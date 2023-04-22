using System;
using System.Windows.Forms;
using company_management.DTO;
using company_management.DAO;

namespace company_management.Views
{
    public partial class LoginForm : Form
    {
        public static User loggedInUser;
        private UserDAO userDAO;

        public LoginForm()
        {
            InitializeComponent();
            userDAO = new UserDAO();
        }

        private void btnForgotpw_Click_1(object sender, EventArgs e)
        {
            VerifyEmailForm verifyEmail = new VerifyEmailForm();
            this.Hide();
            verifyEmail.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Kiểm tra thông tin đăng nhập
            if (ValidateLogin(username, password))
            {
                // Lấy thông tin người dùng đăng nhập
                //User loginUser = userDAO.GetUserByUsername("edalziell2"); // manager
                //User loginUser = userDAO.GetUserByUsername("abaldacchinob"); // leader
               // User loginUser = userDAO.GetUserByUsername("ntute3"); // employee
                User loginUser = userDAO.GetUserByUsername("ntute3"); // employee
                //User loginUser = userDAO.GetUserByUsername("wdionisi7"); // leader

                // Lưu thông tin người dùng đăng nhập và chuyển sang form chính
                UserSession.LoginUser(loginUser);

                FormMain main = new FormMain();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
                lbCannotLogin.Visible = true;
                tbUsername.Clear();
                tbPassword.Clear();
            }        
        }

        private bool ValidateLogin(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập ở đây
            // ...
            User loginUser = userDAO.GetUserByUsername(username);
            //if (loginUser == null)
            //    return false;
            //else if (password == loginUser.Password)
            //    return true;
            //else
            //    return false;

            return true;
        }


    }
}
