namespace Interfaces.Models
{
    public interface IUserModel
    {
        int ID { get; set; }
        bool? ActiveStatus { get; set; }
        string? UserName { get; set; }
        string? UserType { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? FullName { get { return FirstName + " " + LastName; } }
        string? EMail { get; set; }
        string? PhoneNumber { get; set; }
        string? Address { get; set; }
        string? Country { get; set; }
        string? NameCity { get; set; }
        string? ZipCode { get; set; }
        DateTime? CreationDate { get; set; }
        string? Specializations { get; set; }
        string? Password { get; set; }
    }
}