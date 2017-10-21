using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.controls
{
    public partial class ctrl_HorizontalTenFoot : UserControl
    {
        public event EventHandler On_ControlMove = delegate { };
        public event EventHandler On_ControlClick = delegate { };
        private base_classes.ZoneClass zone;
        public base_classes.ZoneClass Zone
        {
            get
            {
                return zone;
            }
            set
            {
                zone = value;
            }
        }
        public base_classes.BayClass Bay { get; set; }

        public ctrl_HorizontalTenFoot()
        {
            InitializeComponent();
        }

        public void SetSize(int Size)
        {
            if(Size==1)
            {
                this.Width = 25;
            }
            else if(Size==2)
            {
                this.Width = 50;
            }
            else if (Size == 3)
            {
                this.Width = 75;
            }
            else if (Size == 4)
            {
                this.Width = 100;
            }
            else if (Size == 5)
            {
                this.Width = 125;
            }
            else
            {
                this.Width = 125;
            }
        }
        private void ctrl_HorizontalTenFoot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
               On_ControlMove(this, new EventArgs());
            }
        }

        private void ctrl_HorizontalTenFoot_Load(object sender, EventArgs e)
        {

        }

        private void ctrl_HorizontalTenFoot_Click(object sender, EventArgs e)
        {
            On_ControlClick(this, new EventArgs());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void ChangeColour()
        {
            this.BackColor = Color.DeepSkyBlue;
        }
        public void DisplayItemDetails()
        {
            On_ControlClick(this, new EventArgs());
            ChangeColour();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
