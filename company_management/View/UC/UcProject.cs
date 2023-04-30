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
        private readonly Lazy<ProjectDao> _projectDao;
        private int _selectedId;

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
            LoadData(GetData());
        }

        private List<Project> GetData()
        {
            var projectBus = _projectBus.Value;
            return projectBus.GetListProjectByPosition();
        }

        private void LoadData(List<Project> projects)
        {
            LoadDataGridview(projects);
            LoadProgressChart(projects);
            CheckAddButtonStatus();
        }

        private void LoadProgressChart(List<Project> projects)
        {
            var util = _utils.Value;
            util.LoadProgressChart(chart_projectProgress, label_todoProject, label_inprogressProject, label_doneProject, projects);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProject addProject = new FormAddProject();
            addProject.Show();
        }
        
        private void LoadDataGridview(List<Project> listProjects)
        {
            var projectBus = _projectBus.Value;
            projectBus.LoadDataGridview(listProjects, dataGridView_Project);
        }

        private void CheckAddButtonStatus()
        {
            var util = _utils.Value;
            util.CheckManagerVisibleStatus(buttonAdd);
            util.CheckManagerVisibleStatus(buttonRemove);
            util.CheckEmployeeVisibleStatus(button_Edit);
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
            if (_selectedId != 0)
            {
                FormViewOrUpdateProject formProject = new FormViewOrUpdateProject();
                formProject.SetProjectId(_selectedId);
                formProject.Show();
            }
            else MessageBox.Show("Select a project to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = dataGridView_Project.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    _selectedId = Convert.ToInt32(value);
                    MessageBox.Show(_selectedId.ToString());
                }
            }
        }
        
        private void combobox_progressFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectBus = _projectBus.Value;
            var projects = _listProject.Value;
            projects.Clear();
            
            int selectedIndex = combobox_progressFilter.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    projects = projectBus.GetListProjectByPosition();
                    break;
                case 1:
                    projects = projectBus.GetTodoProjects();
                    break;
                case 2:
                    projects = projectBus.GetInprogressProjects();
                    break;
                default:
                    projects = projectBus.GetDoneProjects();
                    break;
            }

            LoadDataGridview(projects);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(GetData());
        }
    }
}