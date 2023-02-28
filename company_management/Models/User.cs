using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public enum UserRole
    {
        Admin,
        Employee
    }

    public class User
    {
        private int idUser;
        private string username;
        private string password;
        private string fullName;
        private string email;
        private string address;
        private UserRole role;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public UserRole Role { get => role; set => role = value; }

        public User() { }

        public User(string username, string password, string fullName,
                    string email, string address, UserRole role)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            Address = address;
            Role = role;
        }

        public User(int idUser, string username, string password, string fullName, 
                    string email, string address, UserRole role)
        {
            IdUser = idUser;
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            Address = address;
            Role = role;
        }

        public override string ToString() 
            => $"Username: {Username}\nFullName: {FullName}" +
               $"\nEmail: {Email}\nAddress: {Address}\nRole: {Role}%";


    }
}
