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
            LocGrid.Merge(logic_global.GetLocationGrid(1));
            GetLocations();
            
        }



        private void GetLocations()
        {
            
            LocTree.Nodes.Clear();
            LocGrid.Clear();
            LocGrid=logic_global.GetLocationGrid(0);

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


                    }

                    
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            views.frmAddLocation AddLoc =new views.frmAddLocation();
            AddLoc.MdiParent = this.MdiParent;
            AddLoc.Show();
           
        }
    }
}
