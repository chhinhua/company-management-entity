﻿
namespace company_management.Views
{
    partial class ViewOrUpdateTaskForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_TaskDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.combobox_progress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.circleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressValue = new System.Windows.Forms.Label();
            this.assigned_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.picturebox_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dateTime_deadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combbox_Assignee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_Taskname = new Guna.UI2.WinForms.Guna2TextBox();
            this.GroupBox_TaskDetail.SuspendLayout();
            this.circleProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_TaskDetail
            // 
            this.GroupBox_TaskDetail.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_TaskDetail.Controls.Add(this.dateTime_deadline);
            this.GroupBox_TaskDetail.Controls.Add(this.label2);
            this.GroupBox_TaskDetail.Controls.Add(this.combbox_Assignee);
            this.GroupBox_TaskDetail.Controls.Add(this.label_taskName);
            this.GroupBox_TaskDetail.Controls.Add(this.label3);
            this.GroupBox_TaskDetail.Controls.Add(this.label7);
            this.GroupBox_TaskDetail.Controls.Add(this.txtbox_Desciption);
            this.GroupBox_TaskDetail.Controls.Add(this.txtbox_Taskname);
            this.GroupBox_TaskDetail.Controls.Add(this.btnCancel);
            this.GroupBox_TaskDetail.Controls.Add(this.btnSave);
            this.GroupBox_TaskDetail.Controls.Add(this.guna2Button1);
            this.GroupBox_TaskDetail.Controls.Add(this.combobox_progress);
            this.GroupBox_TaskDetail.Controls.Add(this.label5);
            this.GroupBox_TaskDetail.Controls.Add(this.circleProgressBar);
            this.GroupBox_TaskDetail.Controls.Add(this.assigned_value);
            this.GroupBox_TaskDetail.Controls.Add(this.label1);
            this.GroupBox_TaskDetail.Controls.Add(this.picturebox_Avatar);
            this.GroupBox_TaskDetail.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupBox_TaskDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_TaskDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_TaskDetail.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox_TaskDetail.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_TaskDetail.Name = "GroupBox_TaskDetail";
            this.GroupBox_TaskDetail.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.GroupBox_TaskDetail.ShadowDecoration.Enabled = true;
            this.GroupBox_TaskDetail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.GroupBox_TaskDetail.Size = new System.Drawing.Size(884, 694);
            this.GroupBox_TaskDetail.TabIndex = 113;
            // 
            // combobox_progress
            // 
            this.combobox_progress.BackColor = System.Drawing.Color.Transparent;
            this.combobox_progress.BorderRadius = 5;
            this.combobox_progress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_progress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_progress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_progress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_progress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_progress.ForeColor = System.Drawing.Color.Black;
            this.combobox_progress.ItemHeight = 30;
            this.combobox_progress.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.combobox_progress.Location = new System.Drawing.Point(719, 286);
            this.combobox_progress.Name = "combobox_progress";
            this.combobox_progress.Size = new System.Drawing.Size(95, 36);
            this.combobox_progress.TabIndex = 165;
            this.combobox_progress.SelectedIndexChanged += new System.EventHandler(this.combobox_progress_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(615, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 163;
            this.label5.Text = "Tiến độ (%)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.Controls.Add(this.progressValue);
            this.circleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleProgressBar.FillThickness = 30;
            this.circleProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.White;
            this.circleProgressBar.Location = new System.Drawing.Point(610, 337);
            this.circleProgressBar.Minimum = 0;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProgressBar.ProgressThickness = 35;
            this.circleProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar.Size = new System.Drawing.Size(217, 217);
            this.circleProgressBar.TabIndex = 164;
            this.circleProgressBar.Text = "50";
            this.circleProgressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleProgressBar.Value = 50;
            // 
            // progressValue
            // 
            this.progressValue.BackColor = System.Drawing.Color.Transparent;
            this.progressValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressValue.ForeColor = System.Drawing.Color.Red;
            this.progressValue.Location = new System.Drawing.Point(62, 89);
            this.progressValue.Name = "progressValue";
            this.progressValue.Size = new System.Drawing.Size(112, 44);
            this.progressValue.TabIndex = 120;
            this.progressValue.Text = "50%";
            this.progressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assigned_value
            // 
            this.assigned_value.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigned_value.ForeColor = System.Drawing.Color.Black;
            this.assigned_value.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assigned_value.Location = new System.Drawing.Point(623, 160);
            this.assigned_value.Name = "assigned_value";
            this.assigned_value.Size = new System.Drawing.Size(192, 28);
            this.assigned_value.TabIndex = 162;
            this.assigned_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(652, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 161;
            this.label1.Text = "Người được giao";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 24;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::company_management.Properties.Resources.arrow_back_up;
            this.btnCancel.Location = new System.Drawing.Point(283, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 50);
            this.btnCancel.TabIndex = 168;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 24;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::company_management.Properties.Resources.device_floppy;
            this.btnSave.Location = new System.Drawing.Point(460, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 50);
            this.btnSave.TabIndex = 167;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 24;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::company_management.Properties.Resources.device_floppy;
            this.guna2Button1.Location = new System.Drawing.Point(655, 202);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 50);
            this.guna2Button1.TabIndex = 166;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // picturebox_Avatar
            // 
            this.picturebox_Avatar.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_Avatar.Image = global::company_management.Properties.Resources.avatar1;
            this.picturebox_Avatar.ImageRotate = 0F;
            this.picturebox_Avatar.Location = new System.Drawing.Point(665, 66);
            this.picturebox_Avatar.Name = "picturebox_Avatar";
            this.picturebox_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_Avatar.Size = new System.Drawing.Size(103, 91);
            this.picturebox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Avatar.TabIndex = 152;
            this.picturebox_Avatar.TabStop = false;
            // 
            // dateTime_deadline
            // 
            this.dateTime_deadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_deadline.Location = new System.Drawing.Point(30, 407);
            this.dateTime_deadline.Name = "dateTime_deadline";
            this.dateTime_deadline.Size = new System.Drawing.Size(478, 30);
            this.dateTime_deadline.TabIndex = 177;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 176;
            this.label2.Text = "Chú thích";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combbox_Assignee
            // 
            this.combbox_Assignee.BackColor = System.Drawing.Color.Transparent;
            this.combbox_Assignee.BorderRadius = 5;
            this.combbox_Assignee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_Assignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_Assignee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbox_Assignee.ForeColor = System.Drawing.Color.Black;
            this.combbox_Assignee.ItemHeight = 30;
            this.combbox_Assignee.Location = new System.Drawing.Point(30, 485);
            this.combbox_Assignee.Name = "combbox_Assignee";
            this.combbox_Assignee.Size = new System.Drawing.Size(478, 36);
            this.combbox_Assignee.TabIndex = 175;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(26, 38);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(81, 24);
            this.label_taskName.TabIndex = 170;
            this.label_taskName.Text = "Tên task";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(26, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 171;
            this.label3.Text = "Deadline:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(26, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 174;
            this.label7.Text = "Giao task";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbox_Desciption
            // 
            this.txtbox_Desciption.BorderColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.BorderRadius = 5;
            this.txtbox_Desciption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Desciption.DefaultText = "";
            this.txtbox_Desciption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Desciption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Desciption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Desciption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Desciption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Desciption.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Location = new System.Drawing.Point(30, 140);
            this.txtbox_Desciption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_Desciption.Multiline = true;
            this.txtbox_Desciption.Name = "txtbox_Desciption";
            this.txtbox_Desciption.PasswordChar = '\0';
            this.txtbox_Desciption.PlaceholderText = "";
            this.txtbox_Desciption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Desciption.SelectedText = "";
            this.txtbox_Desciption.Size = new System.Drawing.Size(478, 219);
            this.txtbox_Desciption.TabIndex = 173;
            // 
            // txtbox_Taskname
            // 
            this.txtbox_Taskname.BorderColor = System.Drawing.Color.Black;
            this.txtbox_Taskname.BorderRadius = 5;
            this.txtbox_Taskname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Taskname.DefaultText = "";
            this.txtbox_Taskname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Taskname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Taskname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Taskname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Taskname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Taskname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Taskname.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Taskname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Taskname.Location = new System.Drawing.Point(30, 66);
            this.txtbox_Taskname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_Taskname.Name = "txtbox_Taskname";
            this.txtbox_Taskname.PasswordChar = '\0';
            this.txtbox_Taskname.PlaceholderText = "";
            this.txtbox_Taskname.SelectedText = "";
            this.txtbox_Taskname.Size = new System.Drawing.Size(478, 32);
            this.txtbox_Taskname.TabIndex = 172;
            // 
            // ViewOrUpdateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(884, 694);
            this.Controls.Add(this.GroupBox_TaskDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewOrUpdateTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết task";
            this.Load += new System.EventHandler(this.ViewOrUpdateTaskForm_Load);
            this.GroupBox_TaskDetail.ResumeLayout(false);
            this.GroupBox_TaskDetail.PerformLayout();
            this.circleProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupBox_TaskDetail;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_progress;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar;
        private System.Windows.Forms.Label progressValue;
        private System.Windows.Forms.Label assigned_value;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_Avatar;
        private System.Windows.Forms.DateTimePicker dateTime_deadline;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Assignee;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Taskname;
    }
}