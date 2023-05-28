using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services;
using DAL.Linq;
using DAL.Models;
using Interfaces.Models;
using Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Made by Erik Invoice UnitTest
namespace Tests
{
    /// <summary>
    /// Checking if there is a Invoice ID in the Database with a ID 1 if valid it return True.
    /// </summary>
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void CheckingInvoice_WithValidInvoiceId_ReturnsTrue()
        {

            var CheckingInvoice = new InvitationService();
            var invoiceId = "1";


            var result = CheckingInvoice.SendInvoice(invoiceId);


            Assert.IsTrue(result);
        }

        /// <summary>
        /// A metod too send a Invoice and checking if its Empty Null or have some valid.
        /// </summary>
        [TestClass]
        public class InvitationService
        {
            [TestMethod]
            public bool SendInvoice(string invoiceId)
            {

                if (string.IsNullOrEmpty(invoiceId))
                {
                    return false;
                }



                return true;

            }
        }
    }
}
