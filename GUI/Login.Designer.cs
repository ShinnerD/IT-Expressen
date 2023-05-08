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
            tb_UserName = new TextBox();
            tb_Password = new TextBox();
            lb_UserName = new Label();
            lb_Password = new Label();
            pic_ProfilePic = new PictureBox();
            lb_NotAUser = new Label();
            bt_Login = new Button();
            bt_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_ProfilePic).BeginInit();
            SuspendLayout();
            // 
            // bt_CreateUser
            // 
            bt_CreateUser.Location = new Point(330, 340);
            bt_CreateUser.Name = "bt_CreateUser";
            bt_CreateUser.Size = new Size(75, 23);
            bt_CreateUser.TabIndex = 0;
            bt_CreateUser.Text = "Create User";
            bt_CreateUser.UseVisualStyleBackColor = true;
            bt_CreateUser.Click += bt_CreateUser_Click;
            // 
            // bt_AdminAccess
            // 
            bt_AdminAccess.Location = new Point(443, 147);
            bt_AdminAccess.Name = "bt_AdminAccess";
            bt_AdminAccess.Size = new Size(75, 23);
            bt_AdminAccess.TabIndex = 1;
            bt_AdminAccess.Text = "Admin";
            bt_AdminAccess.UseVisualStyleBackColor = true;
            bt_AdminAccess.Click += bt_AdminAccess_Click;
            // 
            // bt_ConsultantAccess
            // 
            bt_ConsultantAccess.Location = new Point(443, 176);
            bt_ConsultantAccess.Name = "bt_ConsultantAccess";
            bt_ConsultantAccess.Size = new Size(75, 23);
            bt_ConsultantAccess.TabIndex = 2;
            bt_ConsultantAccess.Text = "Consultant";
            bt_ConsultantAccess.UseVisualStyleBackColor = true;
            bt_ConsultantAccess.Click += bt_ConsultantAccess_Click;
            // 
            // bt_ManagerAccess
            // 
            bt_ManagerAccess.Location = new Point(443, 205);
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
            label1.Location = new Point(422, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 132);
            label1.TabIndex = 4;
            label1.Text = "MUST BE DELETED BEFORE RELEASE";
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(170, 223);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(235, 23);
            tb_UserName.TabIndex = 5;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(170, 252);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(235, 23);
            tb_Password.TabIndex = 6;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_UserName.Location = new Point(63, 223);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(101, 25);
            lb_UserName.TabIndex = 7;
            lb_UserName.Text = "Username";
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Password.Location = new Point(63, 252);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(97, 25);
            lb_Password.TabIndex = 8;
            lb_Password.Text = "Password";
            // 
            // pic_ProfilePic
            // 
            pic_ProfilePic.Image = Properties.Resources.blank_profile_picture_gca8f6a276_1280;
            pic_ProfilePic.Location = new Point(170, 12);
            pic_ProfilePic.Name = "pic_ProfilePic";
            pic_ProfilePic.Size = new Size(235, 205);
            pic_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ProfilePic.TabIndex = 9;
            pic_ProfilePic.TabStop = false;
            // 
            // lb_NotAUser
            // 
            lb_NotAUser.Location = new Point(170, 307);
            lb_NotAUser.Name = "lb_NotAUser";
            lb_NotAUser.Size = new Size(235, 30);
            lb_NotAUser.TabIndex = 10;
            lb_NotAUser.Text = "Not a user? Click the \"Greate User\" to create your profile";
            // 
            // bt_Login
            // 
            bt_Login.Location = new Point(170, 281);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(95, 23);
            bt_Login.TabIndex = 11;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(310, 281);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(95, 23);
            bt_cancel.TabIndex = 12;
            bt_cancel.Text = "Cancel";
            bt_cancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 392);
            Controls.Add(bt_cancel);
            Controls.Add(bt_Login);
            Controls.Add(lb_NotAUser);
            Controls.Add(pic_ProfilePic);
            Controls.Add(lb_Password);
            Controls.Add(lb_UserName);
            Controls.Add(tb_Password);
            Controls.Add(tb_UserName);
            Controls.Add(label1);
            Controls.Add(bt_ManagerAccess);
            Controls.Add(bt_ConsultantAccess);
            Controls.Add(bt_AdminAccess);
            Controls.Add(bt_CreateUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_ProfilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_CreateUser;
        private Button bt_AdminAccess;
        private Button bt_ConsultantAccess;
        private Button bt_ManagerAccess;
        private Label label1;
        private TextBox tb_UserName;
        private TextBox tb_Password;
        private Label lb_UserName;
        private Label lb_Password;
        private PictureBox pic_ProfilePic;
        private Label lb_NotAUser;
        private Button bt_Login;
        private Button bt_cancel;
    }
}