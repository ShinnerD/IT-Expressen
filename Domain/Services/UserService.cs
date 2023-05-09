using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Services;
using Interfaces.Models;



namespace Domain.Services
{
    public class UserService : IUserService
    {
        public List<IUserModel> GetAllUsers()
        {
            var userRepo = new DAL.Repository.UserRepository();
            return userRepo.GetAllUsers();
        }
        public void AddUser(IUserModel dto)
        {
            var AddUserRepo = new DAL.Repository.UserRepository();
            AddUserRepo.AddUser(dto);
        }
    }
}
