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
        private IPizzaToppings _pizaaToppings = new AnchovyAPIService().PizzaToppings;

        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnManLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AnchovyContextDataSet.Managers' table. You can move, or remove it, as needed.
            this.ManagersTableAdapter.Fill(this.AnchovyContextDataSet.Managers);
            this.reportViewer1.RefreshReport();
            _toppings = new AnchovyAPIService().Toppings;
            getAllToppingInventory();

            lblDailySalesValue.Text = "" + getAllSales();



        }

        public void getAllToppingInventory()
        {
            var AllToppings = _toppings.GetToppings().GetEnumerator();

            while (AllToppings.MoveNext())
            {
               if(AllToppings.Current.Name == "Cheese")
               {
                    lblCheeseValue.Text = "" + AllToppings.Current.Quantity;
               }
               if (AllToppings.Current.Name == "Onions")
               {
                    lblRedOnionsValue.Text = "" + AllToppings.Current.Quantity;
                    if(AllToppings.Current.Quantity < AllToppings.Current.LowLevel)
                    {
                        lblRedOnionsValue.ForeColor = Color.Red;
                    }else
                    {
                        lblRedOnionsValue.ForeColor = Color.Black;
                    }
               }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void lblCheese_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCheese.ReadOnly = false;
            txtPepperoni.ReadOnly = false;
            txtBacon.ReadOnly = false;
            txtAnchovies.ReadOnly = false;
            txtPinepples.ReadOnly = false;
            txtGreenPeppers.ReadOnly = false;
            txtBlackOlives.ReadOnly = false;
            txtRedOnions.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtCheese.ReadOnly = true;
            txtPepperoni.ReadOnly = true;
            txtBacon.ReadOnly = true;
            txtAnchovies.ReadOnly = true;
            txtPinepples.ReadOnly = true;
            txtGreenPeppers.ReadOnly = true;
            txtBlackOlives.ReadOnly = true;
            txtRedOnions.ReadOnly = true;


            if(txtRedOnions.Text != "")
            {
                int amnt = Int32.Parse(txtRedOnions.Text);
                var AllToppings = _toppings.GetToppings().GetEnumerator();
                Anchovy.API.Client.Models.Topping onion = null;
                while (AllToppings.MoveNext())
                {
                   
                    if (AllToppings.Current.Name == "Onions")
                    {
                    
                        onion = AllToppings.Current;
                    }

                }
                onion.Quantity += amnt;
                _toppings.PutTopping((int)onion.Id, onion);
                getAllToppingInventory();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  e.RowIndex
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
                    total += getMenuListingCost((int)AllLines.Current.MenuListingId)*((int)AllLines.Current.Quantity);
                }
            }

            return total;
        }

        private double getMenuListingCost(int menuListingId)
        {
            var AllMenuListings = _menulistings.GetMenuListings().GetEnumerator();
            double returnValue = 0.0;
            while (AllMenuListings.MoveNext())
            {
                if(menuListingId == (int)AllMenuListings.Current.Id)
                {
                    returnValue = (double)AllMenuListings.Current.Cost;
                }
                    
            }
            return returnValue;
        }

        private double getPizzaCost(int pizzaId)
        {
            return 0.0;
        }
    }
}
