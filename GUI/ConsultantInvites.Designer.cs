namespace GUI
{
    partial class ConsultantInvites
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
            groupBox1 = new GroupBox();
            bt_seeInviteDetails = new Button();
            dgv_ConsultantsInvites = new DataGridView();
            grpBoxProfileInfo = new GroupBox();
            label1 = new Label();
            rtb_Description = new RichTextBox();
            bt_EditProfileCancel = new Button();
            lb_DaysTilEnd = new Label();
            bt_EditProfile = new Button();
            label2 = new Label();
            tb_ProjectID = new TextBox();
            label7 = new Label();
            tb_Country = new TextBox();
            tb_ProjectTitle = new TextBox();
            label9 = new Label();
            tb_ProjectModifiedDate = new TextBox();
            label8 = new Label();
            label3 = new Label();
            tb_ProjectEndDate = new TextBox();
            tb_ProjectOwner = new TextBox();
            tb_ProjectStartDate = new TextBox();
            tb_ProjectStatus = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            lbl_ReqSkills = new Label();
            checkedListSkills = new CheckedListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).BeginInit();
            grpBoxProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_seeInviteDetails);
            groupBox1.Controls.Add(dgv_ConsultantsInvites);
            groupBox1.Location = new Point(26, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 346);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Invites";
            // 
            // bt_seeInviteDetails
            // 
            bt_seeInviteDetails.Dock = DockStyle.Right;
            bt_seeInviteDetails.Location = new Point(552, 316);
            bt_seeInviteDetails.Name = "bt_seeInviteDetails";
            bt_seeInviteDetails.Size = new Size(101, 27);
            bt_seeInviteDetails.TabIndex = 39;
            bt_seeInviteDetails.Text = "See Details";
            bt_seeInviteDetails.UseVisualStyleBackColor = true;
            bt_seeInviteDetails.Click += bt_seeInviteDetails_Click;
            // 
            // dgv_ConsultantsInvites
            // 
            dgv_ConsultantsInvites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantsInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantsInvites.Dock = DockStyle.Top;
            dgv_ConsultantsInvites.Location = new Point(3, 19);
            dgv_ConsultantsInvites.Name = "dgv_ConsultantsInvites";
            dgv_ConsultantsInvites.RowHeadersVisible = false;
            dgv_ConsultantsInvites.RowTemplate.Height = 25;
            dgv_ConsultantsInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantsInvites.Size = new Size(650, 297);
            dgv_ConsultantsInvites.TabIndex = 37;
            dgv_ConsultantsInvites.CellClick += dgv_ConsultantsInvites_CellClick;
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(lbl_ReqSkills);
            grpBoxProfileInfo.Controls.Add(checkedListSkills);
            grpBoxProfileInfo.Controls.Add(label1);
            grpBoxProfileInfo.Controls.Add(rtb_Description);
            grpBoxProfileInfo.Controls.Add(bt_EditProfileCancel);
            grpBoxProfileInfo.Controls.Add(lb_DaysTilEnd);
            grpBoxProfileInfo.Controls.Add(bt_EditProfile);
            grpBoxProfileInfo.Controls.Add(label2);
            grpBoxProfileInfo.Controls.Add(tb_ProjectID);
            grpBoxProfileInfo.Controls.Add(label7);
            grpBoxProfileInfo.Controls.Add(tb_Country);
            grpBoxProfileInfo.Controls.Add(tb_ProjectTitle);
            grpBoxProfileInfo.Controls.Add(label9);
            grpBoxProfileInfo.Controls.Add(tb_ProjectModifiedDate);
            grpBoxProfileInfo.Controls.Add(label8);
            grpBoxProfileInfo.Controls.Add(label3);
            grpBoxProfileInfo.Controls.Add(tb_ProjectEndDate);
            grpBoxProfileInfo.Controls.Add(tb_ProjectOwner);
            grpBoxProfileInfo.Controls.Add(tb_ProjectStartDate);
            grpBoxProfileInfo.Controls.Add(tb_ProjectStatus);
            grpBoxProfileInfo.Controls.Add(label5);
            grpBoxProfileInfo.Controls.Add(label4);
            grpBoxProfileInfo.Controls.Add(label6);
            grpBoxProfileInfo.Dock = DockStyle.Top;
            grpBoxProfileInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxProfileInfo.Location = new Point(0, 0);
            grpBoxProfileInfo.Name = "grpBoxProfileInfo";
            grpBoxProfileInfo.Size = new Size(694, 270);
            grpBoxProfileInfo.TabIndex = 42;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 102;
            label1.Text = "Description:";
            // 
            // rtb_Description
            // 
            rtb_Description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Description.Location = new Point(29, 156);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.ReadOnly = true;
            rtb_Description.Size = new Size(337, 108);
            rtb_Description.TabIndex = 101;
            rtb_Description.Text = "";
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(1661, 126);
            bt_EditProfileCancel.Margin = new Padding(2);
            bt_EditProfileCancel.Name = "bt_EditProfileCancel";
            bt_EditProfileCancel.Size = new Size(100, 25);
            bt_EditProfileCancel.TabIndex = 9;
            bt_EditProfileCancel.Text = "Cancel";
            bt_EditProfileCancel.UseVisualStyleBackColor = true;
            bt_EditProfileCancel.Visible = false;
            // 
            // lb_DaysTilEnd
            // 
            lb_DaysTilEnd.AutoSize = true;
            lb_DaysTilEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lb_DaysTilEnd.Location = new Point(219, 129);
            lb_DaysTilEnd.Name = "lb_DaysTilEnd";
            lb_DaysTilEnd.Size = new Size(186, 17);
            lb_DaysTilEnd.TabIndex = 100;
            lb_DaysTilEnd.Text = "You've been a user for 154 days";
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(1765, 126);
            bt_EditProfile.Margin = new Padding(2);
            bt_EditProfile.Name = "bt_EditProfile";
            bt_EditProfile.Size = new Size(100, 25);
            bt_EditProfile.TabIndex = 9;
            bt_EditProfile.Text = "Edit Profile";
            bt_EditProfile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Project ID";
            // 
            // tb_ProjectID
            // 
            tb_ProjectID.BackColor = SystemColors.ControlLight;
            tb_ProjectID.BorderStyle = BorderStyle.None;
            tb_ProjectID.Enabled = false;
            tb_ProjectID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectID.Location = new Point(88, 22);
            tb_ProjectID.Margin = new Padding(2);
            tb_ProjectID.Name = "tb_ProjectID";
            tb_ProjectID.Size = new Size(208, 16);
            tb_ProjectID.TabIndex = 1;
            tb_ProjectID.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 51);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Title:";
            // 
            // tb_Country
            // 
            tb_Country.BackColor = SystemColors.ControlLight;
            tb_Country.BorderStyle = BorderStyle.None;
            tb_Country.Enabled = false;
            tb_Country.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Country.Location = new Point(431, 101);
            tb_Country.Margin = new Padding(2);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(251, 16);
            tb_Country.TabIndex = 8;
            tb_Country.TabStop = false;
            // 
            // tb_ProjectTitle
            // 
            tb_ProjectTitle.BackColor = SystemColors.ControlLight;
            tb_ProjectTitle.BorderStyle = BorderStyle.None;
            tb_ProjectTitle.Enabled = false;
            tb_ProjectTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectTitle.Location = new Point(88, 48);
            tb_ProjectTitle.Margin = new Padding(2);
            tb_ProjectTitle.Name = "tb_ProjectTitle";
            tb_ProjectTitle.Size = new Size(208, 16);
            tb_ProjectTitle.TabIndex = 2;
            tb_ProjectTitle.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(372, 101);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 8;
            label9.Text = "UNUSED!";
            // 
            // tb_ProjectModifiedDate
            // 
            tb_ProjectModifiedDate.BackColor = SystemColors.ControlLight;
            tb_ProjectModifiedDate.BorderStyle = BorderStyle.None;
            tb_ProjectModifiedDate.Enabled = false;
            tb_ProjectModifiedDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectModifiedDate.Location = new Point(431, 74);
            tb_ProjectModifiedDate.Margin = new Padding(2);
            tb_ProjectModifiedDate.Name = "tb_ProjectModifiedDate";
            tb_ProjectModifiedDate.Size = new Size(251, 16);
            tb_ProjectModifiedDate.TabIndex = 7;
            tb_ProjectModifiedDate.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(305, 77);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 7;
            label8.Text = "Project Last Modified:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Owner:";
            // 
            // tb_ProjectEndDate
            // 
            tb_ProjectEndDate.BackColor = SystemColors.ControlLight;
            tb_ProjectEndDate.BorderStyle = BorderStyle.None;
            tb_ProjectEndDate.Enabled = false;
            tb_ProjectEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectEndDate.Location = new Point(431, 48);
            tb_ProjectEndDate.Margin = new Padding(2);
            tb_ProjectEndDate.Name = "tb_ProjectEndDate";
            tb_ProjectEndDate.Size = new Size(251, 16);
            tb_ProjectEndDate.TabIndex = 6;
            tb_ProjectEndDate.TabStop = false;
            // 
            // tb_ProjectOwner
            // 
            tb_ProjectOwner.BackColor = SystemColors.ControlLight;
            tb_ProjectOwner.BorderStyle = BorderStyle.None;
            tb_ProjectOwner.Enabled = false;
            tb_ProjectOwner.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectOwner.Location = new Point(88, 74);
            tb_ProjectOwner.Margin = new Padding(2);
            tb_ProjectOwner.Name = "tb_ProjectOwner";
            tb_ProjectOwner.Size = new Size(208, 16);
            tb_ProjectOwner.TabIndex = 3;
            tb_ProjectOwner.TabStop = false;
            // 
            // tb_ProjectStartDate
            // 
            tb_ProjectStartDate.BackColor = SystemColors.ControlLight;
            tb_ProjectStartDate.BorderStyle = BorderStyle.None;
            tb_ProjectStartDate.Enabled = false;
            tb_ProjectStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectStartDate.Location = new Point(431, 22);
            tb_ProjectStartDate.Margin = new Padding(2);
            tb_ProjectStartDate.Name = "tb_ProjectStartDate";
            tb_ProjectStartDate.Size = new Size(251, 16);
            tb_ProjectStartDate.TabIndex = 5;
            tb_ProjectStartDate.TabStop = false;
            // 
            // tb_ProjectStatus
            // 
            tb_ProjectStatus.BackColor = SystemColors.ControlLight;
            tb_ProjectStatus.BorderStyle = BorderStyle.None;
            tb_ProjectStatus.Enabled = false;
            tb_ProjectStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectStatus.Location = new Point(88, 101);
            tb_ProjectStatus.Margin = new Padding(2);
            tb_ProjectStatus.Name = "tb_ProjectStatus";
            tb_ProjectStatus.Size = new Size(208, 16);
            tb_ProjectStatus.TabIndex = 4;
            tb_ProjectStatus.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(333, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Project End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(5, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Project Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(326, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "Project Start Date:";
            // 
            // lbl_ReqSkills
            // 
            lbl_ReqSkills.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ReqSkills.AutoSize = true;
            lbl_ReqSkills.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ReqSkills.Location = new Point(424, 136);
            lbl_ReqSkills.Margin = new Padding(2, 0, 2, 0);
            lbl_ReqSkills.Name = "lbl_ReqSkills";
            lbl_ReqSkills.Size = new Size(95, 17);
            lbl_ReqSkills.TabIndex = 104;
            lbl_ReqSkills.Text = "Required Skills";
            // 
            // checkedListSkills
            // 
            checkedListSkills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.BorderStyle = BorderStyle.None;
            checkedListSkills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(372, 156);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(310, 108);
            checkedListSkills.TabIndex = 103;
            // 
            // ConsultantInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 629);
            Controls.Add(grpBoxProfileInfo);
            Controls.Add(groupBox1);
            Name = "ConsultantInvites";
            Text = "ConsultantInvites";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).EndInit();
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button bt_seeInviteDetails;
        private DataGridView dgv_ConsultantsInvites;
        private GroupBox grpBoxProfileInfo;
        private Label label1;
        private RichTextBox rtb_Description;
        private Button bt_EditProfileCancel;
        private Label lb_DaysTilEnd;
        private Button bt_EditProfile;
        private Label label2;
        private TextBox tb_ProjectID;
        private Label label7;
        private TextBox tb_Country;
        private TextBox tb_ProjectTitle;
        private Label label9;
        private TextBox tb_ProjectModifiedDate;
        private Label label8;
        private Label label3;
        private TextBox tb_ProjectEndDate;
        private TextBox tb_ProjectOwner;
        private TextBox tb_ProjectStartDate;
        private TextBox tb_ProjectStatus;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label lbl_ReqSkills;
        private CheckedListBox checkedListSkills;
    }
}