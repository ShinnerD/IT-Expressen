﻿using Domain.Services;
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
    public partial class CreateUser : Form
    {
        List<IUserModel> allUsers { get; set; }
        IUserService userService = new UserService();

        public CreateUser()
        {
            InitializeComponent();
            LoadUserData();
        }
        public void CreatNewUser()
        {
            tb_UserName.Text = allUsers.
        }
        private void LoadUserData()
        {
            var UserService = new Domain.Services.UserService();
            allUsers = UserService.GetAllUsers();
        }
    }
}
