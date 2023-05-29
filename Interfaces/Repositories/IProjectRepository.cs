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
        /// Adds a project with all the details required in the parameter of the method to the database. /Dennis Kempf
        /// </summary>
        void CreateProject(IProjectModel newProject, List<string> specializations);

        /// <summary>
        /// Updates an existing project in the database to match the IProjectModel provided in the parameters. /Dennis Kempf
        /// </summary>
        void UpdateProject(IProjectModel project);

        /// <summary>
        /// Deletes the project specified by setting its status to 'deleted' in the database. Recoverable. /Dennis Kempf
        /// </summary>
        void DeleteProject(int projectId);

        /// <summary>
        /// Returns an IProjectModel for the project matching the provided Project Id. /Dennis Kempf
        /// </summary>
        IProjectModel GetProject(int projectId);

        /// <summary>
        /// Returns a List of IProjectModels with projects related to the User Id provided. /Dennis Kempf
        /// </summary>
        List<IProjectModel> GetUserProjects(int userId);

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. /Dennis Kempf
        /// </summary>
        List<IProjectModel> GetProjectsFromAllSpecializations(List<string> specializations, bool includeEndedProjects = false);

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. /Dennis Kempf
        /// </summary>
        List<IProjectModel> GetProjectsFromAnySpecializations(List<string> specializations, bool includeEndedProjects = false);

        /// <summary>
        /// (JQ)This method searches for projects based on a search term and a user ID.
        /// </summary>
        List<IProjectModel> SearchProjects(string searchTerm, int userId);

        /// <summary>
        /// Runs a stored procedure on the database. Updates the Project Status column for all rows on the Projects table
        /// according to the project's start and end date by using the current date.
        /// </summary>
        void UpdateProjectStatusForAll();

        /// <summary>
        /// Retrieves a list of projects from the database with Project IDs matching the integers from the provided list.
        /// </summary>
        List<IProjectModel> GetProjectsFromIdList(List<int> targetProjectIds);
    }
}