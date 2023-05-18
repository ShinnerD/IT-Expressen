using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class MessageService : IMessageService
    {
        private IMessageRepository MessageRepository = new MessageRepository();

        public List<IMessageModel> GetAllMessageProjectID(int projectID)
        {
            return MessageRepository.GetAllMessageProjectID(projectID);
        }

        public void AddMessage(int projectID, int userID, string message, DateTime messageDate)
        {
            IMessageModel newMessage = new DAL.Models.MessageModel();

            newMessage.ProjectID = projectID;
            newMessage.UserID = userID;
            newMessage.Message = message;
            newMessage.MessageDate = messageDate;

            MessageRepository.AddMessage(newMessage);
        }
        public IMessageModel MessageFromProjctID(int projctID)
        {
            return MessageRepository.MessageFromProjectID(projctID);
        }
        public List<IMessageModel> GetAllMessageFromProjectID(int projctID)
        {
            return MessageRepository.GetAllMessageFromProjectID(projctID).OrderByDescending(i => i.MessageDate).ToList();
        }
    }
}