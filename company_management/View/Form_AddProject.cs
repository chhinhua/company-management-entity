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

namespace company_management.View
{
    public partial class Form_AddProject : Form
    {
        private Lazy<ProjectBUS> projectBUS;
        private Lazy<ProjectDAO> projectDAO;

        public Form_AddProject()
        {
            InitializeComponent();
            projectBUS = new Lazy<ProjectBUS>(() => new ProjectBUS());
            projectDAO = new Lazy<ProjectDAO>(() => new ProjectDAO());
            Form_ViewOrUpdateTask.SetFormShadow(this);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                var projectBus = projectBUS.Value;
                var projectDao = projectDAO.Value;

                Project project = projectBus.GetProjectFromTextBox(txtbox_projectName.Text, txtbox_Desciption.Text,
                                  dateTime_startDate, dateTime_endDate, combbox_AssigneeTeam, 0, textBox_Bonus.Text);
                projectDao.AddProject(project);
                this.Alert("Add successful", Form_Alert.enmType.Success);
                ClearFields();
            }
        }

        private bool CheckDataInput()
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

        private void ClearFields()
        {
            txtbox_projectName.Clear();
            txtbox_Desciption.Clear();
        }

        private void Form_AddProject_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
