using Anchovy.Customer.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchovy.Customer.Main
{
    public partial class AnchovyCustomerMainGUI : Form
    {
        public AnchovyCustomerMainGUI()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppetizersPanel.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerLoginGUI login = new CustomerLoginGUI();
            login.Show();
            this.Hide();
        }
    }
}
