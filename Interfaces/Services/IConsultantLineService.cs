using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IConsultantLineService
    {
        /// <summary>
        /// Enables the use to add a new line to the ConsultantLine table, given the requiered parameters //MS
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="userID"></param>
        /// <param name="HourlyRate"></param>
        /// <param name="HoursTotal"></param>
        void AddConsultantLine(int projectID, int userID, decimal HourlyRate, int HoursTotal);

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Invoice ID matches //MS
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <returns></returns>
        List<IConsultantLineModel> GetAllConsultantLinesFromInvoiceID(int invoiceID);

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Project ID matches //MS
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        List<IConsultantLineModel> GetAllConsultantLinesFromProjectID(int projectID);

        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt User ID matches //MS
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<IConsultantLineModel> GetAllConsultantLinesFromUserID(int userID);
    }
}