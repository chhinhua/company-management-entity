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

namespace company_management.Views
{
    public partial class AddTaskForm : Form
    {
        private TaskDAO taskDAO;
        private TeamDAO teamDAO;
        private TaskBUS taskBUS;
        public static int DEFAULT_INIT_PROGRESS = 0;

        public AddTaskForm()
        {
            InitializeComponent();
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            taskBUS = new TaskBUS();
            ViewOrUpdateTaskForm.SetFormShadow(this);
        }

        private bool checkDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show("Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            taskDAO.LoadUserToCombobox(combbox_Assignee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                Task task = taskBUS.GetTaskFromTextBox(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline, combbox_Assignee);
                taskDAO.AddTask(task);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
