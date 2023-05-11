namespace Interfaces.Repositories
{
    /// <summary>
    /// Interface for accessing methods on the ProjectRepository Class.
    /// Contains methods for retrieving and adding projects to the database.
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Adds a project with all the details required in the parameter of the method to the database.
        /// </summary>
        void Add(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations);
    }
}