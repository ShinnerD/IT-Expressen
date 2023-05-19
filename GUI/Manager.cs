using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Manager : Form
    {
        private string Username;
        private IUserModel userModel;
        private readonly IDomainServiceManager ServiceManager;
        private List<IProjectModel> ProjectList;
        private IProjectModel SelectedProject;
        private IProjectService projectService;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public Manager(IDomainServiceManager serviceManager, string username)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            projectService = ServiceManager.ProjectService;
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
                FeedBackMessage(lbl_ViewProjectsFeedBack, "Unable to retrieve projects.", Color.Red);
            }
            finally
            {
                dgv_Viewproject.AutoGenerateColumns = false;
                dgv_Viewproject.StandardTab = true;

                dgv_Viewproject.Columns.Add("Title", "Project Name");
                dgv_Viewproject.Columns["Title"].DataPropertyName = "Title";
                dgv_Viewproject.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv_Viewproject.Columns.Add("Status", "Status");
                dgv_Viewproject.Columns["Status"].DataPropertyName = "ProjectStatus";

                dgv_Viewproject.Columns.Add("Start", "Start");
                dgv_Viewproject.Columns["Start"].DataPropertyName = "ProjectStartDate";

                dgv_Viewproject.Columns.Add("End", "End");
                dgv_Viewproject.Columns["End"].DataPropertyName = "ProjectEndDate";

                dgv_Viewproject.Columns.Add("Invoiced", "Invoiced");
                dgv_Viewproject.Columns["Invoiced"].DataPropertyName = "TotalInvoicePrice";

                dgv_Viewproject.DataSource = ProjectList;
            }
        }

        /// <summary>
        /// (JQ)This method opens the NewProject form.
        /// </summary>
        private void OpenNewProjectForm()
        {
            this.Hide();
            Form newProjectForm = new NewProject(ServiceManager, Username);
            newProjectForm.ShowDialog();
            this.Show();
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
        /// (JQ)Handle button click event for OpenNewProjectForm.
        /// </summary>
        private void bt_NewProject_Click(object sender, EventArgs e)
        {
            OpenNewProjectForm();
        }

        /// <summary>
        /// (JQ)Handle button click event for ViewProjects and passes userId to ViewProjects form.
        /// </summary>
        //private void bt_ViewProjects_Click(object sender, EventArgs e)
        //{
        //    int userId = userModel.ID;
        //    ViewProjects viewProjects = new ViewProjects(userId);
        //    viewProjects.ShowDialog();
        //    this.Show();
        //}

        /// <summary>
        /// Changes the Form into editing the currently selected project from the projects list. /DK
        /// </summary>
        private void ManageSelectedProject()
        {
            if (SelectedProject != null)
            {
                EditProjectDetails(SelectedProject);
            }
        }

        private void EditProjectDetails(IProjectModel selectedProject)
        {
            ViewProjectsGrpBox.Visible = false;
            NewProjectGrpBox.Visible = true;
            btn_NewProjectSave.Text = "Update Project";
            txtBox_ProjectTitle.Text = selectedProject.Title;
            txtBox_ProjectDescription.Text = selectedProject.Description;
            dtp_NewProjectStartDate.Value = selectedProject.ProjectStartDate ?? DateTime.MinValue;
            dtp_NewProjectEndDate.Value = selectedProject.ProjectEndDate ?? DateTime.MinValue;
            CheckProjectSkills();
        }

        private void CheckProjectSkills()
        {
            foreach (var specialization in ServiceManager.SpecializationService.GetProjectSpecializations(SelectedProject.ProjectId))
            {
                checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(specialization), true);
            }
        }

        /// <summary>
        /// (JQ)Performs a search for projects matching the given search term and displays them in the DataGridView.
        /// </summary>
        private void SearchProjects()
        {
            // string searchTerm = tb_Search.Text.Trim();
            // List<IProjectModel> projects = projectService.SearchProjects(searchTerm, UserId);
            // dgv_Viewproject.DataSource = projects;
        }

        /// <summary>
        /// Opens the form for searching for matching consultants for a project /MS
        /// </summary>
        private void InvitedConsultantSelectedProject()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            if (selectedProject != null)
            {
                InviteConsultants invConSul = new InviteConsultants(ServiceManager, selectedProject.ProjectId);
                this.Hide();
                invConSul.ShowDialog();
                this.Show();
            }
        }

        private void bt_EditProject_Click(object sender, EventArgs e)
        {
            ManageSelectedProject();
        }

        private void bt_FindConsultants_Click(object sender, EventArgs e)
        {
            InvitedConsultantSelectedProject();
        }

        private void bt_EditProfile_Click(object sender, EventArgs e)
        {
            ChangeEditProfileState();
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
                IUserService userService = ServiceManager.UserService;
                userService.UpdateUser(userModel);
                UnlockProfileForEditing(grpBoxProfileInfo, false);
                bt_EditProfileCancel.Enabled = false;
                bt_EditProfileCancel.Visible = false;
                bt_EditProfile.Text = "Edit Profile";
            }
        }

        /// <summary>
        /// Updates the pagewide userModel with the new information in the textboxes /DK
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

        private void bt_EditProfileCancel_Click(object sender, EventArgs e)
        {
            bt_EditProfileCancel.Enabled = false;
            bt_EditProfileCancel.Visible = false;
            bt_EditProfile.Text = "Edit Profile";
            UnlockProfileForEditing(grpBoxProfileInfo, false);
            SetUpTB();
        }

        private void ManageProject()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            if (selectedProject != null)
            {
                ManageProject ManProject = new GUI.ManageProject(ServiceManager, selectedProject.ProjectId);
                this.Hide();
                ManProject.ShowDialog();
                this.Show();
            }
        }

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
        /// Async Task that turns on the visibility of the label provided in the parameters,
        /// shows the given message in the given color, for the given time. /DK
        /// </summary>
        private async Task FeedBackMessage(Label label, string message, Color? color = null, int milliseconds = 5000)
        {
            label.Text = message;
            label.ForeColor = color ?? Color.Black;
            label.Visible = true;
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            await Task.Delay(milliseconds, _cancellationTokenSource.Token);
            label.Text = string.Empty;
            label.ForeColor = Color.Black;
            label.Visible = false;
        }

        private void bt_manageProject_Click(object sender, EventArgs e)
        {
            ManageProject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FeedBackMessage(lbl_FeedBackNewProject, "You clicked the button. Congrats.");
        }

        private void btn_NewProjectBack_Click(object sender, EventArgs e)
        {
            BackToViewProjects();
        }

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
        }

        private void btn_NewProject_Click(object sender, EventArgs e)
        {
            ViewProjectsGrpBox.Visible = false;
            NewProjectGrpBox.Visible = true;
            btn_NewProjectSave.Text = "Save Project";
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

        private void btn_NewProjectSave_Click(object sender, EventArgs e)
        {
            if (btn_NewProjectSave.Text == "Save Project")
            {
                SaveNewProject();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private List<string> FindCheckedSkills()
        {
            List<string> result = new List<string>();

            foreach (var skill in checkedListSkills.CheckedItems)
            {
                result.Add(skill.ToString());
            }
            return result;
        }

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
                FeedBackMessage(lbl_FeedBackNewProject, e.Message, Color.Red);
            }
        }
    }
}