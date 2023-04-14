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
        private TaskBUS taskBUS;
        public static int DEFAULT_INIT_PROGRESS = 0;

        public AddTaskForm()
        {
            InitializeComponent();
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            taskBUS = new TaskBUS();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                Task task = taskBUS.GetTaskFromTextBox(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee);
                taskDAO.addTask(task);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        }
    }
}
