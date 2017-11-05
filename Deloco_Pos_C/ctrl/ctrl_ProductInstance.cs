using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.ctrl
{
     
    public partial class ctrl_ProductInstance : UserControl
    {
        int productid;
        views.frmAddProductInstance AddInst;
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public ctrl_ProductInstance()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        
        public void  SetUpProduct(int ProductID)
        {
            productid = ProductID;
            DisplayProductStockLocations();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInst = new views.frmAddProductInstance(productid);
            AddInst.On_NewProductAdded += AddInst_On_NewProductAdded;
            AddInst.Show();
        }

        private void AddInst_On_NewProductAdded(object sender, EventArgs e)
        {
            AddInst.Close();
            DisplayProductStockLocations();
        }
        private void DisplayProductStockLocations()
        {
            productDS.Product_Stock_Location_View.Clear();
            if(chkShowHistorical.Checked==true)
            {
                productDS.Merge(logic_global.Get_Product_Stock_Locations_historical(productid)); 
            }
            else
            {
                productDS.Merge( logic_global.Get_Product_Stock_Locations(productid));
            }
            
        }

        private void chkShowHistorical_CheckedChanged(object sender, EventArgs e)
        {
            DisplayProductStockLocations();
        }
    }
}
