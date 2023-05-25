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

        private GuiHelper guiHelper = new GuiHelper();

        public ConsultantInvites(IDomainServiceManager serviceManager, string userName)
        {
            InitializeComponent();
            ServiceManager = serviceManager;
            Username = userName;
            GetUser();
            DataGridInitialSetup();
            SetupSkillsCheckList();
            LoadInvitesToDGV();
            dgv_ConsultantsInvites.Rows[0].Cells[0].Selected = false;
        }

        private void GetUser()
        {
            IUserService userService = ServiceManager.UserService;
            userModelGet = userService.GetUserFromUsername(Username);
        }

        private void GetProjectInfo()
        {
            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[0].Value;

            var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

            tb_ProjectID.Text = selectedProject.ProjectId.ToString();
            tb_ProjectTitle.Text = selectedProject.Title;
            tb_ProjectOwner.Text = ServiceManager.UserService.GetUserFromID(selectedProject.UserId).FirstName.ToString() + " " + ServiceManager.UserService.GetUserFromID(selectedProject.UserId).LastName.ToString();
            tb_ProjectStatus.Text = selectedProject.ProjectStatus;
            tb_ProjectStartDate.Text = selectedProject.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = selectedProject.ProjectEndDate.ToString();
            tb_ProjectModifiedDate.Text = selectedProject.ProjectModifyDate.ToString();
            rtb_Description.Text = selectedProject.Description;
            lb_DaysTilEnd.Text = "Days since project end: " + Math.Abs((DateTime.Now - selectedProject.ProjectEndDate).GetValueOrDefault().Days).ToString();

            if (selectedProject.ProjectStatus?.ToLower() == "pending")
            {
                lb_DaysTilEnd.Text = "Days until project start: " + (selectedProject.ProjectStartDate - DateTime.Now).GetValueOrDefault().Days.ToString();
            }
            if (selectedProject.ProjectStatus?.ToLower() == "active")
            {
                lb_DaysTilEnd.Text = "Days until project end: " + (selectedProject.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString();
            }

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

            dgv_ConsultantsInvites.Columns.Add("ProjectId", "ProjectId");
            dgv_ConsultantsInvites.Columns["ProjectId"].DataPropertyName = "ProjectId";
            dgv_ConsultantsInvites.Columns["ProjectId"].Visible = false;

            dgv_ConsultantsInvites.Columns.Add("ProjectTitle", "Project");
            dgv_ConsultantsInvites.Columns["ProjectTitle"].DataPropertyName = "ProjectTitle";

            dgv_ConsultantsInvites.Columns.Add("InviteStatus", "Invite Status");
            dgv_ConsultantsInvites.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_ConsultantsInvites.Columns.Add("InviteDate", "Invitation Date");
            dgv_ConsultantsInvites.Columns["InviteDate"].DataPropertyName = "InviteDate";
            dgv_ConsultantsInvites.Columns["InviteDate"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_ConsultantsInvites.Columns.Add("AcceptDate", "Accept/Declined Date");
            dgv_ConsultantsInvites.Columns["AcceptDate"].DataPropertyName = "AcceptDate";
            dgv_ConsultantsInvites.Columns["AcceptDate"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void dgv_ConsultantsInvites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetProjectInfo();
                StartDateCheck();
            }
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
            if (dgv_ConsultantsInvites.SelectedRows.Count > 0)
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
        }

        private void Declined()
        {
            if (dgv_ConsultantsInvites.SelectedRows.Count > 0)
            {
                var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[3].Value;
                var selectedProject = ServiceManager.ProjectService.GetProject(targetProject);

                var selectedInvite = dgv_ConsultantsInvites.SelectedRows[0].DataBoundItem as IInvitesModel;

                IInviteService inviteService = ServiceManager.InviteService;

                selectedInvite.InviteStatus = "Declined";
                selectedInvite.AcceptDate = DateTime.Now;

                inviteService.UpdateInviteStatus(selectedInvite, selectedProject.ProjectId);

                LoadInvitesToDGV();
            }
        }

        private void StartDateCheck()
        {
            var targetProject = (int)dgv_ConsultantsInvites.SelectedCells[0].Value;

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

        private void dgv_ConsultantsInvites_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        private void dgv_ConsultantsInvites_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_ConsultantsInvites, e, invites);
        }
    }
}