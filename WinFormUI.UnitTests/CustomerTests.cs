using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using WinFormDAL;
using WinFormEntity;

namespace WinFormUI.UnitTests
{
    [TestClass]
    public class CustomerTests
    {

        [TestMethod]
        public void GetCustomer_Any_ReturnsCustomerList()
        {
            // Arrange
            ICustomerRepositry _customerRepositry = new CustomerRepositry();
            Customer customerobj = new Customer();
            DataTable dataTable = new DataTable();
            // Act
            dataTable = _customerRepositry.GetCustomer(customerobj);
            // Assert
            Assert.IsTrue(dataTable.Rows.Count > 0);

        }
}
}
