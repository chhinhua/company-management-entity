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

        public Project GetProjectFromTextBox(string name, string description, DateTimePicker startDate,
            DateTimePicker endDate, ComboBox combbox_Assignee, int progress, string bonus)
        {
            int idCreator = UserSession.LoggedInUser.Id;
            decimal bonusValue = 0;
            if (bonus != "")
            {
                bonusValue = decimal.Parse(bonus);
            }

            Team selectedTeam = (Team)combbox_Assignee.SelectedItem;

            Project project = new Project()
            {
                IdCreator = idCreator,
                IdAssignee = selectedTeam.IdLeader,
                Name = name,
                Description = description,
                StartDate = startDate.Value,
                EndDate = endDate.Value,
                Progress = progress,
                IdTeam = selectedTeam.Id,
                Bonus = bonusValue
            };

            return project;
        }

        public void LoadDataGridview(List<Project> listProject, DataGridView dataGridView)
        {
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;

            dataGridView.ColumnCount = 9;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên Project";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].Name = "Người tạo";
            dataGridView.Columns[3].Name = "Ngày bắt đầu";
            dataGridView.Columns[4].Name = "Deadline";
            dataGridView.Columns[5].Name = "Tiến độ";
            dataGridView.Columns[6].Name = "Người được giao";
            dataGridView.Columns[7].Name = "Team được giao";
            dataGridView.Columns[8].Name = "Bonus";
            dataGridView.Rows.Clear();

            foreach (var p in listProject)
            {
                string creator = userDao.GetUserById(p.IdCreator).FullName;
                string assignee = userDao.GetUserById(p.IdAssignee).FullName;
                string team = teamDao.GetTeamById(p.IdTeam).Name;

                dataGridView.Rows.Add(p.Id, p.Name, creator, p.StartDate.ToString("d/M/yyyy"),
                    p.EndDate.ToString("d/M/yyyy"), p.Progress + " %", assignee, team, p.Bonus.ToString("C"));
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
                projects = projectDao.GetProjectsAssignedByCurrentUser(userDao.GetLeaderByUser(UserSession.LoggedInUser)
                    .Id);
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

            util.CheckEmployeeVisibleStatus(comboBox);
        }

        public List<Project> GetTodoProjects() => GetListProjectByPosition().Where(p => p.Progress == 0).ToList();

        public List<Project> GetInprogressProjects() => GetListProjectByPosition().Where(p => p.Progress > 0 && p.Progress < 100).ToList();

        public List<Project> GetDoneProjects() => GetListProjectByPosition().Where(p => p.Progress == 100).ToList();
        
        public TaskStatusPercentage GetProjectStatusPercentage(List<Project> projects)
        {
            TaskStatusPercentage projectStatus = new TaskStatusPercentage(0, 0, 0);

            if (projects.Count > 0)
            {
                double totalTasks = projects.Count;
                double todoCount = projects.Count(p => p.Progress == 0);
                double inprogressCount = projects.Count(p => p.Progress > 0 && p.Progress < 100);
                double doneCount = projects.Count(p => p.Progress == 100);

                projectStatus.TodoPercent = (todoCount / totalTasks) * 100;
                projectStatus.InprogressPercent = (inprogressCount / totalTasks) * 100;
                projectStatus.DonePercent = (doneCount / totalTasks) * 100;
            }

            return projectStatus;
        }
    }
}