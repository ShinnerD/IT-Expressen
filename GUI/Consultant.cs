﻿using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Consultant : Form
    {
        public string Username { get; set; }
        public IUserModel userModelGet { get; set; }

        private IInviteService invService = new InviteService();

        private IUserService userService = new UserService();

        public Consultant(string username)
        {
            InitializeComponent();
            Username = username;
            GetUser();
            SetUpTB();
            LoadInvitesToDGV();
        }

        /// <summary>
        /// (JQ)This method retrieves and sets the user information using IUserService.
        /// </summary>
        private void GetUser()
        {
            IUserService userService = new UserService();
            userModelGet = userService.GetUser(Username);
        }

        /// <summary>
        /// (JQ)Sets up text boxes to show user information from userModel property.
        /// </summary>
        private void SetUpTB()
        {
            tb_Firstname.Text = userModelGet.FirstName;
            tb_Lastname.Text = userModelGet.LastName;
            tb_Email.Text = userModelGet.EMail;
            tb_Phonenumber.Text = userModelGet.PhoneNumber;
            tb_City.Text = userModelGet.NameCity;
            tb_Address.Text = userModelGet.Address;
            tb_Zipcode.Text = userModelGet.ZipCode;
            tb_Country.Text = userModelGet.Country;
        }

        /// <summary>
        /// (JQ)Handle button click event for ConsultantViewProjects and passes userId to ConsultantViewProjects form.
        /// </summary>
        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModelGet.ID;
            ConsultantViewProjects ConviewProjects = new ConsultantViewProjects(userId);
            ConviewProjects.ShowDialog();
        }

        private void bt_SearchProjects_Click(object sender, EventArgs e)
        {
        }

        private void LoadInvitesToDGV()
        {
            dgv_ConsultantsInvites.DataSource = invService.GetInvitedUserIDList(userModelGet.ID);
        }

        private void bt_seeInviteDetails_Click(object sender, EventArgs e)
        {
            var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;
            AcceptInviteForm AccInvForm = new AcceptInviteForm(selectedProject.ProjectId);
            this.Hide();
            AccInvForm.ShowDialog();
            this.Show();
        }
    }
}