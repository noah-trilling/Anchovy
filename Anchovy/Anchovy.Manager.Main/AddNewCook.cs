using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anchovy.Models.Utilities;
using Anchovy.API.Client;

namespace Anchovy.Manager.Main
{
    public partial class AddNewCook : Form
    {

        private ICooks _cooks = new AnchovyAPIService().Cooks;
        private IManagers _managers = new AnchovyAPIService().Managers;

        public AddNewCook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool errorFlag = true;
            int x = 0;
            double y = 0.0;
            if(!double.TryParse(txtHourlyWage.Text,out y))
            {
                errorFlag = false;
                lblHourlyWageError.Visible = true;
            }else
            {
                lblHourlyWageError.Visible = false;
            }
            if(!double.TryParse(txtPieceWorkRate.Text, out y))
            {
                errorFlag = false;
                lblPieceWorkError.Visible = true;
            }else
            {
                lblPieceWorkError.Visible = false;
            }
            if(!int.TryParse(txtManagerID.Text, out x))
            {
                errorFlag = false;
                lblManagerErrorNum.Visible = true;
            }else
            {
                lblManagerErrorNum.Visible = false;
                try
                {
                    var manager = _managers.GetManager(x);
                    lblManagerErrorExist.Visible = false;
                }
                catch(Exception ex)
                {
                    errorFlag = false;
                    lblManagerErrorExist.Visible = true;
                }
                
               
            }

            

            if (!errorFlag) return;

            API.Client.Models.Cook NewCook = new API.Client.Models.Cook();
            NewCook.FirstName = txtFirstName.Text;
            NewCook.MiddleName = txtMiddleName.Text;
            NewCook.LastName = txtLastName.Text;
            NewCook.Username = txtUserName.Text;
            NewCook.Password = txtPassword.Text;
            NewCook.Address = txtAddress.Text;
            NewCook.City = txtCity.Text;
            NewCook.State = txtState.Text;
            NewCook.Email = txtEmail.Text;
            NewCook.Phone = txtPhoneNumber.Text;
            NewCook.HourlyWage = Convert.ToDouble(txtHourlyWage.Text);
            NewCook.PieceworkRate = Convert.ToDouble(txtPieceWorkRate.Text);
            NewCook.ManagerId = Convert.ToInt32(txtManagerID.Text);

            _cooks.PostCook(NewCook);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
