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
        void AddMessage(IMessageModel messageModel);
        List<IMessageModel> GetAllMessageProjectID(int projectID);
        IMessageModel MessageFromProjectID(int ProjectID);
        List<IMessageModel> GetAllMessageFromProjectID(int projectID);
    }
}
