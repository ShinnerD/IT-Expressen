using DAL.Models;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ManageProject : Form
    {
        private int ProjectID { get; set; }
        private IProjectModel ProjectGet { get; set; }

        private IInvitesModel Invite { get; set; }

        public ManageProject(int projectId)
        {
            InitializeComponent();
            ProjectID = projectId;
            LoadProjectData();
            GetProjectInfo();
            LoadProjectData();
        }
        public ManageProject(IProjectModel projectModel)
        {
            InitializeComponent();
            ProjectGet = projectModel;
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new ProjectService();
            IInviteService inviteService = new InviteService();

            ProjectGet = projectService.GetProject(ProjectID);
            Invite = inviteService.GetInvitedProjectId(ProjectID);
        }

        private void LoadProjectData()
        {

            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_ProjectTitle.Text = ProjectGet.Title.ToString();
            tb_ProjectOwner.Text = ProjectGet.UserId.ToString();
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            tb_ProjectModifiedDate.Text = ProjectGet.ProjectModifyDate.ToString();
        }

    }
}