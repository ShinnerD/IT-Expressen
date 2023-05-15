using Interfaces.Models;
using Interfaces.Services;
using Domain.Services;
using DAL.Linq;

namespace GUI
{
    public partial class AcceptInviteForm : Form
    {
        private int ProjectID { get; set; }

        private IProjectModel ProjectGet { get; set; }

        private IUserService UserService = new UserService();

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
            lb_test.Text = "Accepted";

            IInviteService inviteService = new Domain.Services.InviteService();

            Invite.InviteStatus = lb_test.Text;
            Invite.InviteDate = DateTime.Now;


            inviteService.UpdateInviteStatus(Invite);
        }

        private void bt_decline_Click(object sender, EventArgs e)
        {
            Declined();

        }
        private void Declined()
        {
            lb_test.Text = "Declined";

            IInviteService inviteService = new Domain.Services.InviteService();

            Invite.InviteStatus = lb_test.Text;
            Invite.InviteDate = DateTime.Now;

            inviteService.UpdateInviteStatus(Invite);
        }
    }
}