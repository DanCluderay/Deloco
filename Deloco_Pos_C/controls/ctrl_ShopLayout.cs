using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.controls
{
    public partial class ctrl_ShopLayout : UserControl
    {
        public ctrl_ShopLayout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrl_VerticalTenFoot1.Zone.ZoneID = 1.ToString();
            
        }
    }
}
