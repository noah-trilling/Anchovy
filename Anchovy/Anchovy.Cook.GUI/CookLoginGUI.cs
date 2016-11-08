using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Anchovy.API.Client;
using Anchovy.Cook.Main;
using System.Threading;

namespace Anchovy.Cook.GUI
{
    public partial class CookLoginGUI : Form
    {
        private ICooks _cooks;
        private CookMainGUI _mainG;


        public CookLoginGUI()
        {
            InitializeComponent();
            _cooks = new AnchovyAPIService().Cooks;
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
                            _mainG = new CookMainGUI();
                            _mainG.Text = "Login- " + cook.First().Username;
                            Thread th = new Thread(launchMain);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
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

       private void launchMain()
        {
            Application.Run(_mainG);
        }

        private void invalidUserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
