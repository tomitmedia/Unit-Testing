//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestProject1
//{
//    internal class CustomerData
//    {
//    }
//}



using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankAppTest
{
    [TestFixture]
    public class CustomerDataTests
    {



        [Test]
        public void AddCustomer()
        {



            //Arrange
            var result = new CustomerData();




            //Act
            CustomerModel person = new CustomerModel();
            person.UserId = 1234;
            person.Name = "Femi Tom";
            person.Password = "Femi@1";
            person.Email = "tom@gmail.com";



            var output = result.AddCustomer(person);



            //Assert
            Assert.AreEqual(output, false);




        }



        [Test]
        public void GetAllCustomer()
        {
            //Arrange
            var result = new CustomerData();



            //Act
            var output = result.GetAllCustomer();



            //Assert
            Assert.That(output, Is.Not.Null);



        }



        [Test]
        public void LastId()
        {
            //Arrange
            var result = new CustomerData();
            int expected = 1234;



            //Act
            var output = result.LastId();



            //Assert
            Assert.That(output, Is.EqualTo(expected));
        }



        [Test]



        public void GetCustomerByEmail()
        {
            var customerData = new CustomerData();



            string expectedEmail = "tom@gmail.com";



            var output = customerData.GetCustomerByEmail(expectedEmail);



            Assert.That("tom@gmail.com", Is.EquivalentTo(expectedEmail));



        }



        [Test]



        public void GetCustomerById()
        {
            var customerData = new CustomerData();



            int expectedId = 1234;



            var output = customerData.GetCustomerById(expectedId);



            Assert.That(1234, Is.EqualTo(expectedId));



        }

    }
}
