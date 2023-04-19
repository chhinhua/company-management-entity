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
using company_management.DAO;
using company_management.DTO;

namespace company_management.Views
{
    public partial class FormMain : Form
    {
        private ImageDAO imageDA0;

        public FormMain()
        {
            InitializeComponent();
            imageDA0 = new ImageDAO();
        }

        private void AddUC(UserControl Uc)
        {
            Uc.Dock = DockStyle.Fill;

            pn_main.Controls.Clear();
            pn_main.Controls.Add(Uc);

            Uc.BringToFront();
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
            UCLeaveRequest request = new UCLeaveRequest();
            AddUC(request);
        }

        private void btnKPI_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnKPI.Location.X, btnKPI.Location.Y);
            UC_KPI uckpi = new UC_KPI();
            AddUC(uckpi);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnSalary.Location.X, btnSalary.Location.Y);
            UCSalary uCSalary = new UCSalary();
            AddUC(uCSalary);
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTimekeeping.Location.X, btnTimekeeping.Location.Y);
            UCTimeKeeping timeKeeping = new UCTimeKeeping();
            AddUC(timeKeeping);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnUser.Location.X, btnUser.Location.Y);
            UserManagementUC userManagementUC = new UserManagementUC();
            AddUC(userManagementUC);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            imageDA0.ShowImageInPictureBox(UserSession.LoggedInUser.Avatar, picturebox_avatar);
            UCHome uCHome = new UCHome();
            AddUC(uCHome);
        }

        private void picboxProfile_Click(object sender, EventArgs e)
        {

        }

        private void combobox_profile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void LoadUserControl()
        {
            this.lb_menu_active.Location = new Point(btnUser.Location.X, btnUser.Location.Y);
            UCTask uCTask = new UCTask();
            AddUC(uCTask);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTeam.Location.X, btnTeam.Location.Y);
            UC_Team uC_Team = new UC_Team();
            AddUC(uC_Team);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Teal;
            this.lb_menu_active.Location = new Point(btnHome.Location.X, btnHome.Location.Y);
            UCHome uCHome = new UCHome();
            AddUC(uCHome);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnProject.Location.X, btnProject.Location.Y);
            UC_Project uC_Project = new UC_Project();
            AddUC(uC_Project);
        }
    }
}
