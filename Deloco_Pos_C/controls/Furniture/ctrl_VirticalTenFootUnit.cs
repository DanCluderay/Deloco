using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deloco_Pos_C.base_classes;

namespace Deloco_Pos_C.controls.Furniture
{
    public partial class ctrl_VerticalTenFoot : UserControl

        
    {

        private base_classes.ZoneClass zone;

        public base_classes.ZoneClass Zone
        {
            get
            {
                return zone;
            }
            set
            {
                zone = value;
            }
        }

        public ctrl_VerticalTenFoot()
        {
            InitializeComponent();
        }

        private void ctrl_VerticalTenFoot_Load(object sender, EventArgs e)
        {
            base_classes.ZoneClass Zone = new base_classes.ZoneClass();

        }
    }
}
