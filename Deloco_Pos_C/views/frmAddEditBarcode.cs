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
    public partial class frmAddEditBarcode : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public event EventHandler On_BarcodeEdited = delegate { };
        public event EventHandler On_BarcodeNew = delegate { };
        public frmAddEditBarcode()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void frmAddEditBarcode_Load(object sender, EventArgs e)
        {

        }
    }
}
