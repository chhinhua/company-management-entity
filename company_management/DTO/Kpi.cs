using System;

namespace company_management.DTO
{
    public class Kpi
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string KpiName { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        
        public Kpi() { }

        public Kpi(int idUser, string kpiName, string description, double value)
        {
            IdUser = idUser;
            KpiName = kpiName;
            Description = description;
            Value = value;
        }
    }
}
