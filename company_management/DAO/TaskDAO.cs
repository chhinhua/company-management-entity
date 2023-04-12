using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace company_management.DAO
{
    public class TaskDAO
    {
        private readonly DBConnection dBConnection;
        private List<Task> listTask;
        private TeamDAO teamDAO;

        private SqlConnection connection = new DBConnection().connection;

        public TaskDAO()
        {
            dBConnection = new DBConnection();
            listTask = new List<Task>();
            teamDAO = new TeamDAO();
        }

        public List<Task> GetListTasks(DataGridView dataGridView)
        {

            // dBConnection.loadData(dataGridView, "task");
            /*
                        dataGridView.Columns["id"].Visible = false;
                        dataGridView.Columns["idUser"].Visible = false;
                        dataGridView.Columns["description"].Visible = false;*/

            return listTask;
        }

        public void loadUserToCombobox(ComboBox comboBox)
        {
            string query = string.Format("SELECT * FROM users WHERE role <> 'admin'");
            dBConnection.loadDataControl<ComboBox>(comboBox, query);
        }

        public void addTask(Task task)
        {
            string sqlStr = string.Format("INSERT INTO task(idUser, taskName, description, deadline, progress)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                   task.IdUser, task.TaskName, task.Description, task.Deadline, task.Progress);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateTask(Task updateTask)
        {
            string sqlStr = string.Format("UPDATE task SET " +
                   "idUser = '{0}', taskName = '{1}', description = '{2}', deadline = '{3}', progress = '{4}' WHERE id = '{5}'",
                   updateTask.IdUser, updateTask.TaskName, updateTask.Description, updateTask.Deadline, updateTask.Progress, updateTask.Id);
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

        public List<Task> GetAllTask()
        {
            DataTable dataTable = dBConnection.LoadData("task");
            return MapToListTask(dataTable);
        }

        public void loadData(DataGridView dataGridView, List<Task> tasks)
        {
            dataGridView.ColumnCount = 5;

            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Width = 40;

            dataGridView.Columns[1].Name = "Tên";
            dataGridView.Columns[2].Name = "Deadline";
            dataGridView.Columns[3].Name = "Tiến độ";
            dataGridView.Columns[4].Name = "Team được giao";
            dataGridView.Rows.Clear();

            // sử lý tên team

            foreach (var t in tasks)
            {
                dataGridView.Rows.Add(t.Id, t.TaskName, t.Deadline, 
                                t.Progress + " %", teamDAO.GetTeamById(t.IdTeam).Name);
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
                                IdUser = row.Field<int>("idUser"),
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
