using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Domain.Models
{


    /// <summary>
    /// written by Erik.Model too Invites that have atrributes that is relavent too the case and project. the domain is making a architecture bridge with the DAL and Interface Models
    /// </summary>
    public class InvitesModel //Invites
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime InviteDate { get; set; }
        public bool? InviteStatus { get; set; } 
        public DateTime AcceptDate { get; set; }

    }
}
