using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models
{
    /// <summary>
    /// written by Erik. Model too Project that have atrributes that is relavent too the case and project
    /// </summary>

    public class Project
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public DateTime ProjectModifyDate { get; set; }
        public int TotalInvoicePrice { get; set; }
        public string ProjectStatus { get; set; }
    }
}
