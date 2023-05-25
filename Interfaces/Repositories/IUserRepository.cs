using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets a list of all users in the users table on the database.
        /// </summary>
        List<IUserModel> GetAllUsers();

        /// <summary>
        /// Gets a list of all users of a certain type from the database.
        /// </summary>
        List<IUserModel> GetUsersType(string UserType);

        /// <summary>
        /// Retrieves a single users details from the database with a matching username.
        /// </summary>
        IUserModel GetUserFromUsername(string username);

        /// <summary>
        /// Retrieves a single users details from the database with a matching user Id.
        /// </summary>
        IUserModel GetUserFromID(int ID);

        /// <summary>
        /// Adds a user to the database. Provide an empty list of specializations if none are chosen.
        /// </summary>
        void AddUser(IUserModel userModel, List<string> specializations);

        /// <summary>
        /// Deletes a user in the database.
        /// </summary>
        void Delete(int userId);

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

        public void DeleteConsultantStoredProcedure(int userID);
        /// <summary>
        /// Deletes a user in the database. /Erik
        /// </summary>

    }
}