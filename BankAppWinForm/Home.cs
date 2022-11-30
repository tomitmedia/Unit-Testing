using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BankAppWinForm
{
    public partial class Home : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly Login _login;
        public static string _selectAcctDrop ="";
        public Home(CustomerModel customer, IAccount account, IAccountData accountData, Login login )
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
            //_selectAcctDrop = selectAcctDrop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Deposit = new Deposit(_customer,_account, _accountData, _login);
            Deposit.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Home_Load(object sender, EventArgs e)
        {
            if (selectedDrop_index == null)
                selectAcctDrop.Text = "Select Account";
        
        //  selectAcctDrop.SelectedItem = "fff";
        //   var list = new List<AccountDetailsFormatModel>();
        var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);

            if (allAcount.Count > 0)
            {
                foreach (var account in allAcount)
                {
                  var AccountNo = account.AccountNo;
                selectAcctDrop.Items.Add(  AccountNo);
                }
            }



            //  selectAcctDrop.Text = _accountData.GetAllAccountNo);
            // var transactions = _account.GetAllTransactions(_customer.UserId, acct);
            welcomeName.Text = ("Welcome,\n"+_customer.Name);
            label3.Text = _customer.Name;
            emailDisplay.Text = _customer.Email;
            homeAlertPanel.Visible = false;
            //openAcctAlertPanel.Visible = false;


           // acctDisplay.Text = _accountData.GetAccountByAccountNo(_customer.UserId);
           dateN.Text = DateTime.Now.ToString("dddd\nMMMM dd\ntt h:mm");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Deposit = new Withdraw(_customer, _account, _accountData, _login);
            Deposit.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var SOA = new SOAInput(_customer,_account,_accountData, _login);
            SOA.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var AcctDetails = new AccountDetails(_customer, _account, _accountData, _login);
            var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);
            if(allAcount.Count > 0)
            {
                AcctDetails.Show();
                Hide();
                
            }else
            {
                homeAlertPanel.Visible = true;   
                homeAlert.Text = "You need to Open Account first";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var createAcct = new CreateAccount(_customer, _account, _accountData, _login);
            createAcct.Show();
            Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _login.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var createAcct = new Transfer(_customer, _account, _accountData, _login);
            createAcct.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            _login.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _login.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectedDrop_index(object sender, EventArgs e)
        {
            accNoDisplay.Text = selectAcctDrop.Text;
            if (accNoDisplay.Text == selectAcctDrop.Text)
            {
                var allAcount2 = _accountData.GetAccountByAccountNo(accNoDisplay.Text);
                //   foreach (var account2 in allAcount2)
                // {
                welcomeName.Visible = false;
                acctypeDisplay.Text = allAcount2.AccountType;
                acctDisplay.Text = allAcount2.Balance.ToString();
                acctUnitNGN.Text = "NGN";
                _selectAcctDrop = selectAcctDrop.Text;

                //}
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void welcomeName_Click(object sender, EventArgs e)
        {

        }
    }
}
