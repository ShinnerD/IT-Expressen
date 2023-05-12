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
            projectRepo.Add(userName, title, description, startDate, endDate, specializations);
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
        public List<IProjectModel> SearchProjects(string searchTerm, int userId)
        {
            return projectRepo.SearchProjects(searchTerm, userId);
        }

        
    }
}