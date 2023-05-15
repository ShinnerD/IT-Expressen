namespace GUI
{
    partial class ConsultantViewProjects
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
            dgv_ConsultantViewProjects = new DataGridView();
            tb_Search = new TextBox();
            bt_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantViewProjects).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantViewProjects
            // 
            dgv_ConsultantViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantViewProjects.Location = new Point(12, 124);
            dgv_ConsultantViewProjects.Name = "dgv_ConsultantViewProjects";
            dgv_ConsultantViewProjects.RowHeadersWidth = 62;
            dgv_ConsultantViewProjects.RowTemplate.Height = 33;
            dgv_ConsultantViewProjects.Size = new Size(740, 314);
            dgv_ConsultantViewProjects.TabIndex = 0;
            dgv_ConsultantViewProjects.CellContentClick += dgv_ConsultantVIewProjects_CellContentClick;
            // 
            // tb_Search
            // 
            tb_Search.Location = new Point(253, 55);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(301, 31);
            tb_Search.TabIndex = 1;
            // 
            // bt_Search
            // 
            bt_Search.Location = new Point(95, 55);
            bt_Search.Name = "bt_Search";
            bt_Search.Size = new Size(139, 35);
            bt_Search.TabIndex = 2;
            bt_Search.Text = "Search";
            bt_Search.UseVisualStyleBackColor = true;
            bt_Search.Click += bt_Search_Click;
            // 
            // ConsultantViewProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_Search);
            Controls.Add(tb_Search);
            Controls.Add(dgv_ConsultantViewProjects);
            Name = "ConsultantViewProjects";
            Text = "ConsultantViewProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantViewProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ConsultantViewProjects;
        private TextBox tb_Search;
        private Button bt_Search;
    }
}