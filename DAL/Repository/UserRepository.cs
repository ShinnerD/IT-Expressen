using DAL.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace DAL.Repository
{
    public class UserRepository
    {
        DataClassesDataContext dbcontext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public List<IUserModel> GetAllUsers()
        {
            var AlldtoUsers = dbcontext.Users;

            List<IUserModel> result = new List<IUserModel>();

            foreach (var dto in AlldtoUsers)
            {
                var user = new DAL.Models.UserModel();

                user.ID = dto.User_ID;
                user.Address = dto.Street_Address;
                user.UserName = dto.User_name;
                user.Password = dto.Password;
                user.FirstName = dto.First_Name;
                user.LastName = dto.Last_Name;
                user.EMail = dto.Email;
                user.NameCity = dto.City;
                user.ZipCode = dto.Zip_Code;
                user.PhoneNumber = dto.Phone_Number;
                user.Country = dto.Country;
                user.ActiveStatus = (bool?)dto.Active_Status;
                user.CreationDate = (DateTime?)dto.Creation_Date;
                user.UserType = dto.User_Type;
                //user.Specialization = dto.Specialisations_Lines.First(i => i.User_Id == user.ID).Spec_Id;

                result.Add(user);
            }
            return result;
        }
        public void AddUser(IUserModel dto)
        {
            var faf = new Linq.User
            {
                User_name = dto.UserName,
                Password = dto.Password,
                User_Type = dto.UserType,
                First_Name = dto.FirstName,
                Last_Name = dto.LastName,
                Street_Address = dto.Address,
                City = dto.NameCity,
                Zip_Code = dto.ZipCode,
                Country = dto.Country,
                Phone_Number = dto.PhoneNumber,
                Email = dto.EMail,
                Active_Status = true,
                Creation_Date = DateTime.Now,              
            };
            dbcontext.Users.InsertOnSubmit(faf);
            dbcontext.SubmitChanges();
        }

    }
}

