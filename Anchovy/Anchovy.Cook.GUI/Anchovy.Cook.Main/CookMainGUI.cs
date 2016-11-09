using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Anchovy.Cook.Main
{
    public partial class CookMainGUI : Form
    {
        private Point st;
        public CookMainGUI()
        {
            InitializeComponent();
        }

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


        private void completedQueue_MouseDown(object sender, MouseEventArgs e)
        {
            globalQueue.ClearSelected();
            myQueue.ClearSelected();
            if (completedQueue.SelectedIndex >= 0)
            {
                myQueue.DoDragDrop(completedQueue.SelectedItem, DragDropEffects.All);
            }
        }

        private void globalQueue_MouseDown(object sender, MouseEventArgs e)
        {
            completedQueue.ClearSelected();
            myQueue.ClearSelected();
            if(globalQueue.SelectedIndex >= 0)
            {
                myQueue.DoDragDrop(globalQueue.SelectedItem, DragDropEffects.All);
            }
        }

        private void myQueue_MouseDown(object sender, MouseEventArgs e)
        {
            completedQueue.ClearSelected();
            globalQueue.ClearSelected();
            myQueue.Select();
            if (myQueue.SelectedIndex >= 0)
            {
              completedQueue.DoDragDrop(myQueue.SelectedItem, DragDropEffects.All);
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
                }
            }
        }

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





        private void ingredientsBox_DragDrop(object sender, DragEventArgs e)
        {
            //ListBox box = (ListBox)sender;
            //ingredientsBox.Items.Add(e.Data.GetData(DataFormats.Text));
           // myQueue.Items.Remove(myQueue.SelectedItem);
        }

        private void ingredientsBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            } else
            {
                e.Effect = DragDropEffects.None;
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

        private void myQueue_MouseUp(object sender, MouseEventArgs e)
        {
            // myQueue.ClearSelected();
            //Console.WriteLine("mouse up");
        }

        private void myQueue_MouseClick(object sender, MouseEventArgs e)
        {
            // myQueue.ClearSelected();
            //e.ch
           // Console.WriteLine("mouse click");
        }

        private void myQueue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (myQueue.SelectedIndex >= 0)
            {
                ingredientsBox.Items.Add((String)myQueue.SelectedItem);
                myQueue.Items.Remove(myQueue.SelectedItem);
            }
        }
    }
}
