using DAL.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Repositories;
using Interfaces.Models;
using DAL.Models;
///Writen by Erik

namespace DAL.Repository
{
    

    public class InvoiceRepository : IInvoiceRepository
    {
        /// <summary>
        /// retrieving data from Database and Repository too store data
        /// </summary>
        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);


        /// <summary>
        /// Getting a list off all Invoice, with the attributes that is in Invoice.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Getting a list off all invoice with a specifik ProjectID
        /// </summary>
        /// <param name="projectid"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Getting a list off all invoice with a specifik InvoiceID
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
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

        
    }
}
