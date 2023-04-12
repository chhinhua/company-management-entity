using company_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using company_management.DTO;
using company_management.DTO;

namespace company_management.Views
{
    public partial class UCLeaveRequest : UserControl
    {
        LeaveRequestDAO requestDAO = new LeaveRequestDAO();
        public static LeaveRequestDTO requestDTO = new LeaveRequestDTO();
        private TaskDAO taskDAO = new TaskDAO();

        public UCLeaveRequest()
        {
            InitializeComponent();
        }

        private void UCLeaveRequest_Load(object sender, EventArgs e)
        {
            loadGridview();
            CustomeGridColumn();
        }

        private void btnLR_Click(object sender, EventArgs e)
        {
            FormLeaveQuest formLR = new FormLeaveQuest();
            formLR.ShowDialog();
        }

        private void CustomeGridColumn()
        {
            datagridview_leaveRequest.Columns["Id"].Visible = false;
            datagridview_leaveRequest.Columns["IdUser"].Visible = false;

            // Tạo hai cột mới để chứa các nút phê duyệt/từ chối
            var approveColumn = new DataGridViewCheckBoxColumn();
            approveColumn.Name = "Duyệt";

            var rejectColumn = new DataGridViewCheckBoxColumn();
            rejectColumn.Name = "Từ chối";

            // Đổi tên cột
            datagridview_leaveRequest.Columns["numberDay"].HeaderText = "Số ngày";
            datagridview_leaveRequest.Columns["startDate"].HeaderText = "From";
            datagridview_leaveRequest.Columns["endDate"].HeaderText = "To";
            datagridview_leaveRequest.Columns["reason"].HeaderText = "Nội dung";


            // Thêm cột vào DataGridView
            datagridview_leaveRequest.Columns.Add(approveColumn);
            datagridview_leaveRequest.Columns.Add(rejectColumn);

            // custom chiều rộng cột
            datagridview_leaveRequest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            datagridview_leaveRequest.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            datagridview_leaveRequest.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            datagridview_leaveRequest.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void datagridview_leaveRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void loadGridview()
        {
            List<LeaveRequestDTO> data = requestDAO.GetAllLeaveRequests();

            foreach (LeaveRequestDTO request in data)
            {
                User user = requestDAO.GetUserById(request.IdUser);
                request.Employee = user.FullName;
            }

            datagridview_leaveRequest.DataSource = data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loadGridview();
        }

      
    }
}
