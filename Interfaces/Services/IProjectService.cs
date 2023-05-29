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
        void CreateProject(int userId, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations);

        /// <summary>
        /// Updates the Project in the database. The provided IProjectModel must be an existing project in the database. /DK
        /// </summary>
        void UpdateProject(IProjectModel project, List<string> specializations);

        /// <summary>
        /// Deletes the project specified by setting its status to 'deleted' in the database. Recoverable. /DK
        /// </summary>
        void DeleteProject(int projectId);

        /// <summary>
        /// Returns an IProjectModel for the Project specified in the method parameters. /DK
        /// </summary>
        IProjectModel GetProject(int projectId);

        /// <summary>
        /// Returns an List of IProjectModels related to the Manager specified in the method parameters. /DK
        /// </summary>
        List<IProjectModel> GetUserProjects(int userId);

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. /DK
        /// </summary>
        List<IProjectModel> GetProjectsFromAllSpecializations(List<string> specializations, bool includeEndedProjects = false);

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. /DK
        /// </summary>
        List<IProjectModel> GetProjectsFromAnySpecializations(List<string> specializations, bool includeEndedProjects = false);

        /// <summary>
        /// Updates the Project Status for ALL projects in the Projects table.
        /// Stored Procedure to be executed on program launch. /DK
        /// </summary>
        void UpdateAllProjectStatus();

        /// <summary>
        /// This method searches for projects based on a search term and a user ID. /JQ
        /// </summary>
        List<IProjectModel> SearchProjects(string searchTerm, int userId);

        /// <summary>
        /// Retrieves a list of projects connected to the consultant specified in the parameters.
        /// These are projects the consultant has accepted invites to.
        /// </summary>
        List<IProjectModel> GetConsultantProjects(IUserModel consultant);
    }
}