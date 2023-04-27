using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using company_management.DTO;
using company_management.DAO;
using company_management.View;
using company_management.View.UC;

namespace company_management.BUS
{
    public class CheckinCheckoutBus
    {
        private readonly Lazy<CheckinCheckoutDao> _cicoDao;
        private readonly Lazy<UserDao> _userDao;

        public CheckinCheckoutBus()
        {
            _cicoDao = new Lazy<CheckinCheckoutDao>(() => new CheckinCheckoutDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
        }

        public void LoadDataGridview(List<CheckinCheckout> listCiCo, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên";
            dataGridView.Columns[2].Name = "Giờ checkin";
            dataGridView.Columns[3].Name = "Giờ checkout";
            dataGridView.Columns[3].DefaultCellStyle.NullValue = "";
            dataGridView.Columns[4].Name = "Tổng thời gian";
            dataGridView.Columns[5].Name = "Ngày";
            dataGridView.Rows.Clear();

            string checkoutTime = "";
            var userDao = _userDao.Value;
            foreach (var c in listCiCo)
            {
                string fullName = userDao.GetUserById(c.IdUser).FullName;

                if (c.CheckoutTime != null && c.CheckoutTime != default(DateTime))
                {
                    checkoutTime = c.CheckoutTime.ToString("hh:mm:ss");
                }
                else
                {
                    checkoutTime = "";
                }

                dataGridView.Rows.Add(c.Id, fullName, c.CheckinTime.ToString("hh:mm:ss"), checkoutTime, c.TotalHours, c.Date.ToString("dd/MM/yyyy"));
            }
        }

        public void Checkin(DateTime checkinTime, DateTime date)
        {
            var cicoDao = _cicoDao.Value;
            CheckinCheckout checkinCheckout = new CheckinCheckout();
            checkinCheckout.IdUser = UserSession.LoggedInUser.Id;
            checkinCheckout.CheckinTime = checkinTime;
            checkinCheckout.Date = date;
            cicoDao.AddCheckinCo(checkinCheckout);
        }

        public void Checkout(DateTime checkoutTime)
        {
            var cicoDao = _cicoDao.Value;
            CheckinCheckout checkinCheckout = cicoDao.GetCheckinById(UcTimeKeeping.LastCheckinCheckoutId);
            checkinCheckout.CheckoutTime = checkoutTime;
            cicoDao.UpdateCheckinCo(checkinCheckout);
        }
    }
}
