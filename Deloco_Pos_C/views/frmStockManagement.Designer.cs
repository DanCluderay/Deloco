namespace Deloco_Pos_C.views
{
    partial class frmStockManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVarientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVarViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productVarientView = new Deloco_Pos_C.local_datasets.ProductVarientView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetchProduct = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DG_ProductView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSeeMoreLess = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockForSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSoldNotPickedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockReserveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlDS = new Deloco_Pos_C.local_datasets.StockControlDS();
            this.storeStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserveStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodVarViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productVarientView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.shopNameDataGridViewTextBoxColumn,
            this.prodVarientIDDataGridViewTextBoxColumn,
            this.forSaleDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.soldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodVarViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            // 
            // prodVarientIDDataGridViewTextBoxColumn
            // 
            this.prodVarientIDDataGridViewTextBoxColumn.DataPropertyName = "ProdVarientID";
            this.prodVarientIDDataGridViewTextBoxColumn.HeaderText = "ProdVarientID";
            this.prodVarientIDDataGridViewTextBoxColumn.Name = "prodVarientIDDataGridViewTextBoxColumn";
            // 
            // forSaleDataGridViewTextBoxColumn
            // 
            this.forSaleDataGridViewTextBoxColumn.DataPropertyName = "ForSale";
            this.forSaleDataGridViewTextBoxColumn.HeaderText = "ForSale";
            this.forSaleDataGridViewTextBoxColumn.Name = "forSaleDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // soldDataGridViewTextBoxColumn
            // 
            this.soldDataGridViewTextBoxColumn.DataPropertyName = "Sold";
            this.soldDataGridViewTextBoxColumn.HeaderText = "Sold";
            this.soldDataGridViewTextBoxColumn.Name = "soldDataGridViewTextBoxColumn";
            // 
            // prodVarViewBindingSource
            // 
            this.prodVarViewBindingSource.DataMember = "ProdVarView";
            this.prodVarViewBindingSource.DataSource = this.productVarientView;
            // 
            // productVarientView
            // 
            this.productVarientView.DataSetName = "ProductVarientView";
            this.productVarientView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Selector";
            // 
            // btnFetchProduct
            // 
            this.btnFetchProduct.Location = new System.Drawing.Point(523, 15);
            this.btnFetchProduct.Name = "btnFetchProduct";
            this.btnFetchProduct.Size = new System.Drawing.Size(122, 30);
            this.btnFetchProduct.TabIndex = 3;
            this.btnFetchProduct.Text = "Get Product Details";
            this.btnFetchProduct.UseVisualStyleBackColor = true;
            this.btnFetchProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 595);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnFetchProduct);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "old";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DG_ProductView);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 522);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get All Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(943, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Stock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DG_ProductView
            // 
            this.DG_ProductView.AllowUserToAddRows = false;
            this.DG_ProductView.AllowUserToDeleteRows = false;
            this.DG_ProductView.AllowUserToOrderColumns = true;
            this.DG_ProductView.AutoGenerateColumns = false;
            this.DG_ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn,
            this.stockForSaleDataGridViewTextBoxColumn,
            this.stockSoldNotPickedDataGridViewTextBoxColumn,
            this.stockReserveDataGridViewTextBoxColumn});
            this.DG_ProductView.DataSource = this.stockControlBindingSource;
            this.DG_ProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_ProductView.Location = new System.Drawing.Point(0, 36);
            this.DG_ProductView.Name = "DG_ProductView";
            this.DG_ProductView.ReadOnly = true;
            this.DG_ProductView.Size = new System.Drawing.Size(554, 486);
            this.DG_ProductView.TabIndex = 0;
            this.DG_ProductView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.DG_ProductView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(395, 83);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(384, 204);
            this.dataGrid1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(557, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 522);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIDDataGridViewTextBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.freeStockDataGridViewTextBoxColumn,
            this.soldStockDataGridViewTextBoxColumn,
            this.reserveStockDataGridViewTextBoxColumn,
            this.totalStockDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.storeStockBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 36);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(383, 486);
            this.dataGridView3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSeeMoreLess);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 36);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 36);
            this.panel5.TabIndex = 2;
            // 
            // btnSeeMoreLess
            // 
            this.btnSeeMoreLess.Location = new System.Drawing.Point(288, 6);
            this.btnSeeMoreLess.Name = "btnSeeMoreLess";
            this.btnSeeMoreLess.Size = new System.Drawing.Size(40, 23);
            this.btnSeeMoreLess.TabIndex = 0;
            this.btnSeeMoreLess.Text = ">";
            this.btnSeeMoreLess.UseVisualStyleBackColor = true;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockForSaleDataGridViewTextBoxColumn
            // 
            this.stockForSaleDataGridViewTextBoxColumn.DataPropertyName = "StockForSale";
            this.stockForSaleDataGridViewTextBoxColumn.HeaderText = "StockForSale";
            this.stockForSaleDataGridViewTextBoxColumn.Name = "stockForSaleDataGridViewTextBoxColumn";
            this.stockForSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockSoldNotPickedDataGridViewTextBoxColumn
            // 
            this.stockSoldNotPickedDataGridViewTextBoxColumn.DataPropertyName = "StockSoldNotPicked";
            this.stockSoldNotPickedDataGridViewTextBoxColumn.HeaderText = "StockSoldNotPicked";
            this.stockSoldNotPickedDataGridViewTextBoxColumn.Name = "stockSoldNotPickedDataGridViewTextBoxColumn";
            this.stockSoldNotPickedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockReserveDataGridViewTextBoxColumn
            // 
            this.stockReserveDataGridViewTextBoxColumn.DataPropertyName = "StockReserve";
            this.stockReserveDataGridViewTextBoxColumn.HeaderText = "StockReserve";
            this.stockReserveDataGridViewTextBoxColumn.Name = "stockReserveDataGridViewTextBoxColumn";
            this.stockReserveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockControlBindingSource
            // 
            this.stockControlBindingSource.DataMember = "StockControl";
            this.stockControlBindingSource.DataSource = this.stockControlDS;
            // 
            // stockControlDS
            // 
            this.stockControlDS.DataSetName = "StockControlDS";
            this.stockControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockBindingSource
            // 
            this.storeStockBindingSource.DataMember = "Store_Stock";
            this.storeStockBindingSource.DataSource = this.stockControlDS;
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "Store";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeStockDataGridViewTextBoxColumn
            // 
            this.freeStockDataGridViewTextBoxColumn.DataPropertyName = "FreeStock";
            this.freeStockDataGridViewTextBoxColumn.HeaderText = "Free";
            this.freeStockDataGridViewTextBoxColumn.Name = "freeStockDataGridViewTextBoxColumn";
            this.freeStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.freeStockDataGridViewTextBoxColumn.Width = 60;
            // 
            // soldStockDataGridViewTextBoxColumn
            // 
            this.soldStockDataGridViewTextBoxColumn.DataPropertyName = "SoldStock";
            this.soldStockDataGridViewTextBoxColumn.HeaderText = "SNP";
            this.soldStockDataGridViewTextBoxColumn.Name = "soldStockDataGridViewTextBoxColumn";
            this.soldStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.soldStockDataGridViewTextBoxColumn.Width = 60;
            // 
            // reserveStockDataGridViewTextBoxColumn
            // 
            this.reserveStockDataGridViewTextBoxColumn.DataPropertyName = "ReserveStock";
            this.reserveStockDataGridViewTextBoxColumn.HeaderText = "Reserve";
            this.reserveStockDataGridViewTextBoxColumn.Name = "reserveStockDataGridViewTextBoxColumn";
            this.reserveStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.reserveStockDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalStockDataGridViewTextBoxColumn
            // 
            this.totalStockDataGridViewTextBoxColumn.DataPropertyName = "TotalStock";
            this.totalStockDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalStockDataGridViewTextBoxColumn.Name = "totalStockDataGridViewTextBoxColumn";
            this.totalStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalStockDataGridViewTextBoxColumn.Width = 60;
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStockManagement";
            this.Text = "Stock Management Milk example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodVarViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productVarientView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFetchProduct;
        private System.Windows.Forms.BindingSource prodVarViewBindingSource;
        private local_datasets.ProductVarientView productVarientView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVarientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DG_ProductView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockForSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockSoldNotPickedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockControlBindingSource;
        private local_datasets.StockControlDS stockControlDS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSeeMoreLess;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserveStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storeStockBindingSource;
    }
}