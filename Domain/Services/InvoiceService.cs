using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{

    public class InvoiceService : IInvoiceService
    {
        private readonly IDomainServiceManager ServerManager;
        private readonly IInvoiceRepository InvoiceRepository;

        public InvoiceService(IDomainServiceManager serverManager, IDataContextManager dataContextManger)
        {
            ServerManager = serverManager;
            InvoiceRepository = new InvoiceRepository(dataContextManger);
        }

        public void AddInvoice(int projectID, decimal totalPrice, DateTime invoiceDate)
        {
            IInvoiceModel newInvoice = new DAL.Models.InvoiceModel();

            newInvoice.ProjectId = projectID;
            newInvoice.TotalPrice = totalPrice;
            newInvoice.InvoiceDate = invoiceDate;

            InvoiceRepository.AddInvoice(newInvoice);
        }
        public List<IInvoiceModel> GetAllInvoices()
        {
            return InvoiceRepository.GetAllInvoices();
        }
        public IInvoiceModel GetInvoiceFromProjectID(int projectID)
        {
            return InvoiceRepository.GetInvoiceProjectID(projectID);
        }
        public IInvoiceModel GetInvoiceID(int invoiceID)
        {
            return InvoiceRepository.GetInvoiceID(invoiceID);
        }
    }
}

