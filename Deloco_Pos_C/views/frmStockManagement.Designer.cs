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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetchProduct = new System.Windows.Forms.Button();
            this.productVarientView = new Deloco_Pos_C.local_datasets.ProductVarientView();
            this.prodVarViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVarientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productVarientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodVarViewBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Selector";
            // 
            // btnFetchProduct
            // 
            this.btnFetchProduct.Location = new System.Drawing.Point(520, 50);
            this.btnFetchProduct.Name = "btnFetchProduct";
            this.btnFetchProduct.Size = new System.Drawing.Size(122, 30);
            this.btnFetchProduct.TabIndex = 3;
            this.btnFetchProduct.Text = "Get Product Details";
            this.btnFetchProduct.UseVisualStyleBackColor = true;
            this.btnFetchProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // productVarientView
            // 
            this.productVarientView.DataSetName = "ProductVarientView";
            this.productVarientView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodVarViewBindingSource
            // 
            this.prodVarViewBindingSource.DataMember = "ProdVarView";
            this.prodVarViewBindingSource.DataSource = this.productVarientView;
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
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 548);
            this.Controls.Add(this.btnFetchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStockManagement";
            this.Text = "Stock Management Milk example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productVarientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodVarViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}