using DAL.Linq;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GUI
{
    public partial class Login : Form
    {
        public List<IUserModel> allUsers { get; set; }
        IUserService userService = new UserService();

        public Login()
        {
            InitializeComponent();
            LoadUserData();
            AsyncTask();
        }


        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            OpenCreateUserForm();

        }

        private void bt_AdminAccess_Click(object sender, EventArgs e)
        {
            OpenAdminForm();

        }

        private void bt_ConsultantAccess_Click(object sender, EventArgs e)
        {
            OpenConsultantForm();

        }

        private void bt_ManagerAccess_Click(object sender, EventArgs e)
        {
            OpenManagerForm();
        }
        // 
        private void OpenAdminForm()
        {
            
            this.Hide();
            Admin Admin = new Admin();
            Admin.ShowDialog();
            this.Show();

        }
        private void OpenConsultantForm()
        {
            this.Hide();
            Consultant consultant = new Consultant();
            consultant.ShowDialog();
            this.Show();
        }
        private void OpenCreateUserForm()
        {
            this.Hide();
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
            this.Show();

        }
        private void OpenManagerForm()
        {
            this.Hide();
            Manager manager = new Manager("");
            manager.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userService.GetAllUsers();
                var targetUser = user.Where(i => i.UserName == tb_UserName.Text).First();
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "manager")
                {
                    this.Hide();
                    GUI.Manager a = new Manager(targetUser.UserName);
                    a.Show();
                }
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "consultant")
                {
                    this.Hide();
                    GUI.Consultant a = new Consultant();
                    a.Show();
                }
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "admin")
                {
                    this.Hide();
                    GUI.Admin a = new Admin();
                    a.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect");
            }

        }
        public void AsyncTask()
        {
            Task t = new Task(WakeUpDB);
            t.Start();

        }
        public void WakeUpDB()
        {

            var user = userService.GetAllUsers();
            var anyUser = user.Where(i => i.UserName.IsNullOrEmpty());
            if (anyUser != null)
            {
                lb_connectionTest.Invoke((MethodInvoker)(() => lb_connectionTest.Text = "OK!"));

            }
            if (anyUser == null)
            {
                lb_connectionTest.Invoke((MethodInvoker)(() => lb_connectionTest.Text = "No connection!"));
            }

        }
        private void LoadUserData()
        {
            var UserService = new Domain.Services.UserService();
            allUsers = UserService.GetAllUsers();
        }
    }
}