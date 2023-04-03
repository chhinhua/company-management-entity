using System;
using System.Collections.Generic;
using System.Linq;
using company_management.DTO;
using company_management.Entities;
using company_management.Models;

namespace company_management.Controllers
{
    public class LeaveRequestDAO
    {
        private readonly company_managementEntities dbContext;

        public LeaveRequestDAO()
        {
            dbContext = new company_managementEntities();
        }     

        public List<LeaveRequestDTO> GetAllLeaveRequests()
        {
            var listLeaveRequests = dbContext.leave_request.ToList();

            return listLeaveRequests.Select(lr => MappingExtensions.ToDto<leave_request, LeaveRequestDTO>(lr)).ToList();
        }

        public void InitData()
        {
            using (var db = new company_managementEntities())
            {
                var leaveRequestsDto = new List<LeaveRequestDTO>
                {
                    new LeaveRequestDTO
                    {
                        IdUser = 1,
                        StartDate = new DateTime(2023, 5, 1),
                        EndDate = new DateTime(2023, 5, 5),
                        NumberDay = 5,
                        Reason = "Về quê",
                        Status = "pending"
                    },
                    new LeaveRequestDTO
                    {
                        IdUser = 2,
                        StartDate = new DateTime(2023, 7, 1),
                        EndDate = new DateTime(2023, 7, 2),
                        NumberDay = 2,
                        Reason = "Đi khám bệnh",
                        Status = "approved"
                    },
                    new LeaveRequestDTO
                    {
                        IdUser = 14,
                        StartDate = new DateTime(2023, 6, 10),
                        EndDate = new DateTime(2023, 6, 14),
                        NumberDay = 4,
                        Reason = "Tham gia hội thảo",
                        Status = "rejected"
                    },
                    new LeaveRequestDTO
                    {
                        IdUser = 3,
                        StartDate = new DateTime(2023, 8, 20),
                        EndDate = new DateTime(2023, 8, 22),
                        NumberDay = 3,
                        Reason = "Cưới bạn thân",
                        Status = "cancelled"
                    },
                    new LeaveRequestDTO
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
                    var leaveRequest = MappingExtensions.ToEntity<LeaveRequestDTO, leave_request>(leaveRequestDto);
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

    }

}