using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IConsultantLineRepository
    {
        /// <summary>
        /// Enables the use to add a new line to the ConsultantLine table //MS
        /// </summary>
        /// <param name="ConsulModel"></param>
        void AddConsultantLine(IConsultantLineModel ConsulModel);

        /// <summary>
        /// Give the option to delete a line from the ConsultantLine table //MS
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="projectID"></param>
        void DeleteConsultantLine(int userID, int projectID);

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table //MS
        /// </summary>
        /// <returns></returns>
        List<IConsultantLineModel> GetAllConsultantLines();

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Project ID matches //MS
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        List<IConsultantLineModel> GetALLConsultantLinesFromProjectID(int projectID);
       
        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt User ID matches //MS
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>       
        List<IConsultantLineModel> GetALLConsultantLinesFromUserID(int userID);

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Invoice ID matches //MS
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <returns></returns>
        List<IConsultantLineModel> GetALLConsultantLinesFromInvoiceID(int invoiceID);
    }
}