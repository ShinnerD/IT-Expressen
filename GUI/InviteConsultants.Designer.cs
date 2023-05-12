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
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(12, 198);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(776, 240);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // lb_ProjectID
            // 
            lb_ProjectID.AutoSize = true;
            lb_ProjectID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectID.Location = new Point(33, 16);
            lb_ProjectID.Name = "lb_ProjectID";
            lb_ProjectID.Size = new Size(70, 20);
            lb_ProjectID.TabIndex = 1;
            lb_ProjectID.Text = "ProjectID";
            // 
            // lb_UserID
            // 
            lb_UserID.AutoSize = true;
            lb_UserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UserID.Location = new Point(33, 56);
            lb_UserID.Name = "lb_UserID";
            lb_UserID.Size = new Size(53, 20);
            lb_UserID.TabIndex = 3;
            lb_UserID.Text = "UserID";
            // 
            // lb_ProjectStatus
            // 
            lb_ProjectStatus.AutoSize = true;
            lb_ProjectStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStatus.Location = new Point(33, 76);
            lb_ProjectStatus.Name = "lb_ProjectStatus";
            lb_ProjectStatus.Size = new Size(95, 20);
            lb_ProjectStatus.TabIndex = 4;
            lb_ProjectStatus.Text = "ProjectStatus";
            // 
            // lb_ProjectStartDate
            // 
            lb_ProjectStartDate.AutoSize = true;
            lb_ProjectStartDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectStartDate.Location = new Point(181, 47);
            lb_ProjectStartDate.Name = "lb_ProjectStartDate";
            lb_ProjectStartDate.Size = new Size(118, 20);
            lb_ProjectStartDate.TabIndex = 5;
            lb_ProjectStartDate.Text = "ProjectStartDate";
            // 
            // lb_ProjectEndDate
            // 
            lb_ProjectEndDate.AutoSize = true;
            lb_ProjectEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProjectEndDate.Location = new Point(181, 67);
            lb_ProjectEndDate.Name = "lb_ProjectEndDate";
            lb_ProjectEndDate.Size = new Size(112, 20);
            lb_ProjectEndDate.TabIndex = 6;
            lb_ProjectEndDate.Text = "ProjectEndDate";
            // 
            // lb_ModifyDate
            // 
            lb_ModifyDate.AutoSize = true;
            lb_ModifyDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ModifyDate.Location = new Point(181, 87);
            lb_ModifyDate.Name = "lb_ModifyDate";
            lb_ModifyDate.Size = new Size(88, 20);
            lb_ModifyDate.TabIndex = 7;
            lb_ModifyDate.Text = "ModifyDate";
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_title.Location = new Point(33, 36);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(38, 20);
            lb_title.TabIndex = 2;
            lb_title.Text = "Title";
            // 
            // lb_Description
            // 
            lb_Description.AutoSize = true;
            lb_Description.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Description.Location = new Point(33, 122);
            lb_Description.Name = "lb_Description";
            lb_Description.Size = new Size(88, 20);
            lb_Description.TabIndex = 8;
            lb_Description.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 142);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // InviteConsultants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}