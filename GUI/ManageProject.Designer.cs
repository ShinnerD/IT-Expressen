namespace GUI
{
    partial class ManageProject
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
            cb_UnlockRate = new CheckBox();
            bt_addHours = new Button();
            tb_HoursSpendt = new TextBox();
            lb_HoursSpendt = new Label();
            tb_HourlyRate = new TextBox();
            lb_HourlyRate = new Label();
            label1 = new Label();
            rtb_Description = new RichTextBox();
            bt_EditProfileCancel = new Button();
            lb_DaysTilEnd = new Label();
            bt_EditProfile = new Button();
            label2 = new Label();
            tb_ProjectID = new TextBox();
            label7 = new Label();
            tb_TotalInvoice = new TextBox();
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
            rtb_Message = new RichTextBox();
            rtb_newMessage = new RichTextBox();
            bt_send = new Button();
            lb_TextCounter = new Label();
            dgv_InvolvedUsers = new DataGridView();
            lb_warning = new Label();
            grpBoxProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_InvolvedUsers).BeginInit();
            SuspendLayout();
            // 
            // grpBoxProfileInfo
            // 
            grpBoxProfileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxProfileInfo.Controls.Add(cb_UnlockRate);
            grpBoxProfileInfo.Controls.Add(bt_addHours);
            grpBoxProfileInfo.Controls.Add(tb_HoursSpendt);
            grpBoxProfileInfo.Controls.Add(lb_HoursSpendt);
            grpBoxProfileInfo.Controls.Add(tb_HourlyRate);
            grpBoxProfileInfo.Controls.Add(lb_HourlyRate);
            grpBoxProfileInfo.Controls.Add(label1);
            grpBoxProfileInfo.Controls.Add(rtb_Description);
            grpBoxProfileInfo.Controls.Add(bt_EditProfileCancel);
            grpBoxProfileInfo.Controls.Add(lb_DaysTilEnd);
            grpBoxProfileInfo.Controls.Add(bt_EditProfile);
            grpBoxProfileInfo.Controls.Add(label2);
            grpBoxProfileInfo.Controls.Add(tb_ProjectID);
            grpBoxProfileInfo.Controls.Add(label7);
            grpBoxProfileInfo.Controls.Add(tb_TotalInvoice);
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
            grpBoxProfileInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxProfileInfo.Location = new Point(0, 0);
            grpBoxProfileInfo.Name = "grpBoxProfileInfo";
            grpBoxProfileInfo.Size = new Size(957, 193);
            grpBoxProfileInfo.TabIndex = 23;
            grpBoxProfileInfo.TabStop = false;
            grpBoxProfileInfo.Text = "User Name";
            // 
            // cb_UnlockRate
            // 
            cb_UnlockRate.AutoSize = true;
            cb_UnlockRate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_UnlockRate.Location = new Point(88, 174);
            cb_UnlockRate.Name = "cb_UnlockRate";
            cb_UnlockRate.Size = new Size(128, 19);
            cb_UnlockRate.TabIndex = 108;
            cb_UnlockRate.Text = "Unlock Hourly Rate";
            cb_UnlockRate.UseVisualStyleBackColor = true;
            cb_UnlockRate.Visible = false;
            cb_UnlockRate.CheckedChanged += cb_UnlockRate_CheckedChanged;
            // 
            // bt_addHours
            // 
            bt_addHours.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_addHours.Location = new Point(564, 170);
            bt_addHours.Name = "bt_addHours";
            bt_addHours.Size = new Size(110, 23);
            bt_addHours.TabIndex = 107;
            bt_addHours.Text = "Submit To Invoice";
            bt_addHours.UseVisualStyleBackColor = true;
            bt_addHours.Visible = false;
            bt_addHours.Click += bt_addHours_Click;
            // 
            // tb_HoursSpendt
            // 
            tb_HoursSpendt.BackColor = SystemColors.ControlLight;
            tb_HoursSpendt.BorderStyle = BorderStyle.None;
            tb_HoursSpendt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HoursSpendt.Location = new Point(423, 149);
            tb_HoursSpendt.Margin = new Padding(2);
            tb_HoursSpendt.Name = "tb_HoursSpendt";
            tb_HoursSpendt.Size = new Size(251, 16);
            tb_HoursSpendt.TabIndex = 105;
            tb_HoursSpendt.TabStop = false;
            tb_HoursSpendt.Visible = false;
            // 
            // lb_HoursSpendt
            // 
            lb_HoursSpendt.AutoSize = true;
            lb_HoursSpendt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_HoursSpendt.Location = new Point(338, 150);
            lb_HoursSpendt.Margin = new Padding(2, 0, 2, 0);
            lb_HoursSpendt.Name = "lb_HoursSpendt";
            lb_HoursSpendt.Size = new Size(81, 15);
            lb_HoursSpendt.TabIndex = 106;
            lb_HoursSpendt.Text = "Hours spendt:";
            lb_HoursSpendt.Visible = false;
            // 
            // tb_HourlyRate
            // 
            tb_HourlyRate.BackColor = SystemColors.ControlLight;
            tb_HourlyRate.BorderStyle = BorderStyle.None;
            tb_HourlyRate.Enabled = false;
            tb_HourlyRate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HourlyRate.Location = new Point(88, 149);
            tb_HourlyRate.Margin = new Padding(2);
            tb_HourlyRate.Name = "tb_HourlyRate";
            tb_HourlyRate.Size = new Size(208, 16);
            tb_HourlyRate.TabIndex = 104;
            tb_HourlyRate.TabStop = false;
            tb_HourlyRate.Visible = false;
            // 
            // lb_HourlyRate
            // 
            lb_HourlyRate.AutoSize = true;
            lb_HourlyRate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_HourlyRate.Location = new Point(5, 149);
            lb_HourlyRate.Margin = new Padding(2, 0, 2, 0);
            lb_HourlyRate.Name = "lb_HourlyRate";
            lb_HourlyRate.Size = new Size(69, 15);
            lb_HourlyRate.TabIndex = 103;
            lb_HourlyRate.Text = "Hourly rate:";
            lb_HourlyRate.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(678, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 102;
            label1.Text = "Description:";
            // 
            // rtb_Description
            // 
            rtb_Description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtb_Description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Description.Location = new Point(680, 48);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.ReadOnly = true;
            rtb_Description.Size = new Size(265, 145);
            rtb_Description.TabIndex = 101;
            rtb_Description.Text = "";
            // 
            // bt_EditProfileCancel
            // 
            bt_EditProfileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfileCancel.Location = new Point(1237, 126);
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
            lb_DaysTilEnd.Location = new Point(257, 173);
            lb_DaysTilEnd.Name = "lb_DaysTilEnd";
            lb_DaysTilEnd.Size = new Size(186, 17);
            lb_DaysTilEnd.TabIndex = 100;
            lb_DaysTilEnd.Text = "You've been a user for 154 days";
            // 
            // bt_EditProfile
            // 
            bt_EditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_EditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_EditProfile.Location = new Point(1341, 126);
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
            // tb_TotalInvoice
            // 
            tb_TotalInvoice.BackColor = SystemColors.ControlLight;
            tb_TotalInvoice.BorderStyle = BorderStyle.None;
            tb_TotalInvoice.Enabled = false;
            tb_TotalInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TotalInvoice.Location = new Point(423, 101);
            tb_TotalInvoice.Margin = new Padding(2);
            tb_TotalInvoice.Name = "tb_TotalInvoice";
            tb_TotalInvoice.Size = new Size(251, 16);
            tb_TotalInvoice.TabIndex = 8;
            tb_TotalInvoice.TabStop = false;
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
            label9.Location = new Point(336, 102);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 8;
            label9.Text = "Total invoiced:";
            // 
            // tb_ProjectModifiedDate
            // 
            tb_ProjectModifiedDate.BackColor = SystemColors.ControlLight;
            tb_ProjectModifiedDate.BorderStyle = BorderStyle.None;
            tb_ProjectModifiedDate.Enabled = false;
            tb_ProjectModifiedDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ProjectModifiedDate.Location = new Point(423, 74);
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
            label8.Location = new Point(297, 77);
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
            tb_ProjectEndDate.Location = new Point(423, 48);
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
            tb_ProjectStartDate.Location = new Point(423, 22);
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
            label5.Location = new Point(325, 51);
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
            label6.Location = new Point(318, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "Project Start Date:";
            // 
            // rtb_Message
            // 
            rtb_Message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rtb_Message.Location = new Point(26, 199);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.ReadOnly = true;
            rtb_Message.Size = new Size(648, 189);
            rtb_Message.TabIndex = 24;
            rtb_Message.Text = "";
            // 
            // rtb_newMessage
            // 
            rtb_newMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rtb_newMessage.Location = new Point(26, 394);
            rtb_newMessage.Name = "rtb_newMessage";
            rtb_newMessage.Size = new Size(648, 96);
            rtb_newMessage.TabIndex = 25;
            rtb_newMessage.Text = "";
            rtb_newMessage.TextChanged += rtb_newMessage_TextChanged;
            // 
            // bt_send
            // 
            bt_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bt_send.Location = new Point(599, 504);
            bt_send.Name = "bt_send";
            bt_send.Size = new Size(75, 23);
            bt_send.TabIndex = 26;
            bt_send.Text = "Send";
            bt_send.UseVisualStyleBackColor = true;
            bt_send.Click += bt_send_Click;
            // 
            // lb_TextCounter
            // 
            lb_TextCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_TextCounter.BackColor = SystemColors.Window;
            lb_TextCounter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TextCounter.Location = new Point(599, 472);
            lb_TextCounter.Name = "lb_TextCounter";
            lb_TextCounter.Size = new Size(72, 15);
            lb_TextCounter.TabIndex = 27;
            lb_TextCounter.Text = "0/255";
            lb_TextCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgv_InvolvedUsers
            // 
            dgv_InvolvedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_InvolvedUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_InvolvedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InvolvedUsers.Location = new Point(680, 199);
            dgv_InvolvedUsers.Name = "dgv_InvolvedUsers";
            dgv_InvolvedUsers.RowHeadersVisible = false;
            dgv_InvolvedUsers.RowTemplate.Height = 25;
            dgv_InvolvedUsers.Size = new Size(265, 328);
            dgv_InvolvedUsers.TabIndex = 28;
            // 
            // lb_warning
            // 
            lb_warning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_warning.AutoSize = true;
            lb_warning.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_warning.Location = new Point(285, 506);
            lb_warning.Margin = new Padding(2, 0, 2, 0);
            lb_warning.Name = "lb_warning";
            lb_warning.Size = new Size(309, 17);
            lb_warning.TabIndex = 29;
            lb_warning.Text = "A message can be no longer then 255 characters!";
            lb_warning.Visible = false;
            // 
            // ManageProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 539);
            Controls.Add(lb_warning);
            Controls.Add(dgv_InvolvedUsers);
            Controls.Add(lb_TextCounter);
            Controls.Add(bt_send);
            Controls.Add(rtb_newMessage);
            Controls.Add(rtb_Message);
            Controls.Add(grpBoxProfileInfo);
            MinimumSize = new Size(973, 578);
            Name = "ManageProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProject";
            TransparencyKey = Color.FromArgb(64, 64, 0);
            grpBoxProfileInfo.ResumeLayout(false);
            grpBoxProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_InvolvedUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBoxProfileInfo;
        private Button bt_EditProfileCancel;
        private Label lb_DaysTilEnd;
        private Button bt_EditProfile;
        private Label label2;
        private TextBox tb_ProjectID;
        private Label label7;
        private TextBox tb_TotalInvoice;
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
        private RichTextBox rtb_Message;
        private RichTextBox rtb_newMessage;
        private Button bt_send;
        private Label lb_TextCounter;
        private DataGridView dgv_InvolvedUsers;
        private RichTextBox rtb_Description;
        private Label label1;
        private Label lb_warning;
        private CheckBox cb_UnlockRate;
        private Button bt_addHours;
        private TextBox tb_HoursSpendt;
        private Label lb_HoursSpendt;
        private TextBox tb_HourlyRate;
        private Label lb_HourlyRate;
    }
}