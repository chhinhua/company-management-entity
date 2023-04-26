using System;
using company_management.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.DTO;

namespace company_management.View.UC
{
    public partial class UC_Salary : UserControl
    {
        private Lazy<SalaryDAO> salaryDAO;
        private Lazy<TaskDAO> taskDAO;

        public UC_Salary()
        {
            InitializeComponent();
            salaryDAO = new Lazy<SalaryDAO>(() => new SalaryDAO());
            taskDAO = new Lazy<TaskDAO>(() => new TaskDAO());
        }

        /*        private void btnLR_Click(object sender, EventArgs e)
                {
                    FormLeaveQuest formLR = new FormLeaveQuest();
                    formLR.ShowDialog();
                }*/

        private void AddActionColumn()
        {
            // Tạo hai cột mới để chứa các nút phê duyệt/từ chối
            var approveColumn = new DataGridViewCheckBoxColumn();
            approveColumn.Name = "";

            // Thêm cột vào DataGridView
            datagridview_salary.Columns.Add(approveColumn);
            //datagridview_salary.Columns.Add(rejectColumn);
        }

        private void CustomGridColumn()
        {
            datagridview_salary.Columns["Id"].Visible = false;
            datagridview_salary.Columns["IdUser"].Visible = false;
           
            // Đổi tên cột
            datagridview_salary.Columns["BasicSalary"].HeaderText = "Luơng cơ bản \n(Vnd)";
            datagridview_salary.Columns["TotalHours"].HeaderText = "Tổng giờ";
            datagridview_salary.Columns["OverTimeHours"].HeaderText = "Tăng ca (h)";
            datagridview_salary.Columns["LeaveHours"].HeaderText = "Nghỉ (h)";
            datagridview_salary.Columns["Bonus"].HeaderText = "Thưởng (Vnd)";
            datagridview_salary.Columns["FinalSalary"].HeaderText = "Thực nhận (Vnd)";


            // custom chiều rộng cột
            datagridview_salary.Columns[""].Width = 45;
            datagridview_salary.Columns["TotalHours"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datagridview_salary.Columns["OverTimeHours"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datagridview_salary.Columns["LeaveHours"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

       /* private void datagridview_leaveRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var approveColumn = datagridview_leaveRequest.Columns["Duyệt"];
                var rejectColumn = datagridview_leaveRequest.Columns["Từ chối"];

                if (datagridview_leaveRequest.Columns[e.ColumnIndex] == rejectColumn)
                {
                    var result = MessageBox.Show("Lưu thay đổi", "Từ chối yêu cầu xin nghỉ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        datagridview_leaveRequest.Rows[e.RowIndex].Cells["Duyệt"].Value = false;
                        datagridview_leaveRequest.Rows[e.RowIndex].Cells["Từ chối"].Value = true;
                    }
                    else
                    {
                        datagridview_leaveRequest.Rows[e.RowIndex].Cells["Từ chối"].Value = false;
                    }
                }
                else if (datagridview_leaveRequest.Columns[e.ColumnIndex] == approveColumn)
                {
                    datagridview_leaveRequest.Rows[e.RowIndex].Cells["Từ chối"].Value = false;
                }
            }

        }
*/

        private void loadGridview()
        {
            /*List<Salary> data = salaryDAO.GetAllSalaries();
            datagridview_salary.DataSource = data;*/
        }

        private void UCSalary_Load(object sender, EventArgs e)
        {
        //    //AddActionColumn();
        //    //salaryDAO.InitData();
        //    //loadGridview();
        //    //CustomGridColumn();
        }

        private void btn_caculateSalary_Click(object sender, EventArgs e)
        {
            var salaryDao = salaryDAO.Value;
            DateTime from = new DateTime(2023, 3, 1);
            DateTime to = new DateTime(2023, 5, 30);
            salaryDao.CalculateAndSaveSalaryForAllEmployees(from, to);
        }
    }
}
