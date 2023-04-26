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

namespace company_management.Views
{
    public partial class AddTaskForm : Form
    {
        private TaskDAO taskDAO;
        private TeamDAO teamDAO;
        private ProjectDAO projectDAO;
        private TaskBUS taskBUS;

        public AddTaskForm()
        {
            InitializeComponent();
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            projectDAO = new ProjectDAO();
            taskBUS = new TaskBUS();
            ViewOrUpdateTaskForm.SetFormShadow(this);
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

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtBox_cretor.Text = UserSession.LoggedInUser.FullName;
            taskDAO.LoadUserToCombobox(combbox_Assignee);
            projectDAO.LoadProjectToCombobox(combbox_Project);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                Task task = taskBUS.GetTaskFromTextBox(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, 0, textBox_Bonus.Text, combbox_Project);
                taskDAO.AddTask(task);
                ClearFields();
            }
        }

        public void ClearFields()
        {
            txtbox_taskName.Clear();
            txtbox_Desciption.Clear();
        }
    }
}
