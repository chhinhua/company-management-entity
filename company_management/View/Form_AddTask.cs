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

namespace company_management.View
{
    public partial class Form_AddTask : Form
    {
        private Lazy<TaskDAO> taskDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<ImageDAO> imageDAO;
        private Lazy<TaskBUS> taskBUS;
        private Lazy<ProjectBUS> projectBUS;

        public Form_AddTask()
        {
            InitializeComponent();
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            imageDAO = new Lazy<ImageDAO>(() => new ImageDAO());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            projectBUS = new Lazy<ProjectBUS>(() => new ProjectBUS());
            Form_ViewOrUpdateTask.SetFormShadow(this);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private bool checkDataInput()
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
            var taskDao = taskDAO.Value;
            var projectBus = projectBUS.Value;
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
            if (checkDataInput())
            {
                var taskBus = taskBUS.Value;
                var taskDao = taskDAO.Value;
                Task task = taskBus.GetTaskFromTextBox(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, 0, textBox_Bonus.Text, combbox_Project);
                taskDao.AddTask(task);
                this.Alert("Add successful", Form_Alert.enmType.Success);
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
