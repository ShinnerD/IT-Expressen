using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Service class that has methods for retrieving and manipulating skills/specializations. /DK
    /// </summary>
    public class SpecializationService : ISpecializationService
    {
        private readonly ISpecializationRepository Repository = new DAL.Repository.SpecializationRepository();

        /// <summary>
        /// List of strings representing the current Specializations/Skills in the Database. /DK
        /// </summary>
        public List<string> ListDefinedSpecializations()
        {                            
            return Repository.GetCurrentSpecializationsList();
        }

        /// <summary>
        /// Returns a List of strings representing all specializations chosen for a project with the provided id. /DK
        /// </summary>
        public List<string> GetProjectSpecializations(int projectId)
        {
            return Repository.GetProjectSpecializations(projectId);
        }

        /// <summary>
        /// Returns an int representing the specialization ID matching the specialization in string form provided in the parameters. /DK
        /// </summary>
        public int GetId(string specialization)
        {
            return Repository.GetSpecializationID(specialization);
        }

        /// <summary>
        /// Returns a string representing the specialization which matches the provided ID in the database. /DK
        /// </summary>
        public string GetString(int specId)
        {
            return Repository.GetSpecializationString(specId);
        }

        /// <summary>
        /// Adds the specializations provided to the project in the database. /DK
        /// </summary>
        public void AddToProject(int projectId, List<string> specializations)
        {
            Repository.AddToProject(projectId, specializations);
        }

        /// <summary>
        /// Removes the specializations provided from the project in the database. /DK
        /// </summary>
        public void RemoveFromProject(int projectId, List<string> specializations) 
        {
            Repository.RemoveFromProject(projectId, specializations);
        }

        /// <summary>
        /// Adds the List of string representing specializations to the user with the given User Id to the database. /MS
        /// </summary>
        public void AddSpecializationsToUser(int userId, List<string> specializations)
        {
            Repository.AddSpecializationsToUser(userId, specializations);
        }

        /// <summary>
        /// Removes the given list of string specializations to the user. /DK
        /// </summary>
        public void RemoveSpecializationsFromUser(int userId, string specializations)
        {
            Repository.RemoveSpecializationsFromUser(userId, specializations);
        }

        /// <summary>
        /// Returns a list of strings representing the specializations associated with the user specified in the parameters. /DK
        /// </summary>
        public List<string> GetUserSpecializations(int userId)
        {
            return Repository.GetUserSpecializations(userId).OrderBy(i => i).ToList();
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