using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantPick : Form
    {
        public string UserType { get; set; }
        private IUserService userService;
        private readonly IDomainServiceManager ServiceManager;

        public ConsultantPick(IDomainServiceManager serviceManager)
        {
            ServiceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
            userService = ServiceManager.UserService;

            InitializeComponent();
            LoadConsultantData();
            UserType = "consultant";
        }

        //Loads DataGridView with users with UserType "Consultat" and removes unwanted attributes - MS
        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = userService.FindUsersWithUserType(UserType);

            this.dgv_ConsultantList.Columns["password"].Visible = false;
            this.dgv_ConsultantList.Columns["Address"].Visible = false;
            this.dgv_ConsultantList.Columns["CreationDate"].Visible = false;
            this.dgv_ConsultantList.Columns["ID"].Visible = false;
            this.dgv_ConsultantList.Columns["UserName"].Visible = false;
            this.dgv_ConsultantList.Columns["ZipCode"].Visible = false;
            this.dgv_ConsultantList.Columns["NameCity"].Visible = false;
        }
    }
}