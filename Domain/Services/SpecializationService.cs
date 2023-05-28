using DAL.Linq;
using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Service class that has methods for retrieving and manipulating skills/specializations. /Dennis Kempf
    /// </summary>
    public class SpecializationService : ISpecializationService
    {
        private readonly ISpecializationRepository specRepo;
        private readonly IDomainServiceManager serviceManager;

        public SpecializationService(IDomainServiceManager domainServiceManager, IDataContextManager dataContextManager)
        {
            serviceManager = domainServiceManager;
            specRepo = new SpecializationRepository(dataContextManager);
        }

        /// <summary>
        /// List of strings representing the current Specializations/Skills in the Database. /Dennis Kempf
        /// </summary>
        public List<string> ListDefinedSpecializations()
        {
            return specRepo.GetCurrentSpecializationsList().OrderBy(i => i).ToList();
        }

        /// <summary>
        /// Returns a List of strings representing all specializations chosen for a project with the provided id. /Dennis Kempf
        /// </summary>
        public List<string> GetProjectSpecializations(int projectId)
        {
            return specRepo.GetProjectSpecializations(projectId).OrderBy(i => i).ToList();
        }

        /// <summary>
        /// Returns an int representing the specialization ID matching the specialization in string form provided in the parameters. /Dennis Kempf
        /// </summary>
        public int GetId(string specialization)
        {
            return specRepo.GetSpecializationID(specialization);
        }

        /// <summary>
        /// Returns a string representing the specialization which matches the provided ID in the database. /Dennis Kempf
        /// </summary>
        public string GetString(int specId)
        {
            return specRepo.GetSpecializationString(specId);
        }

        /// <summary>
        /// Adds the specializations provided to the project in the database. /Dennis Kempf
        /// </summary>
        public void AddToProject(int projectId, List<string> specializations)
        {
            specRepo.AddToProject(projectId, specializations);
        }

        /// <summary>
        /// Removes the specializations provided from the project in the database. /Dennis Kempf
        /// </summary>
        public void RemoveFromProject(int projectId, List<string> specializations)
        {
            specRepo.RemoveFromProject(projectId, specializations);
        }


        /// <summary>
        /// Updates the user specializations in the database by checking for differences between the specializations provided
        /// and those present in the database. Adds and removes according to the differences.
        /// </summary>
        public void UpdateUserSpecializations(IUserModel user, List<string> specializations)
        {
            if (user.UserType.ToLower() != "consultant") { throw new Exception("User is not a consultant and has no specializations."); }

            var currentUserSpecializations = serviceManager.SpecializationService.GetUserSpecializations(user.ID) 
                ?? throw new Exception("Can't locate specified user."); 

            List<string> specsToBeRemoved = currentUserSpecializations.Where(i => !specializations.Contains(i)).ToList();
            List<string> specsToBeAdded = specializations.Where(i => !currentUserSpecializations.Contains(i)).ToList();

            try
            {
                serviceManager.SpecializationService.RemoveSpecializationsFromUser(user.ID, specsToBeRemoved);
                serviceManager.SpecializationService.AddSpecializationsToUser(user.ID, specsToBeAdded);
            }
            catch (Exception)
            {
                throw new Exception("Failed to update user specializations.");
            }
        }


        /// <summary>
        /// Adds the List of string representing specializations to the user with the given User Id to the database. /MS
        /// </summary>
        public void AddSpecializationsToUser(int userId, List<string> specializations)
        {
            specRepo.AddSpecializationsToUser(userId, specializations);
        }

        /// <summary>
        /// Removes the given list of string specializations to the user. /Dennis Kempf
        /// </summary>
        public void RemoveSpecializationsFromUser(int userId, List<string> specializations)
        {
            specRepo.RemoveSpecializationsFromUser(userId, specializations);
        }

        /// <summary>
        /// Returns a list of strings representing the specializations associated with the user specified in the parameters. /Dennis Kempf
        /// </summary>
        public List<string> GetUserSpecializations(int userId)
        {
            return specRepo.GetUserSpecializations(userId).OrderBy(i => i).ToList();
        }

        /// <summary>
        /// Fills the IUserModels provided in the method parameters so that their Specializations Property contains
        /// a single string with the Users specializations. The specializations are comma-separated.
        /// </summary>
        public void FillUserSpecializationsProperty(List<IUserModel> users)
        {
            foreach (IUserModel user in users)
            {
                user.Specializations = string.Join(", ", GetUserSpecializations(user.ID));
            }
        }
    }
}