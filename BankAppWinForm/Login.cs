using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankAppWinForm
{
    public partial class Login : Form
    {
        private Register _register;
        private readonly IBank _bank;
        private readonly ICustomerData _customerData;
        private readonly IAccountData _accountData;
        private readonly IValidation _validation;
        private readonly ICustomer _customer;
        private readonly IAccount _account;
        public Login(IBank bank, IValidation validation, ICustomerData customerData,
                            ICustomer customer, IAccount account, IAccountData accountData)
        {
            InitializeComponent();
            _bank = bank;
            _customerData = customerData;
            _validation = validation;
            _customer = customer;
            _register = new Register(_bank, _validation, _customerData, _customer, this);
            _account = account;
            _accountData = accountData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                loginPageAlert.Text = "Invalid Email/Password";

                return;
            }
            var customer = _bank.Login(textBox1.Text, textBox2.Text);
           
            if (customer == null) loginPageAlert.Text = "User does not exist";
            else
            {
                var home = new Home(customer, _account, _accountData,this);
                home.Show();
                Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //showPassword2.Visible = false;
            textBox2.PasswordChar = '*';
            successAlertPanel.Visible = Register.successAlert;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _register.Show(); Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Hover(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.White;
            loginBtn.BackColor = Color.Purple;
        }

        private void RegisterBtn_Hover(object sender, EventArgs e)
        {
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.BackColor = Color.Purple;
        }

        private void RegisterBtn_Leaves(object sender, EventArgs e)
        {
            RegisterBtn.BackColor = Color.White;
            RegisterBtn.ForeColor = Color.Purple;

        }

        private void loginBtn_Leaves(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.White;
            loginBtn.ForeColor = Color.Purple;

        }

        private void loginPageAlert_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_Enters(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = false;
            //textBox2.PasswordChar = char.MinValue;
            //showPassword2.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hidePassword_Leaves(object sender, EventArgs e)
        {
         //   textBox2.PasswordChar = '*';
           // showPassword2.Visible = true;
        }

        private void showPassword2_MouseEnter(object sender, EventArgs e)
        {
      

            // textBox2.PasswordChar = char.MinValue;
        }

        private void hidePassword2_Leaves(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            showPassword2.Visible = true;


        }

        private void showPassword2_Click(object sender, EventArgs e)
        {
           
        }

        private void showPassword2_Hover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = char.MinValue;
            showPassword2.Visible = false;
        }

        private void showPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            //   textBox2.PasswordChar = '*';
            // showPassword2.Visible = true;
        }
    }
}
