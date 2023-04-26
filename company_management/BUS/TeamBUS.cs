using company_management.DAO;
using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace company_management.BUS
{
    public class TeamBUS
    {
        private Lazy<TeamDAO> teamDAO;
        private Lazy<UserBUS> userBUS;
        private Lazy<UserDAO> userDAO;
        private Lazy<List<Team>> listTeam;

        //public Lazy<string> connString;

        public TeamBUS()
        {
            //connString = new Lazy<string>(() => Properties.Settings.Default.connStr);
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            userBUS = new Lazy<UserBUS>(() => new UserBUS());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            listTeam = new Lazy<List<Team>>(() => new List<Team>());
            
        }
    

    public void LoadDataGridview(List<Team> listTeam, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên team";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].Name = "Mô tả";
            dataGridView.Columns[3].Name = "Trưởng nhóm";
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].Name = "Số thành viên";
            dataGridView.Columns[4].Width = 120;
            dataGridView.Rows.Clear();

            var userDao = userDAO.Value;
            var teamDao = teamDAO.Value;
            foreach (var t in listTeam)
            {
                string leader = userDao.GetUserById(t.IdLeader).FullName;
                int countMembers = teamDao.CountMembers(t.Id);

                dataGridView.Rows.Add(t.Id, t.Name, t.Description, leader, countMembers);
            }
        }

        public List<Team> GetListTeamByManager()
        {
            var teamDao = teamDAO.Value;
            List<Team> listTeam = teamDao.GetAllTeam();
            return listTeam;
        }

        public List<User> GetListUserInTeam(int leaderID)
        {
            var teamDao = teamDAO.Value;
            List<User> listUser = teamDao.GetUserInTeam(leaderID);
            return listUser;
        }

        public List<Team> GetListTeamByPosition()
        {
            var teamDao = teamDAO.Value;
            var userBus = userBUS.Value;
            var teams = listTeam.Value;
            string position = userBus.GetUserPosition();

            if (position.Equals("Manager"))
            {
                teams = teamDao.GetAllTeam();
            }
            else
            {
                teams = teamDao.GetTeamsByUser(UserSession.LoggedInUser.Id);
            }

            return teams;
        }
    }
}
