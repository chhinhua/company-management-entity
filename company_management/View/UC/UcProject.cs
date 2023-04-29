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
        public static Project ViewProject;
        private readonly Lazy<Utils> _utils;
        private readonly Lazy<ProjectBus> _projectBus;
        private readonly Lazy<List<Project>> _listProject;
        private Lazy<TaskBus> _taskBus;
        private Lazy<ProjectDao> _projectDao;

        public UcProject()
        {
            InitializeComponent();
            //viewTask = new Task();
            _utils = new Lazy<Utils>(() => new Utils());
            _listProject = new Lazy<List<Project>>(() => new List<Project>());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _projectDao = new Lazy<ProjectDao>(() => new ProjectDao());
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
            var projectBus = _projectBus.Value;

            var projects = projectBus.GetListProjectByPosition();
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
            if (ViewProject != null)
            {
                FormViewOrUpdateProject viewProject = new FormViewOrUpdateProject();
                viewProject.Show();
            }
            else MessageBox.Show("Select a project to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Project.CurrentRow.Selected = true;

            if (e.RowIndex != -1)
            {
                object value = dataGridView_Project.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    int id = Convert.ToInt32(value);
                    var projectDao = _projectDao.Value;
                    ViewProject = projectDao.GetProjectById(id);
                }
            }
        }
    }
}