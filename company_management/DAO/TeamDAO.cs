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
        private List<Team> listTeam;

        private SqlConnection connection = new DBConnection().connection;

        public TeamDAO()
        {
            dBConnection = new DBConnection();
            listTeam = new List<Team>();
        }

        public Team GetTeamById(int id)
        {
            string query = string.Format("SELECT * FROM teams WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<Team>(query);
        }
    }
}
