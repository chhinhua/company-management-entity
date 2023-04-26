using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.View
{
    public partial class Form_ViewOrUpdateProject : Form
    {
        public Form_ViewOrUpdateProject()
        {
            InitializeComponent();
        }

        private void combobox_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox_progress.SelectedItem);
            circleProgressBar.Value = progress;
            progressValue.Text = progress.ToString() + "%";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
