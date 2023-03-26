using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
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
        private string role;
        private byte[] avatar;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }

        public User() { }

        public User(string username, string password, string fullName, 
                    string email, string phoneNumber, string address, string role)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
        }

        public User(int id, string username, string password, string fullName,
                    string email, string phoneNumber, string address, string role, byte[] avatar)
        {
            Id = id;
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
            Avatar = avatar;
        }

        public User(string username, string password, string fullName, 
                    string email, string phoneNumber, string address, string role, byte[] avatar)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
            Avatar = avatar;
        }

        public override string ToString() 
            => $"Username: {Username}\nFullName: {FullName}" +
               $"\nEmail: {Email}\nPhone: {PhoneNumber}" +
               $"\nAddress: {Address}\nRole: {Role}";

    }
}
