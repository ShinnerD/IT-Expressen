using DAL.Linq;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataClassesDataContext dbcontext = new DataClassesDataContext(DbConnectionString.ConnectionString);

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

        public IUserModel GetUser(string username)
        {
            IUserModel user = new DAL.Models.UserModel();

            var dbUser = dbcontext.Users.FirstOrDefault(i => i.User_name == username);

            if (dbUser != null)
            {
                user.ID = dbUser.User_ID;
                user.Address = dbUser.Street_Address;
                user.UserName = dbUser.User_name;
                user.Password = dbUser.Password;
                user.FirstName = dbUser.First_Name;
                user.LastName = dbUser.Last_Name;
                user.EMail = dbUser.Email;
                user.NameCity = dbUser.City;
                user.ZipCode = dbUser.Zip_Code;
                user.PhoneNumber = dbUser.Phone_Number;
                user.Country = dbUser.Country;
                user.ActiveStatus = dbUser.Active_Status;
                user.CreationDate = dbUser.Creation_Date;
                user.UserType = dbUser.User_Type;
            }

            return user;
        }
    }
}