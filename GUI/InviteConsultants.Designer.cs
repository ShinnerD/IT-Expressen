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
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(12, 23);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(776, 240);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // InviteConsultants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_ConsultantList);
            Name = "InviteConsultants";
            Text = "InviteConsultants";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ConsultantList;
    }
}