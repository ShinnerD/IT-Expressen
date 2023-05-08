using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
        public interface IUserModel
        {
            bool? ActiveStatus { get; set; }
            string Address { get; set; }
            string Country { get; set; }
            DateTime? CreationDate { get; set; }
            string EMail { get; set; }
            string FirstName { get; set; }
            int ID { get; set; }
            string LastName { get; set; }
            string NameCity { get; set; }
            string Password { get; set; }
            string? PhoneNumber { get; set; }
            //int Specialization { get; set; }
            string UserName { get; set; }
            string UserType { get; set; }
            string ZipCode { get; set; }
        }   
}
