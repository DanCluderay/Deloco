using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net.Http;
using System.Data;
namespace Deloco_Pos_C.base_classes
{
    class Deloco
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;

        public DelocoProduct Products_Get_Product_by_ID(int productid)
        {

            DelocoProduct Prod = new DelocoProduct();
            //get the product data, product detail data
            //brand name
            //product metrics
            //Brand
            //barcode data
            //product type
            //categories

            //instance data
            //varient
            //product varient locations

            //price

            return Prod;
        }


        public string CreateShopifyObject(DelocoProduct Prod)
        {
            base_classes.ShopifyProductObject NewShop = new base_classes.ShopifyProductObject();
            NewShop.BarCode = Prod.ItemBarcode;
            NewShop.BodyHTML = Prod.ProductLongDescription;
            NewShop.ComparePrice = Prod.RRP_compare;
            NewShop.grams =Prod.WeightInGrams;
            NewShop.ImagePath = Prod.ImagePath;
            NewShop.inventory_management = Prod.InventoryManagement;
            NewShop.price=Prod.ItemSellPrice;
            NewShop.ProductType = Prod.ProductType;
            NewShop.sku = Prod.ProductID.ToString();
            NewShop.tags = Prod.ProductTags;
            NewShop.taxable = Prod.ProductTaxable;
            NewShop.Title = Prod.ProductFullName;
            NewShop.Vendor = Prod.BrandName;
            NewShop.weight_unit =   Prod.ProductWeightType;
            NewShop.weight = Prod.WeightInGrams;
            string json_string = NewShop.GetProductShopify_Json();
            string job = "shopify_dev_create_new_product";
            string res = logic_global.Make_db_call(job, json_string);
            return res;
        }

        
        public DelocoProduct[] Products_Get_Full_Product_List()
        {

            DelocoProduct[] Prod=new DelocoProduct[0];
            Prod[0] = new DelocoProduct();
            return Prod;
        }

        public int CreateShopifyProduct(DelocoProduct p)
        {
            int newInstance = 0;
            string job = "shopify_dev_create_new_product";
            string extra = "'TableName':'product','Pk':'product_ID','UpDateWhere':'" + p.ToString() + "'";
            //string jsonstring = "{" + extra + ",'id':'" + id + "'}";
            string parameters = "{'tags':'langold, milk','vendor':'Big Shaq','title':'Mr Floppy','product_type':'Chocolate Bar','body_html':'some <TAGS>','barcode':'123321','compare_at_price':'1.99','grams':'12','inventory_quantity':'1','price':'12345','sku':'123' ,'taxable':'True','weight':'1.0','weight_unit':'kg','inventory_management':'shopify'}";

            string res = logic_global.Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }


        public int CreateUpdateProductSizeUnits(int product_size_units_ID, string Unit, int TheOrder, int GroupType)
        {

            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_size_units','Pk':'product_size_units_ID','UpDateWhere':'" + product_size_units_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_size_units_ID':'" + product_size_units_ID + "','Unit':'" + Unit.ToString() + "','TheOrder':'" + TheOrder.ToString() + "','GroupType':'" + GroupType.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdateBrand(int brandid,string BrandName, int BrandWeight, int BrandSortOrder)
        {
         
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'brands','Pk':'brands_ID','UpDateWhere':'" + brandid.ToString() + "'";
            string jsonstring = "{" + extra + ",'brands_ID':'" + brandid + "','brand_name':'" + BrandName.ToString() + "','brand_weight':'" + BrandWeight.ToString() + "','sort_order':'" + BrandSortOrder.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
               // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_brand_products(int brand_products_ID, int brand , string brand_productname)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'brand_products','Pk':'brand_products_ID','UpDateWhere':'" + brand_products_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'brand_products_ID':'" + brand_products_ID + "','product_brand_name':'" + brand_productname.ToString() + "','brand':'" + brand.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }
        public int CreateUpdate_product_barcodes(int product_barcodes_ID, int brand_product_ID, int barcode_type, string barcode,int case_qty)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_barcodes','Pk':'product_barcodes_ID','UpDateWhere':'" + product_barcodes_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_barcodes_ID':'" + product_barcodes_ID + "','brand_product_ID':'" + brand_product_ID.ToString() + "','barcode_type':'" + barcode_type.ToString() + "','barcode':'" + barcode.ToString() + "','case_qty':'" + case_qty.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_product(int product_ID, int brand_product, int product_type_ID, int IsLocked, int IsLockedBy)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product','Pk':'product_ID','UpDateWhere':'" + product_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_ID':'" + product_ID + "','brand_product':'" + brand_product.ToString() + "','product_type_ID':'" + product_type_ID.ToString() + "','IsLocked':'" + IsLocked.ToString() + "','IsLockedBy':'" + IsLockedBy.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_product_details(bool forceinsert,base_classes.DelocoProduct prod)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "";
            if(forceinsert==true)
            {
                extra = "'TableName':'product_detail','Pk':'product_detail_ID','UpDateWhere':'0'"; //force an insert query as this table has no autoid and is has a 1 to 1 relationship with the products table
            }
            else
            {
                extra = "'TableName':'product_detail','Pk':'product_detail_ID','UpDateWhere':'" + prod.ProductID + "'"; 
            }
            
            string jsonstring = "{" + extra + ",'product_detail_ID':'" + prod.ProductID.ToString() + "','product_name':'" + prod.ProductName.ToString() + "','product_fullname':'" + prod.ProductFullName.ToString() + "','product_short_description':'" + prod.ProductShortDescription.ToString() + "','product_long_description':'" + prod.ProductLongDescription.ToString() + "','product_prefix':'" + prod.PreFix.ToString() + "','product_postfix':'" + prod.PostFix.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }
        public int CreateUpdate_product_metric(bool forceinsert, base_classes.DelocoProduct prod)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "";
            if (forceinsert == true)
            {
                extra = "'TableName':'product_metrics','Pk':'product_metrics_ID','UpDateWhere':'0'"; //force an insert query as this table has no autoid and is has a 1 to 1 relationship with the products table
            }
            else
            {
                extra = "'TableName':'product_metrics','Pk':'product_metrics_ID','UpDateWhere':'" + prod.ProductID + "'";
            }

            string jsonstring = "{" + extra + ",'product_metrics_ID':'" + prod.ProductID.ToString() + "','productRealWeight':'" + prod.ProductRealWeight.ToString() + "','productVolumetricWeight':'" + prod.ProductVolumetricWeight.ToString() + "','productItemLength':'" + prod.ProductItemLenght.ToString() + "','productItemWidth':'" + prod.ProductItemWidth.ToString() + "','productItemHeight':'" + prod.PreFix.ToString() + "','productTotalVolume':'" + prod.ProductVolumetricWeight.ToString() + "','productSizeString':'" + prod.SizeString.ToString() + "','productSizeRelative':'" + prod.SizeRelative.ToString() + "','productSizeUnit':'" + prod.SizeUnit.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_product_images(int product_images_ID, int product_id, int image_type, string image_path)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_images','Pk':'product_images_ID','UpDateWhere':'" + product_images_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_images_ID':'" + product_images_ID + "','product_id':'" + product_id.ToString() + "','image_type':'" + image_type.ToString() + "','image_path':'" + image_path.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }
        public int CreateUpdate_vat_codes(int vat_codes_ID, string vat_codes_name, double vat_codes_rate)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'vat_codes','Pk':'vat_codes_ID','UpDateWhere':'" + vat_codes_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'vat_codes_ID':'" + vat_codes_ID + "','vat_codes_name':'" + vat_codes_name.ToString() + "','vat_codes_rate':'" + vat_codes_rate.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }
        public int CreateUpdate_product_case_config(int product_case_config_ID, int product_ID, string case_description, int case_qty, string case_barcode)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_case_config','Pk':'product_case_config_ID','UpDateWhere':'" + product_case_config_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_case_config_ID':'" + product_case_config_ID + "','product_ID':'" + product_ID.ToString() + "','case_description':'" + case_description.ToString() + "','case_qty':'" + case_qty.ToString() + "','case_barcode':'" + case_barcode.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }


        public int CreateUpdate_product_types(int product_types_ID, int product_category_ID, string product_type_name)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_types','Pk':'product_types_ID','UpDateWhere':'" + product_types_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_types_ID':'" + product_types_ID + "','product_category_ID':'" + product_category_ID.ToString() + "','product_type_name':'" + product_type_name.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }



        public int CreateUpdate_product_categories(int product_categories_ID, string category_name)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_categories','Pk':'product_categories_ID','UpDateWhere':'" + product_categories_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_categories_ID':'" + product_categories_ID + "','category_name':'" + category_name.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_product_instance(int product_instance_ID, int product_ID,double item_cost_price,int invoice_ID)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_instance','Pk':'product_instance_ID','UpDateWhere':'" + product_instance_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_instance_ID':'" + product_instance_ID + "','product_ID':'" + product_ID.ToString() + "','item_cost_price':'" + item_cost_price.ToString() + "','invoice_ID':'" + invoice_ID.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int CreateUpdate_product_varient(int product_varient_ID, int product_instance_ID, DateTime product_bbedate)
        {

            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_varient','Pk':'product_varient_ID','UpDateWhere':'" + product_varient_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_varient_ID':'" + product_varient_ID + "','product_instance_ID':'" + product_instance_ID.ToString() + "','product_bbedate':'" + product_bbedate.ToShortDateString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }


        public int CreateUpdate_product_varient_location_stock_qty(int product_varient_location_stock_qty_ID, int product_instance_ID, int product_varient_location_ID, int product_varient_qty_free,int product_varient_qty_reserved, int product_varient_qty_soldnotpicked)
        {
            int newInstance = 0;
            string job = "generic_update";
            string extra = "'TableName':'product_varient_location_stock_qty','Pk':'product_varient_location_stock_qty_ID','UpDateWhere':'" + product_varient_location_stock_qty_ID.ToString() + "'";
            string jsonstring = "{" + extra + ",'product_varient_location_stock_qty_ID':'" + product_varient_location_stock_qty_ID + "','product_instance_ID':'" + product_instance_ID.ToString() + "','product_varient_location_ID':'" + product_varient_location_ID.ToString() + "','product_varient_qty_free':'" + product_varient_qty_free.ToString() + "','product_varient_qty_reserved':'" + product_varient_qty_reserved.ToString() + "','product_varient_qty_soldnotpicked':'" + product_varient_qty_soldnotpicked.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                newInstance = Convert.ToInt32(res);
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }

        public int select_product_varient_location_stock_qty()
        {
            int newInstance = 0;
            string job = "generic_select";
            string extra = "'TableName':'product_varient_location_stock_qty','Pk':'product_varient_location_stock_qty_ID','UpDateWhere':'1'";
            string jsonstring = "{" + extra + ",'product_varient_location_stock_qty_ID':'product_varient_location_stock_qty_ID','product_instance_ID':'product_varient_location_stock_qty_ID','product_varient_location_ID':'product_varient_location_ID'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                string responcestring;
                responcestring = res.Replace("\\", "");
                object j=  (DataTable)JsonConvert.DeserializeObject(responcestring, (typeof(DataTable)));
            }
            else
            {
                // FailedWebReseponce("");
            }
            return newInstance;
        }
    }

    class ShopifyProductObject
    {
        public string Vendor { get; set; }
        public string Title { get; set; }
        public string ProductType { get; set; }
        public string BodyHTML { get; set; }
        public string ImagePath { get; set; }

        public string BarCode { get; set; }
        public double ComparePrice { get; set; }
        public string grams { get; set; }
        public double price { get; set; }
        public string sku { get; set; }
        public string taxable { get; set; }
        public string weight { get; set; }
        public string weight_unit { get; set; }
        public string inventory_management { get; set; }
        public string inventory_quantity { get; set; }
        public string tags { get; set; }

        public string GetProductShopify_Json()
        {
            string ret = "";
            ret = "{'tags':'" + this.tags + "','vendor':'" + this.Vendor + "','title':'" + this.Title + "','product_type':'" + this.ProductType + "','body_html':'" + this.BodyHTML + "','barcode':'" + this.BarCode + "','compare_at_price':'" + this.ComparePrice + "','grams':'" + this.grams + "','inventory_quantity':'" + this.inventory_quantity + "','price':'" + this.price + "','sku':'" + this.sku + "' ,'taxable':'" + this.taxable + "','weight':'" + this.weight + "','weight_unit':'" + this.weight_unit + "','inventory_management':'" + this.inventory_management + "','imagepath':'" + this.ImagePath + "'}";
            return ret;
        }

    }

    class ShopifyProductVarientObject
    {
        public string product_tags { get; set; }

    }
    class product_varient_location_stock_qty
    {
        public int gh { get; set; }
    }

    class DelocoProduct
    {
        public int ProductID { get; set; }
        private bool _ProductDirty;
        private int _BrandProduct;
        private bool _BrandProduct_Changed;

        private string _ProductName;
        private bool _ProductName_Changed;

        private string _ProductFullName;
        private bool _ProductFullName_Changed;

        private string _PreFix;
        private bool _PreFix_Changed;

        private string _PostFix;
        private bool _PostFix_Changed;

        private int _BrandID;
        private bool _BrandID_Changed;

        public void Reset_IsDirty()
        {

            _ProductDirty = false;
            _BrandProduct_Changed = false;
            _ProductName_Changed = false;
            _ProductFullName_Changed = false;
            _PreFix_Changed = false;
            _PostFix_Changed = false;
        }
        public int BrandProduct
        {
            get
            {
                return _BrandProduct;
            }
            set
            {
                _BrandProduct = value;
                _BrandProduct_Changed = true;
                _ProductDirty = true;
            }

        }
        
        public bool Has_BrandProduct_Changed
        {
            get
            {
                return _BrandProduct_Changed;
            }
                
        }
        
        public string ProductName 
            {
            get
            {
                return _ProductName;
            }

            set
            {
                _ProductName = value;
                _ProductName_Changed = true;
                _ProductDirty = true;
            }
            }
        public bool Has_ProductName_Changed
        {
            get
            {
                return _ProductName_Changed;
            }
        }
        public string ProductFullName
        {
            get
            {
                return _ProductFullName;
            }
            set
            {
                _ProductFullName = value;
                _ProductFullName_Changed = true;
                _ProductDirty = true;
            }
        }

        public bool Has_ProductFullName_Changed
        {
            get
            {
                return _ProductFullName_Changed;
            }
        }
        public string PreFix
        {
            get
            {
                return _PreFix;
            }
            set
            {
                _PreFix = value;
                _PreFix_Changed = true;
                _ProductDirty = true;
            }
        }

        public bool Has_Prefix_Changed
        {
            get
            {
                return _PreFix_Changed;
            }
        }
        public string PostFix
        {
            get
            {
                return _PostFix;
            }
            set
            {
                _PostFix = value;
                _PostFix_Changed = true;
                _ProductDirty = true;
            }
        }

        public bool Has_Postfix_Changed
        {
            get
            {
                return _PostFix_Changed;
            }
        }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public bool BrandInName { get; set; }
        public string BrandProductName { get; set; }
        public string BrandProductSize { get; set; }

        public double ProductRRP { get; set; }
        public string SizeString { get; set; }
        public int SizeUnit { get; set; }
        public int SizeRelative { get; set; }
        public int ProductItemWidth { get; set; }
        public int ProductItemLenght { get; set; }
        public int ProductItemHeight { get; set; }
        public int ProductTotalVolume { get; set; }
        public double ProductRealWeight { get; set; }
        public double ProductVolumetricWeight { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }

        public int ProductVateCode { get; set; }
        public int InnerPackQty { get; set; }
        public bool IsCasePick { get; set; }

        public double ProductItemRRP { get; set; }

        public bool ISLocked { get; set; }
        public int IsLockedBy { get; set; }
        public int ProductDateType { get; set; }
        public int FreeStockQTY { get; set; }
        public int SNPStockQTY { get; set; }
        public int ReservedStockQTY { get; set; }
        public double ItemCostPrice { get; set; }
        public string ItemBarcode { get; set; }
        public double RRP_compare { get; set; }
        public string WeightInGrams { get; set; }
        public string ImagePath { get; set; }
        public string InventoryManagement { get; set; }
        public double ItemSellPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductTags { get; set; }
        public string ProductTaxable { get; set; }

        public string ProductWeightType { get; set; }
        public int FreeStock { get; set; }
        public int ReseveredStock { get; set; }
        public int SoldNotPickedStock { get; set; }
    }


}
