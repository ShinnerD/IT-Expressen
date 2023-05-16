using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class Manager : Form
    {
        public string Username { get; set; }
        public IUserModel userModel { get; set; }

        public Manager(string username)
        {
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

            IProjectService projectService = new ProjectService();

            dgv_Viewproject.DataSource = projectService.GetUserProjects(userModel.ID).OrderBy(i => i.Title).ToList();
        }

        /// <summary>
        /// (JQ)This method opens the NewProject form.
        /// </summary>
        private void OpenNewProjectForm()
        {
            this.Hide();
            Form newProjectForm = new NewProject(Username);
            newProjectForm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// (JQ)This method retrieves and sets the user information using IUserService.
        /// </summary>
        private void GetUser()
        {
            IUserService userService = new UserService();
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
                EditProject editProject = new EditProject(selectedProject.ProjectId);
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
                InviteConsultants invConSul = new InviteConsultants(selectedProject.ProjectId);
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
    }
}