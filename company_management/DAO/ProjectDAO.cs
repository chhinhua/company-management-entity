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
    public class ProjectDAO
    {
        private readonly DBConnection dBConnection;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<TaskBUS> taskBUS;
        private Lazy<List<Project>> listProject;

        public ProjectDAO()
        {
            dBConnection = new DBConnection();
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            listProject = new Lazy<List<Project>>(() => new List<Project>());
        }

        public void AddProject(Project project)
        {
            string query = string.Format("INSERT INTO project(idCreator, idAssignee, name, description, " +
                   "startDate, endDate, progress, idTeam, bonus)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                   project.IdCreator, project.IdAssignee, project.Name, project.Description,
                   project.StartDate, project.EndDate, project.Progress, project.IdTeam, project.Bonus);
            dBConnection.ExecuteQuery(query);
        }

        public void LoadTeamToCombobox(ComboBox comboBox)
        {
            var teamDao = teamDAO.Value;
            List<Team> teams;

            // Hiển thị danh sách team cho quản lý chọn
            teams = new List<Team>();
            teams.AddRange(teamDao.GetAllTeam());

            comboBox.Items.AddRange(teams.ToArray());
            comboBox.DisplayMember = "name";

            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = 0;
        }

        public List<Project> GetAllProject()
        {
            string query = string.Format("SELECT * FROM project");
            return dBConnection.GetListObjectsByQuery<Project>(query);
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

