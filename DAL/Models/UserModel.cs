﻿using Interfaces.Models;

namespace DAL.Models
{
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

        public List<string>? Specialization { get; set; }
    }
}