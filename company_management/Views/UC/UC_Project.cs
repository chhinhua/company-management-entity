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
using company_management.Views;
using company_management.Views.UC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace company_management.Views.UC
{
    public partial class UC_Project : UserControl
    {
        public static Task viewTask;
        private TaskBUS taskBUS;
        private TaskDAO taskDAO;
        private ProjectBUS projectBUS;
        private List<Project> listProject;

        public UC_Project()
        {
            InitializeComponent();
            listProject = new List<Project>();
            taskBUS = new TaskBUS();
            taskDAO = new TaskDAO();
            viewTask = new Task();
            projectBUS = new ProjectBUS();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             frmAddProject addProject = new frmAddProject();
             addProject.Show();
        }

        private void UC_Project_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            listProject = projectBUS.GetListProjectByPosition();
            projectBUS.LoadDataGridview(listProject, dataGridView_Project);
        }
    }
}
