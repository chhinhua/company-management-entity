using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using company_management.BUS;
using company_management.DAO;
using company_management.DTO;
using company_management.Utilities;
using company_management.View.UC;

namespace company_management.View
{
    public partial class FormViewOrUpdateProject : Form
    {
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<ImageDao> _imageDao;
        private readonly Lazy<TaskBus> _taskBus;

        public FormViewOrUpdateProject()
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

        private void LoadData()
        {
            BindingTaskToFields();
        }
        
        private void combobox_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox_progress.SelectedItem);
            circleProgressBar.Value = progress;
            progressValue.Text = progress.ToString() + "%";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        
        private void BindingTaskToFields()
        {
            var taskBus = _taskBus.Value;
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;
            var imageDao = _imageDao.Value;
            Project project = UcProject.ViewProject;

            int idAssignee = project.IdAssignee;
            int idProject = project.Id;
            User assigneeUser = userDao.GetUserById(idAssignee);
            Team assigneeTeam = teamDao.GetTeamById(project.IdTeam);

            imageDao.ShowImageInPictureBox(assigneeUser.Avatar, picturebox_userAvatar2);
            imageDao.ShowImageInPictureBox(assigneeTeam.Avatar, picturebox_teamAvatar2);

            textbox_projectName.Text = project.Name;
            textbox_Desciption.Text = project.Description;
            textBox_projectBonus.Text = project.Bonus.ToString("C");
            
            label2_assigneedTeam.Text = assigneeTeam.Name;
            label2_assignedPerson.Text = assigneeUser.FullName;
            
            circleProgressBar2.Value = project.Progress;
            progressValue2.Text = project.Progress + "%";

            taskBus.SelectComboBoxItemByValue(combobox2_progress, project.Progress);
            try
            {
                dateTime_startDate2.Value = project.StartDate;
                dateTime_startDate2.Value = project.EndDate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void FormViewOrUpdateProject_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
