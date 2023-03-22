using System;
using System.Windows.Forms;
using company_management.Controllers;
using company_management.Models;
using company_management.Views.UC;

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
            bindingTaskToFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getTaskFromFields().ToString());
            if (checkDataInput())
            {
                taskDAO.updateTask(getTaskFromFields());
            }
        }

        private Task getTaskFromFields()
        {
            int idUser = Convert.ToInt32(combbox_Assignee.SelectedValue);
            DateTime selectedDate = dateTime_deadline.Value;

            Task task = new Task(idUser, txtbox_Taskname.Text,
                            txtbox_Desciption.Text, selectedDate, circleProgressBar.Value);
            return task;
        }

        public void bindingTaskToFields()
        {
            txtbox_Taskname.Text = UCTask.task.TaskName;
            txtbox_Desciption.Text = UCTask.task.Description;
            dateTime_deadline.Value = UCTask.task.Deadline;
            combbox_Assignee.SelectedValue = UCTask.task.IdUser;
            circleProgressBar.Value = UCTask.task.Progress;
            progressValue.Text = UCTask.task.Progress.ToString() + "%";
            assigned_value.Text = combbox_Assignee.SelectedItem.ToString(); 
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_Taskname.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
