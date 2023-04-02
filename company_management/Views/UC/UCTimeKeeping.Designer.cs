namespace company_management.Views
{
    partial class UCTimeKeeping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview_timeKeeping = new Guna.UI2.WinForms.Guna2DataGridView();
            this.datetime_Checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_Checkout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.combbox_employee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.checkbox_checkin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox_checkout = new Guna.UI2.WinForms.Guna2CheckBox();
            this.datetime_fillter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkbox_checkedIn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.groupBox_fillter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.checkbox_checkedOut = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panelFields.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_timeKeeping)).BeginInit();
            this.groupBox_fillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 25;
            this.panelFields.BorderThickness = 1;
            this.panelFields.Controls.Add(this.checkbox_checkout);
            this.panelFields.Controls.Add(this.checkbox_checkin);
            this.panelFields.Controls.Add(this.combbox_employee);
            this.panelFields.Controls.Add(this.datetime_Checkout);
            this.panelFields.Controls.Add(this.datetime_Checkin);
            this.panelFields.Controls.Add(this.label2);
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(16, 18);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(1258, 91);
            this.panelFields.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 25;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.groupBox_fillter);
            this.panelData.Controls.Add(this.txtSearch);
            this.panelData.Controls.Add(this.datagridview_timeKeeping);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(16, 183);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1258, 585);
            this.panelData.TabIndex = 1;
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // datagridview_timeKeeping
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.datagridview_timeKeeping.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridview_timeKeeping.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_timeKeeping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridview_timeKeeping.ColumnHeadersHeight = 30;
            this.datagridview_timeKeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_timeKeeping.DefaultCellStyle = dataGridViewCellStyle11;
            this.datagridview_timeKeeping.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_timeKeeping.Location = new System.Drawing.Point(16, 87);
            this.datagridview_timeKeeping.Name = "datagridview_timeKeeping";
            this.datagridview_timeKeeping.RowHeadersVisible = false;
            this.datagridview_timeKeeping.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.datagridview_timeKeeping.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datagridview_timeKeeping.RowTemplate.Height = 24;
            this.datagridview_timeKeeping.Size = new System.Drawing.Size(1222, 481);
            this.datagridview_timeKeeping.TabIndex = 0;
            this.datagridview_timeKeeping.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_timeKeeping.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_timeKeeping.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_timeKeeping.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_timeKeeping.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_timeKeeping.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.datagridview_timeKeeping.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_timeKeeping.ThemeStyle.HeaderStyle.Height = 30;
            this.datagridview_timeKeeping.ThemeStyle.ReadOnly = false;
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.Height = 24;
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_timeKeeping.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // datetime_Checkin
            // 
            this.datetime_Checkin.BackColor = System.Drawing.Color.Transparent;
            this.datetime_Checkin.BorderRadius = 10;
            this.datetime_Checkin.Checked = true;
            this.datetime_Checkin.FillColor = System.Drawing.Color.White;
            this.datetime_Checkin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.datetime_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetime_Checkin.Location = new System.Drawing.Point(593, 27);
            this.datetime_Checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_Checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_Checkin.Name = "datetime_Checkin";
            this.datetime_Checkin.Size = new System.Drawing.Size(200, 36);
            this.datetime_Checkin.TabIndex = 79;
            this.datetime_Checkin.Value = new System.DateTime(2023, 4, 2, 19, 31, 33, 0);
            this.datetime_Checkin.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // datetime_Checkout
            // 
            this.datetime_Checkout.BackColor = System.Drawing.Color.Transparent;
            this.datetime_Checkout.BorderRadius = 10;
            this.datetime_Checkout.Checked = true;
            this.datetime_Checkout.FillColor = System.Drawing.Color.White;
            this.datetime_Checkout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetime_Checkout.Location = new System.Drawing.Point(988, 27);
            this.datetime_Checkout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_Checkout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_Checkout.Name = "datetime_Checkout";
            this.datetime_Checkout.Size = new System.Drawing.Size(200, 36);
            this.datetime_Checkout.TabIndex = 81;
            this.datetime_Checkout.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // combbox_employee
            // 
            this.combbox_employee.BackColor = System.Drawing.Color.Transparent;
            this.combbox_employee.BorderRadius = 5;
            this.combbox_employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_employee.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combbox_employee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_employee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_employee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbox_employee.ForeColor = System.Drawing.Color.Black;
            this.combbox_employee.ItemHeight = 30;
            this.combbox_employee.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.combbox_employee.Location = new System.Drawing.Point(159, 27);
            this.combbox_employee.Name = "combbox_employee";
            this.combbox_employee.Size = new System.Drawing.Size(258, 36);
            this.combbox_employee.TabIndex = 85;
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
            this.btnEdit.Location = new System.Drawing.Point(230, 125);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 40);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Edit";
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
            this.btnSave.Location = new System.Drawing.Point(67, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 40);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
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
            this.btnDelete.Location = new System.Drawing.Point(392, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 40);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Delete";
            // 
            // checkbox_checkin
            // 
            this.checkbox_checkin.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_checkin.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkbox_checkin.CheckedState.BorderRadius = 10;
            this.checkbox_checkin.CheckedState.BorderThickness = 0;
            this.checkbox_checkin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkin.Location = new System.Drawing.Point(469, 38);
            this.checkbox_checkin.Name = "checkbox_checkin";
            this.checkbox_checkin.Size = new System.Drawing.Size(118, 25);
            this.checkbox_checkin.TabIndex = 86;
            this.checkbox_checkin.Text = "Checkin:";
            this.checkbox_checkin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox_checkin.UncheckedState.BorderRadius = 0;
            this.checkbox_checkin.UncheckedState.BorderThickness = 0;
            this.checkbox_checkin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox_checkin.UseVisualStyleBackColor = false;
            this.checkbox_checkin.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // checkbox_checkout
            // 
            this.checkbox_checkout.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_checkout.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkbox_checkout.CheckedState.BorderRadius = 10;
            this.checkbox_checkout.CheckedState.BorderThickness = 0;
            this.checkbox_checkout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkout.Location = new System.Drawing.Point(848, 38);
            this.checkbox_checkout.Name = "checkbox_checkout";
            this.checkbox_checkout.Size = new System.Drawing.Size(134, 25);
            this.checkbox_checkout.TabIndex = 87;
            this.checkbox_checkout.Text = "Checkout:";
            this.checkbox_checkout.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox_checkout.UncheckedState.BorderRadius = 0;
            this.checkbox_checkout.UncheckedState.BorderThickness = 0;
            this.checkbox_checkout.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox_checkout.UseVisualStyleBackColor = false;
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
            this.checkbox_checkedIn.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged_1);
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
            // UCTimeKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelFields);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTimeKeeping";
            this.Size = new System.Drawing.Size(1292, 788);
            this.Load += new System.EventHandler(this.UCTimeKeeping_Load);
            this.panelFields.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_timeKeeping)).EndInit();
            this.groupBox_fillter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_timeKeeping;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_Checkin;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_Checkout;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_employee;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkin;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkout;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_fillter;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedIn;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_fillter;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedOut;
    }
}
