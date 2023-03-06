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
    public partial class CompanyInfoForm : Form
    {
        public CompanyInfoForm()
        {
            InitializeComponent();
        }

        private void ptbReturn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }
    }
}
