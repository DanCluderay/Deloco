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
    public partial class ctrl_ProductPhysicalProperties : UserControl
    {
        public event EventHandler On_PhysicalPropertiesChanged = delegate { };
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.ProductDS LocalDS;
        views.frmAddEditBarcode BarcodeForm;

        public int ItemTotalVolume { get; set; }
        public int ItemWidth { get; set; }
        public int ItemHeight { get; set; }
        public int ItemLenght { get; set; }
        public double ItemWeight { get; set; }
        public double ItemVolumaticWeight { get; set; }

        public ctrl_ProductPhysicalProperties()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            LocalDS = new local_datasets.ProductDS();
           // BarcodeForm.On_BarcodeEdited += BarcodeForm_On_BarcodeEdited;
           // BarcodeForm.On_BarcodeNew += BarcodeForm_On_BarcodeNew;
        }

        private void BarcodeForm_On_BarcodeNew(object sender, EventArgs e)
        {
            
        }

        private void BarcodeForm_On_BarcodeEdited(object sender, EventArgs e)
        {
            
        }

        private void ctrl_ProductPhysicalProperties_Load(object sender, EventArgs e)
        {

        }
        public void Setup_Barcode_Control(int BrandProduct)
        {
            productDS.Product_Barcodes.Clear();
            productDS.Merge(logic_global.Get_BrandProduct_Barcodes(BrandProduct));

        }

        private void btnAddNewItemBarcode_Click(object sender, EventArgs e)
        {
            BarcodeForm = new views.frmAddEditBarcode();
        }

        private void txtItemidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemidth_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void CalculateVolume()
        {
            int iL;
            int iH;
            int iW;
            int iV;
            double dW;
            double dVW;
            bool res;
            res = int.TryParse(txtItemLenght.Text, out iL);
            if(res==true)
            {
                MessageBox.Show("Lenght not a number");
                return;
            }

            res = int.TryParse(txtItemHeight.Text, out iH);
            if (res == true)
            {
                MessageBox.Show("Height not a number");
                return;
            }

            res = int.TryParse(txtItemidth.Text, out iW);
            if (res == true)
            {
                MessageBox.Show("Width not a number");
                return;
            }

            res = double.TryParse(txtItemWeight.Text, out dW);
            if (res == true)
            {
                MessageBox.Show("Weight not a number");
                return;
            }

            res = double.TryParse(txtVolumetricWeight.Text, out dVW);
            if (res == true)
            {
                MessageBox.Show("Volumetric Weight not a number");
                return;
            }

            ItemWidth = iW;
            ItemHeight = iH;
            ItemLenght = iL;
            ItemVolumaticWeight =dVW;
            ItemTotalVolume = iW * iH * iL;
            ItemWeight = dW;

            txtItemVolume.Text = ItemTotalVolume.ToString();
            On_PhysicalPropertiesChanged(this, new EventArgs());
        }
    }
}
