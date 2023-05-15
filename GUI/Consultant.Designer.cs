namespace GUI
{
    partial class Consultant
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
            bt_ViewProjects = new Button();
            tb_Country = new TextBox();
            tb_Zipcode = new TextBox();
            tb_City = new TextBox();
            tb_Address = new TextBox();
            tb_Lastname = new TextBox();
            tb_Phonenumber = new TextBox();
            tb_Email = new TextBox();
            tb_Firstname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bt_SearchProjects = new Button();
            dgv_ConsultantsInvites = new DataGridView();
            label10 = new Label();
            bt_seeInviteDetails = new Button();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ViewProjects
            // 
            bt_ViewProjects.Location = new Point(23, 193);
            bt_ViewProjects.Margin = new Padding(2);
            bt_ViewProjects.Name = "bt_ViewProjects";
            bt_ViewProjects.Size = new Size(94, 29);
            bt_ViewProjects.TabIndex = 35;
            bt_ViewProjects.Text = "ViewProjects";
            bt_ViewProjects.UseVisualStyleBackColor = true;
            bt_ViewProjects.Click += bt_ViewProjects_Click;
            // 
            // tb_Country
            // 
            tb_Country.Location = new Point(433, 112);
            tb_Country.Margin = new Padding(2);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(163, 23);
            tb_Country.TabIndex = 34;
            // 
            // tb_Zipcode
            // 
            tb_Zipcode.Location = new Point(102, 114);
            tb_Zipcode.Margin = new Padding(2);
            tb_Zipcode.Name = "tb_Zipcode";
            tb_Zipcode.Size = new Size(163, 23);
            tb_Zipcode.TabIndex = 33;
            // 
            // tb_City
            // 
            tb_City.Location = new Point(102, 80);
            tb_City.Margin = new Padding(2);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(163, 23);
            tb_City.TabIndex = 32;
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(433, 78);
            tb_Address.Margin = new Padding(2);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(163, 23);
            tb_Address.TabIndex = 31;
            // 
            // tb_Lastname
            // 
            tb_Lastname.Location = new Point(433, 16);
            tb_Lastname.Margin = new Padding(2);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.Size = new Size(163, 23);
            tb_Lastname.TabIndex = 30;
            // 
            // tb_Phonenumber
            // 
            tb_Phonenumber.Location = new Point(433, 46);
            tb_Phonenumber.Margin = new Padding(2);
            tb_Phonenumber.Name = "tb_Phonenumber";
            tb_Phonenumber.Size = new Size(163, 23);
            tb_Phonenumber.TabIndex = 29;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(102, 48);
            tb_Email.Margin = new Padding(2);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(163, 23);
            tb_Email.TabIndex = 28;
            // 
            // tb_Firstname
            // 
            tb_Firstname.Location = new Point(102, 16);
            tb_Firstname.Margin = new Padding(2);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.Size = new Size(163, 23);
            tb_Firstname.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(355, 116);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 26;
            label9.Text = "Country:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 116);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 25;
            label8.Text = "Zipcode:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 24;
            label7.Text = "Lastname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 82);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 23;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 82);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 22;
            label5.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 50);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 21;
            label4.Text = "Phonenumber:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 19;
            label2.Text = "Firstname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // bt_SearchProjects
            // 
            bt_SearchProjects.Location = new Point(503, 193);
            bt_SearchProjects.Margin = new Padding(2);
            bt_SearchProjects.Name = "bt_SearchProjects";
            bt_SearchProjects.Size = new Size(94, 29);
            bt_SearchProjects.TabIndex = 36;
            bt_SearchProjects.Text = "SearchProjects";
            bt_SearchProjects.UseVisualStyleBackColor = true;
            bt_SearchProjects.Click += bt_SearchProjects_Click;
            // 
            // dgv_ConsultantsInvites
            // 
            dgv_ConsultantsInvites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ConsultantsInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultantsInvites.Dock = DockStyle.Top;
            dgv_ConsultantsInvites.Location = new Point(3, 19);
            dgv_ConsultantsInvites.Name = "dgv_ConsultantsInvites";
            dgv_ConsultantsInvites.RowTemplate.Height = 25;
            dgv_ConsultantsInvites.Size = new Size(595, 297);
            dgv_ConsultantsInvites.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(174, 166);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 38;
            label10.Text = "Invites";
            // 
            // bt_seeInviteDetails
            // 
            bt_seeInviteDetails.Dock = DockStyle.Left;
            bt_seeInviteDetails.Location = new Point(3, 316);
            bt_seeInviteDetails.Name = "bt_seeInviteDetails";
            bt_seeInviteDetails.Size = new Size(101, 27);
            bt_seeInviteDetails.TabIndex = 39;
            bt_seeInviteDetails.Text = "See Details";
            bt_seeInviteDetails.UseVisualStyleBackColor = true;
            bt_seeInviteDetails.Click += bt_seeInviteDetails_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_seeInviteDetails);
            groupBox1.Controls.Add(dgv_ConsultantsInvites);
            groupBox1.Location = new Point(12, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 346);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Invites";
            // 
            // Consultant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 654);
            Controls.Add(label10);
            Controls.Add(bt_SearchProjects);
            Controls.Add(bt_ViewProjects);
            Controls.Add(tb_Country);
            Controls.Add(tb_Zipcode);
            Controls.Add(tb_City);
            Controls.Add(tb_Address);
            Controls.Add(tb_Lastname);
            Controls.Add(tb_Phonenumber);
            Controls.Add(tb_Email);
            Controls.Add(tb_Firstname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Consultant";
            Text = "Consultant";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultantsInvites).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_ViewProjects;
        private TextBox tb_Country;
        private TextBox tb_Zipcode;
        private TextBox tb_City;
        private TextBox tb_Address;
        private TextBox tb_Lastname;
        private TextBox tb_Phonenumber;
        private TextBox tb_Email;
        private TextBox tb_Firstname;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_SearchProjects;
        private DataGridView dgv_ConsultantsInvites;
        private Label label10;
        private Button bt_seeInviteDetails;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}