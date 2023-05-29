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
            var dbInvites = DataContext.Invites;
            return TransferAllInviteProperties(dbInvites);
        }

        /// <summary>
        /// Getting a list off all invites with a specific ProjectID
        /// </summary>
        public List<IInvitesModel> GetAllInviteProjectID(int projectid)
        {
            var dbInvites = DataContext.Invites.Where(i => i.Project_ID == projectid);
            return TransferAllInviteProperties(dbInvites);
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
            result.InviteDate = dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = dbInvite.Accept_date;

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
            result.InviteDate = dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = dbInvite.Accept_date;

            return result;
        }

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        public List<IInvitesModel> GetAllInviteUserId(int UserId)
        {
            var dbInvites = DataContext.Invites.Where(i => i.User_ID == UserId);
            return TransferAllInviteProperties(dbInvites);
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
            result.InviteDate = dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = dbInvite.Accept_date;

            return result;
        }

        /// <summary>
        ///  Repo method to add invitations to a project, the invited consultants userID is stored /MS
        /// </summary>
        public void AddInvite(IInvitesModel inviteModel)
        {
            //Check to make sure the invite isn't a duplicate <-- check works in database as well, but code fails if it his SubmitChanges and
            //the failed invite stays in memory and doesn't get cleared. /DK
            ///  Don't remove the check for duplicate entries in this method. "For some reason" the session gets completely
            ///  locked from adding new invites if one fails because of duplicate keys. So the check is there to make sure
            ///  you never reach .SubmitChanges() if there already is a duplicate value. This prevents the locked state.
            bool InviteExists = DataContext.Invites.Any(i => i.User_ID == inviteModel.UserId && i.Project_ID == inviteModel.ProjectId);
            if (InviteExists) throw new Exception("An Invite for this user on this project, already exists.");

            //If the invite doesn't exist on the database, go ahead and make one and insert.
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
            var dbInvites = DataContext.Invites.FirstOrDefault(i => i.User_ID == inviteModel.UserId && i.Project_ID == ProjectID);

            if (dbInvites != null && inviteModel != null)
            {
                dbInvites.Invite_status = inviteModel.InviteStatus;
                dbInvites.Accept_date = inviteModel.AcceptDate;
                dbInvites.User_ID = inviteModel.UserId;

                DataContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Deletes an Invite in the database.
        /// </summary>
        public void DeleteInvite(int projectId, int userId)
        {
            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.Project_ID == projectId && i.User_ID == userId);

            if (dbInvite != null)
            {
                DataContext.Invites.DeleteOnSubmit(dbInvite);
                DataContext.SubmitChanges();
            }
        }


        private List<IInvitesModel> TransferAllInviteProperties(IQueryable<Linq.Invite>? dtoInvites)
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            if (dtoInvites is null) { return result; }

            var relatedProjectIds = dtoInvites.Select(i => i.Project_ID).ToList();
            var relatedUserIds = dtoInvites.Select(i => i.User_ID).ToList();

            var relatedProjects = DataContext.Projects.Where(i => relatedProjectIds.Contains(i.Project_ID)).ToList();
            var relatedUsers = DataContext.Users.Where(i => relatedUserIds.Contains(i.User_ID)).ToList();

            foreach (var dto in dtoInvites)
            {
                IInvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dto.Project_ID;
                Invite.UserId = dto.Project_ID;
                Invite.InviteDate = dto.Invite_Date;
                Invite.InviteStatus = dto.Invite_status;
                Invite.AcceptDate = dto.Accept_date;

                var invitedUser = relatedUsers.FirstOrDefault(i => i.User_ID == dto.User_ID);
                if (invitedUser != null)
                {
                    Invite.InvitedUserName = invitedUser.User_name;
                    Invite.InvitedUserFullName = invitedUser.First_Name + " " + invitedUser.Last_Name;
                    Invite.InvitedUserSpecializations = string
                        .Join(", ", invitedUser.Specialisations_Lines
                        .Select(i => i.Specialisation.Specialisation1)
                        .OrderBy(i => i).ToArray());
                }
                var invitedProject = relatedProjects.FirstOrDefault(i => i.Project_ID == dto.Project_ID);
                if (invitedProject != null)
                {
                    Invite.ProjectTitle = invitedProject.Title;
                    Invite.ManagerName = invitedProject.User.First_Name + " " + invitedProject.User.Last_Name;
                }

                Invite.ConLineSum = dto.Project.Consultant_Lines
                    .Where(i => i.User_ID == dto.User_ID)
                    .Select(i => i.Hours_total * i.Hourly_Rate)
                    .Sum();

                result.Add(Invite);
            }
            return result;
        }
    }
}