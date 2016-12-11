using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using Anchovy.API.Service.Models;
using System.Collections.Generic;

namespace Anchovy.Cook.Main
{
	public partial class CookMainGUI : Form
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
		private Queue<Anchovy.API.Client.Models.Order> _gQueue;
		private Queue<Anchovy.API.Client.Models.Order> _mQueue;
		private int _cookId;
        private IShifts _shifts;
        private Anchovy.API.Client.Models.Shift _myShift;

		public CookMainGUI()
		{
			InitializeComponent();
			_orders = new AnchovyAPIService().Orders;
			_cooks = new AnchovyAPIService().Cooks;
			_customers = new AnchovyAPIService().Customers;
			_toppings = new AnchovyAPIService().Toppings;
			_pizzas = new AnchovyAPIService().Pizzas;
			_sauces = new AnchovyAPIService().Sauces;
			_crusts = new AnchovyAPIService().Crusts;
            _shifts = new AnchovyAPIService().Shifts;
			_menuListings = new AnchovyAPIService().MenuListings;
			_sizes = new AnchovyAPIService().Sizes;
			_lines = new AnchovyAPIService().Lines;
			_orderLines = new AnchovyAPIService().OrderLines;
			_pizzaToppings = new AnchovyAPIService().PizzaToppings;
		   _gQueue = new Queue<Anchovy.API.Client.Models.Order>();
			_mQueue = new Queue<Anchovy.API.Client.Models.Order>();
			ingredientsBox.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		//Logout current cook and return to login screen; end shift
		private void logoutButton_Click(object sender, EventArgs e)
		{
            endShift();
			Owner.Show();
			Owner = null;
			Close();
		}

		//Initialize a drag-and-drop operation
		private void globalQueue_MouseDown(object sender, MouseEventArgs e)
		{
			myQueue.ClearSelected();
			if (globalQueue.SelectedIndex >= 0) myQueue.DoDragDrop(globalQueue.SelectedItem, DragDropEffects.All);
		}

		//Initialize a drag-and-drop operation, a double click or a right click
		private void myQueue_MouseDown(object sender, MouseEventArgs e)
		{
			myQueue.SelectedIndex = myQueue.IndexFromPoint(e.X, e.Y);
			if (e.Button == MouseButtons.Right)
			{
				if (myQueue.SelectedIndex < 0) contextMenuStrip1.Enabled = false;
				else contextMenuStrip1.Enabled = true;
			}
			else
			{
				globalQueue.ClearSelected();
				if (e.Clicks == 1 && myQueue.SelectedIndex >= 0) globalQueue.DoDragDrop(myQueue.SelectedItem, DragDropEffects.All);
			}
		}

		private void globalQueue_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
			else e.Effect = DragDropEffects.None;
		}

		private void myQueue_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
			else e.Effect = DragDropEffects.None;
		}

		//Add the selected order to globalQueue
		private void globalQueue_DragDrop(object sender, DragEventArgs e)
		{
			if (globalQueue.SelectedIndex == -1)
			{
				if (e.Effect == DragDropEffects.Move)
				{
					globalQueue.Items.Add(e.Data.GetData(DataFormats.Text));

					if (myQueue.SelectedIndex >= 0)
					{
						myQueue.Items.Remove(myQueue.SelectedItem);
						myQueue.ClearSelected();
					}
				}
			}
		}

		//Get the id of the cook hat is logged in
		private int getCookId()
		{
			var user = Text;
			int id = -1;
			var split = user.Split();
			var name = split[split.Length - 1];
			var cooks = _cooks.GetCooks().GetEnumerator();
			while (cooks.MoveNext())
			{
				if (name == cooks.Current.Username)
				{
					id = (int)cooks.Current.Id;
					break;
				}
			}
			return id;
		}

		//Add the selected order to myQueue
		private void myQueue_DragDrop(Object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.Move)
			{
				if (myQueue.SelectedIndex == -1)
				{
					myQueue.Items.Add(e.Data.GetData(DataFormats.Text));
					
					if (globalQueue.SelectedIndex >= 0)
					{
						globalQueue.Items.Remove(globalQueue.SelectedItem);
						globalQueue.ClearSelected();
						var order = _gQueue.Dequeue();
						order = _orders.GetOrder((int)order.Id);
						var cookId = getCookId();
						if (cookId >= 0 && order.CookId == null)
						{
							order.CookId = cookId;
							order.Cook = null;
							var cook = _cooks.GetCook((int)order.CookId);
							var name = cook.FirstName + " " + cook.LastName;
							_orders.PutOrder((int)order.Id, order);
							_mQueue.Enqueue(order);
						}
					}
				}
			}
		}

		//Prevent an item to be dragged and dropped into the same queue it is currently in
		private void globalQueue_DragOver(object sender, DragEventArgs e)
		{
			if (globalQueue.SelectedIndex >= 0) e.Effect = DragDropEffects.None;
		}

		private void myQueue_DragOver(object sender, DragEventArgs e)
		{
			if (myQueue.SelectedIndex >= 0) e.Effect = DragDropEffects.None;
		}

		//Move order from myqueue to ingredients and display ingredients for that order
		private void myQueue_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (myQueue.SelectedIndex >= 0)
			{
				ingredientsBox.Items.Clear();
				ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
				var order = myQueue.SelectedItem.ToString().Split();
				var orderId = Int32.Parse(order[order.Length - 1]);
				var orderLine = _orderLines.GetOrderLines().GetEnumerator();
				
				var count = 0;//print divider or not
				while (orderLine.MoveNext())
				{
					var pizzaToppings = _pizzaToppings.GetPizzaToppings().GetEnumerator();
					if (orderLine.Current.OrderId == orderId)
					{
						//**************** add one line from the order to ingredients box ************************\\
						var line = _lines.GetLine((int)orderLine.Current.LineId);
						if (count > 0) ingredientsBox.Items.Add(new ListViewItem("_____________________________"));

						if (line.MenuListingId != null)
						{
							var menuItem = _menuListings.GetMenuListing((int)line.MenuListingId);
						  
							if (menuItem.SizeId != null)
							{
								var ms = _sizes.GetSize((int)menuItem.SizeId);
								ingredientsBox.Items.Add(new ListViewItem("Pizza: " + menuItem.Name + "    Size: " + ms.Name));
							}
							else ingredientsBox.Items.Add(new ListViewItem("Item: " + menuItem.Name));
						}

						var pizza = _pizzas.GetPizza((int)line.PizzaId);

						//**************** add pizza to ingredients box ************************\\
						ingredientsBox.Items.Add(new ListViewItem("Pizza: " + pizza.Name + "    Qty: " + line.Quantity));

						//**************** add size to ingredients box ************************\\
						var size = _sizes.GetSize((int)pizza.SizeId).Name;
						ingredientsBox.Items.Add(new ListViewItem("Size: " + size));

						//**************** add crust to ingredients box ************************\\
						var crust = _crusts.GetCrust((int)pizza.CrustId).Name;
						ingredientsBox.Items.Add(new ListViewItem("Crust: " + crust));

						//**************** add sauce to ingredients box ************************\\
						var sauce = _sauces.GetSauce((int)pizza.SauceId).Name;
						ingredientsBox.Items.Add(new ListViewItem("Sauce: " + sauce));

						//************ add toppings to ingredients box *********************\\
						
						var c1 = 0; // print toppings or not
						while (pizzaToppings.MoveNext())
						{
							if (pizzaToppings.Current.PizzaId == pizza.Id)
							{
								if (c1 < 1) ingredientsBox.Items.Add(new ListViewItem("Toppings:"));
								var topping = _toppings.GetTopping((int)pizzaToppings.Current.ToppingId).Name;
								ingredientsBox.Items.Add(new ListViewItem("    -" + topping));
								c1++;
							}
						}
						ingredientsBox.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
						count++;
					}
				}
			}
		}

		//Initialize the global queue with orders from database with statuscode == ordered
		private void initGlobal()
		{
			var orders = _orders.GetOrders();
			var order = orders.GetEnumerator();
			_gQueue.Clear();
			
			while (order.MoveNext())
			{
				var stat = order.Current.OrderStatus;
				var id = order.Current.Id;
				var cookId = order.Current.CookId;
				var cust = _customers.GetCustomer((int)order.Current.CustomerId).FirstName + " " + _customers.GetCustomer((int)order.Current.CustomerId).LastName + " - " + id;
				if (stat == (int)Anchovy.API.Service.Models.OrderStatus.Ordered && order.Current.CookId == null)
				{
					globalQueue.Items.Add(cust);
					_gQueue.Enqueue(order.Current);
				}
			} 
		}

		//Close both this form and the loggin form and end shift
		private void CookMainGUI_FormClosed(object sender, FormClosedEventArgs e)
		{
            if (Owner != null)
            {
                endShift();
                Application.Exit();
            }
		}

		//Prevent the contextmenustrip from showing if an item is not selected
		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!contextMenuStrip1.Enabled) e.Cancel = true;
		}

		//Update both the global queue and myQueue so that 1) no claimed orders are in the global queue
		// 2) There are no orders claimed by other cooks in myQueue
		private void refreshButton_Click(object sender, EventArgs e)
		{
			globalQueue.Items.Clear();
			initGlobal();
			refMyQueue();
		}

		//Update myQueue so that there are no orders there that have been claimed by another cook
		private void refMyQueue()
		{
			if (myQueue.Items.Count > 0)
			{
				var c = 0;
				_mQueue.Clear();
				myQueue.SelectedIndex = c;
				while (c < myQueue.Items.Count)
				{
					var split = myQueue.SelectedItem.ToString().Split();
					var ordId = Int32.Parse(split[split.Length - 1]);
					var order = _orders.GetOrder(ordId);
					if (order.CookId != _cookId) myQueue.Items.Remove(myQueue.SelectedItem);
					else _mQueue.Enqueue(order);
					c++;
					if (c < myQueue.Items.Count ) myQueue.SelectedIndex = c;
				}
				myQueue.ClearSelected();
			}
		}

		//Get the id of the cook, initialize the global queue, and set the start time of the shift
		private void CookMainGUI_Load(object sender, EventArgs e)
		{
			_cookId = getCookId();
			initGlobal();
            beginShift();
		}

		//cancel order
		private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var item = myQueue.SelectedItem;
			myQueue.Items.Remove(item);
			ingredientsBox.Items.Clear();
			ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
			var ord = _mQueue.Dequeue();
			ord.OrderStatus = (int)OrderStatus.Cancelled;
			ord.CancelledTimeStamp = DateTimeOffset.UtcNow;
			_orders.PutOrder((int)ord.Id,ord);
			var d = _orders.GetOrder((int)ord.Id);
		}

		//complete order
		private void completeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var item = myQueue.SelectedItem;
			myQueue.Items.Remove(item);
			ingredientsBox.Items.Clear();
			ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
			var ord = _mQueue.Dequeue();
			ord.OrderStatus = (int)OrderStatus.Completed;
			ord.CompletedTimeStamp = DateTimeOffset.UtcNow;
			_orders.PutOrder((int)ord.Id, ord);
			var d = _orders.GetOrder((int)ord.Id);
		}

        //set time for beginning of shift
        private void beginShift()
        {
            var cook = _cooks.GetCook(_cookId);
            _myShift = new Anchovy.API.Client.Models.Shift()
            {
                CookId = _cookId,
                StartTime = DateTimeOffset.UtcNow,
            };
            _shifts.PostShift(_myShift);
        }

        //set time for end of shift
        private void endShift()
        {
            var allShifts = _shifts.GetShifts().GetEnumerator();
            int shiftId = 0;

            while (allShifts.MoveNext())
            {
                if (allShifts.Current.CookId == _cookId && allShifts.Current.StartTime == _myShift.StartTime)
                {
                    shiftId = (int)allShifts.Current.Id;
                    break;
                }
            }
            var shift = _shifts.GetShift(shiftId);
            shift.EndTime = DateTimeOffset.UtcNow;
            _shifts.PutShift((int)shift.Id, shift);
        }
	}
}