using company_management.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.Models;
using company_management.DTO;

namespace company_management.Views
{
    public partial class UCTimeKeeping : UserControl
    {
        CheckinCheckoutDAO cicoDAO = new CheckinCheckoutDAO();
        public static CheckinCheckoutDTO timeKeeping = new CheckinCheckoutDTO();
        private TaskDAO taskDAO = new TaskDAO();

        public UCTimeKeeping()
        {
            InitializeComponent();
        }

        private void UCTimeKeeping_Load(object sender, EventArgs e)
        {
            taskDAO.loadUserToCombobox(combbox_employee);
            loadGridview();
            loadTimeNow();
        }

        public void loadTimeNow()
        {
            datetime_Checkin.ShowUpDown = true;
            datetime_Checkin.Value = DateTime.Now;

            datetime_Checkout.ShowUpDown = true;
            datetime_Checkout.Value = DateTime.Now;
        }

        public void loadGridview()
        {
            List<TimeKeepingDTO> data = cicoDAO.GetAllCheckinCheckouts();
            datagridview_timeKeeping.DataSource = data;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            // Tạo một chuỗi điều kiện để lọc dữ liệu
            StringBuilder filterExpression = new StringBuilder();
            foreach (DataGridViewColumn column in datagridview_timeKeeping.Columns)
            {
                // Chỉ áp dụng lọc cho các cột chứa dữ liệu
                if (column.Visible && column.Name == "Employee")
                {
                    if (filterExpression.Length > 0)
                    {
                        filterExpression.Append(" OR ");
                    }
                    filterExpression.Append($"[{column.DataPropertyName}] LIKE '%{keyword}%'");
                }
            }

            // Áp dụng chuỗi điều kiện lọc dữ liệu vào DataGridView
            (datagridview_timeKeeping.DataSource as DataTable).DefaultView.RowFilter = filterExpression.ToString();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
