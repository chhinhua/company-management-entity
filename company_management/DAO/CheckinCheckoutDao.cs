using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using company_management.Entity;
using company_management.Utilities;
using company_management.View;
using company_management.View.UC;

// ReSharper disable All

namespace company_management.DAO
{
    public sealed class CheckinCheckoutDao : IDisposable
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        private readonly DBConnection _dBConnection;
        private readonly Utils _utils;
        private bool _disposed;

        public CheckinCheckoutDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
            _dBConnection = new DBConnection();
            _utils = new Utils();
        }

        public void AddCheckinCo(CheckinCheckout cico)
        {
            try
            {
                var newCico = _mapper.Map<checkin_checkout>(cico);
                _dbContext.checkin_checkout.Add(newCico);
                _dbContext.SaveChanges();
                _utils.Alert("Checkin thành công", FormAlert.enmType.Success);
                UcTimeKeeping.LastCheckinCheckoutId = newCico.id;
            }
            catch (Exception)
            {
                _utils.Alert("Đang gặp sự cố!", FormAlert.enmType.Error);
            }
        }

        public void UpdateCheckinCo(CheckinCheckout cico)
        {
            var cicoToUpdate = _dbContext.checkin_checkout.Find(cico.Id);
            if (cicoToUpdate != null)
            {
                cicoToUpdate.checkoutTime = cico.CheckoutTime;
                cicoToUpdate.totalHours = cico.CalculateTotalHours();

                try
                {
                    _dbContext.SaveChangesAsync();
                    _utils.Alert("Checkout thành công", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    _utils.Alert("Không thành công!", FormAlert.enmType.Error);
                }
            }
            else
            {
                _utils.Alert("Không tìm thấy!", FormAlert.enmType.Warning);
            }
        }

        public void DeleteCheckinCo(int id)
        {
            try
            {
                var cicoToDelete = _dbContext.checkin_checkout.Find(id);
                if (cicoToDelete != null)
                {
                    _dbContext.checkin_checkout.Remove(cicoToDelete);
                    _dbContext.SaveChanges();
                    _utils.Alert("Xóa thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Xóa không thành công!", FormAlert.enmType.Error);
            }
        }

        public CheckinCheckout GetCheckinCheckoutById(int id)
        {
            var cico = _dbContext.checkin_checkout.Find(id);
            return _mapper.Map<CheckinCheckout>(cico);
        }

        public List<CheckinCheckout> GetAllCheckinCheckouts()
        {
            var cicoList = _dbContext.checkin_checkout.ToList();
            return _mapper.Map<List<CheckinCheckout>>(cicoList);
        }

        public List<CheckinCheckout> GetMyCheckinCoCheckouts(int idUser)
        {
            return GetAllCheckinCheckouts().Where(c => c.IdUser == idUser).ToList();
        }

        // Checkin mà chưa checkout
        public List<CheckinCheckout> GetIncompleteCheckinCheckouts(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCheckouts()
                .Where(c => c.IdUser == idUser && c.CheckoutTime == defaultDateTime)
                .ToList();
        }

        // Hoàn thành checkin checkout
        public List<CheckinCheckout> GetCompleteCheckinCheckouts(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCheckouts()
                .Where(c => c.IdUser == idUser && c.CheckoutTime != defaultDateTime)
                .ToList();
        }

        // Lọc theo ngày
        public List<CheckinCheckout> GetCheckinCheckoutByDate(DateTime selectedDate)
        {
            return GetAllCheckinCheckouts()
                .Where(c => c.Date.Date == selectedDate.Date)
                .ToList();
        }

        // tổng số giờ làm việc của mỗi nhân viên trong một ngày
        public double GetTotalHours(int idUser, DateTime fromDate, DateTime toDate)
        {
            var totalHours = _dbContext.checkin_checkout
                .Where(cc => cc.idUser == idUser && cc.date >= fromDate.Date && cc.date <= toDate.Date)
                .Sum(cc => cc.totalHours) ?? 0;

            return totalHours;
        }

        // số giờ tăng ca của mỗi nhân viên trong một ngày
        public double GetOvertimeHours(int idUser, DateTime fromDate, DateTime toDate)
        {
            var overtimeHours = _dbContext.checkin_checkout
                .Where(cc => cc.idUser == idUser && cc.date >= fromDate.Date && cc.date <= toDate.Date)
                .Sum(cc => cc.totalHours > 8 ? cc.totalHours - 8 : 0) ?? 0;

            return overtimeHours;
        }

        //  số giờ nghỉ phép của mỗi nhân viên trong một ngày
        public double GetLeaveHours(int idUser, DateTime fromDate, DateTime toDate)
        {
            var leaveHours = _dbContext.checkin_checkout
                .Where(cc => cc.idUser == idUser && cc.date >= fromDate.Date && cc.date <= toDate.Date)
                .Sum(cc => cc.totalHours < 8 ? 8 - cc.totalHours : 0) ?? 0;

            return leaveHours;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _dBConnection.Dispose();
            }

            _disposed = true;
        }

        ~CheckinCheckoutDao()
        {
            Dispose(false);
        }
    }
}