using System;
using company_management.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.BUS;
using company_management.DTO;
using company_management.Utilities;

namespace company_management.View.UC
{
    public partial class UcSalary : UserControl
    {
        private readonly Lazy<Utils> _utils;
        private readonly Lazy<SalaryBus> _salaryBus;
        private readonly Lazy<List<Salary>> _listSalary;
        private readonly Lazy<SalaryDao> _salaryDao;

        public UcSalary()
        {
            InitializeComponent();
            _utils = new Lazy<Utils>(() => new Utils());
            _listSalary = new Lazy<List<Salary>>(() => new List<Salary>());
            _salaryBus = new Lazy<SalaryBus>(() => new SalaryBus());
            _salaryDao = new Lazy<SalaryDao>(() => new SalaryDao());
        }
        
        private void LoadDataGridview()
        {
            var salaryBus = _salaryBus.Value;

            var salaries = salaryBus.GetListSalaryByPosition();
            salaryBus.LoadDataGridview(salaries, datagridview_salary);
        }

        private void UCSalary_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void btn_caculateSalary_Click(object sender, EventArgs e)
        {
            var salaryDao = _salaryDao.Value;
            DateTime from = new DateTime(2023, 3, 1);
            DateTime to = new DateTime(2023, 5, 30);
            salaryDao.CalculateAndSaveSalaryForAllEmployees(from, to);
        }
    }
}