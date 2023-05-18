﻿using DAL.Repository;
using Interfaces.Models;

namespace DAL.Models
{
    /// <summary>
    /// written by Erik.Model too Invites that have atrributes that is relavent too the case and project. the model that couples with the DAL Repo invites and the Domain Model invites.
    /// </summary>
    public class InvitesModel : IInvitesModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime InviteDate { get; set; }
        public string? InviteStatus { get; set; }
        public DateTime AcceptDate { get; set; }
        public string UserName { get {return new UserRepository(DAL.DataContextManager.Instance).GetUserFromID(this.UserId).UserName; } }
    }
}