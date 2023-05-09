using DAL.Repository;
using Interfaces.Models;

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
    }
}