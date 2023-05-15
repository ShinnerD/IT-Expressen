using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Domain.Models
{
    /// <summary>
    /// written by Erik. Model too  Specialisation that have atrributes that is relavent too the case and project. the domain is making a architecture bridge with the DAL and Interface Models.
    /// </summary>
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public int ProjectId { get; set; }
        public int LineID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
