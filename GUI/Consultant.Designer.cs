namespace GUI
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
            bt_SearchProjects = new Button();
            dgv_ConsultantsInvites = new DataGridView();
            groupBox1 = new GroupBox();
            bt_seeProjects = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpBoxProfileInfo = new GroupBox();
            bt_Edit = new Button();
            bt_EditCancel = new Button();
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
            bt_seeInvites = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).BeginInit();
            groupBox1.SuspendLayout();
            grpBoxProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // bt_SearchProjects
            // 
            bt_SearchProjects.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_SearchProjects.Location = new Point(528, 160);
            bt_SearchProjects.Margin = new Padding(2);
            bt_SearchProjects.Name = "bt_SearchProjects";
            bt_SearchProjects.Size = new Size(100, 26);
            bt_SearchProjects.TabIndex = 36;
            bt_SearchProjects.Text = "SearchProjects";
            bt_SearchProjects.UseVisualStyleBackColor = true;
            bt_SearchProjects.Click += bt_SearchProjects_Click;
            // 
            // dgv_ConsultantsInvites
            // 
            dgv_ConsultantsInvites.AllowUserToAddRows = false;
            dgv_ConsultantsInvites.AllowUserToDeleteRows = false;
            dgv_ConsultantsInvites.AllowUserToResizeRows = false;
            dgv_ConsultantsInvites.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ConsultantsInvites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantsInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantsInvites.Location = new Point(3, 19);
            dgv_ConsultantsInvites.Name = "dgv_ConsultantsInvites";
            dgv_ConsultantsInvites.RowHeadersVisible = false;
            dgv_ConsultantsInvites.RowTemplate.Height = 25;
            dgv_ConsultantsInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantsInvites.Size = new Size(609, 302);
            dgv_ConsultantsInvites.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(bt_seeProjects);
            groupBox1.Controls.Add(dgv_ConsultantsInvites);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 356);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "My Projects";
            // 
            // bt_seeProjects
            // 
            bt_seeProjects.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_seeProjects.Location = new Point(412, 327);
            bt_seeProjects.Name = "bt_seeProjects";
            bt_seeProjects.Size = new Size(200, 23);
            bt_seeProjects.TabIndex = 43;
            bt_seeProjects.Text = "Go To Project";
            bt_seeProjects.UseVisualStyleBackColor = true;
            bt_seeProjects.Click += bt_seeProjects_Click;
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(bt_Edit);
            grpBoxProfileInfo.Controls.Add(bt_EditCancel);
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
            grpBoxProfileInfo.Size = new Size(639, 157);
            grpBoxProfileInfo.TabIndex = 41;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "User Name";
            // 
            // bt_Edit
            // 
            bt_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_Edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Edit.Location = new Point(528, 126);
            bt_Edit.Margin = new Padding(2);
            bt_Edit.Name = "bt_Edit";
            bt_Edit.Size = new Size(100, 25);
            bt_Edit.TabIndex = 102;
            bt_Edit.Text = "Edit Profile";
            bt_Edit.UseVisualStyleBackColor = true;
            bt_Edit.Click += bt_Edit_Click;
            // 
            // bt_EditCancel
            // 
            bt_EditCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditCancel.Enabled = false;
            bt_EditCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditCancel.Location = new Point(424, 126);
            bt_EditCancel.Margin = new Padding(2);
            bt_EditCancel.Name = "bt_EditCancel";
            bt_EditCancel.Size = new Size(100, 25);
            bt_EditCancel.TabIndex = 101;
            bt_EditCancel.Text = "Cancel";
            bt_EditCancel.UseVisualStyleBackColor = true;
            bt_EditCancel.Visible = false;
            bt_EditCancel.Click += bt_EditCancel_Click;
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
            bt_EditProfileTest.Location = new Point(1027, 126);
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
            tb_Country.Size = new Size(274, 16);
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
            tb_Zipcode.Size = new Size(274, 16);
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
            tb_City.Size = new Size(274, 16);
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
            tb_Address.Size = new Size(274, 16);
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
            // bt_seeInvites
            // 
            bt_seeInvites.Location = new Point(15, 163);
            bt_seeInvites.Name = "bt_seeInvites";
            bt_seeInvites.Size = new Size(125, 23);
            bt_seeInvites.TabIndex = 42;
            bt_seeInvites.Text = "See Invites";
            bt_seeInvites.UseVisualStyleBackColor = true;
            bt_seeInvites.Click += bt_seeInvites_Click;
            // 
            // Consultant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 561);
            Controls.Add(bt_seeInvites);
            Controls.Add(grpBoxProfileInfo);
            Controls.Add(bt_SearchProjects);
            Controls.Add(groupBox1);
            MinimumSize = new Size(655, 600);
            Name = "Consultant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultant";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).EndInit();
            groupBox1.ResumeLayout(false);
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bt_SearchProjects;
        private DataGridView dgv_ConsultantsInvites;
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
        private Button bt_EditCancel;
        private Button bt_Edit;
        private Button bt_seeInvites;
        private Button bt_seeProjects;
    }
}