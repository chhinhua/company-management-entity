using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using company_management.View.UC;
using Guna.UI2.WinForms;

namespace company_management.View
{
    public partial class Form_ViewOrUpdateTask : Form
    {
        private Lazy<TaskDAO> taskDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<ImageDAO> imageDAO;
        private Lazy<TaskBUS> taskBUS;

        public Form_ViewOrUpdateTask()
        {
            InitializeComponent();
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            imageDAO = new Lazy<ImageDAO>(() => new ImageDAO());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            SetFormShadow(this);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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

            int idAssignee = UC_Task.viewTask.IdAssignee;
            int idProject = UC_Task.viewTask.IdProject;
            User assigneeUser = userDao.GetUserById(idAssignee);
            Team assigneeTeam = teamDao.GetTeamById(UC_Task.viewTask.IdTeam);

            imageDao.ShowImageInPictureBox(assigneeUser.Avatar, picturebox_userAvatar);
            imageDao.ShowImageInPictureBox(assigneeTeam.Avatar, picturebox_teamAvatar);

            txtbox_Taskname.Text = UC_Task.viewTask.TaskName;
            txtbox_Desciption.Text = UC_Task.viewTask.Description;
            textBox_Bonus.Text = UC_Task.viewTask.Bonus.ToString();
            
            label_assigneedTeam.Text = assigneeTeam.Name;
            label_assigneedPerson.Text = assigneeUser.FullName;

            //combbox_Assignee.SelectedValue = assigneeUser.Id;
            circleProgressBar.Value = UC_Task.viewTask.Progress;
            progressValue.Text = UC_Task.viewTask.Progress.ToString() + "%";

            taskBus.SelectComboBoxItemByValue(combobox_progress, UC_Task.viewTask.Progress);
            GetSelectedValueToCombobox(taskBus, idProject, assigneeUser, assigneeTeam);
        }

        private void GetSelectedValueToCombobox(TaskBUS taskBus, int idProject, User assigneeUser, Team assigneeTeam)
        {
            if (UserSession.LoggedInUser.IdPosition == 1)
            {
                taskBus.SelectComboboxItemById<Team>(combbox_Assignee, assigneeTeam.Id);
            }
            else if (UserSession.LoggedInUser.IdPosition == 2)
            {
                taskBus.SelectComboboxItemById<User>(combbox_Assignee, assigneeUser.Id);
            }
            taskBus.SelectComboboxItemById<Project>(combbox_Project, idProject);

            try
            {
                dateTime_deadline.Value = UC_Task.viewTask.Deadline;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_Taskname.Text))
            {
                this.Alert("Field required", Form_Alert.enmType.Warning);
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
            if (CheckDataInput())
            {
                var taskBus = taskBUS.Value;
                var taskDao = taskDAO.Value;

                int progress = int.Parse(combobox_progress.SelectedItem.ToString());
                Task task = taskBus.GetTaskFromTextBox(txtbox_Taskname.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, progress, textBox_Bonus.Text, combbox_Project);
                task.Id = UC_Task.viewTask.Id;
                taskDao.UpdateTask(task);
                this.Alert("Update successful", Form_Alert.enmType.Success);
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
            imageDao.SaveTeamAvatar(imageBytes, UC_Task.viewTask.IdTeam);
            imageDao.ShowImageInPictureBox(imageBytes, picturebox_teamAvatar);
        }

        private void Form_ViewOrUpdateTask_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
