using DAL.Linq;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

///Writen by Erik

//namespace DAL.Repository
//{
//    public class ConsultantRepository
//    {

//        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);



//        public List<ConsultantModel> GetAllConsultant()
//        {
//            List<ConsultantModel> result = new List<ConsultantModel>();

//            var dbConsultanes = DataContext.Users.Where(i => i.User_Type == "consultant");
//            foreach (var dbConsultan in dbConsultanes)
//            {
//                ConsultantModel Consultan = new ConsultantModel();

//                Consultan.LineId = dbConsultan.LineId;
//                Consultan.HoursSpendt = dbConsultan.Consultant_Lines.;
//                Consultan.ID = dbConsultan.ID();
//                Consultan.ActiveStatus = dbConsultan.ActiveStatus();
//                Consultan.Specialization = dbConsultan.Specialization();
//                Consultan.HourRate = dbConsultan.HourRate();
//                Consultan.HoursSpendt = dbConsultan.HoursSpendt();
//                Consultan.TotalEarnings = dbConsultan.TotalEarnings();



//                result.Add(Consultan);


//            }
//            return result;




//        }
//        public ConsultantModel GetConsultant(int LineId)
//        {
//            ConsultantModel result = new ConsultantModel();

//            var dbConsultan = DataContext.Consultan.FirstOrDefault(i => i.LineId == LineId);

//            result.LineId = dbConsultan.LineId;
//            result.ID = dbConsultan.ID();
//            result.ActiveStatus = dbConsultan.ActiveStatus();
//            result.Specialization = dbConsultan.Specialization();
//            result.HourRate = dbConsultan.HourRate();
//            result.HoursSpendt = dbConsultan.HoursSpendt();
//            result.TotalEarnings = dbConsultan.TotalEarnings();

//            return result;
//        }


//        public void SaveNewConsulent(ConsultantModel consultant)
//        {
//            ConsultantModel newConsultant = new ConsultantModel();

//            newConsultant.LineId = consultant.LineId;
//            newConsultant.ID = consultant.ID();
//            newConsultant.ActiveStatus = consultant.ActiveStatus();
//            newConsultant.Specialization = consultant.Specialization();
//            newConsultant.HourRate = consultant.HourRate();
//            newConsultant.HoursSpendt = consultant.HoursSpendt();
//            newConsultant.TotalEarnings = consultant.TotalEarnings();

//            DataContext.Consultan.InsertOnSubmit(newEmployee);
//            DataContext.SubmitChanges();
//        }
//        public void EditConsultant(ConsultantModel consultant)
//        {
//            var targetConsultant = DataContext.Consultant.FirstOrDefault(i => i.LineId == consultant.LineId);

//            if (targetConsultant != null)
//            {

//                targetConsultant.LineId = consultant.LineId;
//                targetConsultant.ID = consultant.ID();
//                targetConsultant.ActiveStatus = consultant.ActiveStatus();
//                targetConsultant.Specialization = consultant.Specialization();
//                targetConsultant.HourRate = consultant.HourRate();
//                targetConsultant.HoursSpendt = consultant.HoursSpendt();
//                targetConsultant.TotalEarnings = consultant.TotalEarnings();
//                DataContext.SubmitChanges();

//            }


//        }
//        public void DeleteConsultant(ConsultantModel consultant)
//        {
//            if (consultant != null)
//            {
//                var targetConsultant = DataContext.Consultant.FirstOrDefault(i => i.LineId == consultant.LineId);

//                if (targetConsultant != null)
//                {
//                    DataContext.Consultant.DeleteOnSubmit(targetConsultant);
//                    DataContext.SubmitChanges();
//                }
//            }
//            else
//            {
//                throw new ArgumentNullException(nameof(consultant));
//            }
//        }


//        /// <summary>
//        /// Brugt til at teste. Ændre eller slet bare denne metode. /DK
//        /// </summary>
//        /// <returns></returns>

//        public List<IConsultant> GetAll()
//            {
//                var dbContext = new DataClassesDataContext(DbConnectionString.ConnectionString);
//                return dbContext.Users.Where(i => i.User_Type == "consultant").Cast<IConsultant>().ToList();
//            }
        
//    }
//}