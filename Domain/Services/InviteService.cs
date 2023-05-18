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

        public List<IInvitesModel> GetAllInvites()
        {
            return InvRepo.GetAllInvites();
        }

        public List<IInvitesModel> GetAllInvitedProjectID(int ProjectID)
        {
            return InvRepo.GetAllInviteProjectID(ProjectID);
        }

        public IInvitesModel GetInvitedProjectId(int ProjectID)
        {
            return InvRepo.GetInviteProjectId(ProjectID);
        }

        public IInvitesModel GetInvitedUserID(int id)
        {
            return InvRepo.GetInviteUserId(id);
        }
        public List<IInvitesModel> GetInvitedUserIDList(int id)
        {
            return InvRepo.GetInviteUserIdList(id);
        }
        public IInvitesModel GetInvitedUserName(string UserName)
        {
            return InvRepo.GetInviteUserName(UserName);
        }
        public void UpdateInviteStatus(IInvitesModel inviteModel, int projectID)
        {
            InvRepo.UpdateInviteStatus(inviteModel, projectID);
        }
        public void AddInvites(int ProjectID, int UserID, DateTime inviteDate, string InviteStatus)
        {
            IInvitesModel newInvite = new DAL.Models.InvitesModel();

            newInvite.ProjectId = ProjectID;
            newInvite.UserId = UserID;
            newInvite.InviteDate = DateTime.Now;
            newInvite.InviteStatus = InviteStatus;

            InvRepo.AddInvite(newInvite);

        }
    }
}