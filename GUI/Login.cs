using DAL.Linq;
using System.Threading.Tasks;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataClassesDataContext dataClassesDataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

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
        private void OpenAdminForm()
        {
            var user = (from s in dataClassesDataContext.Users where s.User_name == "admin" select s).First();
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
                var user = (from s in dataClassesDataContext.Users where s.User_name == tb_UserName.Text select s).First();
                if (user.Password == tb_Password.Text && user.User_Type == "manager")
                {
                    this.Hide();
                    GUI.Manager a = new Manager(user.User_name);
                    a.Show();
                }
                if (user.Password == tb_Password.Text && user.User_Type == "consultant")
                {
                    this.Hide();
                    GUI.Consultant a = new Consultant();
                    a.Show();
                }
                if (user.Password == tb_Password.Text && user.User_Type == "admin")
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
        //private void TestDBConnection()
        //{
        //    Action<object> action = (object obj) =>;

        //    Task t1 = new Task(dataClassesDataContext.DatabaseExists);

        //    t1.Start();
        //}

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}