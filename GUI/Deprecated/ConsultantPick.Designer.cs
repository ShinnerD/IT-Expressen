namespace GUI
{
    partial class ConsultantPick
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
            bt_SearchFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(12, 115);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(776, 323);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // bt_SearchFilters
            // 
            bt_SearchFilters.Location = new Point(674, 86);
            bt_SearchFilters.Name = "bt_SearchFilters";
            bt_SearchFilters.Size = new Size(114, 23);
            bt_SearchFilters.TabIndex = 1;
            bt_SearchFilters.Text = "Search Filters";
            bt_SearchFilters.UseVisualStyleBackColor = true;
            // 
            // ConsultantPick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_SearchFilters);
            Controls.Add(dgv_ConsultantList);
            Name = "ConsultantPick";
            Text = "ConsultantPick";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Button bt_SearchFilters;
    }
}