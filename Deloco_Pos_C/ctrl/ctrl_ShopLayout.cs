using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deloco_Pos_C.controls.Furniture;
using System.Diagnostics;


namespace Deloco_Pos_C.controls
{
    public partial class ctrl_ShopLayout : UserControl
    {
        public event EventHandler ONBayClicked = delegate { };
        int cou;
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.LocationGrid GridDS;
        public ctrl_ShopLayout()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        public void SetupDS(local_datasets.LocationGrid DS)
        {
            GridDS = new local_datasets.LocationGrid();
            GridDS.Merge(DS);
        }

        public void DisplayShopLayout(int ShopID)
        {
            //get all the rows whos parent is this shopid
            DataRow[] Results;
            string expres = "LocParent=" + ShopID.ToString();
            Results = GridDS.Location_Grid.Select(expres);


            GridDS.Merge(logic_global.Get_Location_Zone_Layout(ShopID));

            if (GridDS.storelayout.Rows.Count==0)
            {
                //there is no layout file dont bother carrying on!
            }
            else
            {
                string ZoneName="";
                int ZoneID = 0;
                int ZonePos_X = 0;
                int ZonePos_Y = 0;
                int ControlType = 0;
                //loop the contents of the Layout dataset
                foreach(DataRow Item in Results)
                {
                    ZoneID = int.Parse(Item["LocGridID"].ToString());
                    ZoneName = Item["LocName"].ToString();
                    if (CheckifControlIsAlreadyOnForm(ZoneName) ==false)
                    {
                    //find the data in the layout dataset
                    DataRow[] LayoutRows;
                    string layoutquery = "LocGrid_ID=" + ZoneID.ToString();
                    //Get a list of all the layout ZOnes
                    LayoutRows = GridDS.storelayout.Select(layoutquery);
                    //itereate over them
                    foreach (DataRow ZoneItem in LayoutRows)
                    {
                        //get the X,Y and Z
                        ZonePos_X = int.Parse(ZoneItem["Control_X"].ToString());
                        ZonePos_Y = int.Parse(ZoneItem["Control_Y"].ToString());
                        ControlType = int.Parse(ZoneItem["Control_Type"].ToString());
                        if (ControlType==1)
                        {
                            //Horizontal 10
                            ctrl_HorizontalTenFoot N1 = new ctrl_HorizontalTenFoot();
                            N1.Left = ZonePos_X;
                            N1.Top = ZonePos_Y;
                            N1.Zone = new base_classes.ZoneClass();
                            N1.Zone.ZoneName = ZoneName;
                            N1.Name = ZoneName;
                            N1.Zone.ZoneID = ZoneID.ToString();
                            N1.On_ControlMove += N1_On_ControlMove;
                            N1.On_ControlClick += N1_On_ControlClick;
                            
                            shop_floor.Controls.Add(N1);
                        }
                        else if (ControlType==2)
                        {
                            //Vertical 10
                            ctrl_VerticalTenFoot N1 = new ctrl_VerticalTenFoot();
                            N1.Left = ZonePos_X;
                            N1.Top = ZonePos_Y;
                            N1.Zone = new base_classes.ZoneClass();
                            N1.Zone.ZoneName = ZoneName;
                            N1.Name = ZoneName;
                            N1.Zone.ZoneID = ZoneID.ToString();
                            N1.On_ControlMove += N1_On_ControlMove;
                            N1.On_ControlClick += N1_On_ControlClick;
                            shop_floor.Controls.Add(N1);
                        }
                    }
                    }
                    
                }


            }


        }

        private bool CheckifControlIsAlreadyOnForm(string ZoneID)
        {
            //foreach(Control I in this.Controls)
            //{
            //    Debug.WriteLine(I.Name);
            //  //Console.Out(  I.Name);
            //}
            bool ret = false;
            if (shop_floor.Controls.ContainsKey(ZoneID))
            {
                ret = true;
            }


            return ret;
        }
        
        public void CheckChildrenNodes()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ctrl_HorizontalTenFoot Newfridge = new ctrl_HorizontalTenFoot();
            
            Newfridge.Left = 200;
            Newfridge.Top = 200;
            Newfridge.On_ControlMove += Newfridge_On_ControlMove;
            shop_floor.Controls.Add(Newfridge);
            
        }

        private void Newfridge_On_ControlMove(object sender, EventArgs e)
        {
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);//in form coordinates
         
            Point y = shop_floor.PointToClient(p);
            ctrl_HorizontalTenFoot k = sender as ctrl_HorizontalTenFoot;

            k.Left = y.X;
            k.Top = y.Y;
            k.Refresh();
            txtLeft.Text = k.Left.ToString();
            txtTop.Text = k.Top.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loop all the controls in the shopfloor panel

            //update the database with each control X and Y
            
        }

        private void ctrl_VerticalTenFoot3_Load(object sender, EventArgs e)
        {

        }

      
       
        private void button4_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 10; i++)
            {
                ctrl_VerticalTenFoot N1 = new ctrl_VerticalTenFoot();
                N1.Left = 100 + (i*10);
                N1.Top = 100 + (i * 10);
                N1.Zone = new base_classes.ZoneClass();
                N1.Zone.ZoneName = "Zone " + i.ToString();
                N1.On_ControlMove += N1_On_ControlMove;
                N1.On_ControlClick += N1_On_ControlClick;
                shop_floor.Controls.Add(N1);
            }
        }

        private void N1_On_ControlClick(object sender, EventArgs e)
        {
            //Point p = new Point(Cursor.Position.X, Cursor.Position.Y);//in form coordinates

            //Point y = shop_floor.PointToClient(p);
            
            
            //txtLeft.Text = y.X.ToString();
            //txtTop.Text = y.Y.ToString();
        }

        private void N1_On_ControlMove(object sender, EventArgs e)
        {
            cou = cou + 1;
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);//in form coordinates

            Point y = shop_floor.PointToClient(p);

            if(sender.GetType() == typeof(ctrl_VerticalTenFoot))
            {
                ctrl_VerticalTenFoot k = sender as ctrl_VerticalTenFoot;
                k.Left = y.X;
                k.Top = y.Y;
                k.Refresh();
                txtLeft.Text = k.Left.ToString();
                txtTop.Text = k.Top.ToString();
                txtZone.Text = k.Zone.ZoneName.ToString();
                this.Refresh();
            }
            else if (sender.GetType() == typeof(ctrl_HorizontalTenFoot))
            {
                ctrl_HorizontalTenFoot H = sender as ctrl_HorizontalTenFoot;
                H.Left = y.X;
                H.Top = y.Y;
                H.Refresh();
                txtLeft.Text = H.Left.ToString();
                txtTop.Text = H.Top.ToString();
                txtZone.Text = H.Zone.ZoneName.ToString();
                this.Refresh();
            }


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic_global.Get_Location_Zone_Layout(4);
        }
    }
}
