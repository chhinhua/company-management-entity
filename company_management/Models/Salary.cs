using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public class Salary
    {
        private int idSalary;
        private int idUser;
        private double basicSalary;
        private double totalHours;
        private double overtimeHours;
        private double leaveHours;
        private double bonus;

        public Salary() { }

        public Salary(int idUser, double basicSalary, double totalHours, double overtimeHours, double leaveHours, double bonus)
        {
            IdUser = idUser;
            BasicSalary = basicSalary;
            TotalHours = totalHours;
            OvertimeHours = overtimeHours;
            LeaveHours = leaveHours;
            Bonus = bonus;
        }

        public int IdSalary { get => idSalary; set => idSalary = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double TotalHours { get => totalHours; set => totalHours = value; }
        public double OvertimeHours { get => overtimeHours; set => overtimeHours = value; }
        public double LeaveHours { get => leaveHours; set => leaveHours = value; }
        public double Bonus { get => bonus; set => bonus = value; }

        public override string ToString()
            => $"User Id: {IdUser}" +
               $"\nBasicSalary: {BasicSalary}" +
               $"\nTotalHours: {TotalHours}" +
               $"\nOvertimeHours: {OvertimeHours}" +
               $"\nLeaveHours: {LeaveHours}" +
               $"\nBonus: {Bonus}%";
    }
}
