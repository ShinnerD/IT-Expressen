﻿namespace GUI
{
    partial class Manager
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_Firstname = new TextBox();
            tb_Email = new TextBox();
            tb_Phonenumber = new TextBox();
            tb_Lastname = new TextBox();
            tb_Address = new TextBox();
            tb_City = new TextBox();
            tb_Zipcode = new TextBox();
            tb_Country = new TextBox();
            bt_FindConsultants = new Button();
            bt_NewProject = new Button();
            grpBoxProfileInfo = new GroupBox();
            bt_EditProfileCancel = new Button();
            lblUserCreationDate = new Label();
            bt_EditProfile = new Button();
            groupBox2 = new GroupBox();
            bt_manageProject = new Button();
            bt_EditProject = new Button();
            dgv_Viewproject = new DataGridView();
            grpBoxProfileInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(326, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "City:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(305, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 51);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Lastname:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(305, 77);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 7;
            label8.Text = "Zipcode:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(304, 104);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 8;
            label9.Text = "Country:";
            label9.Click += label9_Click;
            // 
            // tb_Firstname
            // 
            tb_Firstname.BackColor = SystemColors.ControlLight;
            tb_Firstname.BorderStyle = BorderStyle.None;
            tb_Firstname.Enabled = false;
            tb_Firstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Firstname.Location = new Point(71, 22);
            tb_Firstname.Margin = new Padding(2);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.Size = new Size(225, 16);
            tb_Firstname.TabIndex = 1;
            tb_Firstname.TabStop = false;
            tb_Firstname.TextChanged += tb_Firstname_TextChanged;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = SystemColors.ControlLight;
            tb_Email.BorderStyle = BorderStyle.None;
            tb_Email.Enabled = false;
            tb_Email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.Location = new Point(71, 74);
            tb_Email.Margin = new Padding(2);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(225, 16);
            tb_Email.TabIndex = 3;
            tb_Email.TabStop = false;
            tb_Email.TextChanged += tb_Email_TextChanged;
            // 
            // tb_Phonenumber
            // 
            tb_Phonenumber.BackColor = SystemColors.ControlLight;
            tb_Phonenumber.BorderStyle = BorderStyle.None;
            tb_Phonenumber.Enabled = false;
            tb_Phonenumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phonenumber.Location = new Point(71, 101);
            tb_Phonenumber.Margin = new Padding(2);
            tb_Phonenumber.Name = "tb_Phonenumber";
            tb_Phonenumber.Size = new Size(225, 16);
            tb_Phonenumber.TabIndex = 4;
            tb_Phonenumber.TabStop = false;
            tb_Phonenumber.TextChanged += tb_Phonenumber_TextChanged;
            // 
            // tb_Lastname
            // 
            tb_Lastname.BackColor = SystemColors.ControlLight;
            tb_Lastname.BorderStyle = BorderStyle.None;
            tb_Lastname.Enabled = false;
            tb_Lastname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Lastname.Location = new Point(71, 48);
            tb_Lastname.Margin = new Padding(2);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.Size = new Size(225, 16);
            tb_Lastname.TabIndex = 2;
            tb_Lastname.TabStop = false;
            tb_Lastname.TextChanged += tb_Lastname_TextChanged;
            // 
            // tb_Address
            // 
            tb_Address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Address.BackColor = SystemColors.ControlLight;
            tb_Address.BorderStyle = BorderStyle.None;
            tb_Address.Enabled = false;
            tb_Address.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(360, 22);
            tb_Address.Margin = new Padding(2);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(328, 16);
            tb_Address.TabIndex = 5;
            tb_Address.TabStop = false;
            tb_Address.TextChanged += tb_Address_TextChanged;
            // 
            // tb_City
            // 
            tb_City.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_City.BackColor = SystemColors.ControlLight;
            tb_City.BorderStyle = BorderStyle.None;
            tb_City.Enabled = false;
            tb_City.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_City.Location = new Point(360, 49);
            tb_City.Margin = new Padding(2);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(328, 16);
            tb_City.TabIndex = 6;
            tb_City.TabStop = false;
            tb_City.TextChanged += tb_City_TextChanged;
            // 
            // tb_Zipcode
            // 
            tb_Zipcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Zipcode.BackColor = SystemColors.ControlLight;
            tb_Zipcode.BorderStyle = BorderStyle.None;
            tb_Zipcode.Enabled = false;
            tb_Zipcode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Zipcode.Location = new Point(360, 74);
            tb_Zipcode.Margin = new Padding(2);
            tb_Zipcode.Name = "tb_Zipcode";
            tb_Zipcode.Size = new Size(328, 16);
            tb_Zipcode.TabIndex = 7;
            tb_Zipcode.TabStop = false;
            tb_Zipcode.TextChanged += tb_Zipcode_TextChanged;
            // 
            // tb_Country
            // 
            tb_Country.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Country.BackColor = SystemColors.ControlLight;
            tb_Country.BorderStyle = BorderStyle.None;
            tb_Country.Enabled = false;
            tb_Country.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Country.Location = new Point(360, 101);
            tb_Country.Margin = new Padding(2);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(328, 16);
            tb_Country.TabIndex = 8;
            tb_Country.TabStop = false;
            tb_Country.TextChanged += tb_Country_TextChanged;
            // 
            // bt_FindConsultants
            // 
            bt_FindConsultants.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bt_FindConsultants.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_FindConsultants.Location = new Point(6, 342);
            bt_FindConsultants.Margin = new Padding(2);
            bt_FindConsultants.Name = "bt_FindConsultants";
            bt_FindConsultants.Size = new Size(110, 25);
            bt_FindConsultants.TabIndex = 11;
            bt_FindConsultants.Text = "Find Consultants";
            bt_FindConsultants.UseVisualStyleBackColor = true;
            bt_FindConsultants.Click += bt_FindConsultants_Click;
            // 
            // bt_NewProject
            // 
            bt_NewProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_NewProject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_NewProject.Location = new Point(360, 342);
            bt_NewProject.Margin = new Padding(2);
            bt_NewProject.Name = "bt_NewProject";
            bt_NewProject.Size = new Size(110, 25);
            bt_NewProject.TabIndex = 12;
            bt_NewProject.Text = "Start New Project";
            bt_NewProject.UseVisualStyleBackColor = true;
            bt_NewProject.Click += bt_NewProject_Click;
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(bt_EditProfileCancel);
            grpBoxProfileInfo.Controls.Add(lblUserCreationDate);
            grpBoxProfileInfo.Controls.Add(bt_EditProfile);
            grpBoxProfileInfo.Controls.Add(label2);
            grpBoxProfileInfo.Controls.Add(tb_Firstname);
            grpBoxProfileInfo.Controls.Add(label7);
            grpBoxProfileInfo.Controls.Add(tb_Country);
            grpBoxProfileInfo.Controls.Add(tb_Lastname);
            grpBoxProfileInfo.Controls.Add(label9);
            grpBoxProfileInfo.Controls.Add(tb_Zipcode);
            grpBoxProfileInfo.Controls.Add(label8);
            grpBoxProfileInfo.Controls.Add(label3);
            grpBoxProfileInfo.Controls.Add(tb_City);
            grpBoxProfileInfo.Controls.Add(tb_Email);
            grpBoxProfileInfo.Controls.Add(tb_Address);
            grpBoxProfileInfo.Controls.Add(tb_Phonenumber);
            grpBoxProfileInfo.Controls.Add(label5);
            grpBoxProfileInfo.Controls.Add(label4);
            grpBoxProfileInfo.Controls.Add(label6);
            grpBoxProfileInfo.Dock = DockStyle.Top;
            grpBoxProfileInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxProfileInfo.Location = new Point(0, 0);
            grpBoxProfileInfo.Name = "grpBoxProfileInfo";
            grpBoxProfileInfo.Size = new Size(699, 157);
            grpBoxProfileInfo.TabIndex = 21;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "User Name";
            grpBoxProfileInfo.Enter += grpBoxProfileInfo_Enter;
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(484, 126);
            bt_EditProfileCancel.Margin = new Padding(2);
            bt_EditProfileCancel.Name = "bt_EditProfileCancel";
            bt_EditProfileCancel.Size = new Size(100, 25);
            bt_EditProfileCancel.TabIndex = 9;
            bt_EditProfileCancel.Text = "Cancel";
            bt_EditProfileCancel.UseVisualStyleBackColor = true;
            bt_EditProfileCancel.Visible = false;
            bt_EditProfileCancel.Click += bt_EditProfileCancel_Click;
            // 
            // lblUserCreationDate
            // 
            lblUserCreationDate.AutoSize = true;
            lblUserCreationDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblUserCreationDate.Location = new Point(219, 129);
            lblUserCreationDate.Name = "lblUserCreationDate";
            lblUserCreationDate.Size = new Size(186, 17);
            lblUserCreationDate.TabIndex = 100;
            lblUserCreationDate.Text = "You've been a user for 154 days";
            lblUserCreationDate.Click += lblUserCreationDate_Click;
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(588, 126);
            bt_EditProfile.Margin = new Padding(2);
            bt_EditProfile.Name = "bt_EditProfile";
            bt_EditProfile.Size = new Size(100, 25);
            bt_EditProfile.TabIndex = 9;
            bt_EditProfile.Text = "Edit Profile";
            bt_EditProfile.UseVisualStyleBackColor = true;
            bt_EditProfile.Click += bt_EditProfile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_manageProject);
            groupBox2.Controls.Add(bt_EditProject);
            groupBox2.Controls.Add(dgv_Viewproject);
            groupBox2.Controls.Add(bt_NewProject);
            groupBox2.Controls.Add(bt_FindConsultants);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 382);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Projects";
            // 
            // bt_manageProject
            // 
            bt_manageProject.Location = new Point(6, 30);
            bt_manageProject.Name = "bt_manageProject";
            bt_manageProject.Size = new Size(143, 23);
            bt_manageProject.TabIndex = 14;
            bt_manageProject.Text = "Manage Project";
            bt_manageProject.UseVisualStyleBackColor = true;
            bt_manageProject.Click += bt_manageProject_Click;
            // 
            // bt_EditProject
            // 
            bt_EditProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_EditProject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProject.Location = new Point(588, 342);
            bt_EditProject.Margin = new Padding(2);
            bt_EditProject.Name = "bt_EditProject";
            bt_EditProject.Size = new Size(100, 25);
            bt_EditProject.TabIndex = 13;
            bt_EditProject.Text = "Edit Project";
            bt_EditProject.UseVisualStyleBackColor = true;
            bt_EditProject.Click += bt_EditProject_Click;
            // 
            // dgv_Viewproject
            // 
            dgv_Viewproject.AllowUserToAddRows = false;
            dgv_Viewproject.AllowUserToDeleteRows = false;
            dgv_Viewproject.AllowUserToResizeRows = false;
            dgv_Viewproject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Viewproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_Viewproject.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_Viewproject.Location = new Point(3, 58);
            dgv_Viewproject.Margin = new Padding(2);
            dgv_Viewproject.MultiSelect = false;
            dgv_Viewproject.Name = "dgv_Viewproject";
            dgv_Viewproject.ReadOnly = true;
            dgv_Viewproject.RowHeadersVisible = false;
            dgv_Viewproject.RowHeadersWidth = 62;
            dgv_Viewproject.RowTemplate.Height = 33;
            dgv_Viewproject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Viewproject.Size = new Size(693, 279);
            dgv_Viewproject.TabIndex = 10;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 539);
            Controls.Add(groupBox2);
            Controls.Add(grpBoxProfileInfo);
            Name = "Manager";
            Text = "Manager";
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_Firstname;
        private TextBox tb_Email;
        private TextBox tb_Phonenumber;
        private TextBox tb_Lastname;
        private TextBox tb_Address;
        private TextBox tb_City;
        private TextBox tb_Zipcode;
        private TextBox tb_Country;
        private Button bt_FindConsultants;
        private Button bt_NewProject;
        private GroupBox grpBoxProfileInfo;
        private Button bt_EditProfile;
        private GroupBox groupBox2;
        private Label lblUserCreationDate;
        private DataGridView dgv_Viewproject;
        private Button bt_EditProject;
        private Button bt_EditProfileCancel;
        private Button bt_manageProject;
    }
}