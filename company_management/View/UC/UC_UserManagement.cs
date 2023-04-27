using System;
using System.Windows.Forms;
using company_management.DTO;
using company_management.DAO;
using company_management.BUS;
using company_management.Utilities;
using company_management.View;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace company_management.View
{
    public partial class UC_UserManagement : UserControl
    {
        private Lazy<UserDAO> userDAO;
        private Lazy<UserBUS> userBUS;
        private Lazy<Utils> utils;
        public int selectedUserId;
        private User user;

        public UC_UserManagement()
        {
            InitializeComponent();
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            userBUS = new Lazy<UserBUS>(() => new UserBUS());
            utils = new Lazy<Utils>(() => new Utils());
            user = new User();
        }

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void UserManagementUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            var userDao = userDAO.Value;
            List<User> listUser = userDao.GetAllUser();
            userDao.loadData(dataGridView_User, listUser);
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
                var util = utils.Value;
                if (util.IsValidEmail(txtbox_email.Text))
                {
                    if (util.IsPhoneNumber(txtbox_phoneNumber.Text))
                    {
                        return true;
                    }
                    else
                    {
                        this.Alert("Invalid phoneNumber!", Form_Alert.enmType.Warning);
                        MessageBox.Show("Invalid phone number!");
                    }
                }
                else
                {
                    this.Alert("Invalid email!", Form_Alert.enmType.Warning);
                    MessageBox.Show("Invalid email!");
                }
            }
            else
            {
                this.Alert("Field required!", Form_Alert.enmType.Warning);
                MessageBox.Show("Required fields Empty. Please fill in all fields!");
            }
                return false;
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId != 0)
            {
                DialogResult result = MessageBox.Show("Delete user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var userDao = userDAO.Value;
                    userDao.DeleteUser(selectedUserId);
                    this.Alert("Delete successful", Form_Alert.enmType.Success);
                    LoadData();
                }
            }
            else MessageBox.Show("User not selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            var userDao = userDAO.Value;
            List<User> listUser = userDao.SearchUsers(keyword);
            userDao.loadData(dataGridView_User, listUser);
        }

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var userDao = userDAO.Value;

                DataGridViewRow selectedRow = dataGridView_User.Rows[e.RowIndex];
                selectedUserId = (int)selectedRow.Cells[0].Value;
                user = userDao.GetUserById(selectedUserId);
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
                var userDao = userDAO.Value;
                if (user == null)
                {
                    userDao.AddUser(GetUserFromTextBox());
                    this.Alert("Add successful", Form_Alert.enmType.Success);
                }
                else
                {
                    userDao.UpdateUser(GetUserEditedUser());
                    this.Alert("Update successful", Form_Alert.enmType.Success);
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
