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
        public frmLocation_Grid()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            LocGrid = new local_datasets.LocationGrid();
            logic_global.On_LocationChanged += Logic_global_On_LocationChanged;
        }

        private void Logic_global_On_LocationChanged(object sender, EventArgs e)
        {
            //get the updated locations
            LocGrid.Clear();
            GetLocations();
        }

        private void frmLocation_Grid_Load(object sender, EventArgs e)
        {
            loadingmode = true;
            LocGrid.Merge(logic_global.GetLocationGrid(1));
            HideTabs();
            GetLocations();
            loadingmode = false;
        }



        private void GetLocations()
        {
            
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
            LocTree.CollapseAll();
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
        private void DisplayDetails()
        {
            if (loadingmode==false)
            {
                int NodeID = 0;
                NodeID=int.Parse( LocTree.SelectedNode.Tag.ToString());
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
                       
                        ctrl_ShopLayout1.DisplayShopLayout(NodeID);
                    }
                    else if (LocationType == 3)
                    {
                        //tabControl1.TabPages.Add(tabZone);
                        //get the zone ID

                        //Find the Zon
                    }
                    else if (LocationType == 4)
                    {
                        //tabControl1.TabPages.Add(tabBay);
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

        private void CreateSibling()
        {
            int _LocType = get_LocType_type(false);
            views.frmAddLocation AddLoc =new views.frmAddLocation(_LocType.ToString(), get_parent_to_be_ID(true),LocGrid, get_next_pick_orderID(true));
            AddLoc.MdiParent = this.MdiParent;
            AddLoc.Show();
        }
        private void CreateChild()
        {
            views.frmAddLocation AddLoc = new views.frmAddLocation(get_LocType_type(true).ToString(), get_parent_to_be_ID(false), LocGrid, get_next_pick_orderID(false));
            AddLoc.MdiParent = this.MdiParent;
            AddLoc.Show();
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
    }
}
