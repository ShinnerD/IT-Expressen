namespace GUI
{
    partial class CreateUser
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
            components = new System.ComponentModel.Container();
            bt_CreateUser = new Button();
            cb_UserType = new ComboBox();
            clb_Skills = new CheckedListBox();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            bt_back = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            toolTip2 = new ToolTip(components);
            label10 = new Label();
            toolTip3 = new ToolTip(components);
            label11 = new Label();
            toolTip4 = new ToolTip(components);
            label3 = new Label();
            toolTip5 = new ToolTip(components);
            label4 = new Label();
            toolTip6 = new ToolTip(components);
            label6 = new Label();
            toolTip7 = new ToolTip(components);
            label8 = new Label();
            toolTip8 = new ToolTip(components);
            label9 = new Label();
            toolTip9 = new ToolTip(components);
            label2 = new Label();
            toolTip10 = new ToolTip(components);
            label7 = new Label();
            toolTip11 = new ToolTip(components);
            label5 = new Label();
            toolTip12 = new ToolTip(components);
            toolTip13 = new ToolTip(components);
            grpBoxProfileInfo = new GroupBox();
            tb_UserName = new TextBox();
            tb_Password = new TextBox();
            tb_RePassword = new TextBox();
            bt_EditProfileCancel = new Button();
            bt_EditProfile = new Button();
            tb_FirstName = new TextBox();
            tb_Country = new TextBox();
            tb_LastName = new TextBox();
            tb_Zipcode = new TextBox();
            tb_City = new TextBox();
            tb_Email = new TextBox();
            tb_Address = new TextBox();
            tb_PhoneNumber = new TextBox();
            lbl_FeedBackLabel = new Label();
            grpBoxProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // bt_CreateUser
            // 
            bt_CreateUser.Location = new Point(557, 403);
            bt_CreateUser.Name = "bt_CreateUser";
            bt_CreateUser.Size = new Size(75, 24);
            bt_CreateUser.TabIndex = 15;
            bt_CreateUser.Text = "Ok";
            bt_CreateUser.UseVisualStyleBackColor = true;
            bt_CreateUser.Click += bt_CreateUser_Click;
            // 
            // cb_UserType
            // 
            cb_UserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_UserType.FormattingEnabled = true;
            cb_UserType.Items.AddRange(new object[] { "Consultant", "Manager" });
            cb_UserType.Location = new Point(456, 220);
            cb_UserType.Name = "cb_UserType";
            cb_UserType.Size = new Size(176, 23);
            cb_UserType.TabIndex = 12;
            cb_UserType.DropDownClosed += cb_UserType_SelectedValueChanged;
            // 
            // clb_Skills
            // 
            clb_Skills.FormattingEnabled = true;
            clb_Skills.Location = new Point(115, 249);
            clb_Skills.MultiColumn = true;
            clb_Skills.Name = "clb_Skills";
            clb_Skills.Size = new Size(517, 148);
            clb_Skills.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(352, 223);
            label12.Name = "label12";
            label12.Size = new Size(89, 13);
            label12.TabIndex = 26;
            label12.Text = "Pick profile type";
            toolTip12.SetToolTip(label12, "What are you looking for of specializations.");
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 249);
            label13.Name = "label13";
            label13.Size = new Size(106, 43);
            label13.TabIndex = 27;
            label13.Text = "For consultants only:";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 285);
            label15.Name = "label15";
            label15.Size = new Size(106, 43);
            label15.TabIndex = 29;
            label15.Text = "Select your specializations";
            toolTip13.SetToolTip(label15, "Enter what specializations you have.\r\n\r\nIf the  specializations is not here contact admin: Adm@mail.com");
            // 
            // bt_back
            // 
            bt_back.Location = new Point(115, 403);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(75, 24);
            bt_back.TabIndex = 14;
            bt_back.Text = "Cancel";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 101;
            label1.Text = "Username:";
            toolTip1.SetToolTip(label1, "Enter your user name here.");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 56);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 107;
            label10.Text = "Password:";
            toolTip2.SetToolTip(label10, "Enter the password you what to your account.");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(296, 56);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 104;
            label11.Text = "Re-Enter Password:";
            toolTip3.SetToolTip(label11, "Save Password and make sure its the same as the password before.");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 149);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            toolTip4.SetToolTip(label3, "The mail you whan't too connect to this account.");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            toolTip5.SetToolTip(label4, "The number you wan't connected too this account.");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(352, 97);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            toolTip6.SetToolTip(label6, "A home adresse or company adresse.");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(352, 149);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 7;
            label8.Text = "Zipcode:";
            toolTip7.SetToolTip(label8, "The zip code off your distrikt.");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(351, 176);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 8;
            label9.Text = "Country:";
            toolTip8.SetToolTip(label9, "The country yuo live in.");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname:";
            toolTip9.SetToolTip(label2, "Your first name.");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 123);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Lastname:";
            toolTip10.SetToolTip(label7, "The last name of your name.");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(373, 123);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "City:";
            toolTip11.SetToolTip(label5, "The City you live in.");
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(label1);
            grpBoxProfileInfo.Controls.Add(tb_UserName);
            grpBoxProfileInfo.Controls.Add(label10);
            grpBoxProfileInfo.Controls.Add(tb_Password);
            grpBoxProfileInfo.Controls.Add(tb_RePassword);
            grpBoxProfileInfo.Controls.Add(label11);
            grpBoxProfileInfo.Controls.Add(bt_EditProfileCancel);
            grpBoxProfileInfo.Controls.Add(bt_EditProfile);
            grpBoxProfileInfo.Controls.Add(label2);
            grpBoxProfileInfo.Controls.Add(tb_FirstName);
            grpBoxProfileInfo.Controls.Add(label7);
            grpBoxProfileInfo.Controls.Add(tb_Country);
            grpBoxProfileInfo.Controls.Add(tb_LastName);
            grpBoxProfileInfo.Controls.Add(label9);
            grpBoxProfileInfo.Controls.Add(tb_Zipcode);
            grpBoxProfileInfo.Controls.Add(label8);
            grpBoxProfileInfo.Controls.Add(label3);
            grpBoxProfileInfo.Controls.Add(tb_City);
            grpBoxProfileInfo.Controls.Add(tb_Email);
            grpBoxProfileInfo.Controls.Add(tb_Address);
            grpBoxProfileInfo.Controls.Add(tb_PhoneNumber);
            grpBoxProfileInfo.Controls.Add(label5);
            grpBoxProfileInfo.Controls.Add(label4);
            grpBoxProfileInfo.Controls.Add(label6);
            grpBoxProfileInfo.Dock = DockStyle.Top;
            grpBoxProfileInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxProfileInfo.Location = new Point(0, 0);
            grpBoxProfileInfo.Name = "grpBoxProfileInfo";
            grpBoxProfileInfo.Size = new Size(652, 209);
            grpBoxProfileInfo.TabIndex = 32;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "Fill out the form to create your user account";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = SystemColors.ControlLight;
            tb_UserName.BorderStyle = BorderStyle.None;
            tb_UserName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_UserName.Location = new Point(68, 27);
            tb_UserName.Margin = new Padding(2);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(225, 16);
            tb_UserName.TabIndex = 1;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = SystemColors.ControlLight;
            tb_Password.BorderStyle = BorderStyle.None;
            tb_Password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(68, 53);
            tb_Password.Margin = new Padding(2);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(225, 16);
            tb_Password.TabIndex = 2;
            // 
            // tb_RePassword
            // 
            tb_RePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_RePassword.BackColor = SystemColors.ControlLight;
            tb_RePassword.BorderStyle = BorderStyle.None;
            tb_RePassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_RePassword.Location = new Point(407, 53);
            tb_RePassword.Margin = new Padding(2);
            tb_RePassword.Name = "tb_RePassword";
            tb_RePassword.PasswordChar = '*';
            tb_RePassword.Size = new Size(225, 16);
            tb_RePassword.TabIndex = 3;
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(936, 126);
            bt_EditProfileCancel.Margin = new Padding(2);
            bt_EditProfileCancel.Name = "bt_EditProfileCancel";
            bt_EditProfileCancel.Size = new Size(100, 25);
            bt_EditProfileCancel.TabIndex = 9;
            bt_EditProfileCancel.Text = "Cancel";
            bt_EditProfileCancel.UseVisualStyleBackColor = true;
            bt_EditProfileCancel.Visible = false;
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(1040, 126);
            bt_EditProfile.Margin = new Padding(2);
            bt_EditProfile.Name = "bt_EditProfile";
            bt_EditProfile.Size = new Size(100, 25);
            bt_EditProfile.TabIndex = 9;
            bt_EditProfile.Text = "Edit Profile";
            bt_EditProfile.UseVisualStyleBackColor = true;
            // 
            // tb_FirstName
            // 
            tb_FirstName.BackColor = SystemColors.ControlLight;
            tb_FirstName.BorderStyle = BorderStyle.None;
            tb_FirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_FirstName.Location = new Point(68, 94);
            tb_FirstName.Margin = new Padding(2);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(225, 16);
            tb_FirstName.TabIndex = 4;
            // 
            // tb_Country
            // 
            tb_Country.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Country.BackColor = SystemColors.ControlLight;
            tb_Country.BorderStyle = BorderStyle.None;
            tb_Country.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Country.Location = new Point(407, 173);
            tb_Country.Margin = new Padding(2);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(225, 16);
            tb_Country.TabIndex = 11;
            // 
            // tb_LastName
            // 
            tb_LastName.BackColor = SystemColors.ControlLight;
            tb_LastName.BorderStyle = BorderStyle.None;
            tb_LastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_LastName.Location = new Point(68, 120);
            tb_LastName.Margin = new Padding(2);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(225, 16);
            tb_LastName.TabIndex = 5;
            // 
            // tb_Zipcode
            // 
            tb_Zipcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Zipcode.BackColor = SystemColors.ControlLight;
            tb_Zipcode.BorderStyle = BorderStyle.None;
            tb_Zipcode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Zipcode.Location = new Point(407, 146);
            tb_Zipcode.Margin = new Padding(2);
            tb_Zipcode.Name = "tb_Zipcode";
            tb_Zipcode.Size = new Size(225, 16);
            tb_Zipcode.TabIndex = 10;
            // 
            // tb_City
            // 
            tb_City.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_City.BackColor = SystemColors.ControlLight;
            tb_City.BorderStyle = BorderStyle.None;
            tb_City.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_City.Location = new Point(407, 121);
            tb_City.Margin = new Padding(2);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(225, 16);
            tb_City.TabIndex = 9;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = SystemColors.ControlLight;
            tb_Email.BorderStyle = BorderStyle.None;
            tb_Email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.Location = new Point(68, 146);
            tb_Email.Margin = new Padding(2);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(225, 16);
            tb_Email.TabIndex = 6;
            // 
            // tb_Address
            // 
            tb_Address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Address.BackColor = SystemColors.ControlLight;
            tb_Address.BorderStyle = BorderStyle.None;
            tb_Address.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(407, 94);
            tb_Address.Margin = new Padding(2);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(225, 16);
            tb_Address.TabIndex = 8;
            // 
            // tb_PhoneNumber
            // 
            tb_PhoneNumber.BackColor = SystemColors.ControlLight;
            tb_PhoneNumber.BorderStyle = BorderStyle.None;
            tb_PhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_PhoneNumber.Location = new Point(68, 173);
            tb_PhoneNumber.Margin = new Padding(2);
            tb_PhoneNumber.Name = "tb_PhoneNumber";
            tb_PhoneNumber.Size = new Size(225, 16);
            tb_PhoneNumber.TabIndex = 7;
            // 
            // lbl_FeedBackLabel
            // 
            lbl_FeedBackLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FeedBackLabel.AutoSize = true;
            lbl_FeedBackLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FeedBackLabel.Location = new Point(3, 430);
            lbl_FeedBackLabel.Name = "lbl_FeedBackLabel";
            lbl_FeedBackLabel.Size = new Size(166, 15);
            lbl_FeedBackLabel.TabIndex = 33;
            lbl_FeedBackLabel.Text = "Feedback label for messages...";
            lbl_FeedBackLabel.Visible = false;
            // 
            // CreateUser
            // 
            AcceptButton = bt_CreateUser;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bt_back;
            ClientSize = new Size(652, 452);
            Controls.Add(lbl_FeedBackLabel);
            Controls.Add(grpBoxProfileInfo);
            Controls.Add(bt_back);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(clb_Skills);
            Controls.Add(cb_UserType);
            Controls.Add(bt_CreateUser);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(668, 491);
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Account";
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_CreateUser;
        private ComboBox cb_UserType;
        private CheckedListBox clb_Skills;
        private Label label12;
        private Label label13;
        private Label label15;
        private Button bt_back;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip9;
        private ToolTip toolTip10;
        private ToolTip toolTip6;
        private ToolTip toolTip11;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip12;
        private ToolTip toolTip13;
        private GroupBox grpBoxProfileInfo;
        private Button bt_EditProfileCancel;
        private Button bt_EditProfile;
        private Label label2;
        private TextBox tb_FirstName;
        private Label label7;
        private TextBox tb_Country;
        private TextBox tb_LastName;
        private Label label9;
        private TextBox tb_Zipcode;
        private Label label8;
        private Label label3;
        private TextBox tb_City;
        private TextBox tb_Email;
        private TextBox tb_Address;
        private TextBox tb_PhoneNumber;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label1;
        private TextBox tb_UserName;
        private Label label10;
        private TextBox tb_Password;
        private TextBox tb_RePassword;
        private Label label11;
        private Label lbl_FeedBackLabel;
    }
}