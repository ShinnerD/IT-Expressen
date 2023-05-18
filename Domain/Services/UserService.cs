using DAL.Repository;
using Interfaces.Models;
using Interfaces.Services;
using Interfaces.Repositories;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepo;
        private readonly IDomainServiceManager _domainServiceManager;

        public UserService(IDomainServiceManager domainServiceManager, IDataContextManager dataContextManager) 
        {
            _domainServiceManager = domainServiceManager;
            userRepo = new UserRepository(dataContextManager);
            }

        public List<IUserModel> GetAllUsers()
        {
            return userRepo.GetAllUsers();
        }
        //public List<IUserModel> GetUserTypeList(string UserType)
        //{
        //    return userRepo.GetUserTypeList(UserType);
        //}
        public IUserModel GetUserFromID(int ID)
        {
            return userRepo.GetUserFromID(ID);
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
        public List<IUserModel> FindUsersWithUserType(string userType)
        {
            var result = GetAllUsers().Where(i => i.UserType == userType).ToList();
            return result;
        }

        void IUserService.Delete(string Delete)
        {
            userRepo.Delete(Delete);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of Users that have any of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAnySpecializations(List<string> specializations)
        {
            return userRepo.GetUsersWithAnySpecializations(specializations);
        }

        /// <summary>
        /// Returns a list of Users that have all of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAllSpecializations(List<string> specializations)
        {
            return userRepo.GetUsersWithAllSpecializations(specializations);
        }

        /// <summary>
        /// Updates a user in the database with any changes that might be in the IUserModel provided in the parameter.
        /// The Provided IUserModel must be a valid user from the database. /DK
        /// </summary>
        public void UpdateUser(IUserModel user)
        {
            userRepo.UpdateUser(user);
        }
    }
}