using Interfaces.Models;

namespace Interfaces.Services
{
    /// <summary>
    /// Interface to the service class ProjectService. Provides methods for creating and retrieving project data.
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// Creates a new Project in the Database related to the given user. /DK
        /// </summary>
        void CreateProject(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations);

        /// <summary>
        /// Returns an List of IProjectModels related to the Manager specified in the method parameters. /DK
        /// </summary>
        List<IProjectModel> GetUserProjects(int userId);

        /// <summary>
        /// Returns an IProjectModel for the Project specified in the method parameters. /DK
        /// </summary>
        IProjectModel GetProject(int projectId);

        /// <summary>
        /// Updates the Project in the database. The provided IProjectModel must be an existing project in the database. /DK
        /// </summary>
        void UpdateProject(IProjectModel project);
    }
}