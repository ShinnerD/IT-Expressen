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
        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to AllProjectID provided. 
        /// </summary>
        List<IInvitesModel> GetAllInviteProjectID(int projectid);

        /// <summary>
        /// Returns a List of IInvitesRepository with projects related to the Allinvites provided. 
        /// </summary>
        List<IInvitesModel> GetAllInvites();

        /// <summary>
        /// Getting the first invite from the database with a specific ProjectID
        /// </summary>
        IInvitesModel GetInviteProjectId(int ProjectId);

        /// <summary>
        /// Getting the first invite in the database with a specific UserId 
        /// </summary>
        IInvitesModel GetInviteUserId(int UserId);

        List<IInvitesModel> GetAllInviteUserId(int UserId);
        IInvitesModel GetInviteUserName(string Username);
        void UpdateInviteStatus(IInvitesModel inviteModel, int ProjectID);

        void AddInvite(IInvitesModel inviteModel/*, List<string> specializtions*/);
    }
}
