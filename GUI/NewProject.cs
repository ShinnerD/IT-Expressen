using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class NewProject : Form
    {
        public IUserModel CurrentUser { get; set; }
        private readonly IDomainServiceManager ServiceManager;


        public NewProject(IDomainServiceManager serviceManager, string currentUser)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

            InitializeComponent();
            SetupSkillsCheckList();

            lblFeedback.Text = string.Empty;
            CurrentUser = ServiceManager.UserService.GetUserFromUsername(currentUser);
            txtBoxUserName.Text = currentUser; // <------- Should be deleted before release along with textbox in designer.  /DK
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

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            SaveNewProject();
            lblFeedback.Text = "New Project Saved!";
        }

        private void SaveNewProject()
        {
            if (NoInputErrors())
            {
                IProjectService projectService = ServiceManager.ProjectService;

                List<string> reqSkills = FindCheckedSkills();

                projectService.CreateProject(CurrentUser.ID, txtBoxTitle.Text, txtBoxDescription.Text, dTPstartDate.Value, dTPendDate.Value, reqSkills);
            }
            else
            {
                lblFeedback.Text = "Please fill out all fields";
            }
        }

        private List<string> FindCheckedSkills()
        {
            List<string> result = new List<string>();

            foreach (var skill in checkedListSkills.CheckedItems)
            {
                result.Add(skill.ToString());
            }
            return result;
        }

        private bool NoInputErrors()
        {
            if (txtBoxTitle.Text != string.Empty
                && txtBoxDescription.Text != string.Empty
                && txtBoxUserName.Text != string.Empty
                && dTPendDate.Value > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}