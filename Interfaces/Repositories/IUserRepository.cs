﻿using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<IUserModel> GetAllUsers();

        IUserModel GetUser(string username);
    }
}