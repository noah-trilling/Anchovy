using Anchovy.API.Client;
using Anchovy.API.Client.Models;
using CustomerLogin;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerSignUp
{
    public partial class CustomerSignUpGUI : Form
    {
        private ICustomers _customers;

        public CustomerSignUpGUI()
        {
            InitializeComponent();
            signUpError.ForeColor = System.Drawing.Color.Red;
            _customers = new AnchovyAPIService().Customers;
        }

        private void cancelSignup_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void signUpSignup_Click(object sender, EventArgs e)
        {
            var username = usernameSignup.Text;
            var password1 = passwordSignup1.Text;
            var password2 = passwordSignup2.Text;
            var email = emailSignup.Text;

            if (username.Trim() == "")
            {
                signUpError.Text = "please enter a username";
            }
            else if (password1.Trim() == "")
            {
                passwordSignup1.Text = "";
                signUpError.Text = "please enter a password";
            }
            else if (password2.Trim() == "")
            {
                signUpError.Text = "please complete all fields";
            }
            else if (email.Trim() == "")
            {
                signUpError.Text = "please enter an email";
            }
            else if (!email.Contains('@') || !email.Contains('.'))
            {
                signUpError.Text = "please enter a valid email format";
            }
            else if (password1 != password2)
            {
                signUpError.Text = "passwords do not match";
            }
            else
            {
                signUpError.Text = "Creating account...";
                var customer1 = new Customer
                {
                    Email = email,
                    Username = username,
                    Password = password1,
                };
                var postResponse = _customers.PostCustomer(customer1);
                if (postResponse.Id != null)
                {
                    signUpError.ForeColor = System.Drawing.Color.Green;
                    signUpError.Text = "Account created successfully!";
                    CustomerLoginGUI login = new CustomerLoginGUI();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    signUpError.Text = "Error creating account.  Please try again.";
                    usernameSignup.Text = "";
                    passwordSignup1.Text = "";
                    passwordSignup2.Text = "";
                    emailSignup.Text = "";
                }
            }
        }
    }
}
