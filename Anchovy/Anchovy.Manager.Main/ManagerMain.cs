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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnManLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AnchovyContextDataSet.Managers' table. You can move, or remove it, as needed.
            this.ManagersTableAdapter.Fill(this.AnchovyContextDataSet.Managers);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void lblCheese_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCheese.ReadOnly = false;
            txtPepperoni.ReadOnly = false;
            txtBacon.ReadOnly = false;
            txtAnchovies.ReadOnly = false;
            txtPinepples.ReadOnly = false;
            txtGreenPeppers.ReadOnly = false;
            txtBlackOlives.ReadOnly = false;
            txtRedOnions.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtCheese.ReadOnly = true;
            txtPepperoni.ReadOnly = true;
            txtBacon.ReadOnly = true;
            txtAnchovies.ReadOnly = true;
            txtPinepples.ReadOnly = true;
            txtGreenPeppers.ReadOnly = true;
            txtBlackOlives.ReadOnly = true;
            txtRedOnions.ReadOnly = true;
        }
    }
}
