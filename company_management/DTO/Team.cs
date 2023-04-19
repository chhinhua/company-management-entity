using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.DTO
{
    public class Team
    {
        private int id;
        private string name;
        private string description;
        private int idLeader;
        private byte[] avatar;

        public Team() { }

        public Team(string name, string description, int idLeader)
        {
            Name = name;
            Description = description;
            IdLeader = idLeader;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int IdLeader { get => idLeader; set => idLeader = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
