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

namespace BankAppWinForm
{
    public partial class Register : Form
    {
        private readonly IBank _bank;
        private readonly ICustomerData _customerData;
        private readonly ICustomer _customer;
        private readonly IValidation _validation;
        private readonly Login _login;
        public static bool successAlert = false;
        public Register(IBank bank, IValidation validation, ICustomerData customerData, 
                            ICustomer customer, Login login)
        {
            InitializeComponent();
            _bank = bank;
            _validation = validation;
            _customerData = customerData;
            _customer = customer;
            _login = login;
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SwitchToLogin();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var firstname = textBox1.Text;
            var lastname = textBox4.Text;
            var email = textBox2.Text;
            var password = textBox3.Text;
            //var val = new Validation();
            if(!_validation.ValidateName(firstname))
            {
                MessageBox.Show("Firstname format not valid");
                return;
            }
            if (!_validation.ValidateName(lastname))
            {
                MessageBox.Show("Lastname format not valid");
                return;
            }
            if (!_validation.ValidateEmail(email))
            {
                MessageBox.Show("Email format not valid");
                return;
            }
            if (!_validation.ValidatePassword(password))
            {
                MessageBox.Show("Password format not valid");
                return;
            }
            
            int lastId = _customerData.LastId()+1;
            
            var newCustomer = _bank.NewCustomer(lastId, firstname, lastname, email, password);
            
            if (newCustomer)
            {
                MessageBox.Show("Successfully registered!");
                SwitchToLogin();
                Hide();
            }else
            {
                MessageBox.Show("Unable to Register please try again");
            }
            //var customer = new Customer(firstname, lastname, email, password);
            
        }

        private void SwitchToLogin()
        {
            _login.Show();
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*'; textBox3.PasswordChar = '*';
           // successAlertPanel.Visible = false;

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var firstname = textBox1.Text;
            var lastname = textBox4.Text;
            var email = textBox2.Text;
            var password = textBox5.Text;
            var password2 = textBox3.Text;
            //var val = new Validation();

            RegisterPageAlert.ForeColor = Color.Red;

            if (!_validation.ValidateName(firstname))
            {
                RegisterPageAlert.Text = "Firstname format not valid";
                return;
            }
            if (!_validation.ValidateName(lastname))
            {
                RegisterPageAlert.Text = "Lastname format not valid";
                return;
            }
            if (!_validation.ValidateEmail(email))
            {
                RegisterPageAlert.Text = "Email format not valid";
                return;
            }
            if (!_validation.ValidatePassword(password))
            {
                RegisterPageAlert.Text = "Password format not valid";
                return;
            }
            else if(password != password2)
            {
                RegisterPageAlert.Text = "Password does not match";
                return;
            }

            int lastId = _customerData.LastId() + 1;

            var newCustomer = _bank.NewCustomer(lastId, firstname, lastname, email, password);

            if (newCustomer)
            {
                RegisterPageAlert.ForeColor = Color.Green;

                // successAlert.Text += ("...");

                // Thread.Sleep(100);
                //RegisterPageAlert.Text = ("Successfully registered!");
                RegisterPageAlert.Text = ("Successfully registered!");
                //ogin.Show()
               // Thread.Sleep(5000);

                SwitchToLogin();
                // successAlert = true;
                Hide();
            }
            else
            {
                RegisterPageAlert.Text = "Unable to Register please try again";
            }
       
            //var customer = new Customer(firstname, lastname, email, password);

        }

        //public static void Loading(int timer = 10)
        //{
        //    for(int i = 0; i< timer; i++)
        //    {
        //        Thread.Sleep(300);
        //    }

        //}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SwitchToLogin();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void successAlertPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
