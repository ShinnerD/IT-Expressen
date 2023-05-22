using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class AcceptInviteForm : Form
    {
        private IInvitesModel CurrentInvite;

        private IProjectModel? ProjectGet;

        private readonly IDomainServiceManager ServiceManager;

        public AcceptInviteForm(IDomainServiceManager serviceManager, IInvitesModel invite)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            CurrentInvite = invite ?? throw new ArgumentNullException(nameof(invite));

            InitializeComponent();
            GetProjectInfo();
            LoadProjectData();
            StartDateCheck();
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = ServiceManager.ProjectService;
            ProjectGet = projectService.GetProject(CurrentInvite.ProjectId);
        }

        //Loads the data transferred into textboxes, so the user can see the information about the given project //MS
        private void LoadProjectData()
        {
            var UserServiceGet = ServiceManager.UserService;

            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_Title.Text = ProjectGet.Title;
            tb_UserID.Text = UserServiceGet.GetUserFromID(ProjectGet.UserId).FirstName.ToString() + " " + UserServiceGet.GetUserFromID(ProjectGet.UserId).LastName.ToString();
            tb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            tb_Description.Text = ProjectGet.Description;
        }

        //Locks the buttons for accept/decline if the DataTime now is greater then the set start date for the project //MS
        private void StartDateCheck()
        {
            if (ProjectGet.ProjectStartDate > (DateTime.Now))
            {
                bt_AcceptInv.Enabled = false;
                bt_decline.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void Accept()
        {
            IInviteService inviteService = ServiceManager.InviteService;

            CurrentInvite.InviteStatus = "Accepted";
            CurrentInvite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(CurrentInvite, CurrentInvite.ProjectId);
            this.Close();
        }

        private void bt_decline_Click(object sender, EventArgs e)
        {
            Declined();
        }

        private void Declined()
        {
            IInviteService inviteService = ServiceManager.InviteService;

            CurrentInvite.InviteStatus = "Declined";
            CurrentInvite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(CurrentInvite, CurrentInvite.ProjectId);
            this.Close();
        }
    }
}