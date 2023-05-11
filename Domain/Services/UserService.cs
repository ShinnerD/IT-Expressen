using DAL.Repository;
using Interfaces.Models;
using Interfaces.Services;
using Interfaces.Repositories;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private IUserRepository userRepo = new UserRepository();

        public List<IUserModel> GetAllUsers()
        {
            return userRepo.GetAllUsers();
        }

        public IUserModel GetUser(string userName)
        {
            return userRepo.GetUser(userName);
        }

        public bool UsernameExists(string userName)
        {
            return GetAllUsers().Exists(i => i.UserName == userName);
        }

        public string GetUserType(string userName)
        {
            if (UsernameExists(userName))
            {
                return userRepo.GetUser(userName).UserType;
            }
            return "";
        }
        public void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, List<string> specializtions)
        {
            IUserModel newUser = new DAL.Models.UserModel();

            newUser.UserName = UserName;
            newUser.Password = Password;
            newUser.UserType = UserType;
            newUser.FirstName = FirstName;
            newUser.LastName = LastName;
            newUser.Address = Address;
            newUser.NameCity = City;
            newUser.ZipCode = ZipCode;
            newUser.Country = Country;
            newUser.PhoneNumber = PhoneNumber;
            newUser.EMail = Email;
            newUser.ActiveStatus = true;
            newUser.CreationDate = DateTime.Now;


            userRepo.AddUser(newUser, specializtions);
        }

        void IUserService.Delete(string Delete)
        {
            userRepo.Delete(Delete);
            throw new NotImplementedException();
        }
    }
}