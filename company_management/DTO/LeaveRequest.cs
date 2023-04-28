using System;

namespace company_management.DTO
{
    public class LeaveRequest
    {        
        public int Id { get; set; }
        public int IdUser { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberDay { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }

        public string Employee { get; set; }
        
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
    }
}
