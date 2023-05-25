using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IConsultantLineRepository
    {
        void AddConsultantLine(IConsultantLineModel ConsulModel);

        void DeleteConsultantLine(int userID, int projectID);

        List<IConsultantLineModel> GetAllConsultantLines();

        List<IConsultantLineModel> GetALLConsultantLinesFromProjectID(int projectID);

        List<IConsultantLineModel> GetALLConsultantLinesFromUserID(int userID);

        List<IConsultantLineModel> GetALLConsultantLinesFromInvoiceID(int invoiceID);
    }
}