using company_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using company_management.Views;

namespace company_management.DAO
{
    public class CheckinCheckoutDAO
    {
        //private readonly company_managementEntities dbContext;
        private readonly DBConnection dBConnection;
        private List<Task> listTask;
        private TeamDAO teamDAO;
        private UserDAO userDAO;

        public CheckinCheckoutDAO()
        {
            //dbContext = new company_managementEntities();
            dBConnection = new DBConnection();
            listTask = new List<Task>();
            teamDAO = new TeamDAO();
            userDAO = new UserDAO();
        }

        /*public List<CheckinCheckout> GetAllCheckinCheckouts()
        {
            var data = from cico in dbContext.checkin_checkout
                       select new TimeKeepingDTO
                       {
                           Employee = cico.user.fullName,
                           CheckinTime = cico.checkinTime,
                           CheckoutTime = (DateTime)cico.checkoutTime,
                           TotalHours = (double)cico.totalHours,
                           Date = (System.DateTime)cico.date
                       };
            return data.ToList();
        }*/

     /*   public void InitData()
        {
            // Tạo 5 đối tượng CheckinCheckoutDTO với fake data và lưu vào database
            for (int i = 1; i <= 5; i++)
            {
                var checkinCheckoutDTO = new CheckinCheckout(i, DateTime.Now, DateTime.Today);
                var checkin_checkout = MappingExtensions.ToEntity<CheckinCheckout, checkin_checkout>(checkinCheckoutDTO);
                dbContext.checkin_checkout.Add(checkin_checkout);
            }
            dbContext.SaveChanges();
        }*/

        public void AddCheckinCO(Task task)
        {
            string query = string.Format("INSERT INTO task(idCreator, idAssignee, taskName, description, deadline, progress, idTeam)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   task.IdCreator, task.IdAssignee, task.TaskName, task.Description, task.Deadline, task.Progress, task.IdTeam);
            dBConnection.executeQuery(query);
        }

        public void UpdateCheckinCO(Task updateTask)
        {
            string sqlStr = string.Format("UPDATE task SET " +
                   "idAssignee = '{0}', taskName = '{1}', description = '{2}', deadline = '{3}', progress = '{4}', idTeam = '{5}' WHERE id = '{6}'",
                   updateTask.IdAssignee, updateTask.TaskName, updateTask.Description, updateTask.Deadline, updateTask.Progress, updateTask.IdTeam, updateTask.Id);
            dBConnection.executeQuery(sqlStr);
        }

        public void DeleteCheckinCO(int id)
        {
            string sqlStr = string.Format("DELETE FROM task WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }

        public CheckinCheckout GetCheckinCOById(int id)
        {
            string query = string.Format("SELECT * FROM checkin_checkout WHERE id = {0}", id);
            return dBConnection.GetObjectByQuery<CheckinCheckout>(query);
        }

        public List<CheckinCheckout> GetAllCheckinCO()
        {
            string query = string.Format("SELECT * FROM checkin_checkout");
            return dBConnection.GetListObjectsByQuery<CheckinCheckout>(query);
        }

        public List<CheckinCheckout> SearchCheckinCO(string txtSearch)
        {
            string query = string.Format("SELECT t.* FROM task t " +
                "INNER JOIN teams tm ON t.idTeam = tm.id " +
                "INNER JOIN users u ON(t.idCreator = u.id OR t.idAssignee = u.id) " +
                "WHERE t.taskName LIKE '%{0}%' " +
                "OR t.description LIKE '%{0}%' " +
                "OR tm.name LIKE '%{0}%' " +
                "OR u.username LIKE '%{0}%' ", txtSearch);
            return dBConnection.GetListObjectsByQuery<CheckinCheckout>(query);
        }

        // Danh sách cico của người đăng nhập
        public List<CheckinCheckout> GetMyCheckinCO(int idUser)
        {
            return GetAllCheckinCO().Where(c => c.IdUser == idUser).ToList();
        }

        // Checkin mà chưa checkout
        public List<CheckinCheckout> GetIncompleteCheckinCO(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCO()
                .Where(c => c.IdUser == idUser && c.CheckoutTime == defaultDateTime)
                .ToList();
        }

        // Hoàn thành checkin checkout
        public List<CheckinCheckout> GetCompleteCheckinCO(int idUser)
        {
            DateTime defaultDateTime = new DateTime();
            return GetAllCheckinCO()
                .Where(c => c.IdUser == idUser && c.CheckoutTime != defaultDateTime)
                .ToList();
        }

        // Lọc theo ngày
        public List<CheckinCheckout> GetCheckinCOByDate(DateTime selectedDate)
        {
            return GetAllCheckinCO()
                .Where(c => c.Date.Date == selectedDate.Date)
                .ToList();
        }

        public List<Task> SearchTasks(string txtSearch)
        {
            string query = string.Format("SELECT t.* FROM task t " +
                "INNER JOIN teams tm ON t.idTeam = tm.id " +
                "INNER JOIN users u ON(t.idCreator = u.id OR t.idAssignee = u.id) " +
                "WHERE t.taskName LIKE '%{0}%' " +
                "OR t.description LIKE '%{0}%' " +
                "OR tm.name LIKE '%{0}%' " +
                "OR u.username LIKE '%{0}%' ", txtSearch);
            return dBConnection.GetListObjectsByQuery<Task>(query);
        }

    }
}