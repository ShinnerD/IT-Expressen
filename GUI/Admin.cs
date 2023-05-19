using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class Admin : Form
    {
        private IUserModel adminUser;
        public string CreatedUserName { get; set; }

        private readonly IDomainServiceManager ServiceManager;

        private IUserService userService;
        private IProjectService projectService;
        private ISpecializationService specializationService;

        private List<IUserModel> usersSearchResults;
        private List<IProjectModel> projectsSearchResults;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public Admin(IDomainServiceManager serviceManager, string username)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

            userService = serviceManager.UserService;
            projectService = serviceManager.ProjectService;
            specializationService = serviceManager.SpecializationService;

            adminUser = userService.GetUserFromUsername(username);

            InitializeComponent();
            SetUpTB();
            SetUpUserDataGridView();
            SetUpProjectDataGridView();
        }

        /// <summary>
        /// Sets up the DataGridView for the Projects Tab.
        /// </summary>
        private void SetUpProjectDataGridView()
        {
            dgv_ProjectSearchResults.AutoGenerateColumns = false;

            dgv_ProjectSearchResults.Columns.Add("ProjectId", "ID");
            dgv_ProjectSearchResults.Columns["ProjectId"].DataPropertyName = "ProjectId";

            dgv_ProjectSearchResults.Columns.Add("Title", "Title");
            dgv_ProjectSearchResults.Columns["Title"].DataPropertyName = "Title";

            dgv_ProjectSearchResults.Columns.Add("Manager", "Manager");
            dgv_ProjectSearchResults.Columns["Manager"].DataPropertyName = "ManagerFullName";

            dgv_ProjectSearchResults.Columns.Add("ProjectStatus", "Status");
            dgv_ProjectSearchResults.Columns["ProjectStatus"].DataPropertyName = "ProjectStatus";

            dgv_ProjectSearchResults.Columns.Add("ProjectStartDate", "Start");
            dgv_ProjectSearchResults.Columns["ProjectStartDate"].DataPropertyName = "ProjectStartDate";

            dgv_ProjectSearchResults.Columns.Add("ProjectEndDate", "End");
            dgv_ProjectSearchResults.Columns["ProjectEndDate"].DataPropertyName = "ProjectEndDate";

            dgv_ProjectSearchResults.Columns.Add("ProjectModifyDate", "Last Modified");
            dgv_ProjectSearchResults.Columns["ProjectModifyDate"].DataPropertyName = "ProjectModifyDate";

            List<string> allSpecializations = specializationService.ListDefinedSpecializations();
            projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).OrderBy(i => i.Title).ToList();
            dgv_ProjectSearchResults.DataSource = projectsSearchResults;
        }

        /// <summary>
        /// Sets up the DataGridView for the Users Tab.
        /// </summary>
        private void SetUpUserDataGridView()
        {
            dgv_UserSearchResults.AutoGenerateColumns = false;

            dgv_UserSearchResults.Columns.Add("UserId", "ID");
            dgv_UserSearchResults.Columns["UserId"].DataPropertyName = "ID";

            dgv_UserSearchResults.Columns.Add("UserName", "User Name");
            dgv_UserSearchResults.Columns["UserName"].DataPropertyName = "UserName";

            dgv_UserSearchResults.Columns.Add("UserType", "Type");
            dgv_UserSearchResults.Columns["UserType"].DataPropertyName = "UserType";

            dgv_UserSearchResults.Columns.Add("FullName", "Name");
            dgv_UserSearchResults.Columns["FullName"].DataPropertyName = "FullName";

            dgv_UserSearchResults.Columns.Add("Email", "Email");
            dgv_UserSearchResults.Columns["Email"].DataPropertyName = "EMail";

            dgv_UserSearchResults.Columns.Add("Country", "Country");
            dgv_UserSearchResults.Columns["Country"].DataPropertyName = "Country";

            dgv_UserSearchResults.Columns.Add("City", "City");
            dgv_UserSearchResults.Columns["City"].DataPropertyName = "NameCity";

            dgv_UserSearchResults.Columns.Add("Address", "Address");
            dgv_UserSearchResults.Columns["Address"].DataPropertyName = "Address";

            dgv_UserSearchResults.Columns.Add("ZipCode", "Zip Code");
            dgv_UserSearchResults.Columns["ZipCode"].DataPropertyName = "ZipCode";

            dgv_UserSearchResults.Columns.Add("PhoneNumber", "Phone");
            dgv_UserSearchResults.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";

            dgv_UserSearchResults.Columns.Add("CreationDate", "Date of Creation");
            dgv_UserSearchResults.Columns["CreationDate"].DataPropertyName = "CreationDate";

            usersSearchResults = userService.GetAllUsers().OrderBy(i => i.UserName).ToList();
            dgv_UserSearchResults.DataSource = usersSearchResults;
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

        /// <summary>
        /// Updates the page-wide UserModel with the new information in the textboxes /DK
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
                userService.UpdateUser(adminUser);
                UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditProfileCancel.Enabled = false;
                bt_EditProfileCancel.Visible = false;
                bt_EditProfile.Text = "Edit Profile";
            }
        }

        /// <summary>
        /// Searches and Filters Users based on text in search field and selected Radio Buttons. /DK
        /// </summary>
        private void PerformUserSearch(string userName = "")
        {
            IUserService _ = userService;
            string searchString = txtBox_UserSearchParams.Text;
            dgv_UserSearchResults.DataSource = null;

            if (radio_AllUsers.Checked)
            {
                usersSearchResults = _.GetAllUsers().ToList();
            }
            if (radio_Consultants.Checked)
            {
                usersSearchResults = _.GetAllUsers().Where(i => i.UserType.ToLower() == "consultant").ToList();
            }
            if (radio_Managers.Checked)
            {
                usersSearchResults = _.GetAllUsers().Where(i => i.UserType.ToLower() == "manager").ToList();
            }

            usersSearchResults = usersSearchResults.Where(x => x.UserName.ToLower().Contains(searchString.ToLower()) || x.FullName.ToLower().Contains(searchString.ToLower()))
                    .OrderBy(o => o.UserName).ToList();

            dgv_UserSearchResults.DataSource = usersSearchResults;

            if (userName != "")
            {
                int index = usersSearchResults.FindIndex(i => i.UserName == userName);
                dgv_UserSearchResults.Rows[index].Selected = true;
                dgv_UserSearchResults.FirstDisplayedScrollingRowIndex = index;
            }
        }

        /// <summary>
        /// Searches and Filters Projects based on text in search field and selected Radio Buttons. /DK
        /// </summary>
        private void PerformProjectSearch()
        {
            string searchString = txtBox_ProjectSearchParams.Text;
            List<string> allSpecializations = specializationService.ListDefinedSpecializations();
            dgv_ProjectSearchResults.DataSource = null;

            if (radio_AllProjects.Checked)
            {
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).ToList();
            }
            if (radio_InProgress.Checked)
            {
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).Where(x => x.ProjectStatus.ToLower() == "active").ToList();
            }
            if (radio_Pending.Checked)
            {
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).Where(x => x.ProjectStatus.ToLower() == "pending").ToList();
            }
            if (radio_Ended.Checked)
            {
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).Where(x => x.ProjectStatus.ToLower() == "ended").ToList();
            }

            projectsSearchResults = projectsSearchResults.Where(i => i.Title.ToLower().Contains(searchString.ToLower())).OrderBy(o => o.Title).ToList();
            dgv_ProjectSearchResults.DataSource = projectsSearchResults;
        }

        /// <summary>
        /// Redraws and resizes the datagridview after the databinding has been completed. Works with window resizing. /DK
        /// </summary>
        private void dgv_UserSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.ColumnCount != 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Opens the relevant Form that is selected from searched Users to View their profile and Edit.
        /// </summary>
        private void OpenUserProfile(string userName, string userType)
        {
            if (userType == "manager")
            {
                Manager manager = new Manager(ServiceManager, userName);
                manager.ShowDialog();
                PerformUserSearch(userName);
            }
            if (userType == "consultant")
            {
                Consultant consultant = new Consultant(ServiceManager, userName);
                consultant.ShowDialog();
                PerformUserSearch(userName);
            }
            if (userType == "admin")
            {
                FeedBackMessage(lbl_FeedbackUserTab, "Admin's can't edit other Admins.", Color.Red);
            }
        }

        /// <summary>
        /// Runs when User clicks the New User button. Opens the form for creating a new user.
        /// </summary>
        private void OpenNewUserForm()
        {
            CreateUser createUser = new CreateUser(ServiceManager, this, true);
            createUser.ShowDialog();
            this.Show();
            PerformUserSearch(CreatedUserName);
        }

        /// <summary>
        /// Async Task that turns on the visibility of the label provided in the parameters,
        /// shows the given message in the given color, for the given time. /DK
        /// </summary>
        private async Task FeedBackMessage(Label label, string message, Color color, int milliseconds = 5000)
        {
            label.Text = message.Trim();
            label.ForeColor = color;
            label.Visible = true;
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            try
            {
                await Task.Delay(milliseconds, _cancellationTokenSource.Token);
                label.Text = string.Empty;
                label.ForeColor = Color.Black;
                label.Visible = false;
            }
            catch (TaskCanceledException) { }
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

        private void btn_SearchUsers_Click(object sender, EventArgs e)
        {
            PerformUserSearch();
        }

        private void btn_SearchProjects_Click(object sender, EventArgs e)
        {
            PerformProjectSearch();
        }

        private void txtBox_ProjectSearchParams_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformProjectSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (dgv_UserSearchResults.SelectedRows.Count != 0)
            {
                OpenUserProfile(dgv_UserSearchResults.SelectedRows[0].Cells["UserName"].Value.ToString(), dgv_UserSearchResults.SelectedRows[0].Cells["UserType"].Value.ToString().ToLower());
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            OpenNewUserForm();
        }

    }
}