using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public class CheckinCheckout
    {
        private int idCheckin;
        private int idUser;
        private DateTime checkinTime;
        private DateTime checkoutTime;
        private double totalHours;
        private DateTime date;

        public CheckinCheckout() { }

        public CheckinCheckout(int idUser, DateTime checkinTime, 
                               DateTime checkoutTime, double totalHours, DateTime date)
        {
            IdUser = idUser;
            CheckinTime = checkinTime;
            CheckoutTime = checkoutTime;
            TotalHours = totalHours;
            Date = date;
        }

        public int IdCheckin { get => idCheckin; set => idCheckin = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public DateTime CheckinTime { get => checkinTime; set => checkinTime = value; }
        public DateTime CheckoutTime { get => checkoutTime; set => checkoutTime = value; }
        public double TotalHours { get => totalHours; set => totalHours = value; }
        public DateTime Date { get => date; set => date = value; }

        public override string ToString() 
            => $"IdUser: {IdUser}\nCheckinTime: {CheckinTime}" +
               $"\nCheckoutTime: {CheckoutTime}\nTotalHours: {TotalHours}\nDate: {Date}%";
    }
}
