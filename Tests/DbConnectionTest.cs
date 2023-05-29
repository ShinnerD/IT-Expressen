using DAL.Repository;
using DAL.Linq;
using Interfaces.Models;

namespace Tests
{

   
    [TestClass]
    public class DbConnectionTest
    {
        /// <summary>
        /// Small test that the database is being contacted correctly when initializing a new instance of the database data context.
        /// Useful for determining if exceptions are being thrown because of a database connection issue or code issues. /Dennis Kempf
        /// </summary>
        [TestMethod]
        public void DBConnectionTest()
        {
            var DbConnection = new DataClassesDataContext(DbConnectionString.ConnectionString);

            Assert.IsTrue(DbConnection.DatabaseExists());
        }
    }
}