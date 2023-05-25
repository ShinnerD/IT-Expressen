﻿using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{


    public class ConsultantLineRepository : IConsultantLineRepository
    {
        private readonly DataClassesDataContext dbcontext;

        public ConsultantLineRepository(IDataContextManager dataContext)
        {
            dbcontext = dataContext.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public List<IConsultantLineModel> GetAllConsultantLines()
        {
            List<IConsultantLineModel> result = new List<IConsultantLineModel>();

            var dbConsultantLine = dbcontext.Consultant_Lines;
            foreach (var line in dbConsultantLine)
            {
                IConsultantLineModel ConLine = new ConsultantLineModel();

                ConLine.LineID = line.Line_ID;
                ConLine.ProjectID = (int)line.Project_ID;
                ConLine.UserID = (int)line.User_ID;
                ConLine.HourlyRate = (decimal)line.Hourly_Rate;
                ConLine.HoursTotal = (int)line.Hours_total;
                ConLine.InvoiceID = line.Invoice_ID;

                result.Add(ConLine);
            }
            return result;
        }
        public void AddConsultantLine(IConsultantLineModel ConsulModel)
        {

            var newConsultantLine = new Linq.Consultant_Line();

            newConsultantLine.Project_ID = ConsulModel.ProjectID;
            newConsultantLine.User_ID = ConsulModel.UserID;
            newConsultantLine.Hourly_Rate = ConsulModel.HourlyRate;
            newConsultantLine.Hours_total = ConsulModel.HoursTotal;
            newConsultantLine.Invoice_ID = ConsulModel.InvoiceID;

            dbcontext.Consultant_Lines.InsertOnSubmit(newConsultantLine);
            dbcontext.SubmitChanges();
        }
        public void DeleteConsultantLine(int userID, int projectID)
        {
            var targetConsulLineID = dbcontext.Consultant_Lines.Where(i => i.User_ID == userID && i.Project_ID == projectID);

            dbcontext.Consultant_Lines.DeleteAllOnSubmit(targetConsulLineID);
            dbcontext.SubmitChanges();
        }
        public List<IConsultantLineModel> GetALLContultantLinesFromUserID(int userID)
        {
            List<IConsultantLineModel> result = new List<IConsultantLineModel>();

            var dbConsulLine = dbcontext.Consultant_Lines.Where(i => i.User_ID == userID);

            foreach (var dtoConsulLine in dbConsulLine)
            {
                IConsultantLineModel consultantLine = new ConsultantLineModel();

                consultantLine.LineID = dtoConsulLine.Line_ID;
                consultantLine.ProjectID = (int)dtoConsulLine.Project_ID;
                consultantLine.UserID = (int)dtoConsulLine.User_ID;
                consultantLine.HourlyRate = (Decimal)dtoConsulLine.Hourly_Rate;
                consultantLine.HoursTotal = (int)dtoConsulLine.Hours_total;
                consultantLine.InvoiceID = dtoConsulLine.Invoice_ID;

                result.Add(consultantLine);
            }
            return result;
        }
        public List<IConsultantLineModel> GetALLContultantLinesFromProjectID(int projectID)
        {
            List<IConsultantLineModel> result = new List<IConsultantLineModel>();

            var dbConsulLine = dbcontext.Consultant_Lines.Where(i => i.Project_ID == projectID);

            foreach (var dtoConsulLine in dbConsulLine)
            {
                IConsultantLineModel consultantLine = new ConsultantLineModel();

                consultantLine.LineID = dtoConsulLine.Line_ID;
                consultantLine.ProjectID = (int)dtoConsulLine.Project_ID;
                consultantLine.UserID = (int)dtoConsulLine.User_ID;
                consultantLine.HourlyRate = (Decimal)dtoConsulLine.Hourly_Rate;
                consultantLine.HoursTotal = (int)dtoConsulLine.Hours_total;
                consultantLine.InvoiceID = dtoConsulLine.Invoice_ID;

                result.Add(consultantLine);
            }
            return result;
        }
        public List<IConsultantLineModel> GetALLContultantLinesFromInvoiceID(int invoiceID)
        {
            List<IConsultantLineModel> result = new List<IConsultantLineModel>();

            var dbConsulLine = dbcontext.Consultant_Lines.Where(i => i.Invoice_ID == invoiceID);

            foreach (var dtoConsulLine in dbConsulLine)
            {
                IConsultantLineModel consultantLine = new ConsultantLineModel();

                consultantLine.LineID = dtoConsulLine.Line_ID;
                consultantLine.ProjectID = (int)dtoConsulLine.Project_ID;
                consultantLine.UserID = (int)dtoConsulLine.User_ID;
                consultantLine.HourlyRate = (Decimal)dtoConsulLine.Hourly_Rate;
                consultantLine.HoursTotal = (int)dtoConsulLine.Hours_total;
                consultantLine.InvoiceID = dtoConsulLine.Invoice_ID;

                result.Add(consultantLine);
            }
            return result;
        }
    }
}