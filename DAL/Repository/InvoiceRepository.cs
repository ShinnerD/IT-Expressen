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
                Invoice.LineID = (int)dbInvoiced.Line_ID;
                Invoice.TotalPrice = (int)dbInvoiced.Total_Price;
                Invoice.InvoiceDate = dbInvoiced.Invoice_Date;

                result.Add(Invoice);
            }
            return result;
        }

        /// <summary>
        /// Getting a list off all invoices with a specific ProjectID
        /// </summary>
        public List<IInvoiceModel> GetAllInvoiceProjectID(int projectId)
        {
            List<IInvoiceModel> result = new List<IInvoiceModel>();

            var dbInvoices = DataContext.Projects.First(i => i.Project_ID == projectId).Invoices;

            foreach (var dbInvoiced in dbInvoices)
            {
                IInvoiceModel Invoice = new InvoiceModel();

                Invoice.InvoiceId = dbInvoiced.Invoice_ID;
                Invoice.ProjectId = (int)dbInvoiced.Project_ID;
                Invoice.LineID = (int)dbInvoiced.Line_ID;
                Invoice.TotalPrice = (int)dbInvoiced.Total_Price;
                Invoice.InvoiceDate = dbInvoiced.Invoice_Date;

                result.Add(Invoice);
            }
            return result;
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
            result.LineID = (int)dbInvoice.Line_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }
    }
}