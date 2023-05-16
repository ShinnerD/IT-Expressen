using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class AcceptInviteForm : Form
    {
        private int ProjectID { get; set; }

        private IProjectModel ProjectGet { get; set; }

        private IInviteService InvService = new InviteService();

        private IInvitesModel Invite { get; set; }

        public AcceptInviteForm(int projectID)
        {
            InitializeComponent();
            ProjectID = projectID;
            GetProjectInfo();
            LoadProjectData();
        }

        public AcceptInviteForm(IProjectModel ProjectSpecs, IInviteService invService)
        {
            InitializeComponent();
            ProjectGet = ProjectSpecs;
            InvService = invService;
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new ProjectService();
            IInviteService inviteService = new InviteService();

            ProjectGet = projectService.GetProject(ProjectID);
            Invite = inviteService.GetInvitedProjectId(ProjectID);
        }

        //Loads the data transfered into textboxes, so the user can see the information about the given project //MS
        private void LoadProjectData()
        {
            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_Title.Text = ProjectGet.Title;
            tb_UserID.Text = ProjectGet.UserId.ToString();
            tb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            tb_Description.Text = ProjectGet.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void Accept()
        {
            IInviteService inviteService = new Domain.Services.InviteService();

            Invite.InviteStatus = "Accepted";
            Invite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(Invite, ProjectID);
            this.Close();
        }

        private void bt_decline_Click(object sender, EventArgs e)
        {
            Declined();
            
        }

        private void Declined()
        {
            IInviteService inviteService = new Domain.Services.InviteService();

            Invite.InviteStatus = "Declined";
            Invite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(Invite, ProjectID);
            this.Close();
        }
    }
}