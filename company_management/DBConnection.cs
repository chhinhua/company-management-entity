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

        public void loadData(DataGridView dataGridView, string tableName)
        {
            try
            {
                connection.Open();
                string sqlStr = string.Format("SELECT * FROM {0}", tableName);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
                dataGridView.Columns["Id"].Visible = false;
                dataGridView.Columns["password"].Visible = false;
                dataGridView.Columns["role"].Visible = false;
                dataGridView.Columns["avatar"].Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
            catch (Exception)
            {
                MessageBox.Show("Failed action");
            }
            finally
            {
                connection.Close();
            }
        }

       
    }

}

