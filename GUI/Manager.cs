using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenNewProjectForm();
        }

        private void OpenNewProjectForm()
        {
            this.Hide();
            Form newProjectForm = new NewProject();
            newProjectForm.ShowDialog();
            this.Show();
        }

        private void GetUser()
        {
            IUserService userService = new UserService();
            userModel = userService.GetUser(Username);

        }

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

        private void bt_NewProject_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject();
            newProject.ShowDialog();
        }

        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModel.ID;
            ViewProjects viewProjects = new ViewProjects(userId);
            viewProjects.ShowDialog();
        }
    }
}
