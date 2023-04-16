using company_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.DTO;
using company_management.BUS;

namespace company_management.Views
{
    public partial class UCTimeKeeping : UserControl
    {
        private CheckinCheckoutDAO checkinCheckoutDAO;      
        private CheckinCheckoutBUS checkinCheckoutBUS;      
        private TaskDAO taskDAO;

        public UCTimeKeeping()
        {
            InitializeComponent();
            taskDAO = new TaskDAO();
            checkinCheckoutDAO = new CheckinCheckoutDAO();
            checkinCheckoutBUS = new CheckinCheckoutBUS();
        }

        private void UCTimeKeeping_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            LoadTimeNow();
        }

        public void LoadTimeNow()
        {
            datetime_Checkin.Value = DateTime.Now;
            datetime_Checkout.Value = DateTime.Now;
        }

        public void LoadDataGridview()
        {
            List<CheckinCheckout> data = checkinCheckoutDAO.GetAllCheckinCO();
            checkinCheckoutBUS.LoadDataGridview(data, datagridview_timeKeeping);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void toggle_checkin_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_checkin.Checked == true)
            {
                DialogResult result = MessageBox.Show("Bạn xác nhận checkin? Nếu bạn nhấn Yes, một dữ liệu chấm công mới sẽ được tạo và bạn sẽ không thể trở lại.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thêm code để tạo checkin checkout

                    toggle_checkin.Enabled = false;
                } 
                else
                {
                    toggle_checkin.Checked = false;
                }
            }
        }

        private void toggle_checkout_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_checkout.Checked == true)
            {
                DialogResult result = MessageBox.Show("Bạn xác nhận checkout? Nếu bạn nhấn Yes, dữ liệu sẽ được lưu và không thể trở lại.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thêm code để set giá trị checkout cho người đang đăng nhập

                    toggle_checkout.Enabled = false;
                }
                else
                {
                    toggle_checkout.Checked = false;
                }
            }
        }


        /*private void toggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton.Checked == false)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tắt tính năng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    toggleButton.Checked = true;
                }
                else
                {
                    isDisabled = true;
                }
            }
            else if (isDisabled)
            {
                MessageBox.Show("Tính năng đã được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isDisabled = false;
            }
        }*/
    }
}
