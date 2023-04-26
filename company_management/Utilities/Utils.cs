using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace company_management.Utilities
{
    public class Utils
    {

        public bool IsPhoneNumber(string number)
        {
            // Loại bỏ các ký tự trống và dấu gạch ngang
            number = number.Replace(" ", "").Replace("-", "");

            // Kiểm tra chuỗi bắt đầu bằng "+" nếu là số điện thoại quốc tế
            if (number.StartsWith("+"))
            {
                // Chuỗi phải có ít nhất 8 ký tự sau dấu "+"
                return Regex.IsMatch(number.Substring(1), @"^\d{8,}$");
            }
            else
            {
                // Chuỗi phải có ít nhất 10 ký tự và không vượt quá 11 ký tự
                return Regex.IsMatch(number, @"^\d{10,11}$");
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string[] allowedDomains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com" };
                return addr.Address == email && allowedDomains.Any(d => addr.Host.EndsWith(d));
            }
            catch
            {
                return false;
            }
        }
    }
}
