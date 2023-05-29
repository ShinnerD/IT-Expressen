using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IDomainServiceManager ServiceManager;
        private readonly IInvoiceRepository InvoiceRepository;

        public InvoiceService(IDomainServiceManager serverManager, IDataContextManager dataContextManger)
        {
            ServiceManager = serverManager;
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

        public void UpdateInvoice(IInvoiceModel invoice)
        {
            //Error checks - is the invoice update consistent with the state of the project?
            IProjectModel? targetProject = ServiceManager.ProjectService.GetProject(invoice.ProjectId);
            if (targetProject.ProjectStatus?.ToLower() != "ended") { throw new Exception("You can't finalize an invoice for an ongoing or pending project."); }
            
            try
            {
                //Calculate the final invoice total.
                var invoiceLines = ServiceManager.ConsultantLineService.GetAllConsultantLinesFromProjectID(invoice.ProjectId);
                invoice.TotalPrice = invoiceLines.Sum(i => i.LineTotal);

                //Set the date and Update the Invoice with the relevant information in the database.
                invoice.InvoiceDate = DateTime.Now;
                InvoiceRepository.UpdateInvoice(invoice);
            }
            catch (Exception)
            {
                throw new Exception("There was an error updating the Invoice.");
            }
        }
    }
}