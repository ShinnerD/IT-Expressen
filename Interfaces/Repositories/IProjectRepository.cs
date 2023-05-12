using Interfaces.Models;

namespace Interfaces.Repositories
{
    /// <summary>
    /// Interface for accessing methods on the ProjectRepository Class.
    /// Contains methods for retrieving and adding projects to the database.
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Adds a project with all the details required in the parameter of the method to the database. /DK
        /// </summary>
        void Add(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations);

        /// <summary>
        /// Returns a List of IProjectModels with projects related to the User Id provided. /DK
        /// </summary>
        List<IProjectModel> GetUserProjects(int userId);

        /// <summary>
        /// Returns an IProjectModel for the project matching the provided Project Id. /DK
        /// </summary>
        IProjectModel GetProject(int projectId);

        /// <summary>
        /// Updates an existing project in the database to match the IProjectModel provided in the parameters. /DK
        /// </summary>
        void UpdateProject(IProjectModel project);

        List<IProjectModel> SearchProjects(string searchTerm, int userId);

        
        
    }
}