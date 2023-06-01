using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataClassesDataContext dbContext;

        public MessageRepository(IDataContextManager dataContext)
        {
            dbContext = dataContext.GetContext() as DataClassesDataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        /// <summary>
        /// Retrieves a List of Invites for the project //MS
        /// </summary>
        public List<IMessageModel> GetAllMessageFromProjectID(int projectID)
        {
            List<IMessageModel> result = new List<IMessageModel>();

            var dbMessages = dbContext.Project_Message_Lines.Where(i => i.Project_ID == projectID);

            foreach (var dbMessage in dbMessages)
            {
                IMessageModel Message = new MessageModel();

                Message.MessageID = dbMessage.Message_ID;
                Message.ProjectID = dbMessage.Project_ID;
                Message.UserID = (int)dbMessage.User_ID;
                Message.Message = dbMessage.Message;
                Message.MessageDate = (DateTime)dbMessage.Message_Date;
                Message.UserName = dbContext.Users.FirstOrDefault(i => i.User_ID == dbMessage.User_ID)?.User_name;

                result.Add(Message);
            }
            return result;
        }

        /// <summary>
        /// Retrieves a List of Invites belonging to a user with the specified Id. //MS
        /// </summary>
        public List<IMessageModel> GetAllMessageFromUserId(int userId)
        {
            List<IMessageModel> result = new List<IMessageModel>();

            var dbMessages = dbContext.Project_Message_Lines.Where(i => i.User_ID == userId);

            foreach (var dtoMessage in dbMessages)
            {
                IMessageModel Message = new MessageModel();

                Message.MessageID = dtoMessage.Message_ID;
                Message.ProjectID = dtoMessage.Project_ID;
                Message.UserID = (int)dtoMessage.User_ID;
                Message.Message = dtoMessage.Message;
                Message.MessageDate = (DateTime)dtoMessage.Message_Date;
                Message.UserName = dbContext.Users.FirstOrDefault(i => i.User_ID == dtoMessage.User_ID)?.User_name;

                result.Add(Message);
            }
            return result;
        }

        /// <summary>
        /// Adds a message to the database. //MS
        /// </summary>
        public void AddMessage(IMessageModel messageModel)
        {
            var linqMessageModel = new Linq.Project_Message_Line();

            linqMessageModel.Project_ID = messageModel.ProjectID;
            linqMessageModel.User_ID = messageModel.UserID;
            linqMessageModel.Message = messageModel.Message;
            linqMessageModel.Message_Date = messageModel.MessageDate;

            dbContext.Project_Message_Lines.InsertOnSubmit(linqMessageModel);
            dbContext.SubmitChanges();
        }
    }
}