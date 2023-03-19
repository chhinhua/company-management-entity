using System;
using System.Windows.Forms;
using company_management.Models;

namespace company_management.Views
{
    public partial class LoginForm : Form
    {
        public static User loggedInUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // login process
            // if login cuccessful, create user object and save user info
            //loggedInUser = new User(username, pass, fullname, email, address, role, avt);

            FormMain main = new FormMain();
            this.Hide();
            main.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.Show();
        }

        private void btnForgotpw_Click_1(object sender, EventArgs e)
        {
            VerifyEmailForm verifyEmail = new VerifyEmailForm();
            this.Hide();
            verifyEmail.Show();
        }

   
    }
}
