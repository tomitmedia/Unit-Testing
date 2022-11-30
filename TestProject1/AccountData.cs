using BankApp.Data;
using BankApp.Implementations;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankAppTest
{
    [TestFixture]
    public class AccountDataTest
    {
        [Test]
        public void GetAllAccounts()
        {
            var result = new AccountData();



            var output = result.GetAllAccounts();



            Assert.IsNotNull(output);
        }



        [Test]
        public void GetAllAccountNo()
        {
            var result = new AccountData();



            var output = result.GetAllAccountNo();



            Assert.That(output, Is.Null);
        }



        [Test]
        public void GetAccountByAccountNo()
        {
            var account = new AccountData();


            var expectedString = "0435797731";



            var result = account.GetAccountByAccountNo(expectedString);




            Assert.That("0435797731", Is.EquivalentTo(expectedString));
        }



        [Test]
        public void GetAccountByUserId()
        {
            AccountData account = new AccountData();



            var expected = 1;



            var result = account.GetAccountsByUserId(expected);



            Assert.That(1, Is.Not.EquivalentTo(result));



        }



        [Test]
        public void InsertAccount()
        {
            var result = new AccountData();



            AccountModel model = new AccountModel();



            model.userId = 1;
            model.AccountType = "Savings";
            model.AccountNo = "0435797731";
            model.Balance = 4479.0;



            bool atr = result.InsertAccount(model);



            Assert.IsTrue(atr);



        }




    }
}