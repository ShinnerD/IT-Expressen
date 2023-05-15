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
            bt_filters = new Button();
            bt_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv_ConsultantList
            // 
            dgv_ConsultantList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ConsultantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantList.Location = new Point(12, 123);
            dgv_ConsultantList.Name = "dgv_ConsultantList";
            dgv_ConsultantList.RowTemplate.Height = 25;
            dgv_ConsultantList.Size = new Size(776, 315);
            dgv_ConsultantList.TabIndex = 0;
            // 
            // bt_AddConcultant
            // 
            bt_AddConcultant.Location = new Point(663, 94);
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
            // bt_filters
            // 
            bt_filters.Location = new Point(12, 94);
            bt_filters.Name = "bt_filters";
            bt_filters.Size = new Size(125, 23);
            bt_filters.TabIndex = 4;
            bt_filters.Text = "Apply Filters";
            bt_filters.UseVisualStyleBackColor = true;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(663, 444);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(125, 23);
            bt_back.TabIndex = 5;
            bt_back.Text = "Back";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // ConsultantAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(bt_back);
            Controls.Add(bt_filters);
            Controls.Add(bt_AddConcultant);
            Controls.Add(dgv_ConsultantList);
            Name = "ConsultantAdd";
            Text = "ConsultantAdd";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantList).EndInit();
            ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ConsultantList;
        private Button bt_AddConcultant;
        private BindingSource userServiceBindingSource;
        private Button bt_filters;
        private Button bt_back;
    }
}