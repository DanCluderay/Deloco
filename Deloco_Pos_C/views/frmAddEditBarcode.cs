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

        private int screen_mode;
        private int BarcodeType;
        public frmAddEditBarcode()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        public frmAddEditBarcode(string productame, int Mode,int barcodetype, string barcode,int caseqty)
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            screen_mode = Mode;
            lblProductName.Text = productame;
            BarcodeType = barcodetype;
            if ( screen_mode==0)
            {
                this.Text = "Add New Barcode";
            }
            else if(screen_mode == 1)
            {
                this.Text = "Edit Barcode";
            }
            if (BarcodeType == 0)
            {
                txtCaseQTY.Visible = false;
                lblCaseQTY.Visible = false;
            }
            else if (BarcodeType == 1)
            {
                txtCaseQTY.Visible = true;
                lblCaseQTY.Visible = true;
            }

            txtBarcode.Text = barcode;
            txtCaseQTY.Text = caseqty.ToString();
        }

        private void frmAddEditBarcode_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
