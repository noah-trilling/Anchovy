using CustomerLogin;
using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using System.Web.Services.Description;
using System.Text.RegularExpressions;

namespace CustomerMain
{
    public partial class AnchovyCustomerMainGUI : Form
    {
        private ICustomers _customers;
        private Anchovy.API.Client.Models.Customer _currentCusty;

        public AnchovyCustomerMainGUI(Anchovy.API.Client.Models.Customer currentCustomer)
        {
            _currentCusty = currentCustomer;
            _customers = new AnchovyAPIService().Customers;
            InitializeComponent();
            fillOutFields();
        }

        private void cancelApps_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Hide();
        }

        private void appetizersButton_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void logoutButton2_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void logoutButton3_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }

        private void cancelInfo_Click(object sender, EventArgs e)
        {
            var reload = _customers.GetCustomer((int)_currentCusty.Id);
            AnchovyCustomerMainGUI login = new AnchovyCustomerMainGUI(reload);
            login.Show();
            this.Hide();
        }

        private void fillOutFields()
        {
            infoFirstName.Text = "";
            infoMiddleName.Text = "";
            infoLastName.Text = "";
            infoAddress.Text = "";
            infoCity.Text = "";
            infoState.Text = "";
            infoPhone.Text = "";
            infoEmail.Text = "";
            infoUsername.Text = "";
            infoPassword1.Text = "";
            infoPassword2.Text = "";

            if (_currentCusty.FirstName != null) infoFirstName.Text = _currentCusty.FirstName;
            if (_currentCusty.MiddleName != null) infoMiddleName.Text = _currentCusty.MiddleName;
            if (_currentCusty.LastName != null) infoLastName.Text = _currentCusty.LastName;
            if (_currentCusty.Address != null) infoAddress.Text = _currentCusty.Address;
            if (_currentCusty.City != null) infoCity.Text = _currentCusty.State;
            if (_currentCusty.State != null) infoState.Text = _currentCusty.State;
            if (_currentCusty.Phone != null) infoPhone.Text = _currentCusty.Phone;
            if (_currentCusty.Email != null) infoEmail.Text = _currentCusty.Email;
            if (_currentCusty.Username != null) infoUsername.Text = _currentCusty.Username;
            if (_currentCusty.Password != null) infoPassword1.Text = _currentCusty.Password;
        }

        private void updateInfo_Click(object sender, EventArgs e)
        {
            if (infoPassword1.Text == "" && infoPassword2.Text == "")
            {
                infoError.Text = "password field cannot be empty";
            }
            else if (infoPassword1.Text == infoPassword2.Text)
            {
                infoError.Text = "information updated successfully!";
                _currentCusty.FirstName = infoFirstName.Text;
                _currentCusty.MiddleName = infoMiddleName.Text;
                _currentCusty.LastName = infoLastName.Text;
                _currentCusty.Address = infoAddress.Text;
                _currentCusty.City = infoCity.Text;
                _currentCusty.State = infoState.Text;
                Regex digitsOnly = new Regex(@"[^\d]");
                _currentCusty.Phone = digitsOnly.Replace(infoPhone.Text, "");
                _currentCusty.Email = infoEmail.Text;
                _currentCusty.Username = infoUsername.Text;
                _currentCusty.Password = infoPassword1.Text;

                var putResp = _customers.PutCustomer((int)_currentCusty.Id, _currentCusty);
                _currentCusty = _customers.GetCustomer((int)_currentCusty.Id);
                fillOutFields();
            }
            else if (infoPassword1.Text != infoPassword2.Text)
            {
                infoError.Text = "passwords do not match.";
            } 
        }
    }
}
