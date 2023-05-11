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
                if (tb_Password.Text == tb_RePassword.Text)
                {
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
                        tb_Email.Text


                        );
                }
                else
                {
                    MessageBox.Show("Passwords are not the same");
                }
            }

            catch
            {
                MessageBox.Show("Username is already in use");
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
            if (cb_UserType.Text == "Consultant")
            {
                clb_Skills.Enabled = true;
            }
            if (cb_UserType.Text == "Manager")
            {
                clb_Skills.Enabled=false;
            }

        }
    }
}