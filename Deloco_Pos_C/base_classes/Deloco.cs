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
        public DelocoProduct[] Products_Get_Full_Product_List()
        {

            DelocoProduct[] Prod=new DelocoProduct[0];
            Prod[0] = new DelocoProduct();
            return Prod;
        }
        public int CreateUpdateBrand(int brandid,string BrandName, int BrandWeight, int BrandSortOrder)
        {
           
            int ret = 0;
            int newInstance = 0;
            string job = "somejob";
            string extra = "'TableName':'brands','Pk':'brands_ID'";
            string jsonstring = "{" + extra + ",'brands_ID':'" + brandid + "','brand_name':'" + BrandName.ToString() + "','brand_weight':'" + BrandWeight.ToString() + "','sort_order':'" + BrandSortOrder.ToString() + "'}";
            string res = logic_global.Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {

                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { Product_VarientID = "" };
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf = int.Parse(jsonObject.Product_VarientID.ToString());
                newInstance = tf;
            }
            else
            {
               // FailedWebReseponce("");
            }
            return ret;
        }
    }
    
    class DelocoProduct
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
    }
}
