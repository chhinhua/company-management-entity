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
using company_management.View;

namespace company_management
{
    public class DBConnection : IDisposable
    {
        public string connString = Properties.Settings.Default.connStr;
        public SqlConnection connection;

        public DBConnection()
        {
            connection = new SqlConnection(connString);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw ex;
            }
            finally
            {
                connection.Close();
            }
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

        public T GetObjectByQuery<T>(string query) where T : class
        {
            using (SqlConnection connection = new SqlConnection(connString)) 
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<T>(query);
                return result;
            }
        }

        public void ExecuteQuery(string sqlStr)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, connection);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        // MessageBox.Show("Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Alert("Successful", Form_Alert.enmType.Success);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                this.Alert("Acction faild!", Form_Alert.enmType.Warning);
                //MessageBox.Show("Acction faild!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Giải phóng các tài nguyên quản lý ở đây.
                if (connection != null)
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close(); // Đóng kết nối nếu đang mở
                    }

                    connection.Dispose(); // Giải phóng kết nối
                    connection = null;
                }
            }
        }

    }

}

