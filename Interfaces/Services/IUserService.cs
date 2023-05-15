using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IUserService
    {
        List<IUserModel> GetAllUsers();

        //List<IUserModel> GetUserTypeList(string UserType);

        IUserModel GetUser(string userName);

        string GetUserType(string userName);

        bool UsernameExists(string userName);
        void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, List<string> Specializations);
        void Delete(string Delete);
        List<IUserModel> FindUsersWithUserType(string userType);
    }
}
