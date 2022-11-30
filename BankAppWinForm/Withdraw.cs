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
    public partial class Withdraw : Form
    {
        private readonly CustomerModel _customer; 
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly Login _login;
        public Withdraw(CustomerModel customer, IAccount account, IAccountData accountData, Login login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
          
        //}

        //private void label5_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Withdraw_Load(object sender, EventArgs e)
        {
           // selectAcctDrop.Text = Home._selectAcctDrop;
            withdrawalAlertPanel.Visible = false;
            DoneAlert.Visible = false;
            failedAlert.Visible = false;

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
            withdrawalAlert.ForeColor = Color.Red;

            var acct = selectAcctDrop.Text;

           // var acct = textBox1.Text;
            var amount = textBox2.Text;
            if (acct == "" || amount == "")
            {
                failedAlert.Visible = true;
                withdrawalAlertPanel.Visible = true;
                    DoneAlert.Visible=false;
                withdrawalAlert.Text = "Account/Amount can't be empty";
                return;
            }
            if (!double.TryParse(amount, out double amt)|| double.Parse(amount) <= 0)
            {
                withdrawalAlertPanel.Visible = true;
                failedAlert.Visible = true;
                DoneAlert.Visible = false;


                withdrawalAlert.Text = "Amount must be a valid number";
                return;
            }

            var confirmDeposit = _account.Withdrawal(_customer.UserId, acct, amt);
            if (confirmDeposit)
            {
                withdrawalAlertPanel.Visible = true;
                DoneAlert.Visible = true;
                withdrawalAlert.ForeColor = Color.Green;
                withdrawalAlert.Text = ("Take your N" + amount + " cash.");
                textBox1.Text = "";
                textBox2.Text = "";

                return;
            }
                withdrawalAlert.ForeColor = Color.Red;
            withdrawalAlertPanel.Visible = true;
            failedAlert.Visible = true;
            DoneAlert.Visible = false;


            withdrawalAlert.Text= "Insufficient fund";
        }

        //private void pictureBox5_Click(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        //private void fundAlertPanel_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void button5_Click(object sender, EventArgs e)
        //{

        //}
    }
}
