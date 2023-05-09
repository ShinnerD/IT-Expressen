using DAL.Linq;
using Interfaces.Repositories;

namespace DAL.Repository
{
    /// <summary>
    /// Repository Class for storing and retrieving data specific to Projects in the Database.
    /// </summary>
    public class SpecializationRepository : ISpecializationRepository
    {
        private DataClassesDataContext dbContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        /// <returns>A list of string representing the currently defined list of specializations in the database.</returns>
        public List<string> GetCurrentSpecializationsList()
        {
            List<string> list = new List<string>();

            var specList = dbContext.Specialisations;

            foreach (var specialization in specList)
            {
                list.Add(specialization.Specialisation1);
            }

            return list;
        }

        /// <returns>An integer representing the generated ID for a specialization the Database
        /// that matches the given string.</returns>
        public int GetSpecializationID(string specialization)
        {
            return dbContext.Specialisations.FirstOrDefault(i => i.Specialisation1 == specialization).Spec_Id;
        }

        /// <summary>
        /// Adds the specializations given in the parameters to the database and relates them to the project.
        /// </summary>
        public void AddSpecializationsToProject(int projectId, List<string> specializations)
        {
            if (specializations != null)
            {
                List<Linq.Projects_Specialisation_Line> newSpecLineRows = new List<Linq.Projects_Specialisation_Line>();

                foreach (var specialization in specializations)
                {
                    var newSpecLine = new Linq.Projects_Specialisation_Line();

                    newSpecLine.Project = dbContext.Projects.FirstOrDefault(i => i.Project_ID == projectId);
                    newSpecLine.Project_ID = newSpecLine.Project.Project_ID;
                    newSpecLine.Specialisation = dbContext.Specialisations.FirstOrDefault(i => i.Specialisation1 == specialization);
                    newSpecLine.Spec_Id = newSpecLine.Specialisation.Spec_Id;

                    newSpecLineRows.Add(newSpecLine);
                }

                dbContext.Projects_Specialisation_Lines.InsertAllOnSubmit(newSpecLineRows);
                dbContext.SubmitChanges();
            }
        }
    }
}