using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using company_management.DAO;
using company_management.DTO;
using company_management.Views.UC;
using Guna.UI2.WinForms;

namespace company_management.Views
{
    public partial class ViewOrUpdateTaskForm : Form
    {
        private TaskDAO taskDAO;
        private UserDAO userDAO;
        private ImageDAO imageDAO;

        public ViewOrUpdateTaskForm()
        {
            InitializeComponent();         
            taskDAO = new TaskDAO();
            userDAO = new UserDAO();
            imageDAO = new ImageDAO();
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
            taskDAO.LoadUserToCombobox(combbox_Assignee);
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
            User user = userDAO.GetUserById(id);

            imageDAO.ShowImageInPictureBox(user.Avatar, picturebox_Avatar);

            txtbox_Taskname.Text = UCTask.viewTask.TaskName;
            txtbox_Desciption.Text = UCTask.viewTask.Description;
            combbox_Assignee.SelectedValue = user.Id;
            assigned_value.Text = user.FullName;
            userDAO.DisplayImage(user.Avatar, picturebox_Avatar);

            circleProgressBar.Value = UCTask.viewTask.Progress;
            progressValue.Text = UCTask.viewTask.Progress.ToString() + "%";
            combobox_progress.SelectedText = UCTask.viewTask.Progress.ToString();

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
            if (string.IsNullOrEmpty(txtbox_Taskname.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Required fields Empty. Please fill in all fields!");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circleProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*DialogResult result = MessageBox.Show("Save changed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (result == DialogResult.Yes)
           {
               if (checkDataInput())
               {
                   taskDAO.updateTask(getTaskFromFields());
               }
           }      
            
             */// Chuyển đổi ảnh trong PictureBox thành mảng byte
            byte[] imageBytes = imageDAO.ImageToByte(picturebox_Avatar);

            // Thực hiện lưu ảnh vào cơ sở dữ liệu
            imageDAO.SaveImageToDatabase(imageBytes, UCTask.viewTask.IdAssignee);

            imageDAO.ShowImageInPictureBox(imageBytes, picturebox_Avatar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void combobox_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox_progress.SelectedItem);
            circleProgressBar.Value = progress;
            progressValue.Text = progress.ToString() + "%";
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            imageDAO.ChooseImageToPictureBox(picturebox_Avatar);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
