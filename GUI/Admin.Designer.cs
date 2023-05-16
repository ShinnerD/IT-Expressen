namespace GUI
{
    partial class Admin
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dgv_ConsultantList = new DataGridView();
            grpBoxSpecFilter = new GroupBox();
            radioButton1 = new RadioButton();
            radioBtnAll = new RadioButton();
            radioBtnAny = new RadioButton();
            button1 = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            grpBoxProfileInfo.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            grpBoxSpecFilter.SuspendLayout();
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
            grpBoxProfileInfo.Size = new Size(739, 163);
            grpBoxProfileInfo.TabIndex = 22;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "Admin UserName";
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(527, 126);
            bt_EditProfileCancel.Margin = new Padding(2);
            bt_EditProfileCancel.Name = "bt_EditProfileCancel";
            bt_EditProfileCancel.Size = new Size(100, 25);
            bt_EditProfileCancel.TabIndex = 9;
            bt_EditProfileCancel.Text = "Cancel";
            bt_EditProfileCancel.UseVisualStyleBackColor = true;
            bt_EditProfileCancel.Visible = false;
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
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname:";
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(631, 126);
            bt_EditProfile.Margin = new Padding(2);
            bt_EditProfile.Name = "bt_EditProfile";
            bt_EditProfile.Size = new Size(100, 25);
            bt_EditProfile.TabIndex = 9;
            bt_EditProfile.Text = "Edit Profile";
            bt_EditProfile.UseVisualStyleBackColor = true;
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
            tb_Country.Size = new Size(371, 16);
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
            tb_Zipcode.Size = new Size(371, 16);
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
            tb_City.Size = new Size(371, 16);
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
            tb_Address.Size = new Size(371, 16);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 163);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 423);
            tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dgv_ConsultantList);
            tabPage1.Controls.Add(grpBoxSpecFilter);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 364);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(107, 25);
            button4.TabIndex = 33;
            button4.Text = "New User";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(628, 364);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(100, 25);
            button3.TabIndex = 32;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(460, 364);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 31;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.AllowUserToAddRows = false;
            dgv_ConsultantList.AllowUserToDeleteRows = false;
            dgv_ConsultantList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(3, 63);
            dgv_ConsultantList.MultiSelect = false;
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.ReadOnly = true;
            dgv_ConsultantList.RowHeadersVisible = false;
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantList.Size = new Size(732, 293);
            dgv_ConsultantList.TabIndex = 1;
            // 
            // grpBoxSpecFilter
            // 
            grpBoxSpecFilter.Controls.Add(radioButton1);
            grpBoxSpecFilter.Controls.Add(radioBtnAll);
            grpBoxSpecFilter.Controls.Add(radioBtnAny);
            grpBoxSpecFilter.Controls.Add(button1);
            grpBoxSpecFilter.Controls.Add(textBox1);
            grpBoxSpecFilter.Dock = DockStyle.Top;
            grpBoxSpecFilter.Location = new Point(3, 3);
            grpBoxSpecFilter.Name = "grpBoxSpecFilter";
            grpBoxSpecFilter.Size = new Size(725, 63);
            grpBoxSpecFilter.TabIndex = 30;
            grpBoxSpecFilter.TabStop = false;
            grpBoxSpecFilter.Text = "Search Filter";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(596, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 19);
            radioButton1.TabIndex = 34;
            radioButton1.TabStop = true;
            radioButton1.Text = "Consultants";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioBtnAll
            // 
            radioBtnAll.AutoSize = true;
            radioBtnAll.Location = new Point(513, 23);
            radioBtnAll.Name = "radioBtnAll";
            radioBtnAll.Size = new Size(77, 19);
            radioBtnAll.TabIndex = 32;
            radioBtnAll.TabStop = true;
            radioBtnAll.Text = "Managers";
            radioBtnAll.UseVisualStyleBackColor = true;
            // 
            // radioBtnAny
            // 
            radioBtnAny.AutoSize = true;
            radioBtnAny.Checked = true;
            radioBtnAny.Location = new Point(468, 23);
            radioBtnAny.Name = "radioBtnAny";
            radioBtnAny.Size = new Size(39, 19);
            radioBtnAny.TabIndex = 31;
            radioBtnAny.TabStop = true;
            radioBtnAny.Text = "All";
            radioBtnAny.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(298, 21);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 10;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Projects";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 586);
            Controls.Add(tabControl1);
            Controls.Add(grpBoxProfileInfo);
            MinimumSize = new Size(755, 625);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            grpBoxSpecFilter.ResumeLayout(false);
            grpBoxSpecFilter.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_ConsultantList;
        private GroupBox grpBoxSpecFilter;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioBtnAll;
        private RadioButton radioBtnAny;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}