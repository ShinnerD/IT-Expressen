using Interfaces.Repositories;

namespace DAL.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Linq.DataClassesDataContext dbContext = new Linq.DataClassesDataContext(Linq.DbConnectionString.ConnectionString);

        public ProjectRepository()
        { }

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

            specRepo.AddSpecializationsToProject(newProject.Project_ID, specializations);
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