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
using System.Windows.Threading;

namespace Deloco_Pos_C.views
{
    //somechange
    public partial class frmMqtt : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmMqtt()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            logic_global.On_mqtt_new += Logic_global_On_mqtt_new;  
        }

        private void Logic_global_On_mqtt_new(object sender, EventArgs e)
        {
            Display_mqttlist();
        }

        private void frmMqtt_Load(object sender, EventArgs e)
        {
            Display_mqttlist();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void Display_mqttlist()
        {
            mqtt_ds.Clear();

            mqtt_ds.Merge(logic_global.GetMQTT_DataSet());
            
            mqttmsgBindingSource.DataSource = mqtt_ds;

            //if (!this.IsHandleCreated)
            //{
            //    Invoke(new MethodInvoker(updateGUI)) ;

            //}
            //var t= Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Normal,(Action)(() => updateGUI())).Result;
            if (IsHandleCreated)
            {
                 dataGridView1.Invoke((MethodInvoker)(() =>
                            {
                                updateGUI();
                            }));
            }
            else
            {
                updateGUI();
            }
               
        }
        void updateGUI()
        {
            // update gui here
           // mqttmsgBindingSource.Filter = "";
            //mqttmsgBindingSource.DataSource = mqtt_ds;
            mqttmsgBindingSource.ResetBindings(false);
            //dataGridView1.Refresh();
            lblLastUpDated.Text = "Last Updated at: " + DateTime.Now;
        }
        private void mqttmsgBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
