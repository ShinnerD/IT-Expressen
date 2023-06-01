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
        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Project ID matches //MS
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        public List<IConsultantLineModel> GetAllConsultantLinesFromProjectID(int projectID)
        {
            return consultantLineRepository.GetALLConsultantLinesFromProjectID(projectID).ToList();
        }
        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt User ID matches //MS
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<IConsultantLineModel> GetAllConsultantLinesFromUserID(int userID)
        {
            return consultantLineRepository.GetALLConsultantLinesFromUserID(userID).ToList();
        }
        /// <summary>
        /// Retrives a list of all entitys contained in the ConsultantLine table, where the sendt Invoice ID matches //MS
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <returns></returns>
        public List<IConsultantLineModel> GetAllConsultantLinesFromInvoiceID(int invoiceID)
        {
            return consultantLineRepository.GetALLConsultantLinesFromInvoiceID(invoiceID);
        }
        /// <summary>
        /// Enables the use to add a new line to the ConsultantLine table, given the requiered parameters //MS
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="userID"></param>
        /// <param name="HourlyRate"></param>
        /// <param name="HoursTotal"></param>
        /// <exception cref="Exception"></exception>
        public void AddConsultantLine(int projectID, int userID, decimal HourlyRate, int HoursTotal)
        {
            //Error Check if Project is still only pending
            var Project = ServiceManager.ProjectService.GetProject(projectID);
            if (Project.ProjectStatus.ToLower() == "pending")
            {
                throw new Exception("Can't add hours to a pending project. Wait for project to start.");
            }

            IConsultantLineModel newConsulLine = new DAL.Models.ConsultantLineModel();

            newConsulLine.ProjectID = projectID;
            newConsulLine.UserID = userID;
            newConsulLine.HourlyRate = HourlyRate;
            newConsulLine.HoursTotal = HoursTotal;

            var Invoice = ServiceManager.InvoiceService.GetInvoiceFromProjectID(projectID);

            if (Invoice == null)
            {
                ServiceManager.InvoiceService.AddInvoice(projectID, 0, DateTime.Now);
                var newInvoiceID = ServiceManager.InvoiceService.GetInvoiceFromProjectID(projectID).InvoiceId;

                newConsulLine.InvoiceID = newInvoiceID;
            }
            else
            {
                newConsulLine.InvoiceID = Invoice.InvoiceId;
            }

            consultantLineRepository.AddConsultantLine(newConsulLine);
        }
    }
}