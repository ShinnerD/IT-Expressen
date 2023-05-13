﻿using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Manager : Form
    {
        public string Username { get; set; }
        public IUserModel userModel { get; set; }

        public Manager(string username)
        {
            InitializeComponent();
            Username = username;
            GetUser();
            SetUpTB();
        }
        /// <summary>
        /// (JQ)This method opens the NewProject form.
        /// </summary>
        private void OpenNewProjectForm()
        {
            this.Hide();
            Form newProjectForm = new NewProject(Username);
            newProjectForm.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// (JQ)This method retrieves and sets the user information using IUserService.
        /// </summary>
        private void GetUser()
        {
            IUserService userService = new UserService();
            userModel = userService.GetUser(Username);
        }
        /// <summary>
        /// (JQ)Sets up text boxes to show user information from userModel property.
        /// </summary>
        private void SetUpTB()
        {
            tb_userName.Text = userModel.UserName;
            tb_Firstname.Text = userModel.FirstName;
            tb_Lastname.Text = userModel.LastName;
            tb_Email.Text = userModel.EMail;
            tb_Phonenumber.Text = userModel.PhoneNumber;
            tb_City.Text = userModel.NameCity;
            tb_Address.Text = userModel.Address;
            tb_Zipcode.Text = userModel.ZipCode;
            tb_Country.Text = userModel.Country;
        }
        /// <summary>
        /// (JQ)Handle button click event for OpenNewProjectForm.
        /// </summary>
        private void bt_NewProject_Click(object sender, EventArgs e)
        {
            OpenNewProjectForm();
        }
        /// <summary>
        /// (JQ)Handle button click event for ViewProjects and passes userId to ViewProjects form.
        /// </summary>
        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModel.ID;
            ViewProjects viewProjects = new ViewProjects(userId);
            viewProjects.ShowDialog();
            this.Show();
        }
    }
}