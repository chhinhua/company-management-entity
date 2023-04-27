using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using company_management.DTO;
using company_management.Entities;

namespace company_management.DAO
{
    public class SalaryDao
    {
        private readonly DBConnection _dBConnection;
        private readonly Lazy<CheckinCheckoutDao> _cicoDao;
        private readonly Lazy<LeaveRequestDao> _leaveRequestDao;
        private Lazy<SalaryDao> _salaryDao;
        private readonly Lazy<TaskDao> _taskDao;
        private readonly Lazy<UserDao> _userDao;

        public SalaryDao()
        {
            //dbContext = new company_managementEntities();
            _dBConnection = new DBConnection();
            _cicoDao = new Lazy<CheckinCheckoutDao>(() => new CheckinCheckoutDao());
            _leaveRequestDao = new Lazy<LeaveRequestDao>(() => new LeaveRequestDao());
            _salaryDao = new Lazy<SalaryDao>(() => new SalaryDao());
            _taskDao = new Lazy<TaskDao>(() => new TaskDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
        }

        //public List<Salary> GetAllSalaries()
        //{
        //    var listSalary = dbContext.salaries.ToList();

        //    return listSalary.Select(salary => MappingExtensions.ToDto<salary, Salary>(salary)).ToList();
        //}

        public decimal CalculateBonus(double kpiValue, double averageProgress)
        {
            decimal bonus = 0;
            double kpiWithProgress = kpiValue + averageProgress;

            // Tính toán lương bonus
            if (kpiWithProgress >= 0.7)
            {
                bonus = (decimal)kpiWithProgress * (decimal)Constants.DEFAULT_BASIC_SALARY;
            }
            return bonus;
        }

        private Salary CalculateSalaryForEmployee(int idUser, DateTime fromDate, DateTime toDate)
        {
            Salary salary = new Salary();
            salary.IdUser = idUser;

            using (SqlConnection connection = new SqlConnection(_dBConnection.connString))
            {
                connection.Open();

                // Tính toán các thành phần của lương
                double totalHours = 0;
                double overtimeHours = 0;
                double leaveHours = 0;
                decimal bonus = 0;

                using (var taskDao = _taskDao.Value)
                {
                    bonus = taskDao.CalculateBonusForEmployee(idUser, fromDate, toDate);
                }

                using (var lrDao = _leaveRequestDao.Value)
                {
                    leaveHours += lrDao.GetTotalLeaveHours(idUser, fromDate, toDate, connection);
                }

                using (var cicoDao = _cicoDao.Value)
                {
                    totalHours = cicoDao.GetTotalHours(idUser, fromDate, toDate, connection);
                    overtimeHours = cicoDao.GetOvertimeHours(idUser, fromDate, toDate, connection);
                    leaveHours = cicoDao.GetLeaveHours(idUser, fromDate, toDate, connection);
                }

                // Tính toán lương
                decimal basicSalary = Constants.DEFAULT_BASIC_SALARY; // Giá trị lương cơ bản mặc định
                decimal hourlyRate = Constants.HourlyRate;

                decimal totalBasicSalary = basicSalary + ((decimal)totalHours * hourlyRate);
                decimal overtimePay = (decimal)overtimeHours * 1.5m * hourlyRate;
                decimal leavePay = (decimal)leaveHours * hourlyRate;
                decimal finalSalary = totalBasicSalary + overtimePay + bonus - leavePay;

                salary.BasicSalary = basicSalary;
                salary.TotalHours = totalHours;
                salary.OvertimeHours = overtimeHours;
                salary.LeaveHours = leaveHours;
                salary.FinalSalary = finalSalary;
            }   

            return salary;
        }

        private List<int> GetUserIdList()
        {
            using(var userDao = _userDao.Value)
            {
                List<User> userList = userDao.GetAllUser();
                List<int> userIds = userList.Select(u => u.Id).ToList();
                return userIds;
            }        
        }

        public void CalculateAndSaveSalaryForAllEmployees(DateTime fromDate, DateTime toDate)
        {
            List<int> userIds = GetUserIdList();

            using (SqlConnection connection = new SqlConnection(_dBConnection.connString))
            {
                connection.Open();
                foreach (int idUser in userIds)
                {
                    Salary salary = CalculateSalaryForEmployee(idUser, fromDate, toDate);

                    // Lưu thông tin lương vào bảng salary
                    string query = "INSERT INTO salary (idUser, basicSalary, totalHours, overtimeHours, leaveHours, bonus, finalSalary) VALUES (@idUser, @basicSalary, @totalHours, @overtimeHours, @leaveHours, @bonus, @finalSalary)";
                    SqlCommand insertCommand = new SqlCommand(query, connection);
                    insertCommand.Parameters.AddWithValue("@idUser", salary.IdUser);
                    insertCommand.Parameters.AddWithValue("@basicSalary", salary.BasicSalary);
                    insertCommand.Parameters.AddWithValue("@totalHours", (decimal)salary.TotalHours);
                    insertCommand.Parameters.AddWithValue("@overtimeHours", (decimal)salary.OvertimeHours);
                    insertCommand.Parameters.AddWithValue("@leaveHours", (decimal)salary.LeaveHours);
                    insertCommand.Parameters.AddWithValue("@bonus", salary.Bonus);
                    insertCommand.Parameters.AddWithValue("@finalSalary", salary.FinalSalary);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}