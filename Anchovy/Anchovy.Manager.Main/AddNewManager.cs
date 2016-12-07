using Anchovy.API.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchovy.Manager.Main
{
    public partial class AddNewManager : Form
    {
        private IManagers _managers = new AnchovyAPIService().Managers;

        public AddNewManager()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool errorFlag = true;
            int x = 0;
            double y = 0.0;
            if (!double.TryParse(txtSalary.Text, out y))
            {
                errorFlag = false;
                lblSalaryError.Visible = true;
            }
            else
            {
                lblSalaryError.Visible = false;
            }

            if (!errorFlag) return;

            API.Client.Models.Manager NewManager = new API.Client.Models.Manager();
            NewManager.FirstName = txtFirstName.Text;
            NewManager.MiddleName = txtMiddleName.Text;
            NewManager.LastName = txtLastName.Text;
            NewManager.Username = txtUserName.Text;
            NewManager.Password = txtPassword.Text;
            NewManager.Address = txtAddress.Text;
            NewManager.City = txtCity.Text;
            NewManager.State = txtState.Text;
            NewManager.Email = txtEmail.Text;
            NewManager.Phone = txtPhoneNumber.Text;
            NewManager.Salary = Convert.ToDouble(txtSalary.Text);

            _managers.PostManager(NewManager);
            ManagerMain mm = new ManagerMain();
            mm.PopulateManagersComboBox();
            mm.selectManagerFromCombo(NewManager);
            this.Close();
        }
    }
}
