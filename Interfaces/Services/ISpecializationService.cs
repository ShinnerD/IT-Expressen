namespace Interfaces.Services
{
    /// <summary>
    /// This service interface provides methods for retrieving and manipulating skills/specializations.
    /// </summary>
    public interface ISpecializationService
    {

        /// <summary>
        /// List of strings representing the current Specializations/Skills in the Database. /DK
        /// </summary>
        public List<string> ListDefinedSpecializations();

        /// <summary>
        /// Returns an int representing the specialization ID matching the specialization in string form provided in the parameters. /DK
        /// </summary>
        int GetIDFromName(string specialization);

        /// <summary>
        /// Returns a string representing the specialization which matches the provided ID in the database. /DK
        /// </summary>
        string GetNameFromID(int specId);

        /// <summary>
        /// Adds the specializations provided to the project in the database. /DK
        /// </summary>
        void AddToProject(int projectId, List<string> specializations);

        /// <summary>
        /// Removes the specializations provided from the project in the database. /DK
        /// </summary>
        void RemoveFromProject(int projectId, List<string> specializations);

        /// <summary>
        /// Returns a List of strings representing all specializations chosen for a project with the provided id. /DK
        /// </summary>
        List<string> GetProjectSpecializations(int projectId);
    }
}