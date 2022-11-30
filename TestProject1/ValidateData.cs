


using BankApp.Implementations;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



namespace BankAppTest
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public void ValidateEmail()
        {

            //Arrange
            var result = new Validation();
            string expected = "tom@gmail.com";



            //Act



            bool actual = result.ValidateEmail(expected);



            //Assert
            Assert.IsTrue(actual);




        }
        [Test]
        public void ValidatePassword()
        {
            //Arrange
            var result = new Validation();



            //Act
            var output = result.ValidatePassword(password: "Femi@1");



            //Assert
            Assert.AreEqual(output, true);
        }
        [Test]
        public void ValidateName()
        {
            //Arrange
            var result = new Validation();



            //Act
            var output = result.ValidateName(name: "Tom");



            //Assert
            Assert.IsTrue(true);
        }




    }
}
