using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using company_management.BUS;
using company_management.Entity;
using company_management.Utilities;
using company_management.View;
using company_management.View.UC;

// ReSharper disable All

namespace company_management.DAO
{
    public sealed class TaskDao : IDisposable
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        private readonly Lazy<TeamDao> _teamDao;
        private readonly Lazy<UserDao> _userDao;
        private readonly Lazy<UserBus> _userBus;
        private bool _disposed;
        private readonly Utils _utils;

        public TaskDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
            _teamDao = new Lazy<TeamDao>(() => new TeamDao());
            _userDao = new Lazy<UserDao>(() => new UserDao());
            _userBus = new Lazy<UserBus>(() => new UserBus());
            _utils = new Utils();
        }

        public void LoadUserToCombobox(ComboBox comboBox)
        {
            List<Team> teams;
            List<User> users;
            var teamDao = _teamDao.Value;
            var userDao = _userDao.Value;

            if (_userBus.Value.IsManager() || _userBus.Value.IsHumanResources())
            {
                teams = new List<Team>();
                teams.AddRange(teamDao.GetAllTeam());

                comboBox.Items.AddRange(teams.ToArray());
                comboBox.DisplayMember = "name";
            }
            else if (_userBus.Value.IsLeader())
            {
                Team team = teamDao.GetTeamByLeader(UserSession.LoggedInUser.Id);
                users = new List<User>();
                users.AddRange(userDao.GetEmployeesByTeam(team.Id));

                comboBox.Items.AddRange(users.ToArray());
                comboBox.DisplayMember = "fullName";
            }
            else
            {
                User mySeft = userDao.GetUserById(UserSession.LoggedInUser.Id);
                comboBox.Items.Add(mySeft);
                comboBox.DisplayMember = "fullName";
                comboBox.Enabled = false;
            }

            comboBox.ValueMember = "id";
            if (UcTask.ViewTask != null)
            {
                comboBox.SelectedValue = UcTask.ViewTask.IdAssignee;
            }
        }

        public void AddTask(Task task)
        {
            try
            {
                var newTask = _mapper.Map<task>(task);
                _dbContext.tasks.Add(newTask);
                _dbContext.SaveChanges();
                _utils.Alert("Thêm task thành công", FormAlert.enmType.Success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _utils.Alert("Thêm không thành công!", FormAlert.enmType.Error);
            }
        }

        public void UpdateTask(Task updateTask)
        {
            try
            {
                var taskToUpdate = _dbContext.tasks.FirstOrDefault(t => t.id == updateTask.Id);
                if (taskToUpdate != null)
                {
                    taskToUpdate.idAssignee = updateTask.IdAssignee;
                    taskToUpdate.taskName = updateTask.TaskName;
                    taskToUpdate.description = updateTask.Description;
                    taskToUpdate.deadline = updateTask.Deadline;
                    taskToUpdate.progress = updateTask.Progress;
                    taskToUpdate.idTeam = updateTask.IdTeam;
                    taskToUpdate.bonus = updateTask.Bonus;
                    taskToUpdate.idProject = updateTask.IdProject;
                    _dbContext.SaveChanges();
                    _utils.Alert("Cập nhật thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy công việc!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Cập nhật thất bại!", FormAlert.enmType.Error);
            }
        }

        public void DeleteTask(int id)
        {
            try
            {
                var taskToDelete = _dbContext.tasks.FirstOrDefault(t => t.id == id);
                if (taskToDelete != null)
                {
                    _dbContext.tasks.Remove(taskToDelete);
                    _dbContext.SaveChanges();
                    _utils.Alert("Xóa thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy công việc!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Xóa thất bại!", FormAlert.enmType.Error);
            }
        }

        public void DeleteTasksByProject(int projectId)
        {
            try
            {
                var tasksToDelete = _dbContext.tasks.Where(t => t.idProject == projectId);
                if (tasksToDelete.Any())
                {
                    _dbContext.tasks.RemoveRange(tasksToDelete);
                    _dbContext.SaveChanges();
                    _utils.Alert("Xóa thành công", FormAlert.enmType.Success);
                }
                else
                {
                    _utils.Alert("Không tìm thấy công việc!", FormAlert.enmType.Warning);
                }
            }
            catch (Exception)
            {
                _utils.Alert("Xóa thất bại!", FormAlert.enmType.Error);
            }
        }

        public Task GetTaskById(int id)
        {
            var task = _dbContext.tasks.FirstOrDefault(t => t.id == id);
            return _mapper.Map<Task>(task);
        }

        public TaskStatusPercentage GetTaskStatusPercentage(List<Task> tasks)
        {
            TaskStatusPercentage taskStatus = new TaskStatusPercentage(0, 0, 0);

            if (tasks.Count > 0)
            {
                double totalTasks = tasks.Count;
                double todoCount = tasks.Count(task => task.Progress == 0);
                double inprogressCount = tasks.Count(task => task.Progress > 0 && task.Progress < 100);
                double doneCount = tasks.Count(task => task.Progress == 100);

                taskStatus.TodoPercent = (todoCount / totalTasks) * 100;
                taskStatus.InprogressPercent = (inprogressCount / totalTasks) * 100;
                taskStatus.DonePercent = (doneCount / totalTasks) * 100;
            }

            return taskStatus;
        }

        public List<Task> GetAllTask()
        {
            var taskList = _dbContext.tasks.ToList();
            return _mapper.Map<List<Task>>(taskList);
        }

        public List<Task> GetTasksCreatedByCurrentUser(int idCreator)
        {
            return GetAllTask().Where(t => t.IdCreator == idCreator).ToList();
        }

        public List<Task> GetTasksAssignedByCurrentUser(int idAssignee)
        {
            return GetAllTask().Where(t => t.IdAssignee == idAssignee).ToList();
        }
        
        public List<Task> GetTasksByTeam(int idTeam)
        {
            return GetAllTask().Where(t => t.IdTeam == idTeam).ToList();
        }

        public decimal CalculateBonusForEmployee(int idUser, DateTime fromDate, DateTime toDate)
        {
            decimal totalBonus = 0;
            
            try
            {
                var tasks = _dbContext.tasks
                    .Where(t => t.idAssignee == idUser && t.deadline >= fromDate && t.deadline <= toDate && t.progress == 100)
                    .ToList();

                foreach (var task in tasks)
                {
                    totalBonus += task.bonus ?? 0;
                }
            }
            catch (Exception)
            {
                _utils.Alert("Lỗi khi tính tổng tiền bonus!", FormAlert.enmType.Error);
            }

            return totalBonus;
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _dbContext.Dispose();
            }

            _disposed = true;
        }

        ~TaskDao()
        {
            Dispose(false);
        }
    }
}