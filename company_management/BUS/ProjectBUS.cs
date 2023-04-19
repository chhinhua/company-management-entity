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
        private TaskDAO taskDAO;
        private TeamDAO teamDAO;
        private UserDAO userDAO;
        private UserBUS userBUS;
        private List<Project> listProject;

        public ProjectBUS()
        {
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
            userBUS = new UserBUS();
            listProject = new List<Project>();
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
