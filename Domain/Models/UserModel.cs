using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// written by Erik. Model too User that have atrributes that is relavent too the case and project
    /// </summary>
    public class UserModel
    {
        public int TLF { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; } 

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
    }
}
