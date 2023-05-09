namespace GUI
{
    partial class ViewProjects
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
            dgv_Viewproject = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).BeginInit();
            SuspendLayout();
            // 
            // dgv_Viewproject
            // 
            dgv_Viewproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Viewproject.Location = new Point(12, 12);
            dgv_Viewproject.Name = "dgv_Viewproject";
            dgv_Viewproject.RowHeadersWidth = 62;
            dgv_Viewproject.RowTemplate.Height = 33;
            dgv_Viewproject.Size = new Size(840, 444);
            dgv_Viewproject.TabIndex = 0;
            dgv_Viewproject.CellContentClick += dgv_Viewproject_CellContentClick;
            // 
            // ViewProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 533);
            Controls.Add(dgv_Viewproject);
            Name = "ViewProjects";
            Text = "ViewProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Viewproject;
    }
}