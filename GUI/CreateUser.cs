using DAL.Linq;
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
            using (DataClassesDataContext dbcontext = new DataClassesDataContext(DbConnectionString.ConnectionString))
            {
                User newUser = new User()
                {
                    User_name = tb_UserName.Text,
                    Password = tb_Password.Text,
                    User_Type = tb_UserType.Text,
                    First_Name = tb_FirstName.Text,
                    Last_Name = tb_LastName.Text,
                    Street_Address = tb_Address.Text,
                    City = tb_City.Text,
                    Zip_Code = tb_ZipCode.Text,
                    Country = tb_Country.Text,
                    Phone_Number = tb_PhoneNr.Text,
                    Email = tb_Email.Text,
                    Creation_Date = DateTime.Now,

                };
                dbcontext.Users.InsertOnSubmit(newUser);
                dbcontext.SubmitChanges();
            }



        }

        private void LoadUserData()
        {
            var UserService = new Domain.Services.UserService();
            allUsers = UserService.GetAllUsers();
        }

        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            CreatNewUser();
        }
    }
}
