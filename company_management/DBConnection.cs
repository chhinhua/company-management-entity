using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using NLog.Fluent;

namespace company_management
{
    public class DBConnection
    {
        public SqlConnection connection;
        private string connString = Properties.Settings.Default.connStr;

        public DBConnection() => connection = new SqlConnection(connString);

        public DataTable LoadData(string tableName)
        {
            string query = string.Format("SELECT * FROM {0}", tableName);
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public List<T> GetListObjectsByQuery<T>(string query) where T : class
        {
            List<T> objects = new List<T>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    objects = connection.Query<T>(query).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không lấy được dữ liệu");
                    Console.WriteLine(ex.ToString());
                    throw; 
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }

            return objects;
        }

        public DataTable SearchData(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public T GetObjectByQuery<T>(string query) where T : class
        {
            using (SqlConnection connection = new SqlConnection(connString)) 
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<T>(query);
                return result;
            }
        }

        public void loadUserToCombobox<T>(T control, string query) where T : Control
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
                    comboBox.DisplayMember = "fullName";
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
                    MessageBox.Show("Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //MessageBox.Show("Acction faild!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}

