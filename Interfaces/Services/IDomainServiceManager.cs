namespace Interfaces.Services
{
    public interface IDomainServiceManager
    {
        IUserService UserService { get; }
        IProjectService ProjectService { get; }
        IInviteService InviteService { get; }
        ISpecializationService SpecializationService { get; }
        IMessageService MessageService { get; }
        IConsultantLineService ConsultantLineService { get; }
        IInvoiceService InvoiceService { get; }
    }
}