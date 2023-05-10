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
        /// Creates a new Project in the database with the details specified in the parameters. /DK
        /// </summary>
        public void Add(string userName, string title, string description, DateTime startDate, DateTime endDate, List<string> specializations)
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
        /// Returns a list of IProjectModels related the user specified in the method parameter. /DK
        /// </summary>
        public List<IProjectModel> GetUserProjects(int userId)
        {
            var targetUser = dbContext.Users.FirstOrDefault(i => i.User_ID == userId);

            List<IProjectModel> result = TransferAllProjectProperties(targetUser.Projects.ToList());

            return result;
        }

        /// <summary>
        /// Retrieves a List of IProjectModels that fit all of the specializations specified in the method parameter. /DK
        /// </summary>
        /// <param name="specializations"></param>
        /// <returns></returns>
        public List<IProjectModel> GetProjectsFromSpecializations(List<string> specializations)
        {
            List<int> targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(i => i.Spec_Id).ToList();

            var dtoProjects = dbContext.Projects.Where(i => targetSpecIds.All(v => i.Projects_Specialisation_Lines.Select(x => x.Spec_Id).Contains(v))).ToList();

            List<IProjectModel> result = TransferAllProjectProperties(dtoProjects);

            return result;
        }

        /// <summary>
        /// Private repository class method. Transfers the properties of database dto objects to ProjectModels. /DK
        /// </summary>
        /// <param name="dtoProjects">A List of Linq.Project items.</param>
        /// <returns></returns>
        private List<IProjectModel> TransferAllProjectProperties(List<Linq.Project> dtoProjects)
        {
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

                    result.Add(projectModel);
                }
            }
            return result;
        }

        /// <summary>
        /// Jonas
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var project = dbContext.Projects.FirstOrDefault(i => i.Project_ID == id);
            if (project != null)
            {
                project.Project_Status = "deleted";
                dbContext.SubmitChanges();
            }
        }
    }
}