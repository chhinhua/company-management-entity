using company_management.Models;
using System.Windows.Forms;
using company_management.Entities;
using System.Linq;
using System.Collections.Generic;
using company_management.DTO;

namespace company_management.Controllers
{
    public class CheckinCheckoutDAO
    {
        private company_managementEntities dbContext;
        private readonly DBConnection dBConnection;

        public CheckinCheckoutDAO()
        {
            dbContext = new company_managementEntities();
            dBConnection = new DBConnection();
        }

        public void loadCheckinCheckout(DataGridView dataGridView)
        {
            dBConnection.loadData(dataGridView, "checkin_checkout");

            dataGridView.Columns["id"].Visible = false;
            //dataGridView.Columns["idUser"].Visible = false;
        }
        public void addCheckinCheckout(CheckinCheckoutDTO checkinCheckout)
        {
            string sqlStr = string.Format("INSERT INTO checkin_checkout(idUser, checkinTime, checkoutTime, totalHours, date)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", 
                checkinCheckout.IdUser, checkinCheckout.CheckinTime, checkinCheckout.CheckoutTime, checkinCheckout.TotalHours, checkinCheckout.Date);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateCheckinCheckout(CheckinCheckoutDTO checkinCheckout)
        {
            string sqlStr = string.Format("UPDATE checkin_checkout SET " +
                   "idUser = '{0}', checkinTime = '{1}', checkoutTime = '{2}', totalHours = '{3}', date = '{4}' WHERE id = '{5}'",
                   checkinCheckout.IdUser, checkinCheckout.CheckinTime, checkinCheckout.CheckoutTime, checkinCheckout.TotalHours, checkinCheckout.Date, checkinCheckout.Id);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteCheckinCheckout(int id)
        {
            string sqlStr = string.Format("DELETE FROM checkin_checkout WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }

        /*public void SaveUser(checkin_checkout checkin_Checkout)
        {
            using (var dbContext = new Entities.Entities())
            {
                // Kiểm tra nếu user đã tồn tại trong cơ sở dữ liệu
                var existingUser = dbContext.users.FirstOrDefault(u => u. == user.Id);

                if (existingUser == null)
                {
                    // Thêm mới một user vào cơ sở dữ liệu
                    dbContext.users.Add(user);
                }
                else
                {
                    // Cập nhật thông tin user trong cơ sở dữ liệu
                    existingUser.FullName = user.FullName;
                    existingUser.Email = user.Email;
                }

                dbContext.SaveChanges();
            }
        }*/

        public List<TimeKeepingDTO> GetAllCheckinCheckouts()
        {
            var data = from cico in dbContext.checkin_checkout
                       select new TimeKeepingDTO
                       {
                           Employee = cico.user.fullName,
                           CheckinTime = cico.checkinTime,
                           CheckoutTime = cico.checkoutTime,
                           TotalHours = cico.totalHours,
                           Date = (System.DateTime)cico.date
                       };
            return data.ToList();
        }

       /* public void AddCheckinCheckout(CheckinCheckoutDTO checkinCheckoutDTO)
        {
            // Chuyển đổi đối tượng DTO sang đối tượng Entity
            var checkinCheckout = new checkin_checkout
            {
                idUser = checkinCheckoutDTO.IdUser,
                checkinTime = checkinCheckoutDTO.CheckinTime,
                checkoutTime = checkinCheckoutDTO.CheckoutTime,
                totalHours = checkinCheckoutDTO.TotalHours,
                date = checkinCheckoutDTO.Date
            };

            // Thêm đối tượng Entity vào context và lưu vào CSDL
            dbContext.checkin_checkout.Add(checkinCheckout);
            dbContext.SaveChanges();
        }*/
    }
}