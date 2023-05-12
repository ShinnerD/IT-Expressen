using DAL.Linq;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantViewProjects : Form
    {
        private IProjectService projectService = new Domain.Services.ProjectService();
        private ISpecializationService specializationService = new Domain.Services.SpecializationService();
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public List<string> ProjectSpecializations { get; set; }


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

        private void LoadSpecializations()
        {
            List<string> specializations = specializationService.GetProjectSpecializations().Select(s => s.Name).ToList();
            comboBox1.DataSource = specializations;
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
            string selectedSpecialization = comboBox1.SelectedItem.ToString();

            List<IProjectModel> projects = projectService.SearchProjects(searchTerm, UserId);
            if (!string.IsNullOrEmpty(selectedSpecialization))
            {
                projects = projects.Where(p => p.Specialization == selectedSpecialization).ToList();
            }

            dgv_ConsultantViewProjects.DataSource = projects;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchProjects();
        }
    }
}