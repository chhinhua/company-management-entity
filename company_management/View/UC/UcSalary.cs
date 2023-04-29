using System;
using System.Windows.Forms;
using company_management.BUS;
using company_management.Utilities;

namespace company_management.View.UC
{
    public partial class UcSalary : UserControl
    {
        private readonly Lazy<Utils> _utils;
        private readonly Lazy<SalaryBus> _salaryBus;


        public UcSalary()
        {
            InitializeComponent();
            _utils = new Lazy<Utils>(() => new Utils());
            _salaryBus = new Lazy<SalaryBus>(() => new SalaryBus());
        }

        private void LoadData()
        {
            var util = _utils.Value;
            util.CheckCalculateSalaryStatus(btn_caculateSalary);
            util.CheckCalculateSalaryStatus(btnRefresh);
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            var salaryBus = _salaryBus.Value;

            var salaries = salaryBus.GetListSalaryByPosition();
            salaryBus.LoadDataGridview(salaries, datagridview_salary);
        }

        private void UCSalary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_caculateSalary_Click(object sender, EventArgs e)
        {
            FormCalculateSalary form = new FormCalculateSalary();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}