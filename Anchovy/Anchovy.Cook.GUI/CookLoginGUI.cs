using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anchovy.API.Client;
using Anchovy.API.Client.Models;
using Anchovy.Cook.Main;

namespace Anchovy.Cook.GUI
{
    public partial class CookLoginGUI : Form
    {
        private ICooks _cooks;
        
        public CookLoginGUI()
        {
            InitializeComponent();
            _cooks = new AnchovyAPIService().Cooks;
            invalidUserLabel.ForeColor = Color.Red;
            invalidPassLabel.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            var user = usernameBox.Text;
            var pass = passwordBox.Text;
		   
            if(user.Trim() == "")
            {
                invalidUserLabel.Text = "please enter a username";
            }
            else if (pass.Trim() == "")
            {
                invalidUserLabel.Text = "";
                invalidPassLabel.Text = "please enter a password";
            }
            else
            {
                invalidUserLabel.Text = "";
                invalidPassLabel.Text = "";
                var cooks = _cooks.GetCooks();

                if (!cooks.Any()) Console.WriteLine("There are no cooks in the database");
                else
                {
                    var cook = cooks.Where(_ => _.Username == user);
                    
                    if (cook.Any())
                    {
                        if(pass == cook.First().Password)
                        {
                            CookMainGUI mainG = new CookMainGUI();
                            mainG.Text = "Login- " + cook.First().Username;
                            this.Hide();
                            mainG.Show();
                        }
                        else
                        {
                            invalidPassLabel.Text = "Invalid Password";
                        }
                    }
                    else
                    {
                        invalidUserLabel.Text = "Invalid Username";
                    }
                }
            }
        }

    }
}
