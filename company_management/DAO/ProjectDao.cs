using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using company_management.Entity;
using company_management.View;
using company_management.Utilities;

// ReSharper disable All

namespace company_management.DAO
{
    public class ProjectDao
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        private readonly DBConnection _dBConnection;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Utils _utils;

        public ProjectDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
            _dBConnection = new DBConnection();
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _utils = new Utils();
        }

        public void AddProject(Project project)
        {
            try
            {
                var newProject = _mapper.Map<project>(project);
                _dbContext.projects.Add(newProject);
                _dbContext.SaveChanges();
                _utils.Alert("Thêm dự án thành công", FormAlert.enmType.Success);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                _utils.Alert("Thêm không thành công!", FormAlert.enmType.Error);
            }
        }

        public async void UpdateProject(Project project)
        {
            var projectToUpdate = _dbContext.projects.Find(project.Id);
            if (projectToUpdate != null)
            {
                projectToUpdate.idCreator = project.IdCreator;
                projectToUpdate.idAssignee = project.IdAssignee;
                projectToUpdate.name = project.Name;
                projectToUpdate.description = project.Description;
                projectToUpdate.startDate = project.StartDate;
                projectToUpdate.endDate = project.EndDate;
                projectToUpdate.progress = project.Progress;
                projectToUpdate.idTeam = project.IdTeam;
                projectToUpdate.bonus = project.Bonus;

                try
                {
                    _dbContext.Entry(projectToUpdate).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    _utils.Alert("Cập nhật thành công", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    _utils.Alert("Cập nhật không thành công!", FormAlert.enmType.Error);
                }
            }
            else
            {
                _utils.Alert("Không tìm thấy dự án!", FormAlert.enmType.Warning);
            }
        }

        public void DeleteProject(int id)
        {
            try
            {
                var projectToDelete = _dbContext.projects.FirstOrDefault(p => p.id == id);
                if (projectToDelete != null)
                {
                    _dbContext.projects.Remove(projectToDelete);
                    _dbContext.SaveChanges();
                    _utils.Alert("Xóa thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy dự án!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Xóa thất bại!", FormAlert.enmType.Error);
            }
        }

        public void LoadTeamToCombobox(ComboBox comboBox)
        {
            var teamDao = _teamDao.Value;
            List<Team> teams;

            // Hiển thị danh sách team cho quản lý chọn
            teams = new List<Team>();
            teams.AddRange(teamDao.GetAllTeam());

            comboBox.Items.AddRange(teams.ToArray());
            comboBox.DisplayMember = "name";

            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = 0;
        }

        public List<Project> GetAllProject()
        {
            var projectList = _dbContext.projects.ToList();
            return _mapper.Map<List<Project>>(projectList);
        }

        public List<Project> GetProjectsCreatedByCurrentUser(int idCreator)
        {
            return GetAllProject().Where(t => t.IdCreator == idCreator).ToList();
        }

        public List<Project> GetProjectsAssignedByCurrentUser(int idAssignee)
        {
            return GetAllProject().Where(t => t.IdAssignee == idAssignee).ToList();
        }

        public List<Project> GetMyProjects()
        {
            var team = _teamDao.Value.GetTeamByUser(UserSession.LoggedInUser.Id);
            return GetAllProject().Where(t => t.IdTeam == team.Id).ToList();
        }

        public Project GetProjectById(int id)
        {
            var project = _dbContext.projects.FirstOrDefault(p => p.id == id);
            return _mapper.Map<Project>(project);
        }

        public Project GetProjectByTeam(int idTeam)
        {
            var project = _dbContext.projects.FirstOrDefault(p => p.idTeam == idTeam);
            return _mapper.Map<Project>(project);
        }
    }
}