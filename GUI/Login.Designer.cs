namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_CreateUser = new Button();
            bt_AdminAccess = new Button();
            bt_ConsultantAccess = new Button();
            bt_ManagerAccess = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bt_CreateUser
            // 
            bt_CreateUser.Location = new Point(12, 415);
            bt_CreateUser.Name = "bt_CreateUser";
            bt_CreateUser.Size = new Size(75, 23);
            bt_CreateUser.TabIndex = 0;
            bt_CreateUser.Text = "Create User";
            bt_CreateUser.UseVisualStyleBackColor = true;
            bt_CreateUser.Click += bt_CreateUser_Click;
            // 
            // bt_AdminAccess
            // 
            bt_AdminAccess.Location = new Point(690, 164);
            bt_AdminAccess.Name = "bt_AdminAccess";
            bt_AdminAccess.Size = new Size(75, 23);
            bt_AdminAccess.TabIndex = 1;
            bt_AdminAccess.Text = "Admin";
            bt_AdminAccess.UseVisualStyleBackColor = true;
            bt_AdminAccess.Click += bt_AdminAccess_Click;
            // 
            // bt_ConsultantAccess
            // 
            bt_ConsultantAccess.Location = new Point(690, 193);
            bt_ConsultantAccess.Name = "bt_ConsultantAccess";
            bt_ConsultantAccess.Size = new Size(75, 23);
            bt_ConsultantAccess.TabIndex = 2;
            bt_ConsultantAccess.Text = "Consultant";
            bt_ConsultantAccess.UseVisualStyleBackColor = true;
            bt_ConsultantAccess.Click += bt_ConsultantAccess_Click;
            // 
            // bt_ManagerAccess
            // 
            bt_ManagerAccess.Location = new Point(690, 222);
            bt_ManagerAccess.Name = "bt_ManagerAccess";
            bt_ManagerAccess.Size = new Size(75, 23);
            bt_ManagerAccess.TabIndex = 3;
            bt_ManagerAccess.Text = "Manager";
            bt_ManagerAccess.UseVisualStyleBackColor = true;
            bt_ManagerAccess.Click += bt_ManagerAccess_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(669, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 132);
            label1.TabIndex = 4;
            label1.Text = "MUST BE DELETED BEFORE RELEASE";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(bt_ManagerAccess);
            Controls.Add(bt_ConsultantAccess);
            Controls.Add(bt_AdminAccess);
            Controls.Add(bt_CreateUser);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_CreateUser;
        private Button bt_AdminAccess;
        private Button bt_ConsultantAccess;
        private Button bt_ManagerAccess;
        private Label label1;
    }
}