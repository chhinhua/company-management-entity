using System;
using System.Windows.Forms;
using company_management.DTO;
using company_management.DAO;

namespace company_management.View
{
    public partial class Form_Login : Form
    {
        private UserDAO userDAO;

        public Form_Login()
        {
            InitializeComponent();
            userDAO = new UserDAO();
        }

        private void btnForgotpw_Click_1(object sender, EventArgs e)
        {
            Form_VerifyEmail verifyEmail = new Form_VerifyEmail();
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
                User loginUser;

                // Lấy thông tin người dùng đăng nhập
                // loginUser = userDAO.GetUserByUsername("edalziell2"); // manager
                //loginUser = userDAO.GetUserByUsername("chhinhua"); // manager

                // User loginUser = userDAO.GetUserByUsername("abaldacchinob"); // leader
                loginUser = userDAO.GetUserByUsername("tmccoish4"); // leader
                // loginUser = userDAO.GetUserByUsername("abrilleman6"); // leader
                // loginUser = userDAO.GetUserByUsername("wdionisi7"); // leader
                // loginUser = userDAO.GetUserByUsername("dlaven9"); // leader
                // loginUser = userDAO.GetUserByUsername("linglishc"); // leader

                //loginUser = userDAO.GetUserByUsername("ntute3"); // employee
                // loginUser = userDAO.GetUserByUsername("esparsholtf"); // employee
                // loginUser = userDAO.GetUserByUsername("econstablee"); // employee
                // loginUser = userDAO.GetUserByUsername("walimand"); // employee
                // loginUser = userDAO.GetUserByUsername("mboardera"); // employee
                // loginUser = userDAO.GetUserByUsername("pbartulj"); // employee
                // loginUser = userDAO.GetUserByUsername("taulti"); // employee
                // loginUser = userDAO.GetUserByUsername("dsillyh"); // employee
                // loginUser = userDAO.GetUserByUsername("ipedlerg"); // employee



                // Lưu thông tin người dùng đăng nhập và chuyển sang form chính
                UserSession.LoginUser(loginUser);

                Form_Main main = new Form_Main();
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
