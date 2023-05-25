using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class MessageService : IMessageService
    {
        private readonly IDomainServiceManager ServiceManager;
        private readonly IMessageRepository MessageRepository;

        public MessageService(IDomainServiceManager serviceManager, IDataContextManager dataContextManager)
        {
            ServiceManager = serviceManager;
            MessageRepository = new MessageRepository(dataContextManager);
        }

        /// <summary>
        /// Returns a list of all messages related to the specified project.
        /// </summary>
        public List<IMessageModel> GetAllMessageFromProjectID(int projectID)
        {
            return MessageRepository.GetAllMessageFromProjectID(projectID).OrderByDescending(i => i.MessageDate).ToList();
        }

        /// <summary>
        /// Returns a list of all messages related to the specified User.
        /// </summary>
        public List<IMessageModel> GetAllMessageFromUserID(int userId)
        {
            return MessageRepository.GetAllMessageFromUserId(userId).OrderByDescending(i => i.MessageDate).ToList();
        }

        /// <summary>
        /// Adds a message to the database.
        /// </summary>
        public void AddMessage(int projectID, int userID, string message, DateTime messageDate)
        {
            IMessageModel newMessage = new DAL.Models.MessageModel();

            newMessage.ProjectID = projectID;
            newMessage.UserID = userID;
            newMessage.Message = message;
            newMessage.MessageDate = messageDate;

            MessageRepository.AddMessage(newMessage);
        }
    }
}