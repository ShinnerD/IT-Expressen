using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditProject : Form
    {
        public IProjectModel Project { get; set; }
        public int ProjectId { get; set; }
        public List<string> ProjectSpecializations { get; set; }

        public EditProject(int projectId)
        {
            InitializeComponent();
            SetupSkillsCheckList();
            ProjectId = projectId;
            GetProjectInfo();
            SetupPageElements();
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new Domain.Services.ProjectService();
            ISpecializationService specializationService = new Domain.Services.SpecializationService();

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
            else { dTPstartDate.Value = dTPstartDate.MinDate;  }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
