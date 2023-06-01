using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using GUI.Admin;

namespace GUI
{
    public partial class CreateUser : Form
    {
        /// <summary>
        /// Initializeing og the service/models need for the form /MS
        /// </summary>
        private readonly IDomainServiceManager ServiceManager;
        private IUserService userService;
        bool isAdmin = false;

        private GuiHelper guiHelper = new GuiHelper();

        AdminMain AdminForm;
        /// <summary>
        /// Initializes needed methods and data
        /// </summary>
        /// <param name="serviceManager"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public CreateUser(IDomainServiceManager serviceManager)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            userService = ServiceManager.UserService;

            InitializeComponent();
            SetupSkillsCheckList();
        }
        /// <summary>
        /// Initializes needed methods and data
        /// </summary>
        /// <param name="serviceManager"></param>
        /// <param name="adminForm"></param>
        /// <param name="IsAdminCreatingUser"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public CreateUser(IDomainServiceManager serviceManager, AdminMain adminForm, bool IsAdminCreatingUser)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            userService = ServiceManager.UserService;

            AdminForm = adminForm;
            isAdmin = IsAdminCreatingUser;

            InitializeComponent();
            SetupSkillsCheckList();
        }

        /// <summary>
        /// Creates a new user according to the parameters defined in the IUserService. /MS
        /// </summary>
        public void CreateNewUser()
        {
            try
            {
                if (NoInputErrors())
                {
                    userService.AddUser(
                        tb_UserName.Text,
                        tb_Password.Text,
                        cb_UserType.Text.ToLower(),
                        tb_FirstName.Text,
                        tb_LastName.Text,
                        tb_Address.Text,
                        tb_City.Text,
                        tb_Zipcode.Text,
                        tb_Country.Text,
                        tb_PhoneNumber.Text,
                        tb_Email.Text,
                        FindCheckedSkills()

                        );
                    if (!isAdmin)
                    {
                        forwardUserToProfile();
                    }
                    else
                    {
                        AdminForm.CreatedUserName = tb_UserName.Text;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out the form and check if both passwords are the same");
                }
            }
            catch (Exception ex)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackLabel, ex.Message, Color.Red);
            }
        }
        /// <summary>
        /// Makes sure the two passwords are the same and critical textboxes arent left empty //MS
        /// </summary>
        /// <returns></returns>
        private bool NoInputErrors()
        {
            if (tb_Password.Text == tb_RePassword.Text
                && tb_Password.Text != string.Empty
                && tb_UserName.Text != string.Empty
                && cb_UserType.Text.ToLower() != string.Empty)

            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Button click event -> see method for results /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_CreateUser_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        /// <summary>
        /// Creates the CheckListBox used for specialization according to data from the database  //MS
        /// </summary>
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

        /// <summary>
        /// Locks and unlocks the CheckBoxList depending on what user type is selected in the ComboBox. Also removed any checked boxes in the CheckBoxList if other is selected /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_UserType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_UserType.Text.ToLower() == "consultant")
            {
                clb_Skills.Enabled = true;
            }
            else
            {
                clb_Skills.Enabled = false;

                for (int i = 0; i < clb_Skills.Items.Count; i++)
                    clb_Skills.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// Button click event -> Close current form /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// After the User is created, the user is forwarded the the correct form, defined by their user type //MS
        /// </summary>
        private void forwardUserToProfile()
        {
            var user = userService.GetUserFromUsername(tb_UserName.Text);
            if (user.UserType == "manager")
            {
                GUI.Manager a = new Manager(ServiceManager, user.UserName);
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
            if (user.UserType == "consultant")
            {
                GUI.Consultant a = new Consultant(ServiceManager, user.UserName);
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
            if (user.UserType == "admin")
            {
                this.Hide();
                AdminMain a = new AdminMain(ServiceManager, user.UserName);
                a.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Adds selected skills to specialization and links to a specefik user /MS
        /// </summary>
        /// <returns></returns>
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