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

        private SqlConnection connection = new DBConnection().connection;

        public TaskDAO()
        {
            dBConnection = new DBConnection();
            listTask = new List<Task>();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
        }

        public void LoadUserToCombobox(ComboBox comboBox)
        {
            List<User> items = new List<User>();

            if (UserSession.LoggedInUser != null)
            {
                if (UserSession.LoggedInUser.IdPosition == 1) // idRole = 1 (manager)
                {
                    // Hiển thị danh sách leader
                    items.AddRange(userDAO.GetAllLeader());
                }
                else if (UserSession.LoggedInUser.IdPosition == 2) // idRole = 2 (leader)
                {
                    // Hiển thị danh sách employee
                    items.AddRange(userDAO.GetAllEmployee()); 
                }
                else // idRole = 3 (employee)
                { 
                    // Không có quyền truy cập
                    comboBox.Enabled = false;
                    return;
                }
            }

            // Đưa danh sách vào ComboBox
            comboBox.Items.AddRange(items.ToArray());
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = "fullName";
            comboBox.ValueMember = "id";
        }

        public void addTask(Task task)
        {
            string query = string.Format("INSERT INTO task(idCreator, idAssignee, taskName, description, deadline, progress, idTeam)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   task.IdCreator, task.IdAssignee, task.TaskName, task.Description, task.Deadline, task.Progress, task.IdTeam);
            dBConnection.executeQuery(query);
        }

        public void updateTask(Task updateTask)
        {
            string sqlStr = string.Format("UPDATE task SET " +
                   "idAssignee = '{0}', taskName = '{1}', description = '{2}', deadline = '{3}', progress = '{4}', idTeam = '{5}' WHERE id = '{6}'",
                   updateTask.IdAssignee, updateTask.TaskName, updateTask.Description, updateTask.Deadline, updateTask.Progress, updateTask.IdTeam, updateTask.Id);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteTask(int id)
        {
            string sqlStr = string.Format("DELETE FROM task WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }

        public Task GetTaskById(int id)
        {
            string query = string.Format("SELECT * FROM task WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<Task>(query);
        }

        public TaskStatusPercentage getTaskStatusPercentage()
        {
            TaskStatusPercentage taskStatus = new TaskStatusPercentage(0, 0, 0);

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM GetTaskStatusPercentage()", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taskStatus.TodoPercent = (double)reader["todoPercent"];
                    taskStatus.InprogressPercent = (double)reader["inprogressPercent"];
                    taskStatus.DonePercent = (double)reader["donePercent"];
                }
                reader.Close();

                return taskStatus;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return taskStatus;
        }

        //===============================================

     /*   public List<Task> GetAllTask()
        {
            DataTable dataTable = dBConnection.LoadData("task");
            return MapToListTask(dataTable);
        }*/

        public List<Task> GetAllTask()
        {
            string query = string.Format("SELECT * FROM task");
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

        public void LoadData(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 5;

            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Width = 40;

            dataGridView.Columns[1].Name = "Tên";
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Name = "Deadline";
            dataGridView.Columns[3].Name = "Tiến độ";
            dataGridView.Columns[4].Name = "Team được giao";
            dataGridView.Rows.Clear();

            // sử lý tên team
            listTask = GetAllTask();

            foreach (var t in listTask)
            {
                dataGridView.Rows.Add(t.Id, t.TaskName, t.Deadline, 
                                t.Progress + " %", teamDAO.GetTeamByTask(t).Name);
            }
        }

        /*public List<Task> SearchTasks(string txtSearch)
        {
            string query = string.Format("SELECT * FROM users WHERE username like '%{0}%' OR fullName like '%{0}%' " +
                "OR email like '%{0}%' OR address like '%{0}%' OR phoneNumber like '%{0}%'", txtSearch);

            DataTable dataTable = dBConnection.SearchData(query);

            return MapToListTask(dataTable);
        }*/

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
