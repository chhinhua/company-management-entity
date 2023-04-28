using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using company_management.BUS;
using System.Text.RegularExpressions;
using company_management.View;

namespace company_management.Utilities
{
    public class Utils
    {
        private readonly Lazy<UserBus> _userBus;

        public Utils()
        {
            _userBus = new Lazy<UserBus>(() => new UserBus());
        }

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

        public void CheckEmployeeStatus<T>(T control) where T : Control
        {
            var userBus = _userBus.Value;
            if (userBus.IsEmployee())
            {
                control.Visible = false;
            }
            else
            {
                control.Visible = true;
            }
        }

        public void CheckManagerStatus<T>(T control) where T : Control
        {
            var userBus = _userBus.Value;
            if (userBus.IsManager())
            {
                control.Visible = true;
            }
            else
            {
                control.Visible = false;
            }
        }
        
        public void CheckCalculateSalaryStatus<T>(T control) where T : Control
        {
            var userBus = _userBus.Value;
            if (userBus.IsManager())
            {
                control.Visible = true;
            }
            else
            {
                control.Visible = false;
            }
        }
        public void SetFormShadow(Form form)
        {
            Guna2ShadowForm shadowForm = new Guna2ShadowForm();

            // Set the shadow properties
            shadowForm.SetShadowForm(form);
            shadowForm.ShadowColor = Color.Gray;
            shadowForm.BorderRadius = 20;

            form.Dock = DockStyle.Fill;
            form.Show();
        }
        
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
    }
}
