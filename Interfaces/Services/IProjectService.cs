using Interfaces.Models;

namespace Interfaces.Services
{
    /// <summary>
    /// Interface to the service class ProjectService. Provides methods for creating and retrieving project data.
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// Creates a new Project in the Database related to the given user.
        /// </summary>
        void CreateProject(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations);

        List<IProjectModel> GetUserProjects(int userId);

        IProjectModel GetProject(int projectId);
        void UpdateProject(IProjectModel project);
    }
}