using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DTO;
using company_management.DAO;
using company_management.View;
using company_management.View.UC;
using company_management.Utilities;

namespace company_management.BUS
{
    public class ProjectBus
    {
        private readonly Lazy<Utils> _utils;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<UserBus> _userBus;
        private readonly Lazy<TaskBus> _taskBus;
        private readonly Lazy<ProjectDao> _projectDao;
        private readonly Lazy<List<Project>> _listProject;

        public ProjectBus()
        {
            _utils = new Lazy<Utils>(() => new Utils());
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _userBus = new Lazy<UserBus>(() => new UserBus());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _projectDao = new Lazy<ProjectDao>(() => new ProjectDao());
            _listProject = new Lazy<List<Project>>(() => new List<Project>());
        }

        public Project GetProjectFromTextBox(string taskName, string description, DateTimePicker startDate,
            DateTimePicker endDate, ComboBox combbox_Assignee, int progress, string bonus)
        {
            Project project = null;
            Team selectesTeam;
            int idAssignee;
            int idCreator = UserSession.LoggedInUser.Id;
            decimal bonusVaue = 0;
            if (bonus != "")
            {
                bonusVaue = decimal.Parse(bonus);
            }

            selectesTeam = (Team)combbox_Assignee.SelectedItem;
            idAssignee = selectesTeam.IdLeader;
            project = new Project(idCreator, idAssignee, taskName,
                        description, startDate.Value, endDate.Value, progress, selectesTeam.Id, bonusVaue);

            return project;
        }
    
        public void LoadDataGridview(List<Project> listProject, DataGridView dataGridView)
        {
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;

            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Người tạo";
            dataGridView.Columns[2].Name = "Tên Project";
            dataGridView.Columns[2].Width = 275;
            dataGridView.Columns[3].Name = "Deadline";
            dataGridView.Columns[4].Name = "Tiến độ";
            dataGridView.Columns[5].Name = "Người được giao";
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[6].Name = "Team được giao";
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Rows.Clear();

            // sort theo deadline tăng dần
            listProject.Sort((x, y) => DateTime.Compare(x.EndDate, y.EndDate));

            foreach (var t in listProject)
            {
                string creator = userDao.GetUserById(t.IdCreator).FullName;
                string assignee = userDao.GetUserById(t.IdAssignee).FullName;
                string team = teamDao.GetTeamById(t.IdTeam).Name;

                dataGridView.Rows.Add(t.Id, creator, t.Name, t.EndDate.ToString("dd/MM/yyyy"), t.Progress + " %", assignee, team);
            }
        }

        public List<Project> GetListProjectByPosition()
        {
            var projects = _listProject.Value;
            var projectDao = _projectDao.Value;
            var userBus = _userBus.Value;
            var userDao = _userDao.Value;

            string position = userBus.GetUserPosition();

            ClearListProject(projects);

            if (position.Equals("Manager"))
            {
                projects = projectDao.GetProjectsCreatedByCurrentUser(UserSession.LoggedInUser.Id);
            }
            else if (position.Equals("Leader"))
            {
                projects.AddRange(projectDao.GetProjectsCreatedByCurrentUser(UserSession.LoggedInUser.Id));
                projects.AddRange(projectDao.GetProjectsAssignedByCurrentUser(UserSession.LoggedInUser.Id));
            }
            else
            {
                projects = projectDao.GetProjectsAssignedByCurrentUser(userDao.GetLeaderByUser(UserSession.LoggedInUser).Id);
            }
            return projects;
        }

        private void ClearListProject(List<Project> listProject)
        {
            listProject.Clear();
            listProject.TrimExcess();
        }

        public void LoadProjectToCombobox(ComboBox comboBox)
        {
            var projects = _listProject.Value;
            var taskBus = _taskBus.Value;
            var util = _utils.Value;

            // Hiển thị danh sách team
            projects = GetListProjectByPosition();

            comboBox.Items.AddRange(projects.ToArray());
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";

            if (UcTask.ViewTask != null)
            {
                comboBox.SelectedValue = UcTask.ViewTask.IdProject;
            }

            util.CheckEmployeeStatus(comboBox);
        }
    }
}
