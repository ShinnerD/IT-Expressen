using Interfaces.Models;

namespace Interfaces.Services
{
    /// <summary>
    /// This service interface provides methods for retrieving and manipulating skills/specializations.
    /// </summary>
    public interface ISpecializationService
    {
        /// <summary>
        /// List of strings representing the current Specializations/Skills in the Database. /Dennis Kempf
        /// </summary>
        public List<string> ListDefinedSpecializations();

        /// <summary>
        /// Returns an int representing the specialization ID matching the specialization in string form provided in the parameters. /Dennis Kempf
        /// </summary>
        int GetId(string specialization);

        /// <summary>
        /// Returns a string representing the specialization which matches the provided ID in the database. /Dennis Kempf
        /// </summary>
        string GetString(int specId);

        /// <summary>
        /// Adds the specializations provided to the project in the database. /Dennis Kempf
        /// </summary>
        void AddToProject(int projectId, List<string> specializations);

        /// <summary>
        /// Removes the specializations provided from the project in the database. /Dennis Kempf
        /// </summary>
        void RemoveFromProject(int projectId, List<string> specializations);

        /// <summary>
        /// Returns a List of strings representing all specializations chosen for a project with the provided id. /Dennis Kempf
        /// </summary>
        List<string> GetProjectSpecializations(int projectId);

        /// <summary>
        /// Returns a list of strings representing the specializations associated with the user specified in the parameters. /Dennis Kempf
        /// </summary>
        List<string> GetUserSpecializations(int userId);

        /// <summary>
        /// Adds the List of string representing specializations to the user with the given User Id to the database. /MS
        /// </summary>
        public void AddSpecializationsToUser(int userId, List<string> specializations);

        /// <summary>
        /// Removes the specializations from the user specified in the method parameters. /Dennis Kempf
        /// </summary>
        public void RemoveSpecializationsFromUser(int userId, List<string> specializations);

        /// <summary>
        /// Fills the IUserModels provided in the method parameters so that their Specializations Property contains
        /// a single string with the Users specializations. The specializations are comma-separated.
        /// </summary>
        public void FillUserSpecializationsProperty(List<IUserModel> users);

        /// <summary>
        /// Updates the user specializations in the database by checking for differences between the specializations provided
        /// and those present in the database. Adds and removes according to the differences.
        /// </summary>
        public void UpdateUserSpecializations(IUserModel user, List<string> specializations);
    }
}