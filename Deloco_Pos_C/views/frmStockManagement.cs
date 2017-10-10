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
    public partial class frmStockManagement : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmStockManagement()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string job = "get_productview_by_prodID";
            string res=  logic_global.Make_db_call(job, "1");
            local_datasets.ProductVarientView ProdView = new local_datasets.ProductVarientView();
            ProdView.Merge( logic_global.FormatStringToDataTable(job, res));
            productVarientView.Clear();
            productVarientView.Merge(ProdView);
        }
    }
}
