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

namespace company_management.Views.UC
{
    public partial class UC_Team : UserControl
    {
        private TeamBUS teamBUS;
        private List<Team> listTeam;

        public UC_Team()
        {
            InitializeComponent();
            teamBUS = new TeamBUS();
            listTeam = new List<Team>();
        }

        private void UC_Team_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            listTeam = teamBUS.GetListTeamByPosition();
            teamBUS.LoadDataGridview(listTeam, dataGridView_Team);
        }
    }
}
