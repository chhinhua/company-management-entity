using company_management.DTO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using company_management.Utilities;
using company_management.View;
using company_management.Entity;

// ReSharper disable All

namespace company_management.DAO
{
    public sealed class UserDao : IDisposable
    {
        private readonly company_management_Entities _dbContext;
        private readonly DBConnection _dBConnection;
        private readonly IMapper _mapper;
        private readonly Utils _utils;
        private bool _disposed;

        public UserDao()
        {
            _dbContext = new company_management_Entities();
            _dBConnection = new DBConnection();
            _mapper = MapperContainer.GetMapper();
            _utils = new Utils();
        }

        public List<User> GetAllUser()
        {
            var userList = _dbContext.users.ToList();
            return _mapper.Map<List<user>, List<User>>(userList);
        }

        public void LoadData(DataGridView dataGridView, List<User> users)
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
            var userList = _dbContext.users
                .Where(u => u.username.Contains(txtSearch) || u.fullName.Contains(txtSearch) ||
                            u.email.Contains(txtSearch) || u.address.Contains(txtSearch) ||
                            u.phoneNumber.Contains(txtSearch)).ToList();
            return _mapper.Map<List<user>, List<User>>(userList);
        }

        public List<User> GetAllLeader()
        {
            var userList = _dbContext.users.Where(u => u.idPosition == 2).ToList();
            return _mapper.Map<List<user>, List<User>>(userList);
        }

        public List<User> GetAllEmployee()
        {
            var userList = _dbContext.users.Where(u => u.idPosition == 3).ToList();
            return _mapper.Map<List<user>, List<User>>(userList);
        }

        public List<User> GetEmployeesByTeam(int teamId)
        {
            var userList = (
                from u in _dbContext.users
                join ut in _dbContext.user_team on u.id equals ut.idUser
                where ut.idTeam == teamId && u.idPosition == 3
                select u
            ).ToList();
            return _mapper.Map<List<user>, List<User>>(userList);
        }

        public void AddUser(User user)
        {
            try
            {
                var newUser = _mapper.Map<User, user>(user);
                _dbContext.users.Add(newUser);
                _dbContext.SaveChanges();
                _utils.Alert("Thêm người dùng thành công", FormAlert.enmType.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                _utils.Alert("Thêm thất bại!", FormAlert.enmType.Error);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var userToUpdate = _dbContext.users.FirstOrDefault(u => u.id == user.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.username = user.Username;
                    userToUpdate.fullName = user.FullName;
                    userToUpdate.email = user.Email;
                    userToUpdate.phoneNumber = user.PhoneNumber;
                    userToUpdate.address = user.Address;
                    userToUpdate.password = user.Password;
                    _dbContext.SaveChanges();
                    _utils.Alert("Cập nhật thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy người dùng!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Cập nhật thất bại!", FormAlert.enmType.Error);
            }
        }

        public void UpdateUserPassword(User user)
        {
            try
            {
                var userToUpdate = _dbContext.users.FirstOrDefault(u => u.id == user.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.password = user.Password;
                    _dbContext.SaveChanges();
                    _utils.Alert("Cập nhật mật khẩu thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy người dùng!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Đổi không thành công!", FormAlert.enmType.Error);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var user = _dbContext.users.FirstOrDefault(u => u.id == id);
                if (user != null)
                {
                    _dbContext.users.Remove(user);
                    _dbContext.SaveChanges();
                    _utils.Alert("Đã xóa người dùng", FormAlert.enmType.Success);
                }
                else
                    _utils.Alert("Không tìm thấy người dùng!", FormAlert.enmType.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _utils.Alert("Xóa không thành công!", FormAlert.enmType.Error);
            }
        }

        public User GetUserById(int id)
        {
            var user = _dbContext.users.FirstOrDefault(u => u.id == id);
            return _mapper.Map<user, User>(user);
        }

        public User GetUserByUsername(string username)
        {
            var user = _dbContext.users.SingleOrDefault(u => u.username.Equals(username));
            return _mapper.Map<user, User>(user);
        }

        public User GetUserByEmail(string email)
        {
            var user = _dbContext.users.SingleOrDefault(u => u.email.Equals(email));
            return _mapper.Map<user, User>(user);
        }

        public User GetLeaderByTeam(Team team)
        {
            var user = _dbContext.users.SingleOrDefault(u => u.id == team.IdLeader);
            return _mapper.Map<user, User>(user);
        }

        public User GetLeaderByUser(User user)
        {
            var teamId = _dbContext.user_team
                .Where(ut => ut.idUser == user.Id)
                .Select(ut => ut.idTeam)
                .FirstOrDefault();

            if (teamId != null)
            {
                var leader = _dbContext.users
                    .Where(u => u.id == _dbContext.teams
                        .Where(t => t.id == teamId)
                        .Select(t => t.idLeader)
                        .FirstOrDefault())
                    .FirstOrDefault();

                return _mapper.Map<User>(leader);
            }
            else
            {
                return null;
            }
        }

        public List<User> GetListLeader()
        {
            List<User> users = GetAllUser();
            var listLeaderUsers = users.Where(u => u.IdPosition == 2).Distinct().ToList();
            return listLeaderUsers;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Giải phóng tài nguyên được sử dụng trong class
                    _dbContext.Dispose();
                }

                _disposed = true;
            }
        }
    }
}