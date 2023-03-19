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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void AddUC(UserControl Uc)
        {
            Uc.Dock = DockStyle.Fill;

            pn_main.Controls.Clear();
            pn_main.Controls.Add(Uc);

            Uc.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnHome.Location.X, btnHome.Location.Y);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTask.Location.X, btnTask.Location.Y);
            UCTask uCTask = new UCTask();
            AddUC(uCTask);
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnLeaveRequest.Location.X, btnLeaveRequest.Location.Y);
        }

        private void btnKPI_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnKPI.Location.X, btnKPI.Location.Y);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnSalary.Location.X, btnSalary.Location.Y);
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTimekeeping.Location.X, btnTimekeeping.Location.Y);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnUser.Location.X, btnUser.Location.Y);
        }

    }
}
