namespace Interfaces.Models
{
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