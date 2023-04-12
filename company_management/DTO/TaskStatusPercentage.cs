using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class TaskStatusPercentage
    {
        public double TodoPercent { get; set; }
        public double InprogressPercent { get; set; }
        public double DonePercent { get; set; }

        public TaskStatusPercentage(double todoPercent, double inprogressPercent, double donePercent)
        {
            TodoPercent = todoPercent;
            InprogressPercent = inprogressPercent;
            DonePercent = donePercent;
        }

        public TaskStatusPercentage(){}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
