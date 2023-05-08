using DAL.Linq;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class ConsultantRepository
    {

        /// <summary>
        /// Brugt til at teste. Ændre eller slet bare denne metode. /DK
        /// </summary>
        /// <returns></returns>
        public List<IConsultant> GetAll()
        {
            var dbContext = new DataClassesDataContext(DbConnectionString.ConnectionString);
            return dbContext.Users.Where(i => i.User_Type == "consultant").Cast<IConsultant>().ToList();
        }
    }
}
