using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<IUserModel> GetAllUsers();

        IUserModel GetUser(string username);

        void AddUser(IUserModel userModel, List<string> specializtions);
        List<IUserModel> GetUsersType(string UserType);
        void Delete(string delete);
    }
}