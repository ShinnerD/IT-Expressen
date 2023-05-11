using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Linq;
using Interfaces.Models;
using Domain.Models;
using System.Reflection;
///Writen by Erik

namespace DAL.Repository
{
    public class InvitesRepository
    {


        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public int ProjectId { get; private set; }

        public List<InvitesModel> GetAllInvites()
        {
            List<InvitesModel> result = new List<InvitesModel>();

            var dbInvites = DataContext.Invites;
            foreach (var dbInvite in dbInvites)
            {
                InvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);


            }
            return result;





        }

        public List<InvitesModel> GetAllInviteProjectID(int projectid)
        {
            List<InvitesModel> result = new List<InvitesModel>();

            var dbInvites = DataContext.Projects.FirstOrDefault(i => i.Project_ID == projectid).Invites;

            foreach (var dbInvite in dbInvites)
            {
                InvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);


            }
            return result;

        }
            public InvitesModel GetInviteProjectId(int ProjectId)
        {
            InvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.Project_ID == ProjectId);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;


        }
        public InvitesModel GetInviteUserId(int UserId)
        {
            InvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.User_ID == UserId);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;


        }
    }
}
      

