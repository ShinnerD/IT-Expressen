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

        private List<IInvitesModel> AssignDomainProperties(List<IInvitesModel> inviteList)
        {
            foreach (var invite in inviteList)
            {
                AssignDomainProperties(invite);
            }
            return inviteList;
        }

        private void AssignDomainProperties(IInvitesModel invite)
        {
            var invitedUser = DomainServiceManager.UserService.GetUserFromID(invite.UserId);
            var invitedToProject = DomainServiceManager.ProjectService.GetProject(invite.ProjectId);
            DomainServiceManager.SpecializationService.FillUserSpecializationsProperty(new List<IUserModel>() { invitedUser });

            invite.InvitedUserName = invitedUser.UserName;
            invite.InvitedUserSpecializations = invitedUser.Specializations;
            invite.ProjectTitle = invitedToProject.Title;
            invite.ManagerName = invitedToProject.ManagerFullName;
        }

        public List<IInvitesModel> GetAllInvites()
        {
            return AssignDomainProperties(InvRepo.GetAllInvites());
        }

        public List<IInvitesModel> GetAllInvitedProjectID(int ProjectID)
        {
            return AssignDomainProperties(InvRepo.GetAllInviteProjectID(ProjectID));
        }

        public IInvitesModel GetInvitedProjectId(int ProjectID)
        {
            var result = InvRepo.GetInviteProjectId(ProjectID);
            AssignDomainProperties(result);
            return result;
        }

        public IInvitesModel GetInvitedUserID(int id)
        {
            var result = InvRepo.GetInviteUserId(id);
            AssignDomainProperties(result);
            return result;
        }

        public List<IInvitesModel> GetInvitedUserIDList(int id)
        {
            return AssignDomainProperties(InvRepo.GetAllInviteUserId(id));
        }

        public IInvitesModel GetInvitedUserName(string UserName)
        {
            var result = InvRepo.GetInviteUserName(UserName);
            AssignDomainProperties(result);
            return result;
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