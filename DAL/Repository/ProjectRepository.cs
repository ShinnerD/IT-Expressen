using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Linq.DataClassesDataContext dbContext = new Linq.DataClassesDataContext(Linq.DbConnectionString.ConnectionString);

        public ProjectRepository()
        { }

        /// <summary>
        /// Adds a project with all the details required in the parameter of the method to the database. /DK
        /// </summary>
        public void CreateProject(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations)
        {
            ISpecializationRepository specRepo = new SpecializationRepository();

            var newProject = new Linq.Project();
            var user = dbContext.Users.FirstOrDefault(i => i.User_name == userName);

            newProject.User = user;
            newProject.User_ID = user.User_ID;
            newProject.Title = title;
            newProject.Description = description;
            newProject.Project_Start_Date = startDate;
            newProject.Project_End_Date = endDate;
            newProject.Project_Status = "active";

            dbContext.Projects.InsertOnSubmit(newProject);
            dbContext.SubmitChanges();

            specRepo.AddToProject(newProject.Project_ID, specializations);
        }

        /// <summary>
        /// Updates an existing project in the database to match the IProjectModel provided in the parameters. /DK
        /// </summary>
        public void UpdateProject(IProjectModel project)
        {
            var dbProject = dbContext.Projects.FirstOrDefault(i => i.Project_ID == project.ProjectId);

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
            var project = dbContext.Projects.FirstOrDefault(i => i.Project_ID == projectId);
            if (project != null)
            {
                project.Project_Status = "deleted";
                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Returns an IProjectModel for the project matching the provided Project Id. /DK
        /// </summary>
        public IProjectModel GetProject(int projectId)
        {
            var targetProject = dbContext.Projects.FirstOrDefault(i => i.Project_ID == projectId);
            if (targetProject == null) { return null; }
            List<Linq.Project> dtoResult = new List<Linq.Project>();
            dtoResult.Add(targetProject);
            return TransferAllProjectProperties(dtoResult)[0];
        }

        /// <summary>
        /// Returns a List of IProjectModels with projects related to the User Id provided. /DK
        /// </summary>
        public List<IProjectModel> GetUserProjects(int userId)
        {
            var targetUser = dbContext.Users.FirstOrDefault(i => i.User_ID == userId);

            List<IProjectModel> result = TransferAllProjectProperties(targetUser.Projects.ToList());

            return result;
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project require ALL of the provided specializations. /DK
        /// </summary>
        public List<IProjectModel> GetProjectsFromAllSpecializations(List<string> specializations)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            var dtoProjects = dbContext.Projects.Where(i => targetSpecIds.All(v => i.Projects_Specialisation_Lines.Select(x => x.Spec_Id).Contains(v))).ToList();

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }

        /// <summary>
        /// Retrieves a List of IProjectModels in which each project requires at least one of the specializations specified. /DK
        /// </summary>
        public List<IProjectModel> GetProjectsFromAnySpecializations(List<string> specializations)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            if (targetSpecIds.Count == 0) return new List<IProjectModel>();

            var dtoProjects = dbContext.Projects.Where(i => i.Projects_Specialisation_Lines.Count == 0 ||  i.Projects_Specialisation_Lines.Any(x => targetSpecIds.Contains(x.Spec_Id))).ToList();

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }

        /// <summary>
        /// Private repository class method. Transfers the properties of database dto objects to ProjectModels. /DK
        /// </summary>
        private List<IProjectModel> TransferAllProjectProperties(List<Linq.Project> dtoProjects)
        {
            IUserRepository userRepo = new UserRepository();
            List<IProjectModel> result = new List<IProjectModel>();

            foreach (var dtoProject in dtoProjects)
            {
                if (dtoProject.Project_Status != "deleted")
                {
                    IProjectModel projectModel = new ProjectModel();

                    projectModel.ProjectId = dtoProject.Project_ID;
                    projectModel.UserId = dtoProject.User_ID;
                    projectModel.Title = dtoProject.Title;
                    projectModel.Description = dtoProject.Description;
                    projectModel.ProjectStartDate = dtoProject.Project_Start_Date;
                    projectModel.ProjectEndDate = dtoProject.Project_End_Date;
                    projectModel.ProjectModifyDate = dtoProject.Project_Modify_Date;
                    projectModel.TotalInvoicePrice = dtoProject.Total_Invoice_Price;
                    projectModel.ProjectStatus = dtoProject.Project_Status;
                    projectModel.ManagerFullName = userRepo.GetUserFromID(dtoProject.User_ID).FullName;
                    projectModel.ManagerUserName = userRepo.GetUserFromID(dtoProject.User_ID).UserName;

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
            var project = dbContext.Projects.FirstOrDefault(i => i.Project_ID == id);
            if (project != null)
            {
                project.Project_Status = "deleted";
                dbContext.SubmitChanges();
            }
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

            List<Linq.Project> dtoProjects = new List<Linq.Project>();

            if (targetUser != null)
            {
                dtoProjects = dbContext.Projects.Where(i => i.User_ID == userId && i.Title.Contains(searchTerm)).ToList();
            }

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }
    }
}