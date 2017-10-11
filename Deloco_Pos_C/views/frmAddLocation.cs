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

    public partial class frmAddLocation : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.LocationTypes LocTypes =new local_datasets.LocationTypes();
        public frmAddLocation()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void frmAddLocation_Load(object sender, EventArgs e)
        {
            //get the location types
            LocTypes.Merge(logic_global.Get_LocationTypes());
            locationTypes.Clear();
            locationTypes.Merge(LocTypes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLocation();
        }
        private void AddLocation()
        {
            //get loc name
            string Locaname = txtLocationName.Text.ToString();
            //get loc type
            int LocationType = int.Parse( cmbLocationType.SelectedValue.ToString());
            //get loc order
            int Locaorder = 0;
            bool res = int.TryParse(txtLocationPickOrder.Text.ToString(), out Locaorder);
            logic_global.CreateLocGridItem(Locaname, LocationType, Locaorder);
            this.Close();
            
        }
    }
}
