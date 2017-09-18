using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Windows.Threading;

using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace Deloco_Pos_C
{
    public partial class Form1 : Form
    {

        MqttClient client = new MqttClient("test.mosquitto.org");
        public Form1()
        {
            InitializeComponent();
            MqttClient client = new MqttClient("test.mosquitto.org");
        }

        private void Mqtttest()
        {

           

            //// register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(new string[] { "cluderay" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });


        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
           
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string func = txtFunction.Text;
            string val = txtValue.Text;
            string url = "https://00t1ug5s49.execute-api.eu-west-1.amazonaws.com/prod/apex-deepretail_deppcore?func=" + func + "&val=" + val;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responce =  client.GetAsync(url).Result)
                {
                    using (HttpContent content = responce.Content)
                    {
                        string mycontent =  content.ReadAsStringAsync().Result;
                        txtResult.Text = mycontent;
                        string newstring=mycontent.Replace("\"", "'");

                        //DataSet tester = (DataSet)JsonConvert.DeserializeObject(newstring, (typeof(DataSet)));
                        DataTable tester = (DataTable)JsonConvert.DeserializeObject(newstring, (typeof(DataTable)));
                        tester.TableName = "Customers";

                        customersdataset.Tables.Remove("Customers");
                        customersdataset.Tables.Add(tester);

                        customersdsBindingSource.DataSource = customersdataset;
                        customersdsBindingSource.DataMember = tester.TableName;
                        customersdsBindingSource.Filter = "";
                        dataGridView1.DataMember = tester.TableName;
                      
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mqtttest();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ("Fed" != "")
            {
                // whole topic
                string Topic = "cluderay";

                // publish a message with QoS 2
                client.Publish(Topic, Encoding.UTF8.GetBytes(txtMQTTPush.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
            else
            {
                //System.Windows.MessageBox.Show("You have to enter a topic to publish!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string func = "mqtt_call";
            string val = this.txtServer_mqtt_notification.Text;
            string url = "https://00t1ug5s49.execute-api.eu-west-1.amazonaws.com/prod/apex-deepretail_deppcore?func=" + func + "&val=" + val;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responce = client.GetAsync(url).Result)
                {
                    using (HttpContent content = responce.Content)
                    {
                        string mycontent = content.ReadAsStringAsync().Result;
                    }
                }

            }
        }
    }
}
