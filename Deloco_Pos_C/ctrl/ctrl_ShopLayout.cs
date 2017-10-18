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
        public void DisplayShopLayout_ByBay(int ShopID)
        {
            //get all the rows whos parent is this shopid
            DataRow[] Results;
            string expres = "LocParent=" + ShopID.ToString();
            Results = GridDS.Location_Grid.Select(expres);
            textBox1.Text = "0";
            GridDS.storelayout.Clear();
            GridDS.Merge(logic_global.Get_Location_Zone_Layout(ShopID));

            if (GridDS.storelayout.Rows.Count == 0)
            {
                //there is no layout file dont bother carrying on!
            }
            else
            {
                string ZoneName = "";
                int ZoneID = 0;
                int ZonePos_X = 0;
                int ZonePos_Y = 0;
                int ControlType = 0;
                int layoutid = 0;
                int buildingid = 0;

                //loop the contents of the Layout dataset
                foreach (DataRow Item in Results)
                {
                    ZoneID = int.Parse(Item["LocGridID"].ToString());
                    ZoneName = Item["LocName"].ToString();
                    //PUT A CHILD LOOP IN TO BAY
                    DataRow[] BayResults;
                    //string exp = "LocGrid_ID=" & ;
                    BayResults = GridDS.storelayout.Select("");
                    foreach (DataRow Bay in BayResults)
                    {

                    }
                    if (CheckifControlIsAlreadyOnForm(ZoneName) == false)
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
                            layoutid = int.Parse(ZoneItem["id"].ToString());
                            buildingid = int.Parse(ZoneItem["buildingid"].ToString());
                            if (ControlType == 1)
                            {
                                //Horizontal 10
                                ctrl_HorizontalTenFoot N1 = new ctrl_HorizontalTenFoot();
                                N1.Left = ZonePos_X;
                                N1.Top = ZonePos_Y;
                                N1.Zone = new base_classes.ZoneClass();
                                N1.Zone.ZoneName = ZoneName;
                                N1.Name = ZoneName;
                                N1.Zone.id = layoutid;
                                N1.Zone.BuildingID = buildingid;
                                N1.Zone.X_Position = ZonePos_X;
                                N1.Zone.Y_Position = ZonePos_Y;
                                N1.Zone.ControlType = ControlType;
                                N1.Zone.ZoneID = ZoneID.ToString();
                                N1.On_ControlMove += N1_On_ControlMove;
                                N1.On_ControlClick += N1_On_ControlClick;

                                shop_floor.Controls.Add(N1);
                            }
                            else if (ControlType == 2)
                            {
                                //Vertical 10
                                ctrl_VerticalTenFoot N1 = new ctrl_VerticalTenFoot();
                                N1.Left = ZonePos_X;
                                N1.Top = ZonePos_Y;
                                N1.Zone = new base_classes.ZoneClass();
                                N1.Zone.ZoneName = ZoneName;
                                N1.Name = ZoneName;
                                N1.Zone.id = layoutid;
                                N1.Zone.BuildingID = buildingid;
                                N1.Zone.X_Position = ZonePos_X;
                                N1.Zone.Y_Position = ZonePos_Y;
                                N1.Zone.ControlType = ControlType;
                                N1.Zone.ZoneID = ZoneID.ToString();
                                N1.On_ControlMove += N1_On_ControlMove;
                                N1.On_ControlClick += N1_On_ControlClick;
                                shop_floor.Controls.Add(N1);
                            }
                            if (textBox1.Text == "")
                            {
                                textBox1.Text = "0";
                            }
                            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
                        }
                    }

                }


            }
            txtlblControlCount.Text = shop_floor.Controls.Count.ToString();

        }
        public void DisplayShopLayout(int ShopID)
        {
            //get all the rows whos parent is this shopid
            DataRow[] Results;
            string expres = "LocParent=" + ShopID.ToString();
            Results = GridDS.Location_Grid.Select(expres);
            textBox1.Text = "0";
            GridDS.storelayout.Clear();
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
                int layoutid = 0;
                int buildingid = 0;

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
                        layoutid = int.Parse(ZoneItem["id"].ToString());
                        buildingid = int.Parse(ZoneItem["buildingid"].ToString());
                            if (ControlType==1)
                        {
                            //Horizontal 10
                            ctrl_HorizontalTenFoot N1 = new ctrl_HorizontalTenFoot();
                            N1.Left = ZonePos_X;
                            N1.Top = ZonePos_Y;
                            N1.Zone = new base_classes.ZoneClass();
                            N1.Zone.ZoneName = ZoneName;
                            N1.Name = ZoneName;
                            N1.Zone.id = layoutid;
                            N1.Zone.BuildingID = buildingid;
                            N1.Zone.X_Position = ZonePos_X;
                            N1.Zone.Y_Position = ZonePos_Y;
                            N1.Zone.ControlType = ControlType;
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
                            N1.Zone.id = layoutid;
                            N1.Zone.BuildingID = buildingid;
                            N1.Zone.X_Position = ZonePos_X;
                            N1.Zone.Y_Position = ZonePos_Y;
                            N1.Zone.ControlType = ControlType;
                            N1.Zone.ZoneID = ZoneID.ToString();
                            N1.On_ControlMove += N1_On_ControlMove;
                            N1.On_ControlClick += N1_On_ControlClick;
                            shop_floor.Controls.Add(N1);
                        }
                            if(textBox1.Text=="")
                            {
                                textBox1.Text = "0";
                            }
                            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
                    }
                    }
                    
                }


            }
            txtlblControlCount.Text = shop_floor.Controls.Count.ToString();

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
            foreach (Control Item in shop_floor.Controls)
            {

                if (Item.GetType() == typeof(ctrl_VerticalTenFoot))
                {
                    ctrl_VerticalTenFoot V10 = Item as ctrl_VerticalTenFoot;
                    if (V10.Zone.HasChanged==true)
                    {
                        logic_global.EditStoreLayoutRow(V10.Zone.BuildingID, int.Parse(V10.Zone.ZoneID), V10.Zone.ControlType, V10.Zone.Y_Position, V10.Zone.X_Position,0,V10.Zone.id);
                    }
                }
                else if (Item.GetType() == typeof(ctrl_HorizontalTenFoot))
                {
                    ctrl_HorizontalTenFoot H10 = Item as ctrl_HorizontalTenFoot;
                    if (H10.Zone.HasChanged == true)
                    {
                        logic_global.EditStoreLayoutRow(H10.Zone.BuildingID, int.Parse(H10.Zone.ZoneID), H10.Zone.ControlType, H10.Zone.Y_Position, H10.Zone.X_Position, 0, H10.Zone.id);
                    }
                }
            }

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
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);//in form coordinates

            Point y = shop_floor.PointToClient(p);

            if (sender.GetType() == typeof(ctrl_VerticalTenFoot))
            {
                ctrl_VerticalTenFoot V10 = sender as ctrl_VerticalTenFoot;

                txtLeft.Text = V10.Left.ToString();
                txtTop.Text = V10.Top.ToString();



            }
            else if (sender.GetType() == typeof(ctrl_HorizontalTenFoot))
            {
                ctrl_HorizontalTenFoot H10 = sender as ctrl_HorizontalTenFoot;
                txtLeft.Text = H10.Left.ToString();
                txtTop.Text = H10.Top.ToString();
            }
        }

        private void N1_On_ControlMove(object sender, EventArgs e)
        {
            cou = cou + 1;
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);//in form coordinates

            Point y = shop_floor.PointToClient(p);

            if(sender.GetType() == typeof(ctrl_VerticalTenFoot))
            {
                ctrl_VerticalTenFoot V10 = sender as ctrl_VerticalTenFoot;
                V10.Left = y.X;
                V10.Top = y.Y;

                V10.Zone.HasChanged = true;
                V10.Refresh();
                txtLeft.Text = V10.Left.ToString();
                txtTop.Text = V10.Top.ToString();
                txtZone.Text = V10.Zone.ZoneName.ToString();
                this.Refresh();
                V10.Zone.X_Position = V10.Left;
                V10.Zone.Y_Position = V10.Top;
            }
            else if (sender.GetType() == typeof(ctrl_HorizontalTenFoot))
            {
                ctrl_HorizontalTenFoot H10 = sender as ctrl_HorizontalTenFoot;
                H10.Left = y.X;
                H10.Top = y.Y;
                H10.Zone.X_Position = y.X;
                H10.Zone.Y_Position = y.X;
                H10.Zone.HasChanged = true;
                H10.Refresh();
                txtLeft.Text = H10.Left.ToString();
                txtTop.Text = H10.Top.ToString();
                txtZone.Text = H10.Zone.ZoneName.ToString();
                this.Refresh();
                H10.Zone.X_Position = H10.Left;
                H10.Zone.Y_Position = H10.Top;

            }

            txtlblControlCount.Text = shop_floor.Controls.Count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic_global.Get_Location_Zone_Layout(4);
        }

        private void shop_floor_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ClearAllFurniture()
        {
            if(shop_floor.Controls.Count > 0)
            {
                 do
                            {
                                  if (shop_floor.Controls[0].GetType() == typeof(ctrl_VerticalTenFoot))
                                {
                                    ctrl_VerticalTenFoot V10 = shop_floor.Controls[0] as ctrl_VerticalTenFoot;
                                    V10.On_ControlClick -= new System.EventHandler(this.ONBayClicked);
                                    shop_floor.Controls.Remove(V10);
                                    V10.Dispose();
                                }
                                else if (shop_floor.Controls[0].GetType() == typeof(ctrl_HorizontalTenFoot))
                                {
                                    ctrl_HorizontalTenFoot H10 = shop_floor.Controls[0] as ctrl_HorizontalTenFoot;
                                    H10.On_ControlClick-= new System.EventHandler(this.ONBayClicked);
                                    shop_floor.Controls.Remove(H10);
                                    H10.Dispose();
                                }
                            } while (shop_floor.Controls.Count >0);
            }
           

            //foreach (Control Item in shop_floor.Controls)
            //{

              
            //}
            this.Refresh();
            txtlblControlCount.Text = shop_floor.Controls.Count.ToString();
        }
    }
}
