using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class SalaryDTO
    {
        private int id;
        private int idUser;
        private decimal basicSalary;
        private double totalHours;
        private double overtimeHours;
        private double leaveHours;
        private decimal bonus;
        private decimal finalSalary;

        public SalaryDTO() { }

        public SalaryDTO(int idUser, decimal basicSalary, double totalHours, double overtimeHours,
                        double leaveHours, decimal bonus)
        {
            IdUser = idUser;
            BasicSalary = basicSalary;
            TotalHours = totalHours;
            OvertimeHours = overtimeHours;
            LeaveHours = leaveHours;
            Bonus = bonus;
            FinalSalary = calculateFinalSalary();
        }

        public decimal calculateFinalSalary()
        {
            decimal hourlyRate = BasicSalary / 176;
            decimal overtimeRate = 1.5m * hourlyRate;

            decimal overtimePay = (decimal)OvertimeHours * overtimeRate;
            decimal leaveDeduction = (decimal)LeaveHours * hourlyRate;
            decimal finalSalary = BasicSalary + overtimePay - leaveDeduction + Bonus;

            return Math.Round(finalSalary, 2); // làm tròn đến 2 chữ số sau dấu phẩy
        }

        public int Id { get => id; set => id = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double TotalHours { get => totalHours; set => totalHours = value; }
        public double OvertimeHours { get => overtimeHours; set => overtimeHours = value; }
        public double LeaveHours { get => leaveHours; set => leaveHours = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal FinalSalary { get => finalSalary; set => finalSalary = value; }

        public override string ToString()
            => $"User Id: {IdUser}" +
               $"\nBasicSalary: {BasicSalary}" +
               $"\nTotalHours: {TotalHours}" +
               $"\nOvertimeHours: {OvertimeHours}" +
               $"\nLeaveHours: {LeaveHours}" +
               $"\nBonus: {Bonus}%" +
               $"\nFinal Salary: {FinalSalary}%";
    }
}
