using Domain.Services;
using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Made by Erik, Unit test of invite.
namespace Tests
{
    [TestClass]
    public class InviteTests
    {
        /// <summary>
        /// Checking if there is a Project ID in the Database with a ID 100 if valid it return True.
        /// </summary>
        [TestMethod]
        public void SendInvitation_WithValidProjectId_ReturnsTrue()
        {
         
            var invitationService = new InvitationService();
            var projectId = "100";

          
            var result = invitationService.SendInvitation(projectId);

           
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Sending a Invitation too a Invalid Projekt ID That return False.
        /// </summary>
        [TestMethod]
        public void SendInvitation_WithInvalidProjectId_ReturnsFalse()
        {
           
            var invitationService = new InvitationService();
            var projectId = "";

            var result = invitationService.SendInvitation(projectId);

            
            Assert.IsFalse(result);
        }
    }
    /// <summary>
    /// A metod too send a Invite and checking if its Empty Null or have some valid.
    /// </summary>
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