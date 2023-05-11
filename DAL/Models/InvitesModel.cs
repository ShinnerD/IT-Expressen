using Interfaces.Models;

namespace DAL.Models
{
    /// <summary>
    /// written by Erik.Model too Invites that have attributes that is relevant too the case and project
    /// </summary>
    public class InvitesModel : IInvitesModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime InviteDate { get; set; }
        public bool? InviteStatus { get; set; }
        public DateTime AcceptDate { get; set; }
    }
}