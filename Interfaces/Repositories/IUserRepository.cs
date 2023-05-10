using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<IUserModel> GetAllUsers();

        IUserModel GetUser(string username);

        void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, bool ActiveStatus, DateTime CreationDate);
    }
}