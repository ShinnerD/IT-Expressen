﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Domain.Models
{
  

    /// <summary>
    /// written by Erik.Model too Invites that have atrributes that is relavent too the case and project
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
