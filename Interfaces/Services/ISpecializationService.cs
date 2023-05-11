namespace Interfaces.Services
{
    /// <summary>
    /// This service interface provides methods for retrieving and manipulating skills/specializations.
    /// </summary>
    public interface ISpecializationService
    {
        /// <returns>List of strings representing the current Specializations/Skills in the Database.</returns>
        public List<string> ListDefinedSpecializations();
    }
}