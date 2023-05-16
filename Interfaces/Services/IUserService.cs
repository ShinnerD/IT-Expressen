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

        /// <summary>
        /// Returns a list of Users that have any of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        List<IUserModel> GetUsersWithAnySpecializations(List<string> specializations);

        /// <summary>
        /// Returns a list of Users that have all of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAllSpecializations(List<string> specializations);

        /// <summary>
        /// Updates a user in the database with any changes that might be in the IUserModel provided in the parameter.
        /// The Provided IUserModel must be a valid user from the database. /DK
        /// </summary>
        void UpdateUser(IUserModel user);
    }
}
