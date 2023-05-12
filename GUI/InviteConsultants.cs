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
        public IProjectModel ProjectFFFS { get; set; }
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

        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = UserService.FindUsersWithUserType(UserType);
        }
        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            Project = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
        }
        private void LoadProjectData()
        {
            
            lb_ProjectID.Text = ProjectID.ToString();
            lb_title.Text = ProjectID.
            lb_UserID.Text = 
            lb_ProjectStatus.Text = 
            lb_ProjectStartDate.Text = 
            lb_ProjectEndDate.Text = 
            lb_ModifyDate.Text = 
            lb_Description.Text = 
        }



    }
}