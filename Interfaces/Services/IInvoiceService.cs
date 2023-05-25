using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IInvoiceService
    {
        void AddInvoice(int projectID, decimal totalPrice, DateTime invoiceDate);

        IInvoiceModel GetInvoiceFromProjectID(int projectID);

        List<IInvoiceModel> GetAllInvoices();

        IInvoiceModel GetInvoiceID(int invoiceID);

        void UpdateInvoice(IInvoiceModel invoice);
    }
}