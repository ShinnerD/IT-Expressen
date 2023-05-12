using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ViewProjects : Form
    {
        private IProjectService projectService = new Domain.Services.ProjectService();

        public int UserId { get; set; }

        public ViewProjects(int userId)
        {
            InitializeComponent();
            UserId = userId;
            ProjectsForManager();
        }

        private void ProjectsForManager()
        {
            dgv_Viewproject.DataSource = projectService.GetUserProjects(UserId);
        }

        private void dgv_Viewproject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectsForManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSelectedProject();
        }

        private void ManageSelectedProject()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            EditProject editProject = new EditProject(selectedProject.ProjectId);
            this.Hide();
            editProject.ShowDialog();
            this.Show();
        }
        private void InvitedConsultantSelctedProject()
        {
            //var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            InviteConsultants invConSul = new InviteConsultants();
            this.Hide();
            invConSul.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvitedConsultantSelctedProject();
        }
    }
}