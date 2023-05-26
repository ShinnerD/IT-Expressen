namespace Interfaces.Models
{
    /// <summary>
    /// written by Erik. Model too  Specialisation that have atrributes that is relavent too the case and project. the model that couples with the Interface Repo Invoice and the Domain Model Invoice.
    /// </summary>
    public interface IInvoiceModel
    {
        DateTime? InvoiceDate { get; set; }
        int InvoiceId { get; set; }
        int ProjectId { get; set; }
        decimal? TotalPrice { get; set; }
    }
}