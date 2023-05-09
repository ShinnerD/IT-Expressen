using Interfaces.Services;

namespace Domain.Services
{
    /// <summary>
    /// Service class that has methods for retrieving and manipulating skills/specializations. /DK
    /// </summary>
    public class SpecializationService : ISpecializationService
    {
        /// <returns>Returns a list of strings that represent the current specializations in the Database</returns>
        public List<string> ListDefinedSpecializations()
        {
            List<string> result;
            var repo = new DAL.Repository.SpecializationRepository();

            result = repo.GetCurrentSpecializationsList();
            return result;
        }
    }
}