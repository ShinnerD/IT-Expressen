using Domain.Services;
using Interfaces.Models;
using Moq;
using Interfaces.Services;
using Interfaces.Repositories;
using DAL.Linq;

namespace Tests
{
    /// <summary>
    /// First attempt at trying to use the Moq Framework to mock classes that are not being tested by using their abstract interfaces.
    /// These tests are for the UpdateUserSpecializations method in the SpecializationService Class. 
    /// Tests various exceptions and that the method updates specializations for a user as expected. /Dennis Kempf
    /// </summary>
    [TestClass]
    public class SpecializationServiceTests
    {
        private Mock<IUserModel> userMock;
        private SpecializationService specializationService;
        private Mock<IDomainServiceManager> serviceManagerMock;
        private Mock<IDataContextManager> dataContextManagerMock;

        [TestInitialize]
        public void Setup()
        {
            userMock = new Mock<IUserModel>();
            serviceManagerMock = new Mock<IDomainServiceManager>();
            dataContextManagerMock = new Mock<IDataContextManager>();

            var mockDataContext = new Mock<DataClassesDataContext>("connection string");
            dataContextManagerMock.Setup(m => m.GetContext()).Returns(mockDataContext.Object);

            specializationService = new SpecializationService(serviceManagerMock.Object, dataContextManagerMock.Object);
        }

        [TestMethod]
        public void UpdateUserSpecializationsNonConsultantThrowsException()
        {
            // Arrange
            userMock.Setup(u => u.UserType).Returns("manager");

            // Act
            Action tryUpdatingAManagersSpecializations = () => specializationService.UpdateUserSpecializations(userMock.Object, new List<string>());

            // Assert
            Assert.ThrowsException<Exception>(tryUpdatingAManagersSpecializations);
        }

        [TestMethod]
        public void UpdateUserSpecializationsNoUserFoundException()
        {
            // Arrange
            userMock.Setup(u => u.UserType).Returns("Consultant");
            userMock.Setup(u => u.ID).Returns(123);
            var specializations = new List<string> { "SpecializationA", "SpecializationB" };
            serviceManagerMock.Setup(s => s.SpecializationService.GetUserSpecializations(123))
                .Returns((List<string>)null);

            // Act
            Action tryUpdatingUserWithInvalidUserId = () => specializationService.UpdateUserSpecializations(userMock.Object, specializations);

            //Assert
            Assert.ThrowsException<Exception>(tryUpdatingUserWithInvalidUserId);
        }

        [TestMethod]
        public void UpdateUserSpecializationsUpdatesUserSpecializations()
        {
            // Arrange
            userMock.Setup(u => u.UserType).Returns("Consultant");
            userMock.Setup(u => u.ID).Returns(123);
            var specializations = new List<string> { "SpecializationA", "SpecializationB" };

            var currentUserSpecializations = new List<string> { "SpecializationC", "SpecializationD" };
            serviceManagerMock.Setup(s => s.SpecializationService.GetUserSpecializations(123))
                .Returns(currentUserSpecializations);

            // Act
            specializationService.UpdateUserSpecializations(userMock.Object, specializations);

            // Assert
            serviceManagerMock.Verify(s => s.SpecializationService.RemoveSpecializationsFromUser(123,
                It.Is<List<string>>(l => l.SequenceEqual(new List<string> { "SpecializationC", "SpecializationD" }))),
                Times.Once);

            serviceManagerMock.Verify(s => s.SpecializationService.AddSpecializationsToUser(123,
                It.Is<List<string>>(l => l.SequenceEqual(new List<string> { "SpecializationA", "SpecializationB" }))),
                Times.Once);
        }
    }
}
