using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using company_management.DTO;
using company_management.Entities;

namespace company_management.DAO
{
    public class SalaryDAO
    {
        private readonly DBConnection dBConnection;
        private readonly company_managementEntities dbContext;
        private CheckinCheckoutDAO checkinCheckoutDAO;
        private LeaveRequestDAO leaveRequestDAO;
        private SalaryDAO salaryDAO;
        private TaskDAO taskDAO;
        public static readonly decimal DEFAULT_BASIC_SALARY = 500; // 500$ 
        

        public SalaryDAO()
        {
            //dbContext = new company_managementEntities();
            dBConnection = new DBConnection();
            checkinCheckoutDAO = new CheckinCheckoutDAO();
            leaveRequestDAO = new LeaveRequestDAO();
            salaryDAO = new SalaryDAO();
            taskDAO = new TaskDAO();
        }

        public List<Salary> GetAllSalaries()
        {
            var listSalary = dbContext.salaries.ToList();

            return listSalary.Select(salary => MappingExtensions.ToDto<salary, Salary>(salary)).ToList();
        }

        public void InitData()
        {
            var listSalaryDTO = new List<Salary>
                {
                    // SalaryDTO(idUser, basicSalary, totalHours, overtimeHours, leaveHours, bonus)
                    new Salary(1, DEFAULT_BASIC_SALARY, 176, 4, 0, 500000),
                    new Salary(2, DEFAULT_BASIC_SALARY, 169, 24, 8, 400000),
                    new Salary(4, DEFAULT_BASIC_SALARY, 180, 8, 4, 650000),
                    new Salary(14, DEFAULT_BASIC_SALARY, 200, 8, 0, 1000000),
                    new Salary(3, DEFAULT_BASIC_SALARY, 176, 16, 0, 650000),
                    new Salary(6, DEFAULT_BASIC_SALARY, 176, 8, 4, 500000),                
                };

            foreach (var salaryDTO in listSalaryDTO)
            {
                var salary = MappingExtensions.ToEntity<Salary, salary>(salaryDTO);
                dbContext.salaries.Add(salary);
            }

            dbContext.SaveChanges();
        }

        public decimal CalculateBonus(double kpiValue, double averageProgress)
        {
            decimal bonus = 0;
            double kpiWithProgress = kpiValue + averageProgress;

            // Tính toán lương bonus
            if (kpiWithProgress >= 0.7)
            {
                bonus = (decimal)kpiWithProgress * (decimal)DEFAULT_BASIC_SALARY;
            }
            return bonus;
        }

        public Salary CalculateSalaryForEmployee(int idUser, DateTime fromDate, DateTime toDate)
        {
            Salary salary = new Salary();
            salary.IdUser = idUser;

            using (SqlConnection connection = new SqlConnection(DBConnection.connString))
            {
                connection.Open();

                // Tính toán lương cơ bản
                decimal basicSalary = DEFAULT_BASIC_SALARY; // Giá trị lương cơ bản mặc định
                double totalHours = checkinCheckoutDAO.GetTotalHours(idUser, fromDate, toDate, connection);
                double overtimeHours = checkinCheckoutDAO.GetOvertimeHours(idUser, fromDate, toDate, connection);
                double leaveHours = checkinCheckoutDAO.GetLeaveHours(idUser, fromDate, toDate, connection);
                decimal bonus = taskDAO.CalculateBonusForEmployee(idUser, fromDate, toDate);

                salary.BasicSalary = basicSalary;
                salary.TotalHours = totalHours;
                salary.OvertimeHours = overtimeHours;
                salary.LeaveHours = leaveHours;
                salary.FinalSalary = salary.BasicSalary
                    + ((decimal)salary.TotalHours * Constants.HourlyRate)
                    + ((decimal)salary.OvertimeHours * 1.5m * Constants.HourlyRate)
                    + bonus
                    - ((decimal)salary.LeaveHours * Constants.HourlyRate);
            }

            return salary;
        }

        public void CalculateAndSaveSalaryForAllEmployees(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.connString))
            {
                connection.Open();
                string query = "SELECT id FROM users";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idUser = (int)reader["id"];
                    Salary salary = CalculateSalaryForEmployee(idUser, fromDate, toDate);

                    // Lưu thông tin lương vào bảng salary
                    query = "INSERT INTO salary (idUser, basicSalary, totalHours, overtimeHours, leaveHours, bonus, finalSalary) VALUES (@idUser, @basicSalary, @totalHours, @overtimeHours, @leaveHours, @bonus, @finalSalary)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUser", salary.IdUser);
                    command.Parameters.AddWithValue("@basicSalary", salary.BasicSalary);
                    command.Parameters.AddWithValue("@totalHours", (decimal)salary.TotalHours);
                    command.Parameters.AddWithValue("@overtimeHours", (decimal)salary.OvertimeHours);
                    command.Parameters.AddWithValue("@leaveHours", (decimal)salary.LeaveHours);
                    command.Parameters.AddWithValue("@bonus", salary.Bonus);
                    command.Parameters.AddWithValue("@finalSalary", salary.FinalSalary);
                    command.ExecuteNonQuery();
                }
                reader.Close();
            }
        }
    }
}