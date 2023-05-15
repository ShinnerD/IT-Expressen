using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class InviteService : IInviteService
    {
        private IInvitesRepository InvRespo = new InvitesRepository();

        public List<IInvitesModel> GetAllInvites()
        {
            return InvRespo.GetAllInvites();
        }

        public List<IInvitesModel> GetAllInvitedProjectID(int ProjectID)
        {
            return InvRespo.GetAllInviteProjectID(ProjectID);
        }

        public IInvitesModel GetInvitedProjectId(int ProjectID)
        {
            return InvRespo.GetInviteProjectId(ProjectID);
        }

        public IInvitesModel GetInvitedUserID(int id)
        {
            return InvRespo.GetInviteUserId(id);
        }
        public IInvitesModel GetInvitedUserName(string UserName)
        {
            return InvRespo.GetInviteUserName(UserName);
        }
        public void AddInvites(int ProjectID, int UserID, DateTime inviteDate, bool InviteStatus, DateTime AcceptDate)
        {
            IInvitesModel newInvite = new DAL.Models.InvitesModel();

            newInvite.ProjectId = ProjectID;
            newInvite.UserId = UserID;
            newInvite.InviteDate = DateTime.Now;
            newInvite.InviteStatus = InviteStatus;
            newInvite.AcceptDate = AcceptDate;

            InvRespo.AddInvite(newInvite);

        }
    }
}