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
    public partial class frmAddProductInstance : Form
    {
        public event EventHandler On_NewProductAdded = delegate { };
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.ProductDS ProdDS;
        int _productID;
        double _itemprice;
        int selecetedItemCaseqty;
        public frmAddProductInstance()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            
        }
        public frmAddProductInstance(int ProductID)
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            ProdDS = new local_datasets.ProductDS();
            ProdDS.Merge(logic_global.Get_Product_Case_Configeration(ProductID));
            productDS.ProductCaseConfig.Clear();
            productDS.Merge(ProdDS);
            _productID = ProductID;
        }
        private void frmAddProductInstance_Load(object sender, EventArgs e)
        {
            HideAllTabs();

        }
        private void HideAllTabs()
        {
            tabCase.Controls.Remove(tabAddCase);
            tabCase.Controls.Remove(tabEdit);
        }

        private void linkAddNewCaseConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabCase.Controls.Remove(tabAddCase);
            tabCase.Controls.Remove(tabEdit);
            tabCase.Controls.Add(tabAddCase);
        }

        private void linkEditCaseConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabCase.Controls.Remove(tabAddCase);
            tabCase.Controls.Remove(tabEdit);
            tabCase.Controls.Add(tabEdit);
            //display details
            int caseID = 0;
            caseID = Convert.ToInt32(cmbCaseConfig.SelectedValue);
            if (caseID == 0) { return; }
            local_datasets.ProductDS.ProductCaseConfigRow res;
            res = productDS.ProductCaseConfig.FindByCaseConfigID(caseID);
            txtEditCaseID.Text = res.CaseConfigID.ToString();
            txtEditCaseName.Text = res.CaseDescription.ToString();
            txtEditCaseQTY.Text = res.CaseQty.ToString();
            txtEditCaseBC.Text = res.CaseBarcode.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewCaseConfig();
        }
        private void AddNewCaseConfig()
        {
            string CaseConfigName = "";
            int CaseConfigQTY = 0;
            string CaseBC = "";
            CaseConfigName = txtNewCaseName.Text.Trim().ToString();
            CaseConfigQTY = int.Parse(txtNewCaseQTY.Text.ToString());
            CaseBC = txtNewCaseBC.Text.Trim().ToString();
            if (CaseConfigName == "")
            {
                return;
            }
            if (CaseConfigQTY == 0)
            {
                return;
            }
            if (CaseBC=="")
            {
                return;
            }
            int newCaseConfigID = logic_global.Add_New_Case_Config(CaseConfigName, CaseConfigQTY, CaseBC, _productID);
            if(newCaseConfigID!=0)
            {
                //we have a new product - add it to the local dataset and select it
                local_datasets.ProductDS.ProductCaseConfigRow NewRow = productDS.ProductCaseConfig.NewProductCaseConfigRow();
                NewRow.CaseConfigID = newCaseConfigID;
                NewRow.CaseDescription = CaseConfigName;
                NewRow.CaseQty = CaseConfigQTY;
                NewRow.CaseBarcode = CaseBC;
                NewRow.Deleted = 0;
                productDS.ProductCaseConfig.AddProductCaseConfigRow(NewRow);
                cmbCaseConfig.SelectedValue = newCaseConfigID;
                txtNewCaseName.Text = "";
                txtNewCaseBC.Text = "";
                txtNewCaseQTY.Text = "0";
                HideAllTabs();
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            string CaseConfigName = "";
            int CaseConfigQTY = 0;
            string CaseBC = "";
            int CaseID = 0;
            int Del = 0;
            CaseConfigName = txtEditCaseName.Text.Trim().ToString();
            CaseConfigQTY = int.Parse(txtEditCaseQTY.Text.ToString());
            CaseBC = txtEditCaseBC.Text.Trim().ToString();
            CaseID= int.Parse(txtEditCaseID.Text.ToString());
            Del = Convert.ToInt32(chkDelete.Checked);
            if (CaseConfigName == "")
            {
                return;
            }
            if (CaseConfigQTY == 0)
            {
                return;
            }
            if (CaseBC == "")
            {
                return;
            }
            int editCaseConfigID = logic_global.Edit_Case_Config(CaseConfigName, CaseConfigQTY, CaseBC, _productID, CaseID,Del);
            if (editCaseConfigID == 1)
            {
                local_datasets.ProductDS.ProductCaseConfigRow row;
                row = productDS.ProductCaseConfig.FindByCaseConfigID(editCaseConfigID);
                row.CaseDescription = CaseConfigName;
                row.CaseQty = CaseConfigQTY;
                row.CaseBarcode = CaseBC;
                txtEditCaseName.Text = "";
                txtEditCaseQTY.Text="";
                txtEditCaseBC.Text="";
                txtEditCaseID.Text="";
                HideAllTabs();
            }
        }

        private void cmbCaseConfig_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtEditCaseName.Text = "";
            txtEditCaseQTY.Text = "";
            txtEditCaseBC.Text = "";
            txtEditCaseID.Text = "";
            txtNewCaseName.Text = "";
            txtNewCaseBC.Text = "";
            txtNewCaseQTY.Text = "0";
            HideAllTabs();

            CalculateItemPrice();
        }
        private void CalculateItemPrice()
        {
            double itemprice = 0.0;
            double caseprice=0.0;
            int totalcaseqty = 0;
            int caseqty = 0;
            local_datasets.ProductDS.ProductCaseConfigRow row;
            row = productDS.ProductCaseConfig.FindByCaseConfigID(Convert.ToInt32( cmbCaseConfig.SelectedValue));
            if(row!=null)
            {
                caseqty = row.CaseQty;
            }
            else
            {
                return;
            }
            
            selecetedItemCaseqty = caseqty;
            double.TryParse(txtCasePrice.Text, out caseprice);
            bool res=int.TryParse(txtCaseCount.Text, out totalcaseqty);
            if (res==false)
            {
                totalcaseqty = 0;
            }
            else
            {
                txtTotalItems.Text = (totalcaseqty * caseqty).ToString();
            }
            if(caseprice!=0 && caseqty!=0)
            {
                itemprice = caseprice / caseqty;
            }
            else
            {
                itemprice = 0;
            }
            _itemprice = itemprice;
            txtItemCostPrice.Text = String.Format("{0:C}", itemprice);
            txtTotalItems.Text = (caseqty * totalcaseqty).ToString();
        }

        private void txtCasePrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCasePrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateItemPrice();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            CheckTableFormat(e.ColumnIndex);
        }

        private void CheckTableFormat(int col)
        {
            bool TableCorrect = true;
            int totalAssignedQTY = 0;
            foreach(DataGridViewRow dgr in DG_Data.Rows)
            {
                int _qty = 0;
                double _qtycase = 0;
            
                bool res=false;
                bool res2=false;
                if(dgr.Cells[0].Value!=null)
                {

                    res = int.TryParse(dgr.Cells[0].Value.ToString(), out _qty);
                    try
                    {
                        res2 = double.TryParse(dgr.Cells[1].Value.ToString(),out _qtycase);
                    }
                    catch
                    {

                    }
                    
                    if (col==0)
                    {
                        // the item col has been updated
                        dgr.Cells[1].Value = Math.Round(Convert.ToDouble(double.Parse(dgr.Cells[0].Value.ToString()) / selecetedItemCaseqty),2);
                    }

                    if (col == 1)
                    {
                        // the Case col has been updated
                        dgr.Cells[0].Value = Convert.ToDouble(int.Parse(dgr.Cells[1].Value.ToString()) * selecetedItemCaseqty);

                    }






                    if (res==true)
                    {
                        if (_qty>0)
                        {
                            dgr.Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dgr.Cells[0].Style.BackColor = Color.Orange;
                            TableCorrect = false;
                        }
                        totalAssignedQTY = totalAssignedQTY + _qty;
                    }
                    else
                    {
                        dgr.Cells[0].Style.BackColor = Color.Orange;
                        TableCorrect = false;
                    }

                    if (res2 == true)
                    {
                        if (_qtycase > 0)
                        {
                            dgr.Cells[1].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dgr.Cells[1].Style.BackColor = Color.Orange;
                            TableCorrect = false;
                        }
                        //totalAssignedQTY = totalAssignedQTY + _qty;
                    }
                    else
                    {
                        dgr.Cells[1].Style.BackColor = Color.Orange;
                        TableCorrect = false;
                    }

                    string _datestring = dgr.Cells[2].Value.ToString();
                    DateTime DT;
                    res = DateTime.TryParse(_datestring, out DT);
                    if (res == true)
                    {         
                            dgr.Cells[2].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgr.Cells[2].Style.BackColor = Color.Orange;
                        TableCorrect = false;
                    }
                    }
            
            }
            txtUnasignedStock.Text = (int.Parse(txtTotalItems.Text) - totalAssignedQTY).ToString();
            if(TableCorrect==true)
            {
                btnAddInstance.Enabled = true;
            }
            else
            {
                btnAddInstance.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add the Product_Instance of the stock - needs doing
            int prod_inst = logic_global.Add_ProductInstance(_productID, _itemprice, 2);

            //now add the Product_Varient_Location_Stock_qty
            foreach (DataGridViewRow dgr in DG_Data.Rows)
            {
                int _qty = 0;
                double _qtycase = 0;

                bool res = false;
                bool res3 = false;
                if (dgr.Cells[0].Value != null)
                {
                    res = int.TryParse(dgr.Cells[0].Value.ToString(), out _qty);
                    string _datestring = dgr.Cells[2].Value.ToString();
                    DateTime DT;
                    res3 = DateTime.TryParse(_datestring, out DT);

                    if (res == true && res3==true)
                    {
                        string datebuilder = DT.Year.ToString() + "/" + DT.Month.ToString() + "/" + DT.Day.ToString() + " " + DT.Hour.ToString() + ":" + DT.Minute.ToString() + ":" + DT.Second.ToString();
                        int varientid=logic_global.Add_Varient(prod_inst,datebuilder);
                        logic_global.Add_Varient_Stock_Instance(varientid,_qty,1);
                    }
                }

            }
            On_NewProductAdded(this, new EventArgs());
        }

        private void txtCaseCount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCaseCount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateItemPrice();
        }
    }
}
