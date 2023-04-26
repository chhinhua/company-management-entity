using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.View
{
    public partial class Form_PasswordChange : Form
    {
        public Form_PasswordChange()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }
    }
}
