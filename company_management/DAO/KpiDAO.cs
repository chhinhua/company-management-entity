using System;
using System.Collections.Generic;
using System.Linq;
using company_management.DTO;
using company_management.Entities;

namespace company_management.DAO
{
    public class KpiDAO
    {
        private readonly company_managementEntities dbContext;

        public KpiDAO() => dbContext = new company_managementEntities();

        public double calculateKPI(Salary salary)
        {
            double totalWorkHours = salary.TotalHours + salary.OvertimeHours;
            double kpiValue = totalWorkHours / (totalWorkHours + salary.LeaveHours);
            return kpiValue;
        }

        

    }
}
