using company_management.DAO;
using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace company_management.BUS
{
    public class TeamBus
    {
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<UserBus> _userBus;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<List<Team>> _listTeam;

        //public Lazy<string> connString;

        public TeamBus()
        {
            //connString = new Lazy<string>(() => Properties.Settings.Default.connStr);
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _userBus = new Lazy<UserBus>(() => new UserBus());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _listTeam = new Lazy<List<Team>>(() => new List<Team>());
        }

        public void LoadDataGridview(List<Team> listTeam, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên nhóm";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].Name = "Trưởng nhóm";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].Name = "Mô tả nhóm";
            dataGridView.Columns[4].Name = "Số thành viên";
            dataGridView.Columns[4].Width = 120;
            dataGridView.Rows.Clear();

            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;
            foreach (var t in listTeam)
            {
                string leader = userDao.GetUserById(t.IdLeader).FullName;
                int countMembers = teamDao.CountMembers(t.Id);

                dataGridView.Rows.Add(t.Id, t.Name, leader, t.Description, countMembers);
            }
        }

        public List<Team> GetListTeamByManager()
        {
            var teamDao = _teamDao.Value;
            List<Team> listTeam = teamDao.GetAllTeam();
            return listTeam;
        }

        public List<User> GetListUserInTeam(int leaderID)
        {
            var teamDao = _teamDao.Value;
            List<User> listUser = teamDao.GetUserInTeam(leaderID);
            return listUser;
        }

        public List<Team> GetListTeamByPosition()
        {
            var teamDao = _teamDao.Value;
            var userBus = _userBus.Value;
            var teams = _listTeam.Value;
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
