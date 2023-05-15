using Interfaces.Models;

namespace DAL.Models
{


    /// <summary>
    /// written by Erik. Model too  Specialisation that have atrributes that is relavent too the case and project. the model that couples with the DAL Repo Invoice and the Domain Model Invoice.
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