using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Deloco_Pos_C.ctrl
{
    public partial class ctrl_edit_prodcut : UserControl
    {
        bool setupmode;
        local_datasets.ProductDS DS;
        base_classes.productclass ProdClass;
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public ctrl_edit_prodcut()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void ctrl_edit_prodcut_Load(object sender, EventArgs e)
        {
            setupmode = true;
            ctrl_NameBuilder2.On_BrandProductChanged += Ctrl_NameBuilder1_On_BrandProductChanged;
            ctrl_NameBuilder2.On_NameChanged += Ctrl_NameBuilder1_On_NameChanged;
            ctrl_ProductPhysicalProperties1.On_PhysicalPropertiesChanged += Ctrl_ProductPhysicalProperties1_On_PhysicalPropertiesChanged;
            ProdClass = new base_classes.productclass();
            DS = new local_datasets.ProductDS();
            setupmode = false;
        }

        private void Ctrl_ProductPhysicalProperties1_On_PhysicalPropertiesChanged(object sender, EventArgs e)
        {
            ProdClass.ItemHeight = ctrl_ProductPhysicalProperties1.ItemHeight;
            ProdClass.ItemLegnth = ctrl_ProductPhysicalProperties1.ItemLenght ;
            ProdClass.ItemWidth = ctrl_ProductPhysicalProperties1.ItemWidth;
            ProdClass.ItemVolume = ctrl_ProductPhysicalProperties1.ItemTotalVolume;
            ProdClass.ItemVolumetricWeight = ctrl_ProductPhysicalProperties1.ItemVolumaticWeight;
            ProdClass.ItemRealWeight = ctrl_ProductPhysicalProperties1.ItemWeight;
            Display_props();
        }

        private void Ctrl_NameBuilder1_On_NameChanged(object sender, EventArgs e)
        {
            ctrl_NameBuilder NameControl = sender as ctrl_NameBuilder;
            ProdClass.BrandID = NameControl.BrandID;
            ProdClass.BrandInName = NameControl.BrandInName;
            ProdClass.BrandName = NameControl.BrandName;
            ProdClass.BrandProductID = NameControl.BrandProduct;
            ProdClass.BrandProductName = NameControl.ProductName;
            ProdClass.BrandProductSize = NameControl.TheSize;
            ProdClass.FullProductName = NameControl.FullProductName;
            ProdClass.InnerPackQTY = 0;
            ProdClass.IsCasePick = false;
            ProdClass.IsLocked = false;
            ProdClass.IsLockedBy = 0;
            
            ProdClass.PostFox = NameControl.PostFix;
            ProdClass.PreFix = NameControl.PreFix;
            ProdClass.ProductLongDescription = "";
            ProdClass.ProductRelativeSize = 0;
            ProdClass.ProductRRP = 0;
            ProdClass.ProductShortDescription = "";
            ProdClass.ProductUnitSize = 0;
            ProdClass.ProductVATCode = 0;
            ProdClass.ProductUnitSize = NameControl.TheUnitSize;
            ProdClass.ProductRelativeSize = NameControl.TheRelativeSize;
            
            Display_props();
        }
        private void Display_props()
        {
            if (setupmode==false)
            {
                Type type = ProdClass.GetType();
                PropertyInfo[] properties = type.GetProperties();
                listBox1.Items.Clear();
                DS.ValuePair.Clear();
                foreach (PropertyInfo property in properties)
                {
                    string Vlau = "Name: " + property.Name + ", Value: " + property.GetValue(ProdClass, null);
                
                    listBox1.Items.Add(Vlau);

                    local_datasets.ProductDS.ValuePairRow NewRow = DS.ValuePair.NewValuePairRow();
                    if(property.GetValue(ProdClass, null) != null)
                    {
                        NewRow.value = property.GetValue(ProdClass, null).ToString();
                    }
                    else
                    {
                        NewRow.value = "";
                    }
                    if (property.Name.ToString() != null)
                    {
                        NewRow.Prop = property.Name.ToString();
                    }
                    else
                    {
                        NewRow.Prop = "";
                    }

                    DS.ValuePair.AddValuePairRow(NewRow);

                }
                productDS.ValuePair.Clear();
                productDS.Merge(DS);

               foreach( DataGridViewRow Row in dataGridView1.Rows)
                {
                    if(Row.Cells[1].Value.ToString() == null)
                    {
                        Row.Cells[1].Style.BackColor = Color.Red;
                    }
                    else if(Row.Cells[1].Value.ToString()=="")
                    {
                        Row.Cells[1].Style.BackColor = Color.Red;
                    }
                    else if (Row.Cells[1].Value.ToString() == "0")
                    {
                        Row.Cells[1].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        Row.Cells[1].Style.BackColor = Color.Green;
                    }
                }
            }
            
        }
        private void Ctrl_NameBuilder1_On_BrandProductChanged(object sender, EventArgs e)
        {
            ctrl_ProductPhysicalProperties1.Setup_Barcode_Control(ctrl_NameBuilder2.BrandProduct);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic_global.Create_New_Product(ProdClass);
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }
    }
}
