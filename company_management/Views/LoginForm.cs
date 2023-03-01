using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        private void btnForgotpw_Click(object sender, EventArgs e)
        {
            VerifyEmailForm verifyEmail = new VerifyEmailForm();
            this.Hide();
            verifyEmail.Show();
        }
    }
}
