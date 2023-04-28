using System;
using System.Collections.Generic;
using System.Linq;
using company_management.DTO;

namespace company_management.DAO
{
    public class KpiDao
    {

        public KpiDao() {}

        public double CalculateKpi(Salary salary)
        {
            double totalWorkHours = salary.TotalHours + salary.OvertimeHours;
            double kpiValue = totalWorkHours / (totalWorkHours + salary.LeaveHours);
            return kpiValue;
        }

        

    }
}
