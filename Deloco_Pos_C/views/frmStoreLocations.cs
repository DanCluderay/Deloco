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
    }
}
