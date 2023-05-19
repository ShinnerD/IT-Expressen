using DAL.Repository;
using Interfaces.Models;

namespace DAL.Models
{
    public class MessageModel : IMessageModel
    {
        public int MessageID { get; set; }
        public int? ProjectID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
        public string? UserName { get; set; }

    }
}