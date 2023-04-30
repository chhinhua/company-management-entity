using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using company_management.View.UC;
using company_management.Utilities;
using Guna.UI2.WinForms;

namespace company_management.View
{
    public partial class FormViewOrUpdateTask : Form
    {
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<ImageDao> _imageDao;
        private readonly Lazy<TaskBus> _taskBus;

        public FormViewOrUpdateTask()
        {
            InitializeComponent();
            var utils = new Utils();
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _imageDao = new Lazy<ImageDao>(() => new ImageDao());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            utils.SetFormShadow(this);
        }

        private void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void LoadData()
        {
            var taskBus = _taskBus.Value;
            taskBus.GetDataToCombobox(combbox_Assignee, combbox_Project);
            BindingTaskToFields();
        }

        private void BindingTaskToFields()
        {
            var taskBus = _taskBus.Value;
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;
            var imageDao = _imageDao.Value;

            int idAssignee = UcTask.ViewTask.IdAssignee;
            int idProject = UcTask.ViewTask.IdProject;
            User assigneeUser = userDao.GetUserById(idAssignee);
            Team assigneeTeam = teamDao.GetTeamById(UcTask.ViewTask.IdTeam);

            imageDao.ShowImageInPictureBox(assigneeUser.Avatar, picturebox_userAvatar);
            imageDao.ShowImageInPictureBox(assigneeTeam.Avatar, picturebox_teamAvatar);

            txtbox_Taskname.Text = UcTask.ViewTask.TaskName;
            txtbox_Desciption.Text = UcTask.ViewTask.Description;
            textBox_Bonus.Text = UcTask.ViewTask.Bonus.ToString(CultureInfo.CurrentCulture);
            
            label_assigneedTeam.Text = assigneeTeam.Name;
            label_assigneedPerson.Text = assigneeUser.FullName;

            circleProgressBar.Value = UcTask.ViewTask.Progress;
            progressValue.Text = UcTask.ViewTask.Progress + @"%";

            taskBus.SelectComboBoxItemByValue(combobox_progress, UcTask.ViewTask.Progress);
            GetSelectedValueToCombobox(taskBus, idProject, assigneeUser, assigneeTeam);
        }

        private void GetSelectedValueToCombobox(TaskBus taskBus, int idProject, User assigneeUser, Team assigneeTeam)
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
                dateTime_deadline.Value = UcTask.ViewTask.Deadline;
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
                this.Alert("Field required", FormAlert.enmType.Warning);
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
                int progress = int.Parse(combobox_progress.SelectedItem.ToString());
                
                var taskBus = _taskBus.Value;
                Task task = taskBus.GetTaskFromTextBox(txtbox_Taskname.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, progress, textBox_Bonus.Text, combbox_Project);
                task.Id = UcTask.ViewTask.Id;
                
                var taskDao = _taskDao.Value;
                taskDao.UpdateTask(task);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            var imageDao = _imageDao.Value;
            imageDao.ChooseImageToPictureBox(picturebox_teamAvatar);
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            var imageDao = _imageDao.Value;
            byte[] imageBytes = imageDao.ImageToByte(picturebox_teamAvatar);
            imageDao.SaveTeamAvatar(imageBytes, UcTask.ViewTask.IdTeam);
            imageDao.ShowImageInPictureBox(imageBytes, picturebox_teamAvatar);
        }

        private void Form_ViewOrUpdateTask_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
