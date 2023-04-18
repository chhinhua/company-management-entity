using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using company_management.Views;

namespace company_management.DAO
{
    public class TaskDAO
    {
        private readonly DBConnection dBConnection;
        private List<Task> listTask;
        private TeamDAO teamDAO;
        private UserDAO userDAO;

        public TaskDAO()
        {
            dBConnection = new DBConnection();
            listTask = new List<Task>();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
        }

        public void LoadUserToCombobox(ComboBox comboBox)
        {
            List<Team> teams;
            List<User> users;

            if (UserSession.LoggedInUser != null)
            {
                if (UserSession.LoggedInUser.IdPosition == 1) // IdPosition = 1 (manager)
                {
                    // Hiển thị danh sách team cho quản lý chọn
                    teams = new List<Team>();
                    teams.AddRange(teamDAO.GetAllTeam());

                    comboBox.Items.AddRange(teams.ToArray());
                    comboBox.DisplayMember = "name";
                }
                else if (UserSession.LoggedInUser.IdPosition == 2) // IdPosition = 2 (leader)
                {
                    // Hiển thị danh sách nhân viên trong team cho leader chọn
                    users = new List<User>();
                    users.AddRange(userDAO.GetAllEmployee());

                    comboBox.Items.AddRange(users.ToArray());
                    comboBox.DisplayMember = "fullName";
                }
                else // (employee)
                { 
                    // Không có quyền truy cập
                    comboBox.Enabled = false;
                    return;
                }

                comboBox.ValueMember = "id";
                comboBox.SelectedIndex = 0;             
            }

        }

        public void AddTask(Task task)
        {
            string query = string.Format("INSERT INTO task(idCreator, idAssignee, taskName, description, deadline, progress, idTeam, bonus)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   task.IdCreator, task.IdAssignee, task.TaskName, task.Description, task.Deadline, task.Progress, task.IdTeam, task.Bonus);
            dBConnection.ExecuteQuery(query);
        }

        public void UpdateTask(Task updateTask)
        {
            string sqlStr = string.Format("UPDATE task SET " +
                   "idAssignee = '{0}', taskName = '{1}', description = '{2}', deadline = '{3}', progress = '{4}', idTeam = '{5}', bonus = '{6}' WHERE id = '{7}'",
                   updateTask.IdAssignee, updateTask.TaskName, updateTask.Description, updateTask.Deadline, updateTask.Progress, updateTask.IdTeam, updateTask.Bonus, updateTask.Id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public void DeleteTask(int id)
        {
            string sqlStr = string.Format("DELETE FROM task WHERE id = '{0}'", id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public Task GetTaskById(int id)
        {
            string query = string.Format("SELECT * FROM task WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<Task>(query);
        }

        public TaskStatusPercentage GetTaskStatusPercentage(List<Task> tasks)
        {
            TaskStatusPercentage taskStatus = new TaskStatusPercentage(0, 0, 0);

            if (tasks.Count > 0)
            {
                double totalTasks = tasks.Count;
                double todoCount = tasks.Count(task => task.Progress == 0);
                double inprogressCount = tasks.Count(task => task.Progress > 0 && task.Progress < 100);
                double doneCount = tasks.Count(task => task.Progress == 100);

                taskStatus.TodoPercent = (todoCount / totalTasks) * 100;
                taskStatus.InprogressPercent = (inprogressCount / totalTasks) * 100;
                taskStatus.DonePercent = (doneCount / totalTasks) * 100;
            }

            return taskStatus;
        }

        public List<Task> GetAllTask()
        {
            string query = string.Format("SELECT * FROM task");
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

        public List<Task> GetTasksCreatedByCurrentUser(int idCreator)
        {
            return GetAllTask().Where(t => t.IdCreator == idCreator).ToList();
        }

        public List<Task> GetTasksAssignedByCurrentUser(int idAssignee)
        {
            return GetAllTask().Where(t => t.IdAssignee == idAssignee).ToList();
        }

        public List<Task> SearchTasks(string txtSearch)
        {
            string query = string.Format("SELECT t.* FROM task t " +
                "INNER JOIN teams tm ON t.idTeam = tm.id " +
                "INNER JOIN users u ON(t.idCreator = u.id OR t.idAssignee = u.id) " +
                "WHERE t.taskName LIKE '%{0}%' " +
                "OR t.description LIKE '%{0}%' " +
                "OR tm.name LIKE '%{0}%' " +
                "OR u.username LIKE '%{0}%' ", txtSearch);
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

        private List<Task> MapToListTask(DataTable dataTable)
        {
            listTask = dataTable.AsEnumerable()
                            .Select(row => new Task
                            {
                                Id = row.Field<int>("id"),
                                IdCreator = row.Field<int>("idCreator"),
                                IdAssignee = row.Field<int>("idAssignee"),
                                TaskName = row.Field<string>("taskName"),
                                Description = row.Field<string>("description"),
                                Deadline = row.Field<DateTime>("deadline"),
                                Progress = row.Field<int>("progress"),
                                IdTeam = row.Field<int>("idTeam")
                            }).ToList();

            return listTask;
        } 
    }
}
