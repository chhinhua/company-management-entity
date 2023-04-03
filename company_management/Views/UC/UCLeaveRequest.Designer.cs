namespace company_management.Views
{
    partial class UCLeaveRequest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.checkbox_checkedOut = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox_checkedIn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.datetime_fillter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox_fillter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview_leaveRequest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelData.SuspendLayout();
            this.groupBox_fillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_leaveRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 19;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnEdit.Image = global::company_management.Properties.Resources.icons8_uninstalling_updates_321;
            this.btnEdit.Location = new System.Drawing.Point(230, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 40);
            this.btnEdit.TabIndex = 84;
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 19;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::company_management.Properties.Resources.x;
            this.btnDelete.Location = new System.Drawing.Point(392, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 40);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            // 
            // checkbox_checkedOut
            // 
            this.checkbox_checkedOut.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedOut.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedOut.CheckedState.BorderRadius = 10;
            this.checkbox_checkedOut.CheckedState.BorderThickness = 0;
            this.checkbox_checkedOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox_checkedOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkedOut.ForeColor = System.Drawing.Color.Black;
            this.checkbox_checkedOut.Location = new System.Drawing.Point(301, 10);
            this.checkbox_checkedOut.Name = "checkbox_checkedOut";
            this.checkbox_checkedOut.Size = new System.Drawing.Size(147, 31);
            this.checkbox_checkedOut.TabIndex = 89;
            this.checkbox_checkedOut.Text = "Checked out";
            this.checkbox_checkedOut.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox_checkedOut.UncheckedState.BorderRadius = 0;
            this.checkbox_checkedOut.UncheckedState.BorderThickness = 0;
            this.checkbox_checkedOut.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox_checkedOut.UseVisualStyleBackColor = false;
            // 
            // checkbox_checkedIn
            // 
            this.checkbox_checkedIn.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedIn.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedIn.CheckedState.BorderRadius = 10;
            this.checkbox_checkedIn.CheckedState.BorderThickness = 0;
            this.checkbox_checkedIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox_checkedIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkedIn.ForeColor = System.Drawing.Color.Black;
            this.checkbox_checkedIn.Location = new System.Drawing.Point(133, 10);
            this.checkbox_checkedIn.Name = "checkbox_checkedIn";
            this.checkbox_checkedIn.Size = new System.Drawing.Size(129, 31);
            this.checkbox_checkedIn.TabIndex = 88;
            this.checkbox_checkedIn.Text = "Checked in";
            this.checkbox_checkedIn.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkbox_checkedIn.UncheckedState.BorderRadius = 0;
            this.checkbox_checkedIn.UncheckedState.BorderThickness = 0;
            this.checkbox_checkedIn.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox_checkedIn.UseVisualStyleBackColor = false;
            // 
            // datetime_fillter
            // 
            this.datetime_fillter.BackColor = System.Drawing.Color.Transparent;
            this.datetime_fillter.BorderRadius = 10;
            this.datetime_fillter.Checked = true;
            this.datetime_fillter.FillColor = System.Drawing.Color.White;
            this.datetime_fillter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_fillter.ForeColor = System.Drawing.Color.Black;
            this.datetime_fillter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_fillter.Location = new System.Drawing.Point(496, 0);
            this.datetime_fillter.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_fillter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_fillter.Name = "datetime_fillter";
            this.datetime_fillter.Size = new System.Drawing.Size(155, 41);
            this.datetime_fillter.TabIndex = 88;
            this.datetime_fillter.Value = new System.DateTime(2023, 4, 2, 18, 8, 25, 868);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 19;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::company_management.Properties.Resources.icons8_add_64;
            this.btnSave.Location = new System.Drawing.Point(67, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 40);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 25;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.groupBox_fillter);
            this.panelData.Controls.Add(this.txtSearch);
            this.panelData.Controls.Add(this.datagridview_leaveRequest);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(17, 231);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1258, 538);
            this.panelData.TabIndex = 82;
            // 
            // groupBox_fillter
            // 
            this.groupBox_fillter.BackColor = System.Drawing.Color.White;
            this.groupBox_fillter.BorderRadius = 10;
            this.groupBox_fillter.Controls.Add(this.checkbox_checkedOut);
            this.groupBox_fillter.Controls.Add(this.checkbox_checkedIn);
            this.groupBox_fillter.Controls.Add(this.datetime_fillter);
            this.groupBox_fillter.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBox_fillter.FillColor = System.Drawing.Color.Transparent;
            this.groupBox_fillter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_fillter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox_fillter.Location = new System.Drawing.Point(587, 18);
            this.groupBox_fillter.Name = "groupBox_fillter";
            this.groupBox_fillter.Size = new System.Drawing.Size(651, 41);
            this.groupBox_fillter.TabIndex = 89;
            this.groupBox_fillter.Text = "Fillter:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::company_management.Properties.Resources.icons8_search_483;
            this.txtSearch.Location = new System.Drawing.Point(16, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(472, 32);
            this.txtSearch.TabIndex = 70;
            // 
            // datagridview_leaveRequest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_leaveRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_leaveRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_leaveRequest.ColumnHeadersHeight = 30;
            this.datagridview_leaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_leaveRequest.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_leaveRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_leaveRequest.Location = new System.Drawing.Point(16, 87);
            this.datagridview_leaveRequest.Name = "datagridview_leaveRequest";
            this.datagridview_leaveRequest.RowHeadersVisible = false;
            this.datagridview_leaveRequest.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridview_leaveRequest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_leaveRequest.RowTemplate.Height = 30;
            this.datagridview_leaveRequest.Size = new System.Drawing.Size(1222, 434);
            this.datagridview_leaveRequest.TabIndex = 0;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.datagridview_leaveRequest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.Height = 30;
            this.datagridview_leaveRequest.ThemeStyle.ReadOnly = false;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.Height = 30;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_leaveRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_leaveRequest_CellContentClick);
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 25;
            this.panelFields.BorderThickness = 1;
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(17, 19);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(1258, 136);
            this.panelFields.TabIndex = 81;
            // 
            // UCLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelFields);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCLeaveRequest";
            this.Size = new System.Drawing.Size(1292, 788);
            this.Load += new System.EventHandler(this.UCLeaveRequestManagement_Load);
            this.panelData.ResumeLayout(false);
            this.groupBox_fillter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_leaveRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedOut;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_fillter;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_fillter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_leaveRequest;
        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
