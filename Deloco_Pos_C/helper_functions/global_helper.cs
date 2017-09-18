using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

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
    }
}
