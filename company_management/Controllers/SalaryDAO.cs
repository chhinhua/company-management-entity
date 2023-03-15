using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class SalaryDAO
    {
        private readonly DBConnection dBConnection;

        public SalaryDAO() => dBConnection = new DBConnection();

        //public void loadSalary(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "salary");

        public void addSalary(Salary salary)
        {
            string sqlStr = string.Format("INSERT INTO salary(idUser, basicSalary, totalHours, overtimeHours, leaveHours, bonus)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                salary.IdUser, salary.BasicSalary, salary.TotalHours, salary.OvertimeHours, salary.LeaveHours, salary.Bonus);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateSalary(Salary salary)
        {
            string sqlStr = string.Format("UPDATE Salary SET " +
                   "idUser = '{0}', basicSalary = '{1}', totalHours = '{2}', overtimeHours = '{3}', leaveHours = '{4}', bonus = '{5}' WHERE id = '{6}'",
                   salary.IdUser, salary.BasicSalary, salary.TotalHours, salary.OvertimeHours, salary.LeaveHours, salary.Bonus, salary.IdSalary);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteSalary(int id)
        {
            string sqlStr = string.Format("DELETE FROM salary WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }
    }
}