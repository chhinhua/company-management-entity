using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DTO;
using company_management.DAO;
using company_management.Views;
using company_management.Views.UC;

namespace company_management.BUS
{
    public class ProjectBUS
    {
        private Lazy<TaskDAO> taskDAO;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<UserBUS> userBUS;
        private Lazy<List<Project>> listProject;

        public ProjectBUS()
        {
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            userBUS = new Lazy<UserBUS>(() => new UserBUS());
            listProject = new Lazy<List<Project>>(() => new List<Project>());
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
    }
}
