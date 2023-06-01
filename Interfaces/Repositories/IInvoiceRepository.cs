using Interfaces.Models;

///Written by Erik

namespace Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        /// <summary>
        /// Returns a List of IInvoices related to the ProjectID provided.
        /// </summary>
        IInvoiceModel GetInvoiceProjectID(int projectId);

        /// <summary>
        /// Getting a list off all Invoice, with the attributes that is in Invoice.
        /// </summary>
        List<IInvoiceModel> GetAllInvoices();

        /// <summary>
        /// Getting a specific invoice according to invoice Id.
        /// </summary>
        IInvoiceModel GetInvoiceID(int invoiceId);

        /// <summary>
        /// Enable the system to add an invoice to the invoice table on the database //MS
        /// </summary>
        /// <param name="invoice"></param>
        void AddInvoice(IInvoiceModel invoice);

        /// <summary>
        /// Enable the system to update an invoice to the invoice table on the database //MS
        /// </summary>
        /// <param name="invoice"></param>
        void UpdateInvoice(IInvoiceModel invoice);
    }
}