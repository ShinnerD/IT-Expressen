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
            dgv_ConsultantList = new DataGridView();
            lb_ProjectID = new Label();
            lb_UserID = new Label();
            lb_ProjectStatus = new Label();
            lb_ProjectStartDate = new Label();
            lb_ProjectEndDate = new Label();
            lb_ModifyDate = new Label();
            lb_title = new Label();
            lb_Description = new Label();
            label2 = new Label();
            tb_ProjectID = new TextBox();
            tb_Title = new TextBox();
            tb_ProjectStatus = new TextBox();
            tb_Description = new TextBox();
            tb_ProjectStartDate = new TextBox();
            tb_ProjectEndDate = new TextBox();
            tb_ModifyDate = new TextBox();
            tb_UserID = new TextBox();
            bt_AddConsultant = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(12, 312);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(776, 240);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // lb_ProjectID
            // 
            lb_ProjectID.AutoSize = true;
            lb_ProjectID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectID.Location = new Point(12, 46);
            lb_ProjectID.Name = "lb_ProjectID";
            lb_ProjectID.Size = new Size(74, 20);
            lb_ProjectID.TabIndex = 1;
            lb_ProjectID.Text = "Project ID";
            // 
            // lb_UserID
            // 
            lb_UserID.AutoSize = true;
            lb_UserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UserID.Location = new Point(12, 114);
            lb_UserID.Name = "lb_UserID";
            lb_UserID.Size = new Size(57, 20);
            lb_UserID.TabIndex = 3;
            lb_UserID.Text = "User ID";
            // 
            // lb_ProjectStatus
            // 
            lb_ProjectStatus.AutoSize = true;
            lb_ProjectStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStatus.Location = new Point(12, 147);
            lb_ProjectStatus.Name = "lb_ProjectStatus";
            lb_ProjectStatus.Size = new Size(99, 20);
            lb_ProjectStatus.TabIndex = 4;
            lb_ProjectStatus.Text = "Project Status";
            // 
            // lb_ProjectStartDate
            // 
            lb_ProjectStartDate.AutoSize = true;
            lb_ProjectStartDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStartDate.Location = new Point(434, 46);
            lb_ProjectStartDate.Name = "lb_ProjectStartDate";
            lb_ProjectStartDate.Size = new Size(126, 20);
            lb_ProjectStartDate.TabIndex = 5;
            lb_ProjectStartDate.Text = "Project Start Date";
            // 
            // lb_ProjectEndDate
            // 
            lb_ProjectEndDate.AutoSize = true;
            lb_ProjectEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectEndDate.Location = new Point(434, 83);
            lb_ProjectEndDate.Name = "lb_ProjectEndDate";
            lb_ProjectEndDate.Size = new Size(120, 20);
            lb_ProjectEndDate.TabIndex = 6;
            lb_ProjectEndDate.Text = "Project End Date";
            // 
            // lb_ModifyDate
            // 
            lb_ModifyDate.AutoSize = true;
            lb_ModifyDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ModifyDate.Location = new Point(434, 118);
            lb_ModifyDate.Name = "lb_ModifyDate";
            lb_ModifyDate.Size = new Size(150, 20);
            lb_ModifyDate.TabIndex = 7;
            lb_ModifyDate.Text = "Project last Modifyed";
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_title.Location = new Point(12, 82);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(38, 20);
            lb_title.TabIndex = 2;
            lb_title.Text = "Title";
            // 
            // lb_Description
            // 
            lb_Description.AutoSize = true;
            lb_Description.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Description.Location = new Point(12, 179);
            lb_Description.Name = "lb_Description";
            lb_Description.Size = new Size(88, 20);
            lb_Description.TabIndex = 8;
            lb_Description.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(454, 30);
            label2.TabIndex = 9;
            label2.Text = "Invites consultants to be part of your project";
            // 
            // tb_ProjectID
            // 
            tb_ProjectID.Location = new Point(127, 46);
            tb_ProjectID.Name = "tb_ProjectID";
            tb_ProjectID.Size = new Size(199, 23);
            tb_ProjectID.TabIndex = 10;
            // 
            // tb_Title
            // 
            tb_Title.Location = new Point(127, 79);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(199, 23);
            tb_Title.TabIndex = 11;
            // 
            // tb_ProjectStatus
            // 
            tb_ProjectStatus.Location = new Point(127, 147);
            tb_ProjectStatus.Name = "tb_ProjectStatus";
            tb_ProjectStatus.Size = new Size(199, 23);
            tb_ProjectStatus.TabIndex = 12;
            // 
            // tb_Description
            // 
            tb_Description.Location = new Point(12, 202);
            tb_Description.Multiline = true;
            tb_Description.Name = "tb_Description";
            tb_Description.Size = new Size(776, 104);
            tb_Description.TabIndex = 13;
            // 
            // tb_ProjectStartDate
            // 
            tb_ProjectStartDate.Location = new Point(589, 46);
            tb_ProjectStartDate.Name = "tb_ProjectStartDate";
            tb_ProjectStartDate.Size = new Size(199, 23);
            tb_ProjectStartDate.TabIndex = 14;
            // 
            // tb_ProjectEndDate
            // 
            tb_ProjectEndDate.Location = new Point(589, 83);
            tb_ProjectEndDate.Name = "tb_ProjectEndDate";
            tb_ProjectEndDate.Size = new Size(199, 23);
            tb_ProjectEndDate.TabIndex = 15;
            // 
            // tb_ModifyDate
            // 
            tb_ModifyDate.Location = new Point(589, 118);
            tb_ModifyDate.Name = "tb_ModifyDate";
            tb_ModifyDate.Size = new Size(199, 23);
            tb_ModifyDate.TabIndex = 16;
            // 
            // tb_UserID
            // 
            tb_UserID.Location = new Point(127, 111);
            tb_UserID.Name = "tb_UserID";
            tb_UserID.Size = new Size(199, 23);
            tb_UserID.TabIndex = 17;
            // 
            // bt_AddConsultant
            // 
            bt_AddConsultant.Location = new Point(680, 173);
            bt_AddConsultant.Name = "bt_AddConsultant";
            bt_AddConsultant.Size = new Size(108, 23);
            bt_AddConsultant.TabIndex = 18;
            bt_AddConsultant.Text = "Add Consultant";
            bt_AddConsultant.UseVisualStyleBackColor = true;
            bt_AddConsultant.Click += bt_AddConsultant_Click;
            // 
            // InviteConsultants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(bt_AddConsultant);
            Controls.Add(tb_UserID);
            Controls.Add(tb_ModifyDate);
            Controls.Add(tb_ProjectEndDate);
            Controls.Add(tb_ProjectStartDate);
            Controls.Add(tb_Description);
            Controls.Add(tb_ProjectStatus);
            Controls.Add(tb_Title);
            Controls.Add(tb_ProjectID);
            Controls.Add(label2);
            Controls.Add(lb_Description);
            Controls.Add(lb_ModifyDate);
            Controls.Add(lb_ProjectEndDate);
            Controls.Add(lb_ProjectStartDate);
            Controls.Add(lb_ProjectStatus);
            Controls.Add(lb_UserID);
            Controls.Add(lb_title);
            Controls.Add(lb_ProjectID);
            Controls.Add(dgv_ConsultantList);
            Name = "InviteConsultants";
            Text = "InviteConsultants";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Label lb_ProjectID;
        private Label lb_UserID;
        private Label lb_ProjectStatus;
        private Label lb_ProjectStartDate;
        private Label lb_ProjectEndDate;
        private Label lb_ModifyDate;
        private Label lb_title;
        private Label lb_Description;
        private Label label2;
        private TextBox tb_ProjectID;
        private TextBox tb_Title;
        private TextBox tb_ProjectStatus;
        private TextBox tb_Description;
        private TextBox tb_ProjectStartDate;
        private TextBox tb_ProjectEndDate;
        private TextBox tb_ModifyDate;
        private TextBox tb_UserID;
        private Button bt_AddConsultant;
    }
}