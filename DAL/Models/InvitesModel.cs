using Interfaces.Models;

namespace DAL.Models
{
    /// <summary>
    /// written by Erik.Model too Invites that have attributes that is relevant too the case and project. the model that couples with the DAL Repo invites and the Domain Model invites.
    /// </summary>
    public class InvitesModel : IInvitesModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime? InviteDate { get; set; }
        public string? InviteStatus { get; set; }
        public DateTime? AcceptDate { get; set; }
        public string? InvitedUserName { get; set; }
        public string? InvitedUserFullName { get; set; }
        public string? InvitedUserSpecializations { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ManagerName { get; set; }
        public decimal? ConLineSum { get; set; }

    }
}