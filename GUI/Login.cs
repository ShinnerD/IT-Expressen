namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Show();
        }

    }
}