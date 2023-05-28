using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Domain Service Manager. Instantiates domain layer services and grabs the instance of the database data context and passes it down,
    /// so that all services act on the same data context. /Dennis Kempf
    /// </summary>
    public class DomainServiceManager : IDomainServiceManager
    {
        private readonly IUserService UserService;
        private readonly IProjectService ProjectService;
        private readonly IInviteService InviteService;
        private readonly ISpecializationService SpecializationService;
        private readonly IMessageService MessageService;
        private readonly IConsultantLineService ConsultantLineService;
        private readonly IInvoiceService InvoiceService;

        public DomainServiceManager()
        {
            IDataContextManager dataContext = DAL.DataContextManager.Instance;

            UserService = new UserService(this, dataContext);
            ProjectService = new ProjectService(this, dataContext);
            InviteService = new InviteService(this, dataContext);
            SpecializationService = new SpecializationService(this, dataContext);
            MessageService = new MessageService(this, dataContext);
            ConsultantLineService = new ConsultantLineService(this, dataContext);
            InvoiceService = new InvoiceService(this, dataContext);
        }

        IUserService IDomainServiceManager.UserService => UserService;

        IProjectService IDomainServiceManager.ProjectService => ProjectService;

        IInviteService IDomainServiceManager.InviteService => InviteService;

        ISpecializationService IDomainServiceManager.SpecializationService => SpecializationService;

        IMessageService IDomainServiceManager.MessageService => MessageService;

        IConsultantLineService IDomainServiceManager.ConsultantLineService => ConsultantLineService;

        IInvoiceService IDomainServiceManager.InvoiceService => InvoiceService;
    }
}