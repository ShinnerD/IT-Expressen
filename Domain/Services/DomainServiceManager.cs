using DAL.Linq;
using Interfaces.Repositories;
using Interfaces.Services;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Services
{
    public class DomainServiceManager : IDomainServiceManager
    {
        readonly IUserService UserService;
        readonly IProjectService ProjectService;
        readonly IInviteService InviteService;
        readonly ISpecializationService SpecializationService;
        readonly IMessageService MessageService;

        public DomainServiceManager()
        {
            IDataContextManager dataContext = DAL.DataContextManager.Instance;

            UserService = new UserService(this, dataContext);
            ProjectService = new ProjectService(this, dataContext);
            InviteService = new InviteService(this, dataContext);
            SpecializationService = new SpecializationService(this, dataContext);
            MessageService = new MessageService(this, dataContext);
        }

        IUserService IDomainServiceManager.UserService => UserService;

        IProjectService IDomainServiceManager.ProjectService => ProjectService;

        IInviteService IDomainServiceManager.InviteService => InviteService;

        ISpecializationService IDomainServiceManager.SpecializationService => SpecializationService;

       IMessageService IDomainServiceManager.MessageService => MessageService;
    }
}