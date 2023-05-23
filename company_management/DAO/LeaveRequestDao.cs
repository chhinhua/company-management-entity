using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AutoMapper;
using company_management.DTO;
using company_management.Entity;
using company_management.Utilities;
using company_management.View;
using System.Windows.Forms;

// ReSharper disable All

namespace company_management.DAO
{
    public sealed class LeaveRequestDao : IDisposable
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        private DBConnection _dBConnection;
        private readonly Utils _utils;

        public LeaveRequestDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
            _dBConnection = new DBConnection();
            _utils = new Utils();
        }

        public void AddRequest(LeaveRequest request)
        {
            try
            {
                var newLeaveRequest = _mapper.Map<leaveRequest>(request);
                _dbContext.leaveRequests.Add(newLeaveRequest);
                _dbContext.SaveChanges();

                // Thông báo thành công
                _utils.Alert("Add successful", FormAlert.enmType.Success);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                _utils.Alert("Add failed", FormAlert.enmType.Error);
            }

        }
         
        public void UpdateRequest(LeaveRequest request)
        {
            var leaveRequest = _dbContext.leaveRequests.FirstOrDefault(lr => lr.id == request.Id);
            if (leaveRequest != null)
            {
                leaveRequest.idUser = request.IdUser;
                leaveRequest.requestDate = request.RequestDate;
                leaveRequest.startDate = request.StartDate;
                leaveRequest.endDate = request.EndDate;
                leaveRequest.numberDay = request.NumberDay;
                leaveRequest.content = request.Content;
                leaveRequest.status = request.Status;

                _dbContext.SaveChanges();

                _utils.Alert("Successful", FormAlert.enmType.Success);
            }
            else
            {
                _utils.Alert("Action failed", FormAlert.enmType.Error);
            }
        }
        
        public void DeleteRequest(int id)
        {
            var leaveRequest = _dbContext.leaveRequests.FirstOrDefault(lr => lr.id == id);
            if (leaveRequest != null)
            {
                _dbContext.leaveRequests.Remove(leaveRequest);
                _dbContext.SaveChanges();
                _utils.Alert("Deleted successful", FormAlert.enmType.Success);
            }
            else
            {
                _utils.Alert("Deleted failed", FormAlert.enmType.Error);
            }
        }
        
        public void UpdateManaRequest(LeaveRequest request)
        {
            var leaveRequest = _dbContext.leaveRequests.FirstOrDefault(lr => lr.id == request.Id);
            if (leaveRequest != null)
            {
                leaveRequest.idUser = request.IdUser;
                leaveRequest.requestDate = request.RequestDate;
                leaveRequest.startDate = request.StartDate;
                leaveRequest.endDate = request.EndDate;
                leaveRequest.numberDay = request.NumberDay;
                leaveRequest.content = request.Content;
                leaveRequest.status = request.Status;
                leaveRequest.idApprover = request.IdApprover;

                _dbContext.SaveChanges();

                _utils.Alert("Updated successful", FormAlert.enmType.Success);
            }
            else
            {
                _utils.Alert("Update failed", FormAlert.enmType.Error);
            }
        }
        
        public List<LeaveRequest> GetAllLeaveRequests()
        {
            var leaveRequests = _dbContext.leaveRequests.ToList();
            return _mapper.Map<List<LeaveRequest>>(leaveRequests);
        }

        public leaveRequest GetRequestById(int id)
        {
            var leaveRequest = _dbContext.leaveRequests.FirstOrDefault(lr => lr.id == id);
            return leaveRequest;
        }

        public List<LeaveRequest> GetMyLeaveRequests(int idUser)
        {
            return GetAllLeaveRequests().Where(s => s.IdUser == idUser).ToList();
        }
        
        public double GetTotalLeaveHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            double leaveHours = _dbContext.leaveRequests
                .Where(lr => lr.idUser == idUser && lr.startDate <= toDate && lr.endDate >= fromDate && lr.status == "Approved")
                .Sum(lr => lr.numberDay * 8) ?? 0;

            leaveHours = Math.Max(0, leaveHours);

            return leaveHours;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Giải phóng các tài nguyên quản lý ở đây.
                if (_dBConnection != null)
                {
                    _dBConnection.Dispose(); // Giải phóng đối tượng DBConnection
                    _dBConnection = null;
                }
            }
        }
    }
}