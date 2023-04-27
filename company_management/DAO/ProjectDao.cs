using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using company_management.View;
using company_management.View.UC;
using company_management.BUS;

namespace company_management.DAO
{
    public class ProjectDao
    {
        private readonly DBConnection _dBConnection;
        private readonly Lazy<TeamDao> _teamDao;
        private Lazy<UserDao> _userDao;
        private Lazy<TaskBus> _taskBus;
        private Lazy<List<Project>> _listProject;

        public ProjectDao()
        {
            _dBConnection = new DBConnection();
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _listProject = new Lazy<List<Project>>(() => new List<Project>());
        }

        public void AddProject(Project project)
        {
            string query = string.Format("INSERT INTO project(idCreator, idAssignee, name, description, " +
                   "startDate, endDate, progress, idTeam, bonus)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                   project.IdCreator, project.IdAssignee, project.Name, project.Description,
                   project.StartDate, project.EndDate, project.Progress, project.IdTeam, project.Bonus);
            _dBConnection.ExecuteQuery(query);
        }

        public void LoadTeamToCombobox(ComboBox comboBox)
        {
            var teamDao = _teamDao.Value;
            List<Team> teams;

            // Hiển thị danh sách team cho quản lý chọn
            teams = new List<Team>();
            teams.AddRange(teamDao.GetAllTeam());

            comboBox.Items.AddRange(teams.ToArray());
            comboBox.DisplayMember = "name";

            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = 0;
        }

        private List<Project> GetAllProject()
        {
            string query = string.Format("SELECT * FROM project");
            return _dBConnection.GetListObjectsByQuery<Project>(query);
        }

        public List<Project> GetProjectsCreatedByCurrentUser(int idCreator)
        {
            return GetAllProject().Where(t => t.IdCreator == idCreator).ToList();
        }

        public List<Project> GetProjectsAssignedByCurrentUser(int idAssignee)
        {
            return GetAllProject().Where(t => t.IdAssignee == idAssignee).ToList();
        }

    }
}

