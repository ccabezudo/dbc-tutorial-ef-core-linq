using DBC.Training.EF.Core.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DBC.Taining.EF.Core.Linq.Test
{
    [TestClass]
    public class Customers_Test
    {
        [TestMethod]
        public void GetAllCustomers_Test()
        {
            var repository = new DataRepository();
            repository.InitCustomer();

            var result = repository.GetAllCustomers();
            Assert.AreEqual(result.Count, 4);
        }

        [TestMethod]
        public void GetCustomerByZipCode_Test()
        {
            var repository = new DataRepository();
            repository.InitCustomer();

            var result = repository.GetCustomerByZipCode("00956");
            Assert.AreEqual(result.Count, 2);
        }

        [TestMethod]
        public void GetCustomerByAreaCode_Test()
        {
            var repository = new DataRepository();
            repository.InitCustomer();

            var result = repository.GetCustomerByAreaCode("787");
            Assert.AreEqual(result.Count, 2);
        }


        [TestMethod]
        public void GetCustomerByAreaCode_Test_ZeroResult()
        {
            var repository = new DataRepository();
            repository.InitCustomer();

            var result = repository.GetCustomerByAreaCode("XXX");
            Assert.AreEqual(result.Count, 0);
        }



    }
}
