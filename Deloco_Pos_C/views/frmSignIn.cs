using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.views
{
    public partial class frmSignIn : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmSignIn()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            logic_global.On_Signed_in += Logic_global_On_Signed_in;
            lst_Events.Items.Add("Attempting to connect to test.mosquitto.org - " + DateTime.Now.ToString());
            logic_global.MqttClient_Server = "test.mosquitto.org";
            lst_Events.Items.Add("Success! - connected to test.mosquitto.org - " + DateTime.Now.ToString());
            lst_Events.Items.Add("Attempting to connect to 'cluderay' - " + DateTime.Now.ToString());
            logic_global.connectToMQTTServer("cluderay");
            lst_Events.Items.Add("Success! - connected to 'cluderay' - " + DateTime.Now.ToString());
        }

        private void Logic_global_On_Signed_in(object sender, EventArgs e)
        {

            //minimise this form when you are signed in
            lst_Events.Items.Add("Success! - signed in - " + DateTime.Now.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic_global.Sign_In("", "");
        }
    }
}
