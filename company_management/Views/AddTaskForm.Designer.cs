﻿
namespace company_management.Views
{
    partial class AddTaskForm
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.groupBox_newTask = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Bonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTime_deadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.combbox_Assignee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_taskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox_newTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // groupBox_newTask
            // 
            this.groupBox_newTask.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_newTask.Controls.Add(this.label1);
            this.groupBox_newTask.Controls.Add(this.textBox_Bonus);
            this.groupBox_newTask.Controls.Add(this.dateTime_deadline);
            this.groupBox_newTask.Controls.Add(this.label2);
            this.groupBox_newTask.Controls.Add(this.btnCancel);
            this.groupBox_newTask.Controls.Add(this.btnSave);
            this.groupBox_newTask.Controls.Add(this.combbox_Assignee);
            this.groupBox_newTask.Controls.Add(this.label_taskName);
            this.groupBox_newTask.Controls.Add(this.label3);
            this.groupBox_newTask.Controls.Add(this.label7);
            this.groupBox_newTask.Controls.Add(this.txtbox_Desciption);
            this.groupBox_newTask.Controls.Add(this.txtbox_taskName);
            this.groupBox_newTask.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.groupBox_newTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_newTask.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_newTask.ForeColor = System.Drawing.Color.Black;
            this.groupBox_newTask.Location = new System.Drawing.Point(0, 0);
            this.groupBox_newTask.Name = "groupBox_newTask";
            this.groupBox_newTask.Size = new System.Drawing.Size(795, 619);
            this.groupBox_newTask.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(633, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 103;
            this.label1.Text = "Bonus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Bonus
            // 
            this.textBox_Bonus.BorderColor = System.Drawing.Color.Black;
            this.textBox_Bonus.BorderRadius = 5;
            this.textBox_Bonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Bonus.DefaultText = "";
            this.textBox_Bonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Bonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Bonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Bonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Bonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Bonus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox_Bonus.ForeColor = System.Drawing.Color.Black;
            this.textBox_Bonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Bonus.Location = new System.Drawing.Point(637, 432);
            this.textBox_Bonus.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Bonus.Name = "textBox_Bonus";
            this.textBox_Bonus.PasswordChar = '\0';
            this.textBox_Bonus.PlaceholderText = "Exp: 200 $";
            this.textBox_Bonus.SelectedText = "";
            this.textBox_Bonus.Size = new System.Drawing.Size(136, 32);
            this.textBox_Bonus.TabIndex = 104;
            // 
            // dateTime_deadline
            // 
            this.dateTime_deadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_deadline.Location = new System.Drawing.Point(330, 434);
            this.dateTime_deadline.Name = "dateTime_deadline";
            this.dateTime_deadline.Size = new System.Drawing.Size(276, 30);
            this.dateTime_deadline.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 24;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::company_management.Properties.Resources.arrow_back_up;
            this.btnCancel.Location = new System.Drawing.Point(251, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 50);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 24;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("MesloLGM Nerd Font Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::company_management.Properties.Resources.device_floppy;
            this.btnSave.Location = new System.Drawing.Point(418, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 50);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.combbox_Assignee.Location = new System.Drawing.Point(24, 434);
            this.combbox_Assignee.Name = "combbox_Assignee";
            this.combbox_Assignee.Size = new System.Drawing.Size(276, 36);
            this.combbox_Assignee.TabIndex = 97;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.BackColor = System.Drawing.Color.Transparent;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(20, 38);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(103, 24);
            this.label_taskName.TabIndex = 92;
            this.label_taskName.Text = "Task name";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(326, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Due date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(20, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 96;
            this.label7.Text = "Assignee to";
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
            this.txtbox_Desciption.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_Desciption.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Location = new System.Drawing.Point(24, 149);
            this.txtbox_Desciption.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Desciption.Multiline = true;
            this.txtbox_Desciption.Name = "txtbox_Desciption";
            this.txtbox_Desciption.PasswordChar = '\0';
            this.txtbox_Desciption.PlaceholderText = "";
            this.txtbox_Desciption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Desciption.SelectedText = "";
            this.txtbox_Desciption.Size = new System.Drawing.Size(749, 238);
            this.txtbox_Desciption.TabIndex = 95;
            // 
            // txtbox_taskName
            // 
            this.txtbox_taskName.BorderColor = System.Drawing.Color.Black;
            this.txtbox_taskName.BorderRadius = 5;
            this.txtbox_taskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_taskName.DefaultText = "";
            this.txtbox_taskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_taskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_taskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_taskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_taskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_taskName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_taskName.ForeColor = System.Drawing.Color.Black;
            this.txtbox_taskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_taskName.Location = new System.Drawing.Point(24, 66);
            this.txtbox_taskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_taskName.Name = "txtbox_taskName";
            this.txtbox_taskName.PasswordChar = '\0';
            this.txtbox_taskName.PlaceholderText = "This is title";
            this.txtbox_taskName.SelectedText = "";
            this.txtbox_taskName.Size = new System.Drawing.Size(749, 32);
            this.txtbox_taskName.TabIndex = 94;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(795, 619);
            this.Controls.Add(this.groupBox_newTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new task";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.groupBox_newTask.ResumeLayout(false);
            this.groupBox_newTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_newTask;
        private System.Windows.Forms.DateTimePicker dateTime_deadline;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Assignee;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_taskName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Bonus;
    }
}