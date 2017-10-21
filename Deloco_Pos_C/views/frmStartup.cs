using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C
{
    public partial class frmStartup : Form
    {
        helper_functions.globalHelper logic_global =  helper_functions.globalHelper.Instance;
        views.frmSignIn Signin;
        public frmStartup()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            logic_global.On_Signed_in += Logic_global_On_Signed_in;
        }

        private void Logic_global_On_Signed_in(object sender, EventArgs e)
        {
            //when a user has been signed in
            this.marketingToolStripMenuItem.Enabled = true;
            this.customersToolStripMenuItem.Enabled = true;
            this.productsToolStripMenuItem.Enabled = true;
            this.shopLocationsToolStripMenuItem.Enabled = true;
            this.stockManagerToolStripMenuItem.Enabled = true;
            this.managementToolStripMenuItem.Enabled = true;
            this.areaManagmentToolStripMenuItem.Enabled = true;
            this.configToolStripMenuItem.Enabled = true;
            this.ordersToolStripMenuItem.Enabled = true;
            this.stockToolStripMenuItem.Enabled = true;
            this.Text = "Ask the milkman - Langold Shop";
            Signin.WindowState = FormWindowState.Minimized;
        }

        private void developmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 devform = new Form1();
            devform.MdiParent = this;
            devform.Show();
        }
        private void DisplayLogin()
        {
            if (Signin != null)

            {
                Signin.Close();
            }
                  

            Signin = new views.frmSignIn();
            Signin.MdiParent = this;
            Signin.Show();
            Signin.WindowState = FormWindowState.Normal;
            
           
           
        }
        private void frmStartup_Load(object sender, EventArgs e)
        {


            //logic_global.Mqtt_Subscribe("cluderay");
            //logic_global.Mqtt_Subscribe("locations_change");
            //logic_global.Mqtt_Subscribe("users_change");
            DisplayLogin();
            this.Text = "Ask the milkman";
            this.WindowState = FormWindowState.Maximized;
        }

        private void mQTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmMqtt mqttform = new views.frmMqtt();
            mqttform.MdiParent = this;
            mqttform.Show();
        }

        private void outstandingOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmLiveDemo LiveDemo = new views.frmLiveDemo();
            LiveDemo.MdiParent = this;
            LiveDemo.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmPOS POS = new views.frmPOS();
            POS.MdiParent = this;
            POS.Show();
        }

        private void viewAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmAllCustomer CustForm= new views.frmAllCustomer();
            CustForm.MdiParent = this;
            CustForm.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmStockManagement Stock = new views.frmStockManagement();
            Stock.MdiParent = this;
            Stock.Show();

        }

        private void shopLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmStoreLocations storeLocations = new views.frmStoreLocations();
            storeLocations.MdiParent = this;
            storeLocations.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.marketingToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.productsToolStripMenuItem.Enabled = false;
            this.shopLocationsToolStripMenuItem.Enabled = false;
            this.stockManagerToolStripMenuItem.Enabled = false;
            this.managementToolStripMenuItem.Enabled = false;
            this.areaManagmentToolStripMenuItem.Enabled = false;
            this.configToolStripMenuItem.Enabled = false;
            this.ordersToolStripMenuItem.Enabled = false;
            this.stockToolStripMenuItem.Enabled = false;
            Signin.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLogin();
        }

        private void locationGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmLocation_Grid LocGrid = new views.frmLocation_Grid();
            LocGrid.MdiParent = this;
            LocGrid.Show();
        }
    }
}
