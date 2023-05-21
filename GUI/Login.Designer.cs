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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_CreateUser = new System.Windows.Forms.Button();
            this.bt_AdminAccess = new System.Windows.Forms.Button();
            this.bt_ConsultantAccess = new System.Windows.Forms.Button();
            this.bt_ManagerAccess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.pic_ProfilePic = new System.Windows.Forms.PictureBox();
            this.lb_NotAUser = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.lb_connectionTest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_ConnectionStatus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.img_RedGreen = new System.Windows.Forms.ImageList(this.components);
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_CreateUser
            // 
            this.bt_CreateUser.Location = new System.Drawing.Point(310, 316);
            this.bt_CreateUser.Name = "bt_CreateUser";
            this.bt_CreateUser.Size = new System.Drawing.Size(95, 23);
            this.bt_CreateUser.TabIndex = 0;
            this.bt_CreateUser.Text = "Create User";
            this.bt_CreateUser.UseVisualStyleBackColor = true;
            // 
            // bt_AdminAccess
            // 
            this.bt_AdminAccess.Location = new System.Drawing.Point(443, 147);
            this.bt_AdminAccess.Name = "bt_AdminAccess";
            this.bt_AdminAccess.Size = new System.Drawing.Size(75, 23);
            this.bt_AdminAccess.TabIndex = 1;
            this.bt_AdminAccess.Text = "Admin";
            this.bt_AdminAccess.UseVisualStyleBackColor = true;
            // 
            // bt_ConsultantAccess
            // 
            this.bt_ConsultantAccess.Location = new System.Drawing.Point(443, 176);
            this.bt_ConsultantAccess.Name = "bt_ConsultantAccess";
            this.bt_ConsultantAccess.Size = new System.Drawing.Size(75, 23);
            this.bt_ConsultantAccess.TabIndex = 2;
            this.bt_ConsultantAccess.Text = "Consultant";
            this.bt_ConsultantAccess.UseVisualStyleBackColor = true;
            // 
            // bt_ManagerAccess
            // 
            this.bt_ManagerAccess.Location = new System.Drawing.Point(443, 205);
            this.bt_ManagerAccess.Name = "bt_ManagerAccess";
            this.bt_ManagerAccess.Size = new System.Drawing.Size(75, 23);
            this.bt_ManagerAccess.TabIndex = 3;
            this.bt_ManagerAccess.Text = "Manager";
            this.bt_ManagerAccess.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(422, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 132);
            this.label1.TabIndex = 4;
            this.label1.Text = "MUST BE DELETED BEFORE RELEASE";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(170, 223);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(235, 23);
            this.tb_UserName.TabIndex = 5;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(170, 252);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(235, 23);
            this.tb_Password.TabIndex = 6;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_UserName.Location = new System.Drawing.Point(63, 223);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(101, 25);
            this.lb_UserName.TabIndex = 7;
            this.lb_UserName.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Password.Location = new System.Drawing.Point(63, 252);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(97, 25);
            this.lb_Password.TabIndex = 8;
            this.lb_Password.Text = "Password";
            // 
            // pic_ProfilePic
            // 
            this.pic_ProfilePic.Image = global::GUI.Properties.Resources.blank_profile_picture_gca8f6a276_1280;
            this.pic_ProfilePic.Location = new System.Drawing.Point(170, 12);
            this.pic_ProfilePic.Name = "pic_ProfilePic";
            this.pic_ProfilePic.Size = new System.Drawing.Size(235, 205);
            this.pic_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ProfilePic.TabIndex = 9;
            this.pic_ProfilePic.TabStop = false;
            // 
            // lb_NotAUser
            // 
            this.lb_NotAUser.Location = new System.Drawing.Point(170, 316);
            this.lb_NotAUser.Name = "lb_NotAUser";
            this.lb_NotAUser.Size = new System.Drawing.Size(131, 56);
            this.lb_NotAUser.TabIndex = 10;
            this.lb_NotAUser.Text = "Not a user? Click the \"Greate User\" to create your profile";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(170, 281);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(95, 23);
            this.bt_Login.TabIndex = 11;
            this.bt_Login.Text = "Login";
            this.toolTip1.SetToolTip(this.bt_Login, "Login button will get you into your account ");
            this.bt_Login.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(310, 281);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(95, 23);
            this.bt_cancel.TabIndex = 12;
            this.bt_cancel.Text = "Cancel";
            this.toolTip2.SetToolTip(this.bt_cancel, "Will close the program.");
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // lb_connectionTest
            // 
            this.lb_connectionTest.Location = new System.Drawing.Point(377, 14);
            this.lb_connectionTest.Name = "lb_connectionTest";
            this.lb_connectionTest.Size = new System.Drawing.Size(99, 15);
            this.lb_connectionTest.TabIndex = 13;
            this.lb_connectionTest.Text = "Please wait....";
            this.lb_connectionTest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_ConnectionStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_connectionTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 35);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Status";
            // 
            // pb_ConnectionStatus
            // 
            this.pb_ConnectionStatus.Image = global::GUI.Properties.Resources.Red_Circle;
            this.pb_ConnectionStatus.Location = new System.Drawing.Point(482, 14);
            this.pb_ConnectionStatus.Name = "pb_ConnectionStatus";
            this.pb_ConnectionStatus.Size = new System.Drawing.Size(18, 15);
            this.pb_ConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ConnectionStatus.TabIndex = 16;
            this.pb_ConnectionStatus.TabStop = false;
            this.toolTip3.SetToolTip(this.pb_ConnectionStatus, "Show your connection too the database.\r\n\r\nIf Red then no connection\r\n\r\nif green y" +
        "ou have a connection\r\n\r\nContact admin if you can\'t connect: Adm@mail.com\r\n");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(167, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Checking connection to databebase";
            // 
            // img_RedGreen
            // 
            this.img_RedGreen.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.img_RedGreen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_RedGreen.ImageStream")));
            this.img_RedGreen.TransparentColor = System.Drawing.Color.Transparent;
            this.img_RedGreen.Images.SetKeyName(0, "Red.png");
            this.img_RedGreen.Images.SetKeyName(1, "green-check-transparent-background-21.png");
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.lb_NotAUser);
            this.Controls.Add(this.pic_ProfilePic);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ManagerAccess);
            this.Controls.Add(this.bt_ConsultantAccess);
            this.Controls.Add(this.bt_AdminAccess);
            this.Controls.Add(this.bt_CreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lb_connectionTest;
        private GroupBox groupBox1;
        private PictureBox pb_ConnectionStatus;
        private Label label2;
        private ImageList img_RedGreen;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
    }
}