using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace company_management.DAO
{
    public class TeamDAO
    {
        private readonly DBConnection dBConnection;
        public Lazy<string> connString;
        private Lazy<UserDAO> userDAO;
        private Lazy<List<Team>> listTeam;

        public TeamDAO()
        {
            dBConnection = new DBConnection();
            connString = new Lazy<string>(() => Properties.Settings.Default.connStr);
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            listTeam = new Lazy<List<Team>>(() => new List<Team>());
        }

        public Team GetTeamById(int id)
        {
            string query = string.Format("SELECT * FROM teams WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<Team>(query);
        }

        public Team GetTeamByLeader(int id)
        {
            string query = string.Format("SELECT * FROM teams WHERE idLeader = {0}", id);
            return dBConnection.GetObjectByQuery<Team>(query);
        }

        public Team GetTeamByTask(Task task)
        {
            Team team = GetTeamById(task.IdTeam);
            if (team != null)
            {
                return team;
            } 
            return null;
            //else
            //{
            //    return GetTeamByLeaderId(task.IdAssignee);
            //}
        }

        public List<User> GetUserInTeam(int idTeam)
        {
            string query = string.Format("select id, fullname, email, phoneNumber, address from users " +
                "where id in (select idUser from user_team " +
                            "where idTeam in (select id from teams " +
                            "                   where idLeader = {0}))", idTeam);
            return dBConnection.GetListObjectsByQuery<User>(query);
        }

        public List<Team> GetAllTeam()
        {
            string query = string.Format("SELECT * FROM teams");
            return dBConnection.GetListObjectsByQuery<Team>(query);
        }

        public void LoadData(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 4;

            dataGridView.Columns[0].Name = "Mã nhóm";
            dataGridView.Columns[0].Width = 40;

            dataGridView.Columns[1].Name = "Tên nhóm";
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Name = "Mô tả nhóm";
            dataGridView.Columns[3].Name = "Trưởng nhóm";
            dataGridView.Rows.Clear();

            // sử lý tên team
            var listTeams = listTeam.Value;
            var userDao = userDAO.Value;
            listTeams = GetAllTeam();

            foreach (var t in listTeams)
            {
                dataGridView.Rows.Add(t.Id, t.Name, t.Description, userDao.GetLeaderByTeam(t).FullName);
            }
        }

        public List<Team> GetTeamsForLeader(int idLeader)
        {
            return GetAllTeam().Where(t => t.IdLeader == idLeader).ToList();
        }

        public List<Team> GetTeamsByUser(int idUser)
        {
            string query = string.Format("SELECT t.* FROM teams t " +
                 "JOIN user_team ut ON t.id = ut.idTeam " +
                 "WHERE ut.idUser = '{0}'", idUser);
            return dBConnection.GetListObjectsByQuery<Team>(query);
        }

        public int CountMembers(int idTeam)
        {
            int result = 0;
        
            string query = string.Format("SELECT COUNT(*) FROM user_team WHERE idTeam='{0}'", idTeam);

            var cnnString = connString.Value;
            using (SqlConnection connection = new SqlConnection(cnnString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    result = (int)command.ExecuteScalar();
                }
                connection.Close();
            }

            return result;
        }
    }
}
