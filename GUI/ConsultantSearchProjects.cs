using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantSearchProjects : Form
    {
        private IProjectService projectService = new Domain.Services.ProjectService();
        private IUserService userService = new Domain.Services.UserService();
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public IUserModel Consultant { get; private set; }
        public List<string> ConsultantSpecializations { get; set; }

        private List<IProjectModel> SearchResults { get; set; }

        public ConsultantSearchProjects(int userId)
        {
            InitializeComponent();
            SetupSkillsCheckList();
            UserId = userId;
            GetProjectInfo();
            SetupPageElements();
        }


        private void dgv_Searchproject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetProjectInfo()
        {
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

            Consultant = userService.GetUserFromID(UserId);
            ConsultantSpecializations = specializationService.GetUserSpecializations(UserId);
        }

        private void SetupPageElements()
        {
            CheckProjectSkills();
            SetupDataGridview();
        }

        private void SetupDataGridview()
        {
            ISpecializationService specService = new SpecializationService();
            List<string> allSpecializations = specService.ListDefinedSpecializations();
            SearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations);
            dgv_Searchproject.DataSource = SearchResults;
        }

        private void CheckProjectSkills()
        {
            foreach (var specialization in ConsultantSpecializations)
            {
                checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(specialization), true);
            }
        }

        private void SetupSkillsCheckList()
        {
            ISpecializationService specService = new Domain.Services.SpecializationService();
            List<string> items = specService.ListDefinedSpecializations().OrderBy(i => i).ToList();

            foreach (var item in items)
            {
                checkedListSkills.Items.Add(item);
            }

            if (items.Count == 0)
            {
                MessageBox.Show("Failed to retrieve skills from server.");
            }
        }

        private void checkedListSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}