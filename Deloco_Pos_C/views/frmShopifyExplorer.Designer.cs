namespace Deloco_Pos_C.views
{
    partial class frmShopifyExplorer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delocoProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preFixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postFixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandInNameDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.brandProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandProductSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRelativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productItemWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productItemLenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productItemHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRealWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productVolumetricWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productShortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLongDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productVateCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerPackQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCasePickDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productItemRRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSLockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLockedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDateTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delocoProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get All Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.brandProductDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productFullNameDataGridViewTextBoxColumn,
            this.preFixDataGridViewTextBoxColumn,
            this.postFixDataGridViewTextBoxColumn,
            this.brandIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.brandInNameDataGridViewCheckBoxColumn,
            this.brandProductNameDataGridViewTextBoxColumn,
            this.brandProductSizeDataGridViewTextBoxColumn,
            this.productRRPDataGridViewTextBoxColumn,
            this.sizeStringDataGridViewTextBoxColumn,
            this.sizeUnitDataGridViewTextBoxColumn,
            this.sizeRelativeDataGridViewTextBoxColumn,
            this.productItemWidthDataGridViewTextBoxColumn,
            this.productItemLenghtDataGridViewTextBoxColumn,
            this.productItemHeightDataGridViewTextBoxColumn,
            this.productTotalVolumeDataGridViewTextBoxColumn,
            this.productRealWeightDataGridViewTextBoxColumn,
            this.productVolumetricWeightDataGridViewTextBoxColumn,
            this.productShortDescriptionDataGridViewTextBoxColumn,
            this.productLongDescriptionDataGridViewTextBoxColumn,
            this.productVateCodeDataGridViewTextBoxColumn,
            this.innerPackQtyDataGridViewTextBoxColumn,
            this.isCasePickDataGridViewCheckBoxColumn,
            this.productItemRRPDataGridViewTextBoxColumn,
            this.iSLockedDataGridViewCheckBoxColumn,
            this.isLockedByDataGridViewTextBoxColumn,
            this.productDateTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.delocoProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(422, 410);
            this.dataGridView1.TabIndex = 2;
            // 
            // delocoProductBindingSource
            // 
            this.delocoProductBindingSource.DataSource = typeof(Deloco_Pos_C.base_classes.DelocoProduct);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandProductDataGridViewTextBoxColumn
            // 
            this.brandProductDataGridViewTextBoxColumn.DataPropertyName = "BrandProduct";
            this.brandProductDataGridViewTextBoxColumn.HeaderText = "BrandProduct";
            this.brandProductDataGridViewTextBoxColumn.Name = "brandProductDataGridViewTextBoxColumn";
            this.brandProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productFullNameDataGridViewTextBoxColumn
            // 
            this.productFullNameDataGridViewTextBoxColumn.DataPropertyName = "ProductFullName";
            this.productFullNameDataGridViewTextBoxColumn.HeaderText = "ProductFullName";
            this.productFullNameDataGridViewTextBoxColumn.Name = "productFullNameDataGridViewTextBoxColumn";
            this.productFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preFixDataGridViewTextBoxColumn
            // 
            this.preFixDataGridViewTextBoxColumn.DataPropertyName = "PreFix";
            this.preFixDataGridViewTextBoxColumn.HeaderText = "PreFix";
            this.preFixDataGridViewTextBoxColumn.Name = "preFixDataGridViewTextBoxColumn";
            this.preFixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postFixDataGridViewTextBoxColumn
            // 
            this.postFixDataGridViewTextBoxColumn.DataPropertyName = "PostFix";
            this.postFixDataGridViewTextBoxColumn.HeaderText = "PostFix";
            this.postFixDataGridViewTextBoxColumn.Name = "postFixDataGridViewTextBoxColumn";
            this.postFixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandIDDataGridViewTextBoxColumn
            // 
            this.brandIDDataGridViewTextBoxColumn.DataPropertyName = "BrandID";
            this.brandIDDataGridViewTextBoxColumn.HeaderText = "BrandID";
            this.brandIDDataGridViewTextBoxColumn.Name = "brandIDDataGridViewTextBoxColumn";
            this.brandIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandInNameDataGridViewCheckBoxColumn
            // 
            this.brandInNameDataGridViewCheckBoxColumn.DataPropertyName = "BrandInName";
            this.brandInNameDataGridViewCheckBoxColumn.HeaderText = "BrandInName";
            this.brandInNameDataGridViewCheckBoxColumn.Name = "brandInNameDataGridViewCheckBoxColumn";
            this.brandInNameDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // brandProductNameDataGridViewTextBoxColumn
            // 
            this.brandProductNameDataGridViewTextBoxColumn.DataPropertyName = "BrandProductName";
            this.brandProductNameDataGridViewTextBoxColumn.HeaderText = "BrandProductName";
            this.brandProductNameDataGridViewTextBoxColumn.Name = "brandProductNameDataGridViewTextBoxColumn";
            this.brandProductNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandProductSizeDataGridViewTextBoxColumn
            // 
            this.brandProductSizeDataGridViewTextBoxColumn.DataPropertyName = "BrandProductSize";
            this.brandProductSizeDataGridViewTextBoxColumn.HeaderText = "BrandProductSize";
            this.brandProductSizeDataGridViewTextBoxColumn.Name = "brandProductSizeDataGridViewTextBoxColumn";
            this.brandProductSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productRRPDataGridViewTextBoxColumn
            // 
            this.productRRPDataGridViewTextBoxColumn.DataPropertyName = "ProductRRP";
            this.productRRPDataGridViewTextBoxColumn.HeaderText = "ProductRRP";
            this.productRRPDataGridViewTextBoxColumn.Name = "productRRPDataGridViewTextBoxColumn";
            this.productRRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeStringDataGridViewTextBoxColumn
            // 
            this.sizeStringDataGridViewTextBoxColumn.DataPropertyName = "SizeString";
            this.sizeStringDataGridViewTextBoxColumn.HeaderText = "SizeString";
            this.sizeStringDataGridViewTextBoxColumn.Name = "sizeStringDataGridViewTextBoxColumn";
            this.sizeStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeUnitDataGridViewTextBoxColumn
            // 
            this.sizeUnitDataGridViewTextBoxColumn.DataPropertyName = "SizeUnit";
            this.sizeUnitDataGridViewTextBoxColumn.HeaderText = "SizeUnit";
            this.sizeUnitDataGridViewTextBoxColumn.Name = "sizeUnitDataGridViewTextBoxColumn";
            this.sizeUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeRelativeDataGridViewTextBoxColumn
            // 
            this.sizeRelativeDataGridViewTextBoxColumn.DataPropertyName = "SizeRelative";
            this.sizeRelativeDataGridViewTextBoxColumn.HeaderText = "SizeRelative";
            this.sizeRelativeDataGridViewTextBoxColumn.Name = "sizeRelativeDataGridViewTextBoxColumn";
            this.sizeRelativeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productItemWidthDataGridViewTextBoxColumn
            // 
            this.productItemWidthDataGridViewTextBoxColumn.DataPropertyName = "ProductItemWidth";
            this.productItemWidthDataGridViewTextBoxColumn.HeaderText = "ProductItemWidth";
            this.productItemWidthDataGridViewTextBoxColumn.Name = "productItemWidthDataGridViewTextBoxColumn";
            this.productItemWidthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productItemLenghtDataGridViewTextBoxColumn
            // 
            this.productItemLenghtDataGridViewTextBoxColumn.DataPropertyName = "ProductItemLenght";
            this.productItemLenghtDataGridViewTextBoxColumn.HeaderText = "ProductItemLenght";
            this.productItemLenghtDataGridViewTextBoxColumn.Name = "productItemLenghtDataGridViewTextBoxColumn";
            this.productItemLenghtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productItemHeightDataGridViewTextBoxColumn
            // 
            this.productItemHeightDataGridViewTextBoxColumn.DataPropertyName = "ProductItemHeight";
            this.productItemHeightDataGridViewTextBoxColumn.HeaderText = "ProductItemHeight";
            this.productItemHeightDataGridViewTextBoxColumn.Name = "productItemHeightDataGridViewTextBoxColumn";
            this.productItemHeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTotalVolumeDataGridViewTextBoxColumn
            // 
            this.productTotalVolumeDataGridViewTextBoxColumn.DataPropertyName = "ProductTotalVolume";
            this.productTotalVolumeDataGridViewTextBoxColumn.HeaderText = "ProductTotalVolume";
            this.productTotalVolumeDataGridViewTextBoxColumn.Name = "productTotalVolumeDataGridViewTextBoxColumn";
            this.productTotalVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productRealWeightDataGridViewTextBoxColumn
            // 
            this.productRealWeightDataGridViewTextBoxColumn.DataPropertyName = "ProductRealWeight";
            this.productRealWeightDataGridViewTextBoxColumn.HeaderText = "ProductRealWeight";
            this.productRealWeightDataGridViewTextBoxColumn.Name = "productRealWeightDataGridViewTextBoxColumn";
            this.productRealWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productVolumetricWeightDataGridViewTextBoxColumn
            // 
            this.productVolumetricWeightDataGridViewTextBoxColumn.DataPropertyName = "ProductVolumetricWeight";
            this.productVolumetricWeightDataGridViewTextBoxColumn.HeaderText = "ProductVolumetricWeight";
            this.productVolumetricWeightDataGridViewTextBoxColumn.Name = "productVolumetricWeightDataGridViewTextBoxColumn";
            this.productVolumetricWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productShortDescriptionDataGridViewTextBoxColumn
            // 
            this.productShortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductShortDescription";
            this.productShortDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductShortDescription";
            this.productShortDescriptionDataGridViewTextBoxColumn.Name = "productShortDescriptionDataGridViewTextBoxColumn";
            this.productShortDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productLongDescriptionDataGridViewTextBoxColumn
            // 
            this.productLongDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductLongDescription";
            this.productLongDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductLongDescription";
            this.productLongDescriptionDataGridViewTextBoxColumn.Name = "productLongDescriptionDataGridViewTextBoxColumn";
            this.productLongDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productVateCodeDataGridViewTextBoxColumn
            // 
            this.productVateCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductVateCode";
            this.productVateCodeDataGridViewTextBoxColumn.HeaderText = "ProductVateCode";
            this.productVateCodeDataGridViewTextBoxColumn.Name = "productVateCodeDataGridViewTextBoxColumn";
            this.productVateCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innerPackQtyDataGridViewTextBoxColumn
            // 
            this.innerPackQtyDataGridViewTextBoxColumn.DataPropertyName = "InnerPackQty";
            this.innerPackQtyDataGridViewTextBoxColumn.HeaderText = "InnerPackQty";
            this.innerPackQtyDataGridViewTextBoxColumn.Name = "innerPackQtyDataGridViewTextBoxColumn";
            this.innerPackQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCasePickDataGridViewCheckBoxColumn
            // 
            this.isCasePickDataGridViewCheckBoxColumn.DataPropertyName = "IsCasePick";
            this.isCasePickDataGridViewCheckBoxColumn.HeaderText = "IsCasePick";
            this.isCasePickDataGridViewCheckBoxColumn.Name = "isCasePickDataGridViewCheckBoxColumn";
            this.isCasePickDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // productItemRRPDataGridViewTextBoxColumn
            // 
            this.productItemRRPDataGridViewTextBoxColumn.DataPropertyName = "ProductItemRRP";
            this.productItemRRPDataGridViewTextBoxColumn.HeaderText = "ProductItemRRP";
            this.productItemRRPDataGridViewTextBoxColumn.Name = "productItemRRPDataGridViewTextBoxColumn";
            this.productItemRRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSLockedDataGridViewCheckBoxColumn
            // 
            this.iSLockedDataGridViewCheckBoxColumn.DataPropertyName = "ISLocked";
            this.iSLockedDataGridViewCheckBoxColumn.HeaderText = "ISLocked";
            this.iSLockedDataGridViewCheckBoxColumn.Name = "iSLockedDataGridViewCheckBoxColumn";
            this.iSLockedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isLockedByDataGridViewTextBoxColumn
            // 
            this.isLockedByDataGridViewTextBoxColumn.DataPropertyName = "IsLockedBy";
            this.isLockedByDataGridViewTextBoxColumn.HeaderText = "IsLockedBy";
            this.isLockedByDataGridViewTextBoxColumn.Name = "isLockedByDataGridViewTextBoxColumn";
            this.isLockedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDateTypeDataGridViewTextBoxColumn
            // 
            this.productDateTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductDateType";
            this.productDateTypeDataGridViewTextBoxColumn.HeaderText = "ProductDateType";
            this.productDateTypeDataGridViewTextBoxColumn.Name = "productDateTypeDataGridViewTextBoxColumn";
            this.productDateTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmShopifyExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmShopifyExplorer";
            this.Text = "frmShopifyExplorer";
            this.Load += new System.EventHandler(this.frmShopifyExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delocoProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preFixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postFixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn brandInNameDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandProductSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productRRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRelativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productItemWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productItemLenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productItemHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productRealWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productVolumetricWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productShortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLongDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productVateCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerPackQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCasePickDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productItemRRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSLockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isLockedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDateTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource delocoProductBindingSource;
    }
}