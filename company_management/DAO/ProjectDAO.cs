using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using company_management.Views;
using company_management.Views.UC;

namespace company_management.DAO
{
    public class ProjectDAO
    {
        private readonly DBConnection dBConnection;
        private TeamDAO teamDAO;
        private UserDAO userDAO;

        public ProjectDAO()
        {
            dBConnection = new DBConnection();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
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
            List<Team> teams;

            // Hiển thị danh sách team cho quản lý chọn
            teams = new List<Team>();
            teams.AddRange(teamDAO.GetAllTeam());

            comboBox.Items.AddRange(teams.ToArray());
            comboBox.DisplayMember = "name";

            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = 0;
        }

        public void LoadProjectToCombobox(ComboBox comboBox)
        {
            List<Project> projects;

            // Hiển thị danh sách team cho quản lý chọn
            projects = new List<Project>();
            projects.AddRange(GetAllProject());

            comboBox.Items.AddRange(projects.ToArray());
            comboBox.DisplayMember = "name";

            comboBox.ValueMember = "id";
            comboBox.SelectedValue = UCTask.viewTask.IdProject;
        }

        public List<Project> GetAllProject()
        {
            string query = string.Format("SELECT * FROM project");
            return dBConnection.GetListObjectsByQuery<Project>(query);
        }
    }
}

