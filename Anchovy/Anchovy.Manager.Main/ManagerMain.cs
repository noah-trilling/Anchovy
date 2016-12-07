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

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AnchovyContextDataSet.Managers' table. You can move, or remove it, as needed.
            this.ManagersTableAdapter.Fill(this.AnchovyContextDataSet.Managers);
            this.reportViewer1.RefreshReport();
            _toppings = new AnchovyAPIService().Toppings;
            // getAllToppingInventory();
            PopulateInventoryListBox();
            PopulateSalesTab();
            PopulateCooksComboBox();
            PopulateManagersComboBox();

            //tabControl.TabPages.Remove(tabPageReports);
        }

        //public void getAllToppingInventory()
        //{
        //    var AllToppings = _toppings.GetToppings().GetEnumerator();

        //    while (AllToppings.MoveNext())
        //    {
        //       if(AllToppings.Current.Name == "Cheese")
        //       {
        //            lblCheeseValue.Text = "" + AllToppings.Current.Quantity;
        //       }
        //       if (AllToppings.Current.Name == "Onions")
        //       {
        //            lblRedOnionsValue.Text = "" + AllToppings.Current.Quantity;
        //            if(AllToppings.Current.Quantity < AllToppings.Current.LowLevel)
        //            {
        //                lblRedOnionsValue.ForeColor = Color.Red;
        //            }else
        //            {
        //                lblRedOnionsValue.ForeColor = Color.Black;
        //            }
        //       }

        //    }

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{

        //}

        //private void lblCheese_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    txtCheese.ReadOnly = false;
        //    txtPepperoni.ReadOnly = false;
        //    txtBacon.ReadOnly = false;
        //    txtAnchovies.ReadOnly = false;
        //    txtPinepples.ReadOnly = false;
        //    txtGreenPeppers.ReadOnly = false;
        //    txtBlackOlives.ReadOnly = false;
        //    txtRedOnions.ReadOnly = false;
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    txtCheese.ReadOnly = true;
        //    txtPepperoni.ReadOnly = true;
        //    txtBacon.ReadOnly = true;
        //    txtAnchovies.ReadOnly = true;
        //    txtPinepples.ReadOnly = true;
        //    txtGreenPeppers.ReadOnly = true;
        //    txtBlackOlives.ReadOnly = true;
        //    txtRedOnions.ReadOnly = true;


        //    if(txtRedOnions.Text != "")
        //    {
        //        int amnt = Int32.Parse(txtRedOnions.Text);
        //        var AllToppings = _toppings.GetToppings().GetEnumerator();
        //        Anchovy.API.Client.Models.Topping onion = null;
        //        while (AllToppings.MoveNext())
        //        {
                   
        //            if (AllToppings.Current.Name == "Onions")
        //            {
                    
        //                onion = AllToppings.Current;
        //            }

        //        }
        //        onion.Quantity += amnt;
        //        _toppings.PutTopping((int)onion.Id, onion);
        //        getAllToppingInventory();


        //    }
        //}
        
        ///<summary>
        ///Inventory Tab
        ///All Functionality for Inventory Tab
        ///</summary>
        
        private void PopulateInventoryListBox()
        {
            var AllToppings =  _toppings.GetToppings().GetEnumerator();
            List<string> DataForListBox = new List<string>();
            while (AllToppings.MoveNext())
            {
                DataForListBox.Add("T"+AllToppings.Current.Id+": " +AllToppings.Current.Name+"\t\t"+AllToppings.Current.Quantity);
            }

            lstBoxInventory.DataSource = DataForListBox;


        }

        private void lstBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            lblWeeklySalesValue.Text = "$" + getSalesByDate(startDate,endDate).ToString("##########.##");
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
                if(AllOrders.Current.CompletedTimeStamp != null)
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
                if(orderIds.IndexOf((int) AllOrderLines.Current.OrderId) != -1)
                {
                    lineIds.Add((int)AllOrderLines.Current.LineId);
                }
            }

            var AllLines = _lines.GetLines().GetEnumerator();
            double total = 0;
            while (AllLines.MoveNext())
            {
                if(lineIds.IndexOf((int)AllLines.Current.Id) != -1)
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
                DateTime compDate = ((DateTimeOffset)AllOrders.Current.CompletedTimeStamp).DateTime;
                if(compDate > startDate && compDate < endDate)
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
                if(AllPizzaToppings.Current.PizzaId == pizzaId)
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
        }

        private void comboCooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var AllCooks = _cooks.GetCooks().GetEnumerator();
            int cookId = -1;
            while (AllCooks.MoveNext())
            {
                if((AllCooks.Current.FirstName+" " + AllCooks.Current.LastName).Equals(comboCooks.Text))
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
            double x = 0.0;
            if(!double.TryParse(txtCookHourlyWage.Text, out x))
            {
                lblCookHourError.Visible = true;
                return;
            }else
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
            AddNewCook anc = new AddNewCook();
            anc.Show();
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
            if(!double.TryParse(txtManagerSalary.Text,out x))
            {
                lblManagerSalaryError.Visible = true;
                return;
            }else
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
            AddNewManager anm = new AddNewManager();
            anm.Show();
        }

        public void selectManagerFromCombo(API.Client.Models.Manager manager)
        {
            comboManager.SelectedItem = manager.FirstName + " " + manager.LastName;
        }

        
    }
}
