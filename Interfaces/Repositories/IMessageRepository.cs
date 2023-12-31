﻿using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IMessageRepository
    {
        /// <summary>
        /// Retrieves a List of Invites for the project //MS
        /// </summary>
        List<IMessageModel> GetAllMessageFromProjectID(int projectID);

        /// <summary>
        /// Retrieves a List of Invites belonging to a user with the specified Id. //MS
        /// </summary>
        List<IMessageModel> GetAllMessageFromUserId(int userId);

        /// <summary>
        /// Adds a message to the database. //MS
        /// </summary>
        void AddMessage(IMessageModel messageModel);
    }
}