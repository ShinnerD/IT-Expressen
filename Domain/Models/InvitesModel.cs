using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// written by Erik. Model too Invites that have atrributes that is relavent too the case and project
/// </summary>

namespace Domain.Models
{
    internal class InvitesModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime InviteDate { get; set; }
        public string InviteStatus { get; set; }
        public DateTime AcceptDate { get; set; }

    }
}
