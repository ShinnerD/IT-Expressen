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
    }
}