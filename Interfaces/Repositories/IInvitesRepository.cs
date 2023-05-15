using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;
///Written by Erik
namespace Interfaces.Repositories
{
    public interface IInvitesRepository
    {
        int ProjectId { get; }
        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to AllProjectID provided. 
        /// </summary>
        List<IInvitesModel> GetAllInviteProjectID(int projectid);
        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to the Allinvites provided. 
        /// </summary>
        List<IInvitesModel> GetAllInvites();
        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to ProjectID provided. 
        /// </summary>
        IInvitesModel GetInviteProjectId(int ProjectId);
        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to UserId provided. 
        /// </summary>
        IInvitesModel GetInviteUserId(int UserId);
        IInvitesModel GetInviteUserName(string Username);
        void AddInvite(IInvitesModel inviteModel/*, List<string> specializtions*/);
    }
}
