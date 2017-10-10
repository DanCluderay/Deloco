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
    public partial class frmStoreLocations : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmStoreLocations()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            logic_global.On_Shop_Location_Update += Logic_global_On_Shop_Location_Update;
        }

        private void Logic_global_On_Shop_Location_Update(object sender, EventArgs e)
        {
            DisplayLocations();
        }

        private void frmStoreLocations_Load(object sender, EventArgs e)
        {
            DisplayLocations();
        }

        private void getstorelocations()
        {
            //go to the server and get a list of locations
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayLocations();
        }
        private void DisplayLocations()
        {
            string job = "get_all_shops";
            string responece = logic_global.Make_db_call(job, "");
            local_datasets.store_locations StoresDS = new local_datasets.store_locations();
            store_locations.Clear();
            StoresDS.Merge(logic_global.FormatStringToDataTable(job, responece));
            store_locations.Merge(StoresDS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            views.frmAddEditLocations Store_New = new frmAddEditLocations();
            Store_New.MdiParent = this.MdiParent;
            Store_New.Setupform("NEW", 0, "", "");
            Store_New.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            views.frmAddEditLocations Store_New = new frmAddEditLocations();
            Store_New.MdiParent = this.MdiParent;
            int shopid = 0;
            bool result= int.TryParse(txtShopID.Text.ToString(),out shopid);
            string shopname = txtShopName.Text.ToString();
            string shopcode = txtShopCode.Text.ToString();
            Store_New.Setupform("UPDATE", shopid, shopname, shopcode);
            Store_New.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string shopid = "";
                string shopname = "";
                string shopcode = "";

                shopid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                shopname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                shopcode = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                txtShopID.Text = shopid.ToString();
                txtShopName.Text = shopname.ToString();
                txtShopCode.Text = shopcode.ToString();
                if (shopid != "")
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
