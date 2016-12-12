using CustomerLogin;
using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using System.Web.Services.Description;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace CustomerMain
{
    public partial class AnchovyCustomerMainGUI : Form
    {

        // Setup services 
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

        // Create variable for current customer passed in
        private Anchovy.API.Client.Models.Customer _currentCusty;

        // Create new order when customer logs in
        private Anchovy.API.Client.Models.Order _currentOrder;

        // Create a variable that can be used when customer creates new pizza
        private Anchovy.API.Client.Models.Pizza _currentPizza;

        // Create two variables that allow each pizza to set a size and crust
        private Anchovy.API.Client.Models.Size thisSize = null;
        private Anchovy.API.Client.Models.Crust thisCrust = null;

        // Create custom pizza button at the end of all the premade pizzas
        private RadioButton customButton;

        public AnchovyCustomerMainGUI(Anchovy.API.Client.Models.Customer currentCustomer)
        {
            InitializeComponent();
            // Create all services
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

            // Set private variable for customer that logged in
            _currentCusty = currentCustomer;

            // Create a new order for this customer
            _currentOrder = new Anchovy.API.Client.Models.Order();
            _currentOrder.CustomerId = currentCustomer.Id;

            // Get all pizza toppings from DB and add them into the listview for custom pizzas
            var pizzaToppings = _toppings.GetToppings();

            // Create list of toppings and place any toppings that our Out Of Stock into an OOS group
            List<String> ptop = new List<String>();
            List<System.Windows.Forms.Label> oosLabels = new List<System.Windows.Forms.Label>();

            var oosLoc = 0;
            foreach (var ptopping in pizzaToppings)
            {
                if (ptopping.Quantity <= 0)
                {
                    System.Windows.Forms.Label temp = new System.Windows.Forms.Label();
                    temp.Text = ptopping.Name + " ($" + ptopping.Cost + ")";
                    temp.Location = new System.Drawing.Point(15, 15 + oosLoc * 30);
                    this.outOfStock.Controls.Add(temp);
                    oosLoc++;
                }
                else
                {
                    ptop.Add(ptopping.Name + " ($" + ptopping.Cost + ")");
                }
            }

            this.allToppings.DataSource = ptop;
             // Create a new custom pizza immediately upon logging in
            _currentPizza = new Anchovy.API.Client.Models.Pizza();

            // Add the premade pizzas
            int pizzas = addPremadePizzas();

            // Create and add custom pizza button at the end of the premade pizzas
            customButton = new RadioButton();
            customButton.Text = "Custom Pizza";
            customButton.Location = new System.Drawing.Point(20, 20 + (pizzas + 1) * 30);
            this.pizzaGroup.Controls.Add(customButton);

            // Create size, sauce, and crust buttons dynamically
            addSizeButtons();
            addSauceButtons();
            addCrustButtons();

            // Call method to fill out all account info 
            fillOutFields();
        }

        // Hide custom pizza 
        private void cancelApps_Click(object sender, EventArgs e)
        {
            _currentPizza = new Anchovy.API.Client.Models.Pizza();
            AppetizersPanel.Hide();
        }

        private void appetizersButton_Click(object sender, EventArgs e)
        {

            // Check if size and crust buttons are selected
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

        // If logout hide this and return to login page
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

        // If select to cancel customer info, get customer and refresh current info
        private void cancelInfo_Click(object sender, EventArgs e)
        {
            fillOutFields();
        }


        // Fill out fields with current information
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

        // Update customer info in DB through POST
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

        // Buttons for moving toppings between list boxes
        private void addOne_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(allToppings, selectedToppings);
        }

        private void removeOne_Click(object sender, EventArgs e)
        {
            this.selectedToppings.Items.Remove(this.selectedToppings.SelectedItem);
            this.selectedToppings.Refresh();
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {

            destination.Items.Add(source.SelectedItem);
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
            if (source.DataSource != null)
            {
                foreach (var i in source.Items)
                {
                    destination.Items.Add(i);
                }
            } else
            {
                this.selectedToppings.Items.Clear();
            }
        }

        // Helper methods for adding radio buttons to proper group boxes
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
                if (i == 0)
                {
                    radioButtons[i].Checked = true;
                }
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
                if (i == 0)
                {
                    radioButtons[i].Checked = true;
                }
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
                if (i == 0)
                {
                    radioButtons[i].Checked = true;
                }
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

        private void fillOrderHistory()
        {
            var allOrders = _orders.GetOrders();
            List<Anchovy.API.Client.Models.OrderLine> orderHistory = new List<Anchovy.API.Client.Models.OrderLine>();
            var loc = 0;
            int status = -1;
            int orderId = -1;
            foreach (var order in allOrders)
            {
                if (order.CustomerId == _currentCusty.Id)
                {
                    loc += 1;
                    var allOrderLines = _orderLines.GetOrderLines();
                    foreach (var orderLine in allOrderLines)
                    {
                        if (orderLine.OrderId == order.Id)
                        {
                            orderId = (int)orderLine.OrderId;
                            orderHistory.Add(orderLine);
                        }
                    }
                    var labelString = "Ordered Date: " + String.Format("{0:dddd, MMMM d, yyyy}", order.OrderedTimeStamp);
                    labelString += " - Status: " + getStatusString((int)order.OrderStatus);
                    status = (int)order.OrderStatus;
                    var allLines = _lines.GetLines();
                    var allPizzas = _pizzas.GetPizzas();
                    var allPizzaToppings = _pizzaToppings.GetPizzaToppings();

                    double totalCost = 0;
                    double toppingCost = 0;
                    // Get order line, check if in order history
                    foreach (var orderLine in orderHistory)
                    {
                        // Get each line check if line.id equals orderline line.id
                        foreach (var line in allLines)
                        {
                            if (orderLine.LineId == line.Id)
                            {
                                // Get each pizza in each line
                                foreach (var pizza in allPizzas)
                                {
                                    if (line.PizzaId == pizza.Id)
                                    {
                                        // Get each Pizza topping for pizzaID
                                        foreach (var topp in allPizzaToppings)
                                        {
                                            if (pizza.Id == topp.PizzaId)
                                            {
                                                toppingCost += (double)topp.Topping.Cost;
                                            }
                                        }
                                    }
                                    // Now we've got a pizza - calculate cost
                                    totalCost += (double)(toppingCost + toppingCost + pizza.Crust.Cost + pizza.Sauce.Cost + pizza.Size.Cost);                                   
                                }
                            }
                        }
                    }
                    labelString += " - Cost: " + (totalCost);
                    System.Windows.Forms.Label currLabel =  new System.Windows.Forms.Label();
                    currLabel.Text = labelString;
                    currLabel.Location = new System.Drawing.Point(10, 10 + loc * 20);
                    // Check if status is Ordered or Unordered to cancel
                    if (status == 0 || status == 1)
                    {
                        System.Windows.Forms.LinkLabel cancelLink = new System.Windows.Forms.LinkLabel();
                        cancelLink.Text = "Cancel Order";
                        cancelLink.Click += (sender, e) => cancelHandler(orderId);
                        this.orderHistory.Controls.Add(currLabel);
                        loc++;
                        cancelLink.Location = new System.Drawing.Point(10, 10 + loc * 20);
                        this.orderHistory.Controls.Add(cancelLink);
                        loc++;

                    }
                    else
                    {
                        this.orderHistory.Controls.Add(currLabel);
                        loc++;
                    }
                }
            }

        }

        // Cancel order handler
        private void cancelHandler(int temp)
        {
            var order = _orders.GetOrder(temp);
            order.OrderStatus = 4;
            _orders.PutOrder((int)temp, order);
        }

        private String getStatusString(int temp)
        {
            switch (temp)
            {
                case 1: return "Ordered";
                case 2: return "Claimed";
                case 3: return "Completed";
                case 4: return "Cancelled";
                default: return "Unordered";
            }
        }

        private void selectedToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
