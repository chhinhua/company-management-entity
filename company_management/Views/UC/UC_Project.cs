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

namespace company_management.Views.UC
{
    public partial class UC_Project : UserControl
    {
        public static Task viewTask;
        private Lazy<TaskBUS> taskBUS;
        private Lazy<TaskDAO> taskDAO;
        private Lazy<List<Task>> listTask;

        public UC_Project()
        {
            InitializeComponent();
            viewTask = new Task();
            listTask = new Lazy<List<Task>>(() => new List<Task>());
            taskBUS = new Lazy<TaskBUS>(() => new TaskBUS());
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());          
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             frmAddProject addProject = new frmAddProject();
             addProject.Show();
        }

        private void UC_Project_Load(object sender, EventArgs e)
        {
        }
    }
}
