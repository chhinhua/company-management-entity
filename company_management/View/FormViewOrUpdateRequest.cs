using System;
using System.Windows.Forms;
using company_management.BUS;
using company_management.DAO;
using company_management.DTO;
using company_management.Utilities;
using company_management.View.UC;

namespace company_management.View
{
    public partial class FormViewOrUpdateRequest : Form
    {
        private int _requestId;
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<ImageDao> _imageDao;
        private readonly Lazy<LeaveRequestDao> _requestDao;
        private readonly Lazy<Utils> _utils;

        public FormViewOrUpdateRequest()
        {
            InitializeComponent();
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _imageDao = new Lazy<ImageDao>(() => new ImageDao());
            _requestDao = new Lazy<LeaveRequestDao>(() => new LeaveRequestDao());
            _utils = new Lazy<Utils>(() => new Utils());
        }

        public void SetRequestId(int id) => _requestId = id;

        private void BindingTaskToFields()
        {
            var requestDao = _requestDao.Value;
            LeaveRequest request = requestDao.GetRequestById(_requestId);

            var userDao = _userDao.Value;
            User writer = userDao.GetUserById(request.IdUser);
            User approver = userDao.GetUserById(request.IdApprover);
            
            var imageDao = _imageDao.Value;
            imageDao.ShowImageInPictureBox(writer.Avatar, picturebox_writer);
            
            if (approver != null)
            {
                label_approver.Text = approver.FullName;
                imageDao.ShowImageInPictureBox(approver.Avatar, picturebox_approver);
            }
            
            label_writer.Text = writer.FullName;
            label_status.Text = request.Status;
            txtbox_content.Text = request.Content;
            datetime_requestDate.Value = request.RequestDate;
            datetime_startDate.Value = request.StartDate;
            datetime_endDate.Value = request.EndDate;
        }
        
        private void LoadData()
        {
            var requestDao = _requestDao.Value;
            LeaveRequest request = requestDao.GetRequestById(_requestId);
            CheckControlStatus(request);
            BindingTaskToFields();
        }

        private void CheckControlStatus(LeaveRequest request)
        {
            var util = _utils.Value;
            util.CheckCancelMyRequestStatus(button_Cancel, request.Status, request.IdUser);
            util.CheckManagerVisibleStatus(combobox_status);
        }

        private void FormViewOrUpdateRequest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}