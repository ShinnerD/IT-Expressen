using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{

    public class ConsultantLineService : IConsultantLineService
    {
        private readonly IDomainServiceManager ServiceManager;
        private readonly IConsultantLineRepository consultantLineRepository;

        public ConsultantLineService(IDomainServiceManager serviceManager, IDataContextManager dataContextManager)
        {
            ServiceManager = serviceManager;
            consultantLineRepository = new ConsultantLineRepository(dataContextManager);
        }

        public List<IConsultantLineModel> GetAllConsultantLinesFromProjectID(int projectID)
        {
            return consultantLineRepository.GetALLContultantLinesFromProjectID(projectID).ToList();
        }

        public List<IConsultantLineModel> GetAllConsultantLinesFromUserID(int userID)
        {
            return consultantLineRepository.GetALLContultantLinesFromUserID(userID).ToList();
        }

        public List<IConsultantLineModel> GetAllConsultantLinesFromInvoiceID(int invoiceID)
        {
            return consultantLineRepository.GetALLContultantLinesFromInvoiceID(invoiceID);
        }

        public void AddConsultantLine(int projectID, int userID, decimal HourlyRate, int HoursTotal)
        {
            IConsultantLineModel newConsulLine = new DAL.Models.ConsultantLineModel();

            newConsulLine.ProjectID = projectID;
            newConsulLine.UserID = userID;
            newConsulLine.HourlyRate = HourlyRate;
            newConsulLine.HoursTotal = HoursTotal;

            if (ServiceManager.InvoiceService.GetInvoiceFromProjectID(projectID) == null)
            {
                ServiceManager.InvoiceService.AddInvoice(projectID, 0, DateTime.Now);
                var newInvoiceID = ServiceManager.InvoiceService.GetInvoiceFromProjectID(projectID);

                newConsulLine.InvoiceID = newInvoiceID.InvoiceId;
            }
            else
            {
                newConsulLine.InvoiceID = ServiceManager.InvoiceService.GetInvoiceFromProjectID(projectID).InvoiceId;
                                        
            }

            consultantLineRepository.AddConsultantLine(newConsulLine);
        }
    }
}