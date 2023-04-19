using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class Project
    {
        private int id;
        private int idCreator;
        private int idAssignee;
        private string taskName;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private int progress;
        private int idTeam;
        private decimal bonus;

        public Project() { }

        public Project(int idCreator, int idAssignee, string taskName, string description, 
            DateTime startDate, DateTime endDate, int progress, int idTeam, decimal bonus)
        {
            IdCreator = idCreator;
            IdAssignee = idAssignee;
            TaskName = taskName;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Progress = progress;
            IdTeam = idTeam;
            Bonus = bonus;
        }

        public int Id { get => id; set => id = value; }
        public int IdCreator { get => idCreator; set => idCreator = value; }
        public int IdAssignee { get => idAssignee; set => idAssignee = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int Progress { get => progress; set => progress = value; }
        public int IdTeam { get => idTeam; set => idTeam = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
    }
}
