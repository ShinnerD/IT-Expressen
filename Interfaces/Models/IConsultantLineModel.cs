using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface IConsultantLineModel
    {
        decimal HourlyRate { get; set; }
        int HoursTotal { get; set; }
        int LineID { get; set; }
        int ProjectID { get; set; }
        int UserID { get; set; }
        int? InvoiceID { get; set; }

    }
}
