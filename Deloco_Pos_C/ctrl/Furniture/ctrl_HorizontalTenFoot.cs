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
    public partial class ctrl_HorizontalTenFoot : UserControl
    {
        public event EventHandler On_ControlMove = delegate { };
        public event EventHandler On_ControlClick = delegate { };
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
        public base_classes.BayClass Bay { get; set; }

        public ctrl_HorizontalTenFoot()
        {
            InitializeComponent();
        }

        private void ctrl_HorizontalTenFoot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
               On_ControlMove(this, new EventArgs());
            }
        }

        private void ctrl_HorizontalTenFoot_Load(object sender, EventArgs e)
        {

        }

        private void ctrl_HorizontalTenFoot_Click(object sender, EventArgs e)
        {
            On_ControlClick(this, new EventArgs());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
