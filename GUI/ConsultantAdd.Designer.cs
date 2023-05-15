namespace GUI
{
    partial class ConsultantAdd
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
            components = new System.ComponentModel.Container();
            dgv_ConsultantList = new DataGridView();
            bt_AddConcultant = new Button();
            userServiceBindingSource = new BindingSource(components);
            bt_back = new Button();
            checkedListSkills = new CheckedListBox();
            grpBoxSpecFilter = new GroupBox();
            grpBoxProjectRequirements = new GroupBox();
            listBoxProjectRequirements = new ListBox();
            grpBoxSearchResult = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).BeginInit();
            grpBoxSpecFilter.SuspendLayout();
            grpBoxProjectRequirements.SuspendLayout();
            grpBoxSearchResult.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Dock = DockStyle.Fill;
            dgv_ConsultantList.Location = new Point(3, 19);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(769, 296);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // bt_AddConcultant
            // 
            bt_AddConcultant.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bt_AddConcultant.Location = new Point(12, 474);
            bt_AddConcultant.Name = "bt_AddConcultant";
            bt_AddConcultant.Size = new Size(125, 23);
            bt_AddConcultant.TabIndex = 3;
            bt_AddConcultant.Text = "Invite Consultant";
            bt_AddConcultant.UseVisualStyleBackColor = true;
            bt_AddConcultant.Click += bt_AddConcultant_Click;
            // 
            // userServiceBindingSource
            // 
            userServiceBindingSource.DataSource = typeof(Domain.Services.UserService);
            // 
            // bt_back
            // 
            bt_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_back.Location = new Point(664, 474);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(125, 23);
            bt_back.TabIndex = 5;
            bt_back.Text = "Back";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // checkedListSkills
            // 
            checkedListSkills.BackColor = SystemColors.Control;
            checkedListSkills.CheckOnClick = true;
            checkedListSkills.Dock = DockStyle.Fill;
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(3, 19);
            checkedListSkills.MultiColumn = true;
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(428, 114);
            checkedListSkills.TabIndex = 27;
            // 
            // grpBoxSpecFilter
            // 
            grpBoxSpecFilter.Controls.Add(checkedListSkills);
            grpBoxSpecFilter.Location = new Point(12, 8);
            grpBoxSpecFilter.Name = "grpBoxSpecFilter";
            grpBoxSpecFilter.Size = new Size(434, 136);
            grpBoxSpecFilter.TabIndex = 29;
            grpBoxSpecFilter.TabStop = false;
            grpBoxSpecFilter.Text = "Specialization Search Filter";
            // 
            // grpBoxProjectRequirements
            // 
            grpBoxProjectRequirements.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpBoxProjectRequirements.Controls.Add(listBoxProjectRequirements);
            grpBoxProjectRequirements.Location = new Point(453, 8);
            grpBoxProjectRequirements.Name = "grpBoxProjectRequirements";
            grpBoxProjectRequirements.Size = new Size(337, 136);
            grpBoxProjectRequirements.TabIndex = 30;
            grpBoxProjectRequirements.TabStop = false;
            grpBoxProjectRequirements.Text = "Project Requirements";
            // 
            // listBoxProjectRequirements
            // 
            listBoxProjectRequirements.BackColor = SystemColors.Control;
            listBoxProjectRequirements.BorderStyle = BorderStyle.None;
            listBoxProjectRequirements.Dock = DockStyle.Fill;
            listBoxProjectRequirements.FormattingEnabled = true;
            listBoxProjectRequirements.ItemHeight = 15;
            listBoxProjectRequirements.Location = new Point(3, 19);
            listBoxProjectRequirements.MultiColumn = true;
            listBoxProjectRequirements.Name = "listBoxProjectRequirements";
            listBoxProjectRequirements.SelectionMode = SelectionMode.None;
            listBoxProjectRequirements.Size = new Size(331, 114);
            listBoxProjectRequirements.TabIndex = 0;
            // 
            // grpBoxSearchResult
            // 
            grpBoxSearchResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSearchResult.Controls.Add(dgv_ConsultantList);
            grpBoxSearchResult.Location = new Point(12, 150);
            grpBoxSearchResult.Name = "grpBoxSearchResult";
            grpBoxSearchResult.Size = new Size(775, 318);
            grpBoxSearchResult.TabIndex = 31;
            grpBoxSearchResult.TabStop = false;
            grpBoxSearchResult.Text = "Matching Consultants";
            // 
            // ConsultantAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(grpBoxSearchResult);
            Controls.Add(grpBoxProjectRequirements);
            Controls.Add(grpBoxSpecFilter);
            Controls.Add(bt_back);
            Controls.Add(bt_AddConcultant);
            MinimumSize = new Size(816, 557);
            Name = "ConsultantAdd";
            Text = "ConsultantAdd";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).EndInit();
            grpBoxSpecFilter.ResumeLayout(false);
            grpBoxProjectRequirements.ResumeLayout(false);
            grpBoxSearchResult.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Button bt_AddConcultant;
        private BindingSource userServiceBindingSource;
        private Button bt_back;
        private CheckedListBox checkedListSkills;
        private GroupBox grpBoxSpecFilter;
        private GroupBox grpBoxProjectRequirements;
        private ListBox listBoxProjectRequirements;
        private GroupBox grpBoxSearchResult;
    }
}