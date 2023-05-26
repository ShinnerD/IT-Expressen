using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class InviteService : IInviteService
    {
        private readonly IInvitesRepository InvRepo;
        private readonly IDomainServiceManager DomainServiceManager;

        public InviteService(IDomainServiceManager domainServiceManager, IDataContextManager dataContextManager)
        {
            DomainServiceManager = domainServiceManager;
            InvRepo = new InvitesRepository(dataContextManager);
        }

        public InviteService()
        {
        }

        /// <summary>
        /// Returns a list of all invites in the database.
        /// </summary>
        /// <returns></returns>
        public List<IInvitesModel> GetAllInvites()
        {
            return InvRepo.GetAllInvites();
        }

        /// <summary>
        /// Returns a list of all invites related to a specific project Id.
        /// </summary>
        public List<IInvitesModel> GetAllInvitedProjectID(int ProjectID)
        {
            return InvRepo.GetAllInviteProjectID(ProjectID);
        }

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        public List<IInvitesModel> GetInvitesFromUserId(int id)
        {
            return InvRepo.GetAllInviteUserId(id);
        }

        /// <summary>
        /// Updates the details of an invite in the database according to userId and projectId. /MS
        /// </summary>
        public void UpdateInviteStatus(IInvitesModel inviteModel, int projectID)
        {
            InvRepo.UpdateInviteStatus(inviteModel, projectID);
        }

        /// <summary>
        ///  Adds an invitation to a project, the invited consultants userID is stored /MS
        /// </summary>
        public void AddInvites(int ProjectID, int UserID, DateTime inviteDate, string InviteStatus)
        {
            if (DomainServiceManager.ProjectService.GetProject(ProjectID).ProjectEndDate < DateTime.Now)
            {
                throw new Exception("Can't create an invite for a project that has ended.");
            }

            IInvitesModel newInvite = new DAL.Models.InvitesModel();

            newInvite.ProjectId = ProjectID;
            newInvite.UserId = UserID;
            newInvite.InviteDate = DateTime.Now;
            newInvite.InviteStatus = InviteStatus;

            InvRepo.AddInvite(newInvite);
        }

        /// <summary>
        /// Deletes an invite from the database. Prevents deletion of accepted invites unless the boolean deleteAccetedInvite is explicitly
        /// set to true when calling the method. This is for admin privileges atm. /DK
        /// </summary>
        public void DeleteInvite(IInvitesModel invite, bool deleteAcceptedInvite = false)
        {
            if (invite.InviteStatus?.ToLower() == "accepted" && !deleteAcceptedInvite)
            {
                throw new ArgumentException("Can't remove an already accepted invite.");
            }

            InvRepo.DeleteInvite(invite.ProjectId, invite.UserId);
        }
    }
}