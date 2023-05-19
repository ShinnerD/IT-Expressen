using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantInvites : Form
    {
        private string Username { get; set; }
        private IUserModel userModelGet { get; set; }

        private List<IInvitesModel> invites;
        private IProjectModel ProjectGet { get; set; }
        private IUserService UserServiceGet { get; set; }

        public ConsultantInvites(string userName)
        {
            InitializeComponent();
            Username = userName;
            GetUser();
            DataGridInitialSetup();
            LoadInvitesToDGV();
            //LoadProjectData();
        }

        public ConsultantInvites(IProjectModel projectModel)
        {
            InitializeComponent();
            ProjectGet = projectModel;
        }

        private void GetUser()
        {
            IUserService userService = new UserService();
            userModelGet = userService.GetUser(Username);
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new ProjectService();

            //ProjectGet = projectService.GetProject(ProjectID);
        }

        private void LoadInvitesToDGV()
        {
            IInviteService inviteService = new InviteService();
            invites = inviteService.GetInvitedUserIDList(userModelGet.ID);
            dgv_ConsultantsInvites.DataSource = null;
            dgv_ConsultantsInvites.DataSource = invites;
        }

        private void LoadProjectData()
        {
            grpBoxProfileInfo.Text = ProjectGet.Title;
            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_ProjectTitle.Text = ProjectGet.Title.ToString();
            tb_ProjectOwner.Text = UserServiceGet.GetUserFromID(ProjectGet.UserId).FirstName.ToString() + " " + UserServiceGet.GetUserFromID(ProjectGet.UserId).LastName.ToString();
            tb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            tb_ProjectModifiedDate.Text = ProjectGet.ProjectModifyDate.ToString();
            rtb_Description.Text = ProjectGet.Description;
            lb_DaysTilEnd.Text = "Project ends in " + (ProjectGet.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString() + " days";
        }

        private void DataGridInitialSetup()
        {
            dgv_ConsultantsInvites.AutoGenerateColumns = false;
            dgv_ConsultantsInvites.StandardTab = true;

            dgv_ConsultantsInvites.Columns.Add("InviteStatus", "Invite Status");
            dgv_ConsultantsInvites.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_ConsultantsInvites.Columns.Add("AcceptDate", "Accept Date");
            dgv_ConsultantsInvites.Columns["AcceptDate"].DataPropertyName = "AcceptDate";

            dgv_ConsultantsInvites.Columns.Add("InviteDate", "Invitation Date");
            dgv_ConsultantsInvites.Columns["InviteDate"].DataPropertyName = "InviteDate";

            dgv_ConsultantsInvites.Columns.Add("ProjectId", "Project ID");
            dgv_ConsultantsInvites.Columns["ProjectId"].DataPropertyName = "ProjectId";
        }

        private void bt_seeInviteDetails_Click(object sender, EventArgs e)
        {
            var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;
            AcceptInviteForm AccInvForm = new AcceptInviteForm(selectedProject.ProjectId);
            this.Hide();
            AccInvForm.ShowDialog();
            this.Show();
            LoadInvitesToDGV();
        }

        private void dgv_ConsultantsInvites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Country.Text = dgv_ConsultantsInvites.SelectedCells[3].Value.ToString();
            //dgv_ConsultantsInvites.Columns[3].Selected
            //var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;

            //LoadInvitesToDGV();
        }
    }
}