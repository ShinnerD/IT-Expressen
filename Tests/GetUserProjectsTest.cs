using Domain.Services;

namespace Tests
{
    [TestClass]
    public class GetUserProjectsTest
    {
        /// <summary>
        /// (JQ)This test is checking that the GetUserProjects method is returning a valid list of projects for a given user ID.
        /// It verifies that the returned list is not null and contains at least one project.
        /// </summary>
        [TestMethod]
        public void GetUserProjects_ReturnsProjects()
        {
            // Arrange
            int userId = 1002;
            var projectService = new ProjectService();

            // Act
            var projects = projectService.GetUserProjects(userId);

            // Assert
            Assert.IsNotNull(projects);
            Assert.IsTrue(projects.Count > 0);
        }
    }
}