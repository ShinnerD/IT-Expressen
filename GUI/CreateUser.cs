using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class CreateUser : Form
    {
        private List<IUserModel> allUsers { get; set; }
        private IUserService userService = new UserService();

        public CreateUser()
        {
            InitializeComponent();
            LoadUserData();
            SetupSkillsCheckList();
        }

        public void CreatNewUser()
        {
            try
            {
                if (NoInputErrors())
                {
                    ISpecializationService UserSpecializationService = new SpecializationService();
                    IUserService userService = new Domain.Services.UserService();

                    userService.AddUser(
                        tb_UserName.Text,
                        tb_Password.Text,
                        cb_UserType.Text,
                        tb_FirstName.Text,
                        tb_LastName.Text,
                        tb_Address.Text,
                        tb_City.Text,
                        tb_ZipCode.Text,
                        tb_Country.Text,
                        tb_PhoneNr.Text,
                        tb_Email.Text,
                        FindCheckedSkills()

                        );
                    forwardUserToProfile();
                }
                else
                {
                    MessageBox.Show("Please fill out the form and check if both passwords are the same");
                }
            }
            catch
            {
                MessageBox.Show("Username is already in use");
            }
        }
        // 
        private bool NoInputErrors()
        {
            if (tb_Password.Text == tb_RePassword.Text
                && tb_Password.Text != string.Empty
                && tb_UserName.Text != string.Empty
                && cb_UserType.Text != string.Empty)

            {
                return true;
            }
            return false;
        }

        private void LoadUserData()
        {
            var UserService = new Domain.Services.UserService();
            var OneUsers = UserService.GetUser(tb_UserName.Text);
        }

        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            CreatNewUser();
        }

        private void SetupSkillsCheckList()
        {
            clb_Skills.Enabled = false;
            ISpecializationService specService = new Domain.Services.SpecializationService();
            List<string> items = specService.ListDefinedSpecializations().OrderBy(i => i).ToList();

            foreach (var item in items)
            {
                clb_Skills.Items.Add(item);
            }

            if (items.Count == 0)
            {
                MessageBox.Show("Failed to retrieve skills from server.");
            }
        }

        private void cb_UserType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_UserType.Text == "consultant")
            {
                clb_Skills.Enabled = true;
            }
            if (cb_UserType.Text == "manager")
            {
                clb_Skills.Enabled = false;

                for (int i = 0; i < clb_Skills.Items.Count; i++)
                    clb_Skills.SetItemChecked(i, false);
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forwardUserToProfile()
        {
            var user = userService.GetUser(tb_UserName.Text);
            if (user.UserType == "manager")
            {
                this.Close();
                GUI.Manager a = new Manager(user.UserName);
                a.Show();
            }
            if (user.UserType == "consultant")
            {
                this.Hide();
                GUI.Consultant a = new Consultant();
                a.Show();
            }
            if (user.UserType == "admin")
            {
                this.Hide();
                GUI.Admin a = new Admin();
                a.Show();
            }
        }

        private List<string> FindCheckedSkills()
        {
            List<string> result = new List<string>();

            foreach (var skill in clb_Skills.CheckedItems)
            {
                result.Add(skill.ToString());
            }
            return result;
        }
    }
}