using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ManageProject : Form
    {
        /// <summary>
        /// Initializeing og the service/models need for the form /MS
        /// </summary>
        private int ProjectID;

        private IProjectModel? ProjectGet;
        private List<IMessageModel>? MessageGet { get; set; }
        private List<string>? MessageBoardGet { get; set; }

        private string UserName;

        private GuiHelper guiHelper = new GuiHelper();

        private readonly IDomainServiceManager ServiceManager;

        private List<IInvitesModel> dgvInvites;
        /// <summary>
        /// Initializes needed methods and data
        /// </summary>
        /// <param name="serviceManager"></param>
        /// <param name="projectId"></param>
        /// <param name="userName"></param>
        public ManageProject(IDomainServiceManager serviceManager, int projectId, string userName)
        {
            ServiceManager = serviceManager;
            ProjectID = projectId;
            UserName = userName;

            InitializeComponent();
            GetProjectInfo();
            LoadProjectData();
            LoadMessageData();
            InvolvedUsers();
        }
        /// <summary>
        /// Gets the correct data from the database //MS
        /// </summary>
        private void GetProjectInfo()
        {
            ProjectGet = ServiceManager.ProjectService.GetProject(ProjectID);
            MessageGet = ServiceManager.MessageService.GetAllMessageFromProjectID(ProjectID);
        }

        /// <summary>
        /// Loads the textbox in the top of the page, with the users profile. Forwared from the login page /MS
        /// </summary>
        private void LoadProjectData()
        {
            grpBoxProfileInfo.Text = ProjectGet.Title;
            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_ProjectTitle.Text = ProjectGet.Title;
            tb_ProjectOwner.Text = ProjectGet.ManagerFullName;
            tb_ProjectStatus.Text = ProjectGet.ProjectStatus;
            tb_ProjectStartDate.Text = ProjectGet.ProjectStartDate.ToString();
            tb_ProjectEndDate.Text = ProjectGet.ProjectEndDate.ToString();
            tb_ProjectModifiedDate.Text = ProjectGet.ProjectModifyDate.ToString();
            rtb_Description.Text = ProjectGet.Description;
            if (ProjectGet.ProjectEndDate > DateTime.Now)
            {
                lb_DaysTilEnd.Text = "Project ends in " + (ProjectGet.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString() + " days";
            }
            else
            {
                lb_DaysTilEnd.Text = "Project has ended";
            }
            GetTotalInvoice();
        }
        /// <summary>
        /// Gets all messages to the related project and sets it up in the right format with full name and date.
        /// </summary>
        private void LoadMessageData()
        {
            MessageBoardGet = new List<string>();

            foreach (IMessageModel message in MessageGet)
            {
                var sender = ServiceManager.UserService.GetUserFromUsername(message.UserName);

                MessageBoardGet.Add("Date: " + message.MessageDate.ToString());
                MessageBoardGet.Add("User: " + sender.FullName);
                MessageBoardGet.Add(message.Message.ToString() + "\n");
            }
            rtb_Message.Text = String.Join(Environment.NewLine, MessageBoardGet);
            rtb_newMessage.Text = "";
        }
        /// <summary>
        /// Adds message to the database with a check to make sure its not null og empty. /MS
        /// </summary>
        public void AddMessage()
        {
            if (!string.IsNullOrEmpty(rtb_newMessage.Text))
            {
                try
                {
                    IMessageService messageService = ServiceManager.MessageService;

                    messageService.AddMessage(
                        ProjectGet.ProjectId,
                        ServiceManager.UserService.GetUserFromUsername(UserName).ID,
                        rtb_newMessage.Text,
                        DateTime.Now
                        );
                }
                catch (Exception ex)
                {
                    guiHelper.FeedBackMessage(lb_warning, ex.Message, Color.Red);
                }
            }
        }
        /// <summary>
        /// Diffrent loads depending on what user type is forwarded to the form. Gives consultants the option to add hours to invoice.
        /// Gives Managers (and admins) a diffrent datagridview, so they are able to see the amount every involved consultant have invoiced /MS
        /// </summary>       
        private void InvolvedUsers()
        {
            if (ServiceManager.UserService.GetUserFromUsername(UserName).UserType.ToLower() == "consultant")
            {
                DataInvolvedUseres();
                LoadConsultantInvoiceBoxes();
                GetTotalInvoice();
                dgvInvites = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectGet.ProjectId).Where(i => i.InviteStatus.ToLower() != "declined").ToList();

                dgv_InvolvedUsers.DataSource = dgvInvites;
                dgv_InvolvedUsers.Columns["ConLineSum"].Visible = false;
            }
            else
            {
                dgvInvites = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectGet.ProjectId).ToList();
                DataInvolvedUseres();
                dgv_InvolvedUsers.DataSource = dgvInvites;
                tb_TotalInvoice.Text = dgvInvites.Select(i => i.ConLineSum).Sum().ToString();
            }
        }
        /// <summary>
        /// Creates and designs the datagridview after a set of rules, so only usefull information is shown, and not the entire model. /MS
        /// </summary>
        private void DataInvolvedUseres()
        {
            dgv_InvolvedUsers.AutoGenerateColumns = false;
            dgv_InvolvedUsers.StandardTab = true;

            dgv_InvolvedUsers.Columns.Add("InvitedUserFullName", "Consultant Name");
            dgv_InvolvedUsers.Columns["InvitedUserFullName"].DataPropertyName = "InvitedUserFullName";

            dgv_InvolvedUsers.Columns.Add("InviteStatus", "Invite Status");
            dgv_InvolvedUsers.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_InvolvedUsers.Columns.Add("InvitedUserSpecializations", "User Specializations");
            dgv_InvolvedUsers.Columns["InvitedUserSpecializations"].DataPropertyName = "InvitedUserSpecializations";

            dgv_InvolvedUsers.Columns.Add("ConLineSum", "Invoiced");
            dgv_InvolvedUsers.Columns["ConLineSum"].DataPropertyName = "ConLineSum";
        }
        /// <summary>
        /// Method to load textbox for the a specefik userType /MS
        /// </summary>
        private void LoadConsultantInvoiceBoxes()
        {
            lb_HourlyRate.Visible = true;
            tb_HourlyRate.Visible = true;
            tb_HoursSpendt.Visible = true;
            lb_HoursSpendt.Visible = true;
            cb_UnlockRate.Visible = true;
            bt_addHours.Visible = true;
        }
        /// <summary>
        /// Method to add the amount invoiced from a consultant to the database /MS
        /// </summary>
        private void AddToInvoice()
        {
            try
            {
                var getUserID = ServiceManager.UserService.GetUserFromUsername(UserName);

                ServiceManager.ConsultantLineService.AddConsultantLine(
                    int.Parse(tb_ProjectID.Text),
                    getUserID.ID,
                    decimal.Parse(tb_HourlyRate.Text),
                    int.Parse(tb_HoursSpendt.Text)
                    );
            }
            catch (Exception e)
            {
                guiHelper.FeedBackMessage(lb_warning, e.Message, Color.Red);
            }
        }
        /// <summary>
        /// Simple method to let consultants able to see the total amount they have invoiced on a the selected project /MS
        /// </summary>
        private void GetTotalInvoice()
        {
            var userID = ServiceManager.UserService.GetUserFromUsername(UserName).ID;
            var getuserID = ServiceManager.UserService.GetUserFromUsername(UserName);

            List<IConsultantLineModel> getTotalInvoiced = ServiceManager.ConsultantLineService.GetAllConsultantLinesFromProjectID(ProjectID).Where(i => i.UserID == userID).ToList(); ;

            decimal result = 0;

            foreach (var ConsultantLine in getTotalInvoiced)
            {
                result += (ConsultantLine.HoursTotal * ConsultantLine.HourlyRate);
            }
            tb_TotalInvoice.Text = result.ToString();
        }
        /// <summary>
        /// Button click event -> see method for results /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_send_Click(object sender, EventArgs e)
        {
            AddMessage();
            GetProjectInfo();
            LoadMessageData();
        }
        /// <summary>
        /// Counter to indicate if the message is to long /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_newMessage_TextChanged(object sender, EventArgs e)
        {
            lb_TextCounter.Text = rtb_newMessage.Text.Length.ToString() + "/255";

            if (rtb_newMessage.Text.Count() < 255)
            {
                lb_warning.Visible = false;
                lb_TextCounter.ForeColor = Color.Black;
            }
            else
            {
                lb_warning.Visible = true;
                lb_TextCounter.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// Button click event -> see method for results /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_addHours_Click(object sender, EventArgs e)
        {
            AddToInvoice();
            GetTotalInvoice();
        }
        /// <summary>
        /// Unlock the textbox to be able to add hours and rate to invoice /MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_UnlockRate_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UnlockRate.Checked == true)
            {
                tb_HourlyRate.Enabled = true;
                tb_HoursSpendt.Enabled = true;
            }
            if (cb_UnlockRate.Checked == false)
            {
                tb_HoursSpendt.Enabled = false;
                tb_HourlyRate.Enabled = false;
            }
        }

        private void dgv_InvolvedUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GuiHelper.DataGridViewDataBindingCompleteResize(sender, e);
        }

        private void dgv_InvolvedUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guiHelper.ReorderDataGridViewColumnHeaderClickEvent(dgv_InvolvedUsers, e, dgvInvites);
        }
    }
}