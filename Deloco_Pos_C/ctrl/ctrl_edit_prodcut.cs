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
        base_classes.productclass ProdClass;
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public ctrl_edit_prodcut()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void ctrl_edit_prodcut_Load(object sender, EventArgs e)
        {
            ctrl_NameBuilder1.On_BrandProductChanged += Ctrl_NameBuilder1_On_BrandProductChanged;
            ctrl_NameBuilder1.On_NameChanged += Ctrl_NameBuilder1_On_NameChanged;
            ctrl_ProductPhysicalProperties1.On_PhysicalPropertiesChanged += Ctrl_ProductPhysicalProperties1_On_PhysicalPropertiesChanged;
            ProdClass = new base_classes.productclass();
        }

        private void Ctrl_ProductPhysicalProperties1_On_PhysicalPropertiesChanged(object sender, EventArgs e)
        {
            ProdClass.ItemHeight = ctrl_ProductPhysicalProperties1.ItemHeight;
            ProdClass.ItemLegnth = ctrl_ProductPhysicalProperties1.ItemLenght ;
            ProdClass.ItemWidth = ctrl_ProductPhysicalProperties1.ItemWidth;
            ProdClass.ItemVolume = ctrl_ProductPhysicalProperties1.ItemTotalVolume;
            ProdClass.ItemVolumetricWeight = ctrl_ProductPhysicalProperties1.ItemVolumaticWeight;
            ProdClass.ItemRealWeight = ctrl_ProductPhysicalProperties1.ItemWeight;
            
        }

        private void Ctrl_NameBuilder1_On_NameChanged(object sender, EventArgs e)
        {
            ProdClass.BrandID = ctrl_NameBuilder1.BrandID;
            ProdClass.BrandInName = ctrl_NameBuilder1.BrandInName;
            ProdClass.BrandName = ctrl_NameBuilder1.BrandName;
            ProdClass.BrandProductID = ctrl_NameBuilder1.BrandProduct;
            ProdClass.BrandProductName = ctrl_NameBuilder1.ProductName;
            ProdClass.BrandProductSize = ctrl_NameBuilder1.TheSize;
            //ProdClass.FullProductName= ctrl_NameBuilder1.
            ProdClass.InnerPackQTY = 0;
            ProdClass.IsCasePick = false;
            ProdClass.IsLocked = false;
            ProdClass.IsLockedBy = 0;
            
            ProdClass.PostFox = ctrl_NameBuilder1.PostFix;
            ProdClass.PreFix = ctrl_NameBuilder1.PreFix;
            ProdClass.ProductLongDescription = "";
            ProdClass.ProductRelativeSize = 0;
            ProdClass.ProductRRP = 0;
            ProdClass.ProductShortDescription = "";
            ProdClass.ProductUnitSize = 0;
            ProdClass.ProductVATCode = 0;
            ProdClass.SizeString = "";

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
