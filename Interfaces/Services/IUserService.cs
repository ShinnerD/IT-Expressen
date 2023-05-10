using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IUserService
    {
        List<IUserModel> GetAllUsers();

        IUserModel GetUser(string userName);

        string GetUserType(string userName);

        bool UsernameExists(string userName);
        void AddUser(string UserName, string password);
    }
}
