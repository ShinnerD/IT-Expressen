using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace Interfaces.Repositories
{
    public interface IInvitesRepository
    {
        int ProjectId { get; }

        List<IInvitesModel> GetAllInviteProjectID(int projectid);
        List<IInvitesModel> GetAllInvites();
        IInvitesModel GetInviteProjectId(int ProjectId);
        IInvitesModel GetInviteUserId(int UserId);
        List<IInvitesModel> GetInviteUserIdList(int UserId);
        IInvitesModel GetInviteUserName(string Username);

        void AddInvite(IInvitesModel inviteModel/*, List<string> specializtions*/);
    }
}
