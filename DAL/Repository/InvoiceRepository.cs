using DAL.Linq;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;
///Writen by Erik

namespace DAL.Repository
{
    public class InvoiceRepository
    {

        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);



        public List<InvoiceModel> GetAllInvoices(InvoiceModel dbInvoice)
        {
            List<InvoiceModel> result = new List<InvoiceModel>();

            var dbInvoices = DataContext.Invoices;
            foreach (var dbInvoiced in dbInvoices)
            {
                InvoiceModel Invoice = new InvoiceModel();

                Invoice.InvoiceId = dbInvoiced.Invoice_ID;
                Invoice.ProjectId = (int)dbInvoiced.Project_ID;
                Invoice.LineID = (int)dbInvoiced.Line_ID;
                Invoice.TotalPrice = (int)dbInvoiced.Total_Price;
                Invoice.InvoiceDate = dbInvoiced.Invoice_Date;




                result.Add(Invoice);
            }
            return result;


        }
            public InvoiceModel GetInvoiceID(int invoice)
            {

            InvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Invoice_ID == invoice);


            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.LineID = (int)dbInvoice.Line_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
            }

        public InvoiceModel GetInvoiceProjectID(int invoice)
        {

            InvoiceModel result = new InvoiceModel();

            var dbInvoice = DataContext.Invoices.FirstOrDefault(i => i.Project_ID == invoice);


            result.InvoiceId = dbInvoice.Invoice_ID;
            result.ProjectId = (int)dbInvoice.Project_ID;
            result.LineID = (int)dbInvoice.Line_ID;
            result.TotalPrice = (int)dbInvoice.Total_Price;
            result.InvoiceDate = dbInvoice.Invoice_Date;

            return result;
        }
    }
}
