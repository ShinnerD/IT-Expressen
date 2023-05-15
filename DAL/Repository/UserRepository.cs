﻿using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataClassesDataContext dbcontext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public List<IUserModel> GetAllUsers()
        {
            try
            {
                var AlldtoUsers = dbcontext.Users;

                List<IUserModel> result = new List<IUserModel>();

                foreach (var dto in AlldtoUsers)
                {
                    var user = new DAL.Models.UserModel();

                    user.ID = dto.User_ID;
                    user.Address = dto.Street_Address;
                    user.UserName = dto.User_name;
                    user.Password = dto.Password;
                    user.FirstName = dto.First_Name;
                    user.LastName = dto.Last_Name;
                    user.EMail = dto.Email;
                    user.NameCity = dto.City;
                    user.ZipCode = dto.Zip_Code;
                    user.PhoneNumber = dto.Phone_Number;
                    user.Country = dto.Country;
                    user.ActiveStatus = (bool?)dto.Active_Status;
                    user.CreationDate = (DateTime?)dto.Creation_Date;
                    user.UserType = dto.User_Type;
                    //user.Specialization = dto.Specialisations_Lines.First(i => i.User_Id == user.ID).Spec_Id;

                    result.Add(user);
                }
                return result;
            }
            catch 
            {
                return null;
            }

        }

        public void AddUser(IUserModel userModel, List<string> specializtions)
        {
            IUserModel user = new DAL.Models.UserModel();
            ISpecializationRepository specRepo = new SpecializationRepository();

            var linqUserModel = new Linq.User();
            
            
            linqUserModel.User_name = userModel.UserName;
            linqUserModel.Password = userModel.Password;
            linqUserModel.User_Type = userModel.UserType;
            linqUserModel.First_Name = userModel.FirstName;
            linqUserModel.Last_Name= userModel.LastName;
            linqUserModel.Street_Address = userModel.Address;
            linqUserModel.City = userModel.NameCity;
            linqUserModel.Zip_Code = userModel.ZipCode;
            linqUserModel.Country = userModel.Country;
            linqUserModel.Phone_Number = userModel.PhoneNumber;
            linqUserModel.Email = userModel.EMail;
            linqUserModel.Active_Status = userModel.ActiveStatus;
            linqUserModel.Creation_Date = userModel.CreationDate;
            
            dbcontext.Users.InsertOnSubmit(linqUserModel);
            dbcontext.SubmitChanges();

            specRepo.AddSpecializationsToUser(linqUserModel.User_ID, specializtions);
        }

        public IUserModel GetUser(string username)
        {
            IUserModel user = new DAL.Models.UserModel();

            var dbUser = dbcontext.Users.FirstOrDefault(i => i.User_name == username);

            if (dbUser != null)
            {
                user.ID = dbUser.User_ID;
                user.UserName = dbUser.User_name;
                user.Password = dbUser.Password;
                user.UserType = dbUser.User_Type;
                user.FirstName = dbUser.First_Name;
                user.LastName = dbUser.Last_Name;
                user.EMail = dbUser.Email;
                user.Address = dbUser.Street_Address;
                user.NameCity = dbUser.City;
                user.ZipCode = dbUser.Zip_Code;
                user.PhoneNumber = dbUser.Phone_Number;
                user.Country = dbUser.Country;
                user.ActiveStatus = dbUser.Active_Status;
                user.CreationDate = dbUser.Creation_Date;
                
            }

            return user;
        }

        void IUserRepository.Delete(string delete)
        {
            throw new NotImplementedException();
        }
        public List<IUserModel> TransferAllUserProperties(List<Linq.User> dtoUsers)
        {
            List<IUserModel> result = new List<IUserModel> ();

            foreach (var dtoUser in dtoUsers)
            {
                IUserModel userModel = new UserModel();

                userModel.ID = dtoUser.User_ID;
                userModel.UserName = dtoUser.User_name;
                userModel.Password = dtoUser.Password;
                userModel.UserType = dtoUser.User_Type;
                userModel.FirstName = dtoUser.First_Name;
                userModel.LastName = dtoUser.Last_Name;
                userModel.EMail = dtoUser.Email;
                userModel.Address = dtoUser.Street_Address;
                userModel.NameCity = dtoUser.City;
                userModel.ZipCode = dtoUser.Zip_Code;
                userModel.Country = dtoUser.Country;
                userModel.PhoneNumber = dtoUser.Phone_Number;
                userModel.ActiveStatus = dtoUser.Active_Status;
                userModel.CreationDate = dtoUser.Creation_Date;

                result.Add(userModel);
            }
            return result;
        }
        public List<IUserModel> GetUsersType(string UserType)
        {
            var targetType = dbcontext.Users.Where(i => i.User_Type == UserType).ToList();

            List<IUserModel> result = TransferAllUserProperties(targetType);

            return result;
        }
        
    }
}