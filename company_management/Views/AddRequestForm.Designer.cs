
namespace company_management.Views
{
    partial class AddRequestForm
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
            this.components = new System.ComponentModel.Container();
            this.txtbox_Reason = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.datetime_to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtbox_Reason
            // 
            this.txtbox_Reason.BorderColor = System.Drawing.Color.Black;
            this.txtbox_Reason.BorderRadius = 5;
            this.txtbox_Reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Reason.DefaultText = "";
            this.txtbox_Reason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Reason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Reason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Reason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Reason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Reason.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_Reason.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Reason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Reason.Location = new System.Drawing.Point(29, 102);
            this.txtbox_Reason.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Reason.Multiline = true;
            this.txtbox_Reason.Name = "txtbox_Reason";
            this.txtbox_Reason.PasswordChar = '\0';
            this.txtbox_Reason.PlaceholderText = "Nhập nội dung xin nghỉ";
            this.txtbox_Reason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Reason.SelectedText = "";
            this.txtbox_Reason.Size = new System.Drawing.Size(478, 175);
            this.txtbox_Reason.TabIndex = 95;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(538, 48);
            this.label9.TabIndex = 100;
            this.label9.Text = "Tạo đơn xin nghỉ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datetime_to
            // 
            this.datetime_to.BackColor = System.Drawing.Color.Transparent;
            this.datetime_to.BorderRadius = 10;
            this.datetime_to.Checked = true;
            this.datetime_to.FillColor = System.Drawing.Color.White;
            this.datetime_to.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_to.Location = new System.Drawing.Point(332, 320);
            this.datetime_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_to.Name = "datetime_to";
            this.datetime_to.Size = new System.Drawing.Size(175, 36);
            this.datetime_to.TabIndex = 101;
            this.datetime_to.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // datetime_from
            // 
            this.datetime_from.BackColor = System.Drawing.Color.Transparent;
            this.datetime_from.BorderRadius = 10;
            this.datetime_from.Checked = true;
            this.datetime_from.FillColor = System.Drawing.Color.White;
            this.datetime_from.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_from.Location = new System.Drawing.Point(67, 320);
            this.datetime_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_from.Name = "datetime_from";
            this.datetime_from.Size = new System.Drawing.Size(183, 36);
            this.datetime_from.TabIndex = 102;
            this.datetime_from.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            this.datetime_from.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 103;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Đến:";
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
            this.btnCancel.Location = new System.Drawing.Point(290, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 50);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Hủy";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::company_management.Properties.Resources.device_floppy;
            this.btnSave.Location = new System.Drawing.Point(29, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 50);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "Lưu";
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime_from);
            this.Controls.Add(this.datetime_to);
            this.Controls.Add(this.txtbox_Reason);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRequestForm";
            this.Text = "AddRequestForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Reason;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_from;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}