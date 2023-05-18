using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IMessageService
    {
        void AddMessage(int projectID, int userID, string message, DateTime messageDate);
        List<IMessageModel> GetAllMessageProjectID(int projectID);
        IMessageModel MessageFromProjctID(int projctID);
        List<IMessageModel> GetAllMessageFromProjectID(int projctID);


    }
}
