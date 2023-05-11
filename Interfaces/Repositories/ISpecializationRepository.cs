namespace Interfaces.Repositories
{
    /// <summary>
    /// Interface for accessing methods from the SpecializationRepository class.
    /// Contains methods for retrieving specialization-specific data or adding specializations to a project in the database.
    /// </summary>
    public interface ISpecializationRepository
    {
        /// <returns>A list of string representing specializations defined in the database.</returns>
        List<string> GetCurrentSpecializationsList();

        /// <returns>An int representing the generated identifier ID for a specialization in the database.</returns>
        int GetSpecializationID(string specialization);

        void AddSpecializationsToProject(int projectId, List<string> specializations);
        void AddSpecializationsToUser(int UserID, List<string> specializations);
    }
}