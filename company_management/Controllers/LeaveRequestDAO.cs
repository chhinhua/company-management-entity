using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class LeaveRequestDAO
    {
        private readonly DBConnection dBConnection;

        public LeaveRequestDAO() => dBConnection = new DBConnection();

        public void loadLeaveRequest(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "leave_request");

        public void addLeaveRequest(LeaveRequest leaveRequest)
        {
            string sqlStr = string.Format("INSERT INTO leave_request(idUser, startDate, endDate, numberDay, reason, status)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
                leaveRequest.IdUser, leaveRequest.StartDate, leaveRequest.EndDate, leaveRequest.NumberDay, leaveRequest.Reason, leaveRequest.Status);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateLeaveRequest(LeaveRequest leaveRequest)
        {
            string sqlStr = string.Format("UPDATE leave_request SET " +
                   "idUser = '{0}', startDate = '{1}', endDate = '{2}', numberDay = '{3}', reason = '{4}', status = '{5}' WHERE id = '{6}'",
                   leaveRequest.IdUser, leaveRequest.StartDate, leaveRequest.EndDate, leaveRequest.NumberDay, leaveRequest.Reason, leaveRequest.Status, leaveRequest.IdUser);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteLeaveRequest(int id)
        {
            string sqlStr = string.Format("DELETE FROM leave_request WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }
    }
}