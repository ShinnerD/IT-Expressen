using Interfaces.Models;

namespace DAL.Models
{
    /// <summary>
    /// written by Erik. Model too  Specializations that have attributes that is relevant too the case and project
    /// </summary>
    public class InvoiceModel : IInvoiceModel
    {
        public int InvoiceId { get; set; }
        public int ProjectId { get; set; }
        public int LineID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}