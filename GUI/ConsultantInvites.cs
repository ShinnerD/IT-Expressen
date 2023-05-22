using DAL.Linq;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantInvites : Form
    {
        private readonly IDomainServiceManager ServiceManager;
        private string Username { get; set; }
        private IUserModel userModelGet { get; set; }

        private List<IInvitesModel> invites;
        private IProjectModel ProjectGet { get; set; }
        private IUserService UserServiceGet { get; set; }
        private IInvitesModel CurrentInvite { get; set; }

        public ConsultantInvites(IDomainServiceManager serviceManager, string userName)
        {
            InitializeComponent();
            ServiceManager = serviceManager;
            Username = userName;
            //CurrentInvite = invite;
            GetUser();
            DataGridInitialSetup();
            SetupSkillsCheckList();
            LoadInvitesToDGV();
            dgv_ConsultantsInvites.Rows[0].Cells[0].Selected = false;
        }

        //public ConsultantInvites(IProjectModel projectModel)
        //{
        //    InitializeComponent();
        //    ProjectGet = projectModel;
        //}

        private void GetUser()
        {
            IUserService userService = ServiceManager.UserService;
            userModelGet = userService.GetUserFromUsername(Username);
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[3].Value;

            var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

            tb_ProjectID.Text = selectedProject.ProjectId.ToString();
            tb_ProjectTitle.Text = selectedProject.Title;
            tb_ProjectOwner.Text = ServiceManager.UserService.GetUserFromID(selectedProject.UserId).FirstName.ToString() + " " + ServiceManager.UserService.GetUserFromID(selectedProject.UserId).LastName.ToString();
            tb_ProjectStatus.Text = selectedProject.ProjectStatus;
            tb_ProjectStartDate.Text = selectedProject.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = selectedProject.ProjectEndDate.ToString();
            tb_ProjectModifiedDate.Text = selectedProject.ProjectModifyDate.ToString();
            rtb_Description.Text = selectedProject.Description;
            lb_DaysTilEnd.Text = "Project ends in " + (selectedProject.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString() + " days";

            for (int i = 0; i < checkedListSkills.Items.Count; i++)
                checkedListSkills.SetItemChecked(i, false);

            foreach (var specialization in ServiceManager.SpecializationService.GetProjectSpecializations(selectedProject.ProjectId))
            {
                checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(specialization), true);
            }
        }

        private void LoadInvitesToDGV()
        {
            IInviteService inviteService = ServiceManager.InviteService;
            invites = inviteService.GetInvitesFromUserId(userModelGet.ID);
            dgv_ConsultantsInvites.DataSource = null;
            dgv_ConsultantsInvites.DataSource = invites;
            dgv_ConsultantsInvites.Rows[0].Cells[0].Selected = false;
        }

        private void DataGridInitialSetup()
        {
            dgv_ConsultantsInvites.AutoGenerateColumns = false;
            dgv_ConsultantsInvites.StandardTab = true;

            dgv_ConsultantsInvites.Columns.Add("InviteStatus", "Invite Status");
            dgv_ConsultantsInvites.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_ConsultantsInvites.Columns.Add("AcceptDate", "Accept/Declined Date");
            dgv_ConsultantsInvites.Columns["AcceptDate"].DataPropertyName = "AcceptDate";

            dgv_ConsultantsInvites.Columns.Add("InviteDate", "Invitation Date");
            dgv_ConsultantsInvites.Columns["InviteDate"].DataPropertyName = "InviteDate";

            dgv_ConsultantsInvites.Columns.Add("ProjectId", "Project ID");
            dgv_ConsultantsInvites.Columns["ProjectId"].DataPropertyName = "ProjectId";
        }

        private void bt_seeInviteDetails_Click(object sender, EventArgs e)
        {
            var selectedProject = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;
            AcceptInviteForm AccInvForm = new AcceptInviteForm(ServiceManager, selectedProject);
            this.Hide();
            AccInvForm.ShowDialog();
            this.Show();
            LoadInvitesToDGV();
        }

        private void dgv_ConsultantsInvites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetProjectInfo();
            StartDateCheck();

        }

        private void SetupSkillsCheckList()
        {
            checkedListSkills.Items.Clear();

            List<string> items = ServiceManager.SpecializationService.ListDefinedSpecializations();

            foreach (var item in items)
            {
                checkedListSkills.Items.Add(item);
            }
        }

        private void Accept()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[3].Value;

            var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

            var selectedInvite = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;

            IInviteService inviteService = ServiceManager.InviteService;


            selectedInvite.InviteStatus = "Accepted";
            selectedInvite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(selectedInvite, selectedProject.ProjectId);

            LoadInvitesToDGV();

        }

        private void Declined()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[3].Value;

            var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

            var selectedInvite = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;

            IInviteService inviteService = ServiceManager.InviteService;

            selectedInvite.InviteStatus = "Declined";
            selectedInvite.AcceptDate = DateTime.Now;

            inviteService.UpdateInviteStatus(selectedInvite, selectedProject.ProjectId);

            LoadInvitesToDGV();

        }
        private void StartDateCheck()
        {
            IProjectService projectService = ServiceManager.ProjectService;

            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[3].Value;

            var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

            if (selectedProject.ProjectEndDate < (DateTime.Now))
            {
                bt_AcceptInv.Enabled = false;
                bt_decline.Enabled = false;
            }
            else
            {
                bt_AcceptInv.Enabled = true;
                bt_decline.Enabled = true;
            }
        }

        private void bt_AcceptInv_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void bt_decline_Click(object sender, EventArgs e)
        {
            Declined();
        }
    }
}