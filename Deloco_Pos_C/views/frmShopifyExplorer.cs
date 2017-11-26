using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.views
{
    public partial class frmShopifyExplorer : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmShopifyExplorer()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void frmShopifyExplorer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic_global.shopify_get_all_products();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic_global.shopify_create_new_product();
        }
    }
}
