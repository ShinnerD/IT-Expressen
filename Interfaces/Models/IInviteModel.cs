using Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    /// <summary>
    /// written by Erik. Model too  Specialisation that have atrributes that is relavent too the case and project. the model that couples with the Interface Repo inites and the Domain Model invites.
    /// </summary>
    public interface IInvitesModel
    {
        DateTime AcceptDate { get; set; }
        DateTime InviteDate { get; set; }
        string? InviteStatus { get; set; }
        int ProjectId { get; set; }
        int UserId { get; set; }
        string UserName { get; }
    }

}
