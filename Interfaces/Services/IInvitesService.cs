using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IInviteService
    {
        List<IInvitesModel> GetAllInvites();
        List<IInvitesModel> GetAllInvitedProjectID(int ProjectID);
        IInvitesModel GetInvitedProjectId(int ProjectID);
        IInvitesModel GetInvitedUserID(int id);
    }
}
