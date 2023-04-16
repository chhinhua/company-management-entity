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
using System.Globalization;

namespace company_management.Views
{
    public partial class UCTimeKeeping : UserControl
    {
        public static int lastCheckinCheckoutId;
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
            datetime_date.Value = DateTime.Now.Date;
            datetime_Checkin.Value = DateTime.Now;
            datetime_Checkout.Value = DateTime.Now;

            toggle_checkout.Checked = false;
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

        private void toggle_checkin_Click(object sender, EventArgs e)
        {
            if (toggle_checkin.Checked == true)
            {
                DialogResult result = MessageBox.Show("Dữ liệu sẽ được tạo sau khi bạn bấm yes.", "Xác nhận Checkin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DateTime checkinTime = datetime_Checkin.Value;
                    DateTime date = datetime_date.Value.Date;
                    checkinCheckoutBUS.Checkin(checkinTime, date);
                    LoadDataGridview();
                    toggle_checkin.Enabled = false;
                }
                else
                {
                    toggle_checkin.Checked = false;
                }
            }
        }

        private void toggle_checkout_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem toggle switch "checkin" đã được chọn hay chưa
            if (toggle_checkin.Checked == false)
            {
                MessageBox.Show("Bạn phải checkin trước khi checkout.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toggle_checkout.Checked = false;
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Dữ liệu sẽ được lưu sau khi bạn bấm yes.", "Xác nhận Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DateTime checkoutTime = datetime_Checkout.Value;
                    checkinCheckoutBUS.Checkout(checkoutTime);
                    LoadDataGridview();

                    toggle_checkout.Enabled = false;
                }
                else
                {
                    toggle_checkout.Checked = false;
                }
            }

        }

        private void datagridview_timeKeeping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = datagridview_timeKeeping.Rows[e.RowIndex];
                UCTimeKeeping.lastCheckinCheckoutId = (int)selectedRow.Cells[0].Value;
                string checkoutTimeValue = selectedRow.Cells["Giờ checkout"].Value.ToString();

                if (string.IsNullOrEmpty(checkoutTimeValue))
                {
                    toggle_checkout.Checked = false;
                    toggle_checkout.Enabled = true;
                }
                else
                {
                    // Giá trị của ô "Giờ checkout" khác rỗng, cần chuyển đổi giá trị sang kiểu DateTime và set giá trị cho datetime_checkout.
                    DateTime checkoutDateTime;
                    if (DateTime.TryParseExact(checkoutTimeValue, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out checkoutDateTime))
                    {
                        datetime_Checkout.Value = checkoutDateTime;
                        toggle_checkout.Checked = true;
                        toggle_checkout.Enabled = false;
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
}
