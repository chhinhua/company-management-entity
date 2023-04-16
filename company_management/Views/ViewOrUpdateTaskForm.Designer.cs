
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.combobox_progress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.circleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressValue = new System.Windows.Forms.Label();
            this.assigned_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_deadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combbox_Assignee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_Taskname = new Guna.UI2.WinForms.Guna2TextBox();
            this.picturebox_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBox_TaskDetail.SuspendLayout();
            this.circleProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_TaskDetail
            // 
            this.GroupBox_TaskDetail.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_TaskDetail.BorderRadius = 10;
            this.GroupBox_TaskDetail.Controls.Add(this.btnCancel);
            this.GroupBox_TaskDetail.Controls.Add(this.btnSave);
            this.GroupBox_TaskDetail.Controls.Add(this.guna2Button1);
            this.GroupBox_TaskDetail.Controls.Add(this.combobox_progress);
            this.GroupBox_TaskDetail.Controls.Add(this.label5);
            this.GroupBox_TaskDetail.Controls.Add(this.circleProgressBar);
            this.GroupBox_TaskDetail.Controls.Add(this.assigned_value);
            this.GroupBox_TaskDetail.Controls.Add(this.label1);
            this.GroupBox_TaskDetail.Controls.Add(this.dateTime_deadline);
            this.GroupBox_TaskDetail.Controls.Add(this.label2);
            this.GroupBox_TaskDetail.Controls.Add(this.combbox_Assignee);
            this.GroupBox_TaskDetail.Controls.Add(this.label_taskName);
            this.GroupBox_TaskDetail.Controls.Add(this.label3);
            this.GroupBox_TaskDetail.Controls.Add(this.label7);
            this.GroupBox_TaskDetail.Controls.Add(this.txtbox_Desciption);
            this.GroupBox_TaskDetail.Controls.Add(this.txtbox_Taskname);
            this.GroupBox_TaskDetail.Controls.Add(this.picturebox_Avatar);
            this.GroupBox_TaskDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_TaskDetail.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox_TaskDetail.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_TaskDetail.Name = "GroupBox_TaskDetail";
            this.GroupBox_TaskDetail.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.GroupBox_TaskDetail.ShadowDecoration.Enabled = true;
            this.GroupBox_TaskDetail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.GroupBox_TaskDetail.Size = new System.Drawing.Size(790, 675);
            this.GroupBox_TaskDetail.TabIndex = 113;
            this.GroupBox_TaskDetail.Text = "Chi tiết";
            this.GroupBox_TaskDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::company_management.Properties.Resources.device_floppy;
            this.guna2Button1.Location = new System.Drawing.Point(58, 261);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 50);
            this.guna2Button1.TabIndex = 166;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
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
            this.combobox_progress.Location = new System.Drawing.Point(129, 368);
            this.combobox_progress.Name = "combobox_progress";
            this.combobox_progress.Size = new System.Drawing.Size(95, 36);
            this.combobox_progress.TabIndex = 165;
            this.combobox_progress.SelectedIndexChanged += new System.EventHandler(this.combobox_progress_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(27, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 163;
            this.label5.Text = "Tiến độ (%)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.Controls.Add(this.progressValue);
            this.circleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.White;
            this.circleProgressBar.Location = new System.Drawing.Point(49, 424);
            this.circleProgressBar.Minimum = 0;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar.Size = new System.Drawing.Size(170, 170);
            this.circleProgressBar.TabIndex = 164;
            this.circleProgressBar.Text = "50";
            this.circleProgressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleProgressBar.Value = 50;
            // 
            // progressValue
            // 
            this.progressValue.BackColor = System.Drawing.Color.Transparent;
            this.progressValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressValue.ForeColor = System.Drawing.Color.Red;
            this.progressValue.Location = new System.Drawing.Point(44, 65);
            this.progressValue.Name = "progressValue";
            this.progressValue.Size = new System.Drawing.Size(95, 34);
            this.progressValue.TabIndex = 120;
            this.progressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assigned_value
            // 
            this.assigned_value.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigned_value.ForeColor = System.Drawing.Color.Black;
            this.assigned_value.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assigned_value.Location = new System.Drawing.Point(32, 215);
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
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 161;
            this.label1.Text = "Người được giao";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTime_deadline
            // 
            this.dateTime_deadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_deadline.Location = new System.Drawing.Point(285, 437);
            this.dateTime_deadline.Name = "dateTime_deadline";
            this.dateTime_deadline.Size = new System.Drawing.Size(478, 30);
            this.dateTime_deadline.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(281, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 159;
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
            this.combbox_Assignee.Location = new System.Drawing.Point(285, 515);
            this.combbox_Assignee.Name = "combbox_Assignee";
            this.combbox_Assignee.Size = new System.Drawing.Size(478, 36);
            this.combbox_Assignee.TabIndex = 158;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(281, 68);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(81, 24);
            this.label_taskName.TabIndex = 153;
            this.label_taskName.Text = "Tên task";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(281, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 154;
            this.label3.Text = "Deadline:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(281, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 157;
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
            this.txtbox_Desciption.Location = new System.Drawing.Point(285, 170);
            this.txtbox_Desciption.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Desciption.Multiline = true;
            this.txtbox_Desciption.Name = "txtbox_Desciption";
            this.txtbox_Desciption.PasswordChar = '\0';
            this.txtbox_Desciption.PlaceholderText = "";
            this.txtbox_Desciption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Desciption.SelectedText = "";
            this.txtbox_Desciption.Size = new System.Drawing.Size(478, 219);
            this.txtbox_Desciption.TabIndex = 156;
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
            this.txtbox_Taskname.Location = new System.Drawing.Point(285, 96);
            this.txtbox_Taskname.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Taskname.Name = "txtbox_Taskname";
            this.txtbox_Taskname.PasswordChar = '\0';
            this.txtbox_Taskname.PlaceholderText = "";
            this.txtbox_Taskname.SelectedText = "";
            this.txtbox_Taskname.Size = new System.Drawing.Size(478, 32);
            this.txtbox_Taskname.TabIndex = 155;
            // 
            // picturebox_Avatar
            // 
            this.picturebox_Avatar.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_Avatar.Image = global::company_management.Properties.Resources.avatar1;
            this.picturebox_Avatar.ImageRotate = 0F;
            this.picturebox_Avatar.Location = new System.Drawing.Point(76, 95);
            this.picturebox_Avatar.Name = "picturebox_Avatar";
            this.picturebox_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_Avatar.Size = new System.Drawing.Size(103, 91);
            this.picturebox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Avatar.TabIndex = 152;
            this.picturebox_Avatar.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::company_management.Properties.Resources.arrow_back_up;
            this.btnCancel.Location = new System.Drawing.Point(546, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 50);
            this.btnCancel.TabIndex = 168;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::company_management.Properties.Resources.device_floppy;
            this.btnSave.Location = new System.Drawing.Point(285, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 50);
            this.btnSave.TabIndex = 167;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ViewOrUpdateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 699);
            this.Controls.Add(this.GroupBox_TaskDetail);
            this.Name = "ViewOrUpdateTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DateTimePicker dateTime_deadline;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Assignee;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Taskname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_Avatar;
    }
}