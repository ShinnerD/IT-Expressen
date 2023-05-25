namespace Interfaces.Models
{
    /// <summary>
    /// written by Erik. Model too  Specialization that have attributes that is relevant too the case and project.
    /// The model that couples with the Interface Repo invites and the Domain Model invites.
    /// </summary>
    public interface IInvitesModel
    {
        DateTime? AcceptDate { get; set; }
        DateTime? InviteDate { get; set; }
        string? InviteStatus { get; set; }
        int ProjectId { get; set; }
        int UserId { get; set; }

        string? InvitedUserName { get; set; }
        string? InvitedUserFullName { get; set; }
        string? InvitedUserSpecializations { get; set; }
        string? ProjectTitle { get; set; }
        string? ManagerName { get; set; }
        decimal? ConLineSum { get; set; }
    }
}