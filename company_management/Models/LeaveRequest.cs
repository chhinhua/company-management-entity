using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public class LeaveRequest
    {
        private int idLeave;
        private int idUser;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDay;
        private string reason;
        private string status;

        public LeaveRequest() { }

        public LeaveRequest(int idUser, DateTime startDate, DateTime endDate, int numberDay, string reason, string status)
        {
            IdUser = idUser;
            StartDate = startDate;
            EndDate = endDate;
            NumberDay = numberDay;
            Reason = reason;
            Status = status;
        }

        public int IdLeave { get => idLeave; set => idLeave = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int NumberDay { get => numberDay; set => numberDay = value; }
        public string Reason { get => reason; set => reason = value; }
        public string Status { get => status; set => status = value; }

        public override string ToString() 
            => $"IdUser: {IdUser}\nStartDate: {StartDate}\nEndDate: {EndDate}" +
               $"\nNumberDay: {NumberDay}\nReason: {Reason}\nStatus: {Status}%";
    }
}
