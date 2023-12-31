﻿using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI.Admin
{
    public partial class AdminMain : Form
    {
        private IUserModel adminUser;
        public string? CreatedUserName { get; set; }

        private readonly IDomainServiceManager ServiceManager;

        private IUserService userService;
        private IProjectService projectService;
        private ISpecializationService specializationService;

        private List<IUserModel>? usersSearchResults;
        private List<IProjectModel>? projectsSearchResults;

        private GuiHelper userGuiHelper = new GuiHelper();
        private GuiHelper projectGuiHelper = new GuiHelper();

        public AdminMain(IDomainServiceManager serviceManager, string username)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

            userGuiHelper.StartingSortedColumnIndex = 1;
            projectGuiHelper.StartingSortedColumnIndex = 1;

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

            dgv_ProjectSearchResults.Columns.Add("ManagerFullName", "Manager Name");
            dgv_ProjectSearchResults.Columns["ManagerFullName"].DataPropertyName = "ManagerFullName";

            dgv_ProjectSearchResults.Columns.Add("ManagerUserName", "User Name");
            dgv_ProjectSearchResults.Columns["ManagerUserName"].DataPropertyName = "ManagerUserName";

            dgv_ProjectSearchResults.Columns.Add("ProjectStatus", "Status");
            dgv_ProjectSearchResults.Columns["ProjectStatus"].DataPropertyName = "ProjectStatus";

            dgv_ProjectSearchResults.Columns.Add("SpecializationsString", "Requirements");
            dgv_ProjectSearchResults.Columns["SpecializationsString"].DataPropertyName = "SpecializationsString";

            dgv_ProjectSearchResults.Columns.Add("ProjectStartDate", "Start");
            dgv_ProjectSearchResults.Columns["ProjectStartDate"].DataPropertyName = "ProjectStartDate";

            dgv_ProjectSearchResults.Columns.Add("ProjectEndDate", "End");
            dgv_ProjectSearchResults.Columns["ProjectEndDate"].DataPropertyName = "ProjectEndDate";

            dgv_ProjectSearchResults.Columns.Add("ProjectModifyDate", "Last Modified");
            dgv_ProjectSearchResults.Columns["ProjectModifyDate"].DataPropertyName = "ProjectModifyDate";

            //List<string> allSpecializations = specializationService.ListDefinedSpecializations();
            //projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).OrderBy(i => i.Title).ToList();
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

            //usersSearchResults = userService.GetAllUsers().OrderBy(i => i.UserName).ToList();
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
        /// Updates the page-wide UserModel with the new information in the textboxes /Dennis Kempf
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
        /// Changes the Edit Profile button to either activate or deactivate the controls, so the user
        /// can edit their profile info. Calls a save on the data if the user wants to save changes.
        /// </summary>
        private void ChangeEditProfileState()
        {
            if (bt_EditProfile.Text == "Edit Profile")
            {
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, true);
                bt_EditProfile.Text = "Save Changes";
                bt_EditProfileCancel.Enabled = true;
                bt_EditProfileCancel.Visible = true;
            }
            else
            {
                UpdateUserModel();
                userService.UpdateUser(adminUser);
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditProfileCancel.Enabled = false;
                bt_EditProfileCancel.Visible = false;
                bt_EditProfile.Text = "Edit Profile";
            }
        }

        /// <summary>
        /// Searches and Filters Users based on text in search field and selected Radio Buttons. /Dennis Kempf
        /// </summary>
        private void PerformUserSearch(string userName = "")
        {
            Cursor = Cursors.WaitCursor;

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

            usersSearchResults = usersSearchResults.Where(x => x.UserName.ToLower().Contains(searchString.ToLower())
                    || x.FullName.ToLower().Contains(searchString.ToLower())
                    || x.ID.ToString().Contains(searchString.ToLower()))
                    .OrderBy(o => o.UserName).ToList();

            dgv_UserSearchResults.DataSource = usersSearchResults;
            userGuiHelper.StartingSortedColumnIndex = 1;

            if (!string.IsNullOrWhiteSpace(userName))
            {
                int index = usersSearchResults.FindIndex(i => i.UserName == userName);
                if (index >= 0)
                {
                    dgv_UserSearchResults.Rows[index].Selected = true;
                    dgv_UserSearchResults.FirstDisplayedScrollingRowIndex = index;
                }
            }
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Searches and Filters Projects based on text in search field and selected Radio Buttons. /Dennis Kempf
        /// </summary>
        private void PerformProjectSearch(int selectThisProjectAfterSearch = 0)
        {
            Cursor = Cursors.WaitCursor;
            string searchString = txtBox_ProjectSearchParams.Text;
            List<string> allSpecializations = specializationService.ListDefinedSpecializations();
            dgv_ProjectSearchResults.DataSource = null;

            if (radio_AllProjects.Checked)
            {
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations, true).ToList();
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
                projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations, true).Where(x => x.ProjectStatus.ToLower() == "ended").ToList();
            }

            projectsSearchResults = projectsSearchResults.Where(i => i.Title.ToLower().Contains(searchString.ToLower())
                || i.ManagerFullName.ToLower().Contains(searchString.ToLower())
                || i.ManagerUserName.ToLower().Contains(searchString.ToLower()))
                .OrderBy(o => o.Title).ToList();

            dgv_ProjectSearchResults.DataSource = projectsSearchResults;
            projectGuiHelper.StartingSortedColumnIndex = 1;

            if (selectThisProjectAfterSearch != 0)
            {
                int index = projectsSearchResults.FindIndex(i => i.ProjectId == selectThisProjectAfterSearch);
                if (index >= 0)
                {
                    dgv_ProjectSearchResults.Rows[index].Selected = true;
                    dgv_ProjectSearchResults.FirstDisplayedScrollingRowIndex = index;
                }
            }
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Redraws and resizes the datagridview after the databinding has been completed. Works with window resizing. /Dennis Kempf
        /// </summary>
        private void dgv_UserSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        /// <summary>
        /// Opens the relevant Form that is selected from searched Users to View their profile and Edit.
        /// </summary>
        private void OpenUserProfile(string userName, string userType)
        {
            try
            {
                if (userType.ToLower() == "manager")
                {
                    Manager manager = new Manager(ServiceManager, userName);
                    manager.ShowDialog();
                    PerformUserSearch(userName);
                }
                if (userType.ToLower() == "consultant")
                {
                    Consultant consultant = new Consultant(ServiceManager, userName);
                    consultant.ShowDialog();
                    PerformUserSearch(userName);
                }
                if (userType.ToLower() == "admin")
                {
                    userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, "Admin's can't edit other Admins.", Color.Red);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred.\n" + ex.Message);
            }
            finally { this.Show(); }
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
        /// Opens a Manager form directly to the edit-panel of the project.
        /// </summary>
        private void OpenProject(IProjectModel targetProject)
        {
            ManageProject ManageProjectForm = new ManageProject(ServiceManager, targetProject.ProjectId, adminUser.UserName);
            ManageProjectForm.ShowDialog();
        }

        /// <summary>
        /// Deletes the User when the admin presses the delete user button. Shows a dialog box for confirmation.
        /// Provides an error message if it didn't succeed. Provides a success message if it did succeed.
        /// </summary>
        private void DeleteUser()
        {
            if (dgv_UserSearchResults.SelectedRows.Count > 0)
            {
                var confirmation = MessageBox.Show(this, "Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.OKCancel);
                if (confirmation == DialogResult.OK)
                {
                    try
                    {
                        var user = dgv_UserSearchResults.SelectedRows[0].DataBoundItem as IUserModel;
                        int userId = user.ID;

                        if (user.UserType.ToLower() != "consultant")
                        {
                            userService.Delete(userId);
                            PerformUserSearch();
                            userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, "User successfully deleted.", Color.Green);
                        }
                        else
                        {
                            userService.DeleteConsultantStoredProcedure(user.ID);
                            PerformUserSearch();
                            userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, "User successfully deleted.", Color.Green);
                        }
                    }
                    catch (Exception e)
                    {
                        userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, e.Message, Color.Red);
                    }
                }
            }
        }

        /// <summary>
        /// Calls for the deletion of a project when the delete project button is pressed. /Dennis Kempf
        /// </summary>
        private void DeleteProject()
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count > 0)
            {
                var confirmation = MessageBox.Show(this, "Are you sure you want to delete this project?", "Delete Project", MessageBoxButtons.OKCancel);
                if (confirmation == DialogResult.OK)
                {
                    try
                    {
                        int projectId = int.Parse(dgv_ProjectSearchResults.SelectedRows[0].Cells["ProjectId"].Value.ToString());
                        projectService.DeleteProject(projectId);
                        PerformProjectSearch();

                        userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, "Project successfully deleted.", Color.Green);
                    }
                    catch (Exception e)
                    {
                        userGuiHelper.FeedBackMessage(lbl_FeedbackUserTab, e.Message, Color.Red);
                    }
                }
            }
        }

        private void bt_EditProfileCancel_Click(object sender, EventArgs e)
        {
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Visible = false;
            bt_EditProfile.Text = "Edit Profile";
            GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, false);
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
                string userName = dgv_UserSearchResults.SelectedRows[0].Cells["UserName"].Value.ToString();
                string userType = dgv_UserSearchResults.SelectedRows[0].Cells["UserType"].Value.ToString().ToLower();
                OpenUserProfile(userName, userType);
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            OpenNewUserForm();
        }

        private void btn_EditProject_Click(object sender, EventArgs e)
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count != 0)
            {
                OpenProject(dgv_ProjectSearchResults.SelectedRows[0].DataBoundItem as IProjectModel);
            }
        }

        private void btn_EditProjectDetails_Click(object sender, EventArgs e)
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count != 0)
            {
                AdminProjectEdit EditProjectForm = new AdminProjectEdit(ServiceManager, dgv_ProjectSearchResults.SelectedRows[0].DataBoundItem as IProjectModel);
                EditProjectForm.ShowDialog();
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            DeleteProject();
        }

        private void btn_DetailsEdit_Click(object sender, EventArgs e)
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count != 0)
            {
                var project = dgv_ProjectSearchResults.SelectedRows[0].DataBoundItem as IProjectModel;
                AdminProjectEdit EditProjectForm = new AdminProjectEdit(ServiceManager, project);
                EditProjectForm.ShowDialog();
                PerformProjectSearch(project.ProjectId);
            }
        }

        private void btn_ViewInvites_Click(object sender, EventArgs e)
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count != 0)
            {
                AdminViewInvites ViewInvitesForm = new AdminViewInvites(ServiceManager, dgv_ProjectSearchResults.SelectedRows[0].DataBoundItem as IProjectModel);
                ViewInvitesForm.ShowDialog();
            }
        }

        private void dgv_UserSearchResults_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userGuiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_UserSearchResults, e, usersSearchResults);
        }

        private void dgv_ProjectSearchResults_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            projectGuiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_ProjectSearchResults, e, projectsSearchResults);
        }

        private void txtBox_UserSearchParams_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformUserSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_InvoiceDetails_Click(object sender, EventArgs e)
        {
            if (dgv_ProjectSearchResults.SelectedRows.Count != 0)
            {
                AdminViewInvoice ViewInvoiceForm = new AdminViewInvoice(ServiceManager, dgv_ProjectSearchResults.SelectedRows[0].DataBoundItem as IProjectModel);
                ViewInvoiceForm.ShowDialog();
            }
        }
    }
}