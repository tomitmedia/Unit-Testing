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
    public partial class SOAInput : Form
    {
        private readonly CustomerModel _customer;
            private readonly IAccount _account;
            private readonly IAccountData _accountData;
            private readonly Login _login;
        public SOAInput(CustomerModel customer, IAccount account, IAccountData accountData, Login login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                   }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var acct = selectAcctDrop.Text;
            if (acct == "")
            {
                tHistoryAlertPanel.Visible = true;
                tHistoryAlert.Text = "Provide your account number";
                return;
            }
            var transactions = _account.GetAllTransactions(_customer.UserId, acct);
            if (transactions != null)
            {
                tHistoryAlertPanel.Visible = true;

                dataGridView1.DataSource = transactions;
                tHistoryAlert.Text = "TRANSACTION HISTORY: " + acct;
            //var tableTrans = new SOATable(_customer, _account, _accountData, transactions);

        }

            else {
            tHistoryAlertPanel.Visible = true;
                tHistoryAlert.Text = "No transactions found for this account"; }

        }

        private void SOAInput_Load(object sender, EventArgs e)
        {
            tHistoryAlertPanel.Visible = false;
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
    }
}
