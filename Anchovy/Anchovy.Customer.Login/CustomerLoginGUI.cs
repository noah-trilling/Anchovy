using CustomerForgotPassword;
using CustomerMain;
using CustomerSignUp;
using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using Anchovy.API.Client.Models;
using System.Linq;

namespace CustomerLogin
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
                usernameError.Text = "";
                passwordError.Text = "";
                var customers = _customers.GetCustomers();

                if (!customers.Any()) Console.WriteLine("There are no customers in the database");
                else
                {
                    try
                    {
                        var customer = customers.Where(_ => _.Username == username);

                        if (customer.Any())
                        {
                            if (password == customer.First().Password)
                            {
                                usernameBox.Text = "";
                                passwordBox.Text = "";
                                _main = new AnchovyCustomerMainGUI(customer.First());
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
                    } catch (Exception a)
                    {
                        usernameError.Text = "Error logging in.";
                    }
                }
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

        private void guestCheckout_Click(object sender, EventArgs e)
        {
            var postResponse = generateGuest();
            while (postResponse.Id == null)
            {
                postResponse = generateGuest();
            }
            _main = new AnchovyCustomerMainGUI(postResponse);
            _main.Text = "Logged In As - " + postResponse.Username;
            this.Hide();
            _main.Show();
        }

        private Anchovy.API.Client.Models.Customer generateGuest()
        {
            Random rnd = new Random();
            var randString = "Guest-";
            for (int i = 0; i < 15; i++)
            {
                randString += rnd.Next(0, 9);
            }
            var customer1 = new Customer
            {
                Username = randString
            };
            customer1.FirstName = "Guest";
            return _customers.PostCustomer(customer1);
        }
    }
}
