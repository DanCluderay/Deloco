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
    public partial class ctrl_edit_prodcut : UserControl
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public ctrl_edit_prodcut()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void ctrl_edit_prodcut_Load(object sender, EventArgs e)
        {
            ctrl_NameBuilder1.On_BrandProductChanged += Ctrl_NameBuilder1_On_BrandProductChanged;

        }

        private void Ctrl_NameBuilder1_On_BrandProductChanged(object sender, EventArgs e)
        {
            ctrl_ProductPhysicalProperties1.Setup_Barcode_Control(ctrl_NameBuilder1.BrandProduct);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        
    }
}
