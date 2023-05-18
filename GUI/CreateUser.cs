using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class CreateUser : Form
    {
        private readonly IDomainServiceManager ServiceManager;
        private List<IUserModel> allUsers { get; set; }
        private IUserService userService;

        public CreateUser(IDomainServiceManager serviceManager)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            userService = ServiceManager.UserService;

            InitializeComponent();
            LoadUserData();
            SetupSkillsCheckList();
        }
        //Creates a new user according to the parameters defined in the IUserService. 
        public void CreatNewUser()
        {
            try
            {
                if (NoInputErrors())
                {
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
        //Makes sure the two passwords are the same and critical textboxes arent left empty //MS
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
        //Initialize user data //MS
        private void LoadUserData()
        {
            var UserService = ServiceManager.UserService;
            var OneUsers = UserService.GetUser(tb_UserName.Text);
        }
        // Button click event -> see method for results /MS
        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            CreatNewUser();
        }
        //Creates the CheckListBox used for specialization according to data from the database  //MS
        private void SetupSkillsCheckList()
        {
            clb_Skills.Enabled = false;
            ISpecializationService specService = ServiceManager.SpecializationService;
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
        //Locks and unlocks the CheckBoxList depending on what user type is selected in the ComboBox. Also removed any checked boxes in the CheckBoxList if manager is selected /MS
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
        // Button click event -> Close current form /MS
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //After the User is created, the user is forwarded the the correct form, defined by their user type //MS
        private void forwardUserToProfile()
        {
            var user = userService.GetUser(tb_UserName.Text);
            if (user.UserType == "manager")
            {
                this.Close();
                GUI.Manager a = new Manager(ServiceManager, user.UserName);
                a.Show();
            }
            if (user.UserType == "consultant")
            {
                this.Hide();
                GUI.Consultant a = new Consultant(ServiceManager, user.UserName);
                a.Show();
            }
            if (user.UserType == "admin")
            {
                this.Hide();
                GUI.Admin a = new Admin(ServiceManager, user.UserName);
                a.Show();
            }
        }
        //Adds selected skills to specialization and links to a specefik user /MS
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