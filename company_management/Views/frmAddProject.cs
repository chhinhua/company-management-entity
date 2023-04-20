using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using company_management.DAO;
using company_management.DTO;
using company_management.BUS;
using System.Data.SqlClient;

namespace company_management.Views
{
    public partial class frmAddProject : Form
    {
        private Lazy<ProjectBUS> projectBUS;
        private Lazy<ProjectDAO> projectDAO;

        public frmAddProject()
        {
            InitializeComponent();
            projectBUS = new Lazy<ProjectBUS>(() => new ProjectBUS());
            projectDAO = new Lazy<ProjectDAO>(() => new ProjectDAO());
            ViewOrUpdateTaskForm.SetFormShadow(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                var projectBus = projectBUS.Value;
                var projectDao = projectDAO.Value;

                Project project = projectBus.GetProjectFromTextBox(txtbox_projectName.Text, txtbox_Desciption.Text,
                                  dateTime_startDate, dateTime_endDate, combbox_AssigneeTeam, 0, textBox_Bonus.Text);
                projectDao.AddProject(project);
                ClearFields();
            }
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_projectName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadData()
        {
            var projectDao = projectDAO.Value;
            projectDao.LoadTeamToCombobox(combbox_AssigneeTeam);
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void ClearFields()
        {
            txtbox_projectName.Clear();
            txtbox_Desciption.Clear();
        }
    }
}
