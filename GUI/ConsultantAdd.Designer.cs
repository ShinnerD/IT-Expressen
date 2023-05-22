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
            this.components = new System.ComponentModel.Container();
            this.dgv_ConsultantList = new System.Windows.Forms.DataGridView();
            this.bt_AddConcultant = new System.Windows.Forms.Button();
            this.userServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_back = new System.Windows.Forms.Button();
            this.checkedListSkills = new System.Windows.Forms.CheckedListBox();
            this.grpBoxSpecFilter = new System.Windows.Forms.GroupBox();
            this.lblSearchParamAnyAll = new System.Windows.Forms.Label();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.radioBtnAny = new System.Windows.Forms.RadioButton();
            this.grpBoxProjectRequirements = new System.Windows.Forms.GroupBox();
            this.listBoxProjectRequirements = new System.Windows.Forms.ListBox();
            this.grpBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultantList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userServiceBindingSource)).BeginInit();
            this.grpBoxSpecFilter.SuspendLayout();
            this.grpBoxProjectRequirements.SuspendLayout();
            this.grpBoxSearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            this.dgv_ConsultantList.AllowUserToAddRows = false;
            this.dgv_ConsultantList.AllowUserToDeleteRows = false;
            this.dgv_ConsultantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ConsultantList.Location = new System.Drawing.Point(3, 19);
            this.dgv_ConsultantList.MultiSelect = false;
            this.dgv_ConsultantList.Name = "dgv_ConsultantList";
            this.dgv_ConsultantList.ReadOnly = true;
            this.dgv_ConsultantList.RowHeadersVisible = false;
            this.dgv_ConsultantList.RowTemplate.Height = 25;
            this.dgv_ConsultantList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConsultantList.Size = new System.Drawing.Size(769, 296);
            this.dgv_ConsultantList.TabIndex = 0;
            // 
            // bt_AddConcultant
            // 
            this.bt_AddConcultant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_AddConcultant.Location = new System.Drawing.Point(12, 474);
            this.bt_AddConcultant.Name = "bt_AddConcultant";
            this.bt_AddConcultant.Size = new System.Drawing.Size(125, 23);
            this.bt_AddConcultant.TabIndex = 3;
            this.bt_AddConcultant.Text = "Invite Consultant";
            this.bt_AddConcultant.UseVisualStyleBackColor = true;
            this.bt_AddConcultant.Click += new System.EventHandler(this.bt_AddConcultant_Click);
            // 
            // userServiceBindingSource
            // 
            this.userServiceBindingSource.DataSource = typeof(Domain.Services.UserService);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_back.Location = new System.Drawing.Point(664, 474);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(125, 23);
            this.bt_back.TabIndex = 5;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // checkedListSkills
            // 
            this.checkedListSkills.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListSkills.CheckOnClick = true;
            this.checkedListSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListSkills.FormattingEnabled = true;
            this.checkedListSkills.Location = new System.Drawing.Point(3, 19);
            this.checkedListSkills.MultiColumn = true;
            this.checkedListSkills.Name = "checkedListSkills";
            this.checkedListSkills.Size = new System.Drawing.Size(428, 114);
            this.checkedListSkills.TabIndex = 27;
            this.toolTip1.SetToolTip(this.checkedListSkills, "Here you can push the button of your Specialization.\r\n\r\nIf your Specialization is" +
        " not here contact admin: Adm@mail.com");
            // 
            // grpBoxSpecFilter
            // 
            this.grpBoxSpecFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSpecFilter.Controls.Add(this.lblSearchParamAnyAll);
            this.grpBoxSpecFilter.Controls.Add(this.radioBtnAll);
            this.grpBoxSpecFilter.Controls.Add(this.radioBtnAny);
            this.grpBoxSpecFilter.Controls.Add(this.checkedListSkills);
            this.grpBoxSpecFilter.Location = new System.Drawing.Point(12, 8);
            this.grpBoxSpecFilter.Name = "grpBoxSpecFilter";
            this.grpBoxSpecFilter.Size = new System.Drawing.Size(434, 136);
            this.grpBoxSpecFilter.TabIndex = 29;
            this.grpBoxSpecFilter.TabStop = false;
            this.grpBoxSpecFilter.Text = "Specialization Search Filter";
            // 
            // lblSearchParamAnyAll
            // 
            this.lblSearchParamAnyAll.AutoSize = true;
            this.lblSearchParamAnyAll.Location = new System.Drawing.Point(326, 87);
            this.lblSearchParamAnyAll.Name = "lblSearchParamAnyAll";
            this.lblSearchParamAnyAll.Size = new System.Drawing.Size(81, 15);
            this.lblSearchParamAnyAll.TabIndex = 30;
            this.lblSearchParamAnyAll.Text = "Should Match";
            // 
            // radioBtnAll
            // 
            this.radioBtnAll.AutoSize = true;
            this.radioBtnAll.Location = new System.Drawing.Point(378, 105);
            this.radioBtnAll.Name = "radioBtnAll";
            this.radioBtnAll.Size = new System.Drawing.Size(39, 19);
            this.radioBtnAll.TabIndex = 29;
            this.radioBtnAll.TabStop = true;
            this.radioBtnAll.Text = "All";
            this.radioBtnAll.UseVisualStyleBackColor = true;
            this.radioBtnAll.Click += new System.EventHandler(this.radioBtnAny_CheckedChanged);
            // 
            // radioBtnAny
            // 
            this.radioBtnAny.AutoSize = true;
            this.radioBtnAny.Checked = true;
            this.radioBtnAny.Location = new System.Drawing.Point(326, 105);
            this.radioBtnAny.Name = "radioBtnAny";
            this.radioBtnAny.Size = new System.Drawing.Size(46, 19);
            this.radioBtnAny.TabIndex = 28;
            this.radioBtnAny.TabStop = true;
            this.radioBtnAny.Text = "Any";
            this.radioBtnAny.UseVisualStyleBackColor = true;
            this.radioBtnAny.Click += new System.EventHandler(this.radioBtnAny_CheckedChanged);
            // 
            // grpBoxProjectRequirements
            // 
            this.grpBoxProjectRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxProjectRequirements.Controls.Add(this.listBoxProjectRequirements);
            this.grpBoxProjectRequirements.Location = new System.Drawing.Point(453, 8);
            this.grpBoxProjectRequirements.Name = "grpBoxProjectRequirements";
            this.grpBoxProjectRequirements.Size = new System.Drawing.Size(337, 136);
            this.grpBoxProjectRequirements.TabIndex = 30;
            this.grpBoxProjectRequirements.TabStop = false;
            this.grpBoxProjectRequirements.Text = "Project Requirements";
            // 
            // listBoxProjectRequirements
            // 
            this.listBoxProjectRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProjectRequirements.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxProjectRequirements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProjectRequirements.FormattingEnabled = true;
            this.listBoxProjectRequirements.ItemHeight = 15;
            this.listBoxProjectRequirements.Location = new System.Drawing.Point(20, 19);
            this.listBoxProjectRequirements.MultiColumn = true;
            this.listBoxProjectRequirements.Name = "listBoxProjectRequirements";
            this.listBoxProjectRequirements.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxProjectRequirements.Size = new System.Drawing.Size(314, 105);
            this.listBoxProjectRequirements.TabIndex = 0;
            // 
            // grpBoxSearchResult
            // 
            this.grpBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSearchResult.Controls.Add(this.dgv_ConsultantList);
            this.grpBoxSearchResult.Location = new System.Drawing.Point(12, 150);
            this.grpBoxSearchResult.Name = "grpBoxSearchResult";
            this.grpBoxSearchResult.Size = new System.Drawing.Size(775, 318);
            this.grpBoxSearchResult.TabIndex = 31;
            this.grpBoxSearchResult.TabStop = false;
            this.grpBoxSearchResult.Text = "Matching Consultants";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedback.Location = new System.Drawing.Point(143, 476);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(140, 21);
            this.lblFeedback.TabIndex = 32;
            this.lblFeedback.Text = "Feedback message";
            // 
            // ConsultantAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.grpBoxSearchResult);
            this.Controls.Add(this.grpBoxProjectRequirements);
            this.Controls.Add(this.grpBoxSpecFilter);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_AddConcultant);
            this.MinimumSize = new System.Drawing.Size(816, 557);
            this.Name = "ConsultantAdd";
            this.Text = "ConsultantAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultantList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userServiceBindingSource)).EndInit();
            this.grpBoxSpecFilter.ResumeLayout(false);
            this.grpBoxSpecFilter.PerformLayout();
            this.grpBoxProjectRequirements.ResumeLayout(false);
            this.grpBoxSearchResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private RadioButton radioBtnAny;
        private RadioButton radioBtnAll;
        private Label lblSearchParamAnyAll;
        private Label lblFeedback;
        private ToolTip toolTip1;
    }
}