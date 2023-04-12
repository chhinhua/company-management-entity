using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class Task
    {
        private int id;
        private int idUser;
        private string taskName;
        private string description;
        private DateTime deadline;
        private int progress;
        private int idTeam;

        public Task() { }

        public Task(int idUser, string taskName, string description,
            DateTime deadline, int progress)
        {
            IdUser = idUser;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
        }

        public Task(int idUser, string taskName, string description, 
            DateTime deadline, int progress, int idTeam)
        {
            IdUser = idUser;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
            IdTeam = idTeam;
        }

        public int Id { get => id; set => id = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public int Progress { get => progress; set => progress = value; }
        public int IdTeam { get => idTeam; set => idTeam = value; }
        public int IdPosition { get => idPosition; set => idPosition = value; }

        public override string ToString()
            => $"User Id: {IdUser}\nTaskName: {TaskName}" +
               $"\nDescription: {Description}\nDeadline: {Deadline}\nProgress: {Progress}%";

    }
}
