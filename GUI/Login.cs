using DAL;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using GUI.Admin;

namespace GUI
{
    public partial class Login : Form
    {
        //Initializeing og the service/models need for the form /MS
        private readonly IDomainServiceManager ServiceManager;
        private IUserService userService;
        //Initializes needed methods and data, and start the AsyncTask /MS
        public Login(IDomainServiceManager domainServiceManager)
        {
            ServiceManager = domainServiceManager ?? throw new ArgumentNullException(nameof(domainServiceManager));
            userService = ServiceManager.UserService;
            InitializeComponent();
            AsyncTask();
        }
        // Button click event -> see method for results /MS
        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            OpenCreateUserForm();
        }
        // Button click event -> see method for results /MS
        private void bt_AdminAccess_Click(object sender, EventArgs e)
        {
            OpenAdminForm();
        }
        // Button click event -> see method for results /MS
        private void bt_ConsultantAccess_Click(object sender, EventArgs e)
        {
            OpenConsultantForm();
        }
        // Button click event -> see method for results /MS
        private void bt_ManagerAccess_Click(object sender, EventArgs e)
        {
            OpenManagerForm();
        }
        //Temp method used to bypass the login and connect straigt to an instance of the admin form -> Used only for development purposes will be deleted before final release /MS
        private void OpenAdminForm()
        {
            try
            {
                this.Hide();
                AdminMain Admin = new AdminMain(ServiceManager, "admin");
                Admin.ShowDialog();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        //Temp method used to bypass the login and connect straigt to an instance of the consultant form, on a specific user -> Used only for development purposes and will be deleted before final release /MS
        private void OpenConsultantForm()
        {
            try
            {
                var user = userService.GetAllUsers();
                var targetUser = user.Where(i => i.UserName == tb_UserName.Text).First();
                this.Hide();
                targetUser.UserName = "fbeccles0";
                targetUser.Password = "password";
                Consultant consultant = new Consultant(ServiceManager, targetUser.UserName);
                consultant.ShowDialog();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        //Method to open form for creating a new user in the system /MS
        private void OpenCreateUserForm()
        {
            this.Hide();
            CreateUser createUser = new CreateUser(ServiceManager);
            createUser.ShowDialog();
            this.Show();
        }
        //Temp method used to bypass the login and connect straigt to an instance of the manager form, on a specific user -> Used only for development purposes and will be deleted before final release /MS
        private void OpenManagerForm()
        {
            try
            {
                var user = userService.GetAllUsers();
                var targetUser = user.Where(i => i.UserName == tb_UserName.Text).First();
                this.Hide();
                targetUser.UserName = "amusto0";
                targetUser.Password = "password";
                Manager manager = new Manager(ServiceManager, targetUser.UserName);
                manager.ShowDialog();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        // Button click event -> see method for results /MS
        private void bt_Login_Click(object sender, EventArgs e)
        {
            LoginControl();
        }
        //Checks the login information to make sure the user excists, and forwards the user to the correct form, according to UserType /MS
        private void LoginControl()
        {
            try
            {
                var user = userService.GetAllUsers();
                var targetUser = user.Where(i => i.UserName == tb_UserName.Text).First();
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "manager")
                {
                    this.Hide();
                    GUI.Manager a = new Manager(ServiceManager, targetUser.UserName);
                    a.Show();
                }
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "consultant")
                {
                    this.Hide();
                    GUI.Consultant a = new Consultant(ServiceManager, targetUser.UserName);
                    a.Show();
                }
                if (targetUser.Password == tb_Password.Text && targetUser.UserType == "admin")
                {
                    this.Hide();
                    AdminMain a = new AdminMain(ServiceManager, targetUser.UserName);
                    a.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect");
            }

        }
        //Seperate task, thats ment to wake up the Database from standby. /MS
        public void AsyncTask()
        {
            Task t = new Task(WakeUpDB);
            t.Start();
        }
        //Connects the database, and checks if there is a user in the User table. If this statment is true, there is a connection to the database. If not the status changes to "No connection". 
        //Delay is just there to make sure, its possiable to see the method fuctions. /MS
        public async void WakeUpDB()
        {
            //await Task.Delay(3000);
            try
            {
                ServiceManager.ProjectService.UpdateAllProjectStatus(); //<-- Execution of stored procedure to update project status column.
                                                                                                          //Piggybacking on this task as a temporary solution. /DK
                var anyUser = userService.GetAllUsers();
                if (anyUser.Count > 0)
                {
                    lb_connectionTest.Invoke((MethodInvoker)(() => lb_connectionTest.Text = "OK!"));
                    lb_FeedbackLabel.Invoke((MethodInvoker)(() => lb_FeedbackLabel.Text = "Connection Established"));
                    pb_ConnectionStatus.Image = img_RedGreen.Images[1];
                }
                else
                {
                    lb_connectionTest.Invoke((MethodInvoker)(() => lb_connectionTest.Text = "No connection!"));
                    pb_ConnectionStatus.Image = img_RedGreen.Images[0];
                }

            }
            catch
            {
                lb_connectionTest.Invoke((MethodInvoker)(() => lb_connectionTest.Text = "No connection!"));
                pb_ConnectionStatus.Image = img_RedGreen.Images[0];
            }
        }
        // Button click event -> see method for results /MS
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}