using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using company_management.Utilities;

namespace company_management.View
{
    public partial class FormAddTask : Form
    {
        private readonly Lazy<TaskDao> _taskDao;
        private Lazy<UserDao> _userDao;
        private Lazy<TeamDao> _teamDao;
        private Lazy<ImageDao> _imageDao;
        private readonly Lazy<TaskBus> _taskBus;
        private readonly Lazy<ProjectBus> _projectBus;

        public FormAddTask()
        {
            InitializeComponent();
            var utils = new Utils();
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _imageDao = new Lazy<ImageDao>(() => new ImageDao());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _projectBus = new Lazy<ProjectBus>(() => new ProjectBus());
            utils.SetFormShadow(this);
        }

        private void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
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
            this.Hide();
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
                this.Alert("Add successful", FormAlert.enmType.Success);
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
