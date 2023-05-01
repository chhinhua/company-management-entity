using System;
using System.Linq;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DTO;
using company_management.DAO;
using company_management.View.UC;
// ReSharper disable All

namespace company_management.BUS
{
    public class TaskBus
    {
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<UserBus> _userBus;
        private readonly Lazy<ProjectBus> _projectBus;
        private readonly Lazy<List<Task>> _listTask;

        public TaskBus()
        {
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _userBus = new Lazy<UserBus>(() => new UserBus());
            _projectBus = new Lazy<ProjectBus>(() => new ProjectBus());
            _listTask = new Lazy<List<Task>>(() => new List<Task>());
        }

        public void LoadDataGridview(List<Task> listTask, DataGridView dataGridView)
        {
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;

            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Người tạo";
            dataGridView.Columns[2].Name = "Tên task";
            dataGridView.Columns[2].Width = 275;
            dataGridView.Columns[3].Name = "Deadline";
            dataGridView.Columns[4].Name = "Tiến độ";
            dataGridView.Columns[5].Name = "Người được giao";
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[6].Name = "Team được giao";
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Rows.Clear();

            // sort theo deadline tăng dần
            listTask.Sort((x, y) => DateTime.Compare(x.Deadline, y.Deadline));

            foreach (var t in listTask)
            {
                string creator = userDao.GetUserById(t.IdCreator).FullName;
                string assignee = userDao.GetUserById(t.IdAssignee).FullName;
                string team = teamDao.GetTeamById(t.IdTeam).Name;

                dataGridView.Rows.Add(t.Id, creator, t.TaskName, t.Deadline.ToString("dd/MM/yyyy"), t.Progress + " %", assignee, team);
            }
        }

        public List<Task> GetListTaskByPosition()
        {
            var tasks = _listTask.Value;
            var taskDao = _taskDao.Value;
            var userBus = _userBus.Value;

            string position = userBus.GetUserPosition();

            ClearListTask(tasks);

            if (position.Equals("Manager"))
            { tasks = taskDao.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id); }
            else if (position.Equals("Leader"))
            {
                tasks.AddRange(taskDao.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id));
                tasks.AddRange(taskDao.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id));
            }
            else { tasks = taskDao.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id); }

            return tasks;
        }

        public Task GetTaskFromTextBox(string taskName, string description, DateTimePicker dateTime, 
                ComboBox comboboxAssignee, int progress, string bonus, ComboBox comboboxProject)
        {
            var userBus = _userBus.Value;
            var teamDao = _teamDao.Value;

            Task task;
            int idAssignee;
            int idCreator = UserSession.LoggedInUser.Id;
            
            var selectedProject = (Project)comboboxProject.SelectedItem;
            decimal bonusValue = 0;
            if (bonus != "")
            {
                bonusValue = decimal.Parse(bonus);
            }

            string position = userBus.GetUserPosition();

            if (position.Equals("Manager"))
            {
                var selectedTeam = (Team)comboboxAssignee.SelectedItem;
                idAssignee = selectedTeam.IdLeader;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, progress, selectedTeam.Id, bonusValue, selectedProject.Id);
            }
            else if (position.Equals("Leader"))
            {
                var selectedUser = (User)comboboxAssignee.SelectedItem;
                idAssignee = selectedUser.Id;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, progress, teamDao.GetTeamByLeader(idCreator).Id, bonusValue, selectedProject.Id);
            }
            else
            {
                task = new Task(UcTask.ViewTask.IdCreator, UcTask.ViewTask.IdAssignee, taskName, description, dateTime.Value, progress, 
                                        teamDao.GetTeamByLeader(UcTask.ViewTask.IdCreator).Id, UcTask.ViewTask.Bonus, selectedProject.Id);
            }
            return task;
        }

        public List<Task> SearchTasks(string txtSearch)
        {
            var taskDao = _taskDao.Value;
            return taskDao.SearchTasks(txtSearch);
        }

        public List<Task> GetTodoTasks() => GetListTaskByPosition().Where(t => t.Progress == 0).ToList();

        public List<Task> GetInprogressTasks() => GetListTaskByPosition().Where(t => t.Progress > 0 && t.Progress < 100).ToList();

        public List<Task> GetDoneTasks() => GetListTaskByPosition().Where(t => t.Progress == 100).ToList();

        public List<Task> GetMyTasks() => GetListTaskByPosition().Where(t => t.IdAssignee == UserSession.LoggedInUser.Id).ToList();
        
        public List<Task> GetMyCreatedTasks() => GetListTaskByPosition().Where(t => t.IdCreator == UserSession.LoggedInUser.Id).ToList();
        
        public List<Task> SearchTasksByKeyword(Guna2DataGridView gridView, string keyword, 
                        int creator, int taskName, int assignee, int team)
        {
            var tasks = _listTask.Value;
            var taskDao = _taskDao.Value;
            ClearListTask(tasks);

            foreach (DataGridViewRow row in gridView.Rows)
            {
                bool found = false;
                foreach (int i in new int[] { creator, taskName, assignee, team })
                {
                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(keyword))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    int taskId = Convert.ToInt32(row.Cells[0].Value);
                    Task task = taskDao.GetTaskById(taskId);
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public void SelectComboBoxItemByValue(Guna2ComboBox comboBox, int value)
        {
            string valueString = value.ToString();
            int index = comboBox.FindStringExact(valueString);
            if (index != -1)
            {
                comboBox.SelectedIndex = index;
            }
        }

        public void SelectComboboxItemById<T>(ComboBox comboBox, int id) where T : class
        {
            // Lấy danh sách các item từ ComboBox
            List<T> items = comboBox.Items.Cast<T>().ToList();

            // Tìm kiếm item có ID trùng với tham số đầu vào và chọn nó
            T selectedItem = items.Find(item => (int)item.GetType().GetProperty("Id").GetValue(item) == id);
            if (selectedItem != null)
            {
                comboBox.SelectedItem = selectedItem;
            }
        }

        public void GetDataToCombobox(ComboBox assignees, ComboBox project)
        {
            var taskDao = _taskDao.Value;
            var projectBus = _projectBus.Value;
            taskDao.LoadUserToCombobox(assignees);
            projectBus.LoadProjectToCombobox(project);
        }

        private void ClearListTask(List<Task> listTask)
        {
            listTask.Clear();
            listTask.TrimExcess();
        }
    }
}
