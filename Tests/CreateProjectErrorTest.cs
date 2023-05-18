using DAL.Linq;
using DAL.Models;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class CreateProjectErrorTest
    {
        [TestMethod]
        public void TestCreateProjectExceptions()
        {
            IDomainServiceManager serviceManager = new DomainServiceManager();

            var userId = 0;
            var title = "Test";
            var description = "Test";
            List<string> specializations = new List<string>();

            var startDate = DateTime.Parse("1/1/2020");
            var endDateBeforeStartDate = DateTime.Parse("1/1/1990"); //<-- EndDate is before start date
            var startDateNull = default(DateTime);
            var endDateNull = default(DateTime);
            var endDateIsBeforeNow = startDate;

            Action scenarioEndDateBeforeStartDate = () => serviceManager.ProjectService.CreateProject(userId, title, description, startDate, endDateBeforeStartDate, specializations);
            Action scenarioDatesAreNull = () => serviceManager.ProjectService.CreateProject(userId, title, description, startDateNull, endDateNull, specializations);
            Action scenarioEndDateIsBeforeNow = () => serviceManager.ProjectService.CreateProject(userId, title, description, startDate, endDateIsBeforeNow, specializations);

            Assert.ThrowsException<ArgumentException>(scenarioEndDateBeforeStartDate);
            Assert.ThrowsException<ArgumentException>(scenarioDatesAreNull);
            Assert.ThrowsException<ArgumentException>(scenarioEndDateIsBeforeNow);
        }
    }
}
