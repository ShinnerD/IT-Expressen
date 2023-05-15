using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Written by Erik


namespace Interfaces.Repositories
{
    public interface IInvoiceRepository
    {

        /// <summary>
        /// Returns a List of IInvoiceRepository with projects related to the ProjectID provided. 
        /// </summary>
        List<IInvoiceModel> GetAllInvoiceProjectID(int projectid);
        /// <summary>
        /// Returns a List of IInvoiceRepository with projects related to the Allinvoice provided. 
        /// </summary>
        List<IInvoiceModel> GetAllInvoices(IInvoiceModel dbInvoice);

        /// <summary>
        /// Returns a List of IInvoiceRepository with projects related to the InvoiceID provided. 
        /// </summary>
        IInvoiceModel GetInvoiceID(int invoice);
       
    }
}
