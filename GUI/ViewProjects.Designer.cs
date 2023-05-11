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
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).BeginInit();
            SuspendLayout();
            // 
            // dgv_Viewproject
            // 
            dgv_Viewproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Viewproject.Location = new Point(8, 7);
            dgv_Viewproject.Margin = new Padding(2, 2, 2, 2);
            dgv_Viewproject.Name = "dgv_Viewproject";
            dgv_Viewproject.RowHeadersWidth = 62;
            dgv_Viewproject.RowTemplate.Height = 33;
            dgv_Viewproject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Viewproject.Size = new Size(610, 266);
            dgv_Viewproject.TabIndex = 0;
            dgv_Viewproject.CellContentClick += dgv_Viewproject_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(492, 285);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 1;
            button1.Text = "Manage Project";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 320);
            Controls.Add(button1);
            Controls.Add(dgv_Viewproject);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewProjects";
            Text = "ViewProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_Viewproject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Viewproject;
        private Button button1;
    }
}