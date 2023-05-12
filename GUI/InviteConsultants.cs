using Domain.Services;
using Interfaces.Services;

namespace GUI
{
    public partial class InviteConsultants : Form
    {
        private IUserService UserService = new UserService();
        public string UserType { get; set; }
        public int projectID { get; set; }

        public InviteConsultants()
        {
            UserType = "consultant";
            InitializeComponent();
            LoadConsultantData();
            this.projectID = projectID;
        }

        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = UserService.GetUserType(UserType = "consultant");
        }
    }
}