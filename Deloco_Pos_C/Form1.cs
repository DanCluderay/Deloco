using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
 

using System.Net;
namespace Deloco_Pos_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                        DataTable tester = (DataTable)JsonConvert.DeserializeObject(newstring, (typeof(DataTable)));
                    }
                }

            }
        }

    }
}
