using DAL.Linq;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Manager : Form
    {
        private string Username;
        private IUserModel userModel;

        private readonly IDomainServiceManager ServiceManager;
        private IProjectService projectService;

        private List<IProjectModel> ProjectList;
        public IProjectModel SelectedProject { get; set; }

        private GuiHelper guiHelper = new GuiHelper();

        public Manager(IDomainServiceManager serviceManager, string username)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            projectService = ServiceManager.ProjectService;
            guiHelper.StartingSortedColumnIndex = 0;
            InitializeComponent();
            Username = username;
            GetUser();

            SetUpTB();
            SetUpProjects();
        }

        /// <summary>
        /// Sets up the DataGridView with correct columns and projects.
        /// </summary>
        private void SetUpProjects()
        {
            try
            {
                ProjectList = projectService.GetUserProjects(userModel.ID).ToList();
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_ViewProjectsFeedBack, "Unable to retrieve projects.", Color.Red);
            }
            finally
            {
                dgv_Viewproject.AutoGenerateColumns = false;
                dgv_Viewproject.StandardTab = true;

                dgv_Viewproject.Columns.Add("Title", "Project Name");
                dgv_Viewproject.Columns["Title"].DataPropertyName = "Title";

                dgv_Viewproject.Columns.Add("Status", "Status");
                dgv_Viewproject.Columns["Status"].DataPropertyName = "ProjectStatus";

                dgv_Viewproject.Columns.Add("Start", "Start");
                dgv_Viewproject.Columns["Start"].DataPropertyName = "ProjectStartDate";
                dgv_Viewproject.Columns["Start"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

                dgv_Viewproject.Columns.Add("End", "End");
                dgv_Viewproject.Columns["End"].DataPropertyName = "ProjectEndDate";
                dgv_Viewproject.Columns["End"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

                dgv_Viewproject.Columns.Add("Invoiced", "Invoice Total");
                dgv_Viewproject.Columns["Invoiced"].DataPropertyName = "TotalInvoicePrice";
                dgv_Viewproject.Columns["Invoiced"].DefaultCellStyle.Format = "F2";

                dgv_Viewproject.DataSource = ProjectList;
            }
        }

        /// <summary>
        /// (JQ)This method retrieves and sets the user information using IUserService.
        /// </summary>
        private void GetUser()
        {
            IUserService userService = ServiceManager.UserService;
            userModel = userService.GetUserFromUsername(Username);
        }

        /// <summary>
        /// (JQ)Sets up text boxes to show user information from userModel property.
        /// </summary>
        private void SetUpTB()
        {
            grpBoxProfileInfo.Text = userModel.UserName;
            tb_Firstname.Text = userModel.FirstName;
            tb_Lastname.Text = userModel.LastName;
            tb_Email.Text = userModel.EMail;
            tb_Phonenumber.Text = userModel.PhoneNumber;
            tb_City.Text = userModel.NameCity;
            tb_Address.Text = userModel.Address;
            tb_Zipcode.Text = userModel.ZipCode;
            tb_Country.Text = userModel.Country;
            lblUserCreationDate.Text = "You've been a user for " + (DateTime.Now - userModel.CreationDate).GetValueOrDefault().Days.ToString() + " days";
        }

        /// <summary>
        /// Changes the Form into editing the currently selected project from the projects list. /DK
        /// </summary>
        private void EditSelectedProject()
        {
            if (SelectedProject != null)
            {
                EditProjectDetails(SelectedProject);
            }
        }

        /// <summary>
        /// Sets the form to Edit Selected Project "mode." /DK
        /// </summary>
        /// <param name="selectedProject"></param>
        private void EditProjectDetails(IProjectModel selectedProject)
        {
            ViewProjectsGrpBox.Visible = false;
            NewProjectGrpBox.Visible = true;
            btn_NewProjectSave.Text = "Update Project";
            txtBox_ProjectTitle.Text = selectedProject.Title;
            txtBox_ProjectDescription.Text = selectedProject.Description;
            dtp_NewProjectStartDate.Value = selectedProject.ProjectStartDate ?? dtp_NewProjectStartDate.MinDate;
            dtp_NewProjectEndDate.Value = selectedProject.ProjectEndDate ?? dtp_NewProjectEndDate.MinDate;
            CheckProjectSkills();
        }

        /// <summary>
        /// Checks off the correct skills in the specializations list.
        /// </summary>
        private void CheckProjectSkills()
        {
            foreach (var specialization in ServiceManager.SpecializationService.GetProjectSpecializations(SelectedProject.ProjectId))
            {
                checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(specialization), true);
            }
        }

        /// <summary>
        /// Opens the form for searching for matching consultants for a project /MS
        /// </summary>
        private void InvitedConsultantSelectedProject()
        {
            if (dgv_Viewproject.SelectedRows.Count > 0)
            {
                SelectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            }
            if (SelectedProject != null)
            {
                InviteConsultants invConSul = new InviteConsultants(ServiceManager, SelectedProject.ProjectId);
                this.Hide();
                invConSul.ShowDialog();
                this.Show();
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
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, true);
                bt_EditProfile.Text = "Save Changes";
                bt_EditProfileCancel.Enabled = true;
                bt_EditProfileCancel.Visible = true;
            }
            else
            {
                UpdateUserModel();
                IUserService userService = ServiceManager.UserService;
                userService.UpdateUser(userModel);
                GuiHelper.UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditProfileCancel.Enabled = false;
                bt_EditProfileCancel.Visible = false;
                bt_EditProfile.Text = "Edit Profile";
            }
        }

        /// <summary>
        /// Updates the page-wide userModel with the new information in the textboxes /DK
        /// </summary>
        private void UpdateUserModel()
        {
            userModel.FirstName = tb_Firstname.Text;
            userModel.LastName = tb_Lastname.Text;
            userModel.EMail = tb_Email.Text;
            userModel.PhoneNumber = tb_Phonenumber.Text;
            userModel.Address = tb_Address.Text;
            userModel.NameCity = tb_City.Text;
            userModel.ZipCode = tb_Zipcode.Text;
            userModel.Country = tb_Country.Text;
        }

        /// <summary>
        /// Opens a form for managing the selected project.
        /// </summary>
        private void ManageProject()
        {
            if (dgv_Viewproject.SelectedRows.Count > 0)
            {
                SelectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
                ManageProject ManProject = new GUI.ManageProject(ServiceManager, SelectedProject.ProjectId, Username);
                this.Hide();
                ManProject.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Adds the database specializations to the checklist.
        /// </summary>
        private void SetupSkillsCheckList()
        {
            checkedListSkills.Items.Clear();

            List<string> items = ServiceManager.SpecializationService.ListDefinedSpecializations();

            foreach (var item in items)
            {
                checkedListSkills.Items.Add(item);
            }
        }

        /// <summary>
        /// Goes to the ViewProjectsGroupBox
        /// </summary>
        private void BackToViewProjects()
        {
            txtBox_ProjectTitle.Clear();
            txtBox_ProjectDescription.Clear();
            dtp_NewProjectEndDate.Value = DateTime.Now;
            dtp_NewProjectStartDate.Value = DateTime.Now;
            checkedListSkills.ClearSelected();
            NewProjectGrpBox.Visible = false;
            ViewProjectsGrpBox.Visible = true;
            dgv_Viewproject.DataSource = null;
            ProjectList = null;
            ProjectList = projectService.GetUserProjects(userModel.ID).ToList();
            dgv_Viewproject.DataSource = ProjectList;
            guiHelper.StartingSortedColumnIndex = 0;
        }

        /// <summary>
        /// Updates the information on the current project and tries to save them in the database.
        /// </summary>
        private void UpdateProject()
        {
            try
            {
                List<string> reqSkills = FindCheckedSkills();

                SelectedProject.Title = txtBox_ProjectTitle.Text;
                SelectedProject.Description = txtBox_ProjectDescription.Text;
                SelectedProject.ProjectStartDate = dtp_NewProjectStartDate.Value;
                SelectedProject.ProjectEndDate = dtp_NewProjectEndDate.Value;

                projectService.UpdateProject(SelectedProject, reqSkills);

                BackToViewProjects();
            }
            catch (Exception e)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, e.Message, Color.Red);
            }
        }

        /// <summary>
        /// Returns a list of strings with the checked items in the check list.
        /// </summary>
        private List<string> FindCheckedSkills()
        {
            List<string> result = new List<string>();

            foreach (var skill in checkedListSkills.CheckedItems)
            {
                result.Add(skill.ToString());
            }
            return result;
        }

        /// <summary>
        /// Saves a new Project to the database
        /// </summary>
        private void SaveNewProject()
        {
            try
            {
                List<string> reqSkills = FindCheckedSkills();

                projectService.CreateProject(userModel.ID, txtBox_ProjectTitle.Text, txtBox_ProjectDescription.Text, dtp_NewProjectStartDate.Value, dtp_NewProjectEndDate.Value, reqSkills);

                BackToViewProjects();
            }
            catch (Exception e)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, e.Message, Color.Red);
            }
        }

        private void bt_manageProject_Click(object sender, EventArgs e)
        {
            ManageProject();
        }

        private void btn_NewProjectBack_Click(object sender, EventArgs e)
        {
            BackToViewProjects();
        }

        private void btn_NewProject_Click(object sender, EventArgs e)
        {
            ViewProjectsGrpBox.Visible = false;
            NewProjectGrpBox.Visible = true;
            btn_NewProjectSave.Text = "Save Project";
            NewProjectGrpBox.Text = "New Project";
        }

        private void NewProjectGrpBox_VisibleChanged(object sender, EventArgs e)
        {
            SetupSkillsCheckList();
        }

        private void dgv_Viewproject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Viewproject.SelectedRows.Count > 0)
            {
                SelectedProject = (IProjectModel)dgv_Viewproject.SelectedRows[0].DataBoundItem;
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

        private void btn_NewProjectSave_Click(object sender, EventArgs e)
        {
            if (btn_NewProjectSave.Text == "Save Project")
            {
                SaveNewProject();
            }
            else
            {
                UpdateProject();
            }
        }

        public void bt_EditProject_Click(object sender, EventArgs e)
        {
            NewProjectGrpBox.Text = "Update Project";
            EditSelectedProject();
        }

        private void bt_FindConsultants_Click(object sender, EventArgs e)
        {
            InvitedConsultantSelectedProject();
        }

        private void bt_EditProfile_Click(object sender, EventArgs e)
        {
            ChangeEditProfileState();
        }

        private void tb_Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_AddConsultant_Click(object sender, EventArgs e)
        {
            if (dgv_Viewproject.SelectedRows.Count > 0)
            {
                int clickedProjectId = (dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel).ProjectId;
                ConsultantAdd invConSul = new ConsultantAdd(ServiceManager, clickedProjectId);
                invConSul.ShowDialog();
                invConSul.Dispose();
            }

        }

        private void dgv_Viewproject_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_Viewproject, e, ProjectList);
        }

        private void dgv_Viewproject_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        private void btn_ViewInvoice_Click(object sender, EventArgs e)
        {
            if (dgv_Viewproject.SelectedRows.Count > 0)
            {
                IProjectModel clickedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
                ManagerViewInvoice viewInvoice = new ManagerViewInvoice(ServiceManager, clickedProject);
                viewInvoice.ShowDialog();
                viewInvoice.Dispose();
                BackToViewProjects();
            }
        }
    }
}