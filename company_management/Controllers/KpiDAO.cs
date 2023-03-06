using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class KpiDAO
    {
        private readonly DBConnection dBConnection;

        public KpiDAO() => dBConnection = new DBConnection();

        public void loadKpi(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "kpi");

        public void addKpi(KPI kpi)
        {
            string sqlStr = string.Format("INSERT INTO kpi(idUser, kpiName, description, progress)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}')",
                   kpi.IdUser, kpi.KpiName, kpi.Description, kpi.Progress);
            dBConnection.executeQuery(sqlStr);
        }

        public void updateKpi(KPI kpi)
        {
            string sqlStr = string.Format("UPDATE kpi SET " +
                   "idUser = '{0}', kpiName = '{1}', description = '{2}', progress = '{3}' WHERE id = '{4}'",
                   kpi.IdUser, kpi.KpiName, kpi.Description, kpi.Progress, kpi.IdKpi);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteKpi(int id)
        {
            string sqlStr = string.Format("DELETE FROM kpi WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }
    }
}
