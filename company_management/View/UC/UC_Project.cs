using company_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.BUS;
using company_management.DTO;
using company_management.View;
using company_management.View.UC;
using company_management.Utilities;

namespace company_management.View.UC
{
    public partial class UC_Project : UserControl
    {
        // public static Task viewTask;
        private Lazy<Utils> utils;
        private Lazy<ProjectBUS> projectBUS;
        private Lazy<TaskBUS> taskBUS;
        private Lazy<TaskDAO> taskDAO;
        private Lazy<List<Project>> listProject;

        public UC_Project()
        {
            InitializeComponent();
            //viewTask = new Task();
            utils = new Lazy<Utils>(() => new Utils());
            listProject = new Lazy<List<Project>>(() => new List<Project>());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            projectBUS = new Lazy<ProjectBUS>(() => new ProjectBUS());
        }

        private void UC_Project_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadDataGridview();
            CheckAddButtonStatus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             Form_AddProject addProject = new Form_AddProject();
             addProject.Show();
        }

        
        private void LoadDataGridview()
        {
            var projects = listProject.Value;
            var projectBus = projectBUS.Value;

            projects = projectBus.GetListProjectByPosition();
            projectBus.LoadDataGridview(projects, dataGridView_Project);
        }

        private void CheckAddButtonStatus()
        {
            var util = utils.Value;
            util.CheckManagerStatus(buttonAdd);
            util.CheckManagerStatus(buttonRemove);
            util.CheckEmployeeStatus(button_Edit);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            //if (viewTask != null)
            //{
            Form_ViewOrUpdateProject viewOrUpdate = new Form_ViewOrUpdateProject();
            viewOrUpdate.Show();
            //}
            //else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnViewOrUpdate_Click(object sender, EventArgs e)
        {
            //if (viewTask != null)
            //{
            Form_ViewOrUpdateProject viewOrUpdate = new Form_ViewOrUpdateProject();
            viewOrUpdate.Show();
            //}
            //else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
