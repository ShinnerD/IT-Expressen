using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        List<IInvoiceModel> GetAllInvoiceProjectID(int projectid);
        List<IInvoiceModel> GetAllInvoices(IInvoiceModel dbInvoice);
        IInvoiceModel GetInvoiceID(int invoice);
       
    }
}
