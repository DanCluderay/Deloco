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
    
    public partial class frmAllCustomer : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmAllCustomer()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmAllCustomer_Load(object sender, EventArgs e)
        {
            logic_global.On_mqtt_new += Logic_global_On_mqtt_new;
        }

        private void Logic_global_On_mqtt_new(object sender, EventArgs e)
        {
     
        }
    }
}
