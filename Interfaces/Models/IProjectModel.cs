namespace Interfaces.Models
{
    public interface IProjectModel
    {
        string? ManagerFullName { get; set; }
        string? ManagerUserName { get; set; }
        DateTime? ProjectEndDate { get; set; }
        int ProjectId { get; set; }
        DateTime? ProjectModifyDate { get; set; }
        DateTime? ProjectStartDate { get; set; }
        string? ProjectStatus { get; set; }
        string? Title { get; set; }
        decimal? TotalInvoicePrice { get; set; }
        int UserId { get; set; }
        string? Description { get; set; }
    }
}