namespace GUI
{
    partial class ConsultantSearchProjects
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
            dgv_Searchproject = new DataGridView();
            checkedListSkills = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Searchproject).BeginInit();
            SuspendLayout();
            // 
            // dgv_Searchproject
            // 
            dgv_Searchproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Searchproject.Location = new Point(30, 185);
            dgv_Searchproject.Margin = new Padding(2);
            dgv_Searchproject.Name = "dgv_Searchproject";
            dgv_Searchproject.RowHeadersWidth = 62;
            dgv_Searchproject.RowTemplate.Height = 33;
            dgv_Searchproject.Size = new Size(458, 207);
            dgv_Searchproject.TabIndex = 0;
            // 
            // checkedListSkills
            // 
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(30, 33);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(615, 130);
            checkedListSkills.TabIndex = 27;
            // 
            // ConsultantSearchProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 503);
            Controls.Add(checkedListSkills);
            Controls.Add(dgv_Searchproject);
            Margin = new Padding(2);
            Name = "ConsultantSearchProjects";
            Text = "ConsultantSearchProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_Searchproject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Searchproject;
        private CheckedListBox checkedListSkills;
    }
}