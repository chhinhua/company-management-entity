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
        public SqlConnection connection;

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

        public T GetObjectById<T>(string query) where T : new()
        {
            T obj = default(T);
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    obj = new T();
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        if (reader[prop.Name] != DBNull.Value)
                        {
                            Type propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                            object propValue = Convert.ChangeType(reader[prop.Name], propType);
                            prop.SetValue(obj, propValue);
                        }
                    }
                }
                reader.Close();
            }
            connection.Close();

            return obj;
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
                MessageBox.Show("Acction faild!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


    }

}

