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
    public partial class VerifyEmailForm : Form
    {
        public VerifyEmailForm()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            PasswordChangeForm passwordChange = new PasswordChangeForm();
            this.Hide();
            passwordChange.Show();
        }
    }
}
