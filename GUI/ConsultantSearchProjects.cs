using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantSearchProjects : Form
    {
        private readonly IDomainServiceManager ServiceManager;

        public List<string> ConsultantSpecializations { get; set; }
        private List<IProjectModel> SearchResults { get; set; }
        public IUserModel Consultant { get; private set; }
        public int UserId { get; set; }

        public ConsultantSearchProjects(IDomainServiceManager serviceManager, int userId)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

            InitializeComponent();
            UserId = userId;
            SetupPageElements();
        }

        private void SetUpUserDataGridView()
        {
            dgv_Searchproject.AutoGenerateColumns = false;

            dgv_Searchproject.Columns.Add("ProjectId", "ID");
            dgv_Searchproject.Columns["ProjectId"].DataPropertyName = "ProjectId";

            dgv_Searchproject.Columns.Add("ManagerUserName", "ManagerUserName");
            dgv_Searchproject.Columns["ManagerUserName"].DataPropertyName = "ManagerUsername";

            dgv_Searchproject.Columns.Add("Title", "Title");
            dgv_Searchproject.Columns["Title"].DataPropertyName = "Title";

            dgv_Searchproject.Columns.Add("ProjectStatus", "Status");
            dgv_Searchproject.Columns["ProjectStatus"].DataPropertyName = "ProjectStatus";
        }

        private void GetProjectInfo()
        {
            Consultant = ServiceManager.UserService.GetUserFromID(UserId);
            ConsultantSpecializations = ServiceManager.SpecializationService.GetUserSpecializations(UserId);
        }

        private void SetupPageElements()
        {
            GetProjectInfo();
            SetUpUserDataGridView();
            SetupSkillsCheckList();
            CheckProjectSkills();
            UpdateDataGridView();
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
            checkedListSkills.Items.AddRange(ServiceManager.SpecializationService.ListDefinedSpecializations().ToArray());
        }

        private void UpdateDataGridView()
        {
            // Filter projects based on selected skills
            List<string> selectedSkills = checkedListSkills.CheckedItems.Cast<string>().ToList();

            dgv_Searchproject.DataSource = null;

            SearchResults = ServiceManager.ProjectService.GetProjectsFromAnySpecializations(selectedSkills);

            dgv_Searchproject.DataSource = SearchResults;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}