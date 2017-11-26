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
    public partial class ctrl_MoveStock : UserControl
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.LocationGrid FromDS;
        local_datasets.LocationGrid ToDS;
        public ctrl_MoveStock()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            
        }
        public void SetUp(int bisid)
        {
            locationGrid.Merge( logic_global.Get_Bis_Locations(3));
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFromLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromDS = new local_datasets.LocationGrid();
            FromDS.Merge(logic_global.Get_Site_Locations("Langold"));
            locationGrid_FROM_LIST_BindingSource.DataSource = FromDS;
        }

        private void txtFromSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtFromSearchBox.Text.Trim().ToString().Length==0)
            {
                locationGrid_FROM_LIST_BindingSource.Filter = "";
            }
            else
            {
                locationGrid_FROM_LIST_BindingSource.Filter = "FullName Like '%" + txtFromSearchBox.Text.ToString() + "%'";
            }
      }
    }
}
