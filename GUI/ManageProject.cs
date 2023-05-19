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
            lb_DaysTilEnd.Text = "Project ends in " + (ProjectGet.ProjectEndDate - DateTime.Now).GetValueOrDefault().Days.ToString() + " days";
        }

        private void LoadMessageData()
        {
            MessageBoardGet = new List<string>();

            foreach (IMessageModel message in MessageGet)
            {
                MessageBoardGet.Add("Date: " + message.MessageDate.ToString());
                MessageBoardGet.Add("User: " + ServiceManager.UserService.GetUserFromUsername(UserName).FirstName.ToString() + " " + ServiceManager.UserService.GetUserFromUsername(UserName).LastName.ToString());
                //MessageBoardGet.Add(message.UserID.ToString());
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
            dgv_InvolvedUsers.AutoGenerateColumns = false;
            dgv_InvolvedUsers.StandardTab = true;

            dgv_InvolvedUsers.Columns.Add("UserName", "User Name");
            dgv_InvolvedUsers.Columns["UserName"].DataPropertyName = "InvitedUserName";

            dgv_InvolvedUsers.Columns.Add("InviteStatus", "Invite Status");
            dgv_InvolvedUsers.Columns["InviteStatus"].DataPropertyName = "InviteStatus";

            dgv_InvolvedUsers.DataSource = ServiceManager.InviteService.GetAllInvitedProjectID(ProjectGet.ProjectId).Where(i => i.InviteStatus.ToLower() != "declined").ToList(); ;
        }
    }
}