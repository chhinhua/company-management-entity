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
        private Lazy<ProjectDAO> projectDAO;
        private List<Project> listProject;

        public ProjectBUS()
        {
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            userBUS = new Lazy<UserBUS>(() => new UserBUS());
            projectDAO = new Lazy<ProjectDAO>(() => new ProjectDAO());
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
        public void LoadDataGridview(List<Project> listProject, DataGridView dataGridView)
        {
            var userDao = userDAO.Value;
            var teamDao = teamDAO.Value;

            dataGridView.ColumnCount = 8;
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
            dataGridView.Columns[7].Name = "Mô tả";
            dataGridView.Rows.Clear();

            // sort theo deadline tăng dần
            listProject.Sort((x, y) => DateTime.Compare(x.EndDate, y.EndDate));

            foreach (var t in listProject)
            {
                string creator = userDao.GetUserById(t.IdCreator).FullName;
                string assignee = userDao.GetUserById(t.IdAssignee).FullName;
                string team = teamDao.GetTeamById(t.IdTeam).Name;

                dataGridView.Rows.Add(t.Id, creator, t.Name, t.EndDate.ToString("dd/MM/yyyy"), t.Progress + " %", assignee, team, t.Description);
            }
        }

        public List<Project> GetListProjectByPosition()
        {
            var projectDao = projectDAO.Value;
            var userBus = userBUS.Value;
            var userDao = userDAO.Value;

            string position = userBus.GetUserPosition();

            ClearListProject(listProject);

            if (position.Equals("Manager"))
            {
                listProject = projectDao.GetProjectsCreatedByCurrentUser(UserSession.LoggedInUser.Id);
            }
            else if (position.Equals("Leader"))
            {
                listProject.AddRange(projectDao.GetProjectsCreatedByCurrentUser(UserSession.LoggedInUser.Id));
                listProject.AddRange(projectDao.GetProjectsAssignedByCurrentUser(UserSession.LoggedInUser.Id));
            }
            else
            {
                listProject = projectDao.GetProjectsAssignedByCurrentUser(userDao.GetLeaderByUser(UserSession.LoggedInUser).Id);
            }

            return listProject;
        }
        public void ClearListProject(List<Project> listProject)
        {
            listProject.Clear();
            listProject.TrimExcess();
        }
    }
}
