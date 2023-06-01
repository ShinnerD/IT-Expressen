namespace Interfaces.Models
{
    /// <summary>
    /// Interface used to connect to MessageModel
    /// </summary>
    public interface IMessageModel
    {
        int MessageID { get; set; }
        int? ProjectID { get; set; }
        int UserID { get; set; }
        string Message { get; set; }
        DateTime MessageDate { get; set; }
        string? UserName { get; set; }
    }
}