using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Domain.Models
{
    /// <summary>
    /// written by Erik. Model too  Specialisation that have atrributes that is relavent too the case and project
    /// </summary>

    public class SpecialisationModel
    {
        public int SpecId { get; set; }
        public string Specialisation { get; set; }
        public string Description { get; set; }

    }
}
