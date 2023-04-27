using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DAO;
using company_management.DTO;
using company_management.BUS;

namespace company_management.View
{
    public partial class UC_TimeKeeping : UserControl
    {
        private Lazy<UserDAO> userDAO;
        private Lazy<CheckinCheckoutDAO> cicoDAO;
        private Lazy<CheckinCheckoutBUS> cicoBUS;
        public static int lastCheckinCheckoutId;

        public UC_TimeKeeping()
        {
            InitializeComponent();
            userDAO = new Lazy<UserDAO>(() => new UserDAO());
            cicoDAO = new Lazy<CheckinCheckoutDAO>(() => new CheckinCheckoutDAO());
            cicoBUS = new Lazy<CheckinCheckoutBUS>(() => new CheckinCheckoutBUS());
        }

        private void UCTimeKeeping_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            LoadTimeNow();
        }

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void LoadTimeNow()
        {
            datetime_date.Value = DateTime.Now.Date;
            datetime_Checkin.Value = DateTime.Now;
            datetime_Checkout.Value = DateTime.Now;

            toggle_checkout.Checked = false;
        }

        private void LoadDataGridview()
        {
            var cicoBus = cicoBUS.Value;
            var cicoDao = cicoDAO.Value;
            List<CheckinCheckout> data = cicoDao.GetAllCheckinCO();
            cicoBus.LoadDataGridview(data, datagridview_timeKeeping);
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

        private void ClearAll()
        {
            lastCheckinCheckoutId = 0;
            txtBox_fullName.Clear();
            txtBox_totalHours.Clear();
            toggle_checkin.Checked = false;
            toggle_checkout.Checked = false;
            toggle_checkin.Enabled = true;
            toggle_checkout.Enabled = true;
            LoadTimeNow();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void toggle_checkin_Click(object sender, EventArgs e)
        {
            if (toggle_checkin.Checked == true)
            {
                DialogResult result = MessageBox.Show("Dữ liệu sẽ được tạo sau khi bạn bấm yes.", "Xác nhận Checkin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cicoBus = cicoBUS.Value;
                    DateTime checkinTime = datetime_Checkin.Value;
                    DateTime date = datetime_date.Value.Date;
                    cicoBus.Checkin(checkinTime, date);
                    this.Alert("Checkin successful", Form_Alert.enmType.Success);
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
                this.Alert("Faild to checkout", Form_Alert.enmType.Warning);
                toggle_checkout.Checked = false;
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Dữ liệu sẽ được lưu sau khi bạn bấm yes.", "Xác nhận Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cicoBus = cicoBUS.Value;
                    DateTime checkoutTime = datetime_Checkout.Value;
                    cicoBus.Checkout(checkoutTime);
                    this.Alert("Checkout successful", Form_Alert.enmType.Success);
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
                lastCheckinCheckoutId = (int)selectedRow.Cells[0].Value;

                var cicoDao = cicoDAO.Value;
                CheckinCheckout cico = cicoDao.GetCheckinCOById(lastCheckinCheckoutId);

                var userDao = userDAO.Value;
                txtBox_fullName.Text = userDao.GetUserById(cico.IdUser).FullName;
                txtBox_totalHours.Text = cico.TotalHours.ToString() + " h";
                datetime_date.Value = cico.Date;
                datetime_Checkin.Value = cico.CheckinTime;

                // Bấm vào một hàng là mặc định giờ checkin được chọn
                toggle_checkin.Checked = true;
                toggle_checkin.Enabled = false;
                                
                // Check xem có checkout hay chưa (giá trị mặc định là DateTime.MinVal)
                if (cico.CheckoutTime == DateTime.MinValue)
                {
                    toggle_checkout.Checked = false;
                    toggle_checkout.Enabled = true;
                }
                else
                {
                    datetime_Checkout.Value = cico.CheckoutTime;
                    toggle_checkout.Checked = true;
                    toggle_checkout.Enabled = false;                
                }
            }
        }
    }
}
