namespace GUI
{
    partial class NewProject
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
            lblTitle = new Label();
            txtBoxTitle = new TextBox();
            lblDescription = new Label();
            txtBoxDescription = new TextBox();
            lblStartDate = new Label();
            dTPstartDate = new DateTimePicker();
            dTPendDate = new DateTimePicker();
            lblEndDate = new Label();
            lblSkillsReq = new Label();
            checkedListSkills = new CheckedListBox();
            btnCreateProject = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBoxUserName = new TextBox();
            lblFeedback = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(30, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Project Title";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(134, 28);
            txtBoxTitle.MaxLength = 25;
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(248, 29);
            txtBoxTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(30, 72);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(134, 70);
            txtBoxDescription.MaxLength = 3000;
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(603, 145);
            txtBoxDescription.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartDate.Location = new Point(41, 228);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 21);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date";
            // 
            // dTPstartDate
            // 
            dTPstartDate.Location = new Point(134, 228);
            dTPstartDate.Name = "dTPstartDate";
            dTPstartDate.Size = new Size(200, 23);
            dTPstartDate.TabIndex = 5;
            // 
            // dTPendDate
            // 
            dTPendDate.Location = new Point(134, 264);
            dTPendDate.Name = "dTPendDate";
            dTPendDate.Size = new Size(200, 23);
            dTPendDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndDate.Location = new Point(49, 264);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(75, 21);
            lblEndDate.TabIndex = 8;
            lblEndDate.Text = "End Date";
            // 
            // lblSkillsReq
            // 
            lblSkillsReq.AutoSize = true;
            lblSkillsReq.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkillsReq.Location = new Point(7, 329);
            lblSkillsReq.Name = "lblSkillsReq";
            lblSkillsReq.Size = new Size(117, 21);
            lblSkillsReq.TabIndex = 9;
            lblSkillsReq.Text = "Skills Required";
            // 
            // checkedListSkills
            // 
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(134, 329);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(603, 130);
            checkedListSkills.TabIndex = 11;
            // 
            // btnCreateProject
            // 
            btnCreateProject.Location = new Point(616, 471);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(121, 36);
            btnCreateProject.TabIndex = 12;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(477, 217);
            label1.Name = "label1";
            label1.Size = new Size(233, 17);
            label1.TabIndex = 13;
            label1.Text = "DEVELOPMENT: SLET INDEN RELEASE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(477, 234);
            label2.Name = "label2";
            label2.Size = new Size(260, 17);
            label2.TabIndex = 14;
            label2.Text = "Username (manager) to save project under";
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(477, 262);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(233, 23);
            txtBoxUserName.TabIndex = 15;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.Location = new Point(404, 28);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(140, 21);
            lblFeedback.TabIndex = 16;
            lblFeedback.Text = "Feedback message";
            // 
            // NewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 519);
            Controls.Add(lblFeedback);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblSkillsReq);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxTitle);
            Controls.Add(txtBoxUserName);
            Controls.Add(dTPstartDate);
            Controls.Add(dTPendDate);
            Controls.Add(checkedListSkills);
            Controls.Add(btnCreateProject);
            Name = "NewProject";
            Text = "NewProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtBoxTitle;
        private Label lblDescription;
        private TextBox txtBoxDescription;
        private Label lblStartDate;
        private DateTimePicker dTPstartDate;
        private DateTimePicker dTPendDate;
        private Label lblEndDate;
        private Label lblSkillsReq;
        private CheckedListBox checkedListSkills;
        private Button btnCreateProject;
        private Label label1;
        private Label label2;
        private TextBox txtBoxUserName;
        private Label lblFeedback;
    }
}