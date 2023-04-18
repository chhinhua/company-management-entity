using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using company_management.DTO;
using company_management.Entities;

namespace company_management.DAO
{
    public class LeaveRequestDAO
    {
        private readonly company_managementEntities dbContext;
        private SalaryDAO salaryDAO;
        private CheckinCheckoutDAO checkinCheckoutDAO;

        public LeaveRequestDAO()
        {
            //dbContext = new company_managementEntities();
            salaryDAO = new SalaryDAO();
            checkinCheckoutDAO = new CheckinCheckoutDAO();
        }

        public List<LeaveRequest> GetAllLeaveRequests()
        {
            var listLeaveRequests = dbContext.leave_request.ToList();

            return listLeaveRequests.Select(lr => MappingExtensions.ToDto<leave_request, LeaveRequest>(lr)).ToList();
        }

        public void InitData()
        {
            using (var db = new company_managementEntities())
            {
                var leaveRequestsDto = new List<LeaveRequest>
                {
                    new LeaveRequest
                    {
                        IdUser = 1,
                        StartDate = new DateTime(2023, 5, 1),
                        EndDate = new DateTime(2023, 5, 5),
                        NumberDay = 5,
                        Reason = "Về quê",
                        Status = "pending"
                    },
                    new LeaveRequest
                    {
                        IdUser = 2,
                        StartDate = new DateTime(2023, 7, 1),
                        EndDate = new DateTime(2023, 7, 2),
                        NumberDay = 2,
                        Reason = "Đi khám bệnh",
                        Status = "approved"
                    },
                    new LeaveRequest
                    {
                        IdUser = 14,
                        StartDate = new DateTime(2023, 6, 10),
                        EndDate = new DateTime(2023, 6, 14),
                        NumberDay = 4,
                        Reason = "Tham gia hội thảo",
                        Status = "rejected"
                    },
                    new LeaveRequest
                    {
                        IdUser = 3,
                        StartDate = new DateTime(2023, 8, 20),
                        EndDate = new DateTime(2023, 8, 22),
                        NumberDay = 3,
                        Reason = "Cưới bạn thân",
                        Status = "cancelled"
                    },
                    new LeaveRequest
                    {
                        IdUser = 1,
                        StartDate = new DateTime(2023, 9, 1),
                        EndDate = new DateTime(2023, 9, 5),
                        NumberDay = 5,
                        Reason = "Du lịch",
                        Status = "pending"
                    }
                };

                foreach (var leaveRequestDto in leaveRequestsDto)
                {
                    var leaveRequest = MappingExtensions.ToEntity<LeaveRequest, leave_request>(leaveRequestDto);
                    db.leave_request.Add(leaveRequest);
                }

                db.SaveChanges();
            }

        }

        public User GetUserById(int userId)
        {
            var userEntity = dbContext.users.FirstOrDefault(u => u.id == userId);

            return MappingExtensions.ToDto<user, User>(userEntity);
        }

        public double GetTotalLeaveHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            double leaveHours = 0;

            // Tính tổng số giờ nghỉ trong các ngày làm việc
            leaveHours += checkinCheckoutDAO.GetLeaveHours(idUser, fromDate, toDate, connection);

            // Tính tổng số giờ nghỉ trong các ngày đã được đăng ký trong bảng đơn xin nghỉ
            string query = "SELECT SUM(numberDay * 8) AS leaveHours " +
                "FROM leave_request WHERE idUser = @idUser " +
                "AND startDate <= @toDate AND endDate >= @fromDate AND status = 'Approved'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUser", idUser);
            command.Parameters.AddWithValue("@fromDate", fromDate.Date);
            command.Parameters.AddWithValue("@toDate", toDate.Date);

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                leaveHours += Convert.ToDouble(result);
            }

            return leaveHours;
        }

    }

}