using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface IInvoiceModel
    {
        DateTime? InvoiceDate { get; set; }
        int InvoiceId { get; set; }
        int LineID { get; set; }
        int ProjectId { get; set; }
        int TotalPrice { get; set; }
    }
}
