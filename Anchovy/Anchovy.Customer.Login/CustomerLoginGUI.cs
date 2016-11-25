using Anchovy.Customer.ForgotPassword;
using Anchovy.Customer.Main;
using Customer.SignUp;
using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using System.Linq;

namespace Anchovy.Customer.Login
{
    public partial class CustomerLoginGUI : Form
    {
        private ICustomers _customers;
        private AnchovyCustomerMainGUI _main;

        public CustomerLoginGUI()
        {
            InitializeComponent();
            _customers = new AnchovyAPIService().Customers;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var username = usernameBox.Text;
            var password = passwordBox.Text;
            if (username.Trim() == "")
            {
                usernameError.Text = "please enter a username";
            }
            else if (password.Trim() == "")
            {
                usernameError.Text = "";
                passwordError.Text = "please enter a password";
            }
            else
            {
                /*usernameError.Text = "";
                passwordError.Text = "";
                var customers = _customers.GetCustomers();

                if (!customers.Any()) Console.WriteLine("There are no customers in the database");
                else
                {
                    var customer = customers.Where(_ => _.Username == username);

                    if (customer.Any())
                    {
                        if (password == customer.First().Password)
                        {
                            usernameBox.Text = "";
                            passwordBox.Text = "";
                            _main = new AnchovyCustomerMainGUI();
                            _main.Text = "Logged In As - " + customer.First().FirstName;
                            this.Hide();
                            _main.Show();
                        }
                        else
                        {
                            passwordError.Text = "Invalid Password";
                        }
                    }
                    else
                    {
                        usernameError.Text = "Invalid Username";
                    }
                }*/
                _main = new AnchovyCustomerMainGUI();
                //_main.Text = "Logged In As - " + customer.First().FirstName;
                this.Hide();
                _main.Show();
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CustomerSignUpGUI signup = new CustomerSignUpGUI();
            signup.Show();
            this.Hide();
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForgotPasswordGUI forgotPword = new CustomerForgotPasswordGUI();
            forgotPword.Show();
            this.Hide();
        }
    }
}
