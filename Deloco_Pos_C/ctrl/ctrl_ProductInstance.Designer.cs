namespace Deloco_Pos_C.ctrl
{
    partial class ctrl_ProductInstance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkShowHistorical = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductInstanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_VarientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varientQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockLocationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDS = new Deloco_Pos_C.local_datasets.ProductDS();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioVarientView = new System.Windows.Forms.RadioButton();
            this.radioInstanceView = new System.Windows.Forms.RadioButton();
            this.radioFullView = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeLocationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlDS = new Deloco_Pos_C.local_datasets.StockControlDS();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMoreStock = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockLocationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeLocationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkShowHistorical
            // 
            this.chkShowHistorical.AutoSize = true;
            this.chkShowHistorical.Location = new System.Drawing.Point(14, 59);
            this.chkShowHistorical.Name = "chkShowHistorical";
            this.chkShowHistorical.Size = new System.Drawing.Size(99, 17);
            this.chkShowHistorical.TabIndex = 2;
            this.chkShowHistorical.Text = "Show Historical";
            this.chkShowHistorical.UseVisualStyleBackColor = true;
            this.chkShowHistorical.CheckedChanged += new System.EventHandler(this.chkShowHistorical_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductInstanceID,
            this.Product_VarientID,
            this.varientQTYDataGridViewTextBoxColumn,
            this.itemcostpriceDataGridViewTextBoxColumn,
            this.productBBEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productStockLocationViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(273, 289);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductInstanceID
            // 
            this.ProductInstanceID.DataPropertyName = "ProductInstanceID";
            this.ProductInstanceID.HeaderText = "ProductInstanceID";
            this.ProductInstanceID.Name = "ProductInstanceID";
            this.ProductInstanceID.ReadOnly = true;
            this.ProductInstanceID.Visible = false;
            // 
            // Product_VarientID
            // 
            this.Product_VarientID.DataPropertyName = "Product_VarientID";
            this.Product_VarientID.HeaderText = "Product_VarientID";
            this.Product_VarientID.Name = "Product_VarientID";
            this.Product_VarientID.ReadOnly = true;
            this.Product_VarientID.Visible = false;
            // 
            // varientQTYDataGridViewTextBoxColumn
            // 
            this.varientQTYDataGridViewTextBoxColumn.DataPropertyName = "Varient_QTY";
            this.varientQTYDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.varientQTYDataGridViewTextBoxColumn.Name = "varientQTYDataGridViewTextBoxColumn";
            this.varientQTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.varientQTYDataGridViewTextBoxColumn.Width = 70;
            // 
            // itemcostpriceDataGridViewTextBoxColumn
            // 
            this.itemcostpriceDataGridViewTextBoxColumn.DataPropertyName = "Item_costprice";
            dataGridViewCellStyle1.Format = "C2";
            this.itemcostpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemcostpriceDataGridViewTextBoxColumn.HeaderText = "Cost price";
            this.itemcostpriceDataGridViewTextBoxColumn.Name = "itemcostpriceDataGridViewTextBoxColumn";
            this.itemcostpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcostpriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // productBBEDataGridViewTextBoxColumn
            // 
            this.productBBEDataGridViewTextBoxColumn.DataPropertyName = "ProductBBE";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.productBBEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productBBEDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            this.productBBEDataGridViewTextBoxColumn.Name = "productBBEDataGridViewTextBoxColumn";
            this.productBBEDataGridViewTextBoxColumn.ReadOnly = true;
            this.productBBEDataGridViewTextBoxColumn.Width = 80;
            // 
            // productStockLocationViewBindingSource
            // 
            this.productStockLocationViewBindingSource.DataMember = "Product_Stock_Location_View";
            this.productStockLocationViewBindingSource.DataSource = this.productDS;
            // 
            // productDS
            // 
            this.productDS.DataSetName = "ProductDS";
            this.productDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 535);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock Instances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioVarientView);
            this.panel2.Controls.Add(this.radioInstanceView);
            this.panel2.Controls.Add(this.radioFullView);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.chkShowHistorical);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(121, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 503);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioVarientView
            // 
            this.radioVarientView.AutoSize = true;
            this.radioVarientView.Location = new System.Drawing.Point(616, 55);
            this.radioVarientView.Name = "radioVarientView";
            this.radioVarientView.Size = new System.Drawing.Size(84, 17);
            this.radioVarientView.TabIndex = 14;
            this.radioVarientView.Text = "Varient View";
            this.radioVarientView.UseVisualStyleBackColor = true;
            // 
            // radioInstanceView
            // 
            this.radioInstanceView.AutoSize = true;
            this.radioInstanceView.Location = new System.Drawing.Point(616, 34);
            this.radioInstanceView.Name = "radioInstanceView";
            this.radioInstanceView.Size = new System.Drawing.Size(92, 17);
            this.radioInstanceView.TabIndex = 13;
            this.radioInstanceView.Text = "Instance View";
            this.radioInstanceView.UseVisualStyleBackColor = true;
            // 
            // radioFullView
            // 
            this.radioFullView.AutoSize = true;
            this.radioFullView.Checked = true;
            this.radioFullView.Location = new System.Drawing.Point(616, 11);
            this.radioFullView.Name = "radioFullView";
            this.radioFullView.Size = new System.Drawing.Size(67, 17);
            this.radioFullView.TabIndex = 12;
            this.radioFullView.TabStop = true;
            this.radioFullView.Text = "Full View";
            this.radioFullView.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Location Areas";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationNameDataGridViewTextBoxColumn,
            this.totalQTYDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.TotalValue});
            this.dataGridView3.DataSource = this.storeLocationViewBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(327, 82);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(403, 288);
            this.dataGridView3.TabIndex = 10;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQTYDataGridViewTextBoxColumn
            // 
            this.totalQTYDataGridViewTextBoxColumn.DataPropertyName = "TotalQTY";
            this.totalQTYDataGridViewTextBoxColumn.HeaderText = "Total QTY";
            this.totalQTYDataGridViewTextBoxColumn.Name = "totalQTYDataGridViewTextBoxColumn";
            this.totalQTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQTYDataGridViewTextBoxColumn.Width = 70;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataGridViewCellStyle3.NullValue = "C2";
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Width = 70;
            // 
            // TotalValue
            // 
            this.TotalValue.DataPropertyName = "TotalValue";
            dataGridViewCellStyle4.Format = "C2";
            this.TotalValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalValue.HeaderText = "Total Value";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            this.TotalValue.Width = 70;
            // 
            // storeLocationViewBindingSource
            // 
            this.storeLocationViewBindingSource.DataMember = "Store_Location_View";
            this.storeLocationViewBindingSource.DataSource = this.stockControlDS;
            // 
            // stockControlDS
            // 
            this.stockControlDS.DataSetName = "StockControlDS";
            this.stockControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 16);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(401, 23);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "This tab is about Products Prices and there Best Before and there Quantities\r\n";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddMoreStock);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 503);
            this.panel1.TabIndex = 11;
            // 
            // btnAddMoreStock
            // 
            this.btnAddMoreStock.Enabled = false;
            this.btnAddMoreStock.Location = new System.Drawing.Point(10, 135);
            this.btnAddMoreStock.Name = "btnAddMoreStock";
            this.btnAddMoreStock.Size = new System.Drawing.Size(102, 38);
            this.btnAddMoreStock.TabIndex = 8;
            this.btnAddMoreStock.Text = "Add More Stock with New Date";
            this.btnAddMoreStock.UseVisualStyleBackColor = true;
            this.btnAddMoreStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Store Instances";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Historical";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(498, 344);
            this.dataGridView2.TabIndex = 0;
            // 
            // ctrl_ProductInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrl_ProductInstance";
            this.Size = new System.Drawing.Size(890, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockLocationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeLocationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkShowHistorical;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource productStockLocationViewBindingSource;
        private local_datasets.ProductDS productDS;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource storeLocationViewBindingSource;
        private local_datasets.StockControlDS stockControlDS;
        private System.Windows.Forms.RadioButton radioVarientView;
        private System.Windows.Forms.RadioButton radioInstanceView;
        private System.Windows.Forms.RadioButton radioFullView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInstanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_VarientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn varientQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddMoreStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
    }
}
