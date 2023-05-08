using Dal.Repository;
using DAL.Linq;
using Interfaces.Models;

namespace Tests
{
    [TestClass]
    public class DbConnectionTest
    {
        [TestMethod]
        public void DBConnectionTest()
        {
            var DbConnection = new DataClassesDataContext(DbConnectionString.ConnectionString);

            Assert.IsTrue(DbConnection.DatabaseExists());
        }
    }
}