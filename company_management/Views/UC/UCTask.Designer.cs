namespace company_management.Views.UC
{
    partial class UCTask
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkbox_checkedOut = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox_checkedIn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.datetime_fillter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox_fillter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTask = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.chart_taskProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewTask = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.label_todoTask = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label_inprogressTask = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label_doneTask = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelData.SuspendLayout();
            this.groupBox_fillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.panelFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_taskProgress)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkbox_checkedOut
            // 
            this.checkbox_checkedOut.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedOut.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkbox_checkedOut.CheckedState.BorderRadius = 10;
            this.checkbox_checkedOut.CheckedState.BorderThickness = 0;
            this.checkbox_checkedOut.CheckedState.FillColor = System.Drawing.Color.Black;
            this.checkbox_checkedOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkedOut.ForeColor = System.Drawing.Color.Black;
            this.checkbox_checkedOut.Location = new System.Drawing.Point(383, 10);
            this.checkbox_checkedOut.Name = "checkbox_checkedOut";
            this.checkbox_checkedOut.Size = new System.Drawing.Size(107, 31);
            this.checkbox_checkedOut.TabIndex = 89;
            this.checkbox_checkedOut.Text = "Từ chối";
            this.checkbox_checkedOut.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
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
            this.checkbox_checkedIn.CheckedState.FillColor = System.Drawing.Color.Black;
            this.checkbox_checkedIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkbox_checkedIn.ForeColor = System.Drawing.Color.Black;
            this.checkbox_checkedIn.Location = new System.Drawing.Point(270, 10);
            this.checkbox_checkedIn.Name = "checkbox_checkedIn";
            this.checkbox_checkedIn.Size = new System.Drawing.Size(107, 31);
            this.checkbox_checkedIn.TabIndex = 88;
            this.checkbox_checkedIn.Text = "Đã duyệt";
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
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 25;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.groupBox_fillter);
            this.panelData.Controls.Add(this.txtSearch);
            this.panelData.Controls.Add(this.dgvTask);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(17, 314);
            this.panelData.Name = "panelData";
            this.panelData.ShadowDecoration.BorderRadius = 25;
            this.panelData.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.ShadowDecoration.Enabled = true;
            this.panelData.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelData.Size = new System.Drawing.Size(1258, 455);
            this.panelData.TabIndex = 96;
            // 
            // groupBox_fillter
            // 
            this.groupBox_fillter.BackColor = System.Drawing.Color.White;
            this.groupBox_fillter.BorderRadius = 10;
            this.groupBox_fillter.Controls.Add(this.guna2CheckBox1);
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
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox1.CheckedState.BorderRadius = 10;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.Location = new System.Drawing.Point(145, 10);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(103, 31);
            this.guna2CheckBox1.TabIndex = 90;
            this.guna2CheckBox1.Text = "Đang chờ";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.UseVisualStyleBackColor = false;
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
            this.txtSearch.Size = new System.Drawing.Size(472, 41);
            this.txtSearch.TabIndex = 70;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvTask
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTask.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTask.ColumnHeadersHeight = 30;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTask.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTask.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTask.Location = new System.Drawing.Point(16, 87);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTask.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTask.RowTemplate.Height = 30;
            this.dgvTask.Size = new System.Drawing.Size(1222, 352);
            this.dgvTask.TabIndex = 0;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvTask.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTask.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTask.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTask.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTask.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTask.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvTask.ThemeStyle.ReadOnly = false;
            this.dgvTask.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTask.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTask.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTask.ThemeStyle.RowsStyle.Height = 30;
            this.dgvTask.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTask.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.Transparent;
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 25;
            this.panelFields.BorderThickness = 1;
            this.panelFields.Controls.Add(this.chart_taskProgress);
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(17, 19);
            this.panelFields.Name = "panelFields";
            this.panelFields.ShadowDecoration.BorderRadius = 25;
            this.panelFields.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFields.ShadowDecoration.Enabled = true;
            this.panelFields.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelFields.Size = new System.Drawing.Size(281, 234);
            this.panelFields.TabIndex = 95;
            // 
            // chart_taskProgress
            // 
            chartArea1.Name = "ChartArea";
            this.chart_taskProgress.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend_progress";
            this.chart_taskProgress.Legends.Add(legend1);
            this.chart_taskProgress.Location = new System.Drawing.Point(16, 3);
            this.chart_taskProgress.Name = "chart_taskProgress";
            this.chart_taskProgress.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend_progress";
            series1.Name = "SeriesProgress";
            this.chart_taskProgress.Series.Add(series1);
            this.chart_taskProgress.Size = new System.Drawing.Size(248, 228);
            this.chart_taskProgress.TabIndex = 18;
            this.chart_taskProgress.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 100;
            this.label1.Text = "Task Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BorderRadius = 19;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.Transparent;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonEdit.Image = global::company_management.Properties.Resources.edit;
            this.buttonEdit.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonEdit.Location = new System.Drawing.Point(1170, 268);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(49, 40);
            this.buttonEdit.TabIndex = 98;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoRoundedCorners = true;
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.BorderRadius = 19;
            this.buttonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRemove.FillColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Image = global::company_management.Properties.Resources.trash;
            this.buttonRemove.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonRemove.Location = new System.Drawing.Point(1225, 268);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(50, 40);
            this.buttonRemove.TabIndex = 99;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoRoundedCorners = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 20;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::company_management.Properties.Resources.plus;
            this.buttonAdd.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonAdd.Location = new System.Drawing.Point(1118, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(46, 42);
            this.buttonAdd.TabIndex = 97;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnViewTask
            // 
            this.btnViewTask.AutoRoundedCorners = true;
            this.btnViewTask.BorderRadius = 19;
            this.btnViewTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewTask.FillColor = System.Drawing.Color.Transparent;
            this.btnViewTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewTask.ForeColor = System.Drawing.Color.White;
            this.btnViewTask.Image = global::company_management.Properties.Resources.icons8_eye_25;
            this.btnViewTask.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewTask.Location = new System.Drawing.Point(1067, 270);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.Size = new System.Drawing.Size(45, 40);
            this.btnViewTask.TabIndex = 101;
            this.btnViewTask.Click += new System.EventHandler(this.btnViewTask_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(34, 90);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(181, 32);
            this.label.TabIndex = 96;
            this.label.Text = "TODO";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_todoTask
            // 
            this.label_todoTask.BackColor = System.Drawing.Color.Transparent;
            this.label_todoTask.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todoTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_todoTask.Location = new System.Drawing.Point(31, 40);
            this.label_todoTask.Name = "label_todoTask";
            this.label_todoTask.Size = new System.Drawing.Size(188, 50);
            this.label_todoTask.TabIndex = 97;
            this.label_todoTask.Text = "500 h";
            this.label_todoTask.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2GradientCircleButton1);
            this.guna2Panel3.Controls.Add(this.label_todoTask);
            this.guna2Panel3.Controls.Add(this.label);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(319, 51);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel3.Size = new System.Drawing.Size(313, 146);
            this.guna2Panel3.TabIndex = 89;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(188, 51);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(75, 59);
            this.guna2GradientCircleButton1.TabIndex = 103;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2GradientCircleButton2);
            this.guna2Panel2.Controls.Add(this.label_inprogressTask);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(643, 51);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel2.Size = new System.Drawing.Size(311, 146);
            this.guna2Panel2.TabIndex = 98;
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.Lime;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.LimeGreen;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(191, 51);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(75, 59);
            this.guna2GradientCircleButton2.TabIndex = 104;
            // 
            // label_inprogressTask
            // 
            this.label_inprogressTask.BackColor = System.Drawing.Color.Transparent;
            this.label_inprogressTask.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inprogressTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_inprogressTask.Location = new System.Drawing.Point(32, 40);
            this.label_inprogressTask.Name = "label_inprogressTask";
            this.label_inprogressTask.Size = new System.Drawing.Size(188, 50);
            this.label_inprogressTask.TabIndex = 97;
            this.label_inprogressTask.Text = "500 h";
            this.label_inprogressTask.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 96;
            this.label3.Text = "IN PROGRESS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 25;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2GradientCircleButton3);
            this.guna2Panel4.Controls.Add(this.label_doneTask);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(965, 51);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel4.Size = new System.Drawing.Size(310, 146);
            this.guna2Panel4.TabIndex = 98;
            // 
            // guna2GradientCircleButton3
            // 
            this.guna2GradientCircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.guna2GradientCircleButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(205, 51);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(75, 59);
            this.guna2GradientCircleButton3.TabIndex = 105;
            // 
            // label_doneTask
            // 
            this.label_doneTask.BackColor = System.Drawing.Color.Transparent;
            this.label_doneTask.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doneTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_doneTask.Location = new System.Drawing.Point(30, 40);
            this.label_doneTask.Name = "label_doneTask";
            this.label_doneTask.Size = new System.Drawing.Size(188, 50);
            this.label_doneTask.TabIndex = 97;
            this.label_doneTask.Text = "500 h";
            this.label_doneTask.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 32);
            this.label9.TabIndex = 96;
            this.label9.Text = "DONE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnViewTask);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTask";
            this.Size = new System.Drawing.Size(1292, 788);
            this.Load += new System.EventHandler(this.UCTask_Load);
            this.panelData.ResumeLayout(false);
            this.groupBox_fillter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.panelFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_taskProgress)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedOut;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_checkedIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_fillter;
        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_fillter;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTask;
        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonRemove;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button btnViewTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_taskProgress;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_todoTask;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label_doneTask;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private System.Windows.Forms.Label label_inprogressTask;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
    }
}
