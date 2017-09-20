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

        public event EventHandler On_mqtt_new = delegate { };
        //public event SetStatus SetStatusEvent = delegate { };


        MqttClient client;
        private static globalHelper instance;

        List<mqtt_msg_object> mqtt_list = new List<mqtt_msg_object>();
       
        private globalHelper() { }
        private string _mqttserver = "";

        
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

            Mqtt_Subscribe(Topic);
            

            return returnValue;
        }
        public string Mqtt_Subscribe(string Topic)
        {

            string return_value = "";

            //// register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            //Later this will be a shop/userid
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(new string[] { Topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });


            return_value = "subcribed to: " + Topic + " successfully";
            return return_value;

        }
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
           
            
            
            mqtt_msg_object newItem = new mqtt_msg_object();
            newItem.msg_payload = ReceivedMessage;
            newItem.msg_topic = "cluderay";

            mqtt_list.Add(newItem);

            On_mqtt_new(this, new EventArgs());

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
                DateTime _orders_time;

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

                    //string test_deliverydate = Item["delivery_date"].ToString();
                    //if (test_deliverydate=="")
                    //{
                    //    test_deliverydate = "2017-01-01";
                    //}
                    //_delivery_date = Convert.ToDateTime(test_deliverydate);
                    //NewRow.delivery_date = _delivery_date;

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
                DateTime _order_date;
                DateTime _order_time;

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
            else
            {
                //just pass a blank table back
                //declare the tempory local variables used for error catching
                //create the empty returning dataset
                //now loop the table items and convert into a dataset
            }

            return ReturnDS;
        }

    }
}
