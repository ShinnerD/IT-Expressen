using Interfaces.Models;

///Written by Erik

namespace Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        /// <summary>
        /// Returns a List of IInvoices related to the ProjectID provided.
        /// </summary>
        List<IInvoiceModel> GetAllInvoiceProjectID(int projectId);

        /// <summary>
        /// Getting a list off all Invoice, with the attributes that is in Invoice.
        /// </summary>
        List<IInvoiceModel> GetAllInvoices();

        /// <summary>
        /// Getting a specific invoice according to invoice Id.
        /// </summary>
        IInvoiceModel GetInvoiceID(int invoiceId);
    }
}