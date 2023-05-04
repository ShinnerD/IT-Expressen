using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// written by Erik. Model too Consultant that have atrributes that is relavent too the case and project
/// </summary>
namespace Domain.Models
{
    internal class ConsultantModel
    {

        public int TLF { get; set; }

        public string Name { get; set; }

        public int LastName { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }

        public DateTime CreationDate { get; set; }

        public string NameCity { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public int ID { get; set; }

        public bool ActiveStatus { get; set; }

        public int Specialization { get; set; }

        public int HourRate { get; set; }

        public int HoursSpendt { get; set; }

        public int TotalEarnings { get; set; }




    /// <summary>
    /// Dette er en test metode tilføjet for at teste, hvordan kode bliver tilføjet til Wiki inde i Azure Devops.
    /// </summary>
    /// <param name="number">Tager en integer som parameter</param>
    /// <returns>Returnerer den givne integer som en string</returns>
    public string TestMethodForDocumentation(int number)
        {
            return number.ToString();
        }


    }
}
