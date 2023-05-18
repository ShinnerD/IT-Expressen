using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

///Writen by Erik

namespace DAL.Repository
{
    public class InvitesRepository : IInvitesRepository
    {
        private readonly DataClassesDataContext DataContext;

        public InvitesRepository(IDataContextManager dataContextManager)
        {
            DataContext = dataContextManager.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContextManager));
        }

        /// <summary>
        /// Getting a list off all invites, with the attributes that is in invites.
        /// </summary>
        public List<IInvitesModel> GetAllInvites()
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            var dbInvites = DataContext.Invites;
            foreach (var dbInvite in dbInvites)
            {
                IInvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);
            }
            return result;
        }

        /// <summary>
        /// Getting a list off all invites with a specific ProjectID
        /// </summary>
        public List<IInvitesModel> GetAllInviteProjectID(int projectid)
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            var dbInvites = DataContext.Projects.First(i => i.Project_ID == projectid).Invites;

            foreach (var dbInvite in dbInvites)
            {
                IInvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);
            }
            return result;
        }

        /// <summary>
        /// Getting the first invite from the database with a specific ProjectID
        /// </summary>
        public IInvitesModel GetInviteProjectId(int ProjectId)
        {
            IInvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.First(i => i.Project_ID == ProjectId);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;
        }

        /// <summary>
        /// Getting the first invite in the database with a specific UserId
        /// </summary>
        public IInvitesModel GetInviteUserId(int UserId)
        {
            IInvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.First(i => i.User_ID == UserId);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;
        }

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        public List<IInvitesModel> GetAllInviteUserId(int UserId)
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            var dbInvites = DataContext.Invites.Where(i => i.User_ID == UserId);

            foreach (var dbinvite in dbInvites)
            {
                IInvitesModel invite = new InvitesModel();

                invite.ProjectId = dbinvite.Project_ID;
                invite.UserId = dbinvite.User_ID;
                invite.InviteDate = (DateTime)dbinvite.Invite_Date;
                invite.InviteStatus = dbinvite.Invite_status;
                invite.AcceptDate = (DateTime)dbinvite.Accept_date;

                result.Add(invite);
            }
            return result;
        }

        /// <summary>
        /// Repo method to link userName with an invite //MS
        /// </summary>
        public IInvitesModel GetInviteUserName(string Username)
        {
            IInvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.User.User_name == Username);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;
        }

        /// <summary>
        ///  Repo method to add invitations to a project, the invited consultants userID is stored /MS
        /// </summary>
        public void AddInvite(IInvitesModel inviteModel)
        {
            var linqInviteModel = new Linq.Invite();

            linqInviteModel.Project_ID = inviteModel.ProjectId;
            linqInviteModel.User_ID = inviteModel.UserId;
            linqInviteModel.Invite_Date = inviteModel.InviteDate;
            linqInviteModel.Invite_status = inviteModel.InviteStatus;
            linqInviteModel.Accept_date = inviteModel.AcceptDate;

            DataContext.Invites.InsertOnSubmit(linqInviteModel);
            DataContext.SubmitChanges();
        }

        /// <summary>
        /// Repo method to update the details of an invite in the database according to userId and projectId. /MS
        /// </summary>
        public void UpdateInviteStatus(IInvitesModel inviteModel, int ProjectID)
        {
            var dbInvites = DataContext.Invites.First(i => i.User_ID == inviteModel.UserId && i.Project_ID == ProjectID);

            if (dbInvites != null && inviteModel != null)
            {
                dbInvites.Invite_status = inviteModel.InviteStatus;
                dbInvites.Accept_date = inviteModel.AcceptDate;
                dbInvites.User_ID = inviteModel.UserId;

                DataContext.SubmitChanges();
            }
        }
    }
}