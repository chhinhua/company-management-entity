using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class TimeKeepingDTO
    {
        public string Employee { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public double TotalHours { get; set; }
        public DateTime Date { get; set; }
    }
}
