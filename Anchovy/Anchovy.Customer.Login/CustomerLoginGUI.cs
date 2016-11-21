using Anchovy.Customer.ForgotPassword;
using Anchovy.Customer.Main;
using Customer.SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchovy.Customer.Login
{
    public partial class CustomerLoginGUI : Form
    {

        public CustomerLoginGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnchovyCustomerMainGUI main = new AnchovyCustomerMainGUI();
            main.Show();
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            CustomerForgotPasswordGUI forgotPword = new CustomerForgotPasswordGUI();
            forgotPword.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerSignUpGUI signup = new CustomerSignUpGUI();
            signup.Show();
            this.Hide();
        }
    }
}
