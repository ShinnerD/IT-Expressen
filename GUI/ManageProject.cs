using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ManageProject : Form
    {
        private int ProjectID { get; set; }
        private IProjectModel ProjectGet { get; set; }
        private IInvitesModel Invite { get; set; }
        private List<IMessageModel> MessageGet { get; set; }
        private List<string> MessageBoardGet { get; set; }
        private IUserService UserServiceGet { get; set; }

        private IInviteService invService = new InviteService();

        public ManageProject(int projectId)
        {
            InitializeComponent();
            ProjectID = projectId;
            GetProjectInfo();
            LoadProjectData();
            LoadMessageData();
            InvolvedUsers();
        }

        public ManageProject(IProjectModel projectModel)
        {
            InitializeComponent();
            ProjectGet = projectModel;
        }

        private void GetProjectInfo()
        {
            IProjectService projectService = new ProjectService();
            IInviteService inviteService = new InviteService();
            IMessageService messageService = new MessageService();

            ProjectGet = projectService.GetProject(ProjectID);
            Invite = inviteService.GetInvitedProjectId(ProjectID);
            MessageGet = messageService.GetAllMessageFromProjectID(ProjectID);
        }

        private void LoadProjectData()
        {
            UserServiceGet = new UserService();

            grpBoxProfileInfo.Text = ProjectGet.Title;
            tb_ProjectID.Text = ProjectGet.ProjectId.ToString();
            tb_ProjectTitle.Text = ProjectGet.Title.ToString();
            tb_ProjectOwner.Text = UserServiceGet.GetUserFromID(ProjectGet.UserId).FirstName.ToString() + " " + UserServiceGet.GetUserFromID(ProjectGet.UserId).LastName.ToString();
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
                MessageBoardGet.Add("User: " + UserServiceGet.GetUserFromID(ProjectGet.UserId).FirstName.ToString() + " " + UserServiceGet.GetUserFromID(ProjectGet.UserId).LastName.ToString());
                //MessageBoardGet.Add(message.UserID.ToString());
                MessageBoardGet.Add(message.Message.ToString());
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
                    IMessageService messageService = new MessageService();

                    messageService.AddMessage(
                        ProjectGet.ProjectId,
                        ProjectGet.UserId,
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
        }

        private void InvolvedUsers()
        {
            dgv_InvolvedUsers.AutoGenerateColumns = false;
            dgv_InvolvedUsers.StandardTab = true;

            dgv_InvolvedUsers.Columns.Add("UserName", "User Name");
            dgv_InvolvedUsers.Columns["UserName"].DataPropertyName = "UserName";

            dgv_InvolvedUsers.Columns.Add("InviteStatus", "Invite Status");
            dgv_InvolvedUsers.Columns["InviteStatus"].DataPropertyName = "InviteStatus";


            dgv_InvolvedUsers.DataSource = invService.GetAllInvitedProjectID(ProjectGet.ProjectId).Where(i => i.InviteStatus.ToLower() != "declined").ToList(); ;
        }
    }
}