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
        string? ConsultantName { get; set; }
        decimal? LineTotal { get; }
    }
}