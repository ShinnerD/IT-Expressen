using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantSearchProjects : Form
    {
        private readonly IDomainServiceManager ServiceManager;
        private IProjectService projectService;
        private IUserService userService;
        private List<IProjectModel> projectsSearchResults;

        public List<string> ConsultantSpecializations { get; set; }
        private List<IProjectModel> SearchResults { get; set; }
        public IUserModel Consultant { get; private set; }
        public int UserId { get; set; }

        public ConsultantSearchProjects(IDomainServiceManager serviceManager, int userId)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            projectService = ServiceManager.ProjectService;
            userService = ServiceManager.UserService;

            InitializeComponent();
            SetUpUserDataGridView();
            SetupSkillsCheckList();
            UserId = userId;
            GetProjectInfo();
            SetupPageElements();
            SetupsDataGridview();
        }

        private void SetUpUserDataGridView()
        {
            ISpecializationService specService = ServiceManager.SpecializationService;
            dgv_Searchproject.AutoGenerateColumns = false;

            dgv_Searchproject.Columns.Add("ProjectId", "ID");
            dgv_Searchproject.Columns["ProjectId"].DataPropertyName = "ProjectId";

            dgv_Searchproject.Columns.Add("ManagerUserName", "ManagerUserName");
            dgv_Searchproject.Columns["ManagerUserName"].DataPropertyName = "ManagerUsername";

            dgv_Searchproject.Columns.Add("Title", "Title");
            dgv_Searchproject.Columns["Title"].DataPropertyName = "Title";

            dgv_Searchproject.Columns.Add("ProjectStatus", "Status");
            dgv_Searchproject.Columns["ProjectStatus"].DataPropertyName = "ProjectStatus";

            List<string> allSpecializations = specService.ListDefinedSpecializations();
            projectsSearchResults = projectService.GetProjectsFromAnySpecializations(allSpecializations).OrderBy(i => i.Title).ToList();
            dgv_Searchproject.DataSource = projectsSearchResults;
        }

        private void GetProjectInfo()
        {
            ISpecializationService specializationService = ServiceManager.SpecializationService;

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
            ISpecializationService specService = ServiceManager.SpecializationService;
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
            ISpecializationService specService = ServiceManager.SpecializationService;
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

        private void SetupsDataGridview()
        {
            ISpecializationService specService = ServiceManager.SpecializationService;
            List<string> allSpecializations = specService.ListDefinedSpecializations();

            // Filter projects based on selected skills
            List<string> selectedSkills = new List<string>();

            foreach (var item in checkedListSkills.CheckedItems)
            {
                if (item is string skill)
                {
                    selectedSkills.Add(skill);
                }
            }

            SearchResults = projectService.GetProjectsFromAnySpecializations(selectedSkills);

            dgv_Searchproject.DataSource = SearchResults;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetupsDataGridview();
        }
    }
}