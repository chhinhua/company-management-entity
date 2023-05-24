using company_management.DTO;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using company_management.Entity;
using company_management.Utilities;

namespace company_management.DAO
{
    public class TeamDao
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        public TeamDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
        }

        public Team GetTeamById(int id)
        {
            var team = _dbContext.teams.FirstOrDefault(t => t.id == id);
            return _mapper.Map<team, Team>(team);
        }

        public Team GetTeamByLeader(int id)
        {
            var team = _dbContext.teams.FirstOrDefault(t => t.idLeader == id);
            return _mapper.Map<team, Team>(team);
        }

        public Team GetTeamByTask(Task task)
        {
            var team = _dbContext.teams.FirstOrDefault(t => t.id == task.IdTeam);
            return _mapper.Map<team, Team>(team);
        }

        public List<User> GetUserInTeam(int idTeam)
        {
            var userList = _dbContext.users
                .Where(u => _dbContext.user_team
                    .Any(ut => ut.idTeam == idTeam && _dbContext.teams
                        .Any(t => t.id == idTeam && t.idLeader == u.id)))
                .ToList();
            return _mapper.Map<List<User>>(userList);
        }

        public List<Team> GetAllTeam()
        {
            var teamList = _dbContext.teams.ToList();
            return _mapper.Map<List<Team>>(teamList);
        }

        public List<Team> GetTeamsByUser(int idUser)
        {
            var teamList = _dbContext.teams
                .Join(_dbContext.user_team, t => t.id, ut => ut.idTeam, (t, ut) => new { Team = t, UserTeam = ut })
                .Where(tu => tu.UserTeam.idUser == idUser)
                .Select(tu => tu.Team)
                .ToList();
            return _mapper.Map<List<Team>>(teamList);
        }

        public Team GetTeamByUser(int idUser)
        {
            var team = _dbContext.teams
                .Join(_dbContext.user_team, t => t.id, ut => ut.idTeam, (t, ut) => new { Team = t, UserTeam = ut })
                .Where(tu => tu.UserTeam.idUser == idUser)
                .Select(tu => tu.Team)
                .Distinct()
                .FirstOrDefault();
            return _mapper.Map<Team>(team);
        }

        public int CountMembers(int idTeam)
        {
            return _dbContext.user_team.Count(ut => ut.idTeam == idTeam);
        }
    }
}