using company_management.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.Views.UC
{
    public partial class UCTask : UserControl
    {
        TaskDAO taskDAO = new TaskDAO();
        public UCTask()
        {
            InitializeComponent();
        }

        private void UCTask_Load(object sender, EventArgs e)
        {
            taskDAO.loadTask(dgvTask);
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTask.CurrentRow.Selected = true;
        }
    }
}
