using DAL.Linq;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Writen by Erik

namespace DAL.Repository
{
    public class SpecialisationRepository
    {
        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);


        public List<SpecialisationModel> GetAllSpecialisation()
        {
            List<SpecialisationModel> result = new List<SpecialisationModel>();

            var dbSpecialisations = DataContext.Specialisations;
            foreach (var dbSpecialisation in dbSpecialisations)
            {
                SpecialisationModel specialisation = new SpecialisationModel();

                specialisation.SpecId = dbSpecialisation.Spec_Id;
                specialisation.Specialisation = dbSpecialisation.Specialisation1;
                specialisation.Description = dbSpecialisation.Description;


                result.Add(specialisation);


            }
            return result;





        }
        public SpecialisationModel GetSpecialisation(int specialisation)
        {
            SpecialisationModel result = new SpecialisationModel();

            var dbSpecialisation = DataContext.Specialisations.FirstOrDefault(i => i.Spec_Id == specialisation);


            result.SpecId = dbSpecialisation.Spec_Id;
            result.Specialisation = dbSpecialisation.Specialisation1;
            result.Description = dbSpecialisation.Description;


            return result;


        }
    }





}

