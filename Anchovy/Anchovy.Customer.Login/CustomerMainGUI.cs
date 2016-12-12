using CustomerLogin;
using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using System.Web.Services.Description;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

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

        // Create variables that allow each pizza to set a size and crust
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
            _currentOrder.OrderStatus = 0;
            _currentOrder = _orders.PostOrder(_currentOrder);

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
            customButton.Font = new Font(customButton.Font.Name, customButton.Font.Size, FontStyle.Bold);
            customButton.Location = new System.Drawing.Point(20, 20 + (pizzas + 1) * 95);
            this.scrollPanel.Controls.Add(customButton);

            // Create size, sauce, and crust buttons dynamically
            addSizeButtons();
            addSauceButtons();
            addCrustButtons();

            // Hide shopping cart
            shoppingPanel.Hide();

            // Call method to fill out all account info 
            fillOutFields();

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
            var premadePizzas = _pizzas.GetPizzas();
            List<String> prePizzas = new List<String>();
            List<String> preSauce = new List<String>();
            List<String> preCrust = new List<String>();
            List<String> preTops = new List<String>();

            int i = 0;
            foreach (var za in premadePizzas)
            {
                if ((bool)za.MenuItem)
                {
                    double topCost = 0;
                    string sauceDesc = "Sauce: " + za.Sauce.Name;
                    string crustDesc = "Crust: " + za.Crust.Name;
                    string toppings = "Toppings: ";
                    var pizzaTops = _pizzaToppings.GetPizzaToppings();
                    foreach (var pTops in pizzaTops)
                    {
                        if (pTops.PizzaId == za.Id)
                        {
                            var currTop = _toppings.GetTopping((int)pTops.ToppingId);
                            toppings += currTop.Name + ", ";
                            topCost += (double)currTop.Cost;
                        }
                    }
                    var cost = za.Sauce.Cost + za.Crust.Cost + topCost;
                    prePizzas.Add(za.Name + " ($" + cost + ")");
                    preSauce.Add(sauceDesc);
                    preCrust.Add(crustDesc);
                    preTops.Add(toppings.Trim(','));
                    i++;
                }
            }
            System.Windows.Forms.RadioButton[] radioButtons = new System.Windows.Forms.RadioButton[i + 1];
            System.Windows.Forms.Label[] sauceLabels = new System.Windows.Forms.Label[i + 1];
            System.Windows.Forms.Label[] crustLabels = new System.Windows.Forms.Label[i + 1];
            System.Windows.Forms.Label[] toppingLabels = new System.Windows.Forms.Label[i + 1];
            for (int x = 0; x < i; x++)
            {
                radioButtons[x] = new RadioButton();
                radioButtons[x].Text = prePizzas[x];
                radioButtons[x].Font = new Font(radioButtons[x].Font.Name, radioButtons[x].Font.Size, FontStyle.Bold);
                radioButtons[x].Location = new System.Drawing.Point(20, 20 + x * 110);
                this.scrollPanel.Controls.Add(radioButtons[x]);
                sauceLabels[x] = new Label();
                sauceLabels[x].AutoSize = true;
                sauceLabels[x].Text = preSauce[x];
                sauceLabels[x].Location = new System.Drawing.Point(20, 80 * x + 50 + x * 30);
                this.scrollPanel.Controls.Add(sauceLabels[x]);
                crustLabels[x] = new Label();
                crustLabels[x].AutoSize = true;
                crustLabels[x].Text = preCrust[x];
                crustLabels[x].Location = new System.Drawing.Point(20, 80 * x + 80 + x * 30);
                this.scrollPanel.Controls.Add(crustLabels[x]);
                toppingLabels[x] = new Label();
                toppingLabels[x].AutoSize = true;
                toppingLabels[x].Text = preTops[x];
                toppingLabels[x].Location = new System.Drawing.Point(20, 80 * x + 110 + x * 30);
                this.scrollPanel.Controls.Add(toppingLabels[x]);
            }
            return i;
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
            else if (thisCrust == null)
            {
                toppingsError.Text = "Please select a crust type.";
            }
            else
            {
                _currentPizza.MenuItem = false;
                _currentPizza.CrustId = thisCrust.Id;
                _currentPizza.SauceId = thisSauce.Id;
                _currentPizza.SizeId = thisSize.Id;
                Random rnd = new Random();
                var randString = "NewCustom-";
                for (int i = 0; i < 6; i++)
                {
                    randString += rnd.Next(0, 9);
                }
                _currentPizza.Name = randString;
                _currentPizza = _pizzas.PostPizza(_currentPizza);
                var allToppings = _toppings.GetToppings();
                foreach (var top in this.selectedToppings.Items)
                {
                    foreach (var top2 in allToppings)
                    {
                        if (((String)top).Contains(top2.Name))
                        {
                            var temp = new Anchovy.API.Client.Models.PizzaTopping();
                            temp.PizzaId = _currentPizza.Id;
                            temp.ToppingId = top2.Id;
                            var currTop = _pizzaToppings.PostPizzaTopping(temp);
                        }
                    }
                }
                var currLine = new Anchovy.API.Client.Models.Line();
                currLine.PizzaId = _currentPizza.Id;
                currLine = _lines.PostLine(currLine);
                var currOrdLine = new Anchovy.API.Client.Models.OrderLine();
                currOrdLine.OrderId = _currentOrder.Id;
                currOrdLine.LineId = currLine.Id;
                currOrdLine = _orderLines.PostOrderLine(currOrdLine);
                orderError.ForeColor = System.Drawing.Color.Green;
                orderError.Text = "Item added successfully.";
                _currentOrder = new Anchovy.API.Client.Models.Order();
                selectedToppings.Items.Clear();
                AppetizersPanel.Hide();
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
                        cancelLink.AutoSize = true;
                        cancelLink.Text = "Cancel Order (Est. Time - " + calcEstTime() + ")";
                        cancelLink.Click += (sender, e) => cancelHandler(orderId);
                        this.orderHistory.Controls.Add(currLabel);
                        loc++;
                        cancelLink.Location = new System.Drawing.Point(10, 10 + loc * 40);
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
            fillOrderHistory();
        }

        // Generate a status string from the enum
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

        // Hide custom pizza 
        private void cancelToppings_Click(object sender, EventArgs e)
        {
            _currentPizza = new Anchovy.API.Client.Models.Pizza();
            AppetizersPanel.Hide();
        }

        private void selectPizza_Click(object sender, EventArgs e)
        {
            // Check if size and crust buttons are selected
            checkSize();
            if (thisSize == null)
            {
                orderError.ForeColor = System.Drawing.Color.Red;
                orderError.Text = "Please select a size.";
            }
            else
            {
                if (customButton.Checked)
                {
                    AppetizersPanel.Show();

                    // TODO: generate custom pizza
                }
                else
                {
                    foreach (var button in this.scrollPanel.Controls)
                    {
                        if (button.GetType() == typeof(RadioButton))
                        {
                            var temp = (RadioButton)button;
                            if (temp.Checked == true)
                            {
                                try
                                {
                                    var allPizzas = _pizzas.GetPizzas();
                                    var currLine = new Anchovy.API.Client.Models.Line();
                                    foreach (var pizza in allPizzas)
                                    {
                                        if (temp.Text.Contains(pizza.Name))
                                        {
                                            pizza.SizeId = thisSize.Id;
                                            pizza.Id = null;
                                            pizza.MenuItem = false;
                                            _currentPizza = _pizzas.PostPizza(pizza);
                                            currLine.PizzaId = _currentPizza.Id;
                                            currLine = _lines.PostLine(currLine);
                                        }
                                    }
                                    var currOrdLine = new Anchovy.API.Client.Models.OrderLine();
                                    currOrdLine.OrderId = _currentOrder.Id;
                                    currOrdLine.LineId = currLine.Id;
                                    currOrdLine = _orderLines.PostOrderLine(currOrdLine);
                                    orderError.ForeColor = System.Drawing.Color.Green;
                                    orderError.Text = "Item added successfully.";
                                    _currentOrder = new Anchovy.API.Client.Models.Order();
                                    _currentOrder.CustomerId = _currentCusty.Id;
                                    _currentOrder.OrderStatus = 0;
                                    _currentOrder = _orders.PostOrder(_currentOrder);
                                }
                                catch (Exception a)
                                {
                                    orderError.ForeColor = System.Drawing.Color.Red;
                                    orderError.Text = "Error adding item";
                                }
                            }
                        }
                    }
                }
            }

            checkCrust();
            checkSize();
        }

        private void shoppingCart1_Click(object sender, EventArgs e)
        {
            var orderLines = _orderLines.GetOrderLines();
            foreach (var orderLine in orderLines)
            {
                var temp = _orders.GetOrder((int)orderLine.OrderId);
                if (temp.CustomerId == _currentCusty.Id && temp.OrderStatus == 0)
                {
                    var lines = _lines.GetLines();
                    foreach (var line in lines)
                    {
                        if (orderLine.LineId == line.Id)
                        {
                            var pizzas = _pizzas.GetPizzas();
                            List<String> prePizzas = new List<String>();
                            List<String> preSauce = new List<String>();
                            List<String> preCrust = new List<String>();
                            List<String> preTops = new List<String>();
                            int i = 0;
                            foreach (var pizza in pizzas)
                            {
                                if (pizza.Id == line.PizzaId)
                                {
                                    double topCost = 0;
                                    string sauceDesc = "Sauce: " + pizza.Sauce.Name;
                                    string crustDesc = "Crust: " + pizza.Crust.Name;
                                    string toppings = "Toppings: ";
                                    var pizzaTops = _pizzaToppings.GetPizzaToppings();
                                    foreach (var pTops in pizzaTops)
                                    {
                                        if (pTops.PizzaId == pizza.Id)
                                        {
                                            var currTop = _toppings.GetTopping((int)pTops.ToppingId);
                                            toppings += currTop.Name + ", ";
                                            topCost += (double)currTop.Cost;
                                        }
                                    }
                                    var cost = pizza.Sauce.Cost + pizza.Crust.Cost + topCost;
                                    var labelString = pizza.Name + " ($" + cost + ")" + " - " + pizza.Size.Name;
                                    prePizzas.Add(labelString);
                                    preSauce.Add(sauceDesc);
                                    preCrust.Add(crustDesc);
                                    preTops.Add(toppings.Trim(','));
                                    i++;
                                }
                            }
                            System.Windows.Forms.Label[] nameLabels = new System.Windows.Forms.Label[i + 1];
                            System.Windows.Forms.Label[] sauceLabels = new System.Windows.Forms.Label[i + 1];
                            System.Windows.Forms.Label[] crustLabels = new System.Windows.Forms.Label[i + 1];
                            System.Windows.Forms.Label[] toppingLabels = new System.Windows.Forms.Label[i + 1];
                            for (int x = 0; x < i; x++)
                            {
                                nameLabels[x] = new Label();
                                nameLabels[x].AutoSize = true;
                                nameLabels[x].Text = prePizzas[x];
                                nameLabels[x].Font = new Font(nameLabels[x].Font.Name, nameLabels[x].Font.Size, FontStyle.Bold);
                                nameLabels[x].Location = new System.Drawing.Point(20, 20 + x * 110);
                                this.shoppingPanel.Controls.Add(nameLabels[x]);
                                sauceLabels[x] = new Label();
                                sauceLabels[x].AutoSize = true;
                                sauceLabels[x].Text = preSauce[x];
                                sauceLabels[x].Location = new System.Drawing.Point(20, 80 * x + 50 + x * 30);
                                this.shoppingPanel.Controls.Add(sauceLabels[x]);
                                crustLabels[x] = new Label();
                                crustLabels[x].AutoSize = true;
                                crustLabels[x].Text = preCrust[x];
                                crustLabels[x].Location = new System.Drawing.Point(20, 80 * x + 80 + x * 30);
                                this.shoppingPanel.Controls.Add(crustLabels[x]);
                                toppingLabels[x] = new Label();
                                toppingLabels[x].AutoSize = true;
                                toppingLabels[x].Text = preTops[x];
                                toppingLabels[x].Location = new System.Drawing.Point(20, 80 * x + 110 + x * 30);
                                this.shoppingPanel.Controls.Add(toppingLabels[x]);
                            }
                        }
                    }
                }
            }
            shoppingPanel.Show();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            shoppingPanel.Hide();
        }

        private void submitOrder_Click(object sender, EventArgs e)
        {
            _currentOrder.OrderStatus = 1;
            _currentOrder = (Anchovy.API.Client.Models.Order)_orders.PutOrder((int)_currentOrder.Id, _currentOrder);
            orderError.Text = "Order submitted successfully";
            orderError.ForeColor = System.Drawing.Color.Green;
            shoppingPanel.Hide();
            fillOrderHistory();
            _currentOrder = new Anchovy.API.Client.Models.Order();
            _currentOrder.OrderStatus = 0;
            _currentOrder.CustomerId = _currentCusty.Id;
            _currentOrder = _orders.PostOrder(_currentOrder);
        }

        private void resetOrder_Click(object sender, EventArgs e)
        {
            var allOrders = _orders.GetOrders();
            foreach (var order in allOrders)
            {
                if (order.CustomerId == _currentCusty.Id && order.OrderStatus == 0)
                {
                    _orders.DeleteOrder((int)order.Id);
                }
            }
            shoppingPanel.Controls.Clear();
            _currentOrder = new Anchovy.API.Client.Models.Order();
            _currentOrder.OrderStatus = 0;
            _currentOrder.CustomerId = _currentCusty.Id;
            _currentOrder = _orders.PostOrder(_currentOrder);
            orderError.ForeColor = System.Drawing.Color.Green;
            orderError.Text = "Unordered items removed successfully.";
            shoppingPanel.Hide();
        }

        //Initialize the global queue with orders from database with statuscode == ordered
        private int calcEstTime()
        {
            int totalTime = 0;
            var orders = _orders.GetOrders();
            foreach (var ord in orders)
            {
                if (ord.OrderStatus == 1) {
                    if (ord.CustomerId == _currentCusty.Id)
                    {
                        break;
                    }
                    else
                    {
                        totalTime += 20;
                    }
                }
            }
            return totalTime;
        }
    }
}
