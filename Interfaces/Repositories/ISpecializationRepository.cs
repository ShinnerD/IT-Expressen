namespace Interfaces.Repositories
{
    /// <summary>
    /// Interface for accessing methods from the SpecializationRepository class.
    /// Contains methods for retrieving specialization-specific data or adding specializations to a project in the database. /DK
    /// </summary>
    public interface ISpecializationRepository
    {
        /// <summary>A list of string representing specializations defined in the database. /DK</summary>
        List<string> GetCurrentSpecializationsList();

        /// <summary>An int representing the generated identifier ID for a specialization in the database. /DK</summary>
        int GetSpecializationID(string specialization);

        /// <summary>A String representing the specialization with the provided spec Id /DK</summary>
        string GetSpecializationString(int specId);

        /// <summary>Adds the given list of string specializations to the project in the database. /DK</summary>
        void AddToProject(int projectId, List<string> specializations);

        /// <summary>Removes the given list of string specializations from the project in the database. /DK</summary>
        void RemoveFromProject(int projectId, List<string> specializations);

        List<string> GetProjectSpecializations(int projectId);
    }
}