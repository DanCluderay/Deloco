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
    public partial class ctrl_ProductPhysicalProperties : UserControl
    {
       
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.ProductDS LocalDS;
        public ctrl_ProductPhysicalProperties()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            LocalDS = new local_datasets.ProductDS();
        }

        private void ctrl_ProductPhysicalProperties_Load(object sender, EventArgs e)
        {

        }
        public void Setup_Barcode_Control(int BrandProduct)
        {
            productDS.Product_Barcodes.Clear();
            productDS.Merge(logic_global.Get_BrandProduct_Barcodes(BrandProduct));

        }
    }
}
