using Anchovy.API.Client;
using CustomerLogin;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using Twilio;
using System.Text.RegularExpressions;
using System.Net;

namespace CustomerForgotPassword
{
    public partial class CustomerForgotPasswordGUI : Form
    {
        private ICustomers _customers;

        public CustomerForgotPasswordGUI()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            forgotPhone.Enabled = false;
            forgotMessage.ForeColor = System.Drawing.Color.Red;
            _customers = new AnchovyAPIService().Customers;
        }

        private void cancelForgot_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void sendForgot_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
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
                            try
                            {
                                MailMessage message = new System.Net.Mail.MailMessage();
                                string fromEmail = "anchovy.app.email@gmail.com";
                                string fromPW = "p1n34ppl3";
                                string toEmail = email;
                                message.From = new MailAddress(fromEmail);
                                message.To.Add(toEmail);
                                message.Subject = "Your Anchovy Password";
                                message.Body = "Your current Anchovy password is: " + customer.First().Password;
                                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtpClient.EnableSsl = true;
                                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                                    smtpClient.UseDefaultCredentials = false;
                                    smtpClient.Credentials = new NetworkCredential(fromEmail, fromPW);

                                    smtpClient.Send(message.From.ToString(), message.To.ToString(),
                                                    message.Subject, message.Body);
                                }
                                forgotMessage.ForeColor = System.Drawing.Color.Green;
                                forgotMessage.Text = "Password sent sucessfully!";
                            }
                            catch (Exception a)
                            {
                                forgotMessage.Text = "Error sending password.";
                            }
                        }
                        else
                        {
                            forgotMessage.Text = "No customer with that email.";
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                var phone = forgotPhone.Text;
                if (phone.Trim() == "")
                {
                    forgotMessage.Text = "please enter a phone number.";
                }
                else
                {
                    var customers = _customers.GetCustomers();

                    if (!customers.Any()) Console.WriteLine("There are no customers in the database");
                    else
                    {
                        var customer = customers.Where(_ => _.Phone == phone);
                        if (customer.Any())
                        {
                            try
                            {
                                var client = new TwilioRestClient("AC6b1ab19dfbb464b09c38b6d04bd18e83", "2c4498eb9d0953f50fd5bd08e353476f");
                                client.SendMessage("+14149399443", "+1" + phone, "Your current Anchovy password is: " + customer.First().Password);
                                forgotMessage.ForeColor = System.Drawing.Color.Green;
                                forgotMessage.Text = "Password sent sucessfully!";
                            }
                            catch (Exception a)
                            {
                                forgotMessage.Text = "Error sending password.";
                            }
                        }
                        else
                        {
                            forgotMessage.Text = "No customer with that email.";
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            forgotEmail.Enabled = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            forgotPhone.Enabled = radioButton2.Checked;
        }
    }
}
