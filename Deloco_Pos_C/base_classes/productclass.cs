using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.base_classes
{
    public class productclass
    {
        public int ProductID { get; set; }
        public int BrandProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductFullName { get; set; }
        public string PreFix { get; set; }
        public string PostFix { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public bool BrandInName { get; set; }
        public string BrandProductName { get; set; }
        public string BrandProductSize { get; set; }

        public double ProductRRP { get; set; }
        public string SizeString {get;set;}
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
        
    }


    public class ShopifyObjectClass
    {
      
    }
    public class ShopifyProductVarientClass 
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;

        public void CreateShopifyVarientObject(productclass prod)
        {
           
        }

        public void SaveVarient()
        {
            string parameters = "{'tags':'langold, milk','vendor':'Big Shaq','title':'Mr Floppy','product_type':'Chocolate Bar','body_html':'some <TAGS>','barcode':'123321','compare_at_price':'1.99','grams':'12','inventory_quantity':'1','price':'12345','sku':'123' ,'taxable':'True','weight':'1.0','weight_unit':'kg','inventory_management':'shopify'}";
            string job = "shopify_create_new_product";
            string res = logic_global.Make_db_call(job, parameters.ToString());

            parameters = "{'tags':'worksop, milk','vendor':'Big Shaq','title':'Mr Floppy','product_type':'Chocolate Bar','body_html':'some <TAGS>','barcode':'123321','compare_at_price':'1.99','grams':'12','inventory_quantity':'1','price':'12345','sku':'123' ,'taxable':'True','weight':'1.0','weight_unit':'kg','inventory_management':'shopify'}";
            res = logic_global.Make_db_call(job, parameters.ToString());
        }
        //strings
        public string barcode { get; set; }
        public string fulfillment_service { get; set; }

        public string inventory_management { get; set; }
        public string inventory_policy { get; set; }
        public string metafield { get; set; }
        public string option { get; set; }

        public string sku { get; set; }
        public string title { get; set; }
        public string weight_unit { get; set; }



        //floats
        public float compare_at_price { get; set; }
        public float price { get; set; }


        //dates
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }


        // bool
        public bool requires_shipping { get; set; }
        public bool taxable { get; set; }


        // longs
        public long id { get; set; }

        public long image_id { get; set; }
        public long product_id { get; set; }
        public long black { get; set; }


        //ints
        public int grams { get; set; }
        public int inventory_quantity { get; set; }
        public int old_inventory_quantity { get; set; }
        public int inventory_quantity_adjustment { get; set; }
        public int position { get; set; }
        public int weight { get; set; }


    }
}
