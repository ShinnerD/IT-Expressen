using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Linq;
using Interfaces.Models;
using System.Reflection;
using Interfaces.Repositories;
using DAL.Models;
///Writen by Erik

namespace DAL.Repository
{
   

    public class InvitesRepository : IInvitesRepository
    {


        DataClassesDataContext DataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);

        public int ProjectId { get; private set; }

        public List<IInvitesModel> GetAllInvites()
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            var dbInvites = DataContext.Invites;
            foreach (var dbInvite in dbInvites)
            {
                IInvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);


            }
            return result;





        }

        public List<IInvitesModel> GetAllInviteProjectID(int projectid)
        {
            List<IInvitesModel> result = new List<IInvitesModel>();

            var dbInvites = DataContext.Projects.FirstOrDefault(i => i.Project_ID == projectid).Invites;

            foreach (var dbInvite in dbInvites)
            {
                IInvitesModel Invite = new InvitesModel();

                Invite.ProjectId = dbInvite.Project_ID;
                Invite.UserId = dbInvite.User_ID;
                Invite.InviteDate = (DateTime)dbInvite.Invite_Date;
                Invite.InviteStatus = dbInvite.Invite_status;
                Invite.AcceptDate = (DateTime)dbInvite.Accept_date;

                result.Add(Invite);


            }
            return result;

        }
        public IInvitesModel GetInviteProjectId(int ProjectId)
        {
            IInvitesModel result = new InvitesModel();

            var dbInvite = DataContext.Invites.FirstOrDefault(i => i.Project_ID == ProjectId);

            result.ProjectId = dbInvite.Project_ID;
            result.UserId = dbInvite.User_ID;
            result.InviteDate = (DateTime)dbInvite.Invite_Date;
            result.InviteStatus = dbInvite.Invite_status;
            result.AcceptDate = (DateTime)dbInvite.Accept_date;

            return result;


        }
        public IInvitesModel GetInviteUserId(int UserId)
        {
            IInvitesModel result = new InvitesModel();

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
      

