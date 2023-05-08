using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;


namespace Domain.Services
{
    public class UserService
    {
        public List<IUserModel> GetAllUsers()
        {
            var  userRepo = new DAL.Repository.UserRepository();
            return userRepo.GetAllUsers();    
        }
    }
}
