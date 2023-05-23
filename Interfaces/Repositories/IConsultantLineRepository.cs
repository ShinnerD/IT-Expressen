using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IConsultantLineRepository
    {
        void AddConsultantLine(IConsultantLineModel ConsulModel);

        void DeleteConsultantLine(int userID, int projectID);

        List<IConsultantLineModel> GetAllConsultantLines();

        List<IConsultantLineModel> GetALLContultantLinesFromProjectID(int projectID);

        List<IConsultantLineModel> GetALLContultantLinesFromUserID(int userID);

        List<IConsultantLineModel> GetALLContultantLinesFromInvoiceID(int invoiceID);
    }
}