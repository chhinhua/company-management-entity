using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using company_management.Views;
using company_management.BUS;

namespace company_management.DAO
{
    public class CheckinCheckoutDAO
    {
        //private readonly company_managementEntities dbContext;
        private readonly DBConnection dBConnection;
        private List<Task> listTask;
        private TeamDAO teamDAO;
        private UserDAO userDAO;

        public CheckinCheckoutDAO()
        {
            //dbContext = new company_managementEntities();
            dBConnection = new DBConnection();
            listTask = new List<Task>();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
        }

        public void AddCheckinCO(CheckinCheckout cico)
        {
            string query = string.Format("INSERT INTO checkin_checkout(idUser, checkinTime, date) VALUES ('{0}', '{1}', '{2}'); SELECT SCOPE_IDENTITY();",
                                      cico.IdUser, cico.CheckinTime, cico.Date);
            int id = Convert.ToInt32(dBConnection.ExecuteScalar(query)); // lấy giá trị ID từ cơ sở dữ liệu
            UCTimeKeeping.lastCheckinCheckoutId = id;
        }

        public void UpdateCheckinCO(CheckinCheckout cico)
        {
            string sqlStr = string.Format("UPDATE checkin_checkout SET checkoutTime = '{0}', totalHours = '{1}' WHERE id = '{2}'",
                   cico.CheckoutTime, cico.CalculateTotalHours(), cico.Id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public void DeleteCheckinCO(int id)
        {
            string sqlStr = string.Format("DELETE FROM task WHERE id = '{0}'", id);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public CheckinCheckout GetCheckinCOById(int id)
        {
            string query = string.Format("SELECT * FROM checkin_checkout WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<CheckinCheckout>(query);
        }

        public List<CheckinCheckout> GetAllCheckinCO()
        {
            string query = string.Format("SELECT * FROM checkin_checkout");
            return dBConnection.GetListObjectsByQuery<CheckinCheckout>(query);
        }

        public List<CheckinCheckout> SearchCheckinCO(string txtSearch)
        {
            string query = string.Format("SELECT t.* FROM task t " +
                "INNER JOIN teams tm ON t.idTeam = tm.id " +
                "INNER JOIN users u ON(t.idCreator = u.id OR t.idAssignee = u.id) " +
                "WHERE t.taskName LIKE '%{0}%' " +
                "OR t.description LIKE '%{0}%' " +
                "OR tm.name LIKE '%{0}%' " +
                "OR u.username LIKE '%{0}%' ", txtSearch);
            return dBConnection.GetListObjectsByQuery<CheckinCheckout>(query);
        }

        // Danh sách cico của người đăng nhập
        public List<CheckinCheckout> GetMyCheckinCO(int idUser)
        {
            return GetAllCheckinCO().Where(c => c.IdUser == idUser).ToList();
        }

        // Checkin mà chưa checkout
        public List<CheckinCheckout> GetIncompleteCheckinCO(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCO()
                .Where(c => c.IdUser == idUser && c.CheckoutTime == defaultDateTime)
                .ToList();
        }

        // Hoàn thành checkin checkout
        public List<CheckinCheckout> GetCompleteCheckinCO(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCO()
                .Where(c => c.IdUser == idUser && c.CheckoutTime != defaultDateTime)
                .ToList();
        }

        // Lọc theo ngày
        public List<CheckinCheckout> GetCheckinCOByDate(DateTime selectedDate)
        {
            return GetAllCheckinCO()
                .Where(c => c.Date.Date == selectedDate.Date)
                .ToList();
        }

        public List<Task> SearchTasks(string txtSearch)
        {
            string query = string.Format("SELECT t.* FROM task t " +
                "INNER JOIN teams tm ON t.idTeam = tm.id " +
                "INNER JOIN users u ON(t.idCreator = u.id OR t.idAssignee = u.id) " +
                "WHERE t.taskName LIKE '%{0}%' " +
                "OR t.description LIKE '%{0}%' " +
                "OR tm.name LIKE '%{0}%' " +
                "OR u.username LIKE '%{0}%' ", txtSearch);
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

        public void SetTotalHours(CheckinCheckout checkin)
        {
            double totalHours = (checkin.CheckoutTime - checkin.CheckinTime).TotalHours;
            string sqlStr = string.Format("UPDATE checkin_checkout SET totalHours = '{0}' WHERE idUser = '{1}' AND date = '{2}'",
                   totalHours, checkin.IdUser, checkin.Date);
            dBConnection.ExecuteQuery(sqlStr);
        }

        public CheckinCheckout GetCheckinById(int id)
        {
            string query = string.Format("SELECT * FROM checkin_checkout WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<CheckinCheckout>(query);
        }

        // tổng số giờ làm việc của mỗi nhân viên trong một ngày
        public double GetTotalHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            string query = "SELECT SUM(totalHours) AS totalHours " +
                "FROM checkin_checkout WHERE idUser = @idUser " +
                "AND date BETWEEN @fromDate AND @toDate";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUser", idUser);
            command.Parameters.AddWithValue("@fromDate", fromDate.Date);
            command.Parameters.AddWithValue("@toDate", toDate.Date);

            object result = command.ExecuteScalar();
            return Convert.ToDouble(result);
        }

        // số giờ tăng ca của mỗi nhân viên trong một ngày
        public double GetOvertimeHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            string query = "SELECT SUM(CASE WHEN totalHours > 8 THEN totalHours - 8 ELSE 0 END) AS overtimeHours FROM checkin_checkout WHERE idUser = @idUser AND date BETWEEN @fromDate AND @toDate";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUser", idUser);
            command.Parameters.AddWithValue("@fromDate", fromDate.Date);
            command.Parameters.AddWithValue("@toDate", toDate.Date);

            object result = command.ExecuteScalar();
            return Convert.ToDouble(result);
        }

        //  số giờ nghỉ phép của mỗi nhân viên trong một ngày
        public double GetLeaveHours(int idUser, DateTime fromDate, DateTime toDate, SqlConnection connection)
        {
            string query = "SELECT SUM(8 - totalHours) AS leaveHours FROM checkin_checkout WHERE idUser = @idUser AND date BETWEEN @fromDate AND @toDate";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUser", idUser);
            command.Parameters.AddWithValue("@fromDate", fromDate.Date);
            command.Parameters.AddWithValue("@toDate", toDate.Date);

            object result = command.ExecuteScalar();
            return Convert.ToDouble(result);
        }

    }
}