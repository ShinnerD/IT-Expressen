using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repositories
{
    public interface IMessageRepository
    {
        /// <summary>
        /// Retrieves a List of Invites for the project
        /// </summary>
        List<IMessageModel> GetAllMessageFromProjectID(int projectID);

        /// <summary>
        /// Retrieves a List of Invites belonging to a user with the specified Id.
        /// </summary>
        List<IMessageModel> GetAllMessageFromUserId(int userId);

        /// <summary>
        /// Adds a message to the database.
        /// </summary>
        void AddMessage(IMessageModel messageModel);
    }
}
