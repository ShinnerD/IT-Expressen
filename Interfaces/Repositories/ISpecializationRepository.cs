namespace Interfaces.Repositories
{
    /// <summary>
    /// Interface for accessing methods from the SpecializationRepository class.
    /// Contains methods for retrieving specialization-specific data or adding specializations to a project in the database. /DK
    /// </summary>
    public interface ISpecializationRepository
    {
        /// <summary>
        /// A list of string representing specializations defined in the database. /DK
        /// </summary>
        List<string> GetCurrentSpecializationsList();

        /// <summary>
        /// An int representing the generated identifier ID for a specialization in the database. /DK
        /// </summary>
        int GetSpecializationID(string specialization);

        /// <summary>
        /// A String representing the specialization with the provided spec Id /DK
        /// </summary>
        string GetSpecializationString(int specId);

        /// <summary>
        /// Adds the given list of string specializations to the project in the database. /DK
        /// </summary>
        void AddToProject(int projectId, List<string> specializations);

        /// <summary>
        /// Removes the given list of string specializations from the project in the database. /DK
        /// </summary>
        void RemoveFromProject(int projectId, List<string> specializations);

        /// <summary>
        /// Returns a List of strings representing all the chosen specializations for a project. /DK
        /// </summary>
        List<string> GetProjectSpecializations(int projectId);

        /// <summary>
        /// Adds the given list of string specializations to the user specified in the parameters. /MS
        /// </summary>
        void AddSpecializationsToUser(int UserID, List<string> specializations);

        /// <summary>
        /// Removes the given list of string specializations to the user. /DK
        /// </summary>
        void RemoveSpecializationsFromUser(int userId, string specializations);

        /// <summary>
        /// Returns a list of strings representing the specializations associated with the user specified in the parameters. /DK
        /// </summary>
        List<string> GetUserSpecializations(int userId);
    }
}