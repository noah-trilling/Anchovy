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
        private Anchovy.API.Client.Models.Order _currentOrder = new Anchovy.API.Client.Models.Order();
        private Anchovy.API.Client.Models.Pizza _currentPizza = new Anchovy.API.Client.Models.Pizza();
        private Anchovy.API.Client.Models.Size thisSize = null;
        private Anchovy.API.Client.Models.Crust thisCrust = null;

        private RadioButton customButton;

        public AnchovyCustomerMainGUI(Anchovy.API.Client.Models.Customer currentCustomer)
        {
            _orders = new AnchovyAPIService().Orders;
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

            int pizzas = addPremadePizzas();
            customButton = new RadioButton();
            customButton.Text = "Custom Pizza";
            customButton.Location = new System.Drawing.Point(20, 20 + (pizzas + 1) * 30);
            this.pizzaGroup.Controls.Add(customButton);
            addSizeButtons();
            addSauceButtons();
            addCrustButtons();
        }

        private void cancelApps_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Hide();
        }

        private void appetizersButton_Click(object sender, EventArgs e)
        {
            checkSize();
            checkCrust();


            if (thisCrust == null)
            {
                orderError.Text = "Please select a crust type.";
            }
            else if (thisSize == null)
            {
                orderError.Text = "Please select a size.";
            } else
            {
                if (customButton.Checked)
                {
                    AppetizersPanel.Show();
                }
            }

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

        private void addSizeButtons()
        {
            var allSizes = _sizes.GetSizes();
            string[] sizeArray = new String[allSizes.Count];
            int i = 0;
            foreach (var s in allSizes)
            {
                sizeArray[i] = s.Name;
                i++;
            }
            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[allSizes.Count];
            for (i = 0; i < allSizes.Count; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = sizeArray[i];
                radioButtons[i].Location = new System.Drawing.Point(10, 10 + i * 20);
                this.sizeGroup.Controls.Add(radioButtons[i]);
            }
        }

        private void addSauceButtons()
        {
            var allSauces = _sauces.GetSauces();
            string[] sauceArray = new String[allSauces.Count];
            int i = 0;
            foreach (var s in allSauces)
            {
                sauceArray[i] = s.Name;
                i++;
            }
            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[allSauces.Count];
            for (i = 0; i < allSauces.Count; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = sauceArray[i];
                radioButtons[i].Location = new System.Drawing.Point(10, 10 + i * 20);
                this.sauceGroup.Controls.Add(radioButtons[i]);
            }
        }

        private void addCrustButtons()
        {
            var allCrusts = _crusts.GetCrusts();
            string[] crustArray = new String[allCrusts.Count];
            int i = 0;
            foreach (var s in allCrusts)
            {
                crustArray[i] = s.Name;
                i++;
            }
            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[allCrusts.Count];
            for (i = 0; i < allCrusts.Count; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = crustArray[i];
                radioButtons[i].Location = new System.Drawing.Point(10, 10 + i * 20);
                this.crustGroup.Controls.Add(radioButtons[i]);
            }
        }

        private int addPremadePizzas()
        {
            var premadePizzas = _pizzaToppings.GetPizzaToppings();
            string[] pizzaArray = new String[premadePizzas.Count];
            string[] descArray = new String[premadePizzas.Count];
            int i = 0;
            foreach (var s in premadePizzas)
            {
                var za = _pizzas.GetPizza((int)s.PizzaId);
                if ((bool)za.MenuItem)
                {
                    pizzaArray[i] = za.Name;
                    string toppingsStr = "";
                    //TODO: add tops
                    descArray[i] = "Sauce: " + za.Sauce.Name + " - Toppings: " + toppingsStr;
                    i++;
                }
            }
            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[premadePizzas.Count + 1];
            for (i = 0; i < premadePizzas.Count; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = pizzaArray[i];
                radioButtons[i].Location = new System.Drawing.Point(20, 20 + i * 30);
                this.pizzaGroup.Controls.Add(radioButtons[i]);
            }
            return premadePizzas.Count;
        }

        private void saveToppings_Click(object sender, EventArgs e)
        {
            Anchovy.API.Client.Models.Sauce thisSauce = null;
            foreach (var but in this.sauceGroup.Controls)
            {
                if (but is RadioButton)
                {
                    RadioButton thing = (RadioButton)but;
                    if (thing.Checked == true)
                    {
                        foreach (var sauc in _sauces.GetSauces())
                        {
                            if (sauc.Name.Equals(thing.Text))
                            {
                                thisSauce = sauc;
                            }
                        }
                    }

                }
            }
            if (thisSauce == null)
            {
                toppingsError.Text = "Please select a sauce type.";
            }
            else
            {
                //TODO: Add toppings and sauce
                this.Hide();
            }
        }

        private void checkSize()
        {
            foreach (var but in this.sizeGroup.Controls)
            {
                if (but is RadioButton)
                {
                    RadioButton thing = (RadioButton)but;
                    if (thing.Checked == true)
                    {
                        foreach (var sz in _sizes.GetSizes())
                        {
                            if (sz.Name.Equals(thing.Text))
                            {
                                thisSize = sz;
                            }
                        }
                    }

                }
            }
        }

        private void checkCrust()
        {
            foreach (var but in this.crustGroup.Controls)
            {
                if (but is RadioButton)
                {
                    RadioButton thing = (RadioButton)but;
                    if (thing.Checked == true)
                    {
                        foreach (var crus in _crusts.GetCrusts())
                        {
                            if (crus.Name.Equals(thing.Text))
                            {
                                thisCrust = crus;
                            }
                        }
                    }

                }
            }
        }
    }
}
