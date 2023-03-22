using System;
using System.Windows.Forms;
using company_management.Controllers;
using company_management.Models;

namespace company_management.Views
{
    public partial class ViewOrUpdateTaskForm : Form
    {
        TaskDAO taskDAO = new TaskDAO();

        public ViewOrUpdateTaskForm()
        {
            InitializeComponent();
        }

        private void ViewOrUpdateTaskForm_Load(object sender, EventArgs e)
        {
            taskDAO.loadUserToCombobox(combbox_Assignee);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getTaskFromTextBox().ToString());
            if (checkDataInput())
            {
                taskDAO.updateTask(getTaskFromTextBox());
            }
        }

        private Task getTaskFromTextBox()
        {
            int idUser = Convert.ToInt32(combbox_Assignee.SelectedValue);
            DateTime selectedDate = dateTime_deadline.Value;

            Task task = new Task(idUser, txtbox_Username.Text,
                            txtbox_Desciption.Text, selectedDate, CircleProgressBar.Value);
            return task;
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_Username.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Required fields Empty. Please fill in all fields!");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
