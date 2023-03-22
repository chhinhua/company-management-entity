using company_management.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.Models;

namespace company_management.Views.UC
{
    public partial class UCTask : UserControl
    {
        TaskDAO taskDAO = new TaskDAO();
        public static Task task = new Task();

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

            if (e.RowIndex != -1)
            {
                object value = dgvTask.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    int id = Convert.ToInt32(value);
                    task = taskDAO.GetTaskById(id);
                }
            }
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
            if (task.Id != 0)
            {
                DialogResult result = MessageBox.Show("Delete user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    taskDAO.deleteTask(task.Id);
                    taskDAO.loadTasks(dgvTask);
                }
            }
            else MessageBox.Show("Task not selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdatee_Click(object sender, EventArgs e)
        {
            ViewOrUpdateTaskForm viewOrUpdate = new ViewOrUpdateTaskForm();
            viewOrUpdate.Show();
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

        private void dgvTask_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == dgvTask.Columns["progress"].Index)
            {
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);

                // Thêm ký tự % vào header của cột progress
                string headerText = dgvTask.Columns["deadline"].HeaderText.Replace("deadline", "") + "(%)";
                e.Graphics.DrawString(headerText, e.CellStyle.Font, Brushes.Black, e.CellBounds, new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far });

                e.Handled = true;
            }
        }
    }
}
