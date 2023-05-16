using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class Admin : Form
    {
        private IUserModel adminUser;

        private IUserService userService;
        private IProjectService projectService;

        private List<IUserModel> usersSearchResults;
        private List<IProjectModel> projectsSearchResults;

        public Admin(string username)
        {
            userService = new UserService();
            projectService = new ProjectService();

            adminUser = userService.GetUser(username);

            InitializeComponent();
            SetUpTB();
            SetUpUserDataGridView();
        }

        private void SetUpUserDataGridView()
        {
            usersSearchResults = userService.GetAllUsers().OrderBy(i => i.UserName).ToList();
            dgv_UserSearchResults.DataSource = usersSearchResults;
        }

        /// <summary>
        /// Updates the pagewide UserModel with the new information in the textboxes /DK
        /// </summary>
        private void UpdateUserModel()
        {
            adminUser.FirstName = tb_Firstname.Text;
            adminUser.LastName = tb_Lastname.Text;
            adminUser.EMail = tb_Email.Text;
            adminUser.PhoneNumber = tb_Phonenumber.Text;
            adminUser.Address = tb_Address.Text;
            adminUser.NameCity = tb_City.Text;
            adminUser.ZipCode = tb_Zipcode.Text;
            adminUser.Country = tb_Country.Text;
        }

        /// <summary>
        /// Unlocks the textboxes in the user profile section of the form and changes the edit button to reflect the ability
        /// to save the changes you make to your profile. /DK
        /// </summary>
        private void UnlockProfileForEditing(Control control, bool unlock)
        {
            if (control is TextBox)
            {
                control.Enabled = unlock;
                control.TabStop = unlock;
                if (unlock)
                {
                    control.BackColor = SystemColors.Window;
                }
                else
                {
                    control.BackColor = SystemColors.ControlLight;
                }
            }
            if (control.HasChildren)
            {
                // Recursively call this method for all controls inside the control passed in the parameter.
                // Ex. all controls inside another group box.
                foreach (Control childControl in control.Controls)
                {
                    UnlockProfileForEditing(childControl, unlock);
                }
            }
        }

        /// <summary>
        /// Changes the Edit Profile button to either activate or deactivate the controls, so the user
        /// can edit their profile info. Calls a save on the data if the user wants to save changes.
        /// </summary>
        private void ChangeEditProfileState()
        {
            if (bt_EditProfile.Text == "Edit Profile")
            {
                UnlockProfileForEditing(grpBoxProfileInfo, true);
                bt_EditProfile.Text = "Save Changes";
                bt_EditProfileCancel.Enabled = true;
                bt_EditProfileCancel.Visible = true;
            }
            else
            {
                UpdateUserModel();
                IUserService userService = new UserService();
                userService.UpdateUser(adminUser);
                UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditProfileCancel.Enabled = false;
                bt_EditProfileCancel.Visible = false;
                bt_EditProfile.Text = "Edit Profile";
            }
        }

        /// <summary>
        /// (JQ)Sets up text boxes to show user information from adminUser property.
        /// </summary>
        private void SetUpTB()
        {
            grpBoxProfileInfo.Text = adminUser.UserName;
            tb_Firstname.Text = adminUser.FirstName;
            tb_Lastname.Text = adminUser.LastName;
            tb_Email.Text = adminUser.EMail;
            tb_Phonenumber.Text = adminUser.PhoneNumber;
            tb_City.Text = adminUser.NameCity;
            tb_Address.Text = adminUser.Address;
            tb_Zipcode.Text = adminUser.ZipCode;
            tb_Country.Text = adminUser.Country;
            lblUserCreationDate.Text = "You've been a user for " + (DateTime.Now - adminUser.CreationDate).GetValueOrDefault().Days.ToString() + " days";
        }

        private void bt_EditProfileCancel_Click(object sender, EventArgs e)
        {
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Visible = false;
            bt_EditProfile.Text = "Edit Profile";
            UnlockProfileForEditing(grpBoxProfileInfo, false);
            SetUpTB();
        }

        private void bt_EditProfile_Click(object sender, EventArgs e)
        {
            ChangeEditProfileState();
        }

        private void dgv_UserSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.ColumnCount != 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_SearchUsers_Click(object sender, EventArgs e)
        {
            PerformUserSearch();
        }

        private void PerformUserSearch()
        {
            string searchString = txtBox_UserSearchParams.Text;
            dgv_UserSearchResults.DataSource = null;

            if (radio_AllUsers.Checked)
            {
                usersSearchResults = userService.GetAllUsers().Where(i => i.UserName.Contains(searchString) || i.FullName.Contains(searchString))
                    .OrderBy(i => i.UserName).ToList();
            }
            if (radio_Consultants.Checked)
            {
                usersSearchResults = userService.GetAllUsers().Where(i => i.UserType == "consultant")
                    .Where(x => x.UserName.Contains(searchString) || x.FullName.Contains(searchString))
                    .OrderBy(o => o.UserName).ToList();
            }
            if (radio_Managers.Checked)
            {
                usersSearchResults = userService.GetAllUsers().Where(i => i.UserType == "manager")
                    .Where(x => x.UserName.Contains(searchString) || x.FullName.Contains(searchString))
                    .OrderBy(o => o.UserName).ToList();
            }
            dgv_UserSearchResults.DataSource = usersSearchResults;
        }
    }
}