using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string fullName;
        private string email;
        private string phoneNumber;
        private string address;
        private byte[] avatar;
        private int idRole;
        private int idPosition;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public int IdRole { get => idRole; set => idRole = value; }
        public int IdPosition { get => idPosition; set => idPosition = value; }

        public User() { }

        // Dành cho User cập nhật thông tin tài khoản
        public User(string username, string password, string fullName, 
            string email, string phoneNumber, string address, byte[] avatar, int idRole)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Avatar = avatar;
            IdRole = idRole;
        }

        // Dành cho Admin tài khoản thêm
        public User(string username, string password, string fullName,
           string email, string phoneNumber, string address, int idRole)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            IdRole = idRole;
        }

        // Signup 
        public User(string username, string password, string fullName, string email)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
        }
    }
}
