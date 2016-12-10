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
        private IOrders _orders;
        private ICooks _cooks;
        private ICustomers _customers;
        private IToppings _toppings;
        private IPizzas _pizzas;
        private ISauces _sauces;
        private ICrusts _crusts;
        private IMenuListings _menuListings;
        private ISizes _sizes;
        private ILines _lines;
        private IOrderLines _orderLines;
        private IPizzaToppings _pizzaToppings;
        private Anchovy.API.Client.Models.Customer _currentCusty;

        public AnchovyCustomerMainGUI(Anchovy.API.Client.Models.Customer currentCustomer)
        {
            _orders = new AnchovyAPIService().Orders;
            _cooks = new AnchovyAPIService().Cooks;
            _customers = new AnchovyAPIService().Customers;
            _toppings = new AnchovyAPIService().Toppings;
            _pizzas = new AnchovyAPIService().Pizzas;
            _sauces = new AnchovyAPIService().Sauces;
            _crusts = new AnchovyAPIService().Crusts;
            _menuListings = new AnchovyAPIService().MenuListings;
            _sizes = new AnchovyAPIService().Sizes;
            _lines = new AnchovyAPIService().Lines;
            _orderLines = new AnchovyAPIService().OrderLines;
            _pizzaToppings = new AnchovyAPIService().PizzaToppings;
            _currentCusty = currentCustomer;
            InitializeComponent();
            fillOutFields();
            var pizzaToppings = _toppings.GetToppings();
            
            foreach (var ptopping in pizzaToppings)
            {
                allToppings.Items.Add(new ListViewItem(ptopping.Name));
            }
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

        private void addOne_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(allToppings, selectedToppings);
        }

        private void removeOne_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(selectedToppings, allToppings);
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            MoveAllListBoxItems(allToppings, selectedToppings);
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            MoveAllListBoxItems(selectedToppings, allToppings);
        }

        private void MoveAllListBoxItems(ListBox source, ListBox destination)
        {
            foreach (var item in source.Items)
            {
                destination.Items.Add(item);
            }
            source.Items.Clear();
        }
    }
}
