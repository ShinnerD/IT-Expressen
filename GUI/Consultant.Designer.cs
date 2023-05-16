﻿namespace GUI
{
    partial class Consultant
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
            bt_ViewProjects = new Button();
            bt_SearchProjects = new Button();
            dgv_ConsultantsInvites = new DataGridView();
            bt_seeInviteDetails = new Button();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpBoxProfileInfo = new GroupBox();
            bt_EditTest = new Button();
            bt_EditCancelTest = new Button();
            lblUserCreationDate = new Label();
            bt_EditProfileTest = new Button();
            label2 = new Label();
            tb_Firstname = new TextBox();
            label7 = new Label();
            tb_Country = new TextBox();
            tb_Lastname = new TextBox();
            label9 = new Label();
            tb_Zipcode = new TextBox();
            label8 = new Label();
            label3 = new Label();
            tb_City = new TextBox();
            tb_Email = new TextBox();
            tb_Address = new TextBox();
            tb_Phonenumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).BeginInit();
            groupBox1.SuspendLayout();
            grpBoxProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ViewProjects
            // 
            bt_ViewProjects.Location = new Point(23, 193);
            bt_ViewProjects.Margin = new Padding(2);
            bt_ViewProjects.Name = "bt_ViewProjects";
            bt_ViewProjects.Size = new Size(94, 29);
            bt_ViewProjects.TabIndex = 35;
            bt_ViewProjects.Text = "ViewProjects";
            bt_ViewProjects.UseVisualStyleBackColor = true;
            bt_ViewProjects.Click += bt_ViewProjects_Click;
            // 
            // bt_SearchProjects
            // 
            bt_SearchProjects.Location = new Point(503, 193);
            bt_SearchProjects.Margin = new Padding(2);
            bt_SearchProjects.Name = "bt_SearchProjects";
            bt_SearchProjects.Size = new Size(94, 29);
            bt_SearchProjects.TabIndex = 36;
            bt_SearchProjects.Text = "SearchProjects";
            bt_SearchProjects.UseVisualStyleBackColor = true;
            bt_SearchProjects.Click += bt_SearchProjects_Click;
            // 
            // dgv_ConsultantsInvites
            // 
            dgv_ConsultantsInvites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantsInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantsInvites.Dock = DockStyle.Top;
            dgv_ConsultantsInvites.Location = new Point(3, 19);
            dgv_ConsultantsInvites.Name = "dgv_ConsultantsInvites";
            dgv_ConsultantsInvites.RowTemplate.Height = 25;
            dgv_ConsultantsInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantsInvites.Size = new Size(595, 297);
            dgv_ConsultantsInvites.TabIndex = 37;
            // 
            // bt_seeInviteDetails
            // 
            bt_seeInviteDetails.Dock = DockStyle.Left;
            bt_seeInviteDetails.Location = new Point(3, 316);
            bt_seeInviteDetails.Name = "bt_seeInviteDetails";
            bt_seeInviteDetails.Size = new Size(101, 27);
            bt_seeInviteDetails.TabIndex = 39;
            bt_seeInviteDetails.Text = "See Details";
            bt_seeInviteDetails.UseVisualStyleBackColor = true;
            bt_seeInviteDetails.Click += bt_seeInviteDetails_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_seeInviteDetails);
            groupBox1.Controls.Add(dgv_ConsultantsInvites);
            groupBox1.Location = new Point(12, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 346);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Invites";
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(bt_EditTest);
            grpBoxProfileInfo.Controls.Add(bt_EditCancelTest);
            grpBoxProfileInfo.Controls.Add(lblUserCreationDate);
            grpBoxProfileInfo.Controls.Add(bt_EditProfileTest);
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
            grpBoxProfileInfo.Size = new Size(625, 157);
            grpBoxProfileInfo.TabIndex = 41;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "User Name";
            // 
            // bt_EditTest
            // 
            bt_EditTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditTest.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditTest.Location = new Point(514, 126);
            bt_EditTest.Margin = new Padding(2);
            bt_EditTest.Name = "bt_EditTest";
            bt_EditTest.Size = new Size(100, 25);
            bt_EditTest.TabIndex = 102;
            bt_EditTest.Text = "Edit Profile";
            bt_EditTest.UseVisualStyleBackColor = true;
            bt_EditTest.Click += bt_EditTest_Click;
            // 
            // bt_EditCancelTest
            // 
            bt_EditCancelTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditCancelTest.Enabled = false;
            bt_EditCancelTest.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditCancelTest.Location = new Point(410, 126);
            bt_EditCancelTest.Margin = new Padding(2);
            bt_EditCancelTest.Name = "bt_EditCancelTest";
            bt_EditCancelTest.Size = new Size(100, 25);
            bt_EditCancelTest.TabIndex = 101;
            bt_EditCancelTest.Text = "Cancel";
            bt_EditCancelTest.UseVisualStyleBackColor = true;
            bt_EditCancelTest.Visible = false;
            bt_EditCancelTest.Click += bt_EditCancelTest_Click;
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
            // 
            // bt_EditProfileTest
            // 
            bt_EditProfileTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileTest.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileTest.Location = new Point(1013, 126);
            bt_EditProfileTest.Margin = new Padding(2);
            bt_EditProfileTest.Name = "bt_EditProfileTest";
            bt_EditProfileTest.Size = new Size(100, 25);
            bt_EditProfileTest.TabIndex = 9;
            bt_EditProfileTest.Text = "Edit Profile";
            bt_EditProfileTest.UseVisualStyleBackColor = true;
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
            tb_Country.Size = new Size(753, 16);
            tb_Country.TabIndex = 8;
            tb_Country.TabStop = false;
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
            tb_Zipcode.Size = new Size(753, 16);
            tb_Zipcode.TabIndex = 7;
            tb_Zipcode.TabStop = false;
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
            tb_City.Size = new Size(753, 16);
            tb_City.TabIndex = 6;
            tb_City.TabStop = false;
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
            tb_Address.Size = new Size(753, 16);
            tb_Address.TabIndex = 5;
            tb_Address.TabStop = false;
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
            // 
            // Consultant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 654);
            Controls.Add(grpBoxProfileInfo);
            Controls.Add(bt_SearchProjects);
            Controls.Add(bt_ViewProjects);
            Controls.Add(groupBox1);
            Name = "Consultant";
            Text = "Consultant";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).EndInit();
            groupBox1.ResumeLayout(false);
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bt_ViewProjects;
        private Button bt_SearchProjects;
        private DataGridView dgv_ConsultantsInvites;
        private Button bt_seeInviteDetails;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpBoxProfileInfo;
        private Button bt_EditCanceltest;
        private Label lblUserCreationDate;
        private Button bt_EditProfileTest;
        private Label label2;
        private TextBox tb_Firstname;
        private Label label7;
        private TextBox tb_Country;
        private TextBox tb_Lastname;
        private Label label9;
        private TextBox tb_Zipcode;
        private Label label8;
        private Label label3;
        private TextBox tb_City;
        private TextBox tb_Email;
        private TextBox tb_Address;
        private TextBox tb_Phonenumber;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button bt_EditCancelTest;
        private Button bt_EditTest;
    }
}