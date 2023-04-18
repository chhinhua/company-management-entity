using company_management.DAO;
using company_management.DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace company_management.BUS
{
    internal class TeamBUS
    {
        private TeamDAO teamDAO;
        private UserBUS userBUS;
        private List<Team> listTeam;

        public TeamBUS()
        {
            teamDAO = new TeamDAO();
            userBUS = new UserBUS();
            listTeam = new List<Team>();
        }

        public void LoadDataGridview(dynamic listTeam, DataGridView dataGridView, string position)
        {
            if (position.Equals("Manager"))
            {
                dataGridView.ColumnCount = 4;
                dataGridView.Columns[0].Name = "Mã";
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Name = "Người tạo";
                dataGridView.Columns[2].Name = "Mô tả";
                dataGridView.Columns[2].Width = 275;
                dataGridView.Columns[3].Name = "Trưởng nhóm";
                dataGridView.Rows.Clear();

                foreach (var t in listTeam)
                {
                    //string creator = userDAO.GetUserById(t.IdCreator).FullName;
                    //string assignee = userDAO.GetUserById(t.IdAssignee).FullName;
                    //string team = teamDAO.GetTeamByTask(t).Name;

                    dataGridView.Rows.Add(t.Id, t.Name, t.Description, t.IdLeader);
                }
            }
            else
            {
                dataGridView.ColumnCount = 5;
                dataGridView.Columns[0].Name = "Mã";
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Name = "Họ tên";
                dataGridView.Columns[2].Name = "Email";
                dataGridView.Columns[3].Name = "Số điện thoại";
                dataGridView.Columns[4].Name = "Địa chỉ";
                dataGridView.Rows.Clear();

                // sort theo deadline tăng dần
                //listTeam.Sort((x, y) => DateTime.Compare(x.Deadline, y.Deadline));

                foreach (var t in listTeam)
                {
                    //string creator = userDAO.GetUserById(t.IdCreator).FullName;
                    //string assignee = userDAO.GetUserById(t.IdAssignee).FullName;
                    //string team = teamDAO.GetTeamByTask(t).Name;

                    dataGridView.Rows.Add(t.Id, t.FullName, t.Email, t.PhoneNumber, t.Address);
                }
            }


            
        }

        public List<Team> GetListTeamByManager()
        {
            List<Team> listTeam = teamDAO.GetAllTeam();
            return listTeam;
        }

        public List<User> GetListUserInTeam(int leaderID)
        {
            List<User> listUser = teamDAO.GetUserInTeam(leaderID);
            return listUser;
        }
    }
}
