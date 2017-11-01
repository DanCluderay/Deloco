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
    public partial class frmStockManagement : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmStockManagement()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string job = "get_productview_by_prodID";
            string res=  logic_global.Make_db_call(job, "1");
            local_datasets.ProductVarientView ProdView = new local_datasets.ProductVarientView();
            ProdView.Merge( logic_global.FormatStringToDataTable(job, res));
            productVarientView.Clear();
            productVarientView.Merge(ProdView);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stockControlDS.StockControl.Clear();
            stockControlDS.Merge(logic_global.GetAllStock());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0) //productID
            {
                int ProductID = 0;
                ProductID =int.Parse( DG_ProductView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show(ProductID.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Parent table  
            DataTable dtstudent = new DataTable();
            // add column to datatable     
            dtstudent.Columns.Add("Student_ID", typeof(int));
            dtstudent.Columns.Add("Student_Name", typeof(string));
            dtstudent.Columns.Add("Student_RollNo", typeof(string));
            //Child table  
            DataTable dtstudentMarks = new DataTable();
            dtstudentMarks.Columns.Add("Student_ID", typeof(int));
            dtstudentMarks.Columns.Add("Subject_ID", typeof(int));
            dtstudentMarks.Columns.Add("Subject_Name", typeof(string));
            dtstudentMarks.Columns.Add("Marks", typeof(int));
            //Adding Rows  

            dtstudent.Rows.Add(111, "Devesh", "03021013014");
            dtstudent.Rows.Add(222, "ROLI", "0302101444");
            dtstudent.Rows.Add(333, "ROLI Ji", "030212222");
            dtstudent.Rows.Add(444, "NIKHIL", "KANPUR");
            // data for devesh ID=111  
            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);
            dtstudentMarks.Rows.Add(111, "02", "Maths", 77);
            dtstudentMarks.Rows.Add(111, "03", "C#", 100);
            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);
            //data for ROLI ID=222  
            dtstudentMarks.Rows.Add(222, "01", "Physics", 80);
            dtstudentMarks.Rows.Add(222, "02", "English", 95);
            dtstudentMarks.Rows.Add(222, "03", "Commerce", 95);
            dtstudentMarks.Rows.Add(222, "01", "BankPO", 99);

            DataSet dsDataset = new DataSet();
            //Add two DataTables  in Dataset   

            dsDataset.Tables.Add(dtstudent);
            dsDataset.Tables.Add(dtstudentMarks);
            DataRelation Datatablerelation = new DataRelation("DetailsMarks", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[0], true);
            dsDataset.Relations.Add(Datatablerelation);
            dataGridView2.DataSource = dsDataset.Tables[0];
        }
    }
}
