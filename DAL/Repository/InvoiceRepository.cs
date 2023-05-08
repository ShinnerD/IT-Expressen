using DAL.Linq;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace Dal.Repository
{
    public class InvoiceRepository
    {

        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);



        public List<InvoiceModel> GetAllInvoices(InvoiceModel dbInvoice)
        {
            List<InvoiceModel> result = new List<InvoiceModel>();

            var dbInvoices = DataContext.Invoices;
            foreach (var dbInvoice in dbInvoices)
            {
                InvoiceModel Invoice = new InvoiceModel();

                Invoice.InvoiceId = dbInvoice.Invoice_ID;
                Invoice.ProjectId = (int)dbInvoice.Project_ID;
                Invoice.LineID = dbInvoice.Invoice_ID;
                Invoice.TotalPrice = (int)dbInvoice.Total_Price;
                Invoice.InvoiceDate = dbInvoice.Invoice_Date;




                result.Add(Invoice);
            }
            return result;


        }
            public InvoiceModel GetInvoice(int invoice)
        {

            InvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Invoice_ID == invoice);


            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.LineID = dbInvoice.Invoice_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }


    }
}
