using System;
using System.Windows.Forms;
using Anchovy.API.Client;
using System.Drawing;
using Anchovy.API.Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;

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
			_menuListings = new AnchovyAPIService().MenuListings;
			_sizes = new AnchovyAPIService().Sizes;
			_lines = new AnchovyAPIService().Lines;
			_orderLines = new AnchovyAPIService().OrderLines;
			_pizzaToppings = new AnchovyAPIService().PizzaToppings;
		   _gQueue = new Queue<Anchovy.API.Client.Models.Order>();
			_mQueue = new Queue<Anchovy.API.Client.Models.Order>();
			//if (completedQueue.Items.Count <= 0) clearQueue.Enabled = false;
		}

		//Logout current cook and return to login screen
		private void logoutButton_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Owner = null;
			Close();
		}

		//Initialize a drag-and-drop operation
		/*private void completedQueue_MouseDown(object sender, MouseEventArgs e)
		{
			globalQueue.ClearSelected();
			myQueue.ClearSelected();
			if (completedQueue.SelectedIndex >= 0) myQueue.DoDragDrop(completedQueue.SelectedItem, DragDropEffects.All);
		}*/

		//Initialize a drag-and-drop operation
		private void globalQueue_MouseDown(object sender, MouseEventArgs e)
		{
			//completedQueue.ClearSelected();
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
				//completedQueue.ClearSelected();
				globalQueue.ClearSelected();
				if (e.Clicks == 1 && myQueue.SelectedIndex >= 0) globalQueue.DoDragDrop(myQueue.SelectedItem, DragDropEffects.All);
			}
		}

		/*private void completedQueue_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
			else e.Effect = DragDropEffects.None;
		}*/

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

		//Add the selected order to completedQueue
		/*private void completedQueue_DragDrop(object sender, DragEventArgs e)
		{
			if (completedQueue.SelectedIndex == -1)
			{
				if (e.Effect == DragDropEffects.Move)
				{
					var item = (string)e.Data.GetData(DataFormats.Text);
					completedQueue.Items.Add(item);
					var split = item.Split();
					var id = Int32.Parse(split[split.Length - 1]);
				   
					if (globalQueue.SelectedIndex >= 0)
					{
						globalQueue.Items.Remove(globalQueue.SelectedItem);
						globalQueue.ClearSelected();
					}
					if (myQueue.SelectedIndex >= 0)
					{
						myQueue.Items.Remove(myQueue.SelectedItem);
						myQueue.ClearSelected();
					}
					clearQueue.Enabled = true;
					 var order = _orders.GetOrder(id);
					order.OrderStatus = (int)OrderStatus.Completed;
					order.CompletedTimeStamp = DateTimeOffset.UtcNow;
					_orders.PutOrder((int)order.Id, order);
				}
			}
		}*/

		//Add the selected order to globalQueue
		private void globalQueue_DragDrop(object sender, DragEventArgs e)
		{
			if (globalQueue.SelectedIndex == -1)
			{
				if (e.Effect == DragDropEffects.Move)
				{
					globalQueue.Items.Add(e.Data.GetData(DataFormats.Text));
					/*if (completedQueue.SelectedIndex >= 0)
					{
						completedQueue.Items.Remove(completedQueue.SelectedItem);
						completedQueue.ClearSelected();
					}*/
					if (myQueue.SelectedIndex >= 0)
					{
						myQueue.Items.Remove(myQueue.SelectedItem);
						myQueue.ClearSelected();
					}
				}
			}
		}

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
				/*	if (completedQueue.SelectedIndex >= 0)
					{
						completedQueue.Items.Remove(completedQueue.SelectedItem);
						completedQueue.ClearSelected();
					}*/
				}
			}
		}

		//Add selected order to the completedQueue
		/*private void completedQueue_DragOver(object sender, DragEventArgs e)
		{
			if (completedQueue.SelectedIndex >= 0) e.Effect = DragDropEffects.None;
		}*/

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
				ingredientsBox.Clear();
				ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
				var order = myQueue.SelectedItem.ToString().Split();
				var orderId = Int32.Parse(order[order.Length - 1]);

				var orderLine = _orderLines.GetOrderLines().GetEnumerator();
				var pizzaToppings = _pizzaToppings.GetPizzaToppings().GetEnumerator();

				while (orderLine.MoveNext())
				{
					if (orderLine.Current.OrderId == orderId)
					{
						//**************** add one line from the order to ingredients box ************************\\
						var line = _lines.GetLine((int)orderLine.Current.LineId);
						var pizza = _pizzas.GetPizza((int)line.PizzaId);

						//**************** add pizza to ingredients box ************************\\
						ingredientsBox.Items.Add("Pizza: " + pizza.Name + "    Qty: " + line.Quantity);

						//**************** add size to ingredients box ************************\\
						var size = _sizes.GetSize((int)pizza.SizeId).Name;
						ingredientsBox.Items.Add("Size: " + size);

						//**************** add crust to ingredients box ************************\\
						var crust = _crusts.GetCrust((int)pizza.CrustId).Name;
						ingredientsBox.Items.Add("Crust: " + crust);

						//**************** add sauce to ingredients box ************************\\
						var sauce = _sauces.GetSauce((int)pizza.SauceId).Name;
						ingredientsBox.Items.Add("Sauce: " + sauce);

						//************ add toppings to ingredients box *********************\\
						ingredientsBox.Items.Add("Toppings:");
						Console.WriteLine("toppings: " + _pizzaToppings.GetPizzaToppings().Count);
						while (pizzaToppings.MoveNext())
						{
							if (pizzaToppings.Current.PizzaId == pizza.Id)
							{
								var topping = _toppings.GetTopping((int)pizzaToppings.Current.ToppingId).Name;
								ingredientsBox.Items.Add("    -" + topping);
							}
						}
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

		//Clear the completed queue
	/*	private void clearQueue_Click(object sender, EventArgs e)
		{
			if (completedQueue.Items.Count > 0)
			{
				completedQueue.Items.Clear();
				clearQueue.Enabled = false;
			}
		}*/

		private void CookMainGUI_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Owner != null) Application.Exit();
		}

		//Cancel an order and place it in the completed queue
		private void contextMenuStrip1_Click(object sender, EventArgs e)
		{
			/*var item = myQueue.SelectedItem;
			completedQueue.Items.Add(item+"  -C");
			myQueue.Items.Remove(item);
			ingredientsBox.Clear();*/
		}

		//Place an item in completed queue. Make canceled orders red.
	/*	private void completedQueue_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			if (e.Index >= 0)
			{
				var item = completedQueue.Items[e.Index].ToString();
				var str = item.Split();
				var isCancel = str[str.Length - 1] == "-C";
                var isComplete = str[str.Length - 1] == "-Completed";
				var color = isCancel ? Brushes.Red : isComplete ? Brushes.Green : Brushes.Black;
				e.Graphics.DrawString(item, completedQueue.Font, color, e.Bounds);
				clearQueue.Enabled = true;
			}
		}*/

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

		//Get the id of the cook and initialize the global queue
		private void CookMainGUI_Load(object sender, EventArgs e)
		{
			_cookId = getCookId();
			initGlobal();
		}

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = myQueue.SelectedItem;
            //completedQueue.Items.Add(item + "  -C");
            myQueue.Items.Remove(item);
            ingredientsBox.Clear();
            ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
            var ord = _mQueue.Dequeue();
            ord.OrderStatus = (int)OrderStatus.Cancelled;
            ord.CancelledTimeStamp = DateTimeOffset.UtcNow;
            _orders.PutOrder((int)ord.Id,ord);
            var d = _orders.GetOrder((int)ord.Id);
            Console.WriteLine("order: " + ord.Customer.FirstName + ", stat: " + d.OrderStatus);
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = myQueue.SelectedItem;
           // completedQueue.Items.Add(item + "  -Completed");
            myQueue.Items.Remove(item);
            ingredientsBox.Clear();
            ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
            var ord = _mQueue.Dequeue();
            ord.OrderStatus = (int)OrderStatus.Completed;
            ord.CompletedTimeStamp = DateTimeOffset.UtcNow;
            _orders.PutOrder((int)ord.Id, ord);
            var d = _orders.GetOrder((int)ord.Id);
            Console.WriteLine("order: " + ord.Customer.FirstName + ", stat: " + d.OrderStatus);
        }
    }
}
