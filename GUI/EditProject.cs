using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class EditProject : Form
    {
        private readonly IDomainServiceManager ServiceManager;
        public IProjectModel Project { get; set; }
        public int ProjectId { get; set; }
        public List<string> ProjectSpecializations { get; set; }

        public EditProject(IDomainServiceManager serviceManager, int projectId)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

            InitializeComponent();
            SetupSkillsCheckList();
            ProjectId = projectId;
            GetProjectInfo();
            SetupPageElements();
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = ServiceManager.ProjectService;
            ISpecializationService specializationService = ServiceManager.SpecializationService;

            Project = projectService.GetProject(ProjectId);
            ProjectSpecializations = specializationService.GetProjectSpecializations(ProjectId);
        }

        private void SetupPageElements()
        {
            txtBoxTitle.Text = Project.Title;
            txtBoxDescription.Text = Project.Description;
            SetStartDate();
            SetEndDate();

            CheckProjectSkills();
        }

        private void SetEndDate()
        {
            if (Project.ProjectEndDate != null) { dTPendDate.Value = Project.ProjectEndDate.Value; }
            else { dTPendDate.Value = dTPendDate.MinDate; }
        }

        private void SetStartDate()
        {
            if (Project.ProjectStartDate != null) { dTPstartDate.Value = Project.ProjectStartDate.Value; }
            else { dTPstartDate.Value = dTPstartDate.MinDate; }
        }

        private void CheckProjectSkills()
        {
            foreach (var specialization in ProjectSpecializations)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            try
            {
                IProjectService projectService = ServiceManager.ProjectService;
                ISpecializationService specializationService = ServiceManager.SpecializationService;

                var specializations = new List<string>();

                foreach (string checkedSkill in checkedListSkills.CheckedItems)
                {
                    specializations.Add(checkedSkill.ToString());
                }

                Project.Title = txtBoxTitle.Text;
                Project.Description = txtBoxDescription.Text;
                Project.ProjectStartDate = dTPstartDate.Value;
                Project.ProjectEndDate = dTPendDate.Value;
                Project.ProjectModifyDate = DateTime.Now;

                projectService.UpdateProject(Project, specializations);

                lblFeedback.Text = "Project Changes Saved";
            }
            catch (Exception ex)
            {
                lblFeedback.Text = ex.Message;
                lblFeedback.ForeColor = Color.Red;
            }
        }

        private List<string> CheckForAddedSkills()
        {
            List<string> result = new List<string>();

            foreach (string checkSkill in checkedListSkills.CheckedItems)
            {
                if (!ProjectSpecializations.Contains(checkSkill))
                {
                    result.Add(checkSkill);
                }
            }
            return result;
        }

        private List<string> CheckForRemovedSkills()
        {
            List<string> result = new List<string>();

            foreach (var specialization in ProjectSpecializations)
            {
                if (!checkedListSkills.CheckedItems.Contains(specialization))
                {
                    result.Add(specialization);
                }
            }
            return result;
        }
    }
}