using DAL.Models;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Consultant : Form
    {
        private IInviteService invService;

        private IUserService userServiceGet;

        private readonly IDomainServiceManager ServiceManager;

        private string Username;

        public IUserModel userModelGet;

        private List<IInvitesModel> invites;

        private List<IProjectModel> ProjectList;

        private IProjectService projectService;



        public Consultant(IDomainServiceManager domainServiceManager, string username)
        {
            ServiceManager = domainServiceManager ?? throw new ArgumentNullException(nameof(domainServiceManager));
            invService = domainServiceManager.InviteService;
            userServiceGet = domainServiceManager.UserService;

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

        private void ChangeEditProfileState()
        {
            if (bt_Edit.Text == "Edit Profile")
            {
                UnlockProfileForEditing(grpBoxProfileInfo, true);
                bt_Edit.Text = "Save Changes";
                bt_EditCancel.Enabled = true;
                bt_EditCancel.Visible = true;
            }
            else
            {
                UpdateUserModel();
                IUserService userService = userServiceGet;
                userService.UpdateUser(userModelGet);
                UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditCancel.Enabled = false;
                bt_EditCancel.Visible = false;
                bt_Edit.Text = "Edit Profile";
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
        /// (JQ)Handle button click event for ConsultantViewProjects and passes userId to ConsultantViewProjects form.
        /// </summary>
        private void bt_ViewProjects_Click(object sender, EventArgs e)
        {
            int userId = userModelGet.ID;
            ConsultantViewProjects viewProjectsForm = new ConsultantViewProjects(ServiceManager, userId);
            viewProjectsForm.ShowDialog();
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

            IInviteService inviteService = invService;
            invites = inviteService.GetInvitesFromUserId(userModelGet.ID).Where(i => i.InviteStatus.ToLower() == "accepted").ToList();
            List<IProjectModel> relatedProjects = new List<IProjectModel>();

            foreach (IInvitesModel invite in invites)
            {
                relatedProjects.Add(ServiceManager.ProjectService.GetProject(invite.ProjectId));

            }
            dgv_ConsultantsInvites.DataSource = relatedProjects;
        }

        private void DataGridInitialSetup()
        {
            dgv_ConsultantsInvites.AutoGenerateColumns = false;
            dgv_ConsultantsInvites.StandardTab = true;

            dgv_ConsultantsInvites.Columns.Add("ManagerFullName", "Owner");
            dgv_ConsultantsInvites.Columns["ManagerFullName"].DataPropertyName = "ManagerFullName";

            dgv_ConsultantsInvites.Columns.Add("Title", "Project Name");
            dgv_ConsultantsInvites.Columns["Title"].DataPropertyName = "Title";
            dgv_ConsultantsInvites.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_ConsultantsInvites.Columns.Add("Status", "Status");
            dgv_ConsultantsInvites.Columns["Status"].DataPropertyName = "ProjectStatus";

            dgv_ConsultantsInvites.Columns.Add("Start", "Start");
            dgv_ConsultantsInvites.Columns["Start"].DataPropertyName = "ProjectStartDate";

            dgv_ConsultantsInvites.Columns.Add("End", "End");
            dgv_ConsultantsInvites.Columns["End"].DataPropertyName = "ProjectEndDate";
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
            UnlockProfileForEditing(grpBoxProfileInfo, false);
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
            var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as ProjectModel;
            ManageProject AccInvForm = new ManageProject(ServiceManager, selectedProject.ProjectId, Username);
            this.Hide();
            AccInvForm.ShowDialog();
            this.Show();
            LoadInvitesToDGV();
        }
    }
}