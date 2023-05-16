using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IUserService
    {
        List<IUserModel> GetAllUsers();

        //List<IUserModel> GetUserTypeList(string UserType);

        IUserModel GetUser(string userName);
        IUserModel GetUserFromID(int ID);

        string GetUserType(string userName);

        bool UsernameExists(string userName);
        void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, List<string> Specializations);
        void Delete(string Delete);
        List<IUserModel> FindUsersWithUserType(string userType);

        /// <summary>
        /// Returns a list of Users that have any of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        List<IUserModel> GetUsersWithAnySpecializations(List<string> specializations);

        /// <summary>
        /// Returns a list of Users that have all of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAllSpecializations(List<string> specializations);
    }
}
