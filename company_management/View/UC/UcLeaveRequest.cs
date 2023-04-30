using System;
using System.Collections.Generic;
using System.Windows.Forms;
using company_management.BUS;
using company_management.DAO;
using company_management.DTO;

namespace company_management.View.UC
{
    public partial class UcLeaveRequest : UserControl
    {
        private readonly Lazy<LeaveRequestDao> _requestDao;
        private readonly Lazy<LeaveRequestBus> _requestBus;
        private readonly Lazy<List<LeaveRequest>> _listRequest;
        private int _selectedId;
        
        public UcLeaveRequest()
        {
            _requestBus = new Lazy<LeaveRequestBus>(() => new LeaveRequestBus());
            _requestDao = new Lazy<LeaveRequestDao>(() => new LeaveRequestDao());
            _listRequest = new Lazy<List<LeaveRequest>>(() => new List<LeaveRequest>());
            InitializeComponent();
        }
        
        private void UCLeaveRequest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadDataGridview();
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

        private void LoadDataGridview()
        {
            var requestBus = _requestBus.Value;
            var request = requestBus.GetListRequestByPosition();
            requestBus.LoadDataGridview(request, datagridview_leaveRequest);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddRequest requestForm = new FormAddRequest();
            requestForm.Show();
        }

        private void btnViewOrUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                 FormViewOrUpdateRequest formRequest = new FormViewOrUpdateRequest();
                 formRequest.SetRequestId(_selectedId);
                 formRequest.Show();
            }
            else MessageBox.Show("Bạn chưa chọn đơn nào! Vui lòng chọn một đơn để xem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void datagridview_leaveRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = datagridview_leaveRequest.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    _selectedId = Convert.ToInt32(value);
                }
            }
        }
    }
}
