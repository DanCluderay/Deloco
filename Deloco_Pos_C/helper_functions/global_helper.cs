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
            mqtt_list = new List<mqtt_msg_object>();
            client = new MqttClient(MqttClient_Server);
            returnValue = "Connected to client";
            clientId = Guid.NewGuid().ToString();
            Mqtt_Subscribe(Topic);
            

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

            string url = "https://00t1ug5s49.execute-api.eu-west-1.amazonaws.com/prod/apex-deepretail_deppcore?func=" + func + "&val=" + val;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responce = client.GetAsync(url).Result)
                {
                    using (HttpContent content = responce.Content)
                    {
                        string mycontent = content.ReadAsStringAsync().Result;

                        string newstring = mycontent.Replace("\"", "'");

                        return newstring;

                        //DataSet tester = (DataSet)JsonConvert.DeserializeObject(newstring, (typeof(DataSet)));
                        //DataTable tester = (DataTable)JsonConvert.DeserializeObject(newstring, (typeof(DataTable)));


                    }
                }
            }

            

        }

        public DataSet FormatStringToDataTable(string functionName,string responcestring)
        {
            DataTable ReturnDataTable;
            DataSet ReturnDS = new DataSet();
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

                    _order_autoid = Int32.Parse( Item["order_autoid"].ToString());
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

                    _delivery_address_Postcode =Item["delivery_address_Postcode"].ToString();
                    NewRow.delivery_address_Postcode = _delivery_address_Postcode;

                    _delivery_address_Country = Item["delivery_address_Country"].ToString();
                    NewRow.delivery_address_Country = _delivery_address_Country;

                    _Customer_First_Name = Item["Customer_First_Name"].ToString();
                    NewRow.Customer_First_Name = _Customer_First_Name;

                    _CustomerTitle = Item["CustomerTitle"].ToString();
                    NewRow.CustomerTitle= _CustomerTitle;

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
                    shopid=Int32.Parse(Item["store_autoid"].ToString());
                    shopname = Item["store_name"].ToString();
                    shopshortcode = Item["store_shortcode"].ToString();
                    StoreRow.store_autoid = shopid;
                    StoreRow.store_name = shopname;
                    StoreRow.store_shortcode = shopshortcode;

                    Stores.stores.AddstoresRow(StoreRow);
                }

                ReturnDS = Stores;
            }
            else if(functionName== "get_productview_by_prodID")
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
                    ProdViewRow.ProductVarientName= Item["pv_Name"].ToString();
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
                foreach(DataRow Item in ReturnDataTable.Rows)
                {
                    local_datasets.LocationTypes.LocationTypesRow  Loc_Row = LocType._LocationTypes.NewLocationTypesRow();

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
                    //Loc_Row.Control_Z = int.Parse(Item["Control_Z"].ToString());

                    LocDS.storelayout.AddstorelayoutRow(Loc_Row);
                }
                ReturnDS = LocDS;
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
            RetGrid.Merge(FormatStringToDataTable(job, res));
            return RetGrid;
        }

        public local_datasets.LocationGrid CreateLocGridItem(string LocName,int LocType,int LocParent,string FullName, string ShortName,int PickOrder)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "{'LocName': '" + LocName + "', 'LocType': '" + LocType.ToString() + "', 'LocParent': '" + LocParent.ToString() + "','FullName': '" + FullName.ToString() + "','ShortName': '" + ShortName.ToString() + "','PickOrder': '" + PickOrder.ToString() + "'}";
            string job = "add_node_to_loc_grid";
            string res = Make_db_call(job, parameters.ToString());
            RetGrid.Merge(FormatStringToDataTable("get_gridlocations", res));
            On_LocationChanged(this, new EventArgs());
            return RetGrid;
        }

        public local_datasets.LocationGrid EditLocGridItem(string LocName, int LocType, int LocParent, int LocGridID, string FullName, string ShortName, int PickOrder)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = "{'LocName': '" + LocName + "', 'LocType': '" + LocType.ToString() + "', 'LocParent': '" + LocParent.ToString() + "', 'LocGridID': '" + LocGridID.ToString() + "','FullName': '" + FullName.ToString() + "','ShortName': '" + ShortName.ToString() + "','PickOrder': '" + PickOrder.ToString() + "'}";
            string job = "edit_node_to_loc_grid";
            string res = Make_db_call(job, parameters.ToString());
            RetGrid.Merge(FormatStringToDataTable("get_gridlocations", res));
            On_LocationChanged(this, new EventArgs());
            return RetGrid;
        }
        //get_location_types
        public local_datasets.LocationTypes Get_LocationTypes()
        {
            local_datasets.LocationTypes LocTypes = new local_datasets.LocationTypes();
            string job = "get_location_types";
            string res = Make_db_call(job, "");
            LocTypes.Merge(FormatStringToDataTable(job, res));
            
            return LocTypes;
        }

        public local_datasets.LocationGrid Get_Location_Zone_Layout(int shopid)
        {
            local_datasets.LocationGrid RetGrid = new local_datasets.LocationGrid();
            string parameters = shopid.ToString();
            string job = "get_location_Store_Zone_Layout";
            string res = Make_db_call(job, parameters.ToString());
            RetGrid.Merge(FormatStringToDataTable(job, res));
           
            return RetGrid;


        }
    }
}
