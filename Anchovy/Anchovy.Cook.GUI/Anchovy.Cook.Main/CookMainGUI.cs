using System;
using System.Windows.Forms;
using System.Threading;

namespace Anchovy.Cook.Main
{
    public partial class CookMainGUI : Form
    {
        

        public CookMainGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
