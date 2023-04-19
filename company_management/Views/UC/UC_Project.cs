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
        private List<Task> listTask;
        private TaskBUS taskBUS;
        private TaskDAO taskDAO;
        public static Task viewTask;

        public UC_Project()
        {
            InitializeComponent();
            listTask = new List<Task>();
            taskBUS = new TaskBUS();
            taskDAO = new TaskDAO();
            viewTask = new Task();
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
