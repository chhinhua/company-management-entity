using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class CheckinCheckoutDAO
    {
        private readonly DBConnection dBConnection;

        public CheckinCheckoutDAO() => dBConnection = new DBConnection();

        public void loadCheckinCheckout(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "checkinCheckout");

        public void addCheckinCheckout(CheckinCheckout checkinCheckout)
        {
            string sqlStr = string.Format("INSERT INTO checkinCheckout(idUser, checkinTime, checkoutTime, totalHours, date)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", checkinCheckout.IdUser, checkinCheckout.CheckinTime, checkinCheckout.CheckoutTime, checkinCheckout.TotalHours, checkinCheckout.Date);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateCheckinCheckout(CheckinCheckout checkinCheckout)
        {
            string sqlStr = string.Format("UPDATE CheckinCheckout SET " +
                   "idUser = '{0}', checkinTime = '{1}', checkoutTime = '{2}', totalHours = '{3}', date = '{4}' WHERE id = '{5}'",
                   checkinCheckout.IdUser, checkinCheckout.CheckinTime, checkinCheckout.CheckoutTime, checkinCheckout.TotalHours, checkinCheckout.Date, checkinCheckout.IdCheckin);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteCheckinCheckout(int id)
        {
            string sqlStr = string.Format("DELETE FROM CheckinCheckout WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }
    }
}