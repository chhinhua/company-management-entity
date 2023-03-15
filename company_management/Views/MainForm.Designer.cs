namespace company_management.Views
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabbar = new Guna.UI2.WinForms.Guna2Panel();
            this.picboxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.combobox_profile = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavereq = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimeKeep = new Guna.UI2.WinForms.Guna2Button();
            this.btnTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalary = new Guna.UI2.WinForms.Guna2Button();
            this.btnKpi = new Guna.UI2.WinForms.Guna2Button();
            this.pnContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).BeginInit();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1384, 59);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabbar
            // 
            this.tabbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabbar.BorderColor = System.Drawing.Color.Black;
            this.tabbar.Controls.Add(this.picboxProfile);
            this.tabbar.Controls.Add(this.combobox_profile);
            this.tabbar.Controls.Add(this.guna2Button1);
            this.tabbar.Controls.Add(this.btnHome);
            this.tabbar.Controls.Add(this.btnLeavereq);
            this.tabbar.Controls.Add(this.btnTimeKeep);
            this.tabbar.Controls.Add(this.btnTask);
            this.tabbar.Controls.Add(this.btnSalary);
            this.tabbar.Controls.Add(this.btnKpi);
            this.tabbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbar.Location = new System.Drawing.Point(0, 59);
            this.tabbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabbar.Name = "tabbar";
            this.tabbar.ShadowDecoration.BorderRadius = 0;
            this.tabbar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabbar.ShadowDecoration.Enabled = true;
            this.tabbar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.tabbar.Size = new System.Drawing.Size(1384, 57);
            this.tabbar.TabIndex = 13;
            this.tabbar.TabStop = true;
            // 
            // picboxProfile
            // 
            this.picboxProfile.BackColor = System.Drawing.Color.Transparent;
            this.picboxProfile.FillColor = System.Drawing.Color.Transparent;
            this.picboxProfile.Image = global::company_management.Properties.Resources.user_circle__1_;
            this.picboxProfile.ImageRotate = 0F;
            this.picboxProfile.Location = new System.Drawing.Point(1304, 8);
            this.picboxProfile.Name = "picboxProfile";
            this.picboxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxProfile.Size = new System.Drawing.Size(50, 46);
            this.picboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxProfile.TabIndex = 21;
            this.picboxProfile.TabStop = false;
            this.picboxProfile.Click += new System.EventHandler(this.picboxProfile_Click);
            // 
            // combobox_profile
            // 
            this.combobox_profile.AutoRoundedCorners = true;
            this.combobox_profile.BackColor = System.Drawing.Color.Transparent;
            this.combobox_profile.BorderColor = System.Drawing.Color.Silver;
            this.combobox_profile.BorderRadius = 17;
            this.combobox_profile.BorderThickness = 0;
            this.combobox_profile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.combobox_profile.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_profile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_profile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.combobox_profile.ForeColor = System.Drawing.Color.Black;
            this.combobox_profile.ItemHeight = 30;
            this.combobox_profile.Items.AddRange(new object[] {
            "Your profile",
            "Your task",
            "Your salary",
            "Sign out"});
            this.combobox_profile.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.combobox_profile.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.combobox_profile.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Silver;
            this.combobox_profile.Location = new System.Drawing.Point(1223, 17);
            this.combobox_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_profile.Name = "combobox_profile";
            this.combobox_profile.Size = new System.Drawing.Size(158, 36);
            this.combobox_profile.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Location = new System.Drawing.Point(559, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 57);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Users";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHome.DefaultAutoSize = true;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(504, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(55, 57);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "KPI";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLeavereq
            // 
            this.btnLeavereq.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavereq.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLeavereq.DefaultAutoSize = true;
            this.btnLeavereq.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavereq.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavereq.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavereq.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavereq.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeavereq.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLeavereq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavereq.ForeColor = System.Drawing.Color.Black;
            this.btnLeavereq.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeavereq.Location = new System.Drawing.Point(369, 0);
            this.btnLeavereq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeavereq.Name = "btnLeavereq";
            this.btnLeavereq.Size = new System.Drawing.Size(135, 57);
            this.btnLeavereq.TabIndex = 19;
            this.btnLeavereq.Text = "Leave Request";
            this.btnLeavereq.Click += new System.EventHandler(this.btnLeavereq_Click);
            // 
            // btnTimeKeep
            // 
            this.btnTimeKeep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeKeep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTimeKeep.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTimeKeep.DefaultAutoSize = true;
            this.btnTimeKeep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimeKeep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimeKeep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimeKeep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimeKeep.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimeKeep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimeKeep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeKeep.ForeColor = System.Drawing.Color.Black;
            this.btnTimeKeep.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimeKeep.Location = new System.Drawing.Point(239, 0);
            this.btnTimeKeep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimeKeep.Name = "btnTimeKeep";
            this.btnTimeKeep.Size = new System.Drawing.Size(130, 57);
            this.btnTimeKeep.TabIndex = 14;
            this.btnTimeKeep.Text = "Time Keeping";
            this.btnTimeKeep.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTask.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTask.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTask.DefaultAutoSize = true;
            this.btnTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.Black;
            this.btnTask.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTask.Location = new System.Drawing.Point(176, 0);
            this.btnTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(63, 57);
            this.btnTask.TabIndex = 18;
            this.btnTask.Text = "Task";
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSalary.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSalary.DefaultAutoSize = true;
            this.btnSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.Black;
            this.btnSalary.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalary.Location = new System.Drawing.Point(101, 0);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(75, 57);
            this.btnSalary.TabIndex = 16;
            this.btnSalary.Text = "Salary";
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnKpi
            // 
            this.btnKpi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKpi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKpi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKpi.DefaultAutoSize = true;
            this.btnKpi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKpi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKpi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKpi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKpi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKpi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKpi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKpi.ForeColor = System.Drawing.Color.Black;
            this.btnKpi.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKpi.Image = global::company_management.Properties.Resources.brand_apple;
            this.btnKpi.Location = new System.Drawing.Point(0, 0);
            this.btnKpi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKpi.Name = "btnKpi";
            this.btnKpi.Size = new System.Drawing.Size(101, 57);
            this.btnKpi.TabIndex = 17;
            this.btnKpi.Text = "Home";
            this.btnKpi.Click += new System.EventHandler(this.btnKpi_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.guna2Panel2);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 116);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1384, 667);
            this.pnContainer.TabIndex = 15;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1384, 667);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(569, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "KMS Solution";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::company_management.Properties.Resources.icons8_logout_rounded_100;
            this.pictureBox2.Location = new System.Drawing.Point(1332, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 783);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.tabbar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabbar.ResumeLayout(false);
            this.tabbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).EndInit();
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel tabbar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLeavereq;
        private Guna.UI2.WinForms.Guna2Button btnTimeKeep;
        private Guna.UI2.WinForms.Guna2Button btnTask;
        private Guna.UI2.WinForms.Guna2Button btnSalary;
        private Guna.UI2.WinForms.Guna2Button btnKpi;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_profile;
        private Guna.UI2.WinForms.Guna2Panel pnContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxProfile;
    }
}