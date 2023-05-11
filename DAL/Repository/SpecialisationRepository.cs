using DAL.Linq;
using Interfaces.Repositories;

namespace DAL.Repository
{
    /// <summary>
    /// Repository Class for storing and retrieving data specific to Projects in the Database.
    /// </summary>
    public class SpecializationRepository : ISpecializationRepository
    {
        private readonly DataClassesDataContext dbContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        /// <summary>
        /// A list of string representing specializations defined in the database. /DK
        /// </summary>
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

        /// <summary>
        /// Returns a List of strings representing all the chosen specializations for a project. /DK
        /// </summary>
        public List<string> GetProjectSpecializations(int projectId)
        {
            return dbContext.Projects_Specialisation_Lines.Where(i => i.Project_ID == projectId).Select(x => x.Specialisation.Specialisation1).ToList();
        }

        /// <summary>
        /// An int representing the generated identifier ID for a specialization in the database. /DK
        /// </summary>
        public int GetSpecializationID(string specialization)
        {
            return dbContext.Specialisations.FirstOrDefault(i => i.Specialisation1 == specialization).Spec_Id;
        }


        /// <summary>
        /// A String representing the specialization with the provided spec Id /DK
        /// </summary>
        public string GetSpecializationString(int specId)
        {
            return dbContext.Specialisations.FirstOrDefault(i => i.Spec_Id == specId).Specialisation1;
        }

        /// <summary>
        /// Adds the given list of string specializations to the project in the database. /DK
        /// </summary>
        public void AddToProject(int projectId, List<string> specializations)
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

        /// <summary>
        /// Removes the given list of string specializations from the project in the database. /DK
        /// </summary>
        public void RemoveFromProject(int  projectId, List<string> specializations) 
        {
            var targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(x => x.Spec_Id).ToList();
            var targetSpecLines = dbContext.Projects.FirstOrDefault(i => i.Project_ID == projectId).Projects_Specialisation_Lines.Where(x => targetSpecIds.Contains(x.Spec_Id)).ToList();

            dbContext.Projects_Specialisation_Lines.DeleteAllOnSubmit(targetSpecLines);
            dbContext.SubmitChanges();
        }
    }
}