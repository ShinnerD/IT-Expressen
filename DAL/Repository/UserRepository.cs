using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ISpecializationRepository specRepo;
        private readonly DataClassesDataContext dbContext;

        public UserRepository(IDataContextManager dataContextManager)
        {
            dbContext = dataContextManager.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContextManager));
            specRepo = new SpecializationRepository(dataContextManager);
        }

        /// <summary>
        /// Gets a list of all users in the users table on the database.
        /// </summary>
        public List<IUserModel> GetAllUsers()
        {
            var AlldtoUsers = dbContext.Users.Where(i => i.Active_Status == true);

            List<IUserModel> result = new List<IUserModel>();

            foreach (var dto in AlldtoUsers)
            {
                var user = new DAL.Models.UserModel();

                user.ID = dto.User_ID;
                user.Address = dto.Street_Address;
                user.UserName = dto.User_name;
                user.Password = dto.Password;
                user.FirstName = dto.First_Name;
                user.LastName = dto.Last_Name;
                user.EMail = dto.Email;
                user.NameCity = dto.City;
                user.ZipCode = dto.Zip_Code;
                user.PhoneNumber = dto.Phone_Number;
                user.Country = dto.Country;
                user.ActiveStatus = (bool?)dto.Active_Status;
                user.CreationDate = (DateTime?)dto.Creation_Date;
                user.UserType = dto.User_Type;

                result.Add(user);
            }
            return result;
        }

        /// <summary>
        /// Gets a list of all users of a certain type from the database.
        /// </summary>
        public List<IUserModel> GetUsersType(string UserType)
        {
            var targetType = dbContext.Users.Where(i => i.User_Type == UserType && i.Active_Status == true).ToList();

            List<IUserModel> result = TransferAllUserProperties(targetType);

            return result;
        }

        /// <summary>
        /// Adds a user to the database. Provide an empty list of specializations if none are chosen.
        /// </summary>
        public void AddUser(IUserModel userModel, List<string> specializations)
        {
            var linqUserModel = new Linq.User();

            linqUserModel.User_name = userModel.UserName;
            linqUserModel.Password = userModel.Password;
            linqUserModel.User_Type = userModel.UserType;
            linqUserModel.First_Name = userModel.FirstName;
            linqUserModel.Last_Name = userModel.LastName;
            linqUserModel.Street_Address = userModel.Address;
            linqUserModel.City = userModel.NameCity;
            linqUserModel.Zip_Code = userModel.ZipCode;
            linqUserModel.Country = userModel.Country;
            linqUserModel.Phone_Number = userModel.PhoneNumber;
            linqUserModel.Email = userModel.EMail;
            linqUserModel.Active_Status = userModel.ActiveStatus;
            linqUserModel.Creation_Date = userModel.CreationDate;

            dbContext.Users.InsertOnSubmit(linqUserModel);
            dbContext.SubmitChanges();

            if (specializations.Count > 0)
            {
                specRepo.AddSpecializationsToUser(linqUserModel.User_ID, specializations);
            }
        }

        /// <summary>
        /// Retrieves a single users details from the database with a matching username.
        /// </summary>
        public IUserModel GetUserFromUsername(string username)
        {
            IUserModel user = new DAL.Models.UserModel();

            var dbUser = dbContext.Users.First(i => i.User_name == username && i.Active_Status == true);

            if (dbUser != null)
            {
                user.ID = dbUser.User_ID;
                user.UserName = dbUser.User_name;
                user.Password = dbUser.Password;
                user.UserType = dbUser.User_Type;
                user.FirstName = dbUser.First_Name;
                user.LastName = dbUser.Last_Name;
                user.EMail = dbUser.Email;
                user.Address = dbUser.Street_Address;
                user.NameCity = dbUser.City;
                user.ZipCode = dbUser.Zip_Code;
                user.PhoneNumber = dbUser.Phone_Number;
                user.Country = dbUser.Country;
                user.ActiveStatus = dbUser.Active_Status;
                user.CreationDate = dbUser.Creation_Date;
            }
            return user;
        }

        /// <summary>
        /// Retrieves a single users details from the database with a matching user Id.
        /// </summary>
        public IUserModel GetUserFromID(int ID)
        {
            IUserModel user = new DAL.Models.UserModel();

            var dbUser = dbContext.Users.First(i => i.User_ID == ID && i.Active_Status == true);

            if (dbUser != null)
            {
                user.ID = dbUser.User_ID;
                user.UserName = dbUser.User_name;
                user.Password = dbUser.Password;
                user.UserType = dbUser.User_Type;
                user.FirstName = dbUser.First_Name;
                user.LastName = dbUser.Last_Name;
                user.EMail = dbUser.Email;
                user.Address = dbUser.Street_Address;
                user.NameCity = dbUser.City;
                user.ZipCode = dbUser.Zip_Code;
                user.PhoneNumber = dbUser.Phone_Number;
                user.Country = dbUser.Country;
                user.ActiveStatus = dbUser.Active_Status;
                user.CreationDate = dbUser.Creation_Date;
            }

            return user;
        }

        /// <summary>
        /// Deletes a user in the database.
        /// </summary>
        public void Delete(int userId)
        {
            var targetUser = dbContext.Users.First(i => i.User_ID==userId);
            targetUser.Active_Status = false;
            dbContext.SubmitChanges();
        }

        /// <summary>
        /// Private repository method for transferring properties from dto-linq-objects to domain models.
        /// </summary>
        private List<IUserModel> TransferAllUserProperties(List<Linq.User> dtoUsers)
        {
            List<IUserModel> result = new List<IUserModel>();

            foreach (var dtoUser in dtoUsers)
            {
                IUserModel userModel = new UserModel();

                userModel.ID = dtoUser.User_ID;
                userModel.UserName = dtoUser.User_name;
                userModel.Password = dtoUser.Password;
                userModel.UserType = dtoUser.User_Type;
                userModel.FirstName = dtoUser.First_Name;
                userModel.LastName = dtoUser.Last_Name;
                userModel.EMail = dtoUser.Email;
                userModel.Address = dtoUser.Street_Address;
                userModel.NameCity = dtoUser.City;
                userModel.ZipCode = dtoUser.Zip_Code;
                userModel.Country = dtoUser.Country;
                userModel.PhoneNumber = dtoUser.Phone_Number;
                userModel.ActiveStatus = dtoUser.Active_Status;
                userModel.CreationDate = dtoUser.Creation_Date;

                result.Add(userModel);
            }
            return result;
        }

        /// <summary>
        /// Updates a user in the database with any changes that might be in the IUserModel provided in the parameter.
        /// The Provided IUserModel must be a valid user from the database. /DK
        /// </summary>
        public void UpdateUser(IUserModel user)
        {
            var dbUser = dbContext.Users.FirstOrDefault(i => i.User_ID == user.ID);

            if (dbUser != null)
            {
                dbUser.First_Name = user.FirstName;
                dbUser.Last_Name = user.LastName;
                dbUser.Email = user.EMail;
                dbUser.Street_Address = user.Address;
                dbUser.City = user.NameCity;
                dbUser.Zip_Code = user.ZipCode;
                dbUser.Country = user.Country;
                dbUser.Phone_Number = user.PhoneNumber;

                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Returns a list of Users that have any of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAnySpecializations(List<string> specializations)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            if (targetSpecIds.Count == 0) return new List<IUserModel>();

            var dtoUsers = dbContext.Users.Where(u => u.User_Type == "consultant" 
                && u.Active_Status == true 
                && u.Specialisations_Lines.Any(x => targetSpecIds.Contains(x.Spec_Id))).ToList();

            return TransferAllUserProperties(dtoUsers);
        }

        /// <summary>
        /// Returns a list of Users that have all of the specializations provided in the list specified in the parameters. /DK
        /// </summary>
        public List<IUserModel> GetUsersWithAllSpecializations(List<string> specializations)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            if (targetSpecIds.Count == 0) return new List<IUserModel>();

            var dtoUsers = dbContext.Users.Where(u => u.User_Type == "consultant" && u.Active_Status == true).ToList();
            dtoUsers = dtoUsers.Where(u => targetSpecIds.All(i => u.Specialisations_Lines.Select(x => x.Spec_Id).Contains(i))).ToList();

            return TransferAllUserProperties(dtoUsers);
        }

        /// <summary>
        /// The StoredProcedure from the Database Called DeleteInvitesAndConsulent that delete a Consulent and alle pending invites.
        /// Written by Erik
        /// </summary>
        /// <param name="userID"></param>
        public void DeleteConsultantStoredProcedure(int userID)
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("TestProcedure", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameter
                    command.Parameters.AddWithValue("@User_ID", userID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Stored procedure executed successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}