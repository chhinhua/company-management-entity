using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace company_management.DTO
{
    public class Task
    {
        private int id;
        private int idCreator;
        private int idAssignee;
        private string taskName;
        private string description;
        private DateTime deadline;
        private int progress;
        private int idTeam;
        private decimal bonus;

        public Task() { }

        public Task(int idCreator, string taskName, string description,
            DateTime deadline, int progress)
        {
            IdCreator = idCreator;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
        }

        public Task(int idCreator, int idAssignee, string taskName, string description, 
            DateTime deadline, int progress)
        {
            IdCreator = idCreator;
            IdAssignee = idAssignee;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
        }

        public Task(int idCreator, int idAssignee, string taskName, 
            string description, DateTime deadline, int progress, int idTeam)
        {
            IdCreator = idCreator;
            IdAssignee = idAssignee;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
            IdTeam = idTeam;
        }

        public Task(int idCreator, int idAssignee, string taskName,
         string description, DateTime deadline, int progress, int idTeam, decimal bonus)
        {
            IdCreator = idCreator;
            IdAssignee = idAssignee;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
            IdTeam = idTeam;
            Bonus = bonus;
        }

        public int Id { get => id; set => id = value; }
        public int IdCreator { get => idCreator; set => idCreator = value; }
        public int IdAssignee { get => idAssignee; set => idAssignee = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public int Progress { get => progress; set => progress = value; }
        public int IdTeam { get => idTeam; set => idTeam = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
    }
}
