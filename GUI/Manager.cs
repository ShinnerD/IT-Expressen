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

        public Manager(IDomainServiceManager serviceManager, string username)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
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

            dgv_Viewproject.DataSource = ServiceManager.ProjectService.GetUserProjects(userModel.ID).OrderBy(i => i.Title).ToList();
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
            userModel = userService.GetUser(Username);
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
        /// Opens the Form for editing a project. /DK
        /// </summary>
        private void ManageSelectedProject()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            if (selectedProject != null)
            {
                EditProject editProject = new EditProject(ServiceManager, selectedProject.ProjectId);
                this.Hide();
                editProject.ShowDialog();
                this.Show();
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
                ManageProject ManProject = new GUI.ManageProject(selectedProject.ProjectId);
                this.Hide();
                ManProject.ShowDialog();
                this.Show();
            }
        }
        private void bt_manageProject_Click(object sender, EventArgs e)
        {
            ManageProject();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void tb_Firstname_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Phonenumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Lastname_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_City_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Zipcode_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Country_TextChanged(object sender, EventArgs e)
        {
        }

        private void grpBoxProfileInfo_Enter(object sender, EventArgs e)
        {
        }

        private void lblUserCreationDate_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


    }
}