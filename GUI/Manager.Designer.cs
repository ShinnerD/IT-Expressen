namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Phonenumber = new System.Windows.Forms.TextBox();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Zipcode = new System.Windows.Forms.TextBox();
            this.tb_Country = new System.Windows.Forms.TextBox();
            this.bt_FindConsultants = new System.Windows.Forms.Button();
            this.grpBoxProfileInfo = new System.Windows.Forms.GroupBox();
            this.bt_EditProfileCancel = new System.Windows.Forms.Button();
            this.lblUserCreationDate = new System.Windows.Forms.Label();
            this.bt_EditProfile = new System.Windows.Forms.Button();
            this.ViewProjectsGrpBox = new System.Windows.Forms.GroupBox();
            this.bt_AddConsultant = new System.Windows.Forms.Button();
            this.lbl_ViewProjectsFeedBack = new System.Windows.Forms.Label();
            this.btn_NewProject = new System.Windows.Forms.Button();
            this.bt_manageProject = new System.Windows.Forms.Button();
            this.bt_EditProject = new System.Windows.Forms.Button();
            this.dgv_Viewproject = new System.Windows.Forms.DataGridView();
            this.NewProjectGrpBox = new System.Windows.Forms.GroupBox();
            this.lbl_FeedBackNewProject = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_ReqSkills = new System.Windows.Forms.Label();
            this.txtBox_ProjectTitle = new System.Windows.Forms.TextBox();
            this.txtBox_ProjectDescription = new System.Windows.Forms.TextBox();
            this.checkedListSkills = new System.Windows.Forms.CheckedListBox();
            this.dtp_NewProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_NewProjectStartDate = new System.Windows.Forms.DateTimePicker();
            this.btn_NewProjectSave = new System.Windows.Forms.Button();
            this.btn_NewProjectBack = new System.Windows.Forms.Button();
            this.grpBoxProfileInfo.SuspendLayout();
            this.ViewProjectsGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viewproject)).BeginInit();
            this.NewProjectGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(326, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(305, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lastname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(305, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zipcode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(304, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Country:";
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Firstname.Enabled = false;
            this.tb_Firstname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Firstname.Location = new System.Drawing.Point(71, 22);
            this.tb_Firstname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(225, 16);
            this.tb_Firstname.TabIndex = 1;
            this.tb_Firstname.TabStop = false;
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Email.Enabled = false;
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.Location = new System.Drawing.Point(71, 74);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(225, 16);
            this.tb_Email.TabIndex = 3;
            this.tb_Email.TabStop = false;
            // 
            // tb_Phonenumber
            // 
            this.tb_Phonenumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phonenumber.Enabled = false;
            this.tb_Phonenumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Phonenumber.Location = new System.Drawing.Point(71, 101);
            this.tb_Phonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Phonenumber.Name = "tb_Phonenumber";
            this.tb_Phonenumber.Size = new System.Drawing.Size(225, 16);
            this.tb_Phonenumber.TabIndex = 4;
            this.tb_Phonenumber.TabStop = false;
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Lastname.Enabled = false;
            this.tb_Lastname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Lastname.Location = new System.Drawing.Point(71, 48);
            this.tb_Lastname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(225, 16);
            this.tb_Lastname.TabIndex = 2;
            this.tb_Lastname.TabStop = false;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Address.Location = new System.Drawing.Point(360, 22);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(328, 16);
            this.tb_Address.TabIndex = 5;
            this.tb_Address.TabStop = false;
            // 
            // tb_City
            // 
            this.tb_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_City.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_City.Enabled = false;
            this.tb_City.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_City.Location = new System.Drawing.Point(360, 49);
            this.tb_City.Margin = new System.Windows.Forms.Padding(2);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(328, 16);
            this.tb_City.TabIndex = 6;
            this.tb_City.TabStop = false;
            // 
            // tb_Zipcode
            // 
            this.tb_Zipcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Zipcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Zipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Zipcode.Enabled = false;
            this.tb_Zipcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Zipcode.Location = new System.Drawing.Point(360, 74);
            this.tb_Zipcode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Zipcode.Name = "tb_Zipcode";
            this.tb_Zipcode.Size = new System.Drawing.Size(328, 16);
            this.tb_Zipcode.TabIndex = 7;
            this.tb_Zipcode.TabStop = false;
            // 
            // tb_Country
            // 
            this.tb_Country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Country.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Country.Enabled = false;
            this.tb_Country.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Country.Location = new System.Drawing.Point(360, 101);
            this.tb_Country.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Country.Name = "tb_Country";
            this.tb_Country.Size = new System.Drawing.Size(328, 16);
            this.tb_Country.TabIndex = 8;
            this.tb_Country.TabStop = false;
            // 
            // bt_FindConsultants
            // 
            this.bt_FindConsultants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_FindConsultants.Location = new System.Drawing.Point(215, 29);
            this.bt_FindConsultants.Margin = new System.Windows.Forms.Padding(2);
            this.bt_FindConsultants.Name = "bt_FindConsultants";
            this.bt_FindConsultants.Size = new System.Drawing.Size(105, 25);
            this.bt_FindConsultants.TabIndex = 11;
            this.bt_FindConsultants.Text = "View Invites";
            this.bt_FindConsultants.UseVisualStyleBackColor = true;
            // 
            // grpBoxProfileInfo
            // 
            this.grpBoxProfileInfo.Controls.Add(this.bt_EditProfileCancel);
            this.grpBoxProfileInfo.Controls.Add(this.lblUserCreationDate);
            this.grpBoxProfileInfo.Controls.Add(this.bt_EditProfile);
            this.grpBoxProfileInfo.Controls.Add(this.label2);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Firstname);
            this.grpBoxProfileInfo.Controls.Add(this.label7);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Country);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Lastname);
            this.grpBoxProfileInfo.Controls.Add(this.label9);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Zipcode);
            this.grpBoxProfileInfo.Controls.Add(this.label8);
            this.grpBoxProfileInfo.Controls.Add(this.label3);
            this.grpBoxProfileInfo.Controls.Add(this.tb_City);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Email);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Address);
            this.grpBoxProfileInfo.Controls.Add(this.tb_Phonenumber);
            this.grpBoxProfileInfo.Controls.Add(this.label5);
            this.grpBoxProfileInfo.Controls.Add(this.label4);
            this.grpBoxProfileInfo.Controls.Add(this.label6);
            this.grpBoxProfileInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxProfileInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoxProfileInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBoxProfileInfo.Name = "grpBoxProfileInfo";
            this.grpBoxProfileInfo.Size = new System.Drawing.Size(699, 157);
            this.grpBoxProfileInfo.TabIndex = 21;
            this.grpBoxProfileInfo.TabStop = false;
            this.grpBoxProfileInfo.Text = "User Name";
            // 
            // bt_EditProfileCancel
            // 
            this.bt_EditProfileCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_EditProfileCancel.Enabled = false;
            this.bt_EditProfileCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_EditProfileCancel.Location = new System.Drawing.Point(484, 126);
            this.bt_EditProfileCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditProfileCancel.Name = "bt_EditProfileCancel";
            this.bt_EditProfileCancel.Size = new System.Drawing.Size(100, 25);
            this.bt_EditProfileCancel.TabIndex = 9;
            this.bt_EditProfileCancel.Text = "Cancel";
            this.bt_EditProfileCancel.UseVisualStyleBackColor = true;
            this.bt_EditProfileCancel.Visible = false;
            // 
            // lblUserCreationDate
            // 
            this.lblUserCreationDate.AutoSize = true;
            this.lblUserCreationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUserCreationDate.Location = new System.Drawing.Point(219, 129);
            this.lblUserCreationDate.Name = "lblUserCreationDate";
            this.lblUserCreationDate.Size = new System.Drawing.Size(186, 17);
            this.lblUserCreationDate.TabIndex = 100;
            this.lblUserCreationDate.Text = "You\'ve been a user for 154 days";
            // 
            // bt_EditProfile
            // 
            this.bt_EditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_EditProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_EditProfile.Location = new System.Drawing.Point(588, 126);
            this.bt_EditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditProfile.Name = "bt_EditProfile";
            this.bt_EditProfile.Size = new System.Drawing.Size(100, 25);
            this.bt_EditProfile.TabIndex = 9;
            this.bt_EditProfile.Text = "Edit Profile";
            this.bt_EditProfile.UseVisualStyleBackColor = true;
            // 
            // ViewProjectsGrpBox
            // 
            this.ViewProjectsGrpBox.Controls.Add(this.bt_AddConsultant);
            this.ViewProjectsGrpBox.Controls.Add(this.lbl_ViewProjectsFeedBack);
            this.ViewProjectsGrpBox.Controls.Add(this.btn_NewProject);
            this.ViewProjectsGrpBox.Controls.Add(this.bt_manageProject);
            this.ViewProjectsGrpBox.Controls.Add(this.bt_EditProject);
            this.ViewProjectsGrpBox.Controls.Add(this.dgv_Viewproject);
            this.ViewProjectsGrpBox.Controls.Add(this.bt_FindConsultants);
            this.ViewProjectsGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewProjectsGrpBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewProjectsGrpBox.Location = new System.Drawing.Point(0, 157);
            this.ViewProjectsGrpBox.Name = "ViewProjectsGrpBox";
            this.ViewProjectsGrpBox.Size = new System.Drawing.Size(699, 382);
            this.ViewProjectsGrpBox.TabIndex = 22;
            this.ViewProjectsGrpBox.TabStop = false;
            this.ViewProjectsGrpBox.Text = "Projects";
            // 
            // bt_AddConsultant
            // 
            this.bt_AddConsultant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_AddConsultant.Location = new System.Drawing.Point(325, 29);
            this.bt_AddConsultant.Name = "bt_AddConsultant";
            this.bt_AddConsultant.Size = new System.Drawing.Size(105, 25);
            this.bt_AddConsultant.TabIndex = 19;
            this.bt_AddConsultant.Text = "Find Consultants";
            this.bt_AddConsultant.UseVisualStyleBackColor = true;
            this.bt_AddConsultant.Click += new System.EventHandler(this.bt_AddConsultant_Click_1);
            // 
            // lbl_ViewProjectsFeedBack
            // 
            this.lbl_ViewProjectsFeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ViewProjectsFeedBack.AutoSize = true;
            this.lbl_ViewProjectsFeedBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ViewProjectsFeedBack.Location = new System.Drawing.Point(12, 358);
            this.lbl_ViewProjectsFeedBack.Name = "lbl_ViewProjectsFeedBack";
            this.lbl_ViewProjectsFeedBack.Size = new System.Drawing.Size(166, 15);
            this.lbl_ViewProjectsFeedBack.TabIndex = 16;
            this.lbl_ViewProjectsFeedBack.Text = "Feedback label for messages...";
            this.lbl_ViewProjectsFeedBack.Visible = false;
            // 
            // btn_NewProject
            // 
            this.btn_NewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NewProject.Location = new System.Drawing.Point(587, 30);
            this.btn_NewProject.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewProject.Name = "btn_NewProject";
            this.btn_NewProject.Size = new System.Drawing.Size(100, 25);
            this.btn_NewProject.TabIndex = 15;
            this.btn_NewProject.Text = "New Project";
            this.btn_NewProject.UseVisualStyleBackColor = true;
            // 
            // bt_manageProject
            // 
            this.bt_manageProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_manageProject.Location = new System.Drawing.Point(6, 29);
            this.bt_manageProject.Name = "bt_manageProject";
            this.bt_manageProject.Size = new System.Drawing.Size(100, 25);
            this.bt_manageProject.TabIndex = 14;
            this.bt_manageProject.Text = "Manage Project";
            this.bt_manageProject.UseVisualStyleBackColor = true;
            // 
            // bt_EditProject
            // 
            this.bt_EditProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_EditProject.Location = new System.Drawing.Point(111, 29);
            this.bt_EditProject.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditProject.Name = "bt_EditProject";
            this.bt_EditProject.Size = new System.Drawing.Size(100, 25);
            this.bt_EditProject.TabIndex = 13;
            this.bt_EditProject.Text = "Edit Project";
            this.bt_EditProject.UseVisualStyleBackColor = true;
            // 
            // dgv_Viewproject
            // 
            this.dgv_Viewproject.AllowUserToAddRows = false;
            this.dgv_Viewproject.AllowUserToDeleteRows = false;
            this.dgv_Viewproject.AllowUserToResizeRows = false;
            this.dgv_Viewproject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Viewproject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Viewproject.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Viewproject.Location = new System.Drawing.Point(3, 58);
            this.dgv_Viewproject.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Viewproject.MultiSelect = false;
            this.dgv_Viewproject.Name = "dgv_Viewproject";
            this.dgv_Viewproject.ReadOnly = true;
            this.dgv_Viewproject.RowHeadersVisible = false;
            this.dgv_Viewproject.RowHeadersWidth = 62;
            this.dgv_Viewproject.RowTemplate.Height = 33;
            this.dgv_Viewproject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Viewproject.Size = new System.Drawing.Size(693, 279);
            this.dgv_Viewproject.TabIndex = 10;
            // 
            // NewProjectGrpBox
            // 
            this.NewProjectGrpBox.Controls.Add(this.lbl_FeedBackNewProject);
            this.NewProjectGrpBox.Controls.Add(this.lbl_StartDate);
            this.NewProjectGrpBox.Controls.Add(this.lbl_EndDate);
            this.NewProjectGrpBox.Controls.Add(this.lbl_ReqSkills);
            this.NewProjectGrpBox.Controls.Add(this.txtBox_ProjectTitle);
            this.NewProjectGrpBox.Controls.Add(this.txtBox_ProjectDescription);
            this.NewProjectGrpBox.Controls.Add(this.checkedListSkills);
            this.NewProjectGrpBox.Controls.Add(this.dtp_NewProjectEndDate);
            this.NewProjectGrpBox.Controls.Add(this.dtp_NewProjectStartDate);
            this.NewProjectGrpBox.Controls.Add(this.btn_NewProjectSave);
            this.NewProjectGrpBox.Controls.Add(this.btn_NewProjectBack);
            this.NewProjectGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewProjectGrpBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewProjectGrpBox.Location = new System.Drawing.Point(0, 157);
            this.NewProjectGrpBox.Name = "NewProjectGrpBox";
            this.NewProjectGrpBox.Size = new System.Drawing.Size(699, 382);
            this.NewProjectGrpBox.TabIndex = 23;
            this.NewProjectGrpBox.TabStop = false;
            this.NewProjectGrpBox.Text = "New Project";
            this.NewProjectGrpBox.Visible = false;
            // 
            // lbl_FeedBackNewProject
            // 
            this.lbl_FeedBackNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FeedBackNewProject.AutoSize = true;
            this.lbl_FeedBackNewProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FeedBackNewProject.Location = new System.Drawing.Point(23, 352);
            this.lbl_FeedBackNewProject.Name = "lbl_FeedBackNewProject";
            this.lbl_FeedBackNewProject.Size = new System.Drawing.Size(163, 15);
            this.lbl_FeedBackNewProject.TabIndex = 16;
            this.lbl_FeedBackNewProject.Text = "Feedback messages go here...";
            this.lbl_FeedBackNewProject.Visible = false;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_StartDate.Location = new System.Drawing.Point(429, 39);
            this.lbl_StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(68, 17);
            this.lbl_StartDate.TabIndex = 20;
            this.lbl_StartDate.Text = "Start date";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EndDate.Location = new System.Drawing.Point(429, 89);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(62, 17);
            this.lbl_EndDate.TabIndex = 22;
            this.lbl_EndDate.Text = "End date";
            // 
            // lbl_ReqSkills
            // 
            this.lbl_ReqSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ReqSkills.AutoSize = true;
            this.lbl_ReqSkills.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ReqSkills.Location = new System.Drawing.Point(429, 154);
            this.lbl_ReqSkills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReqSkills.Name = "lbl_ReqSkills";
            this.lbl_ReqSkills.Size = new System.Drawing.Size(95, 17);
            this.lbl_ReqSkills.TabIndex = 25;
            this.lbl_ReqSkills.Text = "Required Skills";
            // 
            // txtBox_ProjectTitle
            // 
            this.txtBox_ProjectTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_ProjectTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_ProjectTitle.Location = new System.Drawing.Point(23, 84);
            this.txtBox_ProjectTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_ProjectTitle.MaxLength = 255;
            this.txtBox_ProjectTitle.Name = "txtBox_ProjectTitle";
            this.txtBox_ProjectTitle.PlaceholderText = "Title";
            this.txtBox_ProjectTitle.Size = new System.Drawing.Size(360, 22);
            this.txtBox_ProjectTitle.TabIndex = 17;
            this.txtBox_ProjectTitle.TabStop = false;
            // 
            // txtBox_ProjectDescription
            // 
            this.txtBox_ProjectDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_ProjectDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_ProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ProjectDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_ProjectDescription.Location = new System.Drawing.Point(23, 132);
            this.txtBox_ProjectDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_ProjectDescription.Multiline = true;
            this.txtBox_ProjectDescription.Name = "txtBox_ProjectDescription";
            this.txtBox_ProjectDescription.PlaceholderText = "Descrition";
            this.txtBox_ProjectDescription.Size = new System.Drawing.Size(360, 187);
            this.txtBox_ProjectDescription.TabIndex = 19;
            this.txtBox_ProjectDescription.TabStop = false;
            // 
            // checkedListSkills
            // 
            this.checkedListSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListSkills.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListSkills.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListSkills.FormattingEnabled = true;
            this.checkedListSkills.Location = new System.Drawing.Point(429, 174);
            this.checkedListSkills.MultiColumn = true;
            this.checkedListSkills.Name = "checkedListSkills";
            this.checkedListSkills.Size = new System.Drawing.Size(258, 126);
            this.checkedListSkills.TabIndex = 24;
            // 
            // dtp_NewProjectEndDate
            // 
            this.dtp_NewProjectEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NewProjectEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_NewProjectEndDate.Location = new System.Drawing.Point(429, 109);
            this.dtp_NewProjectEndDate.Name = "dtp_NewProjectEndDate";
            this.dtp_NewProjectEndDate.Size = new System.Drawing.Size(170, 25);
            this.dtp_NewProjectEndDate.TabIndex = 23;
            // 
            // dtp_NewProjectStartDate
            // 
            this.dtp_NewProjectStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NewProjectStartDate.CustomFormat = "dd/MM/yy";
            this.dtp_NewProjectStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_NewProjectStartDate.Location = new System.Drawing.Point(429, 58);
            this.dtp_NewProjectStartDate.Name = "dtp_NewProjectStartDate";
            this.dtp_NewProjectStartDate.Size = new System.Drawing.Size(170, 25);
            this.dtp_NewProjectStartDate.TabIndex = 21;
            // 
            // btn_NewProjectSave
            // 
            this.btn_NewProjectSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NewProjectSave.Location = new System.Drawing.Point(129, 30);
            this.btn_NewProjectSave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewProjectSave.Name = "btn_NewProjectSave";
            this.btn_NewProjectSave.Size = new System.Drawing.Size(100, 25);
            this.btn_NewProjectSave.TabIndex = 15;
            this.btn_NewProjectSave.Text = "Save Project";
            this.btn_NewProjectSave.UseVisualStyleBackColor = true;
            // 
            // btn_NewProjectBack
            // 
            this.btn_NewProjectBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NewProjectBack.Location = new System.Drawing.Point(6, 30);
            this.btn_NewProjectBack.Name = "btn_NewProjectBack";
            this.btn_NewProjectBack.Size = new System.Drawing.Size(100, 25);
            this.btn_NewProjectBack.TabIndex = 14;
            this.btn_NewProjectBack.Text = "Back";
            this.btn_NewProjectBack.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 539);
            this.Controls.Add(this.ViewProjectsGrpBox);
            this.Controls.Add(this.NewProjectGrpBox);
            this.Controls.Add(this.grpBoxProfileInfo);
            this.MinimumSize = new System.Drawing.Size(715, 578);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.grpBoxProfileInfo.ResumeLayout(false);
            this.grpBoxProfileInfo.PerformLayout();
            this.ViewProjectsGrpBox.ResumeLayout(false);
            this.ViewProjectsGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viewproject)).EndInit();
            this.NewProjectGrpBox.ResumeLayout(false);
            this.NewProjectGrpBox.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox grpBoxProfileInfo;
        private Button bt_EditProfile;
        private GroupBox ViewProjectsGrpBox;
        private Label lblUserCreationDate;
        private DataGridView dgv_Viewproject;
        private Button bt_EditProject;
        private Button bt_EditProfileCancel;
        private Button bt_manageProject;
        private Button btn_NewProject;
        private GroupBox NewProjectGrpBox;
        private Button btn_NewProjectSave;
        private Button btn_NewProjectBack;
        private Label lbl_FeedBackNewProject;
        private TextBox txtBox_ProjectTitle;
        private Label lbl_StartDate;
        private TextBox txtBox_ProjectDescription;
        private DateTimePicker dtp_NewProjectStartDate;
        private DateTimePicker dtp_NewProjectEndDate;
        private Label lbl_EndDate;
        private CheckedListBox checkedListSkills;
        private Label lbl_ReqSkills;
        private Label lbl_ViewProjectsFeedBack;
        private Button bt_AddConsultant;
    }
}