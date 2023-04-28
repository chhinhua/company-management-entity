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
using company_management.Utilities;

namespace company_management.View.UC
{
    public partial class UcTask : UserControl
    {
        public static Task ViewTask;
        private readonly Lazy<TaskBus> _taskBus;
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<List<Task>> _listTask;
        private readonly Lazy<Utils> _utils;

        public UcTask()
        {
            InitializeComponent();
            _listTask = new Lazy<List<Task>>(() => new List<Task>());
            _taskBus = new Lazy<TaskBus>(() => new TaskBus());
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _utils = new Lazy<Utils>(() => new Utils());
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void CheckAddButtonStatus()
        {
            var util = _utils.Value;
            util.CheckEmployeeStatus(buttonAdd);
            util.CheckEmployeeStatus(buttonRemove);
        }

        private void LoadData()
        {
            LoadDataGridview();
            LoadProgressChart();
            CheckAddButtonStatus();
        }

        private void LoadProgressChart()
        {
            var taskDao = _taskDao.Value;
            var taskBus = _taskBus.Value;
            var tasks = _listTask.Value;

            tasks = taskBus.GetListTaskByPosition();
            TaskStatusPercentage taskStatus = taskDao.GetTaskStatusPercentage(tasks);

            double todoPercent = taskStatus.TodoPercent;
            double inprogressPercent = taskStatus.InprogressPercent;
            double donePercent = taskStatus.DonePercent;

            // Định dạng giá trị với 2 chữ số sau dấu thập phân
            string todoPercentFormatted = todoPercent.ToString("0.00");
            string inprogressPercentFormatted = inprogressPercent.ToString("0.00");
            string donePercentFormatted = donePercent.ToString("0.00");

            chart_taskProgress.Series["SeriesProgress"].Points.Clear();

            // Thêm các phần tử vào danh sách
            chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", todoPercent);
            chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", inprogressPercent);
            chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", donePercent);
            // chart_taskProgress.Series["SeriesProgress"].Points[2].LegendText = "Done";

            // Ẩn nhãn trên biểu đồ tròn
            chart_taskProgress.Series["SeriesProgress"].IsValueShownAsLabel = false;

            chart_taskProgress.Legends.Clear();

            chart_taskProgress.Series["SeriesProgress"].Points[0].Color = Color.FromArgb(214, 40, 40);
            chart_taskProgress.Series["SeriesProgress"].Points[1].Color = Color.FromArgb(0, 255, 0);
            chart_taskProgress.Series["SeriesProgress"].Points[2].Color = Color.FromArgb(67, 97, 238);

            label_todoTask.Text = todoPercentFormatted + "%";
            label_inprogressTask.Text = inprogressPercentFormatted + "%";
            label_doneTask.Text = donePercentFormatted + "%";
        }

        private void LoadDataGridview()
        {
            var taskBus = _taskBus.Value;
            var tasks = taskBus.GetListTaskByPosition();
            taskBus.LoadDataGridview(tasks, dataGridView_Task);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        }

        private void dgvTask_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == dataGridView_Task.Columns["progress"].Index)
            {
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);

                // Thêm ký tự % vào header của cột progress
                string headerText = dataGridView_Task.Columns["deadline"].HeaderText.Replace("deadline", "") + "(%)";
                e.Graphics.DrawString(headerText, e.CellStyle.Font, Brushes.Black, e.CellBounds, new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far });

                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddTask addTask = new FormAddTask();
            addTask.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (ViewTask.Id != 0)
            {
                DialogResult result = MessageBox.Show("Delete task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var taskDao = _taskDao.Value;
                    taskDao.DeleteTask(ViewTask.Id);
                    this.Alert("Delete successful", FormAlert.enmType.Success);
                    LoadDataGridview();
                }
            }
            else MessageBox.Show("Task not selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            int clmnCreator = 1;
            int clmnTaskName = 2;
            int clmnAssignee = 3;
            int clmnTeam = 4;

            var taskBus = _taskBus.Value;
            var tasks = _listTask.Value;
            tasks = taskBus.SearchTasksByKeyword(dataGridView_Task, keyword, clmnCreator, clmnTaskName, clmnAssignee, clmnTeam);
            taskBus.LoadDataGridview(tasks, dataGridView_Task);
        }

        private void btnViewOrUpdate_Click(object sender, EventArgs e)
        {
            if (ViewTask != null)
            {
                FormViewOrUpdateTask viewOrUpdate = new FormViewOrUpdateTask();
                viewOrUpdate.Show();
            }
            else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (ViewTask.Id != 0)
            {
                FormViewOrUpdateTask viewOrUpdate = new FormViewOrUpdateTask();
                viewOrUpdate.Show();
            }
            else MessageBox.Show("Select a task to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView_Task_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Task.CurrentRow.Selected = true;

            if (e.RowIndex != -1)
            {
                object value = dataGridView_Task.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    var taskDao = _taskDao.Value;
                    int id = Convert.ToInt32(value);
                    ViewTask = taskDao.GetTaskById(id);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UC_Task_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
