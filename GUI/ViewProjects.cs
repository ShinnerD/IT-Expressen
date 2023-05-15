using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ViewProjects : Form
    {
        // Initialize the project service
        private IProjectService projectService = new Domain.Services.ProjectService();

        // Store the current user ID
        public int UserId { get; set; }

        // Constructor method
        public ViewProjects(int userId)
        {
            InitializeComponent();
            UserId = userId;
            ProjectsForManager();
            SearchProjects();
        }

        /// <summary>
        /// (JQ)Get and set the data source for the data grid view with the projects for the current user
        /// </summary>
        private void ProjectsForManager()
        {
            dgv_Viewproject.DataSource = projectService.GetUserProjects(UserId);
        }

        /// <summary>
        /// (JQ)Handle cell content click event for the data grid view
        /// </summary>
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
            dgv_Viewproject.DataSource = projects;
        }

        private void InvitedConsultantSelctedProject()
        {
            var selectedProject = dgv_Viewproject.SelectedRows[0].DataBoundItem as IProjectModel;
            InviteConsultants invConSul = new InviteConsultants(selectedProject.ProjectId);
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