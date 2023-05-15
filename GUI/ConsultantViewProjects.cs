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
        /// <summary>
        /// (JQ)Get and set the data source for the data grid view with the projects for the current user
        /// </summary>
        private void ProjectsForConsultants()
        {
            dgv_ConsultantViewProjects.DataSource = projectService.GetUserProjects(UserId);
        }
        /// <summary>
        /// (JQ)Handle cell content click event for the data grid view
        /// </summary>
        private void dgv_ConsultantVIewProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectsForConsultants();
        }
        /// <summary>
        /// (JQ)Handle button click event for the search button
        /// </summary>
        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchProjects();
        }
        /// <summary>
        /// (JQ)Performs a search for projects matching the given search term and displays them in the DataGridView.
        /// </summary>
        private void SearchProjects()
        {
            string searchTerm = tb_Search.Text.Trim();
            List<IProjectModel> projects = projectService.SearchProjects(searchTerm, UserId);
            dgv_ConsultantViewProjects.DataSource = projects;
        }

        
    }
}