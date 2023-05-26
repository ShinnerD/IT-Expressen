using Interfaces.Models;
using Interfaces.Services;
using System.Data;

namespace GUI
{
    public partial class ManagerViewInvoice : Form
    {
        private readonly IDomainServiceManager ServiceManager;

        private IProjectModel ProjectForEdit;
        private IInvoiceModel Invoice;

        private GuiHelper guiHelper = new GuiHelper();

        private List<IConsultantLineModel> consultantLines;

        public ManagerViewInvoice(IDomainServiceManager serviceManager, IProjectModel projectForEdit)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            ProjectForEdit = projectForEdit;
            InitializeComponent();
            SetDataGridViewColumns();
            SetupPage();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        private void SetDataGridViewColumns()
        {
            //Consultant Lines DataGridView
            dgv_PendingInvites.AutoGenerateColumns = false;
            dgv_PendingInvites.Columns.Add("ConsultantName", "Consultant");
            dgv_PendingInvites.Columns["ConsultantName"].DataPropertyName = "ConsultantName";

            dgv_PendingInvites.Columns.Add("HoursTotal", "Hours");
            dgv_PendingInvites.Columns["HoursTotal"].DataPropertyName = "HoursTotal";

            dgv_PendingInvites.Columns.Add("HourlyRate", "Rate");
            dgv_PendingInvites.Columns["HourlyRate"].DataPropertyName = "HourlyRate";
            dgv_PendingInvites.Columns["HourlyRate"].DefaultCellStyle.Format = "f2";

            dgv_PendingInvites.Columns.Add("LineTotal", "Total");
            dgv_PendingInvites.Columns["LineTotal"].DataPropertyName = "LineTotal";
            dgv_PendingInvites.Columns["LineTotal"].DefaultCellStyle.Format = "f2";
        }

        private void SetupPage()
        {
            lbl_ManagerFullName.Text = ProjectForEdit.ManagerFullName;
            lbl_ManagerUserName.Text = ProjectForEdit.ManagerUserName;
            lbl_StatusValue.Text = ProjectForEdit.ProjectStatus.FirstOrDefault().ToString().ToUpper() + ProjectForEdit.ProjectStatus.Remove(0, 1);
            txtBox_ProjectTitle.Text = ProjectForEdit.Title;
            lbl_StartDateValue.Text = "No start date.";
            lbl_EndDateValue.Text = "No end date.";
            if (ProjectForEdit.ProjectStartDate.HasValue) { lbl_StartDateValue.Text = ProjectForEdit.ProjectStartDate.Value.ToShortDateString(); }
            if (ProjectForEdit.ProjectEndDate.HasValue) { lbl_EndDateValue.Text = ProjectForEdit.ProjectEndDate.Value.ToShortDateString(); }

            if (ProjectForEdit.ProjectStatus.ToLower() == "active") lbl_StatusValue.ForeColor = Color.Green;
            if (ProjectForEdit.ProjectStatus.ToLower() == "pending") lbl_StatusValue.ForeColor = Color.DarkOrange;
            if (ProjectForEdit.ProjectStatus.ToLower() == "ended") lbl_StatusValue.ForeColor = Color.DarkRed;

            //Try-Catch for getting specializations
            try
            {
                checkedListSkills.Items.Clear();
                checkedListSkills.Items.AddRange(ServiceManager.SpecializationService.GetProjectSpecializations(ProjectForEdit.ProjectId).ToArray());
                /// Checks off the skills in the specializations list.
                for (int i = 0; i < checkedListSkills.Items.Count; i++)
                {
                    checkedListSkills.SetItemChecked(i, true);
                }
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list of defined skills", Color.Red);
            }

            //Try-Catch for getting pending invites.
            try
            {
                dgv_PendingInvites.DataSource = null;
                consultantLines = ServiceManager.ConsultantLineService.GetAllConsultantLinesFromProjectID(ProjectForEdit.ProjectId);
                dgv_PendingInvites.DataSource = consultantLines;
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list pending invites", Color.Red);
            }

            //Setting to Invoice total from the sum of consultant line totals.
            lbl_TotalCost.Text = consultantLines.Sum(i => i.LineTotal).GetValueOrDefault().ToString("C");
        }

        private void btn_NewProjectBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddInviteButton_Click(object sender, EventArgs e)
        {
            ConsultantAdd InviteForm = new ConsultantAdd(ServiceManager, ProjectForEdit.ProjectId);
            InviteForm.ShowDialog();
            SetupPage();
        }

        private void btn_RemoveInvite_Click(object sender, EventArgs e)
        {
            try
            {
                bool refreshAfterDelete = false;
                if (dgv_PendingInvites.SelectedRows.Count > 0)
                {
                    ServiceManager.InviteService.DeleteInvite(dgv_PendingInvites.SelectedRows[0].DataBoundItem as IInvitesModel, true);
                    guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Invite successfully deleted.", Color.Green);
                    refreshAfterDelete = true;
                }
                if (refreshAfterDelete) { SetupPage(); }
            }
            catch (Exception)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Failed to delete invite.", Color.Red);
            }
        }

        private void dgv_AcceptedInvites_Click(object sender, EventArgs e)
        {
            dgv_PendingInvites.ClearSelection();
        }

        private void dgv_PendingInvites_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_PendingInvites, e, consultantLines);
        }

        private void btn_FinalizeInvoice_Click(object sender, EventArgs e)
        {
            //Get the Invoice so you can call an update on it.
            try { Invoice = ServiceManager.InvoiceService.GetInvoiceFromProjectID(ProjectForEdit.ProjectId); }
            catch (Exception) { guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Problem retrieving Invoice.", Color.Red); }
            if (Invoice is null)
            {
                guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "No invoice found for project since no payments required.", Color.Red);
            }
            //Call an update on the invoice to finalize it.
            else
            {
                try
                {
                    ServiceManager.InvoiceService.UpdateInvoice(Invoice);
                    guiHelper.FeedBackMessage(lbl_FeedBackNewProject, "Invoice has been finalized for this project.", Color.Green, 10000);
                }
                catch (Exception ex) { guiHelper.FeedBackMessage(lbl_FeedBackNewProject, ex.Message, Color.Red); }
            }
        }
    }
}