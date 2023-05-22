namespace GUI.Admin
{
    partial class AdminProjectEdit
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
            NewProjectGrpBox = new GroupBox();
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
            txtBox_ProjectDescription = new TextBox();
            checkedListSkills = new CheckedListBox();
            dtp_NewProjectEndDate = new DateTimePicker();
            dtp_NewProjectStartDate = new DateTimePicker();
            btn_NewProjectSave = new Button();
            btn_NewProjectBack = new Button();
            NewProjectGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // NewProjectGrpBox
            // 
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
            NewProjectGrpBox.Controls.Add(txtBox_ProjectDescription);
            NewProjectGrpBox.Controls.Add(checkedListSkills);
            NewProjectGrpBox.Controls.Add(dtp_NewProjectEndDate);
            NewProjectGrpBox.Controls.Add(dtp_NewProjectStartDate);
            NewProjectGrpBox.Controls.Add(btn_NewProjectSave);
            NewProjectGrpBox.Controls.Add(btn_NewProjectBack);
            NewProjectGrpBox.Dock = DockStyle.Fill;
            NewProjectGrpBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NewProjectGrpBox.Location = new Point(0, 0);
            NewProjectGrpBox.Name = "NewProjectGrpBox";
            NewProjectGrpBox.Size = new Size(772, 483);
            NewProjectGrpBox.TabIndex = 24;
            NewProjectGrpBox.TabStop = false;
            NewProjectGrpBox.Text = "Edit Project";
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
            lbl_StartDate.Location = new Point(511, 32);
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
            lbl_EndDate.Location = new Point(511, 87);
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
            lbl_ReqSkills.Location = new Point(511, 150);
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
            txtBox_ProjectTitle.Size = new Size(469, 22);
            txtBox_ProjectTitle.TabIndex = 1;
            txtBox_ProjectTitle.TabStop = false;
            // 
            // txtBox_ProjectDescription
            // 
            txtBox_ProjectDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_ProjectDescription.BackColor = SystemColors.Window;
            txtBox_ProjectDescription.BorderStyle = BorderStyle.None;
            txtBox_ProjectDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_ProjectDescription.Location = new Point(23, 122);
            txtBox_ProjectDescription.Margin = new Padding(2);
            txtBox_ProjectDescription.Multiline = true;
            txtBox_ProjectDescription.Name = "txtBox_ProjectDescription";
            txtBox_ProjectDescription.PlaceholderText = "Descrition";
            txtBox_ProjectDescription.Size = new Size(469, 318);
            txtBox_ProjectDescription.TabIndex = 2;
            txtBox_ProjectDescription.TabStop = false;
            // 
            // checkedListSkills
            // 
            checkedListSkills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.BorderStyle = BorderStyle.None;
            checkedListSkills.CheckOnClick = true;
            checkedListSkills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(511, 170);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(249, 270);
            checkedListSkills.TabIndex = 5;
            // 
            // dtp_NewProjectEndDate
            // 
            dtp_NewProjectEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_NewProjectEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NewProjectEndDate.Location = new Point(511, 107);
            dtp_NewProjectEndDate.Name = "dtp_NewProjectEndDate";
            dtp_NewProjectEndDate.Size = new Size(249, 25);
            dtp_NewProjectEndDate.TabIndex = 3;
            // 
            // dtp_NewProjectStartDate
            // 
            dtp_NewProjectStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_NewProjectStartDate.CustomFormat = "dd/MM/yy";
            dtp_NewProjectStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NewProjectStartDate.Location = new Point(511, 51);
            dtp_NewProjectStartDate.Name = "dtp_NewProjectStartDate";
            dtp_NewProjectStartDate.Size = new Size(249, 25);
            dtp_NewProjectStartDate.TabIndex = 4;
            // 
            // btn_NewProjectSave
            // 
            btn_NewProjectSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NewProjectSave.Location = new Point(667, 454);
            btn_NewProjectSave.Margin = new Padding(2);
            btn_NewProjectSave.Name = "btn_NewProjectSave";
            btn_NewProjectSave.Size = new Size(100, 25);
            btn_NewProjectSave.TabIndex = 7;
            btn_NewProjectSave.Text = "Save Project";
            btn_NewProjectSave.UseVisualStyleBackColor = true;
            btn_NewProjectSave.Click += btn_NewProjectSave_Click;
            // 
            // btn_NewProjectBack
            // 
            btn_NewProjectBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NewProjectBack.Location = new Point(562, 454);
            btn_NewProjectBack.Name = "btn_NewProjectBack";
            btn_NewProjectBack.Size = new Size(100, 25);
            btn_NewProjectBack.TabIndex = 6;
            btn_NewProjectBack.Text = "Back";
            btn_NewProjectBack.UseVisualStyleBackColor = true;
            btn_NewProjectBack.Click += btn_NewProjectBack_Click;
            // 
            // AdminProjectEdit
            // 
            AcceptButton = btn_NewProjectSave;
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
            Name = "AdminProjectEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProjectEdit";
            NewProjectGrpBox.ResumeLayout(false);
            NewProjectGrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NewProjectGrpBox;
        private Label lbl_FeedBackNewProject;
        private Label lbl_StartDate;
        private Label lbl_EndDate;
        private Label lbl_ReqSkills;
        private TextBox txtBox_ProjectTitle;
        private TextBox txtBox_ProjectDescription;
        private CheckedListBox checkedListSkills;
        private DateTimePicker dtp_NewProjectEndDate;
        private DateTimePicker dtp_NewProjectStartDate;
        private Button btn_NewProjectSave;
        private Button btn_NewProjectBack;
        private Label lbl_ManagerUserName;
        private Label lbl_ManagerFullName;
        private Label lbl_Manager;
        private Label lbl_StatusValue;
        private Label lbl_StatusText;
    }
}