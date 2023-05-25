using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class AdminProjectEdit : Form
    {
        private readonly IDomainServiceManager ServiceManager;

        private IProjectModel ProjectForEdit;

        private GuiHelper guiHelper = new GuiHelper();

        public AdminProjectEdit(IDomainServiceManager serviceManager, IProjectModel projectForEdit)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            ProjectForEdit = projectForEdit;
            InitializeComponent();
            SetupPage();
        }

        private void SetupPage()
        {
            lbl_ManagerFullName.Text = ProjectForEdit.ManagerFullName;
            lbl_ManagerUserName.Text = ProjectForEdit.ManagerUserName;
            lbl_StatusValue.Text = ProjectForEdit.ProjectStatus.FirstOrDefault().ToString().ToUpper() + ProjectForEdit.ProjectStatus.Remove(0, 1);
            txtBox_ProjectTitle.Text = ProjectForEdit.Title;
            txtBox_ProjectDescription.Text = ProjectForEdit.Description;
            dtp_NewProjectStartDate.Value = ProjectForEdit.ProjectStartDate ?? dtp_NewProjectEndDate.MinDate;
            dtp_NewProjectEndDate.Value = ProjectForEdit.ProjectEndDate ?? dtp_NewProjectEndDate.MinDate;

            if (ProjectForEdit.ProjectStatus.ToLower() == "active") lbl_StatusValue.ForeColor = Color.Green;
            if (ProjectForEdit.ProjectStatus.ToLower() == "pending") lbl_StatusValue.ForeColor = Color.DarkOrange;
            if (ProjectForEdit.ProjectStatus.ToLower() == "ended") lbl_StatusValue.ForeColor = Color.DarkRed;

            try
            {
                checkedListSkills.Items.AddRange(ServiceManager.SpecializationService.ListDefinedSpecializations().ToArray());
                /// Checks off the correct skills in the specializations list.
                foreach (var specialization in ServiceManager.SpecializationService.GetProjectSpecializations(ProjectForEdit.ProjectId))
                {
                    checkedListSkills.SetItemChecked(checkedListSkills.FindStringExact(specialization), true);
                }
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list of defined skills", Color.Red);
            }
        }

        /// <summary>
        /// Updates the information on the current project and tries to save them in the database.
        /// </summary>
        private void UpdateProject()
        {
            try
            {
                List<string> reqSkills = checkedListSkills.CheckedItems.Cast<string>().ToList();

                ProjectForEdit.Title = txtBox_ProjectTitle.Text;
                ProjectForEdit.Description = txtBox_ProjectDescription.Text;
                ProjectForEdit.ProjectStartDate = dtp_NewProjectStartDate.Value;
                ProjectForEdit.ProjectEndDate = dtp_NewProjectEndDate.Value;

                ServiceManager.ProjectService.UpdateProject(ProjectForEdit, reqSkills);

                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Project updated successfully.", Color.Green);
            }
            catch (Exception e)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, e.Message, Color.Red);
            }
        }

        private void btn_NewProjectBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewProjectSave_Click(object sender, EventArgs e)
        {
            UpdateProject();
        }
    }
}
