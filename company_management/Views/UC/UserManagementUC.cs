using System;
using System.Windows.Forms;
using company_management.Models;
using company_management.Controllers;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedRoleString = comboBox_role.SelectedItem.ToString();
            UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), selectedRoleString);


            User user = new User(tbUsername.Text, tbPassword.Text, tbFullname.Text, 
                                 tbEmail.Text, tbAddress.Text, selectedRole);
            MessageBox.Show(user.ToString());
            
            //userDAO.addUser(user);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            userDAO.loadUser(dataGridView);
        }
    }
}
