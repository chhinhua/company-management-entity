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
        private UserDAO userDAO;
        private List<Team> listTeam;

        private SqlConnection connection = new DBConnection().connection;

        public TeamDAO()
        {
            dBConnection = new DBConnection();
            userDAO = new UserDAO();
            listTeam = new List<Team>();
        }

        public Team GetTeamById(int id)
        {
            string query = string.Format("SELECT * FROM teams WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<Team>(query);
        }

        public Team GetTeamByLeaderId(int id)
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
            listTeam = GetAllTeam();

            foreach (var t in listTeam)
            {
                dataGridView.Rows.Add(t.Id, t.Name, t.Description, userDAO.GetLeaderByTeam(t).FullName);
            }
        }
    }
}
