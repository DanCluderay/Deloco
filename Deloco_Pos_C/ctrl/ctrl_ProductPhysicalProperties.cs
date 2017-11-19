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
        public int ExpiryDateType { get; set; }

        public ctrl_ProductPhysicalProperties()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            LocalDS = new local_datasets.ProductDS();
            productDS.Merge(logic_global.Get_ExpiryDateType());
           // BarcodeForm.On_BarcodeEdited += BarcodeForm_On_BarcodeEdited;
           // BarcodeForm.On_BarcodeNew += BarcodeForm_On_BarcodeNew;
        }

        public void SetupProduct(local_datasets.ProductDS ProdDS)
        {
            local_datasets.ProductDS.ProductsRow ProdRow = (local_datasets.ProductDS.ProductsRow)ProdDS.Products.Rows[0];
            txtItemHeight.Text = ProdRow.ProductHeight.ToString();
            txtItemLenght.Text = ProdRow.ProductLenght.ToString();
            txtItemidth.Text = ProdRow.ProductWidth.ToString();

            txtItemWeight.Text = ProdRow.ProductRealWeight.ToString();
            txtVolumetricWeight.Text = ProdRow.ProductTotalVolume.ToString();
            cmbExpiryDateType.SelectedValue = ProdRow.ProductDateType;
            Setup_Barcode_Control(ProdRow.BrandProduct);
            CalculateVolume();

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
            CalculateVolume();
        }
        private void CalculateVolume()
        {
            int iL;
            int iH;
            int iW;
            double dW;
            double dVW;
            bool res;
            res = int.TryParse(txtItemLenght.Text, out iL);
            if(res==false)
            {
                //MessageBox.Show("Lenght not a number");
                return;
            }

            res = int.TryParse(txtItemHeight.Text, out iH);
            if (res == false)
            {
                //MessageBox.Show("Height not a number");
                return;
            }

            res = int.TryParse(txtItemidth.Text, out iW);
            if (res == false)
            {
                //MessageBox.Show("Width not a number");
                return;
            }

            res = double.TryParse(txtItemWeight.Text, out dW);
            if (res == false)
            {
                //MessageBox.Show("Weight not a number");
                return;
            }

            res = double.TryParse(txtVolumetricWeight.Text, out dVW);
            if (res == false)
            {
                //MessageBox.Show("Volumetric Weight not a number");
                return;
            }

            ItemWidth = iW;
            ItemHeight = iH;
            ItemLenght = iL;
            ItemVolumaticWeight = dW*1.1;
            ItemTotalVolume = iW * iH * iL;
            ItemWeight = dW;
            ExpiryDateType =Convert.ToInt32(cmbExpiryDateType.SelectedValue);

            txtItemVolume.Text = ItemTotalVolume.ToString();
            On_PhysicalPropertiesChanged(this, new EventArgs());
        }

        private void txtItemHeight_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateVolume();
        }

        private void txtItemLenght_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateVolume();
        }

        private void txtItemWeight_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateVolume();
        }

        private void tabItem_Click(object sender, EventArgs e)
        {

        }

        private void txtItemLenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbExpiryDateType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(this.Disposing==true)
            {

            }
            CalculateVolume();
        }
    }
}
