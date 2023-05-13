using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Consultant : Form
    {
        public string Username { get; set; }
        public IUserModel userModel { get; set; }

        public Consultant(string username)
        {
            InitializeComponent();
            Username = username;
            GetUser();
            SetUpTB();
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
        /// (JQ)Handle button click event for ConsultantViewProjects and passes userId to ConsultantViewProjects form.
        /// </summary>
        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModel.ID;
            ConsultantViewProjects ConviewProjects = new ConsultantViewProjects(userId);
            ConviewProjects.ShowDialog();
        }

        private void bt_SearchProjects_Click(object sender, EventArgs e)
        {

        }
    }
}