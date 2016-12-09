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

namespace Anchovy.Manager.Main
{
    public partial class ManagerLogin : Form
    {

        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool userflag = false;
            IManagers _managers = new AnchovyAPIService().Managers;
            var AllManagers = _managers.GetManagers().GetEnumerator();
            int managerID = 0;
            while (AllManagers.MoveNext())
            {
                if (txtUserName.Text.Equals(AllManagers.Current.Username))
                {
                    userflag = true;
                    managerID = (int)AllManagers.Current.Id;
                }
            }
            if(userflag == false)
            {
                lblInvaildUser.Text = "Invaild Username";
            }else
            {
                lblInvaildUser.Text = "";
                var manager = _managers.GetManager(managerID);
                if (!txtPassword.Text.Equals(manager.Password))
                {
                    lblInvaildPassword.Text = "Invaild Password";
                }else
                {
                    lblInvaildPassword.Text = "";
                    ManagerMain mm = new ManagerMain();
                    if (manager.Username != "admin") mm.hideManagersTab();
                    mm.Text = "Manager Main - " + manager.Username;
                    mm.Show();
                    Hide();
                }
            }
            
        }
    }
}
