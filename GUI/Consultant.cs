using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Consultant : Form
    {
        public string Username { get; set; }
        public int projectId { get; set; }
        public IUserModel userModel { get; set; }
        public IProjectModel projectModel { get; set; }

        public Consultant(string username)
        {
            InitializeComponent();
            Username = username;
            GetUser();
            SetUpTB();
            GetProject();
        }

        private void GetUser()
        {
            IUserService userService = new UserService();
            userModel = userService.GetUser(Username);
        }

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

        private void GetProject()
        {
            IProjectService projectService = new ProjectService();
            projectModel = projectService.GetProject(projectId);
        }
        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModel.ID;
            ConsultantViewProjects ConviewProjects = new ConsultantViewProjects(userId);
            ConviewProjects.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}