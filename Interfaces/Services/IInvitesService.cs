using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IInviteService
    {
        List<IInvitesModel> GetAllInvites();

        List<IInvitesModel> GetAllInvitedProjectID(int ProjectID);

        IInvitesModel GetInvitedProjectId(int ProjectID);

        IInvitesModel GetInvitedUserID(int id);

        IInvitesModel GetInvitedUserName(string UserName);


        void AddInvites(int ProjectID, int UserID, DateTime inviteDate, bool InviteStatus, DateTime AcceptDate);
    }
}