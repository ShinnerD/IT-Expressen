namespace GUI
{
    partial class AcceptInviteForm
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
            tb_UserID = new TextBox();
            tb_ModifyDate = new TextBox();
            tb_ProjectEndDate = new TextBox();
            tb_ProjectStartDate = new TextBox();
            tb_ProjectStatus = new TextBox();
            tb_Title = new TextBox();
            tb_ProjectID = new TextBox();
            lb_ModifyDate = new Label();
            lb_ProjectEndDate = new Label();
            lb_ProjectStartDate = new Label();
            lb_ProjectStatus = new Label();
            lb_UserID = new Label();
            lb_title = new Label();
            lb_ProjectID = new Label();
            tb_Description = new TextBox();
            lb_Description = new Label();
            bt_AcceptInv = new Button();
            bt_decline = new Button();
            cb_Status = new ComboBox();
            lb_test = new Label();
            tb_acceptDate = new TextBox();
            SuspendLayout();
            // 
            // tb_UserID
            // 
            tb_UserID.Location = new Point(127, 177);
            tb_UserID.Name = "tb_UserID";
            tb_UserID.Size = new Size(199, 23);
            tb_UserID.TabIndex = 31;
            // 
            // tb_ModifyDate
            // 
            tb_ModifyDate.Location = new Point(589, 184);
            tb_ModifyDate.Name = "tb_ModifyDate";
            tb_ModifyDate.Size = new Size(199, 23);
            tb_ModifyDate.TabIndex = 30;
            // 
            // tb_ProjectEndDate
            // 
            tb_ProjectEndDate.Location = new Point(589, 149);
            tb_ProjectEndDate.Name = "tb_ProjectEndDate";
            tb_ProjectEndDate.Size = new Size(199, 23);
            tb_ProjectEndDate.TabIndex = 29;
            // 
            // tb_ProjectStartDate
            // 
            tb_ProjectStartDate.Location = new Point(589, 112);
            tb_ProjectStartDate.Name = "tb_ProjectStartDate";
            tb_ProjectStartDate.Size = new Size(199, 23);
            tb_ProjectStartDate.TabIndex = 28;
            // 
            // tb_ProjectStatus
            // 
            tb_ProjectStatus.Location = new Point(127, 213);
            tb_ProjectStatus.Name = "tb_ProjectStatus";
            tb_ProjectStatus.Size = new Size(199, 23);
            tb_ProjectStatus.TabIndex = 27;
            // 
            // tb_Title
            // 
            tb_Title.Location = new Point(127, 145);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(199, 23);
            tb_Title.TabIndex = 26;
            // 
            // tb_ProjectID
            // 
            tb_ProjectID.Location = new Point(127, 112);
            tb_ProjectID.Name = "tb_ProjectID";
            tb_ProjectID.Size = new Size(199, 23);
            tb_ProjectID.TabIndex = 25;
            // 
            // lb_ModifyDate
            // 
            lb_ModifyDate.AutoSize = true;
            lb_ModifyDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ModifyDate.Location = new Point(434, 184);
            lb_ModifyDate.Name = "lb_ModifyDate";
            lb_ModifyDate.Size = new Size(150, 20);
            lb_ModifyDate.TabIndex = 24;
            lb_ModifyDate.Text = "Project last Modifyed";
            // 
            // lb_ProjectEndDate
            // 
            lb_ProjectEndDate.AutoSize = true;
            lb_ProjectEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectEndDate.Location = new Point(434, 149);
            lb_ProjectEndDate.Name = "lb_ProjectEndDate";
            lb_ProjectEndDate.Size = new Size(120, 20);
            lb_ProjectEndDate.TabIndex = 23;
            lb_ProjectEndDate.Text = "Project End Date";
            // 
            // lb_ProjectStartDate
            // 
            lb_ProjectStartDate.AutoSize = true;
            lb_ProjectStartDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStartDate.Location = new Point(434, 112);
            lb_ProjectStartDate.Name = "lb_ProjectStartDate";
            lb_ProjectStartDate.Size = new Size(126, 20);
            lb_ProjectStartDate.TabIndex = 22;
            lb_ProjectStartDate.Text = "Project Start Date";
            // 
            // lb_ProjectStatus
            // 
            lb_ProjectStatus.AutoSize = true;
            lb_ProjectStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStatus.Location = new Point(12, 213);
            lb_ProjectStatus.Name = "lb_ProjectStatus";
            lb_ProjectStatus.Size = new Size(99, 20);
            lb_ProjectStatus.TabIndex = 21;
            lb_ProjectStatus.Text = "Project Status";
            // 
            // lb_UserID
            // 
            lb_UserID.AutoSize = true;
            lb_UserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UserID.Location = new Point(12, 180);
            lb_UserID.Name = "lb_UserID";
            lb_UserID.Size = new Size(57, 20);
            lb_UserID.TabIndex = 20;
            lb_UserID.Text = "User ID";
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_title.Location = new Point(12, 148);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(38, 20);
            lb_title.TabIndex = 19;
            lb_title.Text = "Title";
            // 
            // lb_ProjectID
            // 
            lb_ProjectID.AutoSize = true;
            lb_ProjectID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectID.Location = new Point(12, 112);
            lb_ProjectID.Name = "lb_ProjectID";
            lb_ProjectID.Size = new Size(74, 20);
            lb_ProjectID.TabIndex = 18;
            lb_ProjectID.Text = "Project ID";
            // 
            // tb_Description
            // 
            tb_Description.Location = new Point(12, 277);
            tb_Description.Multiline = true;
            tb_Description.Name = "tb_Description";
            tb_Description.Size = new Size(776, 104);
            tb_Description.TabIndex = 33;
            // 
            // lb_Description
            // 
            lb_Description.AutoSize = true;
            lb_Description.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Description.Location = new Point(12, 254);
            lb_Description.Name = "lb_Description";
            lb_Description.Size = new Size(88, 20);
            lb_Description.TabIndex = 32;
            lb_Description.Text = "Description:";
            // 
            // bt_AcceptInv
            // 
            bt_AcceptInv.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_AcceptInv.Location = new Point(12, 41);
            bt_AcceptInv.Name = "bt_AcceptInv";
            bt_AcceptInv.Size = new Size(358, 40);
            bt_AcceptInv.TabIndex = 34;
            bt_AcceptInv.Text = "Accept";
            bt_AcceptInv.UseVisualStyleBackColor = true;
            bt_AcceptInv.Click += button1_Click;
            // 
            // bt_decline
            // 
            bt_decline.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_decline.Location = new Point(430, 41);
            bt_decline.Name = "bt_decline";
            bt_decline.Size = new Size(358, 40);
            bt_decline.TabIndex = 35;
            bt_decline.Text = "Decline";
            bt_decline.UseVisualStyleBackColor = true;
            bt_decline.Click += bt_decline_Click;
            // 
            // cb_Status
            // 
            cb_Status.FormattingEnabled = true;
            cb_Status.Location = new Point(589, 224);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(121, 23);
            cb_Status.TabIndex = 36;
            // 
            // lb_test
            // 
            lb_test.AutoSize = true;
            lb_test.Location = new Point(117, 15);
            lb_test.Name = "lb_test";
            lb_test.Size = new Size(38, 15);
            lb_test.TabIndex = 37;
            lb_test.Text = "label1";
            // 
            // tb_acceptDate
            // 
            tb_acceptDate.Location = new Point(327, 248);
            tb_acceptDate.Name = "tb_acceptDate";
            tb_acceptDate.Size = new Size(199, 23);
            tb_acceptDate.TabIndex = 38;
            // 
            // AcceptInviteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(tb_acceptDate);
            Controls.Add(lb_test);
            Controls.Add(cb_Status);
            Controls.Add(bt_decline);
            Controls.Add(bt_AcceptInv);
            Controls.Add(tb_Description);
            Controls.Add(lb_Description);
            Controls.Add(tb_UserID);
            Controls.Add(tb_ModifyDate);
            Controls.Add(tb_ProjectEndDate);
            Controls.Add(tb_ProjectStartDate);
            Controls.Add(tb_ProjectStatus);
            Controls.Add(tb_Title);
            Controls.Add(tb_ProjectID);
            Controls.Add(lb_ModifyDate);
            Controls.Add(lb_ProjectEndDate);
            Controls.Add(lb_ProjectStartDate);
            Controls.Add(lb_ProjectStatus);
            Controls.Add(lb_UserID);
            Controls.Add(lb_title);
            Controls.Add(lb_ProjectID);
            Name = "AcceptInviteForm";
            Text = "AcceptInviteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_UserID;
        private TextBox tb_ModifyDate;
        private TextBox tb_ProjectEndDate;
        private TextBox tb_ProjectStartDate;
        private TextBox tb_ProjectStatus;
        private TextBox tb_Title;
        private TextBox tb_ProjectID;
        private Label lb_ModifyDate;
        private Label lb_ProjectEndDate;
        private Label lb_ProjectStartDate;
        private Label lb_ProjectStatus;
        private Label lb_UserID;
        private Label lb_title;
        private Label lb_ProjectID;
        private TextBox tb_Description;
        private Label lb_Description;
        private Button bt_AcceptInv;
        private Button bt_decline;
        private ComboBox cb_Status;
        private Label lb_test;
        private TextBox tb_acceptDate;
    }
}