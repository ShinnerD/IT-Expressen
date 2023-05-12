using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantViewProjects : Form
    {
        private IProjectService projectService = new Domain.Services.ProjectService();
        public int UserId { get; set; }

        public ConsultantViewProjects(int userId)
        {
            InitializeComponent();
            UserId = userId;
            ProjectsForConsultants();
            SearchProjects();
        }

        private void ProjectsForConsultants()
        {
            dgv_ConsultantViewProjects.DataSource = projectService.GetUserProjects(UserId);
        }

        private void dgv_ConsultantVIewProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectsForConsultants();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchProjects();
        }

        private void SearchProjects()
        {
            string searchTerm = tb_Search.Text.Trim();
            List<IProjectModel> projects = projectService.SearchProjects(searchTerm, UserId);
            dgv_ConsultantViewProjects.DataSource = projects;
        }

        private void ()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            EditProject editProject = new EditProject(selectedProject.ProjectId);
            this.Hide();
            editProject.ShowDialog();
            this.Show();
        }
    }
}