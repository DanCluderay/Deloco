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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tab_payment.Show();
            tab_customer.Hide();
            tab_other.Hide();
            tab_transaction.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab_payment.Hide();
            tab_customer.Hide();
            tab_other.Hide();
            tab_transaction.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tab_payment.Hide();
            tab_customer.Show();
            tab_other.Hide();
            tab_transaction.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab_payment.Hide();
            tab_customer.Hide();
            tab_other.Show();
            tab_transaction.Hide();
        }
    }
}
