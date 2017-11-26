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
    public partial class frmLocation_Grid : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.LocationGrid LocGrid;
        bool loadingmode;
        int SelectedShopID;
        views.frmAddLocation AddLoc;
        TreeNode CurerntSelectedTreeNode;
        bool setuptreemode;
        public frmLocation_Grid()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            LocGrid = new local_datasets.LocationGrid();
            logic_global.On_LocationChanged += Logic_global_On_LocationChanged;
            ctrl_ShopLayout1.On_AddChild += Ctrl_ShopLayout1_On_AddChild;
            ctrl_ShopLayout1.On_AddSibling += Ctrl_ShopLayout1_On_AddSibling;
            ctrl_ShopLayout1.Request_Screen_Refresh += Ctrl_ShopLayout1_Request_Screen_Refresh;
            ctrl_ShopLayout1.HighlightColour = Color.DeepSkyBlue;
        }

        private void Ctrl_ShopLayout1_Request_Screen_Refresh(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void Ctrl_ShopLayout1_On_AddSibling(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void Ctrl_ShopLayout1_On_AddChild(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void Logic_global_On_LocationChanged(object sender, EventArgs e)
        {
            //get the updated locations
            LocGrid.Clear();
            GetLocations();
        }

        private void frmLocation_Grid_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            loadingmode = true;
            LocGrid.Merge(logic_global.GetLocationGrid(1));
            HideTabs();
            GetLocations();
            loadingmode = false;
        }



        private void GetLocations()
        {
            setuptreemode = true;
            LocTree.Nodes.Clear();
            LocGrid.Clear();
            LocGrid=logic_global.GetLocationGrid(0);
            ctrl_ShopLayout1.SetupDS(LocGrid);

            foreach (local_datasets.LocationGrid.Location_GridRow Item in LocGrid.Location_Grid.Rows)
            {

                if (Item.LocParent == 0)
                {
                    string name = Item["LocName"].ToString();
                    TreeNode tree = new TreeNode(name);
                    tree.Tag = Item["LocGridID"].ToString();
                    tree.Name = tree.Tag.ToString();
                    LocTree.Nodes.Add(tree);
                    LocTree.SelectedNode = tree;
                    addchildrentoTree(LocTree, Item.LocGridID.ToString());
                }
            }
            //LocTree.CollapseAll();
            setuptreemode = false;
        }

        private void LocTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayDetails();
        }
        private void HideTabs()
        {
            //tabControl1.TabPages.Remove( tabBuilding);
            tabControl1.TabPages.Remove(tabBusiness);
            tabControl1.TabPages.Remove(tabZone);
            tabControl1.TabPages.Remove(tabLocations);
            tabControl1.TabPages.Remove(tabBay);

            tabControl1.TabPages.Remove(tabShelf);
            tabControl1.TabPages.Remove(tabPick);
            tabControl1.TabPages.Remove(tabHole);

        }

        private void SetUpShop(int ShopID)
        {
            ctrl_ShopLayout1.ClearAllFurniture();
            if (setuptreemode != true)
            {
                SelectedShopID = ShopID;
            }

            ctrl_ShopLayout1.DisplayShopLayout_ByBay(ShopID);
        }
        private void DisplayDetails()
        {
            if (loadingmode==false)
            {
                int NodeID = 0;
                NodeID=int.Parse( LocTree.SelectedNode.Tag.ToString());
                int sh = FindBuildingIDofSelectedNode();

                ctrl_ShopLayout1.ShowShopName(sh);
                if (ctrl_ShopLayout1.DISPLAYED_SHOPID != sh)
                {
                    SetUpShop(sh);
                }
                //CurerntSelectedTreeNode = LocTree.SelectedNode;
                DataRow[] gridrows;
                string expression = "LocGridID = " + NodeID.ToString();
                // Use the Select method to find all rows matching the filter.
                gridrows = LocGrid.Location_Grid.Select(expression);
                if(gridrows.Length==0)
                {
                    MessageBox.Show("No rows found with the ID of  " + NodeID.ToString());

                }
                else if(gridrows.Length>1)
                {
                    MessageBox.Show("More than one ID found for " + NodeID.ToString());
                }
                else
                {
                    int LocationType = 0;
                    LocationType = int.Parse(gridrows[0]["LocType"].ToString());
                    HideTabs();

                    if (LocationType==1)
                    {
                        tabControl1.TabPages.Add(tabBusiness); 
                    }
                    else if (LocationType == 2)
                    {
                        //tabControl1.TabPages.Add(tabBuilding);
                        //Draw the layout of the shop
                        //get the ShopID
                        SetUpShop(sh);
                        
                    }
                    else if (LocationType == 3)
                    {
                        //tabControl1.TabPages.Add(tabZone);
                        //get the zone ID
                        ctrl_ShopLayout1.HighLighZone(NodeID);
                        
                    }
                    else if (LocationType == 4)
                    {
                        //tabControl1.TabPages.Add(tabBay);
                        ctrl_ShopLayout1.HighlightBay(NodeID);
                        ctrl_ShopLayout1.Display_Shelf(NodeID);
                    }
                    else if (LocationType == 5)
                    {
                        //tabControl1.TabPages.Add(tabShelf);
                    }
                    else if (LocationType == 6)
                    {
                        //tabControl1.TabPages.Add(tabPick);
                    }
                    else if (LocationType == 7)
                    {
                        //tabControl1.TabPages.Add(tabHole);
                    }
                }
            }
           
        }

        private void LocTree_MouseClick(object sender, MouseEventArgs e)
        {
            //TreeNode SelectedNode = LocTree.SelectedNode;
            //string childkey= LocTree.SelectedNode.Tag.ToString();
            //addchildrentoTree(LocTree, childkey);


        }


        private void addchildrentoTree(TreeView Tree,string ChildKey)
        {
            DataRow[] foundRows;
            string expression;
            expression = "LocParent = " + ChildKey;
            // Use the Select method to find all rows matching the filter.
            foundRows = LocGrid.Location_Grid.Select(expression);
            TreeNode PreviousTreeNode = new TreeNode();
            PreviousTreeNode = Tree.SelectedNode;
            if(foundRows.Length==0)
            {
                //do nothing

            }
            else
            {
                foreach (DataRow Item in foundRows)
                {
                    
                    string name = Item["LocName"].ToString();
                    TreeNode treeNode = new TreeNode( name);
                    treeNode.Tag = Item["LocGridID"].ToString();
                    treeNode.Name = treeNode.Tag.ToString();
                    if (Tree.Nodes.ContainsKey(treeNode.Tag.ToString()))
                    {

                    }
                    else
                    {
                        if (Tree.SelectedNode == null)
                        {
                            Tree.Nodes.Add(treeNode);
                        }
                        else
                        {
                            Tree.SelectedNode.Nodes.Add(treeNode);
                           
                        }

                        Tree.SelectedNode = treeNode;
                        addchildrentoTree(Tree, treeNode.Tag.ToString());
                        Tree.SelectedNode= PreviousTreeNode;

                    }

                    
                }
            }
            
        }

        private int get_parent_to_be_ID(bool createting_Sibling)
        {
            int ret=0;//ret will become the parent of the child created
            bool res = int.TryParse(LocTree.SelectedNode.Tag.ToString(), out ret);

            if (createting_Sibling == true)
            {
                //look at the selected rows parent
                DataRow[] results;
                string exprestion = "LocGridID=" + ret;
                results = LocGrid.Location_Grid.Select(exprestion);
                if (results.Length==1)
                {
                    ret = int.Parse(results[0]["LocParent"].ToString());
                }
                else
                {
                    MessageBox.Show("Could not find product in get_parent_to_be_ID");
                }
            }
            else
            {
                if(res!=true)
                {
                    ret = 0;
                }
            }

                
            return ret;
        }
        
        
        private int get_next_pick_orderID(bool IsSibling)
        {
            int ret = 0;
            bool res = int.TryParse(LocTree.SelectedNode.Tag.ToString(), out ret);
            if (res != true)
            {
                ret = 0;
            }
            else
            {
                DataRow[] Results;


                if(IsSibling==true)
                {
                    //look up the parent then count how many children it has and add 1
                    string expression1 = "LocGridID = " + ret.ToString();
                    Results = LocGrid.Location_Grid.Select(expression1);
                    if (Results.Length == 1)
                    {
                        int _parentID= int.Parse(Results[0]["LocParent"].ToString());
                        expression1 = "LocParent = " + _parentID.ToString();
                        Results=LocGrid.Location_Grid.Select(expression1);
                        ret = Results.Length + 1;
                    }
                }
                else
                {
                    //if its creating a child node then lookup this node and count children +1
                    string expression2 = "LocParent = " + ret.ToString();
                    Results = LocGrid.Location_Grid.Select(expression2);
                    ret = Results.Length + 1;
                }


                
            }
            return ret;
        }

        private int get_LocType_type(bool NextIsChild)
        {
            int ret = 0;
            bool res = int.TryParse(LocTree.SelectedNode.Tag.ToString(), out ret);
            if (res != true)
            {
                ret = 0;
            }
            else
            {
                DataRow[] Results;
                string expression = "LocGridID = " + ret.ToString();
                Results = LocGrid.Location_Grid.Select(expression);
                if(Results.Length==1)
                {
                    ret = int.Parse(Results[0]["LocType"].ToString());
                    if (NextIsChild==true)
                    {
                        ret = ret + 1;// returns the next child
                    }
                    else
                    {
                        // returns the currenttype if you a creating a sbling
                        ret = int.Parse(Results[0]["LocType"].ToString());
                        if (ret==0)
                        {
                            ret = 1;
                        }
                    }
                    
                }
            }
            return ret;
        }

        private int FindBuildingIDofSelectedNode()
        {
            int ret=0;
            int currentid = 0;
            currentid =int.Parse( LocTree.SelectedNode.Tag.ToString());

            DataRow[] res;
            string express = "LocGridID=" + currentid.ToString();
            res = LocGrid.Location_Grid.Select(express);

            if(res.Length>0)
            {
                int _type = 0;
                foreach (DataRow Item in res)
                {
                    _type = int.Parse(Item["LocType"].ToString());
                    if (_type>2) //we are deep in th enode
                    {
                        ret = recursiveFindParent(int.Parse(Item["LocParent"].ToString()));
                    }
                    else if(_type==2)
                    {
                        ret= int.Parse(Item["LocGridID"].ToString());
                    }
                }

            }

            return ret;
        }
        private int recursiveFindParent(int currentLocationID)
        {
            int ret=0;
            DataRow[] res;
            string express = "LocGridID=" + currentLocationID.ToString();
            res = LocGrid.Location_Grid.Select(express);

            if (res.Length > 0)
            {
                int _type = 0;
                foreach (DataRow Item in res)
                {
                    _type = int.Parse(Item["LocType"].ToString());
                    if (_type > 2) //we are deep in th enode
                    {
                        ret = recursiveFindParent(int.Parse(Item["LocParent"].ToString()));
                    }
                    else if (_type == 2)
                    {
                        ret = int.Parse(Item["LocGridID"].ToString());
                    }
                }

            }
            return ret;
        }
        private void CreateSibling()
        {
            CurerntSelectedTreeNode = LocTree.SelectedNode;
            int _LocType = get_LocType_type(false);
            int sh = FindBuildingIDofSelectedNode();
            SelectedShopID = sh;
            views.frmAddLocation AddLoc =new views.frmAddLocation(sh,_LocType.ToString(), get_parent_to_be_ID(true),LocGrid, get_next_pick_orderID(true));
            AddLoc.MdiParent = this.MdiParent;
            AddLoc.Show();
        }
        private void CreateChild()
        {
            CurerntSelectedTreeNode = LocTree.SelectedNode;
            int sh = FindBuildingIDofSelectedNode();
            SelectedShopID = sh;
            AddLoc = new views.frmAddLocation(sh,get_LocType_type(true).ToString(), get_parent_to_be_ID(false), LocGrid, get_next_pick_orderID(false));
            AddLoc.MdiParent = this.MdiParent;
            AddLoc.On_NewLayOutAdded += AddLoc_On_NewLayOutAdded;
            AddLoc.Show();
        }
        
        private void AddLoc_On_NewLayOutAdded(object sender, EventArgs e)
        {
            LocTree.SelectedNode = CurerntSelectedTreeNode;
            tabBuilding_Layout.Show();
            ctrl_ShopLayout1.DisplayShopLayout_ByBay(SelectedShopID);
            LocTree.SelectedNode = CurerntSelectedTreeNode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSibling();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grp_Business.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            GetLocations();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CreateSibling();
        }

        private void ctrl_ShopLayout1_Load(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            ctrl_ShopLayout1.ClearAllFurniture();
        }
    }
}
