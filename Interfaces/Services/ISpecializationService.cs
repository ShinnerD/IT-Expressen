namespace Interfaces.Services
{
    /// <summary>
    /// This service interface provides methods for retrieving and manipulating skills/specializations.
    /// </summary>
    public interface ISpecializationService
    {
        /// <returns>List of strings representing the current Specializations/Skills in the Database.</returns>
        public List<string> ListDefinedSpecializations();

        int GetIDFromName(string specialization);

        string GetNameFromID(int specId);

        void AddToProject(int projectId, List<string> specializations);

        void RemoveFromProject(int projectId, List<string> specializations);

    }
}