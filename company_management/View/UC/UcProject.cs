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
    public partial class UcProject : UserControl
    {
        // public static Task viewTask;
        private readonly Lazy<Utils> _utils;
        private readonly Lazy<ProjectBus> _projectBus;
        private readonly Lazy<List<Project>> _listProject;
        private Lazy<TaskBus> _taskBus;
        private Lazy<TaskDao> _taskDao;
        
        public UcProject()
        {
            InitializeComponent();
            //viewTask = new Task();
            _utils = new Lazy<Utils>(() => new Utils());
            _listProject = new Lazy<List<Project>>(() => new List<Project>());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _projectBus = new Lazy<ProjectBus>(() => new ProjectBus());
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
             FormAddProject addProject = new FormAddProject();
             addProject.Show();
        }

        
        private void LoadDataGridview()
        {
            var projects = _listProject.Value;
            var projectBus = _projectBus.Value;

            projects = projectBus.GetListProjectByPosition();
            projectBus.LoadDataGridview(projects, dataGridView_Project);
        }

        private void CheckAddButtonStatus()
        {
            var util = _utils.Value;
            util.CheckManagerStatus(buttonAdd);
            util.CheckManagerStatus(buttonRemove);
            util.CheckEmployeeStatus(button_Edit);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            //if (viewTask != null)
            //{
            FormViewOrUpdateProject viewOrUpdate = new FormViewOrUpdateProject();
            viewOrUpdate.Show();
            //}
            //else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnViewOrUpdate_Click(object sender, EventArgs e)
        {
            //if (viewTask != null)
            //{
            FormViewOrUpdateProject viewOrUpdate = new FormViewOrUpdateProject();
            viewOrUpdate.Show();
            //}
            //else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
