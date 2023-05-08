using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

/// <summary>
/// written by Erik. Model too Consultant that have atrributes that is relavent too the case and project
/// </summary>
namespace Domain.Models
{

    public class ConsultantModel : IConsultant
    {

        public int TLF { get; set; }

        public string Name { get; set; }

        public int LastName { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }

        public DateTime Creation_Date { get; set; }

        public string NameCity { get; set; }

        public string Street_Address { get; set; }

        public int ZipCode { get; set; }

        public int ID { get; set; }

        public bool ActiveStatus { get; set; }

        public int Specialization { get; set; }

        public int HourRate { get; set; }

        public int HoursSpendt { get; set; }

        public int TotalEarnings { get; set; }

    }
}
