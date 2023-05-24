namespace GUI
{
    partial class EditProject
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
            lblFeedback = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblSkillsReq = new Label();
            txtBoxDescription = new TextBox();
            txtBoxTitle = new TextBox();
            dTPstartDate = new DateTimePicker();
            dTPendDate = new DateTimePicker();
            checkedListSkills = new CheckedListBox();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.Location = new Point(416, 27);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(140, 21);
            lblFeedback.TabIndex = 31;
            lblFeedback.Text = "Feedback message";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(42, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 21);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Project Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(42, 71);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 19;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartDate.Location = new Point(53, 227);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 21);
            lblStartDate.TabIndex = 21;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndDate.Location = new Point(61, 263);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(75, 21);
            lblEndDate.TabIndex = 24;
            lblEndDate.Text = "End Date";
            // 
            // lblSkillsReq
            // 
            lblSkillsReq.AutoSize = true;
            lblSkillsReq.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkillsReq.Location = new Point(19, 328);
            lblSkillsReq.Name = "lblSkillsReq";
            lblSkillsReq.Size = new Size(117, 21);
            lblSkillsReq.TabIndex = 25;
            lblSkillsReq.Text = "Skills Required";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(146, 69);
            txtBoxDescription.MaxLength = 3000;
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(615, 145);
            txtBoxDescription.TabIndex = 20;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(146, 27);
            txtBoxTitle.MaxLength = 25;
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(260, 29);
            txtBoxTitle.TabIndex = 18;
            // 
            // dTPstartDate
            // 
            dTPstartDate.Location = new Point(146, 227);
            dTPstartDate.Name = "dTPstartDate";
            dTPstartDate.Size = new Size(212, 23);
            dTPstartDate.TabIndex = 22;
            // 
            // dTPendDate
            // 
            dTPendDate.Location = new Point(146, 263);
            dTPendDate.Name = "dTPendDate";
            dTPendDate.Size = new Size(212, 23);
            dTPendDate.TabIndex = 23;
            // 
            // checkedListSkills
            // 
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(146, 328);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(615, 130);
            checkedListSkills.TabIndex = 26;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(628, 470);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(133, 36);
            btnSaveChanges.TabIndex = 27;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(465, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 36);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 541);
            Controls.Add(btnCancel);
            Controls.Add(lblFeedback);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblSkillsReq);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxTitle);
            Controls.Add(dTPstartDate);
            Controls.Add(dTPendDate);
            Controls.Add(checkedListSkills);
            Controls.Add(btnSaveChanges);
            Name = "EditProject";
            Text = "EditProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFeedback;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblSkillsReq;
        private TextBox txtBoxDescription;
        private TextBox txtBoxTitle;
        private DateTimePicker dTPstartDate;
        private DateTimePicker dTPendDate;
        private CheckedListBox checkedListSkills;
        private Button btnSaveChanges;
        private Button btnCancel;
    }
}