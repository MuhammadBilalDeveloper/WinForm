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
             ICustomerRepositry _customerRepositry = new MySQLServerCustomerRepositry();
            Customer customerobj = new Customer();
            DataTable dataTable = new DataTable();
            // Act
            dataTable = _customerRepositry.GetCustomer(customerobj);
            // Assert
            Assert.IsTrue(dataTable.Rows.Count > 0);

        }
        [TestMethod]
        public void SaveCustomer_Any_ReturnsNumberofRows()
        {
            // Arrange
            ICustomerRepositry _customerRepositry = new MySQLServerCustomerRepositry();
            Customer customerobj = new Customer() 
            {
                CustomerID = "Test",
                CompanyName ="Test",
                ContactName = "Test",
                ContactTitle = "Test",
                Address      = "Test",
                City = "Test",
                Region = "Test",
                PostalCode = "Test",
                Country = "Test",
                Phone = "Test",
                Fax = "Test"
            };

            int rowsaffected = 0;
            // Act
            rowsaffected = _customerRepositry.SaveUpdateCustomer(customerobj);
            // Assert
            Assert.IsTrue(rowsaffected > 0);

        }
        [TestMethod]
        public void UpdateCustomer_Any_ReturnsNumberofRows()
        {
            // Arrange
            ICustomerRepositry _customerRepositry = new MySQLServerCustomerRepositry();
            Customer customerobj = new Customer()
            {
                CustomerID = "Test",
                CompanyName = "Test Updated",
                ContactName = "Test Updated",
                ContactTitle = "Test Updated",
                Address = "Test Updated",
                City = "Test Updated",
                Region = "Test Updated",
                PostalCode = "Test Updated",
                Country = "Test Updated",
                Phone = "Test Updated",
                Fax = "Test Updated"
            };

            int rowsaffected = 0;
            // Act
            rowsaffected = _customerRepositry.SaveUpdateCustomer(customerobj);
            // Assert
            Assert.IsTrue(rowsaffected > 0);

        }
        [TestMethod]
        public void DeleteCustomer_Any_ReturnsNumberofRows()
        {
            // Arrange
            ICustomerRepositry _customerRepositry = new MySQLServerCustomerRepositry();
            Customer customerobj = new Customer()
            {
                CustomerID = "Test",
            };

            int rowsaffected = 0;
            // Act
            rowsaffected = _customerRepositry.DeleteCustomer(customerobj);
            // Assert
            Assert.IsTrue(rowsaffected > 0);

        }
    }
}
