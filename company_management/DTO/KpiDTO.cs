using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class KpiDTO
    {
        private int id;
        private int idUser;
        private string kpiName;
        private string description;
        private double value;

        public KpiDTO() { }

        public KpiDTO(int idUser, string kpiName, string description, double value)
        {
            IdUser = idUser;
            KpiName = kpiName;
            Description = description;
            Value = value;
        }

        public int Id { get => id; set => id = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string KpiName { get => kpiName; set => kpiName = value; }
        public string Description { get => description; set => description = value; }
        public double Value { get => value; set => this.value = value; }

        public override string ToString() 
            => $"KPI: {KpiName}\nUser ID: {IdUser}" +
               $"\nDescription: {Description}\nValue: {value}";
    }
}
