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
            button1 = new Button();
            bt_Search = new Button();
            tb_Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).BeginInit();
            SuspendLayout();
            // 
            // dgv_Viewproject
            // 
            dgv_Viewproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Viewproject.Location = new Point(12, 101);
            dgv_Viewproject.Name = "dgv_Viewproject";
            dgv_Viewproject.RowHeadersWidth = 62;
            dgv_Viewproject.RowTemplate.Height = 33;
            dgv_Viewproject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Viewproject.Size = new Size(871, 348);
            dgv_Viewproject.TabIndex = 0;
            dgv_Viewproject.CellContentClick += dgv_Viewproject_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(703, 475);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(180, 38);
            button1.TabIndex = 1;
            button1.Text = "Manage Project";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_Search
            // 
            bt_Search.Location = new Point(156, 32);
            bt_Search.Name = "bt_Search";
            bt_Search.Size = new Size(139, 35);
            bt_Search.TabIndex = 4;
            bt_Search.Text = "Search";
            bt_Search.UseVisualStyleBackColor = true;
            bt_Search.Click += bt_Search_Click;
            // 
            // tb_Search
            // 
            tb_Search.Location = new Point(314, 32);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(301, 31);
            tb_Search.TabIndex = 3;
            // 
            // ViewProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 533);
            Controls.Add(bt_Search);
            Controls.Add(tb_Search);
            Controls.Add(button1);
            Controls.Add(dgv_Viewproject);
            Name = "ViewProjects";
            Text = "ViewProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Viewproject;
        private Button button1;
        private Button bt_Search;
        private TextBox tb_Search;
        private Button button2;
    }
}