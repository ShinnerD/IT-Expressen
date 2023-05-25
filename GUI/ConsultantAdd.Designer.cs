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
            btn_Search = new Button();
            lblSearchParamAnyAll = new Label();
            radioBtnAll = new RadioButton();
            radioBtnAny = new RadioButton();
            grpBoxProjectRequirements = new GroupBox();
            checkedListProjReq = new CheckedListBox();
            grpBoxSearchResult = new GroupBox();
            lblFeedback = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).BeginInit();
            grpBoxSpecFilter.SuspendLayout();
            grpBoxProjectRequirements.SuspendLayout();
            grpBoxSearchResult.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.AllowUserToAddRows = false;
            dgv_ConsultantList.AllowUserToDeleteRows = false;
            dgv_ConsultantList.AllowUserToResizeRows = false;
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Dock = DockStyle.Fill;
            dgv_ConsultantList.Location = new Point(3, 19);
            dgv_ConsultantList.MultiSelect = false;
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.ReadOnly = true;
            dgv_ConsultantList.RowHeadersVisible = false;
            dgv_ConsultantList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultantList.Size = new Size(770, 308);
            dgv_ConsultantList.TabIndex = 0;
            dgv_ConsultantList.ColumnHeaderMouseClick += dgv_ConsultantList_ColumnHeaderMouseClick;
            dgv_ConsultantList.DataBindingComplete += dgv_ConsultantList_DataBindingComplete;
            // 
            // bt_AddConcultant
            // 
            bt_AddConcultant.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bt_AddConcultant.Location = new Point(688, 489);
            bt_AddConcultant.Name = "bt_AddConcultant";
            bt_AddConcultant.Size = new Size(100, 25);
            bt_AddConcultant.TabIndex = 3;
            bt_AddConcultant.Text = "Send Invite";
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
            bt_back.Location = new Point(562, 489);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(100, 25);
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
            checkedListSkills.Size = new Size(485, 114);
            checkedListSkills.TabIndex = 27;
            toolTip1.SetToolTip(checkedListSkills, "Here you can push the button of your Specialization.\r\n\r\nIf your Specialization is not here contact admin: Adm@mail.com");
            // 
            // grpBoxSpecFilter
            // 
            grpBoxSpecFilter.Controls.Add(btn_Search);
            grpBoxSpecFilter.Controls.Add(lblSearchParamAnyAll);
            grpBoxSpecFilter.Controls.Add(radioBtnAll);
            grpBoxSpecFilter.Controls.Add(radioBtnAny);
            grpBoxSpecFilter.Controls.Add(checkedListSkills);
            grpBoxSpecFilter.Location = new Point(12, 8);
            grpBoxSpecFilter.Name = "grpBoxSpecFilter";
            grpBoxSpecFilter.Size = new Size(491, 136);
            grpBoxSpecFilter.TabIndex = 29;
            grpBoxSpecFilter.TabStop = false;
            grpBoxSpecFilter.Text = "Specialization Search Filter";
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.Location = new Point(382, 101);
            btn_Search.Margin = new Padding(2);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(100, 25);
            btn_Search.TabIndex = 31;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // lblSearchParamAnyAll
            // 
            lblSearchParamAnyAll.AutoSize = true;
            lblSearchParamAnyAll.Location = new Point(393, 25);
            lblSearchParamAnyAll.Name = "lblSearchParamAnyAll";
            lblSearchParamAnyAll.Size = new Size(81, 15);
            lblSearchParamAnyAll.TabIndex = 30;
            lblSearchParamAnyAll.Text = "Should Match";
            // 
            // radioBtnAll
            // 
            radioBtnAll.AutoSize = true;
            radioBtnAll.Location = new Point(440, 43);
            radioBtnAll.Name = "radioBtnAll";
            radioBtnAll.Size = new Size(39, 19);
            radioBtnAll.TabIndex = 29;
            radioBtnAll.TabStop = true;
            radioBtnAll.Text = "All";
            radioBtnAll.UseVisualStyleBackColor = true;
            // 
            // radioBtnAny
            // 
            radioBtnAny.AutoSize = true;
            radioBtnAny.Checked = true;
            radioBtnAny.Location = new Point(388, 43);
            radioBtnAny.Name = "radioBtnAny";
            radioBtnAny.Size = new Size(46, 19);
            radioBtnAny.TabIndex = 28;
            radioBtnAny.TabStop = true;
            radioBtnAny.Text = "Any";
            radioBtnAny.UseVisualStyleBackColor = true;
            // 
            // grpBoxProjectRequirements
            // 
            grpBoxProjectRequirements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxProjectRequirements.Controls.Add(checkedListProjReq);
            grpBoxProjectRequirements.Location = new Point(509, 8);
            grpBoxProjectRequirements.Name = "grpBoxProjectRequirements";
            grpBoxProjectRequirements.Padding = new Padding(15, 3, 3, 3);
            grpBoxProjectRequirements.Size = new Size(278, 136);
            grpBoxProjectRequirements.TabIndex = 30;
            grpBoxProjectRequirements.TabStop = false;
            grpBoxProjectRequirements.Text = "Project Requirements";
            // 
            // checkedListProjReq
            // 
            checkedListProjReq.BackColor = SystemColors.Control;
            checkedListProjReq.BorderStyle = BorderStyle.None;
            checkedListProjReq.CheckOnClick = true;
            checkedListProjReq.Dock = DockStyle.Fill;
            checkedListProjReq.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListProjReq.FormattingEnabled = true;
            checkedListProjReq.Location = new Point(15, 19);
            checkedListProjReq.MultiColumn = true;
            checkedListProjReq.Name = "checkedListProjReq";
            checkedListProjReq.SelectionMode = SelectionMode.None;
            checkedListProjReq.Size = new Size(260, 114);
            checkedListProjReq.TabIndex = 6;
            checkedListProjReq.TabStop = false;
            // 
            // grpBoxSearchResult
            // 
            grpBoxSearchResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSearchResult.Controls.Add(dgv_ConsultantList);
            grpBoxSearchResult.Location = new Point(12, 147);
            grpBoxSearchResult.Name = "grpBoxSearchResult";
            grpBoxSearchResult.Size = new Size(776, 330);
            grpBoxSearchResult.TabIndex = 31;
            grpBoxSearchResult.TabStop = false;
            grpBoxSearchResult.Text = "Matching Consultants";
            // 
            // lblFeedback
            // 
            lblFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.Location = new Point(12, 494);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(106, 15);
            lblFeedback.TabIndex = 32;
            lblFeedback.Text = "Feedback message";
            // 
            // ConsultantAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            ControlBox = false;
            Controls.Add(lblFeedback);
            Controls.Add(grpBoxSearchResult);
            Controls.Add(grpBoxProjectRequirements);
            Controls.Add(grpBoxSpecFilter);
            Controls.Add(bt_back);
            Controls.Add(bt_AddConcultant);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(816, 557);
            Name = "ConsultantAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultantAdd";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).EndInit();
            grpBoxSpecFilter.ResumeLayout(false);
            grpBoxSpecFilter.PerformLayout();
            grpBoxProjectRequirements.ResumeLayout(false);
            grpBoxSearchResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Button bt_AddConcultant;
        private BindingSource userServiceBindingSource;
        private Button bt_back;
        private CheckedListBox checkedListSkills;
        private GroupBox grpBoxSpecFilter;
        private GroupBox grpBoxProjectRequirements;
        private GroupBox grpBoxSearchResult;
        private RadioButton radioBtnAny;
        private RadioButton radioBtnAll;
        private Label lblSearchParamAnyAll;
        private Label lblFeedback;
        private ToolTip toolTip1;
        private Button btn_Search;
        private CheckedListBox checkedListProjReq;
    }
}