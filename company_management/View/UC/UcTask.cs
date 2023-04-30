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
        
        private void CheckAddButtonStatus()
        {
            var util = _utils.Value;
            util.CheckEmployeeVisibleStatus(buttonAdd);
            util.CheckEmployeeVisibleStatus(buttonRemove);
        }

        private List<Task> GetData()
        {
            var taskBus = _taskBus.Value;
            return taskBus.GetListTaskByPosition();
        }
        
        private void LoadData(List<Task> tasks)
        {
            LoadDataGridview(tasks);
            LoadProgressChart(tasks);
            CheckAddButtonStatus();
        }

        private void LoadProgressChart(List<Task> tasks)
        {
            var util = _utils.Value;
            util.LoadProgressChart(chart_taskProgress, label_todoTask, label_inprogressTask, label_doneTask, tasks);
        }

        private void LoadDataGridview(List<Task> tasks)
        {
            var taskBus = _taskBus.Value;
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
                    var util = _utils.Value;
                    taskDao.DeleteTask(ViewTask.Id);
                    util.Alert("Delete successful", FormAlert.enmType.Success);
                    LoadData(GetData());
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
            LoadData(GetData());
        }

        private void UC_Task_Load(object sender, EventArgs e)
        {
            LoadData(GetData());
        }

        private void combobox_taskStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taskBus = _taskBus.Value;
            var tasks = _listTask.Value;
            tasks.Clear();
            
            int selectedIndex = combobox_taskStatusFilter.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    tasks = taskBus.GetListTaskByPosition();
                    break;
                case 1:
                    tasks = taskBus.GetMyCreatedTasks();
                    break;
                default:
                    tasks = taskBus.GetMyTasks();
                    break;
            }

            LoadData(tasks);
        }


        private void combobox_taskProgressFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taskBus = _taskBus.Value;
            var tasks = _listTask.Value;
            tasks.Clear();
            
            int selectedIndex = combobox_taskProgressFilter.SelectedIndex;
            switch (selectedIndex)
            {
                case 1:
                    tasks = taskBus.GetListTaskByPosition();
                    break;
                case 2:
                    tasks = taskBus.GetTodoTasks();
                    break;
                case 3:
                    tasks = taskBus.GetInprogressTasks();
                    break;
                case 4:
                    tasks = taskBus.GetDoneTasks();
                    break;
                default:
                    tasks = taskBus.GetListTaskByPosition();
                    break;
            }
            
            LoadDataGridview(tasks);
        }
    }
}
