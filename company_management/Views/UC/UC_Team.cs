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
        private TeamBUS teamBUS = new TeamBUS();
        private TaskBUS taskBUS;
        private UserBUS userBUS = new UserBUS();
        public UC_Team()
        {
            InitializeComponent();
        }

        private void UC_Team_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            string position = userBUS.GetUserPosition();

            if (position == "Manager")
            {
                List<Team> listTeam = teamBUS.GetListTeamByManager();
                teamBUS.LoadDataGridview(listTeam, dataGridView_Team, position);
            }
            else
            {
                List<User> listTeam = teamBUS.GetListUserInTeam(UserSession.LoggedInUser.Id);
                teamBUS.LoadDataGridview(listTeam, dataGridView_Team, position);
            }
        }
    }
}
