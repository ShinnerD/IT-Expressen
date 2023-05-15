using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface IInvitesModel
    {
        DateTime AcceptDate { get; set; }
        DateTime InviteDate { get; set; }
        string? InviteStatus { get; set; }
        int ProjectId { get; set; }
        int UserId { get; set; }
    }

}
