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
            string query = string.Format("SELECT * FROM {0}", tableName);
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

        public void loadDataControl<T>(T control, string query) where T : Control
        {
            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = dataTable;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = "username";
                    comboBox.ValueMember = "id";
                }
                // Add additional else if statements for other types of controls as needed

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


        public void load(DataGridView dataGridView, string tableName, string query)
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

