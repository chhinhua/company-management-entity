using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;


using company_management.DTO;
using company_management.DAO;
using company_management.Views;

namespace company_management.BUS
{
    public class TaskBUS
    {
        private TaskDAO taskDAO;
        private TeamDAO teamDAO;
        private UserBUS userBUS;
        private List<Task> listTask;

        public TaskBUS()
        {
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            userBUS = new UserBUS();
            listTask = new List<Task>();
        }

        public void LoadDataGridview(DataGridView dataGridView)
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

            string position = userBUS.GetUserPosition();           

            if (position.Equals("Manager"))
            {
                listTask = taskDAO.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id);
            }
            else if (position.Equals("Leader"))
            {
                listTask.AddRange(taskDAO.GetTasksCreatedByCurrentUser(UserSession.LoggedInUser.Id));
                listTask.AddRange(taskDAO.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id));            
            }
            else
            {
               listTask = taskDAO.GetTasksAssignedByCurrentUser(UserSession.LoggedInUser.Id);
            }

            // sort theo deadline tăng dần
            listTask.Sort((x, y) => DateTime.Compare(x.Deadline, y.Deadline));

            foreach (var t in listTask)
            {
                dataGridView.Rows.Add(t.Id, t.TaskName, t.Deadline,
                                t.Progress + " %", teamDAO.GetTeamByTask(t).Name);
            }
        }

        /*  public void LoadUserToCombobox(ComboBox comboBox)
          {
              List<User> items = taskDAO.LoadUserToCombobox(comboBox);

              // Đưa danh sách vào ComboBox
              comboBox.Items.AddRange(items.ToArray());
              comboBox.SelectedIndex = 0;
              comboBox.DisplayMember = "fullName";
              comboBox.ValueMember = "id";
          }*/

        public Task GetTaskFromTextBox(string taskName, string description, DateTimePicker dateTime, ComboBox combbox_Assignee)
        {
            Team selectesTeam;
            User selectesUser;
            Task task = null;   
            int idAssignee;
            int idCreator = UserSession.LoggedInUser.Id;

            string position = userBUS.GetUserPosition();

            if (position.Equals("Manager")) 
            {
                selectesTeam = (Team)combbox_Assignee.SelectedItem;
                idAssignee = selectesTeam.IdLeader;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, 0, selectesTeam.Id);
            }
            else if (position.Equals("Leader"))
            {
                selectesUser = (User)combbox_Assignee.SelectedItem;
                idAssignee = selectesUser.Id;
                task = new Task(idCreator, idAssignee, taskName,
                            description, dateTime.Value, 0, teamDAO.GetTeamByLeaderId(idCreator).Id);
            } else
            {
                MessageBox.Show("Bạn không có quyền lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return task;
        }

        public void CheckAddButtonStatus(Guna2Button addButton)
        {
            if (userBUS.IsEmployee())
            {
                addButton.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
            }
        }
    }
}
