using Interfaces.Models;

namespace Interfaces.Services
{
    public interface IMessageService
    {
        /// <summary>
        /// Adds a message to the database.
        /// </summary>
        void AddMessage(int projectID, int userID, string message, DateTime messageDate);

        /// <summary>
        /// Returns a list of all messages related to the specified project.
        /// </summary>
        List<IMessageModel> GetAllMessageFromProjectID(int projectID);

        /// <summary>
        /// Returns a list of all messages related to the specified User.
        /// </summary>
        List<IMessageModel> GetAllMessageFromUserID(int userId);
    }
}