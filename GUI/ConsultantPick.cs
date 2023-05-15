using DAL.Linq;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;

namespace GUI
{
    public partial class ConsultantPick : Form
    {
        public string UserType { get; set; }
        private IUserService UserService = new UserService();

        public ConsultantPick()
        {
            InitializeComponent();
            LoadConsultantData();
            UserType = "consultant";

        }

        //Loads DataGridView with users with UserType "Consultat" and removes unwanted attributes - MS
        private void LoadConsultantData()
        {
            dgv_ConsultantList.DataSource = UserService.FindUsersWithUserType(UserType);

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