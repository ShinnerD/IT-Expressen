using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantAdd : Form
    {
        //Initializeing og the service/models need for the form /MS
        public string UserType { get; set; }

        private IUserService UserService = new UserService();
        private IProjectModel ProjectGet { get; set; }
        public int ProjectID { get; set; }
        private List<string> ProjectSpecializations { get; set; }

        //Constructor method loaded with project ID. All relevent data is loaded /MS
        public ConsultantAdd(int projectID)
        {
            UserType = "consultant";
            InitializeComponent();
            LoadConsultantData();
            ProjectID = projectID;
            GetProjectInfo();
        }

        //Loads data to dgv_ConsultantList, rearrange the order and disables certen columns /MS
        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = UserService.FindUsersWithUserType(UserType);

            dgv_ConsultantList.Columns["ID"].DisplayIndex = 0;
            dgv_ConsultantList.Columns["UserName"].DisplayIndex = 1;
            dgv_ConsultantList.Columns["FirstName"].DisplayIndex = 2;
            dgv_ConsultantList.Columns["LastName"].DisplayIndex = 3;

            dgv_ConsultantList.Columns["ActiveStatus"].Visible = false;
            dgv_ConsultantList.Columns["password"].Visible = false;
            dgv_ConsultantList.Columns["Address"].Visible = false;
            dgv_ConsultantList.Columns["CreationDate"].Visible = false;
            dgv_ConsultantList.Columns["ZipCode"].Visible = false;
            dgv_ConsultantList.Columns["NameCity"].Visible = false;
        }

        //Gets data on projects and specializations /MS
        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            ProjectGet = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
        }
        //Method for creating an invite linked to the project. The invited users ID is added from the dgv. /MS
        public void CreateInvite()
        {
            IInviteService inviteService = new Domain.Services.InviteService();

            inviteService.AddInvites(
                ProjectGet.ProjectId,
                (int)dgv_ConsultantList.CurrentRow.Cells[6].Value,
                DateTime.Now,
                "Pending",
                DateTime.Now);
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
    }
}