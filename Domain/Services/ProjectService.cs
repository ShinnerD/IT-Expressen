using DAL.Models;
using DAL.Repository;
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
        private readonly IProjectRepository _projectRepo;
        private readonly IDataContextManager _dataContextManager;
        private readonly IDomainServiceManager _domainServiceManager;

        public ProjectService(IDomainServiceManager serviceManager, IDataContextManager dataContextManager)
        {
            _dataContextManager = dataContextManager;
            _domainServiceManager = serviceManager;
            _projectRepo = new ProjectRepository(_dataContextManager);
        }

        /// <summary>
        /// Creates a new Project in the Database related to the given user. /DK
        /// </summary>
        public void CreateProject(int userId, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations)
        {
            IProjectModel newProject = new ProjectModel();

            newProject.UserId = userId;
            newProject.Title = title;
            newProject.Description = description;
            newProject.ProjectStartDate = startDate;
            newProject.ProjectEndDate = endDate;
            newProject.ProjectModifyDate = DateTime.Now;
            newProject.TotalInvoicePrice = 0;
            SetProjectStatus(newProject);

            //Various Error Checks
            CheckValuesForProject(newProject);
            //Error Check specific to new Projects.
            if (newProject.ProjectEndDate < DateTime.Now)
            {
                throw new ArgumentException("Project end date cannot be before the current date.");
            }

            _projectRepo.CreateProject(newProject, specializations);
        }

        /// <summary>
        /// Private Service Method. Checks that attributes of the new project comply with business rules, or throws exception.
        /// </summary>
        private void CheckValuesForProject(IProjectModel newProject)
        {
            if (string.IsNullOrWhiteSpace(newProject.Title))
            {
                throw new ArgumentException("Project title can't be empty.");
            }
            if (string.IsNullOrWhiteSpace(newProject.Description))
            {
                throw new ArgumentException("Project description can't be empty.");
            }
            if (newProject.ProjectStartDate == default(DateTime) || newProject.ProjectEndDate == default(DateTime))
            {
                throw new ArgumentException("Project must have a start and end date.");
            }
            if (newProject.ProjectStartDate > newProject.ProjectEndDate)
            {
                throw new ArgumentException("Project start date cannot be after end date.");
            }
            if (_projectRepo.SearchProjects(newProject.Title, newProject.UserId).Count > 0) 
            {
                throw new ArgumentException("There's already a project with that name for this user."); 
            }
        }

        /// <summary>
        /// Private Service Method that Sets the Project status according to DateTime Logic.
        /// </summary>
        private void SetProjectStatus(IProjectModel project)
        {
            if (project.ProjectStartDate > DateTime.Now)
            {
                project.ProjectStatus = "Pending";
            }
            else
            {
                project.ProjectStatus = "Active";
            }
        }

        /// <summary>
        /// Returns an List of IProjectModels related to the Manager specified in the method parameters. Ordered by Title. /DK
        /// </summary>
        public List<IProjectModel> GetUserProjects(int userId)
        {
            return AssignDomainDetails(_projectRepo.GetUserProjects(userId)).OrderBy(i => i.Title).ToList();
        }

        /// <summary>
        /// Returns an IProjectModel for the Project specified in the method parameters. /DK
        /// </summary>
        public IProjectModel GetProject(int projectId)
        {
            var result = _projectRepo.GetProject(projectId);
            AssignDomainDetails(result);
            return result;
        }

        /// <summary>
        /// Updates the Project in the database. The provided IProjectModel must be an existing project in the database. /DK
        /// </summary>
        void IProjectService.UpdateProject(IProjectModel project)
        {
            CheckValuesForProject(project);
            _projectRepo.UpdateProject(project);
        }

        /// <summary>
        /// Deletes the project specified by setting its status to 'deleted' in the database. Recoverable. /DK
        /// </summary>
        void IProjectService.DeleteProject(int projectId)
        {
            _projectRepo.DeleteProject(projectId);
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. Ordered by Title. /DK
        /// </summary>
        List<IProjectModel> IProjectService.GetProjectsFromAllSpecializations(List<string> specializations)
        {
            return AssignDomainDetails(_projectRepo.GetProjectsFromAllSpecializations(specializations).OrderBy(i => i.Title).ToList());
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. Ordered by Title. /DK
        /// </summary>
        List<IProjectModel> IProjectService.GetProjectsFromAnySpecializations(List<string> specializations)
        {
            return AssignDomainDetails(_projectRepo.GetProjectsFromAnySpecializations(specializations).OrderBy(i => i.Title).ToList());
        }

        /// <summary>
        /// Searches Projects based on a search term. /JQ
        /// </summary>
        public List<IProjectModel> SearchProjects(string searchTerm, int userId)
        {
            return AssignDomainDetails(_projectRepo.SearchProjects(searchTerm, userId).OrderBy(i => i.Title).ToList());
        }

        /// <summary>
        /// Private service method. Assigns manager details to the IProjectModels. (Full Name and User Name) /DK
        /// </summary>
        private List<IProjectModel> AssignDomainDetails(List<IProjectModel> projectList)
        {
            foreach (var project in projectList)
            {
                AssignDomainDetails(project);
            }
            return projectList;
        }

        /// <summary>
        /// Private void service method. Assigns manager details to the IProjectModel. (Full Name and User Name) /DK
        /// </summary>
        private void AssignDomainDetails(IProjectModel project)
        {
            var manager = _domainServiceManager.UserService.GetUserFromID(project.UserId);
            project.ManagerFullName = manager.FullName;
            project.ManagerUserName = manager.UserName;
        }
    }
}