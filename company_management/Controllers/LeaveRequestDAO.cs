using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class LeaveRequestDAO
    {
        private readonly DBConnection dBConnection;

        public LeaveRequestDAO() => dBConnection = new DBConnection();

        public void loadLeaveRequest(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "leaveRequest");

        public void addLeaveRequest(LeaveRequest leaveRequest)
        {
            string sqlStr = string.Format("INSERT INTO leaveRequest(startDate, endDate, numberDay, reason, status)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", leaveRequest.StartDate, leaveRequest.EndDate, leaveRequest.NumberDay, leaveRequest.Reason, leaveRequest.Status);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateLeaveRequest(LeaveRequest leaveRequest)
        {
            string sqlStr = string.Format("UPDATE LeaveRequest SET " +
                   "startDate = '{0}', endDate = '{1}', numberDay = '{2}', reason = '{3}', status = '{4}' WHERE id = '{5}'",
                   leaveRequest.StartDate, leaveRequest.EndDate, leaveRequest.NumberDay, leaveRequest.Reason, leaveRequest.Status, leaveRequest.IdUser);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteLeaveRequest(int id)
        {
            string sqlStr = string.Format("DELETE FROM LeaveRequest WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }
    }
}