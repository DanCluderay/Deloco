using System;
using System.Windows.Forms;

namespace Deloco_Pos_C.ctrl
{

    public partial class ctrl_ProductInstance : UserControl
    {
        int productid;
        views.frmAddProductInstance AddInst;
        int DetailDisplayMode;
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public ctrl_ProductInstance()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            DetailDisplayMode = 0;
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
            AddInst = new views.frmAddProductInstance(productid,0);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            radioFullView.Text = "Full View";
            radioInstanceView.Text = "Instance View";
            radioVarientView.Text = "Varient View";

            if (e.ColumnIndex==2)
            {
                //group products by all locations
                radioFullView.Checked = true;
                DetailDisplayMode = 0;
            
                radioFullView.Text = "Full View - " + productid.ToString();
            }
            else if (e.ColumnIndex == 3)
            {
                //group products by stock Instances
                radioInstanceView.Checked = true;
                DetailDisplayMode = 1;
                int i;
                i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                radioInstanceView.Text = "Instance View - " + i.ToString();
            }
            else if (e.ColumnIndex == 4)
            {
                //group products by stock varients
                radioVarientView.Checked = true;
                DetailDisplayMode = 2;
                int v;
                v = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                radioVarientView.Text = "Varient View - " + v.ToString();
            }
            DisplayDetails();
            btnAddMoreStock.Enabled = true;
        }

        private void DisplayDetails()
        {
            stockControlDS.Store_Location_View.Clear();
            if (DetailDisplayMode==0)
            {
                stockControlDS.Merge(logic_global.Get_Product_Store_Full_View(productid));
            }
            else if (DetailDisplayMode == 1)
            {
                int instanceid;
                instanceid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                stockControlDS.Merge(logic_global.Get_Product_Store_Instance_View(instanceid));
            }
            else if (DetailDisplayMode == 2)
            {
                int varienceid;
                varienceid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                stockControlDS.Merge(logic_global.Get_Product_Store_Varience_View(varienceid));
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int instanceid;
            instanceid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if(instanceid==0)
            {
                //bailout
                btnAddMoreStock.Enabled = false;
            }
            else
            {
                AddInst = new views.frmAddProductInstance(productid, instanceid);
                AddInst.On_NewProductAdded += AddInst_On_NewProductAdded;
                AddInst.Show();
            }

        }
    }
}
