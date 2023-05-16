using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<IUserModel> GetAllUsers();

        IUserModel GetUser(string username);
        IUserModel GetUserFromID(int ID);

        void AddUser(IUserModel userModel, List<string> specializations);
        void Delete(string delete);

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