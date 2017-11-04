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

namespace Deloco_Pos_C.helper_functions
{
    public class globalHelper
    {
        public string clientId;
        public event EventHandler On_mqtt_new = delegate { };
        public event EventHandler On_Signed_in = delegate { };
        public event EventHandler On_LocationChanged = delegate { };

        public event EventHandler On_Shop_Location_Update = delegate { };


        private local_datasets.ProductDS LocalDS;


        MqttClient client;
        private static globalHelper instance;

        List<mqtt_msg_object> mqtt_list = new List<mqtt_msg_object>();

        private globalHelper() { }
        private string _mqttserver = "";

        public string Sign_In(string username, string password)
        {
            string retval = "";

            On_Signed_in(this, new EventArgs());

            return retval;
        }

        public string MqttClient_Server

        {
            get
            {
                return _mqttserver;
            }
            set
            {
                _mqttserver = value;
            }

        }


        public static globalHelper Instance

        {
            get
            {
                if (instance == null)
                {
                    instance = new globalHelper();
                    //when you create a new instance create a new 
                    

                }
                return instance;
            }
        }

        public string connectToMQTTServer(string Topic)
        {
            string returnValue = "";
            try
            {
                mqtt_list = new List<mqtt_msg_object>();
                client = new MqttClient(MqttClient_Server);
                returnValue = "Connected to client";
                clientId = Guid.NewGuid().ToString();
                Mqtt_Subscribe(Topic);
            }
            catch
            {
                //cannot connect to MQTT server
            }


            return returnValue;
        }
        public string Mqtt_Subscribe(string Topic)
        {

            string return_value = "";

            //// register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            //Later this will be a shop/userid

            client.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2
            //client.Subscribe(new string[] { Topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            string[] Topics = new string[3];
            Topics[0] = "cluderay";
            Topics[1] = "cluderay1";
            Topics[2] = "cluderay2";


            //client.Subscribe(new string[] { Topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            client.Subscribe(new string[] { Topic, "cluderay/#" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            return_value = "subcribed to: " + Topic + " successfully";
            return return_value;

        }
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);



            mqtt_msg_object newItem = new mqtt_msg_object();
            newItem.msg_payload = ReceivedMessage;
            newItem.msg_topic = e.Topic;

            mqtt_list.Add(newItem);

            On_mqtt_new(this, new EventArgs());
            if (newItem.msg_topic == "cluderay/global/store_update")
            {
                //debug the payload
                object tester = (object)JsonConvert.DeserializeObject(newItem.msg_payload, (typeof(object)));
                try
                {
                    On_Shop_Location_Update(this, new EventArgs());
                }
                catch
                {
                }


            }
            else if (newItem.msg_topic == "cluderay")
            {

            }

        }
        public void ActionOnPayload(string Payload)
        {
            //There is a new order

            //An order has changed - dev mode


        }
        public local_datasets.mqtt_ds GetMQTT_DataSet()
        {
            local_datasets.mqtt_ds DS = new local_datasets.mqtt_ds();
            local_datasets.mqtt_ds.mqtt_msgRow drow;

            //logic_global.mqtt_list
            foreach (var Item in mqtt_list)
            {
                drow = DS.mqtt_msg.Newmqtt_msgRow();

                drow.msgpayload = Item.msg_payload;
                drow.msgTopic = Item.msg_topic;

                DS.mqtt_msg.Addmqtt_msgRow(drow);
            }

            return DS;
        }

        public string Make_db_call(string func, string val)
        {
            string newstring="";
            try
            {
             string url = "https://00t1ug5s49.execute-api.eu-west-1.amazonaws.com/prod/apex-deepretail_deppcore?func=" + func + "&val=" + val;

                        using (HttpClient client = new HttpClient())
                        {
                
                            using (HttpResponseMessage responce = client.GetAsync(url).Result)
                            {
                                using (HttpContent content = responce.Content)
                                {
                                    string mycontent = content.ReadAsStringAsync().Result;

                                    newstring = mycontent.Replace("\"", "'");

                                    

                                    //DataSet tester = (DataSet)JsonConvert.DeserializeObject(newstring, (typeof(DataSet)));
                                    //DataTable tester = (DataTable)JsonConvert.DeserializeObject(newstring, (typeof(DataTable)));


                                }
                            }
                        }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            return newstring;


        }

        public DataSet FormatStringToDataTable(string functionName, string responcestring)
        {
            DataTable ReturnDataTable;
            DataSet ReturnDS = new DataSet();
            
            responcestring = responcestring.Replace("\\", "");
            
            ReturnDataTable = (DataTable)JsonConvert.DeserializeObject(responcestring, (typeof(DataTable)));
            if (functionName == "get_customer_order")
            {
                //converts the string into a generic datatable


                //declare the tempory local variables used for error catching
                int _order_autoid = 0;
                int _customerid = 0;
                double _ordervalue = 0.00;
                string _order_status = "";
                int _order_status_int = 0;
                string _GUID = "";
                string _delivery_status = "";
                string _delivery_address_Line1 = "";
                string _delivery_address_Line2 = "";
                string _delivery_address_Town = "";
                string _delivery_address_City = "";
                string _delivery_address_Postcode = "";
                string _delivery_address_Country = "";
                string _Customer_First_Name = "";
                string _CustomerTitle = "";
                string _Customer_Second_Name = "";
                DateTime _delivery_date;
                string _ORDERID = "";
                DateTime _orders_date;
                //DateTime _orders_time;

                //create the empty returning dataset
                local_datasets.OrderDetails_ds OrderDS = new local_datasets.OrderDetails_ds();

                //now loop the table items and convert into a dataset
                foreach (DataRow Item in ReturnDataTable.Rows)
                {

                    local_datasets.OrderDetails_ds.OrderDetailsRow NewRow = OrderDS.OrderDetails.NewOrderDetailsRow();

                    _order_autoid = Int32.Parse(Item["order_autoid"].ToString());
                    NewRow.order_autoid = _order_autoid;

                    _customerid = Int32.Parse(Item["customerid"].ToString());
                    NewRow.customerid = _customerid;

                    string test_OrderValue = Item["ordervalue"].ToString();
                    if (test_OrderValue == "")
                    {
                        test_OrderValue = "0";
                    }
                    _ordervalue = Double.Parse(test_OrderValue);
                    NewRow.ordervalue = _ordervalue;

                    _order_status = Item["order_status"].ToString();
                    NewRow.order_status = _order_status;

                    _order_status_int = Int32.Parse(Item["order_status_int"].ToString());
                    NewRow.order_status_int = _order_status_int;

                    _GUID = Item["GUID"].ToString();
                    NewRow.GUID = _GUID;

                    _delivery_status = Item["delivery_status"].ToString();
                    NewRow.delivery_status = _delivery_status;

                    _delivery_address_Line1 = Item["delivery_address_Line1"].ToString();
                    NewRow.delivery_address_Line1 = _delivery_address_Line1;

                    _delivery_address_Line2 = Item["delivery_address_Line2"].ToString();
                    NewRow.delivery_address_Line2 = _delivery_address_Line2;

                    _delivery_address_Town = Item["delivery_address_Town"].ToString();
                    NewRow.delivery_address_Town = _delivery_address_Town;

                    _delivery_address_City = Item["delivery_address_City"].ToString();
                    NewRow.delivery_address_City = _delivery_address_City;

                    _delivery_address_Postcode = Item["delivery_address_Postcode"].ToString();
                    NewRow.delivery_address_Postcode = _delivery_address_Postcode;

                    _delivery_address_Country = Item["delivery_address_Country"].ToString();
                    NewRow.delivery_address_Country = _delivery_address_Country;

                    _Customer_First_Name = Item["Customer_First_Name"].ToString();
                    NewRow.Customer_First_Name = _Customer_First_Name;

                    _CustomerTitle = Item["CustomerTitle"].ToString();
                    NewRow.CustomerTitle = _CustomerTitle;

                    _Customer_Second_Name = Item["Customer_Second_Name"].ToString();
                    NewRow.Customer_Second_Name = _Customer_Second_Name;

                    string test_deliverydate = Item["delivery_date"].ToString();
                    if (test_deliverydate == "")
                    {
                        test_deliverydate = "2017-01-01";
                    }
                    _delivery_date = Convert.ToDateTime(test_deliverydate);
                    NewRow.delivery_date = _delivery_date;

                    _ORDERID = Item["ORDERID"].ToString();
                    NewRow.ORDERID = _ORDERID;

                    string test_orderdate = Item["orders_date"].ToString();
                    if (test_orderdate == "")
                    {
                        test_orderdate = "2017-01-01";
                    }
                    _orders_date = Convert.ToDateTime(test_orderdate);
                    NewRow.orders_date = _orders_date;


                    //string test_ordertime = Item["orders_time"].ToString();
                    //if (test_ordertime == "")
                    //{
                    //    test_ordertime = "00:00:00";
                    //}
                    //_orders_time = Convert.ToDateTime(test_ordertime);
                    //NewRow.orders_time = _orders_time;

                    OrderDS.OrderDetails.Rows.Add(NewRow);

                }
                ReturnDS = OrderDS;
            }
            else if (functionName == "get_customer_order_items")
            {

                //declare the tempory local variables used for error catching

                int _order_items_autoid = 0;
                int _oitems_orderid = 0;
                string _Items_product_varientid = "";
                string _item_description = "";
                double _items_cost_ex_vat = 0.00;
                int _vatcode = 0;
                int _qty = 0;
                //DateTime _order_date;
                //DateTime _order_time;
                double _DealRetail = 0;

                //create the empty returning dataset
                local_datasets.OrderItems_DS OrderLines = new local_datasets.OrderItems_DS();
                //now loop the table items and convert into a dataset

                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.OrderItems_DS.order_itemsRow NewRow = OrderLines.order_items.Neworder_itemsRow();
                    _order_items_autoid = Int32.Parse(Item["order_items_autoid"].ToString());
                    NewRow.order_items_autoid = _order_items_autoid;

                    _Items_product_varientid = Item["Items_product_varientid"].ToString();
                    NewRow.Items_product_varientid = _Items_product_varientid;

                    _oitems_orderid = Int32.Parse(Item["oitems_orderid"].ToString());
                    NewRow.oitems_orderid = _oitems_orderid;


                    string test_items_cost_ex = Item["items_cost_ex_vat"].ToString();
                    if (test_items_cost_ex == "" || test_items_cost_ex == "None")
                    {
                        test_items_cost_ex = "0";
                    }
                    _items_cost_ex_vat = Double.Parse(test_items_cost_ex);
                    NewRow.items_cost_ex_vat = _items_cost_ex_vat;

                    _item_description = Item["item_description"].ToString();
                    NewRow.item_description = _item_description;

                    _vatcode = Int32.Parse(Item["vatcode"].ToString());
                    NewRow.vatcode = _vatcode;

                    _qty = Int32.Parse(Item["qty"].ToString());
                    NewRow.qty = _qty;

                    _DealRetail = Double.Parse(Item["DealRetail"].ToString());
                    NewRow.DealRetail = _DealRetail;
                    //string test_orderdate = Item["order_date"].ToString();
                    //if (test_orderdate == "")
                    //{
                    //    test_orderdate = "2017-01-01";
                    //}
                    //_order_date = Convert.ToDateTime(test_orderdate);
                    //NewRow.order_date = _order_date;

                    //string test_ordertime = Item["order_time"].ToString();
                    //if (test_ordertime == "")
                    //{
                    //    test_ordertime = "00:00:00";
                    //}
                    //_order_time = Convert.ToDateTime(test_ordertime);
                    //NewRow.order_time = _order_time;

                    OrderLines.order_items.Addorder_itemsRow(NewRow);
                }
                ReturnDS = OrderLines;
            }

            else if (functionName == "get_all_shops")
            {
                int shopid = 0;
                string shopname = "";
                string shopshortcode = "";

                local_datasets.store_locations Stores = new local_datasets.store_locations(); //creates the new dataset

                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.store_locations.storesRow StoreRow = Stores.stores.NewstoresRow();
                    shopid = Int32.Parse(Item["store_autoid"].ToString());
                    shopname = Item["store_name"].ToString();
                    shopshortcode = Item["store_shortcode"].ToString();
                    StoreRow.store_autoid = shopid;
                    StoreRow.store_name = shopname;
                    StoreRow.store_shortcode = shopshortcode;

                    Stores.stores.AddstoresRow(StoreRow);
                }

                ReturnDS = Stores;
            }
            else if (functionName == "get_productview_by_prodID")
            {

                local_datasets.ProductVarientView ProdViewDS = new local_datasets.ProductVarientView();

                foreach (DataRow Item in ReturnDataTable.Rows)
                {


                    local_datasets.ProductVarientView.ProdVarViewRow ProdViewRow = ProdViewDS.ProdVarView.NewProdVarViewRow();

                    ProdViewRow.id = int.Parse(Item["id"].ToString());
                    ProdViewRow.qty = int.Parse(Item["Varient_QTY"].ToString());
                    ProdViewRow.Reserve = int.Parse(Item["reserve"].ToString());
                    ProdViewRow.ProductID = int.Parse(Item["ProductTypesautoid"].ToString());
                    ProdViewRow.last_updated = "";// Item["store_autoid"].ToString(); 
                    ProdViewRow.ProdVarientID = int.Parse(Item["Varient_Instance_ID"].ToString());
                    ProdViewRow.ForSale = int.Parse(Item["ForSale"].ToString());
                    ProdViewRow.Inbastet = int.Parse(Item["Inbasket"].ToString());
                    ProdViewRow.ShopID = int.Parse(Item["Varient_Location_ID"].ToString());
                    ProdViewRow.shopifyvarientid = 0;// Int64.Parse(Item["store_autoid"].ToString());
                    ProdViewRow.ShopName = Item["store_name"].ToString();
                    ProdViewRow.Sold = int.Parse(Item["sold"].ToString());
                    ProdViewRow.Transit = int.Parse(Item["transit"].ToString());
                    ProdViewRow.ProductVarientName = Item["pv_Name"].ToString();
                    // - product Name

                    ProdViewDS.ProdVarView.AddProdVarViewRow(ProdViewRow);
                }
                ReturnDS = ProdViewDS;



            }
            else if (functionName == "get_gridlocations")
            {

                local_datasets.LocationGrid locationGridDS = new local_datasets.LocationGrid();

                foreach (DataRow Item in ReturnDataTable.Rows)
                {


                    local_datasets.LocationGrid.Location_GridRow LocRow = locationGridDS.Location_Grid.NewLocation_GridRow();
                    LocRow.LocGridID = int.Parse(Item["LocGridID"].ToString());
                    LocRow.LocName = Item["LocName"].ToString();
                    LocRow.LocType = int.Parse(Item["LocType"].ToString());
                    LocRow.LocParent = int.Parse(Item["LocParent"].ToString());
                    LocRow.PickOrder = int.Parse(Item["PickOrder"].ToString());
                    LocRow.ShortName = Item["ShortName"].ToString();
                    LocRow.FullName = Item["FullName"].ToString();

                    locationGridDS.Location_Grid.AddLocation_GridRow(LocRow);
                }
                ReturnDS = locationGridDS;



            }
            else if (functionName == "get_location_types")
            {
                local_datasets.LocationTypes LocType = new local_datasets.LocationTypes();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.LocationTypes.LocationTypesRow Loc_Row = LocType._LocationTypes.NewLocationTypesRow();

                    Loc_Row.LocationTypeID = int.Parse(Item["LocationTypeID"].ToString());
                    Loc_Row.LocationName = Item["LocationName"].ToString();

                    LocType._LocationTypes.AddLocationTypesRow(Loc_Row);
                }
                ReturnDS = LocType;
            }
            //
            else if (functionName == "get_location_Store_Zone_Layout")
            {
                local_datasets.LocationGrid LocDS = new local_datasets.LocationGrid();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.LocationGrid.storelayoutRow Loc_Row = LocDS.storelayout.NewstorelayoutRow();

                    Loc_Row.id = int.Parse(Item["id"].ToString());
                    Loc_Row.BuildingID = int.Parse(Item["BuildingID"].ToString());
                    Loc_Row.LocGrid_ID = int.Parse(Item["LocGrid_ID"].ToString());
                    Loc_Row.Control_Type = int.Parse(Item["Control_Type"].ToString());
                    Loc_Row.Control_X = int.Parse(Item["Control_X"].ToString());
                    Loc_Row.Control_Y = int.Parse(Item["Control_Y"].ToString());
                    Loc_Row.Control_Size = int.Parse(Item["Control_Size"].ToString());

                    LocDS.storelayout.AddstorelayoutRow(Loc_Row);
                }
                ReturnDS = LocDS;
            }
            else if (functionName == "get_location_Store_Zone_Funiture")
            {
                //SELECT store_control_type.store_control_type_id, store_control_type.store_control_name, store_control_type.store_control_name_desc, store_control_type.store_control_subtype FROM fred.store_control_type store_control_type

                local_datasets.LocationGrid LocDS = new local_datasets.LocationGrid();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.LocationGrid.store_control_typeRow Loc_Row = LocDS.store_control_type.Newstore_control_typeRow();

                    Loc_Row.store_control_type_id = int.Parse(Item["store_control_type_id"].ToString());
                    Loc_Row.store_control_name = Item["store_control_name"].ToString();
                    Loc_Row.store_control_name_desc = Item["store_control_name_desc"].ToString();
                    Loc_Row.store_control_subtype = int.Parse(Item["store_control_subtype"].ToString());


                    LocDS.store_control_type.Addstore_control_typeRow(Loc_Row);
                }
                ReturnDS = LocDS;
            }
            else if (functionName == "get_product_use_cases")
            {
                //SELECT store_control_type.store_control_type_id, store_control_type.store_control_name, store_control_type.store_control_name_desc, store_control_type.store_control_subtype FROM fred.store_control_type store_control_type

                local_datasets.ProductDS ProdDS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.Product_Use_CaseRow ProdUse_Row = ProdDS.Product_Use_Case.NewProduct_Use_CaseRow();

                    ProdUse_Row.id = int.Parse(Item["id"].ToString());
                    ProdUse_Row.Statement = Item["Statement"].ToString();
                    ProdUse_Row.ParentID = int.Parse(Item["ParentID"].ToString());
                    ProdUse_Row.TAG = Item["TAG"].ToString();

                    ProdDS.Product_Use_Case.AddProduct_Use_CaseRow(ProdUse_Row);
                }
                ReturnDS = ProdDS;
            }

            else if (functionName == "get_all_brands")
            {
                //SELECT store_control_type.store_control_type_id, store_control_type.store_control_name, store_control_type.store_control_name_desc, store_control_type.store_control_subtype FROM fred.store_control_type store_control_type

                local_datasets.ProductDS ProdDS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.BrandsRow Brand_Row = ProdDS.Brands.NewBrandsRow();

                    Brand_Row.BrandID = int.Parse(Item["BrandID"].ToString());
                    if (ReturnDataTable.Columns.Contains("BrandName"))
                    {
                        Brand_Row.BrandName = Item["BrandName"].ToString();
                    }
                    if (ReturnDataTable.Columns.Contains("BrandWeight"))
                    {
                        Brand_Row.BrandWeight = int.Parse(Item["BrandWeight"].ToString());
                    }

                    

                    ProdDS.Brands.AddBrandsRow(Brand_Row);
                }
                ReturnDS = ProdDS;
            }
            else if (functionName == "get_brand_products_by_id")
            {
              
                local_datasets.ProductDS DS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.Brand_ProductsRow BrandProd_Row = DS.Brand_Products.NewBrand_ProductsRow();

                    BrandProd_Row.BrandProductID= int.Parse(Item["BrandProductID"].ToString());
                    if(ReturnDataTable.Columns.Contains("Brand"))
                    {
                        BrandProd_Row.Brand = int.Parse(Item["Brand"].ToString());
                    }
                    
                    if(ReturnDataTable.Columns.Contains("ProductName"))
                    {
                        BrandProd_Row.ProductName = Item["ProductName"].ToString();
                    }
                    

                    DS.Brand_Products.AddBrand_ProductsRow(BrandProd_Row);
                }
                ReturnDS = DS;
            }
            //get_all_product_sizes
            else if (functionName == "get_all_product_sizes")
            {

                local_datasets.ProductDS DS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.Product_Size_UnitsRow ProdSize = DS.Product_Size_Units.NewProduct_Size_UnitsRow();

                    ProdSize.ID = int.Parse(Item["ID"].ToString());
                    if (ReturnDataTable.Columns.Contains("Unit"))
                    {
                        ProdSize.Unit = Item["Unit"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("TheOrder"))
                    {
                        ProdSize.TheOrder =int.Parse( Item["TheOrder"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("GroupType"))
                    {
                        ProdSize.GroupType =int.Parse( Item["GroupType"].ToString());
                    }

                    DS.Product_Size_Units.AddProduct_Size_UnitsRow(ProdSize);
                }
                ReturnDS = DS;
            }
            //get_product_barcode_by_brandproduct
            else if (functionName == "get_product_barcode_by_brandproduct")
            {

                local_datasets.ProductDS DS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.Product_BarcodesRow BarRow = DS.Product_Barcodes.NewProduct_BarcodesRow();

                    BarRow.ProductBarcodeID = int.Parse(Item["ProductBarcodeID"].ToString());

                    if (ReturnDataTable.Columns.Contains("BrandProductID"))
                    {
                        BarRow.BrandProductID = int.Parse(Item["BrandProductID"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("BarcodeType"))
                    {
                        BarRow.BarcodeType = int.Parse(Item["BarcodeType"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("Barcode"))
                    {
                        BarRow.Barcode =Item["Barcode"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("CaseQTY"))
                    {
                        BarRow.CaseQTY = int.Parse(Item["CaseQTY"].ToString());
                    }

                    //if (ReturnDataTable.Columns.Contains("IsDeleted"))
                    //{
                    //    BarRow.CreatedDateTime = int.Parse(Item["IsDeleted"].ToString());
                    //}
                    //if (ReturnDataTable.Columns.Contains("IsDeleted"))
                    //{
                    //    BarRow.UpdatedDateTime = int.Parse(Item["IsDeleted"].ToString());
                    //}


                    if (ReturnDataTable.Columns.Contains("IsDeleted"))
                    {
                        BarRow.IsDeleted = int.Parse(Item["IsDeleted"].ToString());
                    }

                    DS.Product_Barcodes.AddProduct_BarcodesRow(BarRow);
                }
                ReturnDS = DS;
            }

            //get_product_stock
            else if (functionName == "get_product_stock")
            {

                local_datasets.StockControlDS DS = new local_datasets.StockControlDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.StockControlDS.StockControlRow StockRow = DS.StockControl.NewStockControlRow();

                    StockRow.ProductID = int.Parse(Item["ProductID"].ToString());

                    if (ReturnDataTable.Columns.Contains("ProductFullName"))
                    {
                        StockRow.ProductName = Item["ProductFullName"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("StockForSale"))
                    {
                        StockRow.StockForSale = int.Parse(Item["StockForSale"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("StockReserve"))
                    {
                        StockRow.StockReserve = int.Parse(Item["StockReserve"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("StockSoldNotPicked"))
                    {
                        StockRow.StockSoldNotPicked = int.Parse(Item["StockSoldNotPicked"].ToString());
                    }

                    
                    DS.StockControl.AddStockControlRow(StockRow);
                }
                ReturnDS = DS;
            }

            //
            else if (functionName == "get_product_from_product_id")
            {

                local_datasets.ProductDS DS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.ProductsRow ProdRow = DS.Products.NewProductsRow();

                    ProdRow.ProductID = int.Parse(Item["ProductID"].ToString());

                    if (ReturnDataTable.Columns.Contains("BrandID"))
                    {
                        ProdRow.BrandID = int.Parse(Item["BrandID"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("BrandInName"))
                    {
                        ProdRow.BrandInName = int.Parse(Item["BrandInName"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("IsCasePick"))
                    {
                        ProdRow.IsCasePick = int.Parse(Item["IsCasePick"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ISLocked"))
                    {
                        ProdRow.ISLocked = int.Parse(Item["ISLocked"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("IsLockedBy"))
                    {
                        ProdRow.IsLockedBy = int.Parse(Item["IsLockedBy"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("PostFix"))
                    {
                        ProdRow.PostFix =Item["PostFix"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("PreFix"))
                    {
                        ProdRow.PreFix = Item["PreFix"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("ProductFullName"))
                    {
                        ProdRow.ProductFullName = Item["ProductFullName"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("ProductItemHeight"))
                    {
                        ProdRow.ProductHeight = int.Parse(Item["ProductItemHeight"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductImageURL"))
                    {
                        ProdRow.ProductImageURL = Item["ProductImageURL"].ToString();
                    }


                    if (ReturnDataTable.Columns.Contains("ProductItemLenght"))
                    {
                        ProdRow.ProductLenght = int.Parse(Item["ProductItemLenght"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductLongDescription"))
                    {
                        ProdRow.ProductLongDescription = Item["ProductLongDescription"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("ProductName"))
                    {
                        ProdRow.ProductName = Item["ProductName"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("ProductRealWeight"))
                    {
                        ProdRow.ProductRealWeight = double.Parse(Item["ProductRealWeight"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductRRP"))
                    {
                        ProdRow.ProductRRP = double.Parse(Item["ProductRRP"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductShortDescription"))
                    {
                        ProdRow.ProductShortDescription =Item["ProductShortDescription"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("ProductTotalVolume"))
                    {
                        ProdRow.ProductTotalVolume = int.Parse(Item["ProductTotalVolume"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductType"))
                    {
                        ProdRow.ProductType = int.Parse(Item["ProductType"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductVateCode"))
                    {
                        ProdRow.ProductVateCode = int.Parse(Item["ProductVateCode"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductVolumetricWeight"))
                    {
                        ProdRow.ProductVolumetricWeight = double.Parse(Item["ProductVolumetricWeight"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("ProductItemWidth"))
                    {
                        ProdRow.ProductWidth = int.Parse(Item["ProductItemWidth"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("SizeUnit"))
                    {
                        ProdRow.SizeUnit = int.Parse(Item["SizeUnit"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("SizeString"))
                    {
                        ProdRow.SizeString = Item["SizeString"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("BrandProduct"))
                    {
                        ProdRow.BrandProduct = int.Parse(Item["BrandProduct"].ToString());
                    }
                    if (ReturnDataTable.Columns.Contains("SizeRelative"))
                    {
                        ProdRow.SizeRelative = int.Parse(Item["SizeRelative"].ToString());
                    }

                    DS.Products.AddProductsRow(ProdRow);
                }
                ReturnDS = DS;
            }
            else if (functionName == "get_caseconfig")
            {

                local_datasets.ProductDS DS = new local_datasets.ProductDS();
                foreach (DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.ProductDS.ProductCaseConfigRow CaseRow = DS.ProductCaseConfig.NewProductCaseConfigRow();

                    CaseRow.CaseConfigID = int.Parse(Item["CaseConfigID"].ToString());

                    if (ReturnDataTable.Columns.Contains("ProductID"))
                    {
                        CaseRow.ProductID = int.Parse(Item["ProductID"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("CaseDescription"))
                    {
                        CaseRow.CaseDescription = Item["CaseDescription"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("CaseQty"))
                    {
                        CaseRow.CaseQty = int.Parse(Item["CaseQty"].ToString());
                    }

                    if (ReturnDataTable.Columns.Contains("CaseBarcode"))
                    {
                        CaseRow.CaseBarcode = Item["CaseBarcode"].ToString();
                    }

                    if (ReturnDataTable.Columns.Contains("Deleted"))
                    {
                        CaseRow.Deleted = int.Parse(Item["Deleted"].ToString());
                    }

                    DS.ProductCaseConfig.AddProductCaseConfigRow(CaseRow);
                }
                ReturnDS = DS;
            }
            else
            {
                //just pass a blank table back
                //declare the tempory local variables used for error catching
                //create the empty returning dataset
                //now loop the table items and convert into a dataset
            }

            return ReturnDS;
        }
        private string Register_for_Store_Location_Updates(string id)
        {
            string retvalue = "";


            return retvalue;
        }

        public local_datasets.LocationGrid GetLocationGrid(int LocationRef)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string job = "get_gridlocations";
            string res = Make_db_call(job, LocationRef.ToString());
            if (res.Trim().Length != 0)
            {
               RetGrid.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }
            
            return RetGrid;
        }

        public int CreateLocGridItem(string LocName, int LocType, int LocParent, string FullName, string ShortName, int PickOrder)
        {
            int retvalue = 0;
            string parameters = "{'LocName': '" + LocName + "', 'LocType': '" + LocType.ToString() + "', 'LocParent': '" + LocParent.ToString() + "','FullName': '" + FullName.ToString() + "','ShortName': '" + ShortName.ToString() + "','PickOrder': '" + PickOrder.ToString() + "'}";
            string job = "add_node_to_loc_grid";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                DataTable ReturnDataTable;
                ReturnDataTable = (DataTable)JsonConvert.DeserializeObject(res, (typeof(DataTable)));

                retvalue = int.Parse(ReturnDataTable.Rows[0][0].ToString());
                On_LocationChanged(this, new EventArgs());
            }
            else
            {
                FailedWebReseponce("");
            }
            
            return retvalue;
        }

        public local_datasets.LocationGrid EditLocGridItem(string LocName, int LocType, int LocParent, int LocGridID, string FullName, string ShortName, int PickOrder)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "{'LocName': '" + LocName + "', 'LocType': '" + LocType.ToString() + "', 'LocParent': '" + LocParent.ToString() + "', 'LocGridID': '" + LocGridID.ToString() + "','FullName': '" + FullName.ToString() + "','ShortName': '" + ShortName.ToString() + "','PickOrder': '" + PickOrder.ToString() + "'}";
            string job = "edit_node_to_loc_grid";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                RetGrid.Merge(FormatStringToDataTable("get_gridlocations", res));
                On_LocationChanged(this, new EventArgs());
            }
            else
            {
                FailedWebReseponce("");
            }

            return RetGrid;
        }
        //get_location_types
        public local_datasets.LocationTypes Get_LocationTypes()
        {
            local_datasets.LocationTypes LocTypes = new local_datasets.LocationTypes();
            string job = "get_location_types";
            string res = Make_db_call(job, "");
            if (res.Trim().Length != 0)
            {
                LocTypes.Merge(FormatStringToDataTable(job, res));     
            }
            else
            {
                FailedWebReseponce("");
            }


            return LocTypes;
        }

        public local_datasets.LocationGrid Get_Location_Zone_Layout(int shopid)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = shopid.ToString();
            string job = "get_location_Store_Zone_Layout";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                RetGrid.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }
            

            return RetGrid;


        }


        public local_datasets.LocationGrid AddNewStoreLayoutRow(int BuildingID, int LocGrid_ID, int Control_Type, int Control_Y, int Control_X, int Control_Z, int Control_Size)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "{'BuildingID': '" + BuildingID + "', 'LocGrid_ID': '" + LocGrid_ID.ToString() + "', 'Control_Type': '" + Control_Type.ToString() + "', 'Control_Y': '" + Control_Y.ToString() + "','Control_X': '" + Control_X.ToString() + "','Control_Z': '" + Control_Z.ToString() + "','Control_Size': '" + Control_Size.ToString() + "'}";
            string job = "add_store_layout_row";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
               
            }
            else
            {
                FailedWebReseponce("");
            }
            //RetGrid.Merge(FormatStringToDataTable("get_location_Store_Zone_Layout", res));
            return RetGrid;
        }

        public local_datasets.LocationGrid EditStoreLayoutRow(int BuildingID, int LocGrid_ID, int Control_Type, int Control_Y, int Control_X, int Control_Z, int id, int Control_Size)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "{'BuildingID': '" + BuildingID + "', 'LocGrid_ID': '" + LocGrid_ID.ToString() + "', 'Control_Type': '" + Control_Type.ToString() + "', 'Control_Y': '" + Control_Y.ToString() + "','Control_X': '" + Control_X.ToString() + "','Control_Z': '" + Control_Z.ToString() + "','id': '" + id.ToString() + "','Control_Size': '" + Control_Size.ToString() + "'}";
            string job = "edit_store_layout_row";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                
            }
            else
            {
                FailedWebReseponce("");
            }
            //RetGrid.Merge(FormatStringToDataTable("get_location_Store_Zone_Layout", res));
            return RetGrid;
        }

        public local_datasets.LocationGrid GetStoreLayoutDataset()
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "";
            string job = "get_location_Store_Zone_Funiture";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                RetGrid.Merge(FormatStringToDataTable(job, res));             
            }
            else
            {
                FailedWebReseponce("");
            }

            return RetGrid;

        }

        public local_datasets.ProductDS Get_Product_Use_Cases()
        {
            local_datasets.ProductDS ProductDS = new local_datasets.ProductDS();
            string parameters = "";
            string job = "get_product_use_cases";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                ProductDS.Merge(FormatStringToDataTable(job, res));            
            }
            else
            {
                FailedWebReseponce("");
            }

            return ProductDS;
        }
        public local_datasets.ProductDS Get_Brands()
        {
            local_datasets.ProductDS ProductDS = new local_datasets.ProductDS();
            string parameters = "";
            string job = "get_all_brands";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length!=0)
            {
                ProductDS.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }
            return ProductDS;
        }

        public local_datasets.ProductDS add_new_brand(string BrandName,int BrandWeight)
        {
            local_datasets.ProductDS ProductDS = new local_datasets.ProductDS();
            string parameters = "{ 'BrandName': '" + BrandName + "', 'BrandWeight': '" + BrandWeight.ToString() + "'}";
            string job = "add_new_brand";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                ProductDS.Merge(FormatStringToDataTable("get_all_brands", res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return ProductDS;
        }

        public local_datasets.ProductDS Get_Brand_Product(int BrandID)
        {
            local_datasets.ProductDS DS = new local_datasets.ProductDS();
            string parameters = "{'BrandID': '" + BrandID.ToString() + "'}";
            string job = "get_brand_products_by_id";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                DS.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return DS;
        }

        public local_datasets.ProductDS add_new_brand_products(string productid, int brandid)
        {
            local_datasets.ProductDS DS = new local_datasets.ProductDS();
            string parameters = "{'Brand': '" + brandid.ToString() + "','ProductName':'" + productid + "'}";
            string job = "add_new_brand_product";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                DS.Merge(FormatStringToDataTable("get_brand_products_by_id", res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return DS;
        }

        public local_datasets.ProductDS Get_product_sizes(bool refresh)
        {
            bool newds = false;
            if(LocalDS == null)
            {
                LocalDS = new local_datasets.ProductDS();
                newds = true;
            }
            string parameters = "";
            string job = "get_all_product_sizes";
            if(refresh==true || newds==true)
            {

                string res = Make_db_call(job, parameters.ToString());
                if (res.Trim().Length != 0)
                {

                }
                else
                {
                    FailedWebReseponce("");
                }
                LocalDS.Product_Size_Units.Clear();
                LocalDS.Merge(FormatStringToDataTable(job, res));
            }
           
            

            return LocalDS;
        }


        public local_datasets.ProductDS Get_BrandProduct_Barcodes(int ProductID)
        {
            local_datasets.ProductDS DS = new local_datasets.ProductDS();
            string parameters = "{'BrandProductID': '" + ProductID.ToString() + "'}";
            string job = "get_product_barcode_by_brandproduct";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                DS.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return DS;
        }

        public local_datasets.ProductDS Update_Product(base_classes.productclass Prod, local_datasets.ProductDS CheckDS)
        {
            local_datasets.ProductDS DS = new local_datasets.ProductDS();
            //Prod.ProductID = 0;//fudge factor 10
            string parameters="";
            //If productID is empty then its an INSERT statement
            if (CheckNewValue(CheckDS, "ProductID") == true) { parameters = AC(parameters) + "'ProductID': '" + Prod.ProductID.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductName") == true) { parameters = AC(parameters) + "'ProductName': '" + Prod.BrandProductName.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductFullName") == true) { parameters = AC(parameters) + "'ProductFullName': '" + Prod.ProductFullName.ToString() + "'"; }


            if (CheckNewValue(CheckDS, "BrandID") == true) { parameters = AC(parameters) + "'BrandID': '" + Prod.BrandID.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "BrandInName") == true) { parameters = AC(parameters) + "'BrandInName': '" + Prod.BrandInName.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "BrandProduct") == true) { parameters = AC(parameters) + "'BrandProduct': '" + Prod.BrandProduct.ToString() + "'"; }


            if (CheckNewValue(CheckDS, "ProductShortDescription") == true) { parameters = AC(parameters) + "'ProductShortDescription': '" + Prod.ProductShortDescription.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductLongDescription") == true) { parameters = AC(parameters) + "'ProductLongDescription': '" + Prod.ProductLongDescription.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductRealWeight") == true) { parameters = AC(parameters) + "'ProductRealWeight': '" + Prod.ProductRealWeight.ToString() + "'"; }


            if (CheckNewValue(CheckDS, "ProductVolumetricWeight") == true) { parameters = AC(parameters) + "'ProductVolumetricWeight': '" + Prod.ProductVolumetricWeight.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductVateCode") == true) { parameters = AC(parameters) + "'ProductVateCode': '" + Prod.ProductVateCode.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductItemRRP") == true) { parameters = AC(parameters) + "'ProductItemRRP': '" + Prod.ProductItemRRP.ToString() + "'"; }



            if (CheckNewValue(CheckDS, "ProductItemLenght") == true) { parameters = AC(parameters) + "'ProductItemLenght': '" + Prod.ProductItemLenght.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductItemWidth") == true) { parameters = AC(parameters) + "'ProductItemWidth': '" + Prod.ProductItemWidth.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ProductItemHeight") == true) { parameters = AC(parameters) + "'ProductItemHeight': '" + Prod.ProductItemHeight.ToString() + "'"; }

            if (CheckNewValue(CheckDS, "ProductTotalVolume") == true) { parameters = AC(parameters) + "'ProductTotalVolume': '" + Prod.ProductTotalVolume.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "SizeRelative") == true) { parameters = AC(parameters) + "'SizeRelative': '" + Prod.SizeRelative.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "SizeUnit") == true) { parameters = AC(parameters) + "'SizeUnit': '" + Prod.SizeUnit.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "SizeString") == true) { parameters = AC(parameters) + "'SizeString': '" + Prod.SizeString.ToString() + "'"; }

            if (CheckNewValue(CheckDS, "PreFix") == true) { parameters = AC(parameters) + "'PreFix': '" + Prod.PreFix.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "PostFix") == true) { parameters = AC(parameters) + "'PostFix': '" + Prod.PostFix.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "ISLocked") == true) { parameters = AC(parameters) + "'ISLocked': '" + Prod.ISLocked.ToString() + "'"; }

            if (CheckNewValue(CheckDS, "IsLockedBy") == true) { parameters = AC(parameters) + "'IsLockedBy': '" + Prod.IsLockedBy.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "InnerPackQty") == true) { parameters = AC(parameters) + "'InnerPackQty': '" + Prod.InnerPackQty.ToString() + "'"; }
            if (CheckNewValue(CheckDS, "IsCasePick") == true) { parameters = AC(parameters) + "'IsCasePick': '" + Prod.IsCasePick.ToString() + "'"; }

            
            string q_params = ",'TableName':'Products','Pk':'ProductID','UpDateWhere':'" + Prod.ProductID.ToString() + "'";

            if(parameters=="")
            {
                //nothing to update
                return DS;
            }
            else
            {
                parameters = "{" + parameters + q_params + "}";
            }
            

          

            string job = "update_product_dataset";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                if(res=="1")
                {
                    //its worked
                }
                //DS.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return DS;
        }
        private string AC(string Param)
        {
            string retvalue = "";
            if(Param.Length>0)
            {
                retvalue = Param + "," ;
            }
            else
            {
                retvalue = Param;
            }
           
            return retvalue;
        }
        private bool CheckNewValue(local_datasets.ProductDS CheckDS,string Key)
        {
            bool ret=false;
            DataRow[] result;
            //search for the value pair
            result = CheckDS.ValuePair.Select("Prop='" + Key + "'");
            if (result.Length==1)
            {
                // the the original value changed?
                if(result[0]["value"].ToString()!= result[0]["originalValue"].ToString())
                {
                    //there has been a change
                    ret = true;
                }
                else
                {
                    if(result[0]["value"].ToString()=="")
                    {
                        ret = true;
                    }
                    else
                    {
                        ret = false;
                    }
                    
                }
            }
            else
            {
                ret = false;
            }

                return ret;
        }
        public local_datasets.StockControlDS GetAllStock()
        {
            local_datasets.StockControlDS ret =new local_datasets.StockControlDS();

            string parameters = "{'job':'get_all'}";
            string job = "get_product_stock";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                ret.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }


            return ret;
        }
        public local_datasets.ProductDS Get_Product_Details_From_ProductID(int ProductID)
        {   
            local_datasets.ProductDS ret = new local_datasets.ProductDS();
            string parameters = "{'productid':'" + ProductID.ToString() + "'}";
            string job = "get_product_from_product_id";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                ret.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return ret;
        }



        public local_datasets.ProductDS Get_Product_Case_Configeration(int ProductID)
        {
            local_datasets.ProductDS ret = new local_datasets.ProductDS();
            string parameters = "{'productid':'" + ProductID.ToString() + "'}";
            string job = "get_caseconfig";
            string res = Make_db_call(job, parameters.ToString());
            if (res.Trim().Length != 0)
            {
                ret.Merge(FormatStringToDataTable(job, res));
            }
            else
            {
                FailedWebReseponce("");
            }

            return ret;

        }

        public int Add_New_Case_Config(string CaseDesc, int caseQTY, string barcode,int productid)
        {
            int newCaseID=0;
            string job = "update_case_config_dataset";
            string jsonstring = "{'TableName':'ProductCaseConfig','Pk':'CaseConfigID','CaseConfigID':'0','ProductID':'" + productid.ToString() + "','CaseDescription':'" + CaseDesc + "','CaseQty':'" + caseQTY.ToString() + "','CaseBarcode':'" + barcode + "','Deleted':'0'}";
            string res = Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
                //res="{'dan':'p'}";
                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { CaseConfigID = ""};
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf=int.Parse(jsonObject.CaseConfigID.ToString());
                newCaseID = tf;
            }
            else
            {
                FailedWebReseponce("");
            }


            return newCaseID;
        }


        public int Edit_Case_Config(string CaseDesc, int caseQTY, string barcode, int productid, int CaseConfigID, int Del)
        {
            int newCaseID = 0;
            string job = "update_case_config_dataset";
            string jsonstring = "{'TableName':'ProductCaseConfig','Pk':'CaseConfigID','CaseConfigID':'" + CaseConfigID.ToString() + "','ProductID':'" + productid.ToString() + "','CaseDescription':'" + CaseDesc + "','CaseQty':'" + caseQTY.ToString() + "','CaseBarcode':'" + barcode + "','Deleted':'" + Del + "','UpDateWhere':'" + CaseConfigID.ToString() + "'}";
            string res = Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {
              
                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { result = "" };
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf = int.Parse(jsonObject.result.ToString());
                newCaseID = tf;
            }
            else
            {
                FailedWebReseponce("");
            }


            return newCaseID;
        }


        public int Add_ProductInstance(int ProductID, double cost_price,int invoice)
        {
            int newInstance = 0;
            string job = "update_product_instance_dataset";
            string extra = "'TableName':'Product_Instance','Pk':'pv_autoID'";
            string jsonstring = "{" + extra + ",'pv_autoID':'0','productID':'" + ProductID.ToString() + "','Item_costprice':'" + cost_price.ToString() + "','InvoiceID':'" + invoice.ToString() + "'}";
            string res = Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {

                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { pv_autoID = "" };
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf = int.Parse(jsonObject.pv_autoID.ToString());
                newInstance = tf;
            }
            else
            {
                FailedWebReseponce("");
            }

            return newInstance;
        }

        public int Add_Varient(int instanceID, string BBE)
        {
            int newInstance = 0;
            string job = "update_product_varience_dataset";
            string extra = "'TableName':'Product_Varient','Pk':'Product_VarientID'";
            string jsonstring = "{" + extra + ",'Product_VarientID':'0','ProductInstanceID':'" + instanceID.ToString() + "','BBE':'" + BBE.ToString() + "'}";
            string res = Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {

                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { product_varient_ID = "" };
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf = int.Parse(jsonObject.product_varient_ID.ToString());
                newInstance = tf;
            }
            else
            {
                FailedWebReseponce("");
            }

            return newInstance;
        }
        public int Add_Varient_Stock_Instance(int varientID, int qty, int location)
        {
            int newInstance = 0;
            string job = "update_product_stock_varience_dataset";
            string extra = "'TableName':'Product_Varient_Location_Stock_qty','Pk':'product_stock_VID'";
            string jsonstring = "{" + extra + ",'product_stock_VID':'0','Product_Instance_ID':'" + varientID.ToString() + "','Varient_QTY':'" + qty.ToString() + "','Varient_Location_ID':'" + location.ToString() + "'}";
            string res = Make_db_call(job, jsonstring.ToString());
            if (res.Trim().Length != 0)
            {

                string newg = res.Replace("[", "");
                newg = newg.Replace("]", "");
                var a = new { product_varient_ID = "" };
                var c = new JsonSerializer();
                dynamic jsonObject = c.Deserialize(new System.IO.StringReader(newg), a.GetType());
                int tf;
                tf = int.Parse(jsonObject.product_varient_ID.ToString());
                newInstance = tf;
            }
            else
            {
                FailedWebReseponce("");
            }

            return newInstance;
        }
        private void FailedWebReseponce(string E)
        {

        }
}
}
