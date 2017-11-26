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
            DisplayStockList();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayStockList();
        }
        private void DisplayStockList()
        {
            stockControlDS.StockControl.Clear();
            stockControlDS.Merge(logic_global.GetAllStock());
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the locations of the stock at a store level
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void DG_ProductView_DoubleClick(object sender, EventArgs e)
        {
            int ProductID = 0;
            ProductID =int.Parse( DG_ProductView.CurrentRow.Cells[0].Value.ToString());
            if(ProductID != 0)
            {
                views.frmProductFlowDev ProdDetails = new views.frmProductFlowDev(ProductID);
                ProdDetails.MdiParent = this.MdiParent;
                ProdDetails.Show();
                ProdDetails.WindowState=FormWindowState.Maximized;
            }
            
        }
    }
}
