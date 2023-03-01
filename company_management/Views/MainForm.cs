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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddUC(UserControl Uc)
        {
            Uc.Dock= DockStyle.Fill;

            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(Uc);

            Uc.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CompanyInfoForm companyInfo = new CompanyInfoForm();
            this.Hide();
            companyInfo.Show();
        }
    }
}
