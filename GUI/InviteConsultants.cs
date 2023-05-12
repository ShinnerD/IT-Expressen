using DAL.Linq;
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
            lb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            lb_title.Text = ProjectGet.Title;
            lb_UserID.Text = ProjectGet.UserId.ToString();
            lb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            lb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            lb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            lb_ModifyDate.Text = ProjectGet.ProjectModifyDate.ToString();
            lb_Description.Text = ProjectGet.Description;
        }



    }
}