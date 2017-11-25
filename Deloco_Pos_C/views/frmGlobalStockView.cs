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
    public partial class frmGlobalStockView : Form
    {
        public frmGlobalStockView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            int newbrandid = 0;
            newbrandid=brains.CreateUpdateBrand(0, "Mars", 5, 0);
            brains.CreateUpdateBrand(newbrandid, "Mars " + DateTime.Now.ToShortTimeString(), 5, 0);
            int newbrand_productid = 0;
            newbrand_productid=brains.CreateUpdate_brand_products(0, newbrandid, " Chocolate");
            newbrand_productid=brains.CreateUpdate_brand_products(newbrand_productid, newbrandid, " Chocolate " + DateTime.Now.ToShortTimeString());
            int newprodbarcode = 0;
            newprodbarcode = brains.CreateUpdate_product_barcodes(0, newbrand_productid, 1, "123", 12);
            newprodbarcode = brains.CreateUpdate_product_barcodes(newprodbarcode, newbrand_productid, 1, "123 " + DateTime.Now.ToShortTimeString(), 12);

            int catid = 0;
            catid = brains.CreateUpdate_product_categories(0, "Some category");
            catid = brains.CreateUpdate_product_categories(catid, "Some other cateogry");

            int producttypeid = 0;
            producttypeid = brains.CreateUpdate_product_types(0, catid, "Type 1");
            producttypeid = brains.CreateUpdate_product_types(producttypeid, catid, "Type 2");

            int newproductid = 0;
            newproductid = brains.CreateUpdate_product(0, newbrand_productid, producttypeid, 0, 0);
            newproductid = brains.CreateUpdate_product(newproductid, newbrand_productid, producttypeid, 0, 0);

            int newprod_image_id = 0;

            newprod_image_id = brains.CreateUpdate_product_images(0, newproductid, 1, "/beefburger-500x500.gif");
            newprod_image_id = brains.CreateUpdate_product_images(newprod_image_id, newproductid, 1, "http://www.clicknchop.com/image/cache/catalog/Burger/beefburger-500x500.gif");


            base_classes.DelocoProduct prod = new base_classes.DelocoProduct();
            prod.ProductID = newproductid;
            prod.ProductName = "Beef Burger";
            prod.ProductFullName = "Beef Burger";
            prod.ProductShortDescription = "Some Small text";
            prod.ProductLongDescription = "Some HTML";
            prod.PreFix = "prefix";
            prod.PostFix = "postfix";
            prod.InnerPackQty = 12;
            prod.ImagePath = "http://www.clicknchop.com/image/cache/catalog/Burger/beefburger-500x500.gif";
            prod.InventoryManagement = "shopify";
            prod.ItemSellPrice = 9.99;
            prod.ProductType="Meat";
            prod.ProductTags = "Burgers";
            prod.ProductTaxable="true";
            prod.ProductWeightType = "kg";
            prod.WeightInGrams = "12";

            prod.ProductRealWeight = 1;
            prod.ProductVolumetricWeight = 2;
            prod.ProductItemLenght = 1;
            prod.ProductItemWidth = 1;
            prod.ProductItemHeight = 1;
            prod.ProductTotalVolume = 3;
            prod.SizeString = "200ml";
            prod.SizeRelative = 1;
            prod.SizeUnit = 1;

            int newprodid = 0;
            newprodid = brains.CreateUpdate_product_details(true, prod);
            prod.ProductLongDescription = "Some more HTML";
            brains.CreateUpdate_product_details(false, prod);

            newprodid = brains.CreateUpdate_product_metric(true, prod);
            prod.ProductRealWeight = prod.ProductRealWeight + 1;
            brains.CreateUpdate_product_metric(false, prod);




            int instanceid =0;
            instanceid= brains.CreateUpdate_product_instance(0, newprodid,0.3,1);
            instanceid = brains.CreateUpdate_product_instance(instanceid, newprodid, 0.5, 1);

            int varientid = 0;
            varientid = brains.CreateUpdate_product_varient(0, instanceid,DateTime.Now.Date);
            varientid = brains.CreateUpdate_product_varient(varientid, instanceid, DateTime.Now.Date);

            int varientqtyid = 0;
            varientqtyid = brains.CreateUpdate_product_varient_location_stock_qty(0, varientid, 12,12,12,12);
            varientqtyid = brains.CreateUpdate_product_varient_location_stock_qty(varientqtyid, varientid, 13, 12, 12, 12);


            string js = "";
            js = brains.CreateShopifyObject(prod);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            int code_id = 0;
            code_id=brains.CreateUpdate_vat_codes(0, "Zero", 1.0);
            code_id = brains.CreateUpdate_vat_codes(code_id, "Zero " + DateTime.Now.ToShortTimeString(), 1.0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            int prod_type_id = 0;
            prod_type_id = brains.CreateUpdate_product_types(0,1,"Beef Burger");
            prod_type_id = brains.CreateUpdate_product_types(prod_type_id,1, "Beef Burger " + DateTime.Now.ToShortTimeString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            int prod_cats_id = 0;
            prod_cats_id = brains.CreateUpdate_product_categories(0, "some category");
            prod_cats_id = brains.CreateUpdate_product_categories(prod_cats_id, "some category " + DateTime.Now.ToShortTimeString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            int prod_size_id = 0;
            prod_size_id = brains.CreateUpdateProductSizeUnits(0,"kg",1,1);
            prod_size_id = brains.CreateUpdateProductSizeUnits(prod_size_id, "kg " + DateTime.Now.ToShortTimeString(), 1, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            base_classes.Deloco brains = new base_classes.Deloco();
            brains.select_product_varient_location_stock_qty();

        }
    }
}
