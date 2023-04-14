﻿using company_management.DTO;
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
                Console.WriteLine(e.ToString());
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

        public List<Task> GetTasksCreatedByCurrentUser(int idCreator)
        {
            string query = string.Format("SELECT * FROM task WHERE idCreator = {0}", idCreator);
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

        public List<Task> GetTasksAssignedByCurrentUser(int idAssignee)
        {
            string query = string.Format("SELECT * FROM task WHERE idAssignee = {0}", idAssignee);
            return dBConnection.GetListObjectsByQuery<Task>(query);
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