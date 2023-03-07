using company_management.Views.UC;
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
            LoginForm flogin = new LoginForm();
            this.Hide();
            flogin.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CompanyInfoForm fcompanyInfo = new CompanyInfoForm();
            this.Hide();
            fcompanyInfo.Show();
        }

        private void btnLeavereq_Click(object sender, EventArgs e)
        {
            UCLeaveRequestManagement ucLRM = new UCLeaveRequestManagement();
            AddUC(ucLRM);
        }

        private void ptbProfile_Click(object sender, EventArgs e)
        {
            cbbprofile.DroppedDown= true;
        }


        private void btnCheckin_Click(object sender, EventArgs e)
        {
            UCTimeKeeping ucTimeKeeping = new UCTimeKeeping();
            AddUC(ucTimeKeeping);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            UCTask ucTask = new UCTask();
            AddUC(ucTask);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            UCSalary ucSalary = new UCSalary();
            AddUC(ucSalary);
        }

        private void btnKpi_Click(object sender, EventArgs e)
        {
            UC_KPI uc_KPI = new UC_KPI();
            AddUC(uc_KPI);
        }
    }
}
