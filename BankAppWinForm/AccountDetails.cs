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
    public partial class AccountDetails : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly Login _login;
        public AccountDetails(CustomerModel customer, IAccount account, IAccountData accountData, Login login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

        //private List<AccountDetailsFormatModel>

        //FULL NAME | ACCOUNT NUMBER | ACCOUNT TYPE | AMOUNT BAL

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            
            var list = new List<AccountDetailsFormatModel>(); 
            var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);
            
            if (allAcount.Count > 0)
            {
                foreach (var account in allAcount)
                {
                    list.Add(new AccountDetailsFormatModel() { Name = _customer.Name, AccountNo = account.AccountNo, AccountType = account.AccountType, Balance = account.Balance });
                }
                dataGridView1.DataSource = list;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var home = new Home(_customer, _account, _accountData, _login);
            home.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
