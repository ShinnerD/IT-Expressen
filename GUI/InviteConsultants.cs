using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class InviteConsultants : Form
    {
        /// <summary>
        /// Initializeing og the service/models need for the form /MS
        /// </summary>
        private readonly IDomainServiceManager ServiceManager;

        private int ProjectID { get; set; }
        private IProjectModel ProjectGet;

        private GuiHelper guiHelper;

        private List<IInvitesModel> InviteList;

        private IInviteService invService;

        /// <summary>
        /// Constructor method loaded with project ID. All relevent data is loaded /MS
        /// </summary>
        /// <param name="serviceManager"></param>
        /// <param name="projectID"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public InviteConsultants(IDomainServiceManager serviceManager, int projectID)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            invService = ServiceManager.InviteService;
            guiHelper = new GuiHelper();
            ProjectID = projectID;

            InitializeComponent();
            invitedConsultants();
            GetProjectInfo();
            LoadProjectData();
        }

        /// <summary>
        /// Constructor method loaded with project model. All relevent data is loaded /MS
        /// </summary>
        /// <param name="ProjectsSpecs"></param>
        public InviteConsultants(IProjectModel ProjectsSpecs)
        {
            InitializeComponent();
            ProjectGet = ProjectsSpecs;
        }

        /// <summary>
        /// Gets data on projects and specializations /MS
        /// </summary>
        private void GetProjectInfo()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            ProjectGet = projectService.GetProject(ProjectID);
        }

        /// <summary>
        /// Loads the data transfered into textboxes, and updates the invites list so the user can see the information about the given project //MS
        /// </summary>
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

            lb_DaysTilEnd.Text = "Days since project end: " + Math.Abs((DateTime.Now - ProjectGet.ProjectEndDate).GetValueOrDefault().Days).ToString();

            if (ProjectGet.ProjectStatus?.ToLower() == "pending")
            {
                lb_DaysTilEnd.Text = "Days until project start: " + (ProjectGet.ProjectStartDate - DateTime.Now).GetValueOrDefault().Days.ToString();
            }
            if (ProjectGet.ProjectStatus?.ToLower() == "active")
            {
                lb_DaysTilEnd.Text = "Days until project end: " + (ProjectGet.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString();
            }

            dgv_ConsultantList.DataSource = null;
            InviteList = invService.GetAllInvitedProjectID(ProjectGet.ProjectId);
            dgv_ConsultantList.DataSource = InviteList;

            //Try-Catch for getting specializations
            try
            {
                checkedListSkills.Items.Clear();
                checkedListSkills.Items.AddRange(ServiceManager.SpecializationService.GetProjectSpecializations(selectedProject.ProjectId).ToArray());
                /// Checks off the skills in the specializations list.
                for (int i = 0; i < checkedListSkills.Items.Count; i++)
                {
                    checkedListSkills.SetItemChecked(i, true);
                }
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackLabel, "Failed to retrieve list of defined skills.", Color.Red);
            }
        }

        /// <summary>
        /// Datagridview to see all consultants that has been invited to the project //MS
        /// </summary>
        private void invitedConsultants()
        {
            dgv_ConsultantList.AutoGenerateColumns = false;
            dgv_ConsultantList.StandardTab = true;

            dgv_ConsultantList.Columns.Add("InvitedUserFullName", "Full name");
            dgv_ConsultantList.Columns["InvitedUserFullName"].DataPropertyName = "InvitedUserFullName";

            dgv_ConsultantList.Columns.Add("InviteDate", "Invited Date");
            dgv_ConsultantList.Columns["InviteDate"].DataPropertyName = "InviteDate";
            dgv_ConsultantList.Columns["InviteDate"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_ConsultantList.Columns.Add("InviteStatus", " Status for invite");
            dgv_ConsultantList.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_ConsultantList.Columns.Add("AcceptDate", "Accept Date");
            dgv_ConsultantList.Columns["AcceptDate"].DataPropertyName = "AcceptDate";
            dgv_ConsultantList.Columns["InviteDate"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_ConsultantList.Columns.Add("InvitedUserSpecializations", "Specializations");
            dgv_ConsultantList.Columns["InvitedUserSpecializations"].DataPropertyName = "InvitedUserSpecializations";
        }

        private void btn_RemovePendingInvite_Click(object sender, EventArgs e)
        {
            if (dgv_ConsultantList.SelectedRows.Count > 0)
            {
                try
                {
                    ServiceManager.InviteService.DeleteInvite(dgv_ConsultantList.SelectedRows[0].DataBoundItem as IInvitesModel);
                    guiHelper.FeedBackMessage(lbl_FeedBackLabel, "Invite successfully removed.", Color.Green);
                }
                catch (Exception ex)
                {
                    guiHelper.FeedBackMessage(lbl_FeedBackLabel, ex.Message, Color.Red);
                }
                LoadProjectData();
            }
        }

        private void dgv_ConsultantList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_ConsultantList, e, InviteList);
        }

        private void dgv_ConsultantList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }
    }
}