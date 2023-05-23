using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
