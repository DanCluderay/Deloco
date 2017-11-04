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
        public ctrl_ProductInstance()
        {
            InitializeComponent();
        }
        
        public void  SetUpProduct(int ProductID)
        {
            productid = ProductID;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            views.frmAddProductInstance AddInst = new views.frmAddProductInstance(productid);
            //AddInst.MdiParent=
            AddInst.Show();
        }
    }
}
