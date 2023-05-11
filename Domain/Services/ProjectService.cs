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
        private IProjectRepository projectRepo = new DAL.Repository.ProjectRepository();

        /// <summary>
        /// Creates a new Project in the Database related to the given user.
        /// </summary>
        public void CreateProject(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations)
        {
            projectRepo.Add(userName, title, description, startDate, endDate, specializations);
        }

        public List<IProjectModel> GetUserProjects(int userId)
        {
            return projectRepo.GetUserProjects(userId);
        }

        public IProjectModel GetProject(int projectId)
        {
            return projectRepo.GetProject(projectId);
        }
    }
}