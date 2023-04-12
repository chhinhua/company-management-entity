using System;
using System.Collections.Generic;
using System.Linq;
using company_management.DTO;
using company_management.Entities;
using company_management.DTO;

namespace company_management.DAO
{
    public class SalaryDAO
    {
        private readonly company_managementEntities dbContext;
        public static readonly decimal DEFAULT_BASIC_SALARY = 6500000;

        public SalaryDAO() => dbContext = new company_managementEntities();

        public List<SalaryDTO> GetAllSalaries()
        {
            var listSalary = dbContext.salaries.ToList();

            return listSalary.Select(salary => MappingExtensions.ToDto<salary, SalaryDTO>(salary)).ToList();
        }

        public void InitData()
        {
            var listSalaryDTO = new List<SalaryDTO>
                {
                    // SalaryDTO(idUser, basicSalary, totalHours, overtimeHours, leaveHours, bonus)
                    new SalaryDTO(1, DEFAULT_BASIC_SALARY, 176, 4, 0, 500000),
                    new SalaryDTO(2, DEFAULT_BASIC_SALARY, 169, 24, 8, 400000),
                    new SalaryDTO(4, DEFAULT_BASIC_SALARY, 180, 8, 4, 650000),
                    new SalaryDTO(14, DEFAULT_BASIC_SALARY, 200, 8, 0, 1000000),
                    new SalaryDTO(3, DEFAULT_BASIC_SALARY, 176, 16, 0, 650000),
                    new SalaryDTO(6, DEFAULT_BASIC_SALARY, 176, 8, 4, 500000),                
                };

            foreach (var salaryDTO in listSalaryDTO)
            {
                var salary = MappingExtensions.ToEntity<SalaryDTO, salary>(salaryDTO);
                dbContext.salaries.Add(salary);
            }

            dbContext.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            var userEntity = dbContext.users.FirstOrDefault(u => u.id == userId);

            return MappingExtensions.ToDto<user, User>(userEntity);
        }

        public decimal calculateBonus(double kpiValue, double averageProgress)
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
    }
}