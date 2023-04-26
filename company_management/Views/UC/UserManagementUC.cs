using System;
using System.Windows.Forms;
using company_management.DTO;
using company_management.DAO;
using company_management.BUS;
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
        private UserDAO userDAO;
        private UserBUS userBUS;
        public int selectedUserId;
        private User user;

        public UserManagementUC()
        {
            InitializeComponent();
            userDAO = new UserDAO();
            userBUS = new UserBUS();
            user = new User();
        }

        private void UserManagementUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<User> listUser = userDAO.GetAllUser();
            userDAO.loadData(dataGridView_User, listUser);
        }

        private User GetUserFromTextBox()
        {
            return new User(txtbox_username.Text, Constants.DEFAULT_INIT_PASSWORD, txtbox_fullname.Text,
                            txtbox_email.Text, txtbox_phoneNumber.Text, txtbox_address.Text, Constants.DEFAULT_USER_ROLE_ID);
        }

        private User GetUserEditedUser()
        {
            user.Username = txtbox_username.Text;
            user.FullName = txtbox_fullname.Text;
            user.Email = txtbox_email.Text;
            user.PhoneNumber = txtbox_phoneNumber.Text;
            user.Address = txtbox_address.Text;

            return user;
        }

        private bool CheckDataInput()
        {
            if (CheckEmptyInput())
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

        private bool CheckEmptyInput()
        {
            if (string.IsNullOrEmpty(txtbox_username.Text) || string.IsNullOrEmpty(txtbox_fullname.Text) ||
                string.IsNullOrEmpty(txtbox_email.Text) || string.IsNullOrEmpty(txtbox_phoneNumber.Text) ||
                string.IsNullOrEmpty(txtbox_address.Text))
            {
                return false;
            }
            return true;
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) // Kiểm tra nếu vị trí được nhấp chuột là tên cột
            {
                dataGridView_User.ClearSelection(); // Xóa bất kỳ lựa chọn nào trong DataGridView
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            user = null;

            txtbox_username.Clear();
            txtbox_fullname.Clear();
            txtbox_email.Clear();
            txtbox_phoneNumber.Clear();
            txtbox_address.Clear();

            btn_Save.Enabled = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                User user = userDAO.GetUserById(GetUserFromTextBox().Id);
                userDAO.DeleteUser(user.Id);
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            List<User> listUser = userDAO.SearchUsers(keyword);
            userDAO.loadData(dataGridView_User, listUser);
        }

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView_User.Rows[e.RowIndex];
                selectedUserId = (int)selectedRow.Cells[0].Value;
                user = userDAO.GetUserById(selectedUserId);
                btn_Save.Enabled = false;

                object value = dataGridView_User.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    DataGridViewRow row = dataGridView_User.Rows[e.RowIndex];

                    // Hiển thị dữ liệu lên các đối tượng TextBox
                    txtbox_username.Text = row.Cells[1].Value.ToString();
                    txtbox_fullname.Text = row.Cells[2].Value.ToString();
                    txtbox_email.Text = row.Cells[3].Value.ToString();
                    txtbox_phoneNumber.Text = row.Cells[4].Value.ToString();
                    txtbox_address.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (user == null)
                {
                    userDAO.AddUser(GetUserFromTextBox());
                }
                else
                {
                    userDAO.UpdateUser(GetUserEditedUser());
                }
                LoadData();
            }
        }

        private void CheckSaveButton()
        {
            if (user != null)
            {
                if (user.Id != 0)
                {
                    // Và đã có sự thay đổi so với dữ liệu ban đầu thì enable nút Lưu
                    if (txtbox_username.Text != user.Username
                        || txtbox_email.Text != user.Email
                        || txtbox_phoneNumber.Text != user.PhoneNumber
                        || txtbox_fullname.Text != user.FullName
                        || txtbox_address.Text != user.Address)
                    {
                        btn_Save.Enabled = true;
                    }
                    else
                    {
                        btn_Save.Enabled = false;
                    }
                }
                else if (txtbox_username.Text != ""
                    || txtbox_email.Text != ""
                    || txtbox_phoneNumber.Text != ""
                    || txtbox_fullname.Text != ""
                    || txtbox_address.Text != "")
                {
                    btn_Save.Enabled = true;
                }
                else
                {
                    btn_Save.Enabled = false;
                }
            }         
            else
            {
                if (txtbox_username.Text != ""
                    || txtbox_email.Text != ""
                    || txtbox_phoneNumber.Text != ""
                    || txtbox_fullname.Text != ""
                    || txtbox_address.Text != "")
                {
                    btn_Save.Enabled = true;
                }
                else
                {
                    btn_Save.Enabled = false;
                }
            }
        }

        // TextBox changed and leaved event
        private void txtbox_email_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_username_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_fullname_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_phoneNumber_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_address_TextChanged(object sender, EventArgs e) => CheckSaveButton();
    }
}
