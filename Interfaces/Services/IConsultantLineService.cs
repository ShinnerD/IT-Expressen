using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IConsultantLineService
    {
        void AddConsultantLine(int projectID, int userID, decimal HourlyRate, int HoursTotal);

        List<IConsultantLineModel> GetAllConsultantLinesFromInvoiceID(int invoiceID);

        List<IConsultantLineModel> GetAllConsultantLinesFromProjectID(int projectID);

        List<IConsultantLineModel> GetAllConsultantLinesFromUserID(int userID);
    }
}