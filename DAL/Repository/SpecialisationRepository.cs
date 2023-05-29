using DAL.Linq;
using Interfaces.Repositories;

namespace DAL.Repository
{
    /// <summary>
    /// Repository Class for storing and retrieving data specific to Projects in the Database.
    /// </summary>
    public class SpecializationRepository : ISpecializationRepository
    {
        private readonly DataClassesDataContext dbContext;

        public SpecializationRepository(IDataContextManager dataContextManager)
        {
            dbContext = dataContextManager.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContextManager));
        }

        /// <summary>
        /// A list of string representing specializations defined in the database. /Dennis Kempf
        /// </summary>
        public List<string> GetCurrentSpecializationsList()
        {
            return dbContext.Specialisations.Select(i => i.Specialisation1).ToList();
        }

        /// <summary>
        /// Returns a List of strings representing all the chosen specializations for a project. /Dennis Kempf
        /// </summary>
        public List<string> GetProjectSpecializations(int projectId)
        {
            return dbContext.Projects_Specialisation_Lines.Where(i => i.Project_ID == projectId).Select(x => x.Specialisation.Specialisation1).ToList();
        }

        /// <summary>
        /// Returns a list of strings representing the specializations associated with the user specified in the parameters. /Dennis Kempf
        /// </summary>
        public List<string> GetUserSpecializations(int userId)
        {
            return dbContext.Specialisations_Lines.Where(i => i.User_Id == userId).Select(x => x.Specialisation.Specialisation1).ToList();
        }

        /// <summary>
        /// An int representing the generated identifier ID for a specialization in the database. /Dennis Kempf
        /// </summary>
        public int GetSpecializationID(string specialization)
        {
            return dbContext.Specialisations.First(i => i.Specialisation1 == specialization).Spec_Id;
        }

        /// <summary>
        /// A String representing the specialization with the provided spec Id /Dennis Kempf
        /// </summary>
        public string GetSpecializationString(int specId)
        {
            return dbContext.Specialisations.First(i => i.Spec_Id == specId).Specialisation1;
        }

        /// <summary>
        /// Adds the given list of string specializations to the project in the database. /Dennis Kempf
        /// </summary>
        public void AddToProject(int projectId, List<string> specializations)
        {
            if (specializations != null)
            {
                List<Linq.Projects_Specialisation_Line> newSpecLineRows = new List<Linq.Projects_Specialisation_Line>();

                foreach (var specialization in specializations)
                {
                    var newSpecLine = new Linq.Projects_Specialisation_Line();

                    newSpecLine.Project_ID = projectId;
                    newSpecLine.Spec_Id = GetSpecializationID(specialization);

                    newSpecLineRows.Add(newSpecLine);
                }

                dbContext.Projects_Specialisation_Lines.InsertAllOnSubmit(newSpecLineRows);
                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Removes the given list of string specializations from the project in the database. /Dennis Kempf
        /// </summary>
        public void RemoveFromProject(int projectId, List<string> specializations)
        {
            var targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(x => x.Spec_Id).ToList();
            var targetSpecLines = dbContext.Projects.First(i => i.Project_ID == projectId).Projects_Specialisation_Lines.Where(x => targetSpecIds.Contains(x.Spec_Id)).ToList();

            dbContext.Projects_Specialisation_Lines.DeleteAllOnSubmit(targetSpecLines);
            dbContext.SubmitChanges();
        }

        /// <summary>
        /// Adds the List of string representing specializations to the user with the given User Id to the database. /MS
        /// </summary>
        public void AddSpecializationsToUser(int UserID, List<string> specializations)
        {
            if (specializations.Any())
            {
                List<Linq.Specialisations_Line> newSpecLineRows = new List<Linq.Specialisations_Line>();

                foreach (var specialization in specializations)
                {
                    var newSpecLine = new Linq.Specialisations_Line();

                    newSpecLine.User_Id = UserID;
                    newSpecLine.Spec_Id = GetSpecializationID(specialization);

                    newSpecLineRows.Add(newSpecLine);
                }

                dbContext.Specialisations_Lines.InsertAllOnSubmit(newSpecLineRows);
                dbContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Removes the given list of string specializations to the user. /Dennis Kempf
        /// </summary>
        public void RemoveSpecializationsFromUser(int userId, List<string> specializations)
        {
            var targetSpecIds = dbContext.Specialisations.Where(i => specializations.Contains(i.Specialisation1)).Select(x => x.Spec_Id).ToList();
            var targetSpecLines = dbContext.Specialisations_Lines.Where(x => x.User_Id == userId && targetSpecIds.Contains(x.Spec_Id)).ToList();

            dbContext.Specialisations_Lines.DeleteAllOnSubmit(targetSpecLines);
            dbContext.SubmitChanges();
        }
    }
}