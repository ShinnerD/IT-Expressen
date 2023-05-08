namespace Interfaces.Models
{
    public interface IConsultant
    {
        bool ActiveStatus { get; set; }
        string Street_Address { get; set; }
        DateTime Creation_Date { get; set; }
        int HourRate { get; set; }
        int HoursSpendt { get; set; }
        int ID { get; set; }
        int LastName { get; set; }
        string Mail { get; set; }
        string Name { get; set; }
        string NameCity { get; set; }
        string Password { get; set; }
        int Specialization { get; set; }
        int TLF { get; set; }
        int TotalEarnings { get; set; }
        string UserType { get; set; }
        int ZipCode { get; set; }
    }
}
