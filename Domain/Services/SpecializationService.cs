using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Service class that has methods for retrieving and manipulating skills/specializations. /DK
    /// </summary>
    public class SpecializationService : ISpecializationService
    {
        ISpecializationRepository Repository = new DAL.Repository.SpecializationRepository();

        /// <returns>Returns a list of strings that represent the current specializations in the Database</returns>
        public List<string> ListDefinedSpecializations()
        {                            
            return Repository.GetCurrentSpecializationsList();
        }

        public List<string> GetProjectSpecializations(int projectId)
        {
            return Repository.GetProjectSpecializations(projectId);
        }

        public int GetIDFromName(string specialization)
        {
            return Repository.GetSpecializationID(specialization);
        }

        public string GetNameFromID(int specId)
        {
            return Repository.GetSpecializationString(specId);
        }

        public void AddToProject(int projectId, List<string> specializations)
        {
            Repository.AddToProject(projectId, specializations);
        }

        public void RemoveFromProject(int projectId, List<string> specializations) 
        {
            Repository.RemoveFromProject(projectId, specializations);
        }
    }
}