using System;
using System.Windows.Forms;

using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using company_management.Utilities;
// ReSharper disable All

namespace company_management.View
{
    public partial class FormAddTask : Form
    {
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<TaskBus> _taskBus;
        private readonly Lazy<ProjectBus> _projectBus;

        public FormAddTask()
        {
            InitializeComponent();
            var utils = new Utils();
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _projectBus = new Lazy<ProjectBus>(() => new ProjectBus());
            utils.SetFormShadow(this);
        }
        
        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show(@"Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void GetDataToCombobox(ComboBox assignees, ComboBox project)
        {
            var taskDao = _taskDao.Value;
            var projectBus = _projectBus.Value;
            taskDao.LoadUserToCombobox(assignees);
            projectBus.LoadProjectToCombobox(project);
        }

        private void LoadData()
        {
            txtBox_cretor.Text = UserSession.LoggedInUser.FullName;
            GetDataToCombobox(combbox_Assignee, combbox_Project);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                var taskBus = _taskBus.Value;
                var taskDao = _taskDao.Value;
                Task task = taskBus.GetTaskFromTextBox(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, 0, textBox_Bonus.Text, combbox_Project);
                taskDao.AddTask(task);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtbox_taskName.Clear();
            txtbox_Desciption.Clear();
        }

        private void Form_AddTask_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
