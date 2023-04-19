using company_management.DAO;
using company_management.DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace company_management.BUS
{
    internal class TeamBUS
    {
        private TeamDAO teamDAO;
        private UserBUS userBUS;
        private UserDAO userDAO;
        private List<Team> listTeam;

        public TeamBUS()
        {
            teamDAO = new TeamDAO();
            userBUS = new UserBUS();
            userDAO = new UserDAO();
            listTeam = new List<Team>();
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

            foreach (var t in listTeam)
            {
                string leader = userDAO.GetUserById(t.IdLeader).FullName;
                int countMembers = teamDAO.CountMembers(t.Id);

                dataGridView.Rows.Add(t.Id, t.Name, t.Description, leader, countMembers);
            }
        }

        public List<Team> GetListTeamByManager()
        {
            List<Team> listTeam = teamDAO.GetAllTeam();
            return listTeam;
        }

        public List<User> GetListUserInTeam(int leaderID)
        {
            List<User> listUser = teamDAO.GetUserInTeam(leaderID);
            return listUser;
        }

        public List<Team> GetListTeamByPosition()
        {
            string position = userBUS.GetUserPosition();

            if (position.Equals("Manager"))
            {
                listTeam = teamDAO.GetAllTeam();
            }
            else
            {
                listTeam = teamDAO.GetTeamsByCurrentUser(UserSession.LoggedInUser.Id);
            }

            return listTeam;
        }
    }
}
