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
        private TaskDAO taskDAO;
        private UserDAO userDAO;
        private TeamDAO teamDAO;
        private ImageDAO imageDAO;
        private ProjectDAO projectDAO;
        private TaskBUS taskBUS;

        public ViewOrUpdateTaskForm()
        {
            InitializeComponent();         
            taskDAO = new TaskDAO();
            userDAO = new UserDAO();
            teamDAO = new TeamDAO();
            imageDAO = new ImageDAO();
            projectDAO = new ProjectDAO();
            taskBUS = new TaskBUS();
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
            taskBUS.GetDataToCombobox(combbox_Assignee, combbox_Project);
            bindingTaskToFields();
        }

        private Task getTaskFromFields()
        {
            int idUser = Convert.ToInt32(combbox_Assignee.SelectedValue);
            DateTime selectedDate = dateTime_deadline.Value;

            Task task = new Task(idUser, txtbox_Taskname.Text,
                            txtbox_Desciption.Text, selectedDate, circleProgressBar.Value);
            task.Id = UCTask.viewTask.Id;

            return task;
        }

        public void bindingTaskToFields()
        {
            int id = UCTask.viewTask.IdAssignee;
            int idProject = UCTask.viewTask.IdProject;
            User user = userDAO.GetUserById(id);
            Team team = teamDAO.GetTeamById(UCTask.viewTask.IdTeam);

            imageDAO.ShowImageInPictureBox(user.Avatar, picturebox_userAvatar);
            imageDAO.ShowImageInPictureBox(team.Avatar, picturebox_teamAvatar);
            txtbox_Taskname.Text = UCTask.viewTask.TaskName;
            txtbox_Desciption.Text = UCTask.viewTask.Description;
            label_assigneedTeam.Text = teamDAO.GetTeamByTask(UCTask.viewTask).Name;
            textBox_Bonus.Text = UCTask.viewTask.Bonus.ToString();
            label_assigneedPerson.Text = user.FullName;
            combbox_Assignee.SelectedValue = user.Id;            
            circleProgressBar.Value = UCTask.viewTask.Progress;
            progressValue.Text = UCTask.viewTask.Progress.ToString() + "%";
            taskBUS.SelectComboBoxItemByValue(combobox_progress, UCTask.viewTask.Progress);
            taskBUS.SelectComboboxItemById<User>(combbox_Assignee, user.Id);
            taskBUS.SelectComboboxItemById<Project>(combbox_Project, idProject);

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
                int progress = int.Parse(combobox_progress.SelectedItem.ToString());
                Task task = taskBUS.GetTaskFromTextBox(txtbox_Taskname.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee, progress, textBox_Bonus.Text, combbox_Project);
                task.Id = UCTask.viewTask.Id;
                taskDAO.UpdateTask(task);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            imageDAO.ChooseImageToPictureBox(picturebox_teamAvatar);
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = imageDAO.ImageToByte(picturebox_teamAvatar);
            imageDAO.SaveTeamAvatar(imageBytes, UCTask.viewTask.IdTeam);
            imageDAO.ShowImageInPictureBox(imageBytes, picturebox_teamAvatar);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            imageDAO.ChooseImageToPictureBox(picturebox_teamAvatar);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = imageDAO.ImageToByte(picturebox_teamAvatar);
            imageDAO.SaveUserAvatar(imageBytes, 1);
            imageDAO.ShowImageInPictureBox(imageBytes, picturebox_teamAvatar);
        }
    }
}
