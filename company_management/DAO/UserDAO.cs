using company_management.DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace company_management.DAO
{
    public class UserDAO
    {
        private readonly DBConnection dBConnection;
        private List<User> listUser;

        public UserDAO()
        {
            dBConnection = new DBConnection();
            listUser = new List<User>();
        }

        public List<User> GetAllUser()
        {
            DataTable dataTable = dBConnection.LoadData("users");
            return MapToListUser(dataTable);
        }

        public void loadData(DataGridView dataGridView, List<User> users) 
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên tài khoản";
            dataGridView.Columns[2].Name = "Họ và tên";
            dataGridView.Columns[3].Name = "Email";
            dataGridView.Columns[4].Name = "Số điện thoại";
            dataGridView.Columns[5].Name = "Địa chỉ";
            dataGridView.Rows.Clear();

            foreach (var x in users)
            {
                dataGridView.Rows.Add(x.Id, x.Username, x.FullName, x.Email, x.PhoneNumber, x.Address);
            }
        }

        public List<User> SearchUsers(string txtSearch)
        {
            string query = string.Format("SELECT * FROM users WHERE username like '%{0}%' OR fullName like '%{0}%' " +
                "OR email like '%{0}%' OR address like '%{0}%' OR phoneNumber like '%{0}%'", txtSearch);

            DataTable dataTable = dBConnection.SearchData(query);       
            
            return MapToListUser(dataTable);
        }

        private List<User> MapToListUser(DataTable dataTable)
        {
            listUser = dataTable.AsEnumerable()
                            .Select(row => new User
                            {
                                Id = row.Field<int>("id"),
                                Username = row.Field<string>("username"),
                                Password = row.Field<string>("password"),
                                FullName = row.Field<string>("fullName"),
                                Email = row.Field<string>("email"),
                                PhoneNumber = row.Field<string>("phoneNumber"),
                                Address = row.Field<string>("address"),
                                Avatar = row.Field<byte[]>("avatar"),
                                IdRole = row.Field<int>("idRole")
                            }).ToList();

            return listUser;
        }

        public List<User> GetAllLeader()
        {
            string query = string.Format("SELECT * FROM users WHERE users.idPosition = 2");
            listUser = dBConnection.GetListObjectsByQuery<User>(query);
            return listUser.ToList();
        }

        public List<User> GetAllEmployee()
        {
            string query = string.Format("SELECT * FROM users WHERE users.idPosition = 3");
            return dBConnection.GetListObjectsByQuery<User>(query).ToList();
        }

        public void AddUser(User user)
        {         
            string sqlStr = string.Format("INSERT INTO users(username, password, fullname, email, phoneNumber, address, idRole)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   user.Username, user.Password, user.FullName, user.Email, user.PhoneNumber, user.Address, user.IdRole);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public void UpdateUser(User user)
        {
            string sqlStr = string.Format("UPDATE users SET " +
                   "username = '{0}', fullname = '{1}', email = '{2}', phoneNumber = '{3}', address = '{4}', password = '{5}' WHERE id = '{6}'",
                   user.Username, user.FullName, user.Email, user.PhoneNumber, user.Address, user.Password, user.Id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public void DeleteUser(int id)
        {
            string sqlStr = string.Format("DELETE FROM users WHERE id = '{0}'", id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public User GetUserById(int id)
        {
            string query = string.Format("SELECT * FROM users WHERE users.id = {0}", id);
            return dBConnection.GetObjectByQuery<User>(query);
        }

        public User GetUserByUsername(string username)
        {
            string query = string.Format("SELECT * FROM users WHERE users.username = '{0}'", username);
            return dBConnection.GetObjectByQuery<User>(query);
        }

        public User GetLeaderByTeam(Team team)
        {
            string query = string.Format("SELECT * FROM users WHERE users.id = '{0}'", team.IdLeader);
            return dBConnection.GetObjectByQuery<User>(query);
        }

        public List<User> GetListLeader()
        {
             List<User> users = GetAllUser();
             var listLeaderUsers = users.Where(u => u.IdPosition == 2)
                              .Distinct()
                              .ToList();
            return listLeaderUsers;
        }

        public void DisplayImage(byte[] avatarBytes, PictureBox pictureBox)
        {
            if (avatarBytes == null || avatarBytes.Length == 0)
            {
                return;
            }

            // Tạo một MemoryStream để đọc mảng byte
            using (var ms = new MemoryStream(avatarBytes))
            {
                var image = Image.FromStream(ms);
                pictureBox.Image = image;
            }
        }

    }
}
