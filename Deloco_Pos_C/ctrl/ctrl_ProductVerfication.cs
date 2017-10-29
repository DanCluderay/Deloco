using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.ctrl
{
    public partial class ctrl_ProductVerfication : UserControl
    {
        
        public ctrl_ProductVerfication()
        {
            InitializeComponent();
            
        }

        private void ctrl_ProductVerfication_Load(object sender, EventArgs e)
        {

        }
        public void Add_Rule(string RuleName, string Original, string NewValue,string Status)
        {
            local_datasets.ProductDS.ProductVerificationRow Rule = productDS.ProductVerification.NewProductVerificationRow();
            Rule.Status = Status;
            Rule.RuleName = RuleName;
            Rule.OriginalValue = Original;
            Rule.NewValue = NewValue;

            productDS.ProductVerification.AddProductVerificationRow(Rule);
        }
        public void Set_Rule(string RuleName, string Original, string NewValue, string Status)
        {
            DataRow[] results;
            results =productDS.ProductVerification.Select("");
        }
    }
}
