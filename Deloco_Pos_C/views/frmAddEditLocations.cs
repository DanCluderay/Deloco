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
    public partial class frmAddEditLocations : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmAddEditLocations()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        string CurrentMode;

        public string Setupform(string Mode, int Shopid,string shopname, string shopcode)
        {
            string retvalue = "";
            CurrentMode = Mode;
            if (Mode == "NEW")
               
            {
                this.Text = "Add a new Location";
            }
            else if (Mode == "UPDATE")
            {
                this.txtShopName.Text = shopname;
                this.txtShopCode.Text = shopcode;
                this.txtShopID.Text = Shopid.ToString();
                this.Text = "Add a existing Location - " + shopname;
            }

            return retvalue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaction_Click(object sender, EventArgs e)
        {
            string job = "";
            string parameters = "";

            string shopid = txtShopID.Text.ToString();
            string shopname = txtShopName.Text.ToString();
            string shopcode = txtShopCode.Text.ToString();

            //parameters = "{ \"update_address\": { \"shopid\": \"" + shopid + "\", \"shopname\": \"" + shopname + "\", \"shopcode\": \"" + shopcode + "\" } }";
            parameters = "{'shopid': '" + shopid + "', 'shopname': '" + shopname + "', 'shopcode': '" + shopcode + "'}";

            if (CurrentMode=="NEW")
            {
                job = "add_new_store_location";
                            }
            
            else if(CurrentMode=="UPDATE")
            {
                job = "update_store_location";
            }

            string responece = logic_global.Make_db_call(job, parameters);
            this.Close();
        }
    }
}
