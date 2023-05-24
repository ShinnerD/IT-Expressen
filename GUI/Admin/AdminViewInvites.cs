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
    public partial class AdminViewInvites : Form
    {
        private readonly IDomainServiceManager ServiceManager;

        private IProjectModel ProjectForEdit;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public AdminViewInvites(IDomainServiceManager serviceManager, IProjectModel projectForEdit)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            ProjectForEdit = projectForEdit;
            InitializeComponent();
            SetDataGridViewColumns();
            SetupPage();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.ColumnCount != 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView.ClearSelection();
        }

        private void SetDataGridViewColumns()
        {
            //Pending Invites DataGridView
            dgv_PendingInvites.AutoGenerateColumns = false;
            dgv_PendingInvites.Columns.Add("InvitedUserName", "Username");
            dgv_PendingInvites.Columns["InvitedUserName"].DataPropertyName = "InvitedUserName";
            dgv_PendingInvites.Columns.Add("InvitedUserFullName", "Full Name");
            dgv_PendingInvites.Columns["InvitedUserFullName"].DataPropertyName = "InvitedUserFullName";
            dgv_PendingInvites.Columns.Add("InviteDate", "Invited");
            dgv_PendingInvites.Columns["InviteDate"].DataPropertyName = "InviteDate";
            dgv_PendingInvites.Columns.Add("InvitedUserSpecializations", "Specializations");
            dgv_PendingInvites.Columns["InvitedUserSpecializations"].DataPropertyName = "InvitedUserSpecializations";

            //Accepted Invites DataGridView
            dgv_AcceptedInvites.AutoGenerateColumns = false;
            dgv_AcceptedInvites.Columns.Add("InvitedUserName", "Username");
            dgv_AcceptedInvites.Columns["InvitedUserName"].DataPropertyName = "InvitedUserName";
            dgv_AcceptedInvites.Columns.Add("InvitedUserFullName", "Full Name");
            dgv_AcceptedInvites.Columns["InvitedUserFullName"].DataPropertyName = "InvitedUserFullName";
            dgv_AcceptedInvites.Columns.Add("InviteDate", "Invited");
            dgv_AcceptedInvites.Columns["InviteDate"].DataPropertyName = "InviteDate";
            dgv_AcceptedInvites.Columns.Add("AcceptDate", "Accepted");
            dgv_AcceptedInvites.Columns["AcceptDate"].DataPropertyName = "AcceptDate";
            dgv_AcceptedInvites.Columns.Add("InvitedUserSpecializations", "Specializations");
            dgv_AcceptedInvites.Columns["InvitedUserSpecializations"].DataPropertyName = "InvitedUserSpecializations";
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
                FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list of defined skills", Color.Red);
            }

            //Try-Catch for getting pending invites.
            try
            {
                dgv_PendingInvites.DataSource = null;
                dgv_PendingInvites.DataSource = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectForEdit.ProjectId)
                    .Where(i =>  i.InviteStatus?.ToLower() == "pending").ToList();
            }
            catch (Exception)
            {
                FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list pending invites", Color.Red);
            }

            //Try-Catch for getting accepted invites.
            //try
            //{
                dgv_AcceptedInvites.DataSource = null;
                dgv_AcceptedInvites.DataSource = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectForEdit.ProjectId)
                    .Where(i => i.InviteStatus?.ToLower() == "accepted").ToList();
            //}
            //catch (Exception)
            //{
            //    FeedBackMessage(lbl_FeedBackNewProject, "Failed to retrieve list accepted invites", Color.Red);
            //}
        }

        private async Task FeedBackMessage(Label label, string message, Color? color = null, int milliseconds = 5000)
        {
            label.Text = message;
            label.ForeColor = color ?? Color.Black;
            label.Visible = true;
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            await Task.Delay(milliseconds, _cancellationTokenSource.Token);
            label.Text = string.Empty;
            label.ForeColor = Color.Black;
            label.Visible = false;
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
                    ServiceManager.InviteService.DeleteInvite(dgv_PendingInvites.SelectedRows[0].DataBoundItem as IInvitesModel);
                    FeedBackMessage(lbl_FeedBackNewProject, "Invite successfully deleted.", Color.Green);
                    refreshAfterDelete = true;
                }
                if (refreshAfterDelete) { SetupPage(); }
            }
            catch (Exception)
            {
                FeedBackMessage(lbl_FeedBackNewProject, "Failed to delete invite.", Color.Red);
            }
        }

        private void dgv_PendingInvites_Click(object sender, EventArgs e)
        {
            dgv_AcceptedInvites.ClearSelection();
        }

        private void dgv_AcceptedInvites_Click(object sender, EventArgs e)
        {
            dgv_PendingInvites.ClearSelection();
        }
    }
}
