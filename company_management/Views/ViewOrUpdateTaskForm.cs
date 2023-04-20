using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using company_management.Views.UC;
using Guna.UI2.WinForms;

namespace company_management.Views
{
    public partial class ViewOrUpdateTaskForm : Form
    {
        private Lazy<TaskDAO> taskDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<ImageDAO> imageDAO;
        private Lazy<TaskBUS> taskBUS;

        public ViewOrUpdateTaskForm()
        {
            InitializeComponent();
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            imageDAO = new Lazy<ImageDAO>(() => new ImageDAO());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            SetFormShadow(this);
        }

        public static void SetFormShadow(Form form)
        {
            Guna2ShadowForm shadowForm = new Guna2ShadowForm();

            // Set the shadow properties
            shadowForm.SetShadowForm(form);
            shadowForm.ShadowColor = Color.Gray;
            shadowForm.BorderRadius = 20;

            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ViewOrUpdateTaskForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var taskBus = taskBUS.Value;
            taskBus.GetDataToCombobox(combbox_Assignee, combbox_Project);
            bindingTaskToFields();
        }

        public void bindingTaskToFields()
        {
            var taskBus = taskBUS.Value;
            var userDao = userDAO.Value;
            var teamDao = teamDAO.Value;
            var imageDao = imageDAO.Value;

            int id = UCTask.viewTask.IdAssignee;
            int idProject = UCTask.viewTask.IdProject;
            User user = userDao.GetUserById(id);
            Team team = teamDao.GetTeamById(UCTask.viewTask.IdTeam);

            imageDao.ShowImageInPictureBox(user.Avatar, picturebox_userAvatar);
            imageDao.ShowImageInPictureBox(team.Avatar, picturebox_teamAvatar);
            txtbox_Taskname.Text = UCTask.viewTask.TaskName;
            txtbox_Desciption.Text = UCTask.viewTask.Description;
            label_assigneedTeam.Text = teamDao.GetTeamByTask(UCTask.viewTask).Name;
            textBox_Bonus.Text = UCTask.viewTask.Bonus.ToString();
            label_assigneedPerson.Text = user.FullName;
            combbox_Assignee.SelectedValue = user.Id;
            circleProgressBar.Value = UCTask.viewTask.Progress;
            progressValue.Text = UCTask.viewTask.Progress.ToString() + "%";
            taskBus.SelectComboBoxItemByValue(combobox_progress, UCTask.viewTask.Progress);
            taskBus.SelectComboboxItemById<User>(combbox_Assignee, user.Id);
            taskBus.SelectComboboxItemById<Project>(combbox_Project, idProject);

            try
            {
                dateTime_deadline.Value = UCTask.viewTask.Deadline;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_Taskname.Text))
            {
                MessageBox.Show("Required fields Empty. Please fill in all fields!");
                return false;
            }
            return true;
        }

        private void circleProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combobox_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox_progress.SelectedItem);
            circleProgressBar.Value = progress;
            progressValue.Text = progress.ToString() + "%";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        { 
            if (checkDataInput())
            {
                var taskBus = taskBUS.Value;
                var taskDao = taskDAO.Value;

                int progress = int.Parse(combobox_progress.SelectedItem.ToString());
                Task task = taskBus.GetTaskFromTextBox(txtbox_Taskname.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, progress, textBox_Bonus.Text, combbox_Project);
                task.Id = UCTask.viewTask.Id;
                taskDao.UpdateTask(task);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            var imageDao = imageDAO.Value;
            imageDao.ChooseImageToPictureBox(picturebox_teamAvatar);
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            var imageDao = imageDAO.Value;
            byte[] imageBytes = imageDao.ImageToByte(picturebox_teamAvatar);
            imageDao.SaveTeamAvatar(imageBytes, UCTask.viewTask.IdTeam);
            imageDao.ShowImageInPictureBox(imageBytes, picturebox_teamAvatar);
        }
    }
}
