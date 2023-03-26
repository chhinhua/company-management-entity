using company_management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class TaskDAO
    {
        private readonly DBConnection dBConnection;

        private SqlConnection connection = new DBConnection().connection;

        public TaskDAO() => dBConnection = new DBConnection();

        public void loadTasks(DataGridView dataGridView)
        {
            dBConnection.loadData(dataGridView, "task");

            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["idUser"].Visible = false;
            dataGridView.Columns["description"].Visible = false;
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
            Task task = dBConnection.GetObjectById<Task>(query);
            return task;
        }

        public TaskStatusPercentage getTaskStatusPercentage()
        {
            TaskStatusPercentage taskStatus = new TaskStatusPercentage();

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
    }
}
