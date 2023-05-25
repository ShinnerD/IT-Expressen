using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System.Threading;

namespace GUI
{
    public partial class ConsultantAdd : Form
    {
        //Initializeing og the service/models need for the form /MS
        public int ProjectID { get; set; }

        private List<IUserModel> SearchResults { get; set; }
        private IProjectModel ProjectGet { get; set; }

        private readonly IDomainServiceManager ServiceManager;
        private IUserService userService;
        private ISpecializationService SpecService;

        private List<string> ProjectSpecializations { get; set; }

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        //Constructor method loaded with project ID. All relevent data is loaded /MS
        public ConsultantAdd(IDomainServiceManager serviceManager, int projectID)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            userService = ServiceManager.UserService;
            SpecService = ServiceManager.SpecializationService;

            ProjectID = projectID;

            InitializeComponent();

            lblFeedback.Text = "";

            GetProjectInfo();

            SetupProjectRequirementsList();
            SetupSkillsCheckList();

            SetupDataGridView();
        }

        /// <summary>
        /// Finds the required users according to search params and then sets the datagridview to represent that list.
        /// </summary>
        private void LoadSearchResults()
        {
            Cursor = Cursors.WaitCursor;

            List<string> searchParams = GetSpecializationSearchParameters();

            if (!radioBtnAll.Checked)
            {
                SearchResults = userService.GetUsersWithAnySpecializations(searchParams);
            }
            else
            {
                SearchResults = userService.GetUsersWithAllSpecializations(searchParams);
            }

            SpecService.FillUserSpecializationsProperty(SearchResults);

            dgv_ConsultantList.DataSource = SearchResults.OrderBy(i => i.FullName).ToList();

            Cursor = Cursors.Default;
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

            if (result.Count <= 0)
            {
                result.AddRange(checkedListSkills.Items.Cast<string>());
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

            dgv_ConsultantList.Columns.Add("FullName", "Consultant");
            dgv_ConsultantList.Columns["FullName"].DataPropertyName = "FullName";
            dgv_ConsultantList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ConsultantList.Columns["FullName"].FillWeight = 100;

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
            IProjectService projectService = ServiceManager.ProjectService;
            ISpecializationService specializationService = SpecService;

            ProjectGet = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
        }

        //Method for creating an invite linked to the project. The invited users ID is added from the dgv. /MS
        public void CreateInvite()
        {
            try
            {
                IInviteService inviteService = ServiceManager.InviteService;

                inviteService.AddInvites(
                    ProjectGet.ProjectId,
                    (int)dgv_ConsultantList.CurrentRow.Cells["UserId"].Value,
                    DateTime.Now,
                    "Pending");

                string successMessage = "Invite Sent to " + (string)dgv_ConsultantList.CurrentRow.Cells["FullName"].Value;
                FeedBackMessage(lblFeedback, successMessage, Color.Green);
            }
            catch (Exception e)
            {
                FeedBackMessage(lblFeedback, e.Message, Color.Red);
            }

        }

        /// <summary>
        /// Async Task that turns on the visibility of the label provided in the parameters,
        /// shows the given message in the given color, for the given time. /DK
        /// </summary>
        private async Task FeedBackMessage(Label label, string message, Color? color = null, int milliseconds = 5000)
        {
            label.Text = message.Trim();
            label.ForeColor = color ?? Color.Black;
            label.Visible = true;
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            await Task.Delay(milliseconds, _cancellationTokenSource.Token);
            label.Text = string.Empty;
            label.ForeColor = Color.Black;
            label.Visible = false;
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
            try
            {
                ISpecializationService specService = SpecService;
                List<string> items = specService.ListDefinedSpecializations().OrderBy(i => i).ToList();

                foreach (var item in items)
                {
                    checkedListSkills.Items.Add(item);
                    if (ProjectSpecializations.Contains(item)) checkedListSkills.SetItemChecked(checkedListSkills.Items.Count - 1, true);
                }
            }
            catch (Exception)
            {
                FeedBackMessage(lblFeedback, "Failed to retrieve skills from server.", Color.Red);
            }
        }

        // Sets up the right side list box of specializations chosen for the project that is currently being invited to.
        private void SetupProjectRequirementsList()
        {
            //Try-Catch for getting specializations
            try
            {
                checkedListProjReq.Items.AddRange(ServiceManager.SpecializationService.GetProjectSpecializations(ProjectID).ToArray());
                /// Checks off the skills in the specializations list.
                for (int i = 0; i < checkedListProjReq.Items.Count; i++)
                {
                    checkedListProjReq.SetItemChecked(i, true);
                }
            }
            catch (Exception)
            {
                FeedBackMessage(lblFeedback, "Failed to retrieve list of defined skills", Color.Red);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadSearchResults();
        }
    }
}