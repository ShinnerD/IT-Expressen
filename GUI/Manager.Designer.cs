namespace GUI
{
    partial class Manager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_Firstname = new TextBox();
            tb_Email = new TextBox();
            tb_Phonenumber = new TextBox();
            tb_Lastname = new TextBox();
            tb_Address = new TextBox();
            tb_City = new TextBox();
            tb_Zipcode = new TextBox();
            tb_Country = new TextBox();
            bt_ViewProjects = new Button();
            bt_NewProject = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 41);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Firstname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 91);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 91);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 3;
            label4.Text = "Phonenumber:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 144);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 4;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 144);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(541, 41);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 6;
            label7.Text = "Lastname:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 201);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 7;
            label8.Text = "Zipcode:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 201);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 8;
            label9.Text = "Country:";
            // 
            // tb_Firstname
            // 
            tb_Firstname.Location = new Point(197, 35);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.Size = new Size(231, 31);
            tb_Firstname.TabIndex = 9;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(197, 88);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(231, 31);
            tb_Email.TabIndex = 10;
            // 
            // tb_Phonenumber
            // 
            tb_Phonenumber.Location = new Point(655, 85);
            tb_Phonenumber.Name = "tb_Phonenumber";
            tb_Phonenumber.Size = new Size(231, 31);
            tb_Phonenumber.TabIndex = 11;
            // 
            // tb_Lastname
            // 
            tb_Lastname.Location = new Point(655, 35);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.Size = new Size(231, 31);
            tb_Lastname.TabIndex = 12;
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(655, 138);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(231, 31);
            tb_Address.TabIndex = 13;
            // 
            // tb_City
            // 
            tb_City.Location = new Point(197, 141);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(231, 31);
            tb_City.TabIndex = 14;
            // 
            // tb_Zipcode
            // 
            tb_Zipcode.Location = new Point(197, 198);
            tb_Zipcode.Name = "tb_Zipcode";
            tb_Zipcode.Size = new Size(231, 31);
            tb_Zipcode.TabIndex = 15;
            // 
            // tb_Country
            // 
            tb_Country.Location = new Point(655, 195);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(231, 31);
            tb_Country.TabIndex = 16;
            // 
            // bt_ViewProjects
            // 
            bt_ViewProjects.Location = new Point(31, 324);
            bt_ViewProjects.Name = "bt_ViewProjects";
            bt_ViewProjects.Size = new Size(134, 48);
            bt_ViewProjects.TabIndex = 17;
            bt_ViewProjects.Text = "ViewProjects";
            bt_ViewProjects.UseVisualStyleBackColor = true;
            bt_ViewProjects.Click += bt_ViewProjects_Click;
            // 
            // bt_NewProject
            // 
            bt_NewProject.Location = new Point(792, 300);
            bt_NewProject.Name = "bt_NewProject";
            bt_NewProject.Size = new Size(115, 48);
            bt_NewProject.TabIndex = 18;
            bt_NewProject.Text = "NewProject";
            bt_NewProject.UseVisualStyleBackColor = true;
            bt_NewProject.Click += bt_NewProject_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 384);
            Controls.Add(bt_NewProject);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_Firstname;
        private TextBox tb_Email;
        private TextBox tb_Phonenumber;
        private TextBox tb_Lastname;
        private TextBox tb_Address;
        private TextBox tb_City;
        private TextBox tb_Zipcode;
        private TextBox tb_Country;
        private Button bt_ViewProjects;
        private Button bt_NewProject;
    }
}