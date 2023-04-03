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
        private double basicSalary;
        private double totalHours;
        private double overtimeHours;
        private double leaveHours;
        private double bonus;

        public SalaryDTO() { }

        public SalaryDTO(int idUser, double basicSalary, double totalHours, double overtimeHours, double leaveHours, double bonus)
        {
            IdUser = idUser;
            BasicSalary = basicSalary;
            TotalHours = totalHours;
            OvertimeHours = overtimeHours;
            LeaveHours = leaveHours;
            Bonus = bonus;
        }

        public int Id { get => id; set => id = value; }
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
