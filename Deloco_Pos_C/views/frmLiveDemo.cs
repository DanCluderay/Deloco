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
    public partial class frmLiveDemo : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        public frmLiveDemo()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            logic_global.On_mqtt_new += Logic_global_On_mqtt_new;
        }

        private void Logic_global_On_mqtt_new(object sender, EventArgs e)
        {
            Display_mqttlist();
        }
        private void Display_mqttlist()
        {
            
            if (IsHandleCreated)
            {
                dataGridView1.Invoke((MethodInvoker)(() =>
                {
                    updateGUI();
                }));
            }
            else
            {
                updateGUI();
            }

        }
        private void updateGUI()
        {
            FindOrder("", txtCustomerID.Text);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindOrder("", txtCustomerID.Text);
            //string functionName = "get_customer_order";//from customer ID
            //string functionValues = txtCustomerID.Text;

            ////get the order info
            //string orderinfo = logic_global.Make_db_call(functionName, functionValues);
            //local_datasets.OrderDetails_ds OrderDS = new local_datasets.OrderDetails_ds();
            //DataSet returnedDataSet = new DataSet();
            //returnedDataSet = logic_global.FormatStringToDataTable(functionName, orderinfo);
            ////convert the order text into a dataset
            //OrderDS.Merge(returnedDataSet.Tables["OrderDetails"]);







            //int ORDER_ID = Int32.Parse(OrderDS.OrderDetails.Rows[0]["order_autoid"].ToString());

            //local_datasets.OrderDetails_ds.OrderDetailsRow OrderRow;
            //string FullName = "";
            //FullName = OrderDS.OrderDetails.Rows[0]["CustomerTitle"].ToString() + " " + OrderDS.OrderDetails.Rows[0]["Customer_First_Name"].ToString() + " " + OrderDS.OrderDetails.Rows[0]["Customer_Second_Name"].ToString();

            //txtCustomerName.Text = FullName;
            //txtDeliveryDate.Text = OrderDS.OrderDetails.Rows[0]["delivery_date"].ToString();


            //txtOrderValue.Text = OrderDS.OrderDetails.Rows[0]["ordervalue"].ToString();

            ////display the data

            ////get the orderID

            //functionValues = ORDER_ID.ToString();
            //functionName = "get_customer_order_items";
            ////get the order info
            //string order_items_info = logic_global.Make_db_call(functionName, functionValues);
            //local_datasets.OrderItems_DS OrderItems = new local_datasets.OrderItems_DS();
            //returnedDataSet = new DataSet();//cleare out the old dataset
            //returnedDataSet = logic_global.FormatStringToDataTable(functionName, order_items_info);

            //OrderItems.Merge(returnedDataSet);
            //orderitemsBindingSource.DataSource = OrderItems;
            //orderitemsBindingSource.ResetBindings(false);




        }
        private void FindOrder(string OrderID, string CustomerID)
        {
            string functionName;//from customer ID
            string functionValues;
            int ORDER_ID = 0;
            local_datasets.OrderDetails_ds OrderDS = new local_datasets.OrderDetails_ds();
            DataSet returnedDataSet = new DataSet();
            if (OrderID == ""  && CustomerID == "")
            {
                return;
            }
                if (OrderID == "")
            {
                if (CustomerID != "")
                {
                    functionName = "get_customer_order";
                    functionValues = CustomerID;
                    string orderinfo = logic_global.Make_db_call(functionName, functionValues);


                    returnedDataSet = logic_global.FormatStringToDataTable(functionName, orderinfo);
                    //convert the order text into a dataset
                    OrderDS.Merge(returnedDataSet.Tables["OrderDetails"]);
                    ORDER_ID = Int32.Parse(OrderDS.OrderDetails.Rows[0]["order_autoid"].ToString());
                }
            }
            local_datasets.OrderDetails_ds.OrderDetailsRow OrderRow;
            string FullName = "";
            FullName = OrderDS.OrderDetails.Rows[0]["CustomerTitle"].ToString() + " " + OrderDS.OrderDetails.Rows[0]["Customer_First_Name"].ToString() + " " + OrderDS.OrderDetails.Rows[0]["Customer_Second_Name"].ToString();

            txtCustomerName.Text = FullName;
            txtDeliveryDate.Text = OrderDS.OrderDetails.Rows[0]["delivery_date"].ToString();
            txtLatestOrderID.Text = ORDER_ID.ToString();

            txtOrderValue.Text = OrderDS.OrderDetails.Rows[0]["ordervalue"].ToString();

            //display the data

            //get the orderID

            functionValues = ORDER_ID.ToString();
            functionName = "get_customer_order_items";
            //get the order info
            string order_items_info = logic_global.Make_db_call(functionName, functionValues);
            local_datasets.OrderItems_DS OrderItems = new local_datasets.OrderItems_DS();
            returnedDataSet = new DataSet();//cleare out the old dataset
            returnedDataSet = logic_global.FormatStringToDataTable(functionName, order_items_info);

            OrderItems.Merge(returnedDataSet);
            orderitemsBindingSource.DataSource = OrderItems;
            orderitemsBindingSource.ResetBindings(false);
            txLineCount.Text = dataGridView1.RowCount.ToString();
            AddUpOrderValue();
        }
        private void AddUpOrderValue()
        {

            double orderTotal = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                orderTotal = orderTotal + double.Parse( r.Cells["DealRetail"].Value.ToString());
            }
            txtOrderValue.Text = "£" + orderTotal.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FindOrder(txtCustomerID.Text,"" );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
