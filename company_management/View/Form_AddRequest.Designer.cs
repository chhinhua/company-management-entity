
namespace company_management.View
{
    partial class Form_AddRequest
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
            this.datetime_to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.txtbox_Reason.Location = new System.Drawing.Point(13, 62);
            this.txtbox_Reason.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbox_Reason.Multiline = true;
            this.txtbox_Reason.Name = "txtbox_Reason";
            this.txtbox_Reason.PasswordChar = '\0';
            this.txtbox_Reason.PlaceholderText = "Nhập nội dung xin nghỉ";
            this.txtbox_Reason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Reason.SelectedText = "";
            this.txtbox_Reason.Size = new System.Drawing.Size(466, 325);
            this.txtbox_Reason.TabIndex = 95;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // datetime_to
            // 
            this.datetime_to.BackColor = System.Drawing.Color.Transparent;
            this.datetime_to.BorderRadius = 10;
            this.datetime_to.Checked = true;
            this.datetime_to.CustomFormat = "dd/MM/yyyy";
            this.datetime_to.FillColor = System.Drawing.Color.White;
            this.datetime_to.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_to.Location = new System.Drawing.Point(11, 526);
            this.datetime_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_to.Name = "datetime_to";
            this.datetime_to.Size = new System.Drawing.Size(467, 49);
            this.datetime_to.TabIndex = 101;
            this.datetime_to.Value = new System.DateTime(2023, 4, 26, 20, 37, 46, 0);
            // 
            // datetime_from
            // 
            this.datetime_from.BackColor = System.Drawing.Color.Transparent;
            this.datetime_from.BorderRadius = 10;
            this.datetime_from.Checked = true;
            this.datetime_from.CustomFormat = "dd/MM/yyyy";
            this.datetime_from.FillColor = System.Drawing.Color.White;
            this.datetime_from.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_from.Location = new System.Drawing.Point(11, 438);
            this.datetime_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_from.Name = "datetime_from";
            this.datetime_from.Size = new System.Drawing.Size(466, 46);
            this.datetime_from.TabIndex = 102;
            this.datetime_from.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            this.datetime_from.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 103;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Đến:";
            // 
            // buttn_Save
            // 
            this.buttn_Save.BackColor = System.Drawing.Color.Transparent;
            this.buttn_Save.BorderRadius = 10;
            this.buttn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttn_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttn_Save.ForeColor = System.Drawing.Color.White;
            this.buttn_Save.Location = new System.Drawing.Point(11, 622);
            this.buttn_Save.Name = "buttn_Save";
            this.buttn_Save.Size = new System.Drawing.Size(466, 50);
            this.buttn_Save.TabIndex = 182;
            this.buttn_Save.Text = "Apply";
            this.buttn_Save.Click += new System.EventHandler(this.buttn_Save_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::company_management.Properties.Resources.edit___Copy;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 38);
            this.label3.TabIndex = 183;
            this.label3.Text = "Tạo đơn xin nghỉ";
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 696);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime_from);
            this.Controls.Add(this.datetime_to);
            this.Controls.Add(this.txtbox_Reason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Reason;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_from;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttn_Save;
        private System.Windows.Forms.Label label3;
    }
}