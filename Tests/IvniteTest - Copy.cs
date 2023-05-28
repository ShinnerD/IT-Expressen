using Domain.Services;
using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class InviteTests
    {
        /// <summary>
        /// Invitation service test. /Erik
        /// </summary>
        [TestMethod]
        public void SendInvitation_WithValidProjectId_ReturnsTrue()
        {
         
            var invitationService = new InvitationService();
            var projectId = "100";

          
            var result = invitationService.SendInvitation(projectId);

           
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SendInvitation_WithInvalidProjectId_ReturnsFalse()
        {
           
            var invitationService = new InvitationService();
            var projectId = "";

            var result = invitationService.SendInvitation(projectId);

            
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class InvitationService
    {
        [TestMethod]
        public bool SendInvitation(string projectId)
        {
            
            if (string.IsNullOrEmpty(projectId))
            {
                return false;
            }

           

            return true;
        }
    }
}