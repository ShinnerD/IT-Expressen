using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantAdd : Form
    {
        //Initializeing og the service/models need for the form /MS
        public int ProjectID { get; set; }

        private List<IUserModel> SearchResults { get; set; }
        private IProjectModel ProjectGet { get; set; }

        private IUserService UserService = new UserService();
        private ISpecializationService SpecService = new SpecializationService();

        private List<string> ProjectSpecializations { get; set; }

        //Constructor method loaded with project ID. All relevent data is loaded /MS
        public ConsultantAdd(int projectID)
        {
            ProjectID = projectID;
            ProjectSpecializations = SpecService.GetProjectSpecializations(ProjectID);

            InitializeComponent();
            lblFeedback.Text = "";

            GetProjectInfo();

            SetupProjectRequirementsList();
            SetupSkillsCheckList();

            SetupDataGridView();
            LoadSearchResults();
        }

        /// <summary>
        /// Finds the required users according to search params and then sets the datagridview to represent that list.
        /// </summary>
        private void LoadSearchResults()
        {
            List<string> searchParams = GetSpecializationSearchParameters();

            if (!radioBtnAll.Checked)
            {
                SearchResults = UserService.GetUsersWithAnySpecializations(searchParams);
            }
            else
            {
                SearchResults = UserService.GetUsersWithAllSpecializations(searchParams);
            }

            SpecService.FillUserSpecializationsProperty(SearchResults);

            dgv_ConsultantList.DataSource = SearchResults;
        }

        /// <summary>
        /// Returns a List of strings representing the checked specializations in the specialization search parameter list on the Form.
        /// </summary>
        private List<string> GetSpecializationSearchParameters()
        {
            List<string> result = new List<string>();

            foreach (string specialization in checkedListSkills.CheckedItems)
            {
                result.Add(specialization);
            }

            return result;
        }

        //Loads dgv_ConsultantList, rearrange the order and disables certain columns /MS
        private void SetupDataGridView()
        {
            dgv_ConsultantList.AutoGenerateColumns = false;

            dgv_ConsultantList.Columns.Add("UserId", "User Id");
            dgv_ConsultantList.Columns["UserId"].DataPropertyName = "ID";
            dgv_ConsultantList.Columns["UserId"].Visible = false;

            dgv_ConsultantList.Columns.Add("UserName", "Consultant");
            dgv_ConsultantList.Columns["UserName"].DataPropertyName = "UserName";
            dgv_ConsultantList.Columns["UserName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ConsultantList.Columns["UserName"].FillWeight = 100;

            dgv_ConsultantList.Columns.Add("Country", "Country");
            dgv_ConsultantList.Columns["Country"].DataPropertyName = "Country";
            dgv_ConsultantList.Columns["Country"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ConsultantList.Columns["Country"].FillWeight = 100;

            dgv_ConsultantList.Columns.Add("Specializations", "Specializations");
            dgv_ConsultantList.Columns["Specializations"].DataPropertyName = "Specializations";
            dgv_ConsultantList.Columns["Specializations"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ConsultantList.Columns["Specializations"].FillWeight = 90;
        }

        //Gets data on projects and specializations /MS
        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            ProjectGet = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
        }

        //Method for creating an invite linked to the project. The invited users ID is added from the dgv. /MS
        public void CreateInvite()
        {
            try
            {
                IInviteService inviteService = new Domain.Services.InviteService();

                inviteService.AddInvites(
                    ProjectGet.ProjectId,
                    (int)dgv_ConsultantList.CurrentRow.Cells["UserId"].Value,
                    DateTime.Now,
                    "Pending");

                lblFeedback.ForeColor = System.Drawing.Color.Green;
                lblFeedback.Text = "Invite Sent to " + (string)dgv_ConsultantList.CurrentRow.Cells["UserName"].Value;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("UNIQUE KEY constraint"))
                {
                    lblFeedback.ForeColor = Color.Red;
                    lblFeedback.Text = "This person already has an invitation to this project.";
                }              
            }
            
        }

        // Button click event -> see method for results /MS
        private void bt_AddConcultant_Click(object sender, EventArgs e)
        {
            CreateInvite();
        }

        // Button click event -> see method for results /MS
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sets up the selection of skills at the initialization of the window /DK
        private void SetupSkillsCheckList()
        {
            ISpecializationService specService = new Domain.Services.SpecializationService();
            List<string> items = specService.ListDefinedSpecializations().OrderBy(i => i).ToList();

            foreach (var item in items)
            {
                checkedListSkills.Items.Add(item);
                if (ProjectSpecializations.Contains(item)) checkedListSkills.SetItemChecked(checkedListSkills.Items.Count - 1, true);
            }

            if (items.Count == 0)
            {
                MessageBox.Show("Failed to retrieve skills from server.");
            }
        }

        // Sets up the right side list box of specializations chosen for the project that is currently being invited to.
        private void SetupProjectRequirementsList()
        {
            listBoxProjectRequirements.DataSource = ProjectSpecializations;
        }

        private void checkedListSkills_MouseUp(object sender, MouseEventArgs e)
        {
            LoadSearchResults();
        }

        private void radioBtnAny_CheckedChanged(object sender, EventArgs e)
        {
            LoadSearchResults();
        }
    }
}