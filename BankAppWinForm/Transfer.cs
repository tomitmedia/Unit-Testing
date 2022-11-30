using BankApp.Data;
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

namespace BankAppWinForm
{
    public partial class Transfer : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly Login _login;
        public Transfer(CustomerModel customer, IAccount account, IAccountData accountData, Login login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            transferAlertPanel.Visible = false;
            //selectAcctDrop.Text = Home._selectAcctDrop;
            selectAcctDrop.Text = Home._selectAcctDrop;

            if (selectAcctDrop.Text == "")
            {
                selectAcctDrop.Text = "Select Account";
            }

            var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);

            if (allAcount.Count > 0)
            {
                foreach (var account in allAcount)
                {
                    var AccountNo = account.AccountNo;
                    selectAcctDrop.Items.Add(AccountNo);
                }
            }
        }

        private bool ValidateInput()
        {
            var sender = selectAcctDrop.Text;
            var receiver = textBox2.Text;
            var amount = textBox3.Text;

            if (sender == "" || receiver == "" || amount == "")
            {
            transferAlertPanel.Visible = true;
                transferAlert.Text = "No field should not be empty";
                return false;
            }
           var senderAcct = _accountData.GetAccountByUserIdAndAccountNo(_customer.UserId, sender);
            if(senderAcct == null)
            {
            transferAlertPanel.Visible = true;
                transferAlert.Text = "Not authorized to transfer from this account";
                return false;
            }
            var receiverAcct = _accountData.GetAccountByAccountNo(receiver);
            if(receiverAcct == null)
            {
            transferAlertPanel.Visible = true;
                transferAlert.Text = "This account does not exist";
                return false;
            }
            if(!double.TryParse(amount, out double amt))
            {
            transferAlertPanel.Visible = true;
                transferAlert.Text = "Please put a valid number";
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
           // var acct = selectAcctDrop.Text;

            if (ValidateInput())
            {

                var amount = double.Parse(textBox3.Text);
                if (amount < 0)
                {
            transferAlertPanel.Visible = true;
                    transferAlert.ForeColor = Color.Red;

                    transferAlert.Text = "Cannot transfer amount less than 0";
                    return;
                }
                var transferApproval = _account.Transfer(_customer.UserId, amount, selectAcctDrop.Text, textBox2.Text);
                if (transferApproval)
                {
                    transferAlertPanel.Visible = true;
                    transferAlert.ForeColor = Color.Green;
                    
                    transferAlert.Text = "Transfer successful!";
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                }
                else
                {
                    transferAlertPanel.Visible = true;
                    transferAlert.ForeColor = Color.Red;

                    transferAlert.Text = "Insufficient Balance.";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
