using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IUserService
    {
        public List<IUserModel> GetAllUsers();

        public void AddUser(IUserModel dto);
    }
}
