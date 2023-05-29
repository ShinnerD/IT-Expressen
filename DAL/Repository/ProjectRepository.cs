using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;
using System.Text;

namespace DAL.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ISpecializationRepository specRepo;
        private readonly DataClassesDataContext dbContext;

        public ProjectRepository(IDataContextManager dataContextManager)
        {
            dbContext = dataContextManager.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContextManager));
            specRepo = new SpecializationRepository(dataContextManager);
        }

        /// <summary>
        /// Adds a project with all the details required in the parameter of the method to the database. /Dennis Kempf
        /// </summary>
        public void CreateProject(IProjectModel newProject, List<string> specializations)
        {
            var dtoProject = new Linq.Project();

            dtoProject.User_ID = newProject.UserId;
            dtoProject.Title = newProject.Title;
            dtoProject.Description = newProject.Description;
            dtoProject.Project_Start_Date = newProject.ProjectStartDate;
            dtoProject.Project_End_Date = newProject.ProjectEndDate;
            dtoProject.Project_Modify_Date = newProject.ProjectModifyDate;
            dtoProject.Project_Status = newProject.ProjectStatus;

            dbContext.Projects.InsertOnSubmit(dtoProject);
            dbContext.SubmitChanges();

            specRepo.AddToProject(dtoProject.Project_ID, specializations);
        }

        /// <summary>
        /// Updates an existing project in the database to match the IProjectModel provided in the parameters. /Dennis Kempf
        /// </summary>
        public void UpdateProject(IProjectModel project)
        {
            var dbProject = dbContext.Projects.First(i => i.Project_ID == project.ProjectId);

            if (dbProject != null && project != null)
            {
                dbProject.Title = project.Title;
                dbProject.Description = project.Description;
                dbProject.Project_Start_Date = project.ProjectStartDate;
                dbProject.Project_End_Date = project.ProjectEndDate;
                dbProject.Project_Modify_Date = project.ProjectModifyDate;

                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// 'Deletes' a project from the database by setting its Status Column to "deleted" in the database. /Jonas
        /// </summary>
        public void DeleteProject(int projectId)
        {
            var project = dbContext.Projects.First(i => i.Project_ID == projectId);
            if (project != null)
            {
                project.Project_Status = "deleted";
                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Returns an IProjectModel for the project matching the provided Project Id. /Dennis Kempf
        /// </summary>
        public IProjectModel GetProject(int projectId)
        {
            var targetProject = dbContext.Projects.Where(i => i.Project_ID == projectId);

            var resultList = TransferAllProjectProperties(targetProject);

            if (resultList.Count <= 0)
            {
                return null;
            }

            return resultList[0];
        }

        /// <summary>
        /// Returns a List of IProjectModels with projects related to the User Id provided. /Dennis Kempf
        /// </summary>
        public List<IProjectModel> GetUserProjects(int userId)
        {
            var targetProjects = dbContext.Projects.Where(i => i.User_ID == userId);

            List<IProjectModel> result = TransferAllProjectProperties(targetProjects);

            return result;
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. /Dennis Kempf
        /// </summary>
        public List<IProjectModel> GetProjectsFromAllSpecializations(List<string> specializations, bool includeEndedProjects = false)
        {
            IQueryable<Project>? dtoProjects;

            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            if (!includeEndedProjects)
            {
                dtoProjects = dbContext.Projects.Where(i => i.Project_Status != "ended" &&
                    targetSpecIds.All(v => i.Projects_Specialisation_Lines.Select(x => x.Spec_Id).Contains(v)));
            }
            else
            {
                dtoProjects = dbContext.Projects.Where(i => targetSpecIds.All(v => i.Projects_Specialisation_Lines.Select(x => x.Spec_Id).Contains(v)));
            }

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. /Dennis Kempf
        /// </summary>
        public List<IProjectModel> GetProjectsFromAnySpecializations(List<string> specializations, bool includeEndedProjects = false)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            IQueryable<Project>? dtoProjects;

            if (!targetSpecIds.Any()) return new List<IProjectModel>();

            //If told not to include ended projects only the projects with status not fitting "ended" is included. (false by default).
            if (!includeEndedProjects)
            {
                dtoProjects = dbContext.Projects.Where(i => i.Projects_Specialisation_Lines.Count == 0 && i.Project_Status.ToLower() != "ended"
                    || i.Project_Status.ToLower() != "ended" && i.Projects_Specialisation_Lines.Any(x => targetSpecIds.Contains(x.Spec_Id)));
            }

            //Otherwise we include ended projects.
            else
            {
                dtoProjects = dbContext.Projects.Where(i => i.Projects_Specialisation_Lines.Count == 0
                    || i.Projects_Specialisation_Lines.Any(x => targetSpecIds.Contains(x.Spec_Id)));
            }

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }

        /// <summary>
        /// Private repository class method. Transfers the properties of database dto objects to ProjectModels. /Dennis Kempf
        /// </summary>
        private List<IProjectModel> TransferAllProjectProperties(IQueryable<Linq.Project>? dtoProjects)
        {
            List<IProjectModel> result = new List<IProjectModel>();

            if (dtoProjects is null) { return result; }

            var projectIds = dtoProjects
                .Where(p => p.Project_Status.ToLower() != "deleted")
                .Select(p => p.Project_ID).ToList();

            var specializations = dbContext.Projects_Specialisation_Lines.Where(i => projectIds.Contains(i.Project_ID)).ToList();
            var invoices = dbContext.Invoices.Where(i => projectIds.Contains(i.Project_ID.GetValueOrDefault())).ToList();

            foreach (var dtoProject in dtoProjects)
            {
                if (dtoProject.Project_Status.ToLower() != "deleted")
                {
                    IProjectModel projectModel = new ProjectModel();

                    projectModel.ProjectId = dtoProject.Project_ID;
                    projectModel.UserId = dtoProject.User_ID;
                    projectModel.Title = dtoProject.Title;
                    projectModel.Description = dtoProject.Description;
                    projectModel.ProjectStartDate = dtoProject.Project_Start_Date;
                    projectModel.ProjectEndDate = dtoProject.Project_End_Date;
                    projectModel.ProjectModifyDate = dtoProject.Project_Modify_Date;
                    projectModel.TotalInvoicePrice = invoices.FirstOrDefault(i => i.Project_ID == dtoProject.Project_ID)?.Total_Price;
                    projectModel.ProjectStatus = dtoProject.Project_Status;

                    var projectSpecializations = specializations.Where(i => i.Project_ID == dtoProject.Project_ID).ToList();

                    var manager = dtoProject.User;

                    if (manager != null)
                    {
                        projectModel.ManagerFullName = new StringBuilder(manager.First_Name).Append(' ').Append(manager.Last_Name).ToString();
                        projectModel.ManagerUserName = manager.User_name;
                    }
                    if (projectSpecializations.Any())
                    {
                        projectModel.SpecializationsString = new StringBuilder().AppendJoin(", ", projectSpecializations.Select(i => i.Specialisation.Specialisation1)).ToString();
                    }

                    result.Add(projectModel);
                }
            }
            return result;
        }

        /// <summary>
        /// 'Deletes' a project from the database by setting its Status Column to "deleted" in the database. /Jonas
        /// </summary>
        public void Delete(int id)
        {
            var project = dbContext.Projects.First(i => i.Project_ID == id);

            project.Project_Status = "deleted";
            dbContext.SubmitChanges();
        }

        /// <summary>
        /// (JQ)This method searches for projects based on a search term and a user ID.
        /// </summary>
        /// <param name="searchTerm">The search term to use when looking for projects.</param>
        /// <param name="userId">The ID of the user to which the projects belong.</param>
        /// <returns>A list of project models that match the search term and belong to the specified user.<</returns>
        public List<IProjectModel> SearchProjects(string searchTerm, int userId)
        {
            var targetUser = dbContext.Users.FirstOrDefault(i => i.User_ID == userId);

            if (targetUser != null)
            {
                var dtoProjects = dbContext.Projects.Where(i => i.User_ID == userId
                    && i.Title.ToLower().Contains(searchTerm.ToLower()));

                List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

                return result;
            }
            return new List<IProjectModel>();
        }

        /// <summary>
        /// Updates the Project Status for ALL projects in the Projects table.
        /// Stored Procedure to be executed on program launch. /Dennis Kempf
        /// </summary>
        public void UpdateProjectStatusForAll()
        {
            try
            {
                dbContext.UpdateProjectStatusForAll();
            }
            catch (Exception)
            {
                throw new Exception("Server failed to update project status'.");
            }
        }

        public List<IProjectModel> GetProjectsFromIdList(List<int> targetProjectIds)
        {
            return TransferAllProjectProperties(dbContext.Projects.Where(i => targetProjectIds.Contains(i.Project_ID)));
        }
    }
}