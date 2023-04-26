using company_management.BUS;
using company_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.View.UC
{
    public partial class UC_Team : UserControl
    {
        private Lazy<TeamBUS> teamBUS;
        private Lazy<List<Team>> listTeam;

        public UC_Team()
        {
            InitializeComponent();
            teamBUS = new Lazy<TeamBUS>(() => new TeamBUS());
            listTeam = new Lazy<List<Team>>(() => new List<Team>());
        }

        private void UC_Team_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            var teams = listTeam.Value;
            var teamBus = teamBUS.Value;
            teams = teamBus.GetListTeamByPosition();
            teamBus.LoadDataGridview(teams, dataGridView_Team);
        }
    }
}
