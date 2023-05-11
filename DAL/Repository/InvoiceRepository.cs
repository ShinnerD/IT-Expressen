using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

///Writen by Erik

namespace DAL.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public List<IInvoiceModel> GetAllInvoices(IInvoiceModel dbInvoice)
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

        public List<IInvoiceModel> GetAllInvoiceProjectID(int projectid)
        {
            List<IInvoiceModel> result = new List<IInvoiceModel>();

            var dbInvoices = DataContext.Projects.FirstOrDefault(i => i.Project_ID == projectid).Invoices;

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

        public IInvoiceModel GetInvoiceID(int invoice)
        {
            IInvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Invoice_ID == invoice);

            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.LineID = (int)dbInvoice.Line_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }

        public IInvoiceModel GetInvoiceInvoiceID(int invoice)
        {
            IInvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Invoice_ID == invoice);

            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.LineID = (int)dbInvoice.Line_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }
    }
}