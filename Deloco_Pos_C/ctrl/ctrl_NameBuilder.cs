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
    public partial class ctrl_NameBuilder : UserControl
    {
        public ctrl_NameBuilder()
        {
            InitializeComponent();
        }
        public string PreFix;
        public string PostFix;
        public string BrandID;
        public string BrandName;
        public bool BrandInName;
        public string Size;
        public int RelativeSize;
        private void ctrl_NameBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
