namespace GUI
{
    partial class InviteConsultants
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
            dgv_ConsultantList = new DataGridView();
            btn_RemovePendingInvite = new Button();
            grpBoxProfileInfo = new GroupBox();
            label9 = new Label();
            lbl_ReqSkills = new Label();
            checkedListSkills = new CheckedListBox();
            label1 = new Label();
            rtb_Description = new RichTextBox();
            bt_EditProfileCancel = new Button();
            lb_DaysTilEnd = new Label();
            bt_EditProfile = new Button();
            label2 = new Label();
            tb_ProjectID = new TextBox();
            label7 = new Label();
            tb_ProjectTitle = new TextBox();
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
            groupBox1 = new GroupBox();
            lbl_FeedBackLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            grpBoxProfileInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgv_ConsultantList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ConsultantList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ConsultantList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(0, 46);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowHeadersVisible = false;
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantList.Size = new Size(777, 239);
            dgv_ConsultantList.TabIndex = 0;
            dgv_ConsultantList.ColumnHeaderMouseClick += dgv_ConsultantList_ColumnHeaderMouseClick;
            dgv_ConsultantList.DataBindingComplete += dgv_ConsultantList_DataBindingComplete;
            // 
            // btn_RemovePendingInvite
            // 
            btn_RemovePendingInvite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemovePendingInvite.Location = new Point(666, 15);
            btn_RemovePendingInvite.Name = "btn_RemovePendingInvite";
            btn_RemovePendingInvite.Size = new Size(105, 25);
            btn_RemovePendingInvite.TabIndex = 18;
            btn_RemovePendingInvite.Text = "Remove Invite";
            btn_RemovePendingInvite.UseVisualStyleBackColor = true;
            btn_RemovePendingInvite.Click += btn_RemovePendingInvite_Click;
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Controls.Add(label9);
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
            grpBoxProfileInfo.Controls.Add(tb_ProjectTitle);
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
            grpBoxProfileInfo.Size = new Size(777, 271);
            grpBoxProfileInfo.TabIndex = 43;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "Project Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(340, 138);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 106;
            label9.Text = "Specializations";
            // 
            // lbl_ReqSkills
            // 
            lbl_ReqSkills.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ReqSkills.AutoSize = true;
            lbl_ReqSkills.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ReqSkills.Location = new Point(1001, 136);
            lbl_ReqSkills.Margin = new Padding(2, 0, 2, 0);
            lbl_ReqSkills.Name = "lbl_ReqSkills";
            lbl_ReqSkills.Size = new Size(95, 17);
            lbl_ReqSkills.TabIndex = 104;
            lbl_ReqSkills.Text = "Required Skills";
            // 
            // checkedListSkills
            // 
            checkedListSkills.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.BorderStyle = BorderStyle.None;
            checkedListSkills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(434, 138);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(343, 126);
            checkedListSkills.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 102;
            label1.Text = "Description";
            // 
            // rtb_Description
            // 
            rtb_Description.BackColor = SystemColors.ControlLight;
            rtb_Description.BorderStyle = BorderStyle.None;
            rtb_Description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Description.Location = new Point(12, 156);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.ReadOnly = true;
            rtb_Description.Size = new Size(412, 109);
            rtb_Description.TabIndex = 101;
            rtb_Description.Text = "";
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(2238, 126);
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
            lb_DaysTilEnd.Location = new Point(464, 99);
            lb_DaysTilEnd.Name = "lb_DaysTilEnd";
            lb_DaysTilEnd.Size = new Size(137, 17);
            lb_DaysTilEnd.TabIndex = 100;
            lb_DaysTilEnd.Text = "Days until project ends:";
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(2342, 126);
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
            label7.Size = new Size(29, 15);
            label7.TabIndex = 6;
            label7.Text = "Title";
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
            // tb_ProjectModifiedDate
            // 
            tb_ProjectModifiedDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_ProjectModifiedDate.BackColor = SystemColors.ControlLight;
            tb_ProjectModifiedDate.BorderStyle = BorderStyle.None;
            tb_ProjectModifiedDate.Enabled = false;
            tb_ProjectModifiedDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectModifiedDate.Location = new Point(431, 74);
            tb_ProjectModifiedDate.Margin = new Padding(2);
            tb_ProjectModifiedDate.Name = "tb_ProjectModifiedDate";
            tb_ProjectModifiedDate.Size = new Size(342, 16);
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
            label8.Size = new Size(119, 15);
            label8.TabIndex = 7;
            label8.Text = "Project Last Modified";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Owner";
            // 
            // tb_ProjectEndDate
            // 
            tb_ProjectEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_ProjectEndDate.BackColor = SystemColors.ControlLight;
            tb_ProjectEndDate.BorderStyle = BorderStyle.None;
            tb_ProjectEndDate.Enabled = false;
            tb_ProjectEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectEndDate.Location = new Point(431, 48);
            tb_ProjectEndDate.Margin = new Padding(2);
            tb_ProjectEndDate.Name = "tb_ProjectEndDate";
            tb_ProjectEndDate.Size = new Size(342, 16);
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
            tb_ProjectStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_ProjectStartDate.BackColor = SystemColors.ControlLight;
            tb_ProjectStartDate.BorderStyle = BorderStyle.None;
            tb_ProjectStartDate.Enabled = false;
            tb_ProjectStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectStartDate.Location = new Point(431, 22);
            tb_ProjectStartDate.Margin = new Padding(2);
            tb_ProjectStartDate.Name = "tb_ProjectStartDate";
            tb_ProjectStartDate.Size = new Size(342, 16);
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
            label5.Location = new Point(330, 51);
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
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Project Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(326, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 5;
            label6.Text = "Project Start Date";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbl_FeedBackLabel);
            groupBox1.Controls.Add(btn_RemovePendingInvite);
            groupBox1.Controls.Add(dgv_ConsultantList);
            groupBox1.Location = new Point(0, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 286);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Invites";
            // 
            // lbl_FeedBackLabel
            // 
            lbl_FeedBackLabel.AutoSize = true;
            lbl_FeedBackLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FeedBackLabel.Location = new Point(12, 19);
            lbl_FeedBackLabel.Name = "lbl_FeedBackLabel";
            lbl_FeedBackLabel.Size = new Size(166, 15);
            lbl_FeedBackLabel.TabIndex = 19;
            lbl_FeedBackLabel.Text = "Feedback label for messages...";
            lbl_FeedBackLabel.Visible = false;
            // 
            // InviteConsultants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 560);
            Controls.Add(groupBox1);
            Controls.Add(grpBoxProfileInfo);
            MinimumSize = new Size(793, 599);
            Name = "InviteConsultants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invites";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Button btn_RemovePendingInvite;
        private GroupBox grpBoxProfileInfo;
        private Label lbl_ReqSkills;
        private CheckedListBox checkedListSkills;
        private Label label1;
        private RichTextBox rtb_Description;
        private Button bt_EditProfileCancel;
        private Label lb_DaysTilEnd;
        private Button bt_EditProfile;
        private Label label2;
        private TextBox tb_ProjectID;
        private Label label7;
        private TextBox tb_ProjectTitle;
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
        private GroupBox groupBox1;
        private Label label9;
        private Label lbl_FeedBackLabel;
    }
}