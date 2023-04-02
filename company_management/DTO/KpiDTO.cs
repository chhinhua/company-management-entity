using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public class KPI
    {
        private int id;
        private int idUser;
        private string kpiName;
        private string description;
        private int progress;

        public KPI() { }

        public KPI(int idUser, string kpiName, string description, int progress)
        {
            IdUser = idUser;
            KpiName = kpiName;
            Description = description;
            Progress = progress;
        }

        public int Id { get => id; set => id = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string KpiName { get => kpiName; set => kpiName = value; }
        public string Description { get => description; set => description = value; }
        public int Progress { get => progress; set => progress = value; }

        public override string ToString() 
            => $"KPI: {KpiName}\nUser ID: {IdUser}" +
               $"\nDescription: {Description}\nProgress: {Progress}%";
    }
}
