﻿using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class InviteConsultants : Form
    {
        //Initializeing og the service/models need for the form /MS
        private IUserService UserService = new UserService();

        private string UserType { get; set; }
        private int ProjectID { get; set; }
        private IProjectModel ProjectGet { get; set; }
        private List<string> ProjectSpecializations { get; set; }

        private IInviteService invService = new InviteService();

        //Constructor method loaded with project ID. All relevent data is loaded /MS
        public InviteConsultants(int projectID)
        {
            UserType = "consultant";
            InitializeComponent();
            ProjectID = projectID;
            GetProjectInfo();
            LoadProjectData();
            invitedConsultants();
        }

        //Constructor method loaded with project model. All relevent data is loaded /MS
        public InviteConsultants(IProjectModel ProjectsSpecs)
        {
            InitializeComponent();
            ProjectGet = ProjectsSpecs;
        }

        //Gets data on projects and specializations /MS
        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            ProjectGet = projectService.GetProject(ProjectID);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectID);
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

        // Button click event -> see method for results /MS
        private void bt_AddConsultant_Click(object sender, EventArgs e)
        {
            OpenConsutantAdd();
        }

        //Opens new form and forwards the project ID /MS
        private void OpenConsutantAdd()
        {
            var selectedProject = ProjectGet as IProjectModel;
            InviteConsultants ConsulAdd = new InviteConsultants(selectedProject.ProjectId);
            ConsultantAdd invConSul = new ConsultantAdd(ProjectGet.ProjectId);
            this.Hide();
            invConSul.ShowDialog();
            this.Show();
        }

        //Datagridview to see all consultants that has been invited to the project //MS
        private void invitedConsultants()
        {
            dgv_ConsultantList.DataSource = invService.GetAllInvitedProjectID(ProjectGet.ProjectId);
        }
    }
}