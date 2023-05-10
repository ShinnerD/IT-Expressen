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
    }
}