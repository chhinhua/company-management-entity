using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DTO;
using company_management.DAO;
using company_management.View;
using company_management.View.UC;

namespace company_management.BUS
{
    public class TaskBUS
    {
        private Lazy<TaskDAO> taskDAO;
        private Lazy<TeamDAO> teamDAO;
        private Lazy<UserDAO> userDAO;
        private Lazy<UserBUS> userBUS;
        private Lazy<ProjectBUS> projectBUS;
        private Lazy<List<Task>> listTask;

        public TaskBUS()
        {
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
            teamDAO = new Lazy<TeamDAO>(() => new TeamDAO());
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            userBUS = new Lazy<UserBUS>(() => new UserBUS());
            projectBUS = new Lazy<ProjectBUS>(() => new ProjectBUS());
            listTask = new Lazy<List<Task>>(() => new List<Task>());
        }

        public void LoadDataGridview(List<Task> listTask, DataGridView dataGridView)
        {
            var userDao = userDAO.Value;
            var teamDao = teamDAO.Value;

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
            var tasks = listTask.Value;
            var taskDao = taskDAO.Value;
            var userBus = userBUS.Value;

            string position = userBus.GetUserPosition();

            ClearListTask(tasks);

            if (position.Equals("Manager"))
            {
                tasks = taskDao.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id);
            }
            else if (position.Equals("Leader"))
            {
                tasks.AddRange(taskDao.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id));
                tasks.AddRange(taskDao.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id));
            }
            else
            {
                tasks = taskDao.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id);
            }

            return tasks;
        }

        public Task GetTaskFromTextBox(string taskName, string description, DateTimePicker dateTime, 
                ComboBox combbox_Assignee, int progress, string bonus, ComboBox combobox_Project)
        {
            var userBus = userBUS.Value;
            var teamDao = teamDAO.Value;

            Team selectedTeam;
            User selectedUser;
            Project selectedProject;
            Task task = null;
            int idAssignee;
            int idCreator = UserSession.LoggedInUser.Id;
            
            selectedProject = (Project)combobox_Project.SelectedItem;
            decimal bonusVaue = 0;
            if (bonus != "")
            {
                bonusVaue = decimal.Parse(bonus);
            }

            string position = userBus.GetUserPosition();

            if (position.Equals("Manager"))
            {
                selectedTeam = (Team)combbox_Assignee.SelectedItem;
                idAssignee = selectedTeam.IdLeader;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, progress, selectedTeam.Id, bonusVaue, selectedProject.Id);
            }
            else if (position.Equals("Leader"))
            {
                selectedUser = (User)combbox_Assignee.SelectedItem;
                idAssignee = selectedUser.Id;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, progress, teamDao.GetTeamByLeader(idCreator).Id, bonusVaue, selectedProject.Id);
            }
            else
            {
                task = new Task(UC_Task.viewTask.IdCreator, UC_Task.viewTask.IdAssignee, taskName, description, dateTime.Value, progress, 
                                        teamDao.GetTeamByLeader(UC_Task.viewTask.IdCreator).Id, UC_Task.viewTask.Bonus, selectedProject.Id);
            }
            return task;
        }

        public List<Task> SearchTasks(string txtSearch)
        {
            var taskDao = taskDAO.Value;
            return taskDao.SearchTasks(txtSearch);
        }

        public List<Task> SearchTasksByKeyword(Guna2DataGridView gridView, string keyword, 
                        int clmnCreator, int clmnTaskName, int clmnAssignee, int clmnTeam)
        {
            var tasks = listTask.Value;
            var taskDao = taskDAO.Value;
            ClearListTask(tasks);

            foreach (DataGridViewRow row in gridView.Rows)
            {
                bool found = false;
                foreach (int i in new int[] { clmnCreator, clmnTaskName, clmnAssignee, clmnTeam })
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
            var taskDao = taskDAO.Value;
            var projectBus = projectBUS.Value;
            taskDao.LoadUserToCombobox(assignees);
            projectBus.LoadProjectToCombobox(project);
        }

        public void ClearListTask(List<Task> listTask)
        {
            listTask.Clear();
            listTask.TrimExcess();
        }
    }
}
