using company_management.DTO;
using System.Windows.Forms;
using company_management.Entities;
using System.Linq;
using System.Collections.Generic;
using company_management.DTO;
using System;

namespace company_management.DAO
{
    public class CheckinCheckoutDAO
    {
        private readonly company_managementEntities dbContext;

        public CheckinCheckoutDAO() => dbContext = new company_managementEntities();

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
                           CheckoutTime = (DateTime)cico.checkoutTime,
                           TotalHours = (double)cico.totalHours,
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

        public void InitData()
        {
            // Tạo 5 đối tượng CheckinCheckoutDTO với fake data và lưu vào database
            for (int i = 1; i <= 5; i++)
            {
                var checkinCheckoutDTO = new CheckinCheckoutDTO(i, DateTime.Now, DateTime.Today);
                var checkin_checkout = MappingExtensions.ToEntity<CheckinCheckoutDTO, checkin_checkout>(checkinCheckoutDTO);
                dbContext.checkin_checkout.Add(checkin_checkout);
            }
            dbContext.SaveChanges();
        }

    }
}