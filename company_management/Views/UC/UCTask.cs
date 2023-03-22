using company_management.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.Views.UC
{
    public partial class UCTask : UserControl
    {
        TaskDAO taskDAO = new TaskDAO();
        public UCTask()
        {
            InitializeComponent();
        }

        private void UCTask_Load(object sender, EventArgs e)
        {
            taskDAO.loadTasks(dgvTask);
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTask.CurrentRow.Selected = true;
        }

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatee_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            // Tạo một chuỗi điều kiện để lọc dữ liệu
            StringBuilder filterExpression = new StringBuilder();
            foreach (DataGridViewColumn column in dgvTask.Columns)
            {
                // Chỉ áp dụng lọc cho các cột chứa dữ liệu và không phải cột deadline
                if (column.DataPropertyName != null && column.Visible && column.Name != "deadline" && column.Name != "progress")
                {
                    if (filterExpression.Length > 0)
                    {
                        filterExpression.Append(" OR ");
                    }
                    filterExpression.Append($"[{column.DataPropertyName}] LIKE '%{keyword}%'");
                }
            }

            // Áp dụng chuỗi điều kiện lọc dữ liệu vào DataGridView
            (dgvTask.DataSource as DataTable).DefaultView.RowFilter = filterExpression.ToString();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
