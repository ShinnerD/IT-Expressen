using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class NewProject : Form
    {
        public int ProjectId { get; set; }
        public string CurrentUser { get; set; }

        public NewProject(int projectId, string currentUser)
        {
            InitializeComponent();
            SetupSkillsCheckList();
            lblFeedback.Text = string.Empty;
            ProjectId = projectId;
            CurrentUser = currentUser;
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

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            SaveNewProject();
            lblFeedback.Text = "New Project Saved!";
        }

        private void SaveNewProject()
        {
            if (NoInputErrors())
            {
                IProjectService projectService = new Domain.Services.ProjectService();

                List<string> reqSkills = FindCheckedSkills();

                projectService.CreateProject(txtBoxUserName.Text, txtBoxTitle.Text, txtBoxDescription.Text, dTPstartDate.Value, dTPendDate.Value, reqSkills);
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