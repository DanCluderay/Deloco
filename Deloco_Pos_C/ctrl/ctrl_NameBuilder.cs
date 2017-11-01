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
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public event EventHandler On_BrandProductChanged = delegate { };
       
        public event EventHandler On_NameChanged = delegate { };


        public ctrl_NameBuilder()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        public string FullProductName;
        public string PreFix;
        public string PostFix;
        public int BrandID;
        public int BrandProduct;
        public string BrandName;
        public bool BrandInName;
        public string TheSize;
        public int TheUnitSize;
        public int TheRelativeSize;
        public string TheProduct_Name;

        private void ctrl_NameBuilder_Load(object sender, EventArgs e)
        {
            HideAllTabs();
            GetBrands();
            GetProductSizes();
        }
        private void GetBrands()
        {
            local_datasets.ProductDS DS = new local_datasets.ProductDS();
            DS.Merge(logic_global.Get_Brands());
            productDS.Merge(DS);
        }
        private void GetProductSizes()
        {
            productDS.Product_Size_Units.Clear();
            productDS.Merge(logic_global.Get_product_sizes(false));
            
        }
        private void ShowOptionsTab()
        {
            HideAllTabs();
            tabControl1.Controls.Add(tabOptions);

        }
        private void ShowBrandTab()
        {
            HideAllTabs();
            tabControl1.Controls.Add(tabBrand);

        }
        private void ShowProductTypeTab()
        {
            HideAllTabs();

            tabControl1.Controls.Add(tabProductType);

        }
        private void HideAllTabs()
        {
         
            tabControl1.Controls.Remove(tabOptions);
            tabControl1.Controls.Remove(tabProductType);
            tabControl1.Controls.Remove(tabBrand);
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrandsSearchBindingSource.Filter = "";
            txtAddBrandWeight.Text = "0";
            txtAddBrandName.Text = "";
            CheckAddBrandButtonAllowed();
            ShowBrandTab();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNewBrandProduct.Text = BrandName;
            brandProductsBindingSource.Filter = "";
            txtNewProductName.Text = "";
            CheckAddBrandProductButtonAllowed();
            ShowProductTypeTab();
        }
        private void CheckAddBrandProductButtonAllowed()
        {
            string new_product_name = txtNewProductName.Text.ToString().Trim();
            if(new_product_name.Length==0 & lstBrandProducts.Items.Count>0)
            {
                btnAddNewBrandProduct.Enabled = false;
                btnAddNewBrandProduct.BackColor = Color.LightSalmon;
            }
            else
            {
                btnAddNewBrandProduct.Enabled = true;
                btnAddNewBrandProduct.BackColor = Color.LightGreen;
            }
        }
        private void cmbBrand_Click(object sender, EventArgs e)
        {
         
        }

        private void cmbProductType_Click(object sender, EventArgs e)
        {
            //ShowOptionsTab();
        }


        private void BuildProductName()
        {
            string brand_to_display;
            if(BrandInName==true){ brand_to_display = ""; } else { brand_to_display = BrandName; }

            string unit_size="";
            if(cmbUnitSize.Text!="NA")
            {
                unit_size = cmbUnitSize.Text;
            }



            FullProductName = PreFix + " " + brand_to_display + " " + cmbProductType.Text + " " + TheSize + " " + unit_size + " " + PostFix;
            txtFullName.Text = FullProductName;
            On_NameChanged(this, new EventArgs());
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrefix_KeyUp(object sender, KeyEventArgs e)
        {
            PreFix = txtPrefix.Text.ToString();
            BuildProductName();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBrand.SelectedValue is null)
            {
            BrandName = "";
            BrandID = 0;
            }
            else
            {
            BrandName = cmbBrand.Text;
            BrandID = int.Parse( cmbBrand.SelectedValue.ToString());
            productDS.Brand_Products.Clear();
            productDS.Merge( logic_global.Get_Brand_Product(BrandID));
            }
            ShowOptionsTab();
            BuildProductName();
           
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
    
        }

        private void cmbBrand_DropDown(object sender, EventArgs e)
        {
            //ShowOptionsTab();
        }

        private void txtPostFix_KeyUp(object sender, KeyEventArgs e)
        {
            PostFix = txtPostFix.Text;
            BuildProductName();
        }

        private void txtPostFix_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBrandInName_CheckedChanged(object sender, EventArgs e)
        {
            BrandInName = chkBrandInName.Checked;
            BuildProductName();

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtSize_KeyUp(object sender, KeyEventArgs e)
        {
            TheSize = txtSize.Text.ToString();
            BuildProductName();
        }
        private void CheckAddBrandButtonAllowed()
        {
            string newbrandName = txtAddBrandName.Text.ToString().Trim();
            bool res;
            int newweight;
            string brandweightholder = txtAddBrandWeight.Text;
            if (brandweightholder == "") { brandweightholder = "0"; }
            res = int.TryParse(brandweightholder, out newweight);
            if (res == true & newbrandName.Length > 0 & lstNewBrandSearch.Items.Count==0)
            {
                btnAddNewBrand.Enabled = true;
                btnAddNewBrand.BackColor = Color.LightGreen;
            }
            else
            {
                btnAddNewBrand.Enabled = false;
                btnAddNewBrand.BackColor = Color.LightSalmon;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newbrandName = txtAddBrandName.Text.ToString().Trim();
            bool res;
            int newweight;
            string brandweightholder = txtAddBrandWeight.Text;
            if (brandweightholder == "") { brandweightholder = "0"; }
            res = int.TryParse(brandweightholder,out newweight);
            local_datasets.ProductDS retDS = new local_datasets.ProductDS();
            int newbrand_id=0;
            if(res==true & newbrandName.Length > 0)
            {
                retDS.Merge(logic_global.add_new_brand(newbrandName, newweight));
                if(retDS.Brands.Rows.Count==1)
                {
                    //we have a result
                    newbrand_id =int.Parse( retDS.Brands.Rows[0]["BrandID"].ToString());
                    local_datasets.ProductDS.BrandsRow NewBrand= productDS.Brands.NewBrandsRow();
                    NewBrand.BrandID = newbrand_id;
                    NewBrand.BrandName = newbrandName;
                    productDS.Brands.AddBrandsRow(NewBrand);
                    txtAddBrandName.Text = "";
                    txtAddBrandWeight.Text = "0";
                    cmbBrand.SelectedValue = newbrand_id;
                }
            }
            btnAddNewBrand.BackColor = default(Color);


        }

        private void txtAddBrandName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddBrandName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox lol = sender as TextBox;
            if(lol.Text=="")
            {
                BrandsSearchBindingSource.Filter = "";
            }
            else
            {
                BrandsSearchBindingSource.Filter = "BrandName like '" + lol.Text + "%'";
            }
            
            CheckAddBrandButtonAllowed();
        }

        private void txtAddBrandWeight_KeyUp(object sender, KeyEventArgs e)
        {
            CheckAddBrandButtonAllowed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string new_brand_product_name=txtNewProductName.Text.ToString().Trim();
            local_datasets.ProductDS retDS = new local_datasets.ProductDS();
            if(BrandID>0 & new_brand_product_name.Length>0)
            {
                retDS.Merge(logic_global.add_new_brand_products(new_brand_product_name, BrandID));
                int new_brand_product_id;
                if(retDS.Brand_Products.Rows.Count==1)
                {
                    new_brand_product_id =int.Parse( retDS.Brand_Products.Rows[0]["BrandProductID"].ToString());
                    local_datasets.ProductDS.Brand_ProductsRow newrow = productDS.Brand_Products.NewBrand_ProductsRow();
                    newrow.BrandProductID = new_brand_product_id;
                    newrow.ProductName = new_brand_product_name;
                    newrow.Brand = BrandID;
                    productDS.Brand_Products.AddBrand_ProductsRow(newrow);
                    txtNewBrandProduct.Text = "";
                    txtNewProductName.Text = "";
                    brandProductsBindingSource.Filter = "";
                }

                btnAddNewBrandProduct.BackColor = default(Color);

            }
           
        }

        private void txtNewProductName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox lol=sender as TextBox;
            if(lol.Text.ToString().Trim().Length==0)
            {
                brandProductsBindingSource.Filter = "";
            }
            else
            {
                brandProductsBindingSource.Filter = "ProductName like '" + lol.Text.ToString() + "%'";
            }
            CheckAddBrandProductButtonAllowed();
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProductType.SelectedValue!=null)
            {
                BrandProduct=int.Parse( cmbProductType.SelectedValue.ToString());
                TheProduct_Name = cmbProductType.Text;
                BuildProductName();
                On_BrandProductChanged(this, new EventArgs());
            }

        }

        private void cmbUnitSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUnitSize.SelectedValue!=null)
            {
                TheUnitSize =int.Parse(cmbUnitSize.SelectedValue.ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRelativeSize.SelectedValue!=null)
            {
                TheRelativeSize =int.Parse(cmbRelativeSize.SelectedValue.ToString());
                On_NameChanged(this, new EventArgs());
            }

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
