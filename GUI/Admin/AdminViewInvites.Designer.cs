﻿namespace GUI.Admin
{
    partial class AdminViewInvites
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            NewProjectGrpBox = new GroupBox();
            btn_RemoveInvite = new Button();
            groupBox2 = new GroupBox();
            dgv_AcceptedInvites = new DataGridView();
            groupBox1 = new GroupBox();
            dgv_PendingInvites = new DataGridView();
            lbl_EndDateValue = new Label();
            lbl_StartDateValue = new Label();
            lbl_StatusValue = new Label();
            lbl_StatusText = new Label();
            lbl_ManagerUserName = new Label();
            lbl_ManagerFullName = new Label();
            lbl_Manager = new Label();
            lbl_FeedBackNewProject = new Label();
            lbl_StartDate = new Label();
            lbl_EndDate = new Label();
            lbl_ReqSkills = new Label();
            txtBox_ProjectTitle = new TextBox();
            checkedListSkills = new CheckedListBox();
            btn_AddInviteButton = new Button();
            btn_NewProjectBack = new Button();
            NewProjectGrpBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AcceptedInvites).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PendingInvites).BeginInit();
            SuspendLayout();
            // 
            // NewProjectGrpBox
            // 
            NewProjectGrpBox.Controls.Add(btn_RemoveInvite);
            NewProjectGrpBox.Controls.Add(groupBox2);
            NewProjectGrpBox.Controls.Add(groupBox1);
            NewProjectGrpBox.Controls.Add(lbl_EndDateValue);
            NewProjectGrpBox.Controls.Add(lbl_StartDateValue);
            NewProjectGrpBox.Controls.Add(lbl_StatusValue);
            NewProjectGrpBox.Controls.Add(lbl_StatusText);
            NewProjectGrpBox.Controls.Add(lbl_ManagerUserName);
            NewProjectGrpBox.Controls.Add(lbl_ManagerFullName);
            NewProjectGrpBox.Controls.Add(lbl_Manager);
            NewProjectGrpBox.Controls.Add(lbl_FeedBackNewProject);
            NewProjectGrpBox.Controls.Add(lbl_StartDate);
            NewProjectGrpBox.Controls.Add(lbl_EndDate);
            NewProjectGrpBox.Controls.Add(lbl_ReqSkills);
            NewProjectGrpBox.Controls.Add(txtBox_ProjectTitle);
            NewProjectGrpBox.Controls.Add(checkedListSkills);
            NewProjectGrpBox.Controls.Add(btn_AddInviteButton);
            NewProjectGrpBox.Controls.Add(btn_NewProjectBack);
            NewProjectGrpBox.Dock = DockStyle.Fill;
            NewProjectGrpBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NewProjectGrpBox.Location = new Point(0, 0);
            NewProjectGrpBox.Name = "NewProjectGrpBox";
            NewProjectGrpBox.Size = new Size(772, 483);
            NewProjectGrpBox.TabIndex = 24;
            NewProjectGrpBox.TabStop = false;
            NewProjectGrpBox.Text = "Project Invites";
            // 
            // btn_RemoveInvite
            // 
            btn_RemoveInvite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RemoveInvite.Location = new Point(563, 454);
            btn_RemoveInvite.Margin = new Padding(2);
            btn_RemoveInvite.Name = "btn_RemoveInvite";
            btn_RemoveInvite.Size = new Size(100, 25);
            btn_RemoveInvite.TabIndex = 4;
            btn_RemoveInvite.Text = "Remove Invite";
            btn_RemoveInvite.UseVisualStyleBackColor = true;
            btn_RemoveInvite.Click += btn_RemoveInvite_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_AcceptedInvites);
            groupBox2.Location = new Point(5, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(761, 154);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Accepted";
            // 
            // dgv_AcceptedInvites
            // 
            dgv_AcceptedInvites.AllowUserToAddRows = false;
            dgv_AcceptedInvites.AllowUserToDeleteRows = false;
            dgv_AcceptedInvites.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgv_AcceptedInvites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_AcceptedInvites.BackgroundColor = SystemColors.Control;
            dgv_AcceptedInvites.BorderStyle = BorderStyle.None;
            dgv_AcceptedInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_AcceptedInvites.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_AcceptedInvites.Dock = DockStyle.Fill;
            dgv_AcceptedInvites.Location = new Point(3, 21);
            dgv_AcceptedInvites.MultiSelect = false;
            dgv_AcceptedInvites.Name = "dgv_AcceptedInvites";
            dgv_AcceptedInvites.ReadOnly = true;
            dgv_AcceptedInvites.RowHeadersVisible = false;
            dgv_AcceptedInvites.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_AcceptedInvites.RowTemplate.Height = 25;
            dgv_AcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_AcceptedInvites.Size = new Size(755, 130);
            dgv_AcceptedInvites.StandardTab = true;
            dgv_AcceptedInvites.TabIndex = 2;
            dgv_AcceptedInvites.ColumnHeaderMouseClick += dgv_AcceptedInvites_ColumnHeaderMouseClick;
            dgv_AcceptedInvites.DataBindingComplete += dgv_DataBindingComplete;
            dgv_AcceptedInvites.Click += dgv_AcceptedInvites_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_PendingInvites);
            groupBox1.Location = new Point(6, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 148);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pending";
            // 
            // dgv_PendingInvites
            // 
            dgv_PendingInvites.AllowUserToAddRows = false;
            dgv_PendingInvites.AllowUserToDeleteRows = false;
            dgv_PendingInvites.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dgv_PendingInvites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_PendingInvites.BackgroundColor = SystemColors.Control;
            dgv_PendingInvites.BorderStyle = BorderStyle.None;
            dgv_PendingInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_PendingInvites.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_PendingInvites.Dock = DockStyle.Fill;
            dgv_PendingInvites.Location = new Point(3, 21);
            dgv_PendingInvites.MultiSelect = false;
            dgv_PendingInvites.Name = "dgv_PendingInvites";
            dgv_PendingInvites.ReadOnly = true;
            dgv_PendingInvites.RowHeadersVisible = false;
            dgv_PendingInvites.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_PendingInvites.RowTemplate.Height = 25;
            dgv_PendingInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PendingInvites.Size = new Size(755, 124);
            dgv_PendingInvites.StandardTab = true;
            dgv_PendingInvites.TabIndex = 1;
            dgv_PendingInvites.ColumnHeaderMouseClick += dgv_PendingInvites_ColumnHeaderMouseClick;
            dgv_PendingInvites.DataBindingComplete += dgv_DataBindingComplete;
            dgv_PendingInvites.Click += dgv_PendingInvites_Click;
            // 
            // lbl_EndDateValue
            // 
            lbl_EndDateValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_EndDateValue.AutoSize = true;
            lbl_EndDateValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_EndDateValue.Location = new Point(418, 113);
            lbl_EndDateValue.Margin = new Padding(2, 0, 2, 0);
            lbl_EndDateValue.Name = "lbl_EndDateValue";
            lbl_EndDateValue.Size = new Size(74, 17);
            lbl_EndDateValue.TabIndex = 32;
            lbl_EndDateValue.Text = "13/04/2025";
            // 
            // lbl_StartDateValue
            // 
            lbl_StartDateValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_StartDateValue.AutoSize = true;
            lbl_StartDateValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StartDateValue.Location = new Point(95, 113);
            lbl_StartDateValue.Margin = new Padding(2, 0, 2, 0);
            lbl_StartDateValue.Name = "lbl_StartDateValue";
            lbl_StartDateValue.Size = new Size(74, 17);
            lbl_StartDateValue.TabIndex = 31;
            lbl_StartDateValue.Text = "24/12/2023";
            // 
            // lbl_StatusValue
            // 
            lbl_StatusValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_StatusValue.AutoSize = true;
            lbl_StatusValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StatusValue.ForeColor = Color.Green;
            lbl_StatusValue.Location = new Point(430, 68);
            lbl_StatusValue.Margin = new Padding(2, 0, 2, 0);
            lbl_StatusValue.Name = "lbl_StatusValue";
            lbl_StatusValue.Size = new Size(42, 17);
            lbl_StatusValue.TabIndex = 30;
            lbl_StatusValue.Text = "Active";
            // 
            // lbl_StatusText
            // 
            lbl_StatusText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_StatusText.AutoSize = true;
            lbl_StatusText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StatusText.Location = new Point(380, 68);
            lbl_StatusText.Margin = new Padding(2, 0, 2, 0);
            lbl_StatusText.Name = "lbl_StatusText";
            lbl_StatusText.Size = new Size(46, 17);
            lbl_StatusText.TabIndex = 29;
            lbl_StatusText.Text = "Status:";
            // 
            // lbl_ManagerUserName
            // 
            lbl_ManagerUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ManagerUserName.AutoSize = true;
            lbl_ManagerUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ManagerUserName.Location = new Point(91, 59);
            lbl_ManagerUserName.Margin = new Padding(2, 0, 2, 0);
            lbl_ManagerUserName.Name = "lbl_ManagerUserName";
            lbl_ManagerUserName.Size = new Size(74, 17);
            lbl_ManagerUserName.TabIndex = 28;
            lbl_ManagerUserName.Text = "User Name";
            // 
            // lbl_ManagerFullName
            // 
            lbl_ManagerFullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ManagerFullName.AutoSize = true;
            lbl_ManagerFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ManagerFullName.Location = new Point(91, 32);
            lbl_ManagerFullName.Margin = new Padding(2, 0, 2, 0);
            lbl_ManagerFullName.Name = "lbl_ManagerFullName";
            lbl_ManagerFullName.Size = new Size(66, 17);
            lbl_ManagerFullName.TabIndex = 27;
            lbl_ManagerFullName.Text = "Full Name";
            // 
            // lbl_Manager
            // 
            lbl_Manager.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Manager.AutoSize = true;
            lbl_Manager.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Manager.Location = new Point(23, 32);
            lbl_Manager.Margin = new Padding(2, 0, 2, 0);
            lbl_Manager.Name = "lbl_Manager";
            lbl_Manager.Size = new Size(64, 17);
            lbl_Manager.TabIndex = 26;
            lbl_Manager.Text = "Manager:";
            // 
            // lbl_FeedBackNewProject
            // 
            lbl_FeedBackNewProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FeedBackNewProject.AutoSize = true;
            lbl_FeedBackNewProject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FeedBackNewProject.Location = new Point(12, 459);
            lbl_FeedBackNewProject.Name = "lbl_FeedBackNewProject";
            lbl_FeedBackNewProject.Size = new Size(163, 15);
            lbl_FeedBackNewProject.TabIndex = 16;
            lbl_FeedBackNewProject.Text = "Feedback messages go here...";
            lbl_FeedBackNewProject.Visible = false;
            // 
            // lbl_StartDate
            // 
            lbl_StartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_StartDate.AutoSize = true;
            lbl_StartDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_StartDate.Location = new Point(23, 113);
            lbl_StartDate.Margin = new Padding(2, 0, 2, 0);
            lbl_StartDate.Name = "lbl_StartDate";
            lbl_StartDate.Size = new Size(68, 17);
            lbl_StartDate.TabIndex = 20;
            lbl_StartDate.Text = "Start date";
            // 
            // lbl_EndDate
            // 
            lbl_EndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_EndDate.AutoSize = true;
            lbl_EndDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EndDate.Location = new Point(352, 113);
            lbl_EndDate.Margin = new Padding(2, 0, 2, 0);
            lbl_EndDate.Name = "lbl_EndDate";
            lbl_EndDate.Size = new Size(62, 17);
            lbl_EndDate.TabIndex = 22;
            lbl_EndDate.Text = "End date";
            // 
            // lbl_ReqSkills
            // 
            lbl_ReqSkills.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ReqSkills.AutoSize = true;
            lbl_ReqSkills.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ReqSkills.Location = new Point(511, 32);
            lbl_ReqSkills.Margin = new Padding(2, 0, 2, 0);
            lbl_ReqSkills.Name = "lbl_ReqSkills";
            lbl_ReqSkills.Size = new Size(95, 17);
            lbl_ReqSkills.TabIndex = 25;
            lbl_ReqSkills.Text = "Required Skills";
            // 
            // txtBox_ProjectTitle
            // 
            txtBox_ProjectTitle.BackColor = SystemColors.Window;
            txtBox_ProjectTitle.BorderStyle = BorderStyle.None;
            txtBox_ProjectTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_ProjectTitle.Location = new Point(23, 87);
            txtBox_ProjectTitle.Margin = new Padding(2);
            txtBox_ProjectTitle.MaxLength = 255;
            txtBox_ProjectTitle.Name = "txtBox_ProjectTitle";
            txtBox_ProjectTitle.PlaceholderText = "Title";
            txtBox_ProjectTitle.ReadOnly = true;
            txtBox_ProjectTitle.Size = new Size(469, 22);
            txtBox_ProjectTitle.TabIndex = 1;
            txtBox_ProjectTitle.TabStop = false;
            txtBox_ProjectTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // checkedListSkills
            // 
            checkedListSkills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.BorderStyle = BorderStyle.None;
            checkedListSkills.CheckOnClick = true;
            checkedListSkills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(511, 52);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.SelectionMode = SelectionMode.None;
            checkedListSkills.Size = new Size(249, 90);
            checkedListSkills.TabIndex = 5;
            checkedListSkills.TabStop = false;
            // 
            // btn_AddInviteButton
            // 
            btn_AddInviteButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddInviteButton.Location = new Point(667, 454);
            btn_AddInviteButton.Margin = new Padding(2);
            btn_AddInviteButton.Name = "btn_AddInviteButton";
            btn_AddInviteButton.Size = new Size(100, 25);
            btn_AddInviteButton.TabIndex = 5;
            btn_AddInviteButton.Text = "Add Invite";
            btn_AddInviteButton.UseVisualStyleBackColor = true;
            btn_AddInviteButton.Click += btn_AddInviteButton_Click;
            // 
            // btn_NewProjectBack
            // 
            btn_NewProjectBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NewProjectBack.Location = new Point(430, 454);
            btn_NewProjectBack.Name = "btn_NewProjectBack";
            btn_NewProjectBack.Size = new Size(100, 25);
            btn_NewProjectBack.TabIndex = 3;
            btn_NewProjectBack.Text = "Back";
            btn_NewProjectBack.UseVisualStyleBackColor = true;
            btn_NewProjectBack.Click += btn_NewProjectBack_Click;
            // 
            // AdminViewInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_NewProjectBack;
            ClientSize = new Size(772, 483);
            ControlBox = false;
            Controls.Add(NewProjectGrpBox);
            MaximizeBox = false;
            MaximumSize = new Size(788, 522);
            MinimizeBox = false;
            MinimumSize = new Size(788, 522);
            Name = "AdminViewInvites";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invites";
            NewProjectGrpBox.ResumeLayout(false);
            NewProjectGrpBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_AcceptedInvites).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_PendingInvites).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NewProjectGrpBox;
        private Label lbl_FeedBackNewProject;
        private Label lbl_EndDate;
        private Label lbl_ReqSkills;
        private TextBox txtBox_ProjectTitle;
        private CheckedListBox checkedListSkills;
        private Button btn_AddInviteButton;
        private Button btn_NewProjectBack;
        private Label lbl_ManagerUserName;
        private Label lbl_ManagerFullName;
        private Label lbl_Manager;
        private Label lbl_StatusValue;
        private Label lbl_StatusText;
        private Label lbl_EndDateValue;
        private Label lbl_StartDateValue;
        private Label lbl_StartDate;
        private DataGridView dgv_PendingInvites;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_AcceptedInvites;
        private Button btn_RemoveInvite;
    }
}