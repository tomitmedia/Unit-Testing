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
    public partial class Deposit : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly Login _login;
        public Deposit(CustomerModel customer, IAccount account, IAccountData accountData, Login login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer,_account,_accountData, _login);
            home.Show();
            Hide();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

            fundAlertPanel.Visible = false;
         
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello there!");
            //var acct = textBox1.Text;
            //  var allAcount =
         
           // else {
             // selectAcctDrop.Text = Home._selectAcctDrop;
              
                var acct = selectAcctDrop.Text;
                // selectAcctDrop.Items =
               // textBox1.PlaceholderText = Home._selectAcctDrop;
               // textBox1.Text = Home._selectAcctDrop;
                var amount = textBox2.Text;
                if (acct == "" || amount == "")
                {
                fundAlertPanel.Visible = true;
                    fundAlert.Text = "Account/Amount can't be empty";
                    return;
                }
                if (!double.TryParse(amount, out double amt))
                {
                fundAlertPanel.Visible = true;

                fundAlert.Text = "Invalid amount";
                    return;
                }

                var confirmDeposit = _account.Deposit(_customer.UserId, acct, amt);
                if (confirmDeposit)
                {
                fundAlertPanel.Visible = true;

                fundAlert.ForeColor = Color.Green;
                    fundAlert.Text = "Deposit Successful";
                    textBox1.Text = "";
                    textBox2.Text = "";
                return;
                }
                fundAlert.ForeColor = Color.Red;
            fundAlertPanel.Visible = true;

            fundAlert.Text = "Unable to deposit in this account";
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void selectedDrop_index(object sender, EventArgs e)
        {
            //.Text = selectAcctDrop.Text;
        }
    }
}
