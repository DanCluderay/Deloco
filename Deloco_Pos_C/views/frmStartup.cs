using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C
{
    public partial class frmStartup : Form
    {
        helper_functions.globalHelper logic_global =  helper_functions.globalHelper.Instance;
        public frmStartup()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void developmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 devform = new Form1();
            devform.MdiParent = this;
            devform.Show();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            logic_global.MqttClient_Server = "test.mosquitto.org";
            logic_global.connectToMQTTServer("cluderay");
            this.Text = "Ask the milkman - Langold Shop";
            
        }

        private void mQTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmMqtt mqttform = new views.frmMqtt();
            mqttform.MdiParent = this;
            mqttform.Show();
        }

        private void outstandingOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmLiveDemo LiveDemo = new views.frmLiveDemo();
            LiveDemo.MdiParent = this;
            LiveDemo.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            views.frmPOS POS = new views.frmPOS();
            POS.MdiParent = this;
            POS.Show();
        }
    }
}
