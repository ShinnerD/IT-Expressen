using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IInvoiceService
    {
        void AddInvoice(int projectID, decimal totalPrice, DateTime invoiceDate);
        IInvoiceModel GetInvoiceFromProjectID(int projectID);
        List<IInvoiceModel> GetAllInvoices();
        IInvoiceModel GetInvoiceID(int invoiceID);
    }
}
