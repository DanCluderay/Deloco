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
    public partial class frmProductUseCases : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.ProductDS ProdDS;
        public frmProductUseCases()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRefreshAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProdDS = new local_datasets.ProductDS();
            ProdDS.Merge(logic_global.Get_Product_Use_Cases());
            Tree_Usecase.Nodes.Clear();
            AddToTreeView();
            

        }

        private void AddToTreeView()
        {
            DataRow[] Results;

            string query = "ParentID=0";

            Results = ProdDS.Product_Use_Case.Select(query);
            if (Results.Length>0)
            {
                foreach(DataRow Item in Results)
                {
                    TreeNode T1 = new TreeNode();
                    int id = int.Parse(Item["id"].ToString());
                    T1.Name = id.ToString();
                    T1.Text=Item["Statement"].ToString();
                    T1.Tag= Item["TAG"].ToString();
                    Tree_Usecase.Nodes.Add(T1);
                    Tree_Usecase.SelectedNode = T1;
                    recervise_add_to_tree(id);
                }

            }
        }

        private void recervise_add_to_tree(int id)
        {
            DataRow[] Results;
            TreeNode PreviousNode = Tree_Usecase.SelectedNode;
            string query = "ParentID=" + id;

            Results = ProdDS.Product_Use_Case.Select(query);
            if (Results.Length > 0)
            {
                foreach (DataRow Item in Results)
                {
                    TreeNode T1 = new TreeNode();
                    int _id = int.Parse(Item["id"].ToString());
                    T1.Name = _id.ToString();
                    T1.Text = Item["Statement"].ToString();
                    T1.Tag = Item["TAG"].ToString();
                    Tree_Usecase.SelectedNode.Nodes.Add(T1);
                    Tree_Usecase.SelectedNode = T1;
                    recervise_add_to_tree(_id);
                    Tree_Usecase.SelectedNode = PreviousNode;
                }

            }
            else
            {
                Tree_Usecase.SelectedNode = PreviousNode;
            }

        }

        private void Tree_Usecase_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int NodeIDSelected;
            TreeNode CurrentNode = Tree_Usecase.SelectedNode;
            NodeIDSelected = int.Parse(CurrentNode.Name.ToString());
            string UseTAGS = "";
            UseTAGS = mineTAGS(NodeIDSelected);
            textBox1.Text = UseTAGS.ToString();
        }
        private string mineTAGS(int TAG)
        {
            string retvalue="";
            DataRow[] Results;
            string query = "id=" + TAG.ToString();
            Results = ProdDS.Product_Use_Case.Select(query);

            foreach(DataRow Item in Results)
            {
                int tagid = int.Parse(Item["Parentid"].ToString());
                if(tagid>0)
                {
                    if(retvalue == "")
                    {
                        retvalue = Item["TAG"].ToString();
                    }
                    else
                    {
                        //retvalue = retvalue + " , " + Item["TAG"].ToString();
                    }
                    //now look up one level
                    retvalue = retvalue + " , " + mineTAGS(tagid);
                }
                else
                {
                    retvalue =  Item["TAG"].ToString();
                }
                


            }

            return retvalue;
        }
    }
}
