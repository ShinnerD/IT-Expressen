using DAL.Models;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Consultant : Form
    {
        private IUserService userServiceGet;

        private readonly IDomainServiceManager ServiceManager;

        private string Username;

        private IUserModel userModelGet;

        private List<IProjectModel> ProjectList = new List<IProjectModel>();

        private GuiHelper guiHelper = new();

        public Consultant(IDomainServiceManager domainServiceManager, string username)
        {
            ServiceManager = domainServiceManager ?? throw new ArgumentNullException(nameof(domainServiceManager));
            userServiceGet = domainServiceManager.UserService;
            guiHelper.StartingSortedColumnIndex = 1;

            InitializeComponent();
            Username = username;
            GetUser();
            SetUpTB();
            DataGridInitialSetup();
            LoadInvitesToDGV();
        }

        /// <summary>
        /// (JQ)This method retrieves and sets the user information using IUserService.
        /// </summary>
        private void GetUser()
        {
            userModelGet = userServiceGet.GetUserFromUsername(Username);
        }

        /// <summary>
        /// (JQ)Sets up text boxes to show user information from userModel property.
        /// </summary>
        private void SetUpTB()
        {
            grpBoxProfileInfo.Text = userModelGet.UserName;
            tb_Firstname.Text = userModelGet.FirstName;
            tb_Lastname.Text = userModelGet.LastName;
            tb_Email.Text = userModelGet.EMail;
            tb_Phonenumber.Text = userModelGet.PhoneNumber;
            tb_City.Text = userModelGet.NameCity;
            tb_Address.Text = userModelGet.Address;
            tb_Zipcode.Text = userModelGet.ZipCode;
            tb_Country.Text = userModelGet.Country;
            lblUserCreationDate.Text = "You've been a user for " + (DateTime.Now - userModelGet.CreationDate).GetValueOrDefault().Days.ToString() + " days";
        }

        /// <summary>
        /// Changes the form to allow editing of the consultants profile and specializations. /Dennis Kempf
        /// </summary>
        private void ChangeEditProfileState()
        {
            if (bt_Edit.Text == "Edit Profile")
            {
                //Setup the elements needed to edit the profile.
                checkedListSkills.Items.Clear();
                var userSpecs = ServiceManager.SpecializationService.GetUserSpecializations(userModelGet.ID);
                checkedListSkills.Items.AddRange(ServiceManager.SpecializationService.ListDefinedSpecializations().ToArray());
                foreach (var skill in userSpecs)
                {
                    checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(skill), true);
                }
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, true);
                bt_Edit.Text = "Save Changes";
                bt_EditCancel.Enabled = true;
                bt_EditCancel.Visible = true;
                grpBoxProjects.Visible = false;
                grpBoxSpecializations.Visible = true;
            }
            else
            {
                SaveProfileChanges();
            }
        }

        /// <summary>
        /// Gets called when you click the "Save Changes" button - tries to update the user profile via the domain layer.
        /// displays an error message via the feedback label if not successful. /Dennis Kempf
        /// </summary>
        private void SaveProfileChanges()
        {
            try
            {
                UpdateUserModel();
                IUserService userService = userServiceGet;
                userService.UpdateUser(userModelGet);
                List<string> specializations = checkedListSkills.CheckedItems.Cast<string>().ToList();
                ServiceManager.SpecializationService.UpdateUserSpecializations(userModelGet, specializations);
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditCancel.Enabled = false;
                bt_EditCancel.Visible = false;
                bt_Edit.Text = "Edit Profile";
                grpBoxSpecializations.Visible = false;
                grpBoxProjects.Visible = true;
                guiHelper.FeedBackMessage(lbl_FeedBackLabel, "Profile updated successfully.", Color.Green);
            }
            catch (Exception ex)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackLabel, ex.Message, Color.Red);
            }
        }

        private void UpdateUserModel()
        {
            userModelGet.FirstName = tb_Firstname.Text;
            userModelGet.LastName = tb_Lastname.Text;
            userModelGet.EMail = tb_Email.Text;
            userModelGet.PhoneNumber = tb_Phonenumber.Text;
            userModelGet.Address = tb_Address.Text;
            userModelGet.NameCity = tb_City.Text;
            userModelGet.ZipCode = tb_Zipcode.Text;
            userModelGet.Country = tb_Country.Text;
        }

        /// <summary>
        /// (JQ)Handle button click event for searching projects and passes userId to the ConsultantSearchProjects form.
        /// </summary>
        private void bt_SearchProjects_Click(object sender, EventArgs e)
        {
            int userId = userModelGet.ID;
            ConsultantSearchProjects viewProjectsForm = new ConsultantSearchProjects(ServiceManager, userId);
            viewProjectsForm.ShowDialog();
        }

        /// <summary>
        /// Clears and loads the Datagridview //MS
        /// </summary>
        private void LoadInvitesToDGV()
        {
            dgv_ConsultantsInvites.DataSource = null;
            ProjectList = ServiceManager.ProjectService.GetConsultantProjects(userModelGet);
            dgv_ConsultantsInvites.DataSource = ProjectList;
            guiHelper.StartingSortedColumnIndex = 1;
        }

        private void DataGridInitialSetup()
        {
            dgv_ConsultantsInvites.AutoGenerateColumns = false;
            dgv_ConsultantsInvites.StandardTab = true;

            dgv_ConsultantsInvites.Columns.Add("ManagerFullName", "Owner");
            dgv_ConsultantsInvites.Columns["ManagerFullName"].DataPropertyName = "ManagerFullName";

            dgv_ConsultantsInvites.Columns.Add("Title", "Project Name");
            dgv_ConsultantsInvites.Columns["Title"].DataPropertyName = "Title";

            dgv_ConsultantsInvites.Columns.Add("Status", "Status");
            dgv_ConsultantsInvites.Columns["Status"].DataPropertyName = "ProjectStatus";

            dgv_ConsultantsInvites.Columns.Add("Start", "Start");
            dgv_ConsultantsInvites.Columns["Start"].DataPropertyName = "ProjectStartDate";
            dgv_ConsultantsInvites.Columns["Start"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_ConsultantsInvites.Columns.Add("End", "End");
            dgv_ConsultantsInvites.Columns["End"].DataPropertyName = "ProjectEndDate";
            dgv_ConsultantsInvites.Columns["End"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        //Opens the form to accept the selected invitation, then refreshes the datagridview /MS
        private void bt_seeInviteDetails_Click(object sender, EventArgs e)
        {
            if (dgv_ConsultantsInvites.SelectedRows.Count > 0)
            {
                var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;
                AcceptInviteForm AccInvForm = new AcceptInviteForm(ServiceManager, selectedProject);
                this.Hide();
                AccInvForm.ShowDialog();
                this.Show();
                LoadInvitesToDGV();
            }
        }

        private void EditCancel()
        {
            bt_EditCancel.Enabled = false;
            bt_EditCancel.Visible = false;
            bt_Edit.Text = "Edit Profile";
            GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, false);
            grpBoxSpecializations.Visible = false;
            grpBoxProjects.Visible = true;
            SetUpTB();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            ChangeEditProfileState();
        }

        private void bt_EditCancel_Click(object sender, EventArgs e)
        {
            EditCancel();
        }

        private void bt_seeInvites_Click(object sender, EventArgs e)
        {
            var userName = userModelGet.UserName;
            ConsultantInvites seeInv = new ConsultantInvites(ServiceManager, userName);
            this.Hide();
            seeInv.ShowDialog();
            this.Show();
            LoadInvitesToDGV();
        }

        private void bt_seeProjects_Click(object sender, EventArgs e)
        {
            if (dgv_ConsultantsInvites.SelectedRows.Count > 0)
            {
                var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as ProjectModel;
                ManageProject AccInvForm = new ManageProject(ServiceManager, selectedProject.ProjectId, Username);
                this.Hide();
                AccInvForm.ShowDialog();
                this.Show();
                LoadInvitesToDGV();
            }
        }

        private void dgv_ConsultantsInvites_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        private void dgv_ConsultantsInvites_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_ConsultantsInvites, e, ProjectList);
        }
    }
}