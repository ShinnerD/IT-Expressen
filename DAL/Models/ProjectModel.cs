using DAL.Repository;
using Interfaces.Models;

namespace DAL.Models
{
    public class ProjectModel : IProjectModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string? ManagerUserName { get; set; }
        public string? ManagerFullName { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public DateTime? ProjectModifyDate { get; set; }
        public decimal? TotalInvoicePrice { get; set; }
        public string? ProjectStatus { get; set; }
        public string? Description { get; set; }
    }
}
