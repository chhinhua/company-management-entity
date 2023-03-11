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

        /*public void getShowUserProfile(int id, string sqlStr)
        {

            connection.Open();

            // Tạo đối tượng SqlCommand
            SqlCommand command = new SqlCommand(sqlStr, connection);

            // Thực thi câu truy vấn SQL và đọc dữ liệu
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Đổ dữ liệu vào các text fiels tương ứng
                    idUser = reader.GetInt32(reader.GetOrdinal("id"));
                    username = reader.GetString(reader.GetOrdinal("username"));
                    password = reader.GetString(reader.GetOrdinal("password"));
                    fullName = reader.GetString(reader.GetOrdinal("fullName"));
                    email = reader.GetString(reader.GetOrdinal("email"));
                    address = reader.GetString(reader.GetOrdinal("address"));
                    role = (UserRole)reader.GetInt32(reader.GetOrdinal("role"));
                    avatar = (byte[])reader["avatar"];

                    // Hiển thị ảnh lên PictureBox
                    if (avatar != null)
                    {
                        using (MemoryStream ms = new MemoryStream(avatar))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
             }
         }*/
    }
        
}

