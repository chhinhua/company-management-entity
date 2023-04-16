using System;
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
    public class CheckinCheckoutBUS
    {
        private TaskDAO taskDAO;
        private TeamDAO teamDAO;
        private UserDAO userDAO;
        private UserBUS userBUS;
        private List<Task> listTask;

        public CheckinCheckoutBUS()
        {
            taskDAO = new TaskDAO();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
            userBUS = new UserBUS();
            listTask = new List<Task>();
        }

        public void LoadDataGridview(List<CheckinCheckout> listCiCo, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên người dùng";
            dataGridView.Columns[2].Name = "Giờ checkin";
            dataGridView.Columns[3].Name = "Giờ checkout";
            dataGridView.Columns[4].Name = "Tổng thời gian";
            dataGridView.Columns[5].Name = "Ngày";
            dataGridView.Rows.Clear();

            foreach (var c in listCiCo)
            {
                string fullName = userDAO.GetUserById(c.IdUser).FullName;
                dataGridView.Rows.Add(c.Id, fullName, c.CheckinTime.ToString("hh:mm:ss"), c.CheckoutTime.ToString("hh:mm:ss"), c.TotalHours, c.Date.ToString("dd/MM/yyyy"));
            }
        }
    }
}
