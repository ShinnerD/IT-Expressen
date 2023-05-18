using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Repositories;

namespace DAL.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private DataClassesDataContext dbcontext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public List<IMessageModel> GetAllMessageProjectID(int projectID)
        {
            List<IMessageModel> result = new List<IMessageModel>();

            var dbMessage = dbcontext.Projects.FirstOrDefault(i => i.Project_ID == projectID).Project_Message_Lines;

            foreach (var item in dbMessage)
            {
                IMessageModel Message = new MessageModel();

                Message.MessageID = item.Message_ID;
                Message.ProjectID = item.Project_ID;
                Message.UserID = (int)item.User_ID;
                Message.Message = item.Message;
                Message.MessageDate = (DateTime)item.Message_Date;

                result.Add(Message);
            }
            return result;
        }

        public IMessageModel MessageFromProjectID(int ProjectID)
        {
            IMessageModel Message = new MessageModel();

            var dbMessage = dbcontext.Project_Message_Lines.FirstOrDefault(i => i.Project_ID == ProjectID);

            Message.MessageID = dbMessage.Message_ID;
            Message.ProjectID = dbMessage.Project_ID;
            Message.UserID = (int)dbMessage.User_ID;
            Message.Message = dbMessage.Message;
            Message.MessageDate = (DateTime)dbMessage.Message_Date;

            return Message;
        }

        public void AddMessage(IMessageModel messageModel)
        {

            
            IMessageModel message = new MessageModel();

            var linqMessageModel = new Linq.Project_Message_Line();

            linqMessageModel.Message_ID = messageModel.MessageID;
            linqMessageModel.Project_ID = messageModel.ProjectID;
            linqMessageModel.User_ID = messageModel.UserID;
            linqMessageModel.Message = messageModel.Message;
            linqMessageModel.Message_Date = messageModel.MessageDate;

            dbcontext.Project_Message_Lines.InsertOnSubmit(linqMessageModel);
            dbcontext.SubmitChanges();
            


        }

        public List<IMessageModel> GetAllMessageFromProjectID(int projectID)
        {
            List<IMessageModel> result = new List<IMessageModel>();

            var dbMessages = dbcontext.Projects.FirstOrDefault(i => i.Project_ID == projectID).Project_Message_Lines;

            foreach (var dbMessage in dbMessages)
            {
                IMessageModel Message = new MessageModel();

                Message.MessageID = dbMessage.Message_ID;
                Message.ProjectID = dbMessage.Project_ID;
                Message.UserID = (int)dbMessage.User_ID;
                Message.Message = dbMessage.Message;
                Message.MessageDate = (DateTime)dbMessage.Message_Date;

                result.Add(Message);
            }
            return result;
        }

    }
}