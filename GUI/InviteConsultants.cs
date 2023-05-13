using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class InviteConsultants : Form
    {
        private IUserService UserService = new UserService();
        public string UserType { get; set; }
        public int ProjectID { get; set; }
        public IProjectModel ProjectGet { get; set; }
        public List<string> ProjectSpecializations { get; set; }

        public InviteConsultants(int projectID)
        {
            UserType = "consultant";
            InitializeComponent();
            LoadConsultantData();
            ProjectID = projectID;
            GetProjectInfo();
            LoadProjectData();
        }

        public InviteConsultants(IProjectModel ProjectsSpecs)
        {
            InitializeComponent();
            ProjectGet = ProjectsSpecs;
        }

        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = UserService.FindUsersWithUserType(UserType);

            this.dgv_ConsultantList.Columns["password"].Visible = false;
            this.dgv_ConsultantList.Columns["Address"].Visible = false;
            this.dgv_ConsultantList.Columns["CreationDate"].Visible = false;
            this.dgv_ConsultantList.Columns["ID"].Visible = false;
            this.dgv_ConsultantList.Columns["UserName"].Visible = false;
            this.dgv_ConsultantList.Columns["ZipCode"].Visible = false;
            this.dgv_ConsultantList.Columns["NameCity"].Visible = false;
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            ProjectGet = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
        }

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
    }
}