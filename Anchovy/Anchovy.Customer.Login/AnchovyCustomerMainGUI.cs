using Anchovy.Customer.Login;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Anchovy.API.Client;

namespace Anchovy.Customer.Main
{
    public partial class AnchovyCustomerMainGUI : Form
    {
        private ICustomers _customers;

        public AnchovyCustomerMainGUI()
        {
            InitializeComponent();
        }

        private void cancelApps_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Hide();
        }

        private void appetizersButton_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Show();
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
    }
}
