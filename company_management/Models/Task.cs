using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public class Task
    {
        private int idTask;
        private int idUser;
        private string taskName;
        private string description;
        private DateTime deadline;
        private int progress;

        public Task() { }

        public Task(int idUser, string taskName, string description, DateTime deadline, int progress)
        {
            IdUser = idUser;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Progress = progress;
        }

        public int IdTask { get => idTask; set => idTask = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public int Progress { get => progress; set => progress = value; }

        public override string ToString()
            => $"User Id: {IdUser}\nTaskName: {TaskName}" +
               $"\nDescription: {Description}\nDeadline: {Deadline}\nProgress: {Progress}%";

    }
}
