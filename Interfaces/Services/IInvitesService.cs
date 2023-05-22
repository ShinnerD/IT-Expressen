using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IInviteService
    {
        /// <summary>
        /// Returns a list of all invites in the database.
        /// </summary>
        List<IInvitesModel> GetAllInvites();

        /// <summary>
        /// Returns a list of all invites related to a specific project Id.
        /// </summary>
        List<IInvitesModel> GetAllInvitedProjectID(int ProjectID);

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        List<IInvitesModel> GetInvitesFromUserId(int id);

        /// <summary>
        /// Updates the details of an invite in the database according to userId and projectId. /MS
        /// </summary>
        void UpdateInviteStatus(IInvitesModel inviteModel, int projectID);

        /// <summary>
        ///  Adds an invitation to a project, the invited consultants userID is stored /MS
        /// </summary>
        void AddInvites(int ProjectID, int UserID, DateTime inviteDate, string InviteStatus);

        /// <summary>
        /// Deletes an invite from the database.
        /// </summary>
        void DeleteInvite(IInvitesModel invite);
    }
}