using company_management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management
{
    public class DBConnection
    {
        private readonly SqlConnection connection;

        public DBConnection() => connection = new SqlConnection(Properties.Settings.Default.connStr);

        public void loadData(DataGridView dataGridView, string tableName, string query)
        {
            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void executeQuery(string sqlStr)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, connection);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //MessageBox.Show("Failed action");
            }
            finally
            {
                connection.Close();
            }
        }

       
    }

}

