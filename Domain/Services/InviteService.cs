﻿using DAL.Repository;
using Interfaces.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Domain.Services
{
    public class InviteService : IInviteService
    {
        private readonly IInvitesRepository InvRepo;
        private readonly IDomainServiceManager DomainServiceManager;

        public InviteService(IDomainServiceManager domainServiceManager, IDataContextManager dataContextManager)
        {
            DomainServiceManager = domainServiceManager;
            InvRepo = new InvitesRepository(dataContextManager);
        }

        /// <summary>
        /// Returns a list of all invites in the database.
        /// </summary>
        /// <returns></returns>
        public List<IInvitesModel> GetAllInvites()
        {
            return AssignDomainProperties(InvRepo.GetAllInvites());
        }

        /// <summary>
        /// Returns a list of all invites related to a specific project Id.
        /// </summary>
        public List<IInvitesModel> GetAllInvitedProjectID(int ProjectID)
        {
            return AssignDomainProperties(InvRepo.GetAllInviteProjectID(ProjectID));
        }

        /// <summary>
        /// Getting a list off all invites with a specific UserId
        /// </summary>
        public List<IInvitesModel> GetInvitesFromUserId(int id)
        {
            return AssignDomainProperties(InvRepo.GetAllInviteUserId(id));
        }

        /// <summary>
        /// Updates the details of an invite in the database according to userId and projectId. /MS
        /// </summary>
        public void UpdateInviteStatus(IInvitesModel inviteModel, int projectID)
        {
            InvRepo.UpdateInviteStatus(inviteModel, projectID);
        }

        /// <summary>
        ///  Adds an invitation to a project, the invited consultants userID is stored /MS
        /// </summary>
        public void AddInvites(int ProjectID, int UserID, DateTime inviteDate, string InviteStatus)
        {
            IInvitesModel newInvite = new DAL.Models.InvitesModel();

            newInvite.ProjectId = ProjectID;
            newInvite.UserId = UserID;
            newInvite.InviteDate = DateTime.Now;
            newInvite.InviteStatus = InviteStatus;

            InvRepo.AddInvite(newInvite);
        }

        /// <summary>
        /// Private Service Class method that fills additional properties on the IInviteModels that needs to
        /// fetched from other repositories than the InvitesRepository.
        /// </summary>
        private List<IInvitesModel> AssignDomainProperties(List<IInvitesModel> inviteList)
        {
            List<IInvitesModel> invalidInvites = new List<IInvitesModel>();

            foreach (var invite in inviteList)
            {
                AssignDomainProperties(invite);

                //Check to see if an active (undeleted) project is connected to the invite, if there isn't (I.e. the project title is null)
                //then the invite is added to a list that subtracted from the result before returning the result.
                if (invite.ProjectTitle == null)
                {
                    invalidInvites.Add(invite);
                }
            }

            return inviteList.Except(invalidInvites).ToList();
        }

        /// <summary>
        /// Private Service Class method that fills additional properties on the IInviteModels that needs to
        /// fetched from other repositories than the InvitesRepository.
        /// </summary>
        private void AssignDomainProperties(IInvitesModel invite)
        {
                var invitedUser = DomainServiceManager.UserService.GetUserFromID(invite.UserId);
                var invitedToProject = DomainServiceManager.ProjectService.GetProject(invite.ProjectId);
                DomainServiceManager.SpecializationService.FillUserSpecializationsProperty(new List<IUserModel>() { invitedUser });

            if (invitedUser != null && invitedToProject != null)
            {
                invite.InvitedUserName = invitedUser.UserName;
                invite.InvitedUserSpecializations = invitedUser.Specializations;
                invite.ProjectTitle = invitedToProject.Title;
                invite.ManagerName = invitedToProject.ManagerFullName;
            }
        }
    }
}