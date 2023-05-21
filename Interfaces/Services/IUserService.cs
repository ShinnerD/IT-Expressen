using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Adds a user to the database.
        /// If the user needs no specializations chosen at creation provide an empty list.
        /// </summary>
        void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, List<string> specializations);

        /// <summary>
        /// Updates a user in the database with any changes that might be in the IUserModel provided in the parameter.
        /// The Provided IUserModel must be a valid user from the database. /DK
        /// </summary>
        void UpdateUser(IUserModel user);

        /// <summary>
        /// Deletes a user from the database.
        /// </summary>
        void Delete(int userId);

        /// <summary>
        /// Gets a list of all users from the database.
        /// </summary>
        List<IUserModel> GetAllUsers();

        /// <summary>
        /// Retrieves a user from the database according to his user Id.
        /// </summary>
        IUserModel GetUserFromID(int ID);

        /// <summary>
        /// Retrieves a user from the database according to his username.
        /// </summary>
        IUserModel GetUserFromUsername(string userName);

        /// <summary>
        /// Returns a list of users that have a user type which matches the one specified in the parameters.
        /// </summary>
        List<IUserModel> FindUsersWithUserType(string userType);

        /// <summary>
        /// Returns a string with the specified user's user type. (Admin, Consultant, Manager)
        /// Returns an empty string if no user is found.
        /// </summary>
        string GetUserType(string userName);

        /// <summary>
        /// Returns a boolean based on the existence of a user with the specified username in the database.
        /// </summary>
        bool UsernameExists(string userName);

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