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

namespace company_management.Views
{
    public partial class AddTaskForm : Form
    {
        TaskDAO taskDAO= new TaskDAO();
        public static int DEFAULT_INIT_PROGRESS = 0;

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                taskDAO.addTask(getTaskFromTextBox());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Task getTaskFromTextBox()
        {        
            User selectesUser = (User)combbox_Assignee.SelectedItem;

            int idCreator = UserSession.LoggedInUser.Id;
            int idAssignee = selectesUser.Id;
            DateTime selectedDate = dateTime_deadline.Value;

            Task task = new Task(idCreator, idAssignee, txtbox_taskName.Text, 
                            txtbox_Desciption.Text, selectedDate, DEFAULT_INIT_PROGRESS);
            return task;
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Required fields Empty. Please fill in all fields!");
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
            taskDAO.LoadUserToCombobox(combbox_Assignee);
        }

        private void combbox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAssignee = Convert.ToInt32(combbox_Assignee.SelectedValue);
            MessageBox.Show(idAssignee.ToString());
        }
    }
}
