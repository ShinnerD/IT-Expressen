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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_Searchproject = new DataGridView();
            checkedListSkills = new CheckedListBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Searchproject).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Searchproject
            // 
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgv_Searchproject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Searchproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Searchproject.Dock = DockStyle.Fill;
            dgv_Searchproject.Location = new Point(3, 19);
            dgv_Searchproject.Margin = new Padding(2);
            dgv_Searchproject.MultiSelect = false;
            dgv_Searchproject.Name = "dgv_Searchproject";
            dgv_Searchproject.ReadOnly = true;
            dgv_Searchproject.RowHeadersVisible = false;
            dgv_Searchproject.RowHeadersWidth = 62;
            dgv_Searchproject.RowTemplate.Height = 33;
            dgv_Searchproject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Searchproject.Size = new Size(776, 437);
            dgv_Searchproject.TabIndex = 0;
            dgv_Searchproject.DataBindingComplete += dgv_Searchproject_DataBindingComplete;
            // 
            // checkedListSkills
            // 
            checkedListSkills.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.BorderStyle = BorderStyle.None;
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(6, 17);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(769, 72);
            checkedListSkills.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(673, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 26);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "SearchProject";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgv_Searchproject);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 459);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Results";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(checkedListSkills);
            groupBox2.Location = new Point(3, 461);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(779, 98);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Parameters";
            // 
            // ConsultantSearchProjects
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 600);
            Name = "ConsultantSearchProjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultantSearchProjects";
            ((System.ComponentModel.ISupportInitialize)dgv_Searchproject).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Searchproject;
        private CheckedListBox checkedListSkills;
        private Button btnSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}