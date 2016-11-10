using System;
using System.Windows.Forms;
using System.Threading;
using Anchovy.API.Client;

namespace Anchovy.Cook.Main
{
    public partial class CookMainGUI : Form
    {
        private IOrders _orders;

        public CookMainGUI()
        {
            InitializeComponent();
            _orders = new AnchovyAPIService().Orders;
            if (completedQueue.Items.Count <= 0)
            {
                clearQueue.Enabled = false;
            }
           // initGlobal();
        }

        //Logout current cook and return to login screen
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(launchLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void launchLogin()
        {
            //Application.Run(new CookLoginGUI);
        }

        //Initialize a drag-and-drop operation
        private void completedQueue_MouseDown(object sender, MouseEventArgs e)
        {
            globalQueue.ClearSelected();
            myQueue.ClearSelected();
            
            if (completedQueue.SelectedIndex >= 0)
            {
                myQueue.DoDragDrop(completedQueue.SelectedItem, DragDropEffects.All);
            }
        }

        //Initialize a drag-and-drop operation
        private void globalQueue_MouseDown(object sender, MouseEventArgs e)
        {
            completedQueue.ClearSelected();
            myQueue.ClearSelected();
            if(globalQueue.SelectedIndex >= 0)
            {
                myQueue.DoDragDrop(globalQueue.SelectedItem, DragDropEffects.All);
            }
        }
        //Initialize a drag-and-drop operation or a double click 
        private void myQueue_MouseDown(object sender, MouseEventArgs e)
        {
            var clicks = e.Clicks;
            completedQueue.ClearSelected();
            globalQueue.ClearSelected();
            if (clicks == 1) {
                if (myQueue.SelectedIndex >= 0)
                {
                    completedQueue.DoDragDrop(myQueue.SelectedItem, DragDropEffects.All);
                }
            }
            else if(clicks >= 1)
            {
                myQueue_MouseDoubleClick(sender, e);
            }
        }

        private void completedQueue_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void globalQueue_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void myQueue_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Add the selected item into completedQueue
        private void completedQueue_DragDrop(object sender, DragEventArgs e)
        {
            if (completedQueue.SelectedIndex == -1)
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    completedQueue.Items.Add(e.Data.GetData(DataFormats.Text));
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
                }
            }
        }

        //Add the selected item into globalQueue
        private void globalQueue_DragDrop(object sender, DragEventArgs e)
        {
            if (globalQueue.SelectedIndex == -1)
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    globalQueue.Items.Add(e.Data.GetData(DataFormats.Text));
                    if (completedQueue.SelectedIndex >= 0)
                    {
                        completedQueue.Items.Remove(completedQueue.SelectedItem);
                        completedQueue.ClearSelected();
                    }
                    if (myQueue.SelectedIndex >= 0)
                    {
                        myQueue.Items.Remove(myQueue.SelectedItem);
                        myQueue.ClearSelected();
                    }
                }
            }
        }

        //Add the selected item into myQueue
        private void myQueue_DragDrop(Object sender, DragEventArgs e)
        {
            if(e.Effect == DragDropEffects.Move)
            {
                if (myQueue.SelectedIndex == -1)
                {
                    myQueue.Items.Add(e.Data.GetData(DataFormats.Text));
                    if (globalQueue.SelectedIndex >= 0)
                    {
                        globalQueue.Items.Remove(globalQueue.SelectedItem);
                        globalQueue.ClearSelected();
                    }
                    if (completedQueue.SelectedIndex >= 0)
                    {
                        completedQueue.Items.Remove(completedQueue.SelectedItem);
                        completedQueue.ClearSelected();
                    }
                }
            }
           
        }
   
        private void completedQueue_DragOver(object sender, DragEventArgs e)
        {
            if (completedQueue.SelectedIndex >= 0)
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void globalQueue_DragOver(object sender, DragEventArgs e)
        {
            if(globalQueue.SelectedIndex >= 0)
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void myQueue_DragOver(object sender, DragEventArgs e)
        {
            if (myQueue.SelectedIndex >= 0)
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Move item from myqueue to ingredients and display ingredients for that order
        private void myQueue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (myQueue.SelectedIndex >= 0)
            {
                ingredientsLabel.Text = ingredientsLabel.Text.Split()[0] + " - " + myQueue.SelectedItem;
                myQueue.Items.Remove(myQueue.SelectedItem);
                myQueue.ClearSelected();
            }
        }

        //Initialize the global queue with orders from database with (whichever?) statuscode
        private void initGlobal()
        {
            Console.WriteLine("here");
            var orders = _orders.GetOrders();
            var or = orders.Count;
            Console.WriteLine("count:: " + or);
            var o = orders.GetEnumerator();
            o.MoveNext();
            var p = o.Current.Lines.GetEnumerator();
            p.MoveNext();

            for (int i = 0; i < orders.Count;++i)
            {
                Console.WriteLine("order#: " + o.Current.Id);
                Console.WriteLine("name#: " + p.Current.Pizza.Name); //globalQueue.Items.Add(p.Current.Pizza.Name);
                o.MoveNext();
                p = o.Current.Lines.GetEnumerator();
                p.MoveNext();
            }
        }

        //Clear the completed queue
        private void clearQueue_Click(object sender, EventArgs e)
        {
            if (completedQueue.Items.Count > 0)
            {
                completedQueue.Items.Clear();
                clearQueue.Enabled = false;
            }
        }
    }
}
