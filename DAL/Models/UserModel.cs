using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace DAL.Models
{
    //public interface IUserModel
    //{
    //    bool ActiveStatus { get; set; }
    //    string Address { get; set; }
    //    string Country { get; set; }
    //    DateTime CreationDate { get; set; }
    //    string EMail { get; set; }
    //    string FirstName { get; set; }
    //    int ID { get; set; }
    //    string LastName { get; set; }
    //    string NameCity { get; set; }
    //    string Password { get; set; }
    //    string PhoneNumber { get; set; }
    //    int Specialization { get; set; }
    //    string UserName { get; set; }
    //    string UserType { get; set; }
    //    int ZipCode { get; set; }
    //}

    /// <summary>
    /// written by Erik. Model too User that have atrributes that is relavent too the case and project
    /// </summary>
    public class UserModel : IUserModel
    {
        public string? PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }

        public DateTime? CreationDate { get; set; }

        public string NameCity { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }
        public string Country { get; set; }

        public int ID { get; set; }

        public bool? ActiveStatus { get; set; }

        public int Specialization { get; set; }
    }
}
