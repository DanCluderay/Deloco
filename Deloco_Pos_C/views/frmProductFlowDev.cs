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
    public partial class frmProductFlowDev : Form
    {
        public frmProductFlowDev()
        {
            InitializeComponent();
            ctrl_edit_prodcut1.Request_Close += Ctrl_edit_prodcut1_Request_Close;
        }

        private void Ctrl_edit_prodcut1_Request_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmProductFlowDev(int ProductID)
        {
            InitializeComponent();
            ctrl_edit_prodcut1.Request_Close += Ctrl_edit_prodcut1_Request_Close;
            ctrl_edit_prodcut1.LoadProductDetails(ProductID);
            
        }
        private void ctrl_edit_prodcut1_Load(object sender, EventArgs e)
        {

        }

        private void frmProductFlowDev_Load(object sender, EventArgs e)
        {

        }
    }
}
