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

namespace company_management.Views
{
    public partial class UCTimeKeeping : UserControl
    {
        CheckinCheckoutDAO cicoDAO = new CheckinCheckoutDAO();
        public static CheckinCheckout timeKeeping = new CheckinCheckout();
        //public static bool dataChanged = false;

        public UCTimeKeeping()
        {
            InitializeComponent();
        }

        private void UCTimeKeeping_Load(object sender, EventArgs e)
        {
            cicoDAO.loadCheckinCheckout(datagridview_timeKeeping);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            // Tạo một chuỗi điều kiện để lọc dữ liệu
            StringBuilder filterExpression = new StringBuilder();
            foreach (DataGridViewColumn column in datagridview_timeKeeping.Columns)
            {
                // Chỉ áp dụng lọc cho các cột chứa dữ liệu và không phải cột deadline
                if (column.DataPropertyName != null && column.Visible && column.Name == "idUser")
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
    }
}
