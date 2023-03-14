using System;
using System.Windows.Forms;
using company_management.Models;
using company_management.Controllers;
using company_management.Views;


namespace company_management.Views
{
    public partial class UserManagementUC : UserControl
    {
        UserDAO userDAO = new UserDAO();

        public UserManagementUC()
        {
            InitializeComponent();
        }

        private void UserManagementUC_Load(object sender, EventArgs e)
        {          
            userDAO.loadUser(dataGridView);
        }

       

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }  

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*string selectedRoleString = comboBox_role.SelectedItem.ToString();
          UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), selectedRoleString);

          User user = new User(tbUsername.Text, tbPassword.Text, tbFullname.Text, 
                               tbEmail.Text, tbPhone.Text, tbAddress.Text, selectedRole);          
          userDAO.addUser(user);
          userDAO.loadUser(dataGridView);*/
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void btnUpdatee_Click_1(object sender, EventArgs e)
        {

        }

    
    }
}
