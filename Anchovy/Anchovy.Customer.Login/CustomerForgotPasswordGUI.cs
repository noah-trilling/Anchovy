using Anchovy.API.Client;
using Anchovy.Customer.Login;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;

namespace Anchovy.Customer.ForgotPassword
{
    public partial class CustomerForgotPasswordGUI : Form
    {
        private ICustomers _customers;
        private MailMessage mail;

        public CustomerForgotPasswordGUI()
        {
            InitializeComponent();
            _customers = new AnchovyAPIService().Customers;
            mail = new MailMessage("anchovy.app.email@gmail.com", "dcfaber@gmail.com");
        }

        private void cancelForgot_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void sendForgot_Click(object sender, EventArgs e)
        {
            var email = forgotEmail.Text;
            if (email.Trim() == "")
            {
                forgotMessage.Text = "please enter an email.";
            }
            else if (!email.Contains("@"))
            {
                forgotMessage.Text = "Please enter a valid email.";
            }
            else
            {
                var customers = _customers.GetCustomers();

                if (!customers.Any()) Console.WriteLine("There are no customers in the database");
                else
                {
                    var customer = customers.Where(_ => _.Email == email);
                    if (customer.Any())
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 25;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("anchovy.app.email@gmail.com", "p1n34ppl3");
                        client.Host = "smtp.google.com";
                        mail.Subject = "this is a test email.";
                        mail.Body = "Password: " + customer.First().Password;
                        client.Send(mail);

                    }
                    else
                    {
                        forgotMessage.Text = "No customer with that email currently registered.";
                    }
                }
            }
        }
    }
}
