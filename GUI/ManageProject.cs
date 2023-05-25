using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ManageProject : Form
    {
        private int ProjectID;

        private IProjectModel? ProjectGet;
        private List<IMessageModel>? MessageGet { get; set; }
        private List<string>? MessageBoardGet { get; set; }

        private string UserName;

        private readonly IDomainServiceManager ServiceManager;

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
            GetTotalInvoice();
        }

        private void GetProjectInfo()
        {
            ProjectGet = ServiceManager.ProjectService.GetProject(ProjectID);
            MessageGet = ServiceManager.MessageService.GetAllMessageFromProjectID(ProjectID);
        }

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
                catch
                {
                    MessageBox.Show("Message cant be longer then 255 characters");
                }
            }
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            AddMessage();
            GetProjectInfo();
            LoadMessageData();
        }

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

        private void InvolvedUsers()
        {
            if (ServiceManager.UserService.GetUserFromUsername(UserName).UserType.ToLower() == "consultant")
            {
                DataInvolvedUseres();
                LoadConsultantInvoiceBoxes();

                dgv_InvolvedUsers.DataSource = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectGet.ProjectId).Where(i => i.InviteStatus.ToLower() != "declined").ToList(); ;
            }
            else
            {
                DataInvolvedUseres();

                dgv_InvolvedUsers.DataSource = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectGet.ProjectId).ToList(); ;
            }
        }

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
        }

        //private void CalculateRates()
        //{
        //    double hours, rate, total;

        //    try
        //    {
        //        hours = Convert.ToInt32(tb_HourlyRate.Text);
        //        rate = Convert.ToInt32(tb_HoursSpendt.Text);

        //        total = Convert.ToInt32(hours * rate);

        //        tb_TotalInvoice.Text = total.ToString();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Felts may only include numbers");
        //    }
        //}
        private void LoadConsultantInvoiceBoxes()
        {
            lb_HourlyRate.Visible = true;
            tb_HourlyRate.Visible = true;
            tb_HoursSpendt.Visible = true;
            lb_HoursSpendt.Visible = true;
            cb_UnlockRate.Visible = true;
            bt_addHours.Visible = true;
        }

        private void AddToInvoice()
        {
            var getUserID = ServiceManager.UserService.GetUserFromUsername(UserName);
            var getProjectID = ServiceManager.ProjectService.GetProject(ProjectID);

            ServiceManager.ConsultantLineService.AddConsultantLine(
                int.Parse(tb_ProjectID.Text),
                getUserID.ID,
                decimal.Parse(tb_HourlyRate.Text),
                int.Parse(tb_HoursSpendt.Text)
                );

        }


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

        private void bt_addHours_Click(object sender, EventArgs e)
        {
            AddToInvoice();
            GetTotalInvoice();
        }

        private void cb_UnlockRate_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UnlockRate.Checked == true)
            {
                tb_HourlyRate.Enabled = true;
            }
            if (cb_UnlockRate.Checked == false)
            {
                tb_HourlyRate.Enabled = false;
            }
        }
    }
}