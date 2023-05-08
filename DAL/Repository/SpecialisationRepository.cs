using DAL.Linq;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class SpecialisationRepository
    {

        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        List<SpecialisationModel> result = new List<SpecialisationModel>();
        public SpecialisationModel GetInvite(int ProjectId)
        {
            SpecialisationModel result = new SpecialisationModel();

            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.Project_ID == ProjectId);

           

            return result;


        }
    }
}
