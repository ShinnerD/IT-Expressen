using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;
using System.Net.Mail;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepo;
        private readonly IDomainServiceManager _domainServiceManager;

        public UserService(IDomainServiceManager domainServiceManager, IDataContextManager dataContextManager)
        {
            _domainServiceManager = domainServiceManager;
            userRepo = new UserRepository(dataContextManager);
        }

        /// <summary>
        /// Gets a list of all users from the database.
        /// </summary>
        public List<IUserModel> GetAllUsers()
        {
            return userRepo.GetAllUsers();
        }

        /// <summary>
        /// Retrieves a user from the database according to his user Id.
        /// </summary>
        public IUserModel GetUserFromID(int ID)
        {
            return userRepo.GetUserFromID(ID);
        }

        /// <summary>
        /// Retrieves a user from the database according to his username.
        /// </summary>
        public IUserModel GetUserFromUsername(string userName)
        {
            return userRepo.GetUserFromUsername(userName);
        }

        /// <summary>
        /// Returns a boolean based on the existence of a user with the specified username in the database.
        /// </summary>
        public bool UsernameExists(string userName)
        {
            return GetAllUsers().Exists(i => i.UserName == userName);
        }

        /// <summary>
        /// Returns a string with the specified user's user type. (Admin, Consultant, Manager)
        /// Returns an empty string if no user is found.
        /// </summary>
        public string GetUserType(string userName)
        {
            if (UsernameExists(userName))
            {
                return userRepo.GetUserFromUsername(userName).UserType;
            }
            return "";
        }

        /// <summary>
        /// Adds a user to the database.
        /// If the user needs no specializations chosen at creation provide an empty list.
        /// </summary>
        public void AddUser(string UserName, string Password, string UserType, string FirstName, string LastName, string Address, string City, string ZipCode, string Country, string PhoneNumber, string Email, List<string> specializations)
        {
            IUserModel newUser = new DAL.Models.UserModel();

            newUser.UserName = UserName.Trim();
            newUser.Password = Password;
            newUser.UserType = UserType;
            newUser.FirstName = FirstName.Trim();
            newUser.LastName = LastName.Trim();
            newUser.Address = Address.Trim();
            newUser.NameCity = City.Trim();
            newUser.ZipCode = ZipCode.Trim();
            newUser.Country = Country.Trim();
            newUser.PhoneNumber = PhoneNumber.Trim();
            newUser.EMail = Email.Trim();
            newUser.ActiveStatus = true;
            newUser.CreationDate = DateTime.Now;

            CheckUserValidity(newUser);

            userRepo.AddUser(newUser, specializations);
        }

        /// <summary>
        /// Returns a list of users that have a user type which matches the one specified in the parameters.
        /// </summary>
        public List<IUserModel> FindUsersWithUserType(string userType)
        {
            var result = GetAllUsers().Where(i => i.UserType == userType).ToList();
            return result;
        }

        /// <summary>
        /// Deletes a user from the database. /DK
        /// </summary>
        public void Delete(int userId)
        {
            //Check for Pending or Active or Pending Projects.
            bool hasCurrentProjects = _domainServiceManager.ProjectService.GetUserProjects(userId)
                .Where(i => i.ProjectStatus.ToLower() != "ended" && i.ProjectStatus.ToLower() != "deleted").Count() > 0;

            //If they don't then proceed with user deletion.
            if (!hasCurrentProjects)
            {
                userRepo.Delete(userId);
            }
            //Otherwise throw an exception to the presentation layer that says the user cant be deleted
            //because of pending or active projects.
            else
            {
                throw new Exception("Can't delete user. They stil have active or pending projects.");
            }
        }

        /// <summary>
        /// Returns a list of Users that have any of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAnySpecializations(List<string> specializations)
        {
            return userRepo.GetUsersWithAnySpecializations(specializations);
        }

        /// <summary>
        /// Returns a list of Users that have all of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAllSpecializations(List<string> specializations)
        {
            return userRepo.GetUsersWithAllSpecializations(specializations);
        }

        /// <summary>
        /// Updates a user in the database with any changes that might be in the IUserModel provided in the parameter.
        /// The Provided IUserModel must be a valid user from the database. /DK
        /// </summary>
        public void UpdateUser(IUserModel user)
        {
            CheckUserValidity(user);
            userRepo.UpdateUser(user);
        }

        /// <summary>
        /// Delete a Consulent from data base with the specifik UserID /Erik
        /// </summary>
        void IUserService.DeleteConsultantStoredProcedure(int userID)
        {
            userRepo.DeleteConsultantStoredProcedure(userID);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CheckUserValidity(IUserModel user)
        {
            //Checks for user model valid properties before any user creation or user update.
            if (user is null) { throw new Exception("Must provide a non null user model for validation"); }
            if (string.IsNullOrWhiteSpace(user.UserName)) { throw new Exception("You're username can't be empty or blank space."); }
            if (user.UserName.Contains(' ')) { throw new Exception("Username can't contain spaces."); }
            if (string.IsNullOrWhiteSpace(user.Password)) { throw new Exception("Please provide a password."); }
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName)) { throw new Exception("Please provide your first '&' last name."); }

            //Using the inbuilt mail address class to check for a valid email address. 
            try
            {
                var userEmail = new MailAddress(user.EMail);
            }
            catch (Exception)
            {
                throw new Exception("Please provide a valid email address.");
            }

            //Check if phone number contains only numbers
            if (!user.PhoneNumber.All(char.IsAsciiDigit)) { throw new Exception("Please provide only numbers as your phone number."); }
            
            //No further checks for address, country, city or zip-code. Add these later if needed.
        }


    }
}