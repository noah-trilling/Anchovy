using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anchovy.Models.Utilities;
using Anchovy.API.Client;

//changed 
//orderhelper.cs line 17
//pizzahelper.cs line 18
namespace Anchovy.Manager.Main
{
    public partial class ManagerMain : Form
    {
        private IToppings _toppings;
        private IOrders _orders = new AnchovyAPIService().Orders;
        private IOrderLines _orderLines = new AnchovyAPIService().OrderLines;
        private ILines _lines = new AnchovyAPIService().Lines;
        private IMenuListings _menulistings = new AnchovyAPIService().MenuListings;
        private IPizzas _pizzas = new AnchovyAPIService().Pizzas;
        private IPizzaToppings _pizzaToppings = new AnchovyAPIService().PizzaToppings;
        private ISizes _sizes = new AnchovyAPIService().Sizes;
        private ISauces _sauses = new AnchovyAPIService().Sauces;
        private ICrusts _crust = new AnchovyAPIService().Crusts;
        private ICooks _cooks = new AnchovyAPIService().Cooks;
        private IManagers _managers = new AnchovyAPIService().Managers;



        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnManLogout_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.Show();
            this.Close();
        }

        public void hideManagersTab()
        {
            tabControl.TabPages.Remove(tabPageManagers);
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AnchovyContextCustomerDataSet.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.AnchovyContextCustomerDataSet.Customers);
            // TODO: This line of code loads data into the 'AnchovyContextCookHourPay.CookHoursPayView' table. You can move, or remove it, as needed.
            this.CookHoursPayViewTableAdapter.Fill(this.AnchovyContextCookHourPay.CookHoursPayView);
            // TODO: This line of code loads data into the 'AnchovyContextCookPreformanceDataSet.CookPreformanceView' table. You can move, or remove it, as needed.
            this.CookPreformanceViewTableAdapter.Fill(this.AnchovyContextCookPreformanceDataSet.CookPreformanceView);
            // TODO: This line of code loads data into the 'AnchovyContextDataSetToppingCountView.ToppingCountView' table. You can move, or remove it, as needed.
            this.ToppingCountViewTableAdapter.Fill(this.AnchovyContextDataSetToppingCountView.ToppingCountView);
            // TODO: This line of code loads data into the 'AnchovyContextDataSet.Managers' table. You can move, or remove it, as needed.
            this.ManagersTableAdapter.Fill(this.AnchovyContextDataSet.Managers);
            //   this.rptViewToppingUsage.RefreshReport();
            _toppings = new AnchovyAPIService().Toppings;
            // getAllToppingInventory();
            PopulateInventoryListBox();
            PopulateSalesTab();
            PopulateCooksComboBox();
            PopulateManagersComboBox();
            populatelstPizzasList();

            //tabControl.TabPages.Remove(tabPageReports);
            this.rptViewCooksPreformance.RefreshReport();
            this.rptViewToppingUsage.RefreshReport();
            this.rptViewCookHourPay.RefreshReport();
            this.rptViewCustomersList.RefreshReport();
            this.rptViewCustomersList.RefreshReport();
        }


        ///<summary>
        ///Inventory Tab
        ///All Functionality for Inventory Tab
        ///</summary>

        private void PopulateInventoryListBox()
        {
            var AllToppings = _toppings.GetToppings().GetEnumerator();
            List<string> DataForListBox = new List<string>();
            string low = "LOW";
            while (AllToppings.MoveNext())
            {
                if (AllToppings.Current.Quantity <= AllToppings.Current.LowLevel)
                {
                    DataForListBox.Add("T" + AllToppings.Current.Id + ": " + AllToppings.Current.Name + "\t\t" + AllToppings.Current.Quantity + "  " + low);
                }
                else
                {
                    DataForListBox.Add("T" + AllToppings.Current.Id + ": " + AllToppings.Current.Name + "\t\t" + AllToppings.Current.Quantity);
                }
            }


            var AllSizes = _sizes.GetSizes().GetEnumerator();
            List<string> sizes = new List<string>();

            while (AllSizes.MoveNext())
            {
                DataForListBox.Add("Z" + AllSizes.Current.Id + ": " + AllSizes.Current.Name + " (Size)");
            }

            var AllSauses = _sauses.GetSauces().GetEnumerator();
            while (AllSauses.MoveNext())
            {
                DataForListBox.Add("S" + AllSauses.Current.Id + ": " + AllSauses.Current.Name + " (Sauce)");
            }
            var AllCrust = _crust.GetCrusts().GetEnumerator();
            while (AllCrust.MoveNext())
            {
                DataForListBox.Add("C" + AllCrust.Current.Id + ": " + AllCrust.Current.Name + " (Crust)");
            }
            var AllMenuListings = _menulistings.GetMenuListings().GetEnumerator();
            while (AllMenuListings.MoveNext())
            {
                DataForListBox.Add("M" + AllMenuListings.Current.Id + ": " + AllMenuListings.Current.Name);
            }
            PopulateComboInventorySize();
            lstBoxInventory.DataSource = DataForListBox;

        }

        private void PopulateComboInventorySize()
        {
            var AllSizes = _sizes.GetSizes().GetEnumerator();
            List<string> sizes = new List<string>();
            while (AllSizes.MoveNext())
            {
                sizes.Add(AllSizes.Current.Name);
            }
            comboInventorySize.DataSource = sizes;
        }

        private void lstBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = lstBoxInventory.SelectedItem.ToString();
            string idstring = item.Substring(1, item.IndexOf(":") - 1);
            int _id = Convert.ToInt32(idstring);
            if (item.StartsWith("T"))
            {
                lblInventoryType.Text = "Topping";
                lblInventoryLowLevel.Visible = true;
                txtInventoryLowLevel.Visible = true;
                txtInventoryQuantity.Visible = true;
                lblInventoryQuantity.Visible = true;
                comboInventorySize.Visible = false;
                lblInventoryQuantity.Text = "Quantity";

                var topping = _toppings.GetTopping(_id);
                txtInventoryName.Text = topping.Name;
                txtInventoryQuantity.Text = "" + topping.Quantity;
                txtInventoryLowLevel.Text = "" + topping.LowLevel;
                txtInventoryCost.Text = ((double)topping.Cost).ToString("###########.00");
            }
            else if (item.StartsWith("M"))
            {
                lblInventoryType.Text = "Menu Item";
                lblInventoryQuantity.Text = "Size";
                lblInventoryQuantity.Visible = true;
                lblInventoryLowLevel.Visible = false;
                txtInventoryLowLevel.Visible = false;
                txtInventoryQuantity.Visible = false;
                comboInventorySize.Visible = true;
                var MenuListing = _menulistings.GetMenuListing(_id);
                txtInventoryName.Text = MenuListing.Name;
                txtInventoryCost.Text = ((double)MenuListing.Cost).ToString("########.00");
                PopulateComboInventorySize();
                comboInventorySize.Text = _sizes.GetSize((int)MenuListing.SizeId).Name;
            }
            else if (item.StartsWith("Z"))
            {
                lblInventoryType.Text = "Size";
                lblInventoryLowLevel.Visible = false;
                lblInventoryQuantity.Visible = false;
                txtInventoryLowLevel.Visible = false;
                txtInventoryQuantity.Visible = false;
                comboInventorySize.Visible = false;
                txtInventoryName.Text = _sizes.GetSize(_id).Name;
                txtInventoryCost.Text = ((double)_sizes.GetSize(_id).Cost).ToString("#########.00");
            }
            else if (item.StartsWith("C"))
            {
                lblInventoryType.Text = "Crust";
                lblInventoryLowLevel.Visible = false;
                lblInventoryQuantity.Visible = false;
                txtInventoryLowLevel.Visible = false;
                txtInventoryQuantity.Visible = false;
                comboInventorySize.Visible = false;
                txtInventoryName.Text = _crust.GetCrust(_id).Name;
                txtInventoryCost.Text = ((double)_crust.GetCrust(_id).Cost).ToString("#########.00");
            }
            else if (item.StartsWith("S"))
            {
                lblInventoryType.Text = "Sause";
                lblInventoryLowLevel.Visible = false;
                lblInventoryQuantity.Visible = false;
                txtInventoryLowLevel.Visible = false;
                txtInventoryQuantity.Visible = false;
                comboInventorySize.Visible = false;
                txtInventoryName.Text = _sauses.GetSauce(_id).Name;
                txtInventoryCost.Text = ((double)_sauses.GetSauce(_id).Cost).ToString("#########.00");
            }
            else
            {
                return;
            }
        }

        private void btnInventoryEdit_Click(object sender, EventArgs e)
        {
            comboInventorySize.Enabled = true;
            txtInventoryCost.ReadOnly = false;
            txtInventoryName.ReadOnly = false;
            txtInventoryQuantity.ReadOnly = false;
            txtInventoryLowLevel.ReadOnly = false;
        }

        private void btnInventorySave_Click(object sender, EventArgs e)
        {
            double x = 0.0;
            int y = 0;
            bool flag = true;
            if (!double.TryParse(txtInventoryCost.Text, out x))
            {
                lblInventoryErrorCost.Visible = true;
                flag = false;
            }
            else
            {
                lblInventoryErrorCost.Visible = false;
            }
            if (!int.TryParse(txtInventoryQuantity.Text, out y) && comboInventorySize.Visible == false)
            {
                lblInventoryQuantityError.Visible = true;
                flag = false;
            }
            else
            {
                lblInventoryQuantityError.Visible = false;
            }
            if (!int.TryParse(txtInventoryLowLevel.Text, out y))
            {
                lblInventoryLowLevelError.Visible = true;
                flag = false;
            }
            else
            {
                lblInventoryLowLevelError.Visible = false;
            }
            if (flag == false) return;


            string item = lstBoxInventory.SelectedItem.ToString();
            string idstring = item.Substring(1, item.IndexOf(":") - 1);
            int _id = Convert.ToInt32(idstring);
            if (item.StartsWith("T"))
            {
                var topping = _toppings.GetTopping(_id);
                topping.Name = txtInventoryName.Text;
                topping.Cost = Convert.ToDouble(txtInventoryCost.Text);
                topping.Quantity = Convert.ToInt32(txtInventoryQuantity.Text);
                topping.LowLevel = Convert.ToInt32(txtInventoryLowLevel.Text);

                _toppings.PutTopping(_id, topping);

            }
            else if (item.StartsWith("M"))
            {
                var MenuListing = _menulistings.GetMenuListing(_id);
                MenuListing.Name = txtInventoryName.Text;
                MenuListing.Cost = Convert.ToDouble(txtInventoryCost.Text);
                var AllSizes = _sizes.GetSizes().GetEnumerator();
                while (AllSizes.MoveNext())
                {
                    if (AllSizes.Current.Name.Equals(comboInventorySize.Text))
                    {
                        MenuListing.SizeId = AllSizes.Current.Id;
                        MenuListing.Size = AllSizes.Current;
                    }
                }
                _menulistings.PutMenuListing(_id, MenuListing);
            }
            else if (item.StartsWith("Z"))
            {
                var size = _sizes.GetSize(_id);
                size.Name = txtInventoryName.Text;
                size.Cost = Convert.ToDouble(txtInventoryCost.Text);
                _sizes.PutSize(_id, size);
            }
            else if (item.StartsWith("C"))
            {
                var crust = _crust.GetCrust(_id);
                crust.Cost = Convert.ToDouble(txtInventoryCost.Text);
                crust.Name = txtInventoryName.Text;
                _crust.PutCrust(_id, crust);
            }
            else if (item.StartsWith("S"))
            {
                var sause = _sauses.GetSauce(_id);
                sause.Cost = Convert.ToDouble(txtInventoryCost.Text);
                sause.Name = txtInventoryName.Text;
                _sauses.PutSauce(_id, sause);
            }
            else
            {
                return;
            }

            comboInventorySize.Enabled = false;
            txtInventoryCost.ReadOnly = true;
            txtInventoryName.ReadOnly = true;
            txtInventoryQuantity.ReadOnly = true;
            txtInventoryLowLevel.ReadOnly = true;


            PopulateInventoryListBox();

        }

        private void btnInvtAddNewItem_Click(object sender, EventArgs e)
        {
            panelInventoryAddNew.Visible = true;
            comboInventoryAddList.Text = "Select one...";
            txtInventoryAddNewName.Text = "";
            if (btnInvtAddNewItem.Text.Equals("Cancel"))
            {
                btnInvtAddNewItem.Text = "Add New Item";
                panelInventoryAddNew.Visible = false;
            }
            else
            {
                btnInvtAddNewItem.Text = "Cancel";
                panelInventoryAddNew.Visible = true;
            }


        }

        private void btnInventoryAddNewDone_Click(object sender, EventArgs e)
        {
            if (comboInventoryAddList.Text.Equals("Topping"))
            {
                Anchovy.API.Client.Models.Topping topping = new API.Client.Models.Topping();
                topping.Name = txtInventoryAddNewName.Text;
                _toppings.PostTopping(topping);
            }
            else if (comboInventoryAddList.Text.Equals("Crust"))
            {
                Anchovy.API.Client.Models.Crust crust = new API.Client.Models.Crust();
                crust.Name = txtInventoryAddNewName.Text;
                _crust.PostCrust(crust);
            }
            else if (comboInventoryAddList.Text.Equals("Sause"))
            {
                Anchovy.API.Client.Models.Sauce sause = new API.Client.Models.Sauce();
                sause.Name = txtInventoryAddNewName.Text;
                _sauses.PostSauce(sause);
            }
            else if (comboInventoryAddList.Text.Equals("Size"))
            {
                Anchovy.API.Client.Models.Size size = new API.Client.Models.Size();
                size.Name = txtInventoryAddNewName.Text;
                _sizes.PostSize(size);
            }
            else if (comboInventoryAddList.Text.Equals("Menu Listing"))
            {
                Anchovy.API.Client.Models.MenuListing menulist = new API.Client.Models.MenuListing();
                menulist.Name = txtInventoryAddNewName.Text;
                var AllSizes = _sizes.GetSizes().GetEnumerator();
                Anchovy.API.Client.Models.Size size = new API.Client.Models.Size();
                while (AllSizes.MoveNext())
                {
                    size = AllSizes.Current;
                }
                menulist.SizeId = (int)size.Id;
                menulist.Size = size;
                _menulistings.PostMenuListing(menulist);
            }
            PopulateInventoryListBox();
            panelInventoryAddNew.Visible = false;
            btnInvtAddNewItem.Text = "Add New Item";
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            string item = lstBoxInventory.SelectedItem.ToString();
            string idstring = item.Substring(1, item.IndexOf(":") - 1);
            int _id = Convert.ToInt32(idstring);
            if (item.StartsWith("T"))
            {
                _toppings.DeleteTopping(_id);

            }
            else if (item.StartsWith("M"))
            {
                _menulistings.DeleteMenuListing(_id);
            }
            else if (item.StartsWith("Z"))
            {
                _sizes.DeleteSize(_id);
            }
            else if (item.StartsWith("C"))
            {
                _crust.DeleteCrust(_id);
            }
            else if (item.StartsWith("S"))
            {
                _sauses.DeleteSauce(_id);
            }
            else
            {
                return;
            }
            PopulateInventoryListBox();
        }

        ///<summary>
        ///Pizzas Tab
        ///All fumctionality for adding and editing pizzas
        ///</summary>
        private void populatelstPizzasList()
        {
            var AllMenuPizzas = _pizzas.GetPizzas().GetEnumerator();
            List<string> DataforpizzaList = new List<string>();
            while (AllMenuPizzas.MoveNext())
            {
                if ((bool)AllMenuPizzas.Current.MenuItem)
                {
                    DataforpizzaList.Add(AllMenuPizzas.Current.Id + ": " + AllMenuPizzas.Current.Name);
                }
            }

            lstPizzasList.DataSource = DataforpizzaList;
            PopulateAllPizzaCombos();
            PopulatePizzaAllToppingsList();
        }

        private void lstPizzasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = lstPizzasList.SelectedItem.ToString();
            string idstring = item.Substring(0, item.IndexOf(":"));
            int _id = Convert.ToInt32(idstring);

            var pizza = _pizzas.GetPizza(_id);
            txtPizzasTabName.Text = pizza.Name;

            PopulateAllPizzaCombos();
        }

        private void PopulateAllPizzaCombos()
        {
            var AllSizes = _sizes.GetSizes().GetEnumerator();
            List<string> sizes = new List<string>();
            while (AllSizes.MoveNext())
            {
                sizes.Add(AllSizes.Current.Name);
            }
            comboPizzasSize.DataSource = sizes;
            comboPizzaAddNewSize.DataSource = sizes;
            var AllCrusts = _crust.GetCrusts().GetEnumerator();
            List<string> crusts = new List<string>();
            while (AllCrusts.MoveNext())
            {
                crusts.Add(AllCrusts.Current.Name);
            }
            comboPizzasCrust.DataSource = crusts;
            comboPizzaAddNewCrust.DataSource = crusts;
            var AllSauces = _sauses.GetSauces().GetEnumerator();
            List<string> sauces = new List<string>();
            while (AllSauces.MoveNext())
            {
                sauces.Add(AllSauces.Current.Name);
            }
            comboPizzasSauce.DataSource = sauces;
            comboPizzaAddNewSauce.DataSource = sauces;

            string item = lstPizzasList.SelectedItem.ToString();
            string idstring = item.Substring(0, item.IndexOf(":"));
            int _id = Convert.ToInt32(idstring);
            var pizza = _pizzas.GetPizza(_id);
            int sizeId = (int)pizza.SizeId;
            int sauceId = (int)pizza.SauceId;
            int crustId = (int)pizza.CrustId;
            comboPizzasSize.Text = _sizes.GetSize(sizeId).Name;
            comboPizzasSauce.Text = _sauses.GetSauce(sauceId).Name;
            comboPizzasCrust.Text = _crust.GetCrust(crustId).Name;

            var AllToppingsOnPizzas = _pizzaToppings.GetPizzaToppings().GetEnumerator();
            List<int> toppingIds = new List<int>();
            while (AllToppingsOnPizzas.MoveNext())
            {
                if (AllToppingsOnPizzas.Current.PizzaId == _id)
                {
                    toppingIds.Add((int)AllToppingsOnPizzas.Current.ToppingId);
                }
            }
            List<string> toppingNames = new List<string>();
            lstPizzasToppingOnPizza.Items.Clear();
            foreach (var x in toppingIds)
                lstPizzasToppingOnPizza.Items.Add(_toppings.GetTopping(x).Name);

        }

        private void PopulatePizzaAllToppingsList()
        {
            var AllToppings = _toppings.GetToppings().GetEnumerator();
            List<string> toppinglist = new List<string>();
            while (AllToppings.MoveNext())
            {
                toppinglist.Add(AllToppings.Current.Name);
            }
            lstPizzasAllToppings.DataSource = toppinglist;
        }

        private void btnPizzasEdit_Click(object sender, EventArgs e)
        {
            txtPizzasTabName.ReadOnly = false;
            comboPizzasCrust.Enabled = true;
            comboPizzasSauce.Enabled = true;
            comboPizzasSize.Enabled = true;
            btnPizzasAddAllToppings.Enabled = true;
            btnPizzasToppingsAddOne.Enabled = true;
            btnPizzasRemoveOneTopping.Enabled = true;
            btnPizzasToppingRemoveAll.Enabled = true;
        }

        private void btnPizzasSave_Click(object sender, EventArgs e)
        {
            string item = lstPizzasList.SelectedItem.ToString();
            string idstring = item.Substring(0, item.IndexOf(":"));
            int _id = Convert.ToInt32(idstring);
            var pizza = _pizzas.GetPizza(_id);
            var AllSizes = _sizes.GetSizes().GetEnumerator();
            var AllSauces = _sauses.GetSauces().GetEnumerator();
            var AllCrusts = _crust.GetCrusts().GetEnumerator();
            int sizeId = 0;
            int sauceId = 0;
            int crustId = 0;
            while (AllSizes.MoveNext())
            {
                if (AllSizes.Current.Name.Equals(comboPizzasSize.Text))
                {
                    sizeId = (int)AllSizes.Current.Id;
                }
            }
            while (AllSauces.MoveNext())
            {
                if (AllSauces.Current.Name.Equals(comboPizzasSauce.Text))
                {
                    sauceId = (int)AllSauces.Current.Id;
                }
            }
            while (AllCrusts.MoveNext())
            {
                if (AllCrusts.Current.Name.Equals(comboPizzasCrust.Text))
                {
                    crustId = (int)AllCrusts.Current.Id;
                }
            }
            pizza.Name = txtPizzasTabName.Text;
            pizza.SizeId = sizeId;
            pizza.Size = _sizes.GetSize(sizeId);
            pizza.SauceId = sauceId;
            pizza.Sauce = _sauses.GetSauce(sauceId);
            pizza.CrustId = crustId;
            pizza.Crust = _crust.GetCrust(crustId);
            _pizzas.PutPizza(_id, pizza);

            var AllToppingsOnPizzas = _pizzaToppings.GetPizzaToppings().GetEnumerator();
            while (AllToppingsOnPizzas.MoveNext())
            {
                if (AllToppingsOnPizzas.Current.PizzaId == _id)
                {
                    _pizzaToppings.DeletePizzaTopping((int)AllToppingsOnPizzas.Current.Id);
                }
            }
            List<int> toppingIds = new List<int>();
            var AllToppings = _toppings.GetToppings().GetEnumerator();
            while (AllToppings.MoveNext())
            {
                foreach (var i in lstPizzasToppingOnPizza.Items)
                {
                    if (i.Equals(AllToppings.Current.Name))
                    {
                        toppingIds.Add((int)AllToppings.Current.Id);
                    }
                }
            }
            API.Client.Models.PizzaTopping pt = new API.Client.Models.PizzaTopping();
            foreach (int topId in toppingIds)
            {
                pt.PizzaId = _id;
                pt.ToppingId = topId;
                _pizzaToppings.PostPizzaTopping(pt);
            }

            txtPizzasTabName.ReadOnly = true;
            comboPizzasCrust.Enabled = false;
            comboPizzasSauce.Enabled = false;
            comboPizzasSize.Enabled = false;
            btnPizzasAddAllToppings.Enabled = false;
            btnPizzasToppingsAddOne.Enabled = false;
            btnPizzasRemoveOneTopping.Enabled = false;
            btnPizzasToppingRemoveAll.Enabled = false;
            populatelstPizzasList();
        }

        private void btnPizzasAddPizzas_Click(object sender, EventArgs e)
        {
            if (btnPizzasAddPizzas.Text.Equals("Cancel"))
            {
                panelPizzasAddPizza.Visible = false;
                btnPizzasAddPizzas.Text = "Add New Pizza";
                return;
            }
            btnPizzasAddPizzas.Text = "Cancel";
            panelPizzasAddPizza.Visible = true;
        }

        private void btnPizzasAddDone_Click(object sender, EventArgs e)
        {
            API.Client.Models.Pizza pizza = new API.Client.Models.Pizza();
            var AllSizes = _sizes.GetSizes().GetEnumerator();
            var AllSauces = _sauses.GetSauces().GetEnumerator();
            var AllCrusts = _crust.GetCrusts().GetEnumerator();
            int sizeId = 0;
            int sauceId = 0;
            int crustId = 0;
            while (AllSizes.MoveNext())
            {
                if (AllSizes.Current.Name.Equals(comboPizzaAddNewSize.Text))
                {
                    sizeId = (int)AllSizes.Current.Id;
                }
            }
            while (AllSauces.MoveNext())
            {
                if (AllSauces.Current.Name.Equals(comboPizzaAddNewSauce.Text))
                {
                    sauceId = (int)AllSauces.Current.Id;
                }
            }
            while (AllCrusts.MoveNext())
            {
                if (AllCrusts.Current.Name.Equals(comboPizzaAddNewCrust.Text))
                {
                    crustId = (int)AllCrusts.Current.Id;
                }
            }
            pizza.Name = txtPizzaAddNewName.Text;
            pizza.SizeId = sizeId;
            pizza.Size = _sizes.GetSize(sizeId);
            pizza.SauceId = sauceId;
            pizza.Sauce = _sauses.GetSauce(sauceId);
            pizza.CrustId = crustId;
            pizza.Crust = _crust.GetCrust(crustId);
            pizza.MenuItem = true;

            _pizzas.PostPizza(pizza);
            txtPizzaAddNewName.Text = "";
            btnPizzasAddPizzas.Text = "Add New Pizza";
            panelPizzasAddPizza.Visible = false;
            populatelstPizzasList();
        }

        private void btnPizzasAddAllToppings_Click(object sender, EventArgs e)
        {
            foreach (var item in lstPizzasAllToppings.Items)
            {
                lstPizzasToppingOnPizza.Items.Add(item);
            }

        }

        private void btnPizzasToppingsAddOne_Click(object sender, EventArgs e)
        {
            foreach (var item in lstPizzasAllToppings.SelectedItems)
            {
                lstPizzasToppingOnPizza.Items.Add(item);
            }
        }

        private void btnPizzasRemoveOneTopping_Click(object sender, EventArgs e)
        {
            foreach (string s in lstPizzasToppingOnPizza.SelectedItems.OfType<string>().ToList())
                lstPizzasToppingOnPizza.Items.Remove(s);
        }

        private void btnPizzasToppingRemoveAll_Click(object sender, EventArgs e)
        {
            lstPizzasToppingOnPizza.Items.Clear();
        }

        /// <summary>
        /// Sales Tab
        /// All functionality for getting current and average sales.
        /// </summary>
        public void PopulateSalesTab()
        {
            getCurrentSales();
            getAverageSales();
        }

        public void getCurrentSales()
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Now;

            lblDailySalesValue.Text = "$" + getSalesByDate(startDate, endDate).ToString("##########.##");
            if (getSalesByDate(startDate, endDate) == 0) lblDailySalesValue.Text = "$0";

            startDate = DateTime.Today.AddDays(-7);
            lblWeeklySalesValue.Text = "$" + getSalesByDate(startDate, endDate).ToString("##########.##");
            if (getSalesByDate(startDate, endDate) == 0) lblWeeklySalesValue.Text = "$0";

            startDate = DateTime.Today.AddDays(-30);
            lblMonthlySalesValue.Text = "$" + getSalesByDate(startDate, endDate).ToString("##########.##");
            if (getSalesByDate(startDate, endDate) == 0) lblMonthlySalesValue.Text = "$0";
        }

        public void getAverageSales()
        {
            List<double> returnList = new List<double>();
            double allSales = getAllSales();
            var AllOrders = _orders.GetOrders().GetEnumerator();
            DateTimeOffset oldestdate = DateTime.Today;
            while (AllOrders.MoveNext())
            {
                if (AllOrders.Current.CompletedTimeStamp != null)
                {
                    if (((DateTimeOffset)AllOrders.Current.CompletedTimeStamp).DateTime <= oldestdate.DateTime)
                    {
                        oldestdate = (DateTimeOffset)AllOrders.Current.CompletedTimeStamp;
                    }
                }
            }

            TimeSpan span = DateTime.Today.Subtract(oldestdate.DateTime);
            int totalDays = (int)span.TotalDays;
            double dailyAverage = allSales / totalDays;
            double weeklyAverage = dailyAverage * 7;
            double monthlyAverage = dailyAverage * 30;

            lblDailyAveragesValue.Text = "$" + dailyAverage.ToString("########.##");
            lbllblWeeklyAveragesValue.Text = "$" + weeklyAverage.ToString("########.##");
            lblMonthlyAveragesValue.Text = "$" + monthlyAverage.ToString("########.##");

        }

        public double getAllSales()
        {
            //Getting All orders and saving there ids in orderIds list
            var AllOrders = _orders.GetOrders().GetEnumerator();
            List<int> orderIds = new List<int>();
            while (AllOrders.MoveNext())
            {
                orderIds.Add((int)AllOrders.Current.Id);
            }

            //getting all line ids from orderlines that match with orderids in list
            List<int> lineIds = new List<int>();
            var AllOrderLines = _orderLines.GetOrderLines().GetEnumerator();
            while (AllOrderLines.MoveNext())
            {
                if (orderIds.IndexOf((int)AllOrderLines.Current.OrderId) != -1)
                {
                    lineIds.Add((int)AllOrderLines.Current.LineId);
                }
            }

            var AllLines = _lines.GetLines().GetEnumerator();
            double total = 0;
            while (AllLines.MoveNext())
            {
                if (lineIds.IndexOf((int)AllLines.Current.Id) != -1)
                {
                    total += getMenuListingCost((int)AllLines.Current.MenuListingId);
                    total += getPizzaCost((int)AllLines.Current.PizzaId);
                }
            }

            return total;
        }

        public double getSalesByDate(DateTime startDate, DateTime endDate)
        {
            //Getting All orders and saving there ids in orderIds list
            var AllOrders = _orders.GetOrders().GetEnumerator();
            List<int> orderIds = new List<int>();
            while (AllOrders.MoveNext())
            {
                if(AllOrders.Current.CompletedTimeStamp != null) { 
                DateTime compDate = ((DateTimeOffset)AllOrders.Current.CompletedTimeStamp).DateTime;
                if (compDate > startDate && compDate < endDate)
                    orderIds.Add((int)AllOrders.Current.Id);
                }
            }

            //getting all line ids from orderlines that match with orderids in list
            List<int> lineIds = new List<int>();
            var AllOrderLines = _orderLines.GetOrderLines().GetEnumerator();
            while (AllOrderLines.MoveNext())
            {
                if (orderIds.IndexOf((int)AllOrderLines.Current.OrderId) != -1)
                {
                    lineIds.Add((int)AllOrderLines.Current.LineId);
                }
            }

            var AllLines = _lines.GetLines().GetEnumerator();
            double total = 0;
            while (AllLines.MoveNext())
            {
                if (lineIds.IndexOf((int)AllLines.Current.Id) != -1)
                {
                    total += getMenuListingCost((int)AllLines.Current.MenuListingId);
                    total += getPizzaCost((int)AllLines.Current.PizzaId);
                }
            }

            return total;
        }

        private double getMenuListingCost(int menuListingId)
        {
            if (menuListingId == null || menuListingId == -1) return 0.0;
            var menuListing = _menulistings.GetMenuListing(menuListingId);
            var size = _sizes.GetSize((int)menuListing.SizeId);
            return (double)(menuListing.Cost + size.Cost);
        }

        private double getPizzaCost(int pizzaId)
        {
            if (pizzaId == null || pizzaId == -1) return 0.0;
            double returnValue = 0.0;
            var pizza = _pizzas.GetPizza(pizzaId);
            var sizeId = pizza.SizeId;
            var crustId = pizza.CrustId;
            var sauseId = pizza.SauceId;

            var AllPizzaToppings = _pizzaToppings.GetPizzaToppings().GetEnumerator();
            List<int> ToppingsIdList = new List<int>();
            while (AllPizzaToppings.MoveNext())
            {
                if (AllPizzaToppings.Current.PizzaId == pizzaId)
                {
                    ToppingsIdList.Add((int)AllPizzaToppings.Current.ToppingId);
                }
            }
            var AllToppings = _toppings.GetToppings().GetEnumerator();
            while (AllToppings.MoveNext())
            {
                if (ToppingsIdList.Contains((int)AllToppings.Current.Id))
                {
                    returnValue += (double)AllToppings.Current.Cost;
                }
            }

            returnValue += (double)_sizes.GetSize((int)sizeId).Cost;
            returnValue += (double)_sauses.GetSauce((int)sauseId).Cost;
            returnValue += (double)_crust.GetCrust((int)crustId).Cost;

            return returnValue;
        }

        private void btnRefreshSales_Click(object sender, EventArgs e)
        {
            PopulateSalesTab();
        }

        /// <summary>
        /// Cooks Tab
        /// All functionality for Cooks.
        /// </summary>
        public void PopulateCooksComboBox()
        {
            List<string> cookNames = new List<string>();
            var AllCooks = _cooks.GetCooks().GetEnumerator();
            while (AllCooks.MoveNext())
            {
                cookNames.Add("" + AllCooks.Current.FirstName + " " + AllCooks.Current.LastName);
            }
            comboCooks.DataSource = cookNames;

            var AllManagers = _managers.GetManagers().GetEnumerator();
            List<int> managers = new List<int>();
            while (AllManagers.MoveNext())
            {
                managers.Add((int)AllManagers.Current.Id);
            }
            comboCookNewCookManager.DataSource = managers;
        }

        private void comboCooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var AllCooks = _cooks.GetCooks().GetEnumerator();
            int cookId = -1;
            while (AllCooks.MoveNext())
            {
                if ((AllCooks.Current.FirstName + " " + AllCooks.Current.LastName).Equals(comboCooks.Text))
                {
                    cookId = (int)AllCooks.Current.Id;
                    break;
                }
            }

            if (cookId == -1) return;

            var selectedCook = _cooks.GetCook(cookId);
            txtCookFirstName.Text = selectedCook.FirstName;
            txtCookMiddleName.Text = selectedCook.MiddleName;
            txtCookLastName.Text = selectedCook.LastName;
            txtCookUsername.Text = selectedCook.Username;
            txtCookPassword.Text = selectedCook.Password;
            txtCookAddress.Text = selectedCook.Address;
            txtCookCity.Text = selectedCook.City;
            txtCookState.Text = selectedCook.State;
            txtCookEmail.Text = selectedCook.Email;
            txtCookPhoneNumber.Text = selectedCook.Phone;
            txtCookHourlyWage.Text = selectedCook.HourlyWage.ToString();
            txtCookPieceWorkRate.Text = selectedCook.PieceworkRate.ToString();

        }

        private void btnCookEdit_Click(object sender, EventArgs e)
        {
            txtCookFirstName.ReadOnly = false;
            txtCookMiddleName.ReadOnly = false;
            txtCookLastName.ReadOnly = false;
            txtCookUsername.ReadOnly = false;
            txtCookPassword.ReadOnly = false;
            txtCookAddress.ReadOnly = false;
            txtCookCity.ReadOnly = false;
            txtCookState.ReadOnly = false;
            txtCookEmail.ReadOnly = false;
            txtCookPhoneNumber.ReadOnly = false;
            txtCookHourlyWage.ReadOnly = false;
            txtCookPieceWorkRate.ReadOnly = false;
        }

        private void btnCookSave_Click(object sender, EventArgs e)
        {
            txtCookFirstName.ReadOnly = true;
            txtCookMiddleName.ReadOnly = true;
            txtCookLastName.ReadOnly = true;
            txtCookUsername.ReadOnly = true;
            txtCookPassword.ReadOnly = true;
            txtCookAddress.ReadOnly = true;
            txtCookCity.ReadOnly = true;
            txtCookState.ReadOnly = true;
            txtCookEmail.ReadOnly = true;
            txtCookPhoneNumber.ReadOnly = true;
            txtCookHourlyWage.ReadOnly = true;
            txtCookPieceWorkRate.ReadOnly = true;

            double x = 0.0;
            if (!double.TryParse(txtCookHourlyWage.Text, out x))
            {
                lblCookHourError.Visible = true;
                return;
            }
            else
            {
                lblCookHourError.Visible = false;
            }
            if (!double.TryParse(txtCookPieceWorkRate.Text, out x))
            {
                lblCookPieceWrkError.Visible = true;
                return;
            }
            else
            {
                lblCookPieceWrkError.Visible = false;
            }
            

            var AllCooks = _cooks.GetCooks().GetEnumerator();
            int cookId = -1;
            while (AllCooks.MoveNext())
            {
                if ((AllCooks.Current.FirstName + " " + AllCooks.Current.LastName).Equals(comboCooks.Text))
                {
                    cookId = (int)AllCooks.Current.Id;
                    break;
                }
            }

            if (cookId == -1) return;
            var selectedCook = _cooks.GetCook(cookId);

            selectedCook.FirstName = txtCookFirstName.Text;
            selectedCook.MiddleName = txtCookMiddleName.Text;
            selectedCook.LastName = txtCookLastName.Text;
            selectedCook.Username = txtCookUsername.Text;
            selectedCook.Password = txtCookPassword.Text;
            selectedCook.Address = txtCookAddress.Text;
            selectedCook.City = txtCookCity.Text;
            selectedCook.State = txtCookState.Text;
            selectedCook.Email = txtCookEmail.Text;
            selectedCook.Phone = txtCookPhoneNumber.Text;
            selectedCook.HourlyWage = Convert.ToDouble(txtCookHourlyWage.Text);
            selectedCook.PieceworkRate = Convert.ToDouble(txtCookPieceWorkRate.Text);

            _cooks.PutCook(cookId, selectedCook);
            PopulateCooksComboBox();
            comboCooks.SelectedItem = selectedCook.FirstName + " " + selectedCook.LastName;

        }

        private void btnAddNewCook_Click(object sender, EventArgs e)
        {
            if (btnAddNewCook.Text.Equals("Cancel"))
            {
                panalCooksAddNewCook.Visible = false;
                btnAddNewCook.Text = "Add New Cook";
            }
            else
            {
                btnAddNewCook.Text = "Cancel";
                panalCooksAddNewCook.Visible = true;
            }
            
            //AddNewCook anc = new AddNewCook();
            //anc.Show();
        }

        private void btnCookAddNewCookDone_Click(object sender, EventArgs e)
        {
            
            API.Client.Models.Cook cook = new API.Client.Models.Cook();
            cook.FirstName = txtCookNewCookName.Text;
            cook.ManagerId = Convert.ToInt32(comboCookNewCookManager.Text);
            _cooks.PostCook(cook);
            PopulateCooksComboBox();
            txtCookNewCookName.Text = "";
            btnAddNewCook.Text = "Add New Cook";
            panalCooksAddNewCook.Visible = false;
        }

        ///<summary>
        ///Managers Tab
        ///All Functionality for Managers Tab
        ///</summary>

        public void PopulateManagersComboBox()
        {
            List<string> managerNames = new List<string>();
            var AllManagers = _managers.GetManagers().GetEnumerator();
            while (AllManagers.MoveNext())
            {
                managerNames.Add("" + AllManagers.Current.FirstName + " " + AllManagers.Current.LastName);
            }
            comboManager.DataSource = managerNames;
        }

        private void comboManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            var AllManagers = _managers.GetManagers().GetEnumerator();
            int managerId = -1;
            while (AllManagers.MoveNext())
            {
                if ((AllManagers.Current.FirstName + " " + AllManagers.Current.LastName).Equals(comboManager.Text))
                {
                    managerId = (int)AllManagers.Current.Id;
                    break;
                }
            }

            if (managerId == -1) return;

            var selectedManager = _managers.GetManager(managerId);
            txtManagerFName.Text = selectedManager.FirstName;
            txtManagerMName.Text = selectedManager.MiddleName;
            txtManagerLName.Text = selectedManager.LastName;
            txtManagerUName.Text = selectedManager.Username;
            txtManagerPwd.Text = selectedManager.Password;
            txtManagerAddress.Text = selectedManager.Address;
            txtManagerCity.Text = selectedManager.City;
            txtManagerState.Text = selectedManager.State;
            txtManagerEmail.Text = selectedManager.Email;
            txtManagerPhoneNumber.Text = selectedManager.Phone;
            txtManagerSalary.Text = selectedManager.Salary.ToString();
            lblManagerIdValue.Text = selectedManager.Id.ToString();
        }

        private void btnManagerEdit_Click(object sender, EventArgs e)
        {
            txtManagerFName.ReadOnly = false;
            txtManagerMName.ReadOnly = false;
            txtManagerLName.ReadOnly = false;
            txtManagerUName.ReadOnly = false;
            txtManagerPwd.ReadOnly = false;
            txtManagerAddress.ReadOnly = false;
            txtManagerCity.ReadOnly = false;
            txtManagerState.ReadOnly = false;
            txtManagerEmail.ReadOnly = false;
            txtManagerPhoneNumber.ReadOnly = false;
            txtManagerSalary.ReadOnly = false;
        }

        private void btnManagerSave_Click(object sender, EventArgs e)
        {
            double x;
            if (!double.TryParse(txtManagerSalary.Text, out x))
            {
                lblManagerSalaryError.Visible = true;
                return;
            }
            else
            {
                lblManagerSalaryError.Visible = false;
            }
            txtManagerFName.ReadOnly = true;
            txtManagerMName.ReadOnly = true;
            txtManagerLName.ReadOnly = true;
            txtManagerUName.ReadOnly = true;
            txtManagerPwd.ReadOnly = true;
            txtManagerAddress.ReadOnly = true;
            txtManagerCity.ReadOnly = true;
            txtManagerState.ReadOnly = true;
            txtManagerEmail.ReadOnly = true;
            txtManagerPhoneNumber.ReadOnly = true;
            txtManagerSalary.ReadOnly = true;


            var AllManagers = _managers.GetManagers().GetEnumerator();
            int managerId = -1;
            while (AllManagers.MoveNext())
            {
                if ((AllManagers.Current.FirstName + " " + AllManagers.Current.LastName).Equals(comboManager.Text))
                {
                    managerId = (int)AllManagers.Current.Id;
                    break;
                }
            }

            if (managerId == -1) return;
            var selectedManager = _managers.GetManager(managerId);

            selectedManager.FirstName = txtManagerFName.Text;
            selectedManager.MiddleName = txtManagerMName.Text;
            selectedManager.LastName = txtManagerLName.Text;
            selectedManager.Username = txtManagerUName.Text;
            selectedManager.Password = txtManagerPwd.Text;
            selectedManager.Address = txtManagerAddress.Text;
            selectedManager.City = txtManagerCity.Text;
            selectedManager.State = txtManagerState.Text;
            selectedManager.Email = txtManagerEmail.Text;
            selectedManager.Phone = txtManagerPhoneNumber.Text;
            selectedManager.Salary = Convert.ToDouble(txtManagerSalary.Text);

            _managers.PutManager(managerId, selectedManager);
            PopulateManagersComboBox();
            comboManager.SelectedItem = selectedManager.FirstName + " " + selectedManager.LastName;
        }

        private void btnAddNewManager_Click(object sender, EventArgs e)
        {
            if (btnAddNewManager.Text.Equals("Cancel"))
            {
                panelManagersAddNewManager.Visible = false;
                btnAddNewManager.Text = "Add New Manager";
            }
            else
            {
                btnAddNewManager.Text = "Cancel";
                panelManagersAddNewManager.Visible = true;
            }

            //AddNewManager anm = new AddNewManager();
            //anm.Show();
        }

        private void btnManagerAddNewManagerDone_Click(object sender, EventArgs e)
        {
            API.Client.Models.Manager manager = new API.Client.Models.Manager();
            manager.FirstName = txtManagerAddNewManagerName.Text;
            _managers.PostManager(manager);
            PopulateManagersComboBox();
            txtManagerAddNewManagerName.Text = "";
            btnAddNewManager.Text = "Add New Manager";
            panelManagersAddNewManager.Visible = false;
        }

        public void selectManagerFromCombo(API.Client.Models.Manager manager)
        {
            comboManager.SelectedItem = manager.FirstName + " " + manager.LastName;
        }


        ///<summary>
        ///Reports Tab
        ///All Functionality for Reports
        ///</summary>

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            //        Cook Preformance
            //Cooks Hours and Pay
            //Topping Usage Report
            //Customers List

            if (comboReports.Text.Equals("Cook Preformance"))
            {
                rptViewCooksPreformance.Visible = true;
                rptViewToppingUsage.Visible = false;
                rptViewCookHourPay.Visible = false;
                rptViewCustomersList.Visible = false;
            }
            else if (comboReports.Text.Equals("Topping Usage Report"))
            {
                rptViewCooksPreformance.Visible = false;
                rptViewToppingUsage.Visible = true;
                rptViewCookHourPay.Visible = false;
                rptViewCustomersList.Visible = false;
            }
            else if(comboReports.Text.Equals("Cooks Hours and Pay"))
            {
                rptViewCooksPreformance.Visible = false;
                rptViewToppingUsage.Visible = false;
                rptViewCookHourPay.Visible = true;
                rptViewCustomersList.Visible = false;
            }
            else if(comboReports.Text.Equals("Customers List"))
            {
                rptViewCooksPreformance.Visible = false;
                rptViewToppingUsage.Visible = false;
                rptViewCookHourPay.Visible = false;
                rptViewCustomersList.Visible = true;
            }
            else
            {
                rptViewCooksPreformance.Visible = false;
                rptViewToppingUsage.Visible = false;
                rptViewCookHourPay.Visible = false;
                rptViewCustomersList.Visible = false;
            }
        }


    }
}
