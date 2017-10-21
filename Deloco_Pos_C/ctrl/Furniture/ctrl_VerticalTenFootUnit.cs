using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deloco_Pos_C.base_classes;

namespace Deloco_Pos_C.controls.Furniture
{
   
    public partial class ctrl_VerticalTenFoot : UserControl
 
        
    {
        public event EventHandler On_ControlMove = delegate { };
        public event EventHandler On_ControlClick = delegate { };
        private base_classes.ZoneClass zone;
        public base_classes.BayClass Bay { get; set; }

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
        


        public ctrl_VerticalTenFoot()
        {
            InitializeComponent();
            Zone = new ZoneClass();
            Zone.On_ZoneHighLighted += Zone_On_ZoneHighLighted;
            Bay = new BayClass();
            Bay.On_Bay_Clicked += Bay_On_Bay_Clicked;
        }

        private void Bay_On_Bay_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Zone_On_ZoneHighLighted(object sender, EventArgs e)
        {
            ChangeColour();
        }
        private void ChangeColour()
        {
            this.BackColor = Color.DeepSkyBlue;
        }
        private void ctrl_VerticalTenFoot_Load(object sender, EventArgs e)
        {
            //base_classes.ZoneClass Zone = new base_classes.ZoneClass();

        }

        private void ctrl_VerticalTenFoot_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void ctrl_VerticalTenFoot_Click(object sender, EventArgs e)
        {
            On_ControlClick(this, new EventArgs());
            ChangeColour();
        }

        private void ctrl_VerticalTenFoot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                On_ControlMove(this, new EventArgs());
            }
        }
        public void DisplayItemDetails()
        {
            On_ControlClick(this, new EventArgs());
            ChangeColour();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void SetSize(int Size)
        {
            if (Size == 1)
            {
                this.Height = 25;
            }
            else if (Size == 2)
            {
                this.Height = 50;
            }
            else if (Size == 3)
            {
                this.Height = 75;
            }
            else if (Size == 4)
            {
                this.Height = 100;
            }
            else if (Size == 5)
            {
                this.Height = 125;
            }
            else
            {
                this.Height = 125;
            }
        }
    }
}
