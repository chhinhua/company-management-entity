using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using company_management.BUS;
using company_management.DTO;
using System.Windows.Forms;

namespace company_management.View.UC
{
    public partial class UcTeam : UserControl
    {
        private readonly Lazy<TeamBus> _teamBus;
        private readonly Lazy<List<Team>> _listTeam;

        public UcTeam()
        {
            InitializeComponent();
            _teamBus = new Lazy<TeamBus>(() => new TeamBus());
            _listTeam = new Lazy<List<Team>>(() => new List<Team>());
        }

        private void UC_Team_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            var teams = _listTeam.Value;
            var teamBus = _teamBus.Value;
            teams = teamBus.GetListTeamByPosition();
            teamBus.LoadDataGridview(teams, dataGridView_Team);
        }
    }
}
