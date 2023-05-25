using Interfaces.Models;

namespace DAL.Models
{
    public class ConsultantLineModel : IConsultantLineModel
    {
        public int LineID { get; set; }
        public int ProjectID { get; set; }
        public int UserID { get; set; }
        public int? InvoiceID { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursTotal { get; set; }
    }
}