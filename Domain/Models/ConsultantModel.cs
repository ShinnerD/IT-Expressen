using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class Konsulent
    {
        public int MyProperty { get; set; }

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
