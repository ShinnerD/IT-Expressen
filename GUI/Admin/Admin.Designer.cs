namespace GUI.Admin
{
    partial class AdminMain
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grpBoxProfileInfo = new GroupBox();
            bt_EditProfileCancel = new Button();
            lblUserCreationDate = new Label();
            label2 = new Label();
            bt_EditProfile = new Button();
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
            tabControl = new TabControl();
            tabPage_Users = new TabPage();
            lbl_FeedbackUserTab = new Label();
            btn_NewUser = new Button();
            btn_DeleteUser = new Button();
            btn_EditUser = new Button();
            dgv_UserSearchResults = new DataGridView();
            grpBoxUserSearchFilter = new GroupBox();
            radio_Consultants = new RadioButton();
            radio_Managers = new RadioButton();
            radio_AllUsers = new RadioButton();
            btn_SearchUsers = new Button();
            txtBox_UserSearchParams = new TextBox();
            tabPage_Projects = new TabPage();
            btn_ViewInvites = new Button();
            btn_DetailsEdit = new Button();
            lbl_FeedbackProjectTab = new Label();
            btn_InvoiceDetails = new Button();
            btn_EditProject = new Button();
            btn_DeleteProject = new Button();
            dgv_ProjectSearchResults = new DataGridView();
            groupBox1 = new GroupBox();
            radio_Ended = new RadioButton();
            radio_InProgress = new RadioButton();
            radio_AllProjects = new RadioButton();
            radio_Pending = new RadioButton();
            btn_SearchProjects = new Button();
            txtBox_ProjectSearchParams = new TextBox();
            grpBoxProfileInfo.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_UserSearchResults).BeginInit();
            grpBoxUserSearchFilter.SuspendLayout();
            tabPage_Projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectSearchResults).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(bt_EditProfileCancel);
            grpBoxProfileInfo.Controls.Add(lblUserCreationDate);
            grpBoxProfileInfo.Controls.Add(label2);
            grpBoxProfileInfo.Controls.Add(bt_EditProfile);
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
            grpBoxProfileInfo.Size = new Size(948, 163);
            grpBoxProfileInfo.TabIndex = 22;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "Admin UserName";
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(736, 126);
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
            lblUserCreationDate.Size = new Size(241, 17);
            lblUserCreationDate.TabIndex = 100;
            lblUserCreationDate.Text = "This account has been active for 153 days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname";
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(840, 126);
            bt_EditProfile.Margin = new Padding(2);
            bt_EditProfile.Name = "bt_EditProfile";
            bt_EditProfile.Size = new Size(100, 25);
            bt_EditProfile.TabIndex = 9;
            bt_EditProfile.Text = "Edit Profile";
            bt_EditProfile.UseVisualStyleBackColor = true;
            bt_EditProfile.Click += bt_EditProfile_Click;
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
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Lastname";
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
            tb_Country.Size = new Size(580, 16);
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
            label9.Size = new Size(50, 15);
            label9.TabIndex = 8;
            label9.Text = "Country";
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
            tb_Zipcode.Size = new Size(580, 16);
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
            label8.Size = new Size(50, 15);
            label8.TabIndex = 7;
            label8.Text = "Zipcode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
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
            tb_City.Size = new Size(580, 16);
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
            tb_Address.Size = new Size(580, 16);
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
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(305, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_Users);
            tabControl.Controls.Add(tabPage_Projects);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 163);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(948, 528);
            tabControl.TabIndex = 23;
            // 
            // tabPage_Users
            // 
            tabPage_Users.BackColor = SystemColors.Control;
            tabPage_Users.Controls.Add(lbl_FeedbackUserTab);
            tabPage_Users.Controls.Add(btn_NewUser);
            tabPage_Users.Controls.Add(btn_DeleteUser);
            tabPage_Users.Controls.Add(btn_EditUser);
            tabPage_Users.Controls.Add(dgv_UserSearchResults);
            tabPage_Users.Controls.Add(grpBoxUserSearchFilter);
            tabPage_Users.Location = new Point(4, 24);
            tabPage_Users.Name = "tabPage_Users";
            tabPage_Users.Padding = new Padding(3);
            tabPage_Users.Size = new Size(940, 500);
            tabPage_Users.TabIndex = 0;
            tabPage_Users.Text = "Users";
            // 
            // lbl_FeedbackUserTab
            // 
            lbl_FeedbackUserTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FeedbackUserTab.AutoSize = true;
            lbl_FeedbackUserTab.Location = new Point(19, 474);
            lbl_FeedbackUserTab.Name = "lbl_FeedbackUserTab";
            lbl_FeedbackUserTab.Size = new Size(137, 15);
            lbl_FeedbackUserTab.TabIndex = 34;
            lbl_FeedbackUserTab.Text = "FeedBack Label Message";
            lbl_FeedbackUserTab.Visible = false;
            // 
            // btn_NewUser
            // 
            btn_NewUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_NewUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NewUser.Location = new Point(670, 470);
            btn_NewUser.Margin = new Padding(2);
            btn_NewUser.Name = "btn_NewUser";
            btn_NewUser.Size = new Size(107, 25);
            btn_NewUser.TabIndex = 33;
            btn_NewUser.Text = "New User";
            btn_NewUser.UseVisualStyleBackColor = true;
            btn_NewUser.Click += btn_NewUser_Click;
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_DeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DeleteUser.Location = new Point(835, 470);
            btn_DeleteUser.Margin = new Padding(2);
            btn_DeleteUser.Name = "btn_DeleteUser";
            btn_DeleteUser.Size = new Size(100, 25);
            btn_DeleteUser.TabIndex = 32;
            btn_DeleteUser.Text = "Delete";
            btn_DeleteUser.UseVisualStyleBackColor = true;
            btn_DeleteUser.Click += btn_DeleteUser_Click;
            // 
            // btn_EditUser
            // 
            btn_EditUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_EditUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EditUser.Location = new Point(566, 470);
            btn_EditUser.Margin = new Padding(2);
            btn_EditUser.Name = "btn_EditUser";
            btn_EditUser.Size = new Size(100, 25);
            btn_EditUser.TabIndex = 31;
            btn_EditUser.Text = "Manage User";
            btn_EditUser.UseVisualStyleBackColor = true;
            btn_EditUser.Click += btn_EditUser_Click;
            // 
            // dgv_UserSearchResults
            // 
            dgv_UserSearchResults.AllowUserToAddRows = false;
            dgv_UserSearchResults.AllowUserToDeleteRows = false;
            dgv_UserSearchResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            dgv_UserSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgv_UserSearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_UserSearchResults.BackgroundColor = SystemColors.Control;
            dgv_UserSearchResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_UserSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_UserSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UserSearchResults.Location = new Point(0, 63);
            dgv_UserSearchResults.MultiSelect = false;
            dgv_UserSearchResults.Name = "dgv_UserSearchResults";
            dgv_UserSearchResults.ReadOnly = true;
            dgv_UserSearchResults.RowHeadersVisible = false;
            dgv_UserSearchResults.RowTemplate.Height = 25;
            dgv_UserSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_UserSearchResults.Size = new Size(940, 398);
            dgv_UserSearchResults.TabIndex = 1;
            dgv_UserSearchResults.ColumnHeaderMouseClick += dgv_UserSearchResults_ColumnHeaderMouseClick;
            dgv_UserSearchResults.DataBindingComplete += dgv_UserSearchResults_DataBindingComplete;
            // 
            // grpBoxUserSearchFilter
            // 
            grpBoxUserSearchFilter.Controls.Add(radio_Consultants);
            grpBoxUserSearchFilter.Controls.Add(radio_Managers);
            grpBoxUserSearchFilter.Controls.Add(radio_AllUsers);
            grpBoxUserSearchFilter.Controls.Add(btn_SearchUsers);
            grpBoxUserSearchFilter.Controls.Add(txtBox_UserSearchParams);
            grpBoxUserSearchFilter.Dock = DockStyle.Top;
            grpBoxUserSearchFilter.Location = new Point(3, 3);
            grpBoxUserSearchFilter.Name = "grpBoxUserSearchFilter";
            grpBoxUserSearchFilter.Size = new Size(934, 63);
            grpBoxUserSearchFilter.TabIndex = 30;
            grpBoxUserSearchFilter.TabStop = false;
            grpBoxUserSearchFilter.Text = "Search Filter";
            // 
            // radio_Consultants
            // 
            radio_Consultants.AutoSize = true;
            radio_Consultants.Location = new Point(596, 23);
            radio_Consultants.Name = "radio_Consultants";
            radio_Consultants.Size = new Size(88, 19);
            radio_Consultants.TabIndex = 34;
            radio_Consultants.TabStop = true;
            radio_Consultants.Text = "Consultants";
            radio_Consultants.UseVisualStyleBackColor = true;
            // 
            // radio_Managers
            // 
            radio_Managers.AutoSize = true;
            radio_Managers.Location = new Point(513, 23);
            radio_Managers.Name = "radio_Managers";
            radio_Managers.Size = new Size(77, 19);
            radio_Managers.TabIndex = 32;
            radio_Managers.TabStop = true;
            radio_Managers.Text = "Managers";
            radio_Managers.UseVisualStyleBackColor = true;
            // 
            // radio_AllUsers
            // 
            radio_AllUsers.AutoSize = true;
            radio_AllUsers.Checked = true;
            radio_AllUsers.Location = new Point(468, 23);
            radio_AllUsers.Name = "radio_AllUsers";
            radio_AllUsers.Size = new Size(39, 19);
            radio_AllUsers.TabIndex = 31;
            radio_AllUsers.TabStop = true;
            radio_AllUsers.Text = "All";
            radio_AllUsers.UseVisualStyleBackColor = true;
            // 
            // btn_SearchUsers
            // 
            btn_SearchUsers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SearchUsers.Location = new Point(298, 21);
            btn_SearchUsers.Margin = new Padding(2);
            btn_SearchUsers.Name = "btn_SearchUsers";
            btn_SearchUsers.Size = new Size(100, 25);
            btn_SearchUsers.TabIndex = 10;
            btn_SearchUsers.Text = "Search";
            btn_SearchUsers.UseVisualStyleBackColor = true;
            btn_SearchUsers.Click += btn_SearchUsers_Click;
            // 
            // txtBox_UserSearchParams
            // 
            txtBox_UserSearchParams.Location = new Point(6, 22);
            txtBox_UserSearchParams.Name = "txtBox_UserSearchParams";
            txtBox_UserSearchParams.PlaceholderText = "ID, Username, Full Name";
            txtBox_UserSearchParams.Size = new Size(283, 23);
            txtBox_UserSearchParams.TabIndex = 0;
            txtBox_UserSearchParams.KeyDown += txtBox_UserSearchParams_KeyDown;
            // 
            // tabPage_Projects
            // 
            tabPage_Projects.BackColor = SystemColors.Control;
            tabPage_Projects.Controls.Add(btn_ViewInvites);
            tabPage_Projects.Controls.Add(btn_DetailsEdit);
            tabPage_Projects.Controls.Add(lbl_FeedbackProjectTab);
            tabPage_Projects.Controls.Add(btn_InvoiceDetails);
            tabPage_Projects.Controls.Add(btn_EditProject);
            tabPage_Projects.Controls.Add(btn_DeleteProject);
            tabPage_Projects.Controls.Add(dgv_ProjectSearchResults);
            tabPage_Projects.Controls.Add(groupBox1);
            tabPage_Projects.Location = new Point(4, 24);
            tabPage_Projects.Name = "tabPage_Projects";
            tabPage_Projects.Padding = new Padding(3);
            tabPage_Projects.Size = new Size(940, 500);
            tabPage_Projects.TabIndex = 1;
            tabPage_Projects.Text = "Projects";
            // 
            // btn_ViewInvites
            // 
            btn_ViewInvites.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ViewInvites.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewInvites.Location = new Point(372, 468);
            btn_ViewInvites.Margin = new Padding(2);
            btn_ViewInvites.Name = "btn_ViewInvites";
            btn_ViewInvites.Size = new Size(107, 25);
            btn_ViewInvites.TabIndex = 38;
            btn_ViewInvites.Text = "View Invites";
            btn_ViewInvites.UseVisualStyleBackColor = true;
            btn_ViewInvites.Click += btn_ViewInvites_Click;
            // 
            // btn_DetailsEdit
            // 
            btn_DetailsEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_DetailsEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DetailsEdit.Location = new Point(587, 468);
            btn_DetailsEdit.Margin = new Padding(2);
            btn_DetailsEdit.Name = "btn_DetailsEdit";
            btn_DetailsEdit.Size = new Size(107, 25);
            btn_DetailsEdit.TabIndex = 37;
            btn_DetailsEdit.Text = "Edit Details";
            btn_DetailsEdit.UseVisualStyleBackColor = true;
            btn_DetailsEdit.Click += btn_DetailsEdit_Click;
            // 
            // lbl_FeedbackProjectTab
            // 
            lbl_FeedbackProjectTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FeedbackProjectTab.AutoSize = true;
            lbl_FeedbackProjectTab.Location = new Point(19, 473);
            lbl_FeedbackProjectTab.Name = "lbl_FeedbackProjectTab";
            lbl_FeedbackProjectTab.Size = new Size(137, 15);
            lbl_FeedbackProjectTab.TabIndex = 36;
            lbl_FeedbackProjectTab.Text = "FeedBack Label Message";
            lbl_FeedbackProjectTab.Visible = false;
            // 
            // btn_InvoiceDetails
            // 
            btn_InvoiceDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_InvoiceDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_InvoiceDetails.Location = new Point(698, 468);
            btn_InvoiceDetails.Margin = new Padding(2);
            btn_InvoiceDetails.Name = "btn_InvoiceDetails";
            btn_InvoiceDetails.Size = new Size(107, 25);
            btn_InvoiceDetails.TabIndex = 35;
            btn_InvoiceDetails.Text = "Invoice Details";
            btn_InvoiceDetails.UseVisualStyleBackColor = true;
            btn_InvoiceDetails.Click += btn_InvoiceDetails_Click;
            // 
            // btn_EditProject
            // 
            btn_EditProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_EditProject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EditProject.Location = new Point(483, 468);
            btn_EditProject.Margin = new Padding(2);
            btn_EditProject.Name = "btn_EditProject";
            btn_EditProject.Size = new Size(100, 25);
            btn_EditProject.TabIndex = 34;
            btn_EditProject.Text = "View Messages";
            btn_EditProject.UseVisualStyleBackColor = true;
            btn_EditProject.Click += btn_EditProject_Click;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_DeleteProject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DeleteProject.Location = new Point(833, 468);
            btn_DeleteProject.Margin = new Padding(2);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(100, 25);
            btn_DeleteProject.TabIndex = 33;
            btn_DeleteProject.Text = "Delete";
            btn_DeleteProject.UseVisualStyleBackColor = true;
            btn_DeleteProject.Click += btn_DeleteProject_Click;
            // 
            // dgv_ProjectSearchResults
            // 
            dgv_ProjectSearchResults.AllowUserToAddRows = false;
            dgv_ProjectSearchResults.AllowUserToDeleteRows = false;
            dgv_ProjectSearchResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dgv_ProjectSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_ProjectSearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ProjectSearchResults.BackgroundColor = SystemColors.Control;
            dgv_ProjectSearchResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_ProjectSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_ProjectSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProjectSearchResults.Location = new Point(0, 63);
            dgv_ProjectSearchResults.MultiSelect = false;
            dgv_ProjectSearchResults.Name = "dgv_ProjectSearchResults";
            dgv_ProjectSearchResults.ReadOnly = true;
            dgv_ProjectSearchResults.RowHeadersVisible = false;
            dgv_ProjectSearchResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_ProjectSearchResults.RowTemplate.Height = 25;
            dgv_ProjectSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ProjectSearchResults.Size = new Size(940, 400);
            dgv_ProjectSearchResults.TabIndex = 32;
            dgv_ProjectSearchResults.ColumnHeaderMouseClick += dgv_ProjectSearchResults_ColumnHeaderMouseClick;
            dgv_ProjectSearchResults.DataBindingComplete += dgv_UserSearchResults_DataBindingComplete;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_Ended);
            groupBox1.Controls.Add(radio_InProgress);
            groupBox1.Controls.Add(radio_AllProjects);
            groupBox1.Controls.Add(radio_Pending);
            groupBox1.Controls.Add(btn_SearchProjects);
            groupBox1.Controls.Add(txtBox_ProjectSearchParams);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 62);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Filter";
            // 
            // radio_Ended
            // 
            radio_Ended.AutoSize = true;
            radio_Ended.Location = new Point(633, 24);
            radio_Ended.Name = "radio_Ended";
            radio_Ended.Size = new Size(58, 19);
            radio_Ended.TabIndex = 35;
            radio_Ended.TabStop = true;
            radio_Ended.Text = "Ended";
            radio_Ended.UseVisualStyleBackColor = true;
            // 
            // radio_InProgress
            // 
            radio_InProgress.AutoSize = true;
            radio_InProgress.Location = new Point(469, 24);
            radio_InProgress.Name = "radio_InProgress";
            radio_InProgress.Size = new Size(83, 19);
            radio_InProgress.TabIndex = 34;
            radio_InProgress.TabStop = true;
            radio_InProgress.Text = "In Progress";
            radio_InProgress.UseVisualStyleBackColor = true;
            // 
            // radio_AllProjects
            // 
            radio_AllProjects.AutoSize = true;
            radio_AllProjects.Checked = true;
            radio_AllProjects.Location = new Point(424, 24);
            radio_AllProjects.Name = "radio_AllProjects";
            radio_AllProjects.Size = new Size(39, 19);
            radio_AllProjects.TabIndex = 31;
            radio_AllProjects.TabStop = true;
            radio_AllProjects.Text = "All";
            radio_AllProjects.UseVisualStyleBackColor = true;
            // 
            // radio_Pending
            // 
            radio_Pending.AutoSize = true;
            radio_Pending.Location = new Point(558, 24);
            radio_Pending.Name = "radio_Pending";
            radio_Pending.Size = new Size(69, 19);
            radio_Pending.TabIndex = 32;
            radio_Pending.TabStop = true;
            radio_Pending.Text = "Pending";
            radio_Pending.UseVisualStyleBackColor = true;
            // 
            // btn_SearchProjects
            // 
            btn_SearchProjects.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SearchProjects.Location = new Point(298, 21);
            btn_SearchProjects.Margin = new Padding(2);
            btn_SearchProjects.Name = "btn_SearchProjects";
            btn_SearchProjects.Size = new Size(100, 25);
            btn_SearchProjects.TabIndex = 10;
            btn_SearchProjects.Text = "Search";
            btn_SearchProjects.UseVisualStyleBackColor = true;
            btn_SearchProjects.Click += btn_SearchProjects_Click;
            // 
            // txtBox_ProjectSearchParams
            // 
            txtBox_ProjectSearchParams.Location = new Point(6, 22);
            txtBox_ProjectSearchParams.Name = "txtBox_ProjectSearchParams";
            txtBox_ProjectSearchParams.PlaceholderText = "Project Title, Manager Name or User Name";
            txtBox_ProjectSearchParams.Size = new Size(283, 23);
            txtBox_ProjectSearchParams.TabIndex = 0;
            txtBox_ProjectSearchParams.KeyDown += txtBox_ProjectSearchParams_KeyDown;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 691);
            Controls.Add(tabControl);
            Controls.Add(grpBoxProfileInfo);
            MinimumSize = new Size(755, 625);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage_Users.ResumeLayout(false);
            tabPage_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_UserSearchResults).EndInit();
            grpBoxUserSearchFilter.ResumeLayout(false);
            grpBoxUserSearchFilter.PerformLayout();
            tabPage_Projects.ResumeLayout(false);
            tabPage_Projects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectSearchResults).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxProfileInfo;
        private Button bt_EditProfileCancel;
        private Label lblUserCreationDate;
        private Button bt_EditProfile;
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
        private TabControl tabControl;
        private TabPage tabPage_Users;
        private TabPage tabPage_Projects;
        private DataGridView dgv_UserSearchResults;
        private GroupBox grpBoxUserSearchFilter;
        private TextBox txtBox_UserSearchParams;
        private Button btn_SearchUsers;
        private RadioButton radio_Consultants;
        private RadioButton radio_Managers;
        private RadioButton radio_AllUsers;
        private Button btn_NewUser;
        private Button btn_DeleteUser;
        private Button btn_EditUser;
        private DataGridView dgv_ProjectSearchResults;
        private GroupBox groupBox1;
        private RadioButton radio_Ended;
        private RadioButton radio_InProgress;
        private RadioButton radio_AllProjects;
        private RadioButton radio_Pending;
        private Button btn_SearchProjects;
        private TextBox txtBox_ProjectSearchParams;
        private Button btn_InvoiceDetails;
        private Button btn_EditProject;
        private Button btn_DeleteProject;
        private Label lbl_FeedbackUserTab;
        private Label lbl_FeedbackProjectTab;
        private Button btn_DetailsEdit;
        private Button btn_ViewInvites;
    }
}