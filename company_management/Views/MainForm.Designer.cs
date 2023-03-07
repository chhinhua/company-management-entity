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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ptbProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavereq = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimeKeep = new Guna.UI2.WinForms.Guna2Button();
            this.btnTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalary = new Guna.UI2.WinForms.Guna2Button();
            this.btnKpi = new Guna.UI2.WinForms.Guna2Button();
            this.cbbprofile = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(135)))), ((int)(((byte)(48)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1390, 74);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.ptbProfile);
            this.guna2Panel1.Controls.Add(this.btnHome);
            this.guna2Panel1.Controls.Add(this.btnLeavereq);
            this.guna2Panel1.Controls.Add(this.btnTimeKeep);
            this.guna2Panel1.Controls.Add(this.btnTask);
            this.guna2Panel1.Controls.Add(this.btnSalary);
            this.guna2Panel1.Controls.Add(this.btnKpi);
            this.guna2Panel1.Controls.Add(this.cbbprofile);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 74);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1390, 95);
            this.guna2Panel1.TabIndex = 13;
            // 
            // ptbProfile
            // 
            this.ptbProfile.Image = global::company_management.Properties.Resources._10673808141645017009_48;
            this.ptbProfile.ImageRotate = 0F;
            this.ptbProfile.Location = new System.Drawing.Point(1294, 13);
            this.ptbProfile.Name = "ptbProfile";
            this.ptbProfile.Size = new System.Drawing.Size(65, 59);
            this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProfile.TabIndex = 0;
            this.ptbProfile.TabStop = false;
            this.ptbProfile.Click += new System.EventHandler(this.ptbProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(710, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 95);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLeavereq
            // 
            this.btnLeavereq.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavereq.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLeavereq.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavereq.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavereq.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavereq.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavereq.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeavereq.FillColor = System.Drawing.Color.White;
            this.btnLeavereq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavereq.ForeColor = System.Drawing.Color.Black;
            this.btnLeavereq.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeavereq.Location = new System.Drawing.Point(568, 0);
            this.btnLeavereq.Name = "btnLeavereq";
            this.btnLeavereq.Size = new System.Drawing.Size(142, 95);
            this.btnLeavereq.TabIndex = 19;
            this.btnLeavereq.Text = "Leave Request";
            this.btnLeavereq.Click += new System.EventHandler(this.btnLeavereq_Click);
            // 
            // btnTimeKeep
            // 
            this.btnTimeKeep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTimeKeep.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTimeKeep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimeKeep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimeKeep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimeKeep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimeKeep.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimeKeep.FillColor = System.Drawing.Color.White;
            this.btnTimeKeep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeKeep.ForeColor = System.Drawing.Color.Black;
            this.btnTimeKeep.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimeKeep.Location = new System.Drawing.Point(426, 0);
            this.btnTimeKeep.Name = "btnTimeKeep";
            this.btnTimeKeep.Size = new System.Drawing.Size(142, 95);
            this.btnTimeKeep.TabIndex = 14;
            this.btnTimeKeep.Text = "Time Keeping";
            this.btnTimeKeep.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnTask
            // 
            this.btnTask.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTask.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTask.FillColor = System.Drawing.Color.White;
            this.btnTask.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.Black;
            this.btnTask.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTask.Location = new System.Drawing.Point(284, 0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(142, 95);
            this.btnTask.TabIndex = 18;
            this.btnTask.Text = "Task";
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSalary.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalary.FillColor = System.Drawing.Color.White;
            this.btnSalary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.Black;
            this.btnSalary.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalary.Location = new System.Drawing.Point(142, 0);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(142, 95);
            this.btnSalary.TabIndex = 16;
            this.btnSalary.Text = "Salary";
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnKpi
            // 
            this.btnKpi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKpi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKpi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKpi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKpi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKpi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKpi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKpi.FillColor = System.Drawing.Color.White;
            this.btnKpi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKpi.ForeColor = System.Drawing.Color.Black;
            this.btnKpi.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKpi.Location = new System.Drawing.Point(0, 0);
            this.btnKpi.Name = "btnKpi";
            this.btnKpi.Size = new System.Drawing.Size(142, 95);
            this.btnKpi.TabIndex = 17;
            this.btnKpi.Text = "KPI";
            this.btnKpi.Click += new System.EventHandler(this.btnKpi_Click);
            // 
            // cbbprofile
            // 
            this.cbbprofile.BackColor = System.Drawing.Color.Transparent;
            this.cbbprofile.BorderColor = System.Drawing.Color.White;
            this.cbbprofile.BorderThickness = 0;
            this.cbbprofile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbprofile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbprofile.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbprofile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbprofile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbprofile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbprofile.ItemHeight = 30;
            this.cbbprofile.Items.AddRange(new object[] {
            "Logout",
            "profile"});
            this.cbbprofile.Location = new System.Drawing.Point(1249, 13);
            this.cbbprofile.Name = "cbbprofile";
            this.cbbprofile.Size = new System.Drawing.Size(140, 36);
            this.cbbprofile.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(135)))), ((int)(((byte)(48)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::company_management.Properties.Resources.icons8_logout_rounded_100;
            this.pictureBox2.Location = new System.Drawing.Point(1302, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(135)))), ((int)(((byte)(48)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::company_management.Properties.Resources._15009037641673701313_64;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.guna2Panel2);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 169);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1390, 711);
            this.pnContainer.TabIndex = 15;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1390, 711);
            this.guna2Panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 880);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLeavereq;
        private Guna.UI2.WinForms.Guna2Button btnTimeKeep;
        private Guna.UI2.WinForms.Guna2Button btnTask;
        private Guna.UI2.WinForms.Guna2Button btnSalary;
        private Guna.UI2.WinForms.Guna2Button btnKpi;
        private Guna.UI2.WinForms.Guna2PictureBox ptbProfile;
        private Guna.UI2.WinForms.Guna2ComboBox cbbprofile;
        private Guna.UI2.WinForms.Guna2Panel pnContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}