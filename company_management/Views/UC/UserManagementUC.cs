using System;
using System.Windows.Forms;
using company_management.Models;
using company_management.Controllers;
using company_management.Views;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace company_management.Views
{
    public partial class UserManagementUC : UserControl
    {
        UserDAO userDAO = new UserDAO();
        static string initPassword = "123";
        static int id = -1;
        private User user;

        public UserManagementUC()
        {
            InitializeComponent();
        }

        private void UserManagementUC_Load(object sender, EventArgs e)
        {          
            userDAO.loadUsers(dataGridView);

        }

        /*private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy chỉ số của dòng hiện tại
            string rowNumber = (e.RowIndex + 1).ToString();

            // Kiểm tra xem có cột STT trong DataGridView không
            if (dataGridView.RowHeadersVisible)
            {
                // Nếu có, thì hiển thị số thứ tự tương ứng với dòng
                dataGridView.Rows[e.RowIndex].HeaderCell.Value = rowNumber;
            }
            else
            {
                // Nếu không, thì thêm cột STT và hiển thị số thứ tự tương ứng với dòng
                dataGridView.Rows[e.RowIndex].Cells[0].Value = rowNumber;
            }
        }*/

        public UserRole GetUserRoleFromString(string inputString)
        {
            UserRole userRole;

            // Nếu chuỗi đầu vào rỗng hoặc null, mặc định giá trị UserRole là Employee
            if (string.IsNullOrEmpty(inputString))
            {
                userRole = UserRole.Employee;
            }
            else
            {
                // Chuyển đổi chuỗi thành UserRole
                if (Enum.TryParse(inputString, out userRole) == false)
                {
                    // Nếu chuỗi không chuyển đổi thành UserRole được, mặc định giá trị UserRole là Employee
                    userRole = UserRole.Employee;
                }
                else
                {
                    userRole = (UserRole)Enum.Parse(typeof(UserRole), inputString); ;
                }
            }
            return userRole;
        }

        private User getUserFromTextBox(User user)
        {
            string selectedRoleString = cbbox_role.SelectedItem?.ToString();
            UserRole userRole = GetUserRoleFromString(selectedRoleString);

            user = new User(id, txtbox_username.Text, initPassword, txtbox_fullname.Text,
                            txtbox_email.Text, txtbox_phoneNumber.Text, txtbox_address.Text, userRole, null);

            return user;
        }

        private bool checkDataInput()
        {
            if (checkEmptyInput())
            {
                if (IsValidEmail(txtbox_email.Text))
                {
                    if (IsPhoneNumber(txtbox_phoneNumber.Text))
                    {
                        return true;
                    }
                    else MessageBox.Show("Invalid phone number!");
                }
                else MessageBox.Show("Invalid email!");
            }
            else MessageBox.Show("Required fields Empty. Please fill in all fields!");
            return false;
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

        private bool checkEmptyInput()
        {
            if (string.IsNullOrEmpty(txtbox_username.Text) || string.IsNullOrEmpty(txtbox_fullname.Text) ||
                string.IsNullOrEmpty(txtbox_email.Text) || string.IsNullOrEmpty(txtbox_phoneNumber.Text) ||
                string.IsNullOrEmpty(txtbox_address.Text))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
           if (checkDataInput())
           {
                userDAO.addUser(getUserFromTextBox(user));
                userDAO.loadUsers(dataGridView);
           }
        }

        private void btnUpdatee_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("demo");
/*            MessageBox.Show(txtbox_username.Text);
            MessageBox.Show(txtbox_fullname.Text);
            MessageBox.Show(txtbox_email.Text);
            MessageBox.Show(txtbox_phoneNumber.Text);
            MessageBox.Show(txtbox_address.Text);
            MessageBox.Show(cbbox_role.Text);*/
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            // Tạo một chuỗi điều kiện để lọc dữ liệu
            StringBuilder filterExpression = new StringBuilder();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // Chỉ áp dụng lọc cho các cột chứa dữ liệu
                if (column.DataPropertyName != null && column.Visible)
                {
                    if (filterExpression.Length > 0)
                    {
                        filterExpression.Append(" OR ");
                    }
                    filterExpression.Append($"[{column.DataPropertyName}] LIKE '%{keyword}%'");
                }
            }

            // Áp dụng chuỗi điều kiện lọc dữ liệu vào DataGridView
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = filterExpression.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Delete user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                userDAO.deleteUser(id);
                userDAO.loadUsers(dataGridView);
            }         
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) // Kiểm tra nếu vị trí được nhấp chuột là tên cột
            {
                dataGridView.ClearSelection(); // Xóa bất kỳ lựa chọn nào trong DataGridView
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = dataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    id = Convert.ToInt32(value);
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    // Hiển thị dữ liệu lên các đối tượng TextBox
                    txtbox_username.Text = row.Cells[1].Value.ToString();
                    txtbox_fullname.Text = row.Cells[3].Value.ToString();
                    txtbox_email.Text = row.Cells[4].Value.ToString();
                    txtbox_phoneNumber.Text = row.Cells[5].Value.ToString();
                    txtbox_address.Text = row.Cells[6].Value.ToString();

                    string selectedValue = row.Cells[7].Value.ToString();

                    // Thêm giá trị vào danh sách các mục của ComboBox
                    if (!cbbox_role.Items.Contains(selectedValue))
                    {
                        cbbox_role.Items.Add(selectedValue);
                    }

                    // Set giá trị của ComboBox
                    cbbox_role.SelectedItem = selectedValue;

                }
            }
        }

    }
}
