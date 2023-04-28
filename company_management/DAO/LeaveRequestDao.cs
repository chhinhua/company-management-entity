using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using company_management.DTO;

namespace company_management.DAO
{
    public sealed class LeaveRequestDao : IDisposable
    {
        private DBConnection _dBConnection;

        public LeaveRequestDao()
        {
            
        }

        /* public User GetUserById(int userId)
         {
             var userEntity = dbContext.users.FirstOrDefault(u => u.id == userId);

             return MappingExtensions.ToDto<user, User>(userEntity);
         }*/

        public double GetTotalLeaveHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            double leaveHours = 0;

            // Tìm tất cả các đơn xin nghỉ được chấp thuận trong khoảng thời gian fromDate - toDate
            string query = "SELECT SUM(numberDay * 8) AS leaveHours " +
                           "FROM leave_request WHERE idUser = @idUser " +
                           "AND startDate <= @toDate AND endDate >= @fromDate AND status = 'Approved'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@fromDate", fromDate.Date);
                command.Parameters.AddWithValue("@toDate", toDate.Date);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        leaveHours += Convert.ToDouble(reader["leaveHours"]);
                    }
                }
            }

            return Math.Max(0, leaveHours); // Return non-negative leave hours
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