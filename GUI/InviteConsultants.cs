using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class InviteConsultants : Form
    {
        //Initializeing og the service/models need for the form /MS
        private readonly IDomainServiceManager ServiceManager;

        private int ProjectID { get; set; }
        private IProjectModel ProjectGet;

        private List<IInvitesModel> InviteList;

        private IInviteService invService;

        //Constructor method loaded with project ID. All relevent data is loaded /MS
        public InviteConsultants(IDomainServiceManager serviceManager, int projectID)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            invService = ServiceManager.InviteService;

            ProjectID = projectID;

            InitializeComponent();
            GetProjectInfo();
            LoadProjectData();
        }

        //Constructor method loaded with project model. All relevent data is loaded /MS
        public InviteConsultants(IProjectModel ProjectsSpecs)
        {
            InitializeComponent();
            ProjectGet = ProjectsSpecs;
        }

        //Gets data on projects and specializations /MS
        private void GetProjectInfo()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            ProjectGet = projectService.GetProject(ProjectID);
        }

        //Loads the data transfered into textboxes, and updates the invites list so the user can see the information about the given project //MS
        private void LoadProjectData()
        {
            var selectedProject = ServiceManager.ProjectService.GetProject(ProjectID);

            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_ProjectTitle.Text = ProjectGet.Title;
            tb_ProjectOwner.Text = ServiceManager.UserService.GetUserFromID(selectedProject.UserId).FullName.ToString();
            tb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            rtb_Description.Text = ProjectGet.Description;
        }

        // Button click event -> see method for results /MS
        private void bt_AddConsultant_Click(object sender, EventArgs e)
        {
            OpenConsutantAdd();
        }

        //Opens new form and forwards the project ID /MS
        private void OpenConsutantAdd()
        {
            ConsultantAdd invConSul = new ConsultantAdd(ServiceManager, ProjectID);
            invConSul.ShowDialog();
            invConSul.Dispose();
            LoadProjectData();
        }

        //Datagridview to see all consultants that has been invited to the project //MS
        private void invitedConsultants()
        {
            dgv_ConsultantList.AutoGenerateColumns = false;
            dgv_ConsultantList.StandardTab = true;

            dgv_ConsultantList.Columns.Add("InvitedUserFullName", "Full name");
            dgv_ConsultantList.Columns["InvitedUSerFullName"].DataPropertyName = "InvitedUSerFullName";

            dgv_ConsultantList.Columns.Add("InviteStatus", " Status for invite");
            dgv_ConsultantList.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_ConsultantList.Columns.Add("InvitedUserSpecializations", "Specializations");
            dgv_ConsultantList.Columns["InvitedUserSpecializations"].DataPropertyName = "InvitedUserSpecializations";

            dgv_ConsultantList.Columns.Add("AcceptDate", "Accept Date");
            dgv_ConsultantList.Columns["AcceptDate"].DataPropertyName = "AcceptDate";

            dgv_ConsultantList.DataSource = invService.GetAllInvitedProjectID(ProjectGet.ProjectId);
        }
    }
}