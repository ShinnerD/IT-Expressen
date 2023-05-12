using DAL.Linq;
using DAL.Models;
using DAL.Repository;
using Domain.Models;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Service class that deals with project related data. Can retrieve, store and update projects.
    /// </summary>
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepo = new DAL.Repository.ProjectRepository();

        /// <summary>
        /// Creates a new Project in the Database related to the given user. /DK
        /// </summary>
        public void CreateProject(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations)
        {
            projectRepo.CreateProject(userName, title, description, startDate, endDate, specializations);
        }

        /// <summary>
        /// Returns an List of IProjectModels related to the Manager specified in the method parameters. /DK
        /// </summary>
        public List<IProjectModel> GetUserProjects(int userId)
        {
            return projectRepo.GetUserProjects(userId);
        }

        /// <summary>
        /// Returns an IProjectModel for the Project specified in the method parameters. /DK
        /// </summary>
        public IProjectModel GetProject(int projectId)
        {
            return projectRepo.GetProject(projectId);
        }

        /// <summary>
        /// Updates the Project in the database. The provided IProjectModel must be an existing project in the database. /DK
        /// </summary>
        void IProjectService.UpdateProject(IProjectModel project)
        {
            projectRepo.UpdateProject(project);
        }

        /// <summary>
        /// Deletes the project specified by setting its status to 'deleted' in the database. Recoverable. /DK
        /// </summary>
        void IProjectService.DeleteProject(int projectId)
        {
            projectRepo.DeleteProject(projectId);
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. /DK
        /// </summary>
        List<IProjectModel> IProjectService.GetProjectsFromAllSpecializations(List<string> specializations)
        {
            return projectRepo.GetProjectsFromAllSpecializations(specializations);
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. /DK
        /// </summary>
        List<IProjectModel> IProjectService.GetProjectsFromAnySpecializations(List<string> specializations)
        {
            return projectRepo.GetProjectsFromAnySpecializations(specializations);
        }

        public List<IProjectModel> SearchProjects(string searchTerm, int userId)
        {
            return projectRepo.SearchProjects(searchTerm, userId);
        }

        
    }
}