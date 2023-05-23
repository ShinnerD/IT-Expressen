using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

///Writen by Erik

namespace DAL.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        /// <summary>
        /// retrieving data from Database and Repository too store data
        /// </summary>
        private readonly DataClassesDataContext DataContext;

        public InvoiceRepository(IDataContextManager dataContext)
        {
            DataContext = dataContext.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        /// <summary>
        /// Getting a list off all Invoice, with the attributes that is in Invoice.
        /// </summary>
        public List<IInvoiceModel> GetAllInvoices()
        {
            List<IInvoiceModel> result = new List<IInvoiceModel>();

            var dbInvoices = DataContext.Invoices;
            foreach (var dbInvoiced in dbInvoices)
            {
                IInvoiceModel Invoice = new InvoiceModel();

                Invoice.InvoiceId = dbInvoiced.Invoice_ID;
                Invoice.ProjectId = (int)dbInvoiced.Project_ID;
                Invoice.TotalPrice = (decimal)dbInvoiced.Total_Price;
                Invoice.InvoiceDate = dbInvoiced.Invoice_Date;

                result.Add(Invoice);
            }
            return result;
        }

        /// <summary>
        /// Getting a list off all invoices with a specific ProjectID
        /// </summary>
        public IInvoiceModel GetInvoiceProjectID(int projectId)
        {

            var dbInvoices = DataContext.Invoices.FirstOrDefault(i => i.Project_ID == projectId);
            if (dbInvoices == null)
            {
                return null;
            }
            IInvoiceModel Invoice = new InvoiceModel();

            Invoice.InvoiceId = dbInvoices.Invoice_ID;
            Invoice.ProjectId = (int)dbInvoices.Project_ID;
            Invoice.TotalPrice = (decimal)dbInvoices.Total_Price;
            Invoice.InvoiceDate = dbInvoices.Invoice_Date;

            return Invoice;
        }

        /// <summary>
        /// Getting a specific invoice according to invoice Id.
        /// </summary>
        public IInvoiceModel GetInvoiceID(int invoiceId)
        {
            IInvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Invoice_ID == invoiceId);

            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.TotalPrice = (decimal)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }

        public void AddInvoice(IInvoiceModel invoice)
        {
            var newInovice = new Linq.Invoice();

            newInovice.Project_ID = invoice.ProjectId;
            newInovice.Total_Price = invoice.TotalPrice;
            newInovice.Invoice_Date = invoice.InvoiceDate;

            DataContext.Invoices.InsertOnSubmit(newInovice);
            DataContext.SubmitChanges();
        }
    }
}