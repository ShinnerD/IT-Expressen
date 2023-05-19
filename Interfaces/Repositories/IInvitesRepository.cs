using Interfaces.Models;

///Written by Erik
namespace Interfaces.Repositories
{
    public interface IInvitesRepository
    {
        /// <summary>
        /// Getting a list off all invites, with the attributes that is in invites.
        /// </summary>
        List<IInvitesModel> GetAllInvites();

        /// <summary>
        /// Getting a list off all invites with a specific ProjectID
        /// </summary>
        List<IInvitesModel> GetAllInviteProjectID(int projectid);

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        List<IInvitesModel> GetAllInviteUserId(int UserId);

        /// <summary>
        /// Repo method to update the details of an invite in the database according to userId and projectId. /MS
        /// </summary>
        void UpdateInviteStatus(IInvitesModel inviteModel, int ProjectID);

        /// <summary>
        ///  Repo method to add invitations to a project, the invited consultants userID is stored /MS
        /// </summary>
        void AddInvite(IInvitesModel inviteModel);
    }
}