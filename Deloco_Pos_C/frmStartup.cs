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
        public frmStartup()
        {
            InitializeComponent();
        }

        private void developmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 devform = new Form1();
            devform.MdiParent = this;
            devform.Show();
        }
    }
}
