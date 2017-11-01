namespace Deloco_Pos_C.ctrl
{
    partial class ctrl_NameBuilder
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkBrandInName = new System.Windows.Forms.CheckBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDS = new Deloco_Pos_C.local_datasets.ProductDS();
            this.txtPostFix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRelativeSize = new System.Windows.Forms.ComboBox();
            this.productSizeUnitsBindingSource_RELATIVE = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.brandProductsBindingSource_combobox = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBrand = new System.Windows.Forms.TabPage();
            this.lstNewBrandSearch = new System.Windows.Forms.ListBox();
            this.BrandsSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddBrandWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewBrand = new System.Windows.Forms.Button();
            this.tabProductType = new System.Windows.Forms.TabPage();
            this.lstBrandProducts = new System.Windows.Forms.ListBox();
            this.brandProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNewBrandProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddNewBrandProduct = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.lstOptions = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUnitSize = new System.Windows.Forms.ComboBox();
            this.productSizeUnitsBindingSource_UNITS = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeUnitsBindingSource_RELATIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandProductsBindingSource_combobox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandsSearchBindingSource)).BeginInit();
            this.tabProductType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandProductsBindingSource)).BeginInit();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeUnitsBindingSource_UNITS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(107, 146);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(60, 20);
            this.txtSize.TabIndex = 30;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            this.txtSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSize_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Size";
            // 
            // chkBrandInName
            // 
            this.chkBrandInName.AutoSize = true;
            this.chkBrandInName.Location = new System.Drawing.Point(107, 95);
            this.chkBrandInName.Name = "chkBrandInName";
            this.chkBrandInName.Size = new System.Drawing.Size(97, 17);
            this.chkBrandInName.TabIndex = 28;
            this.chkBrandInName.Text = "Brand In Name";
            this.chkBrandInName.UseVisualStyleBackColor = true;
            this.chkBrandInName.CheckedChanged += new System.EventHandler(this.chkBrandInName_CheckedChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(107, 13);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(364, 20);
            this.txtFullName.TabIndex = 27;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Full Name";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 68);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Create   ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DataSource = this.brandsBindingSource;
            this.cmbBrand.DisplayMember = "BrandName";
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(107, 65);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(143, 21);
            this.cmbBrand.TabIndex = 21;
            this.cmbBrand.ValueMember = "BrandID";
            this.cmbBrand.DropDown += new System.EventHandler(this.cmbBrand_DropDown);
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.productDS;
            // 
            // productDS
            // 
            this.productDS.DataSetName = "ProductDS";
            this.productDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPostFix
            // 
            this.txtPostFix.Location = new System.Drawing.Point(107, 200);
            this.txtPostFix.Name = "txtPostFix";
            this.txtPostFix.Size = new System.Drawing.Size(143, 20);
            this.txtPostFix.TabIndex = 20;
            this.txtPostFix.TextChanged += new System.EventHandler(this.txtPostFix_TextChanged);
            this.txtPostFix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPostFix_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Postfix";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(107, 39);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(143, 20);
            this.txtPrefix.TabIndex = 18;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            this.txtPrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrefix_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prefix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Relative Size";
            // 
            // cmbRelativeSize
            // 
            this.cmbRelativeSize.DataSource = this.productSizeUnitsBindingSource_RELATIVE;
            this.cmbRelativeSize.DisplayMember = "Unit";
            this.cmbRelativeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelativeSize.FormattingEnabled = true;
            this.cmbRelativeSize.Location = new System.Drawing.Point(173, 173);
            this.cmbRelativeSize.Name = "cmbRelativeSize";
            this.cmbRelativeSize.Size = new System.Drawing.Size(77, 21);
            this.cmbRelativeSize.TabIndex = 31;
            this.cmbRelativeSize.ValueMember = "ID";
            this.cmbRelativeSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productSizeUnitsBindingSource_RELATIVE
            // 
            this.productSizeUnitsBindingSource_RELATIVE.DataMember = "Product_Size_Units";
            this.productSizeUnitsBindingSource_RELATIVE.DataSource = this.productDS;
            this.productSizeUnitsBindingSource_RELATIVE.Filter = "GroupType=1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 122);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create / Edit Type";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbProductType
            // 
            this.cmbProductType.DataSource = this.brandProductsBindingSource_combobox;
            this.cmbProductType.DisplayMember = "ProductName";
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(107, 119);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(143, 21);
            this.cmbProductType.TabIndex = 33;
            this.cmbProductType.ValueMember = "BrandProductID";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            this.cmbProductType.Click += new System.EventHandler(this.cmbProductType_Click);
            // 
            // brandProductsBindingSource_combobox
            // 
            this.brandProductsBindingSource_combobox.DataMember = "Brand_Products";
            this.brandProductsBindingSource_combobox.DataSource = this.productDS;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabBrand);
            this.tabControl1.Controls.Add(this.tabProductType);
            this.tabControl1.Controls.Add(this.tabOptions);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(256, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 241);
            this.tabControl1.TabIndex = 38;
            // 
            // tabBrand
            // 
            this.tabBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBrand.Controls.Add(this.lstNewBrandSearch);
            this.tabBrand.Controls.Add(this.txtAddBrandWeight);
            this.tabBrand.Controls.Add(this.label4);
            this.tabBrand.Controls.Add(this.txtAddBrandName);
            this.tabBrand.Controls.Add(this.label2);
            this.tabBrand.Controls.Add(this.btnAddNewBrand);
            this.tabBrand.Location = new System.Drawing.Point(4, 25);
            this.tabBrand.Name = "tabBrand";
            this.tabBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrand.Size = new System.Drawing.Size(207, 212);
            this.tabBrand.TabIndex = 0;
            this.tabBrand.Text = "Add Brand";
            // 
            // lstNewBrandSearch
            // 
            this.lstNewBrandSearch.DataSource = this.BrandsSearchBindingSource;
            this.lstNewBrandSearch.DisplayMember = "BrandName";
            this.lstNewBrandSearch.FormattingEnabled = true;
            this.lstNewBrandSearch.Location = new System.Drawing.Point(6, 73);
            this.lstNewBrandSearch.Name = "lstNewBrandSearch";
            this.lstNewBrandSearch.Size = new System.Drawing.Size(189, 82);
            this.lstNewBrandSearch.TabIndex = 23;
            this.lstNewBrandSearch.ValueMember = "BrandID";
            // 
            // BrandsSearchBindingSource
            // 
            this.BrandsSearchBindingSource.DataMember = "Brands";
            this.BrandsSearchBindingSource.DataSource = this.productDS;
            // 
            // txtAddBrandWeight
            // 
            this.txtAddBrandWeight.Location = new System.Drawing.Point(86, 41);
            this.txtAddBrandWeight.Name = "txtAddBrandWeight";
            this.txtAddBrandWeight.Size = new System.Drawing.Size(109, 20);
            this.txtAddBrandWeight.TabIndex = 22;
            this.txtAddBrandWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddBrandWeight_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Brand Weight";
            // 
            // txtAddBrandName
            // 
            this.txtAddBrandName.Location = new System.Drawing.Point(86, 15);
            this.txtAddBrandName.Name = "txtAddBrandName";
            this.txtAddBrandName.Size = new System.Drawing.Size(109, 20);
            this.txtAddBrandName.TabIndex = 20;
            this.txtAddBrandName.TextChanged += new System.EventHandler(this.txtAddBrandName_TextChanged);
            this.txtAddBrandName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddBrandName_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Brand Name";
            // 
            // btnAddNewBrand
            // 
            this.btnAddNewBrand.Enabled = false;
            this.btnAddNewBrand.Location = new System.Drawing.Point(6, 174);
            this.btnAddNewBrand.Name = "btnAddNewBrand";
            this.btnAddNewBrand.Size = new System.Drawing.Size(189, 24);
            this.btnAddNewBrand.TabIndex = 0;
            this.btnAddNewBrand.Text = "Add New Brand";
            this.btnAddNewBrand.UseVisualStyleBackColor = true;
            this.btnAddNewBrand.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabProductType
            // 
            this.tabProductType.Controls.Add(this.lstBrandProducts);
            this.tabProductType.Controls.Add(this.txtNewBrandProduct);
            this.tabProductType.Controls.Add(this.label6);
            this.tabProductType.Controls.Add(this.txtNewProductName);
            this.tabProductType.Controls.Add(this.label10);
            this.tabProductType.Controls.Add(this.btnAddNewBrandProduct);
            this.tabProductType.Location = new System.Drawing.Point(4, 25);
            this.tabProductType.Name = "tabProductType";
            this.tabProductType.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductType.Size = new System.Drawing.Size(207, 212);
            this.tabProductType.TabIndex = 1;
            this.tabProductType.Text = "Add Product Type";
            this.tabProductType.UseVisualStyleBackColor = true;
            // 
            // lstBrandProducts
            // 
            this.lstBrandProducts.DataSource = this.brandProductsBindingSource;
            this.lstBrandProducts.DisplayMember = "ProductName";
            this.lstBrandProducts.FormattingEnabled = true;
            this.lstBrandProducts.Location = new System.Drawing.Point(12, 85);
            this.lstBrandProducts.Name = "lstBrandProducts";
            this.lstBrandProducts.Size = new System.Drawing.Size(189, 82);
            this.lstBrandProducts.TabIndex = 32;
            this.lstBrandProducts.ValueMember = "BrandProductID";
            // 
            // brandProductsBindingSource
            // 
            this.brandProductsBindingSource.DataMember = "Brand_Products";
            this.brandProductsBindingSource.DataSource = this.productDS;
            // 
            // txtNewBrandProduct
            // 
            this.txtNewBrandProduct.Location = new System.Drawing.Point(89, 15);
            this.txtNewBrandProduct.Name = "txtNewBrandProduct";
            this.txtNewBrandProduct.ReadOnly = true;
            this.txtNewBrandProduct.Size = new System.Drawing.Size(109, 20);
            this.txtNewBrandProduct.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Brand";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(89, 42);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(109, 20);
            this.txtNewProductName.TabIndex = 27;
            this.txtNewProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewProductName_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Product Name";
            // 
            // btnAddNewBrandProduct
            // 
            this.btnAddNewBrandProduct.Location = new System.Drawing.Point(9, 173);
            this.btnAddNewBrandProduct.Name = "btnAddNewBrandProduct";
            this.btnAddNewBrandProduct.Size = new System.Drawing.Size(189, 24);
            this.btnAddNewBrandProduct.TabIndex = 25;
            this.btnAddNewBrandProduct.Text = "Add New Brand";
            this.btnAddNewBrandProduct.UseVisualStyleBackColor = true;
            this.btnAddNewBrandProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.lstOptions);
            this.tabOptions.Location = new System.Drawing.Point(4, 25);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(207, 212);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // lstOptions
            // 
            this.lstOptions.DataSource = this.brandProductsBindingSource;
            this.lstOptions.DisplayMember = "ProductName";
            this.lstOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOptions.FormattingEnabled = true;
            this.lstOptions.Location = new System.Drawing.Point(0, 0);
            this.lstOptions.Name = "lstOptions";
            this.lstOptions.Size = new System.Drawing.Size(207, 212);
            this.lstOptions.TabIndex = 0;
            this.lstOptions.ValueMember = "BrandProductID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Unit";
            // 
            // cmbUnitSize
            // 
            this.cmbUnitSize.DataSource = this.productSizeUnitsBindingSource_UNITS;
            this.cmbUnitSize.DisplayMember = "Unit";
            this.cmbUnitSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitSize.FormattingEnabled = true;
            this.cmbUnitSize.Location = new System.Drawing.Point(205, 146);
            this.cmbUnitSize.Name = "cmbUnitSize";
            this.cmbUnitSize.Size = new System.Drawing.Size(45, 21);
            this.cmbUnitSize.TabIndex = 39;
            this.cmbUnitSize.ValueMember = "ID";
            this.cmbUnitSize.SelectedIndexChanged += new System.EventHandler(this.cmbUnitSize_SelectedIndexChanged);
            // 
            // productSizeUnitsBindingSource_UNITS
            // 
            this.productSizeUnitsBindingSource_UNITS.DataMember = "Product_Size_Units";
            this.productSizeUnitsBindingSource_UNITS.DataSource = this.productDS;
            this.productSizeUnitsBindingSource_UNITS.Filter = "GroupType=0";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(50, 68);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(56, 13);
            this.linkLabel3.TabIndex = 41;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Edit Brand";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(38, 68);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(18, 13);
            this.linkLabel4.TabIndex = 42;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = " / ";
            // 
            // ctrl_NameBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbUnitSize);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRelativeSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkBrandInName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.txtPostFix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel2);
            this.Name = "ctrl_NameBuilder";
            this.Size = new System.Drawing.Size(489, 293);
            this.Load += new System.EventHandler(this.ctrl_NameBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeUnitsBindingSource_RELATIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandProductsBindingSource_combobox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBrand.ResumeLayout(false);
            this.tabBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandsSearchBindingSource)).EndInit();
            this.tabProductType.ResumeLayout(false);
            this.tabProductType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandProductsBindingSource)).EndInit();
            this.tabOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productSizeUnitsBindingSource_UNITS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkBrandInName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.TextBox txtPostFix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRelativeSize;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private local_datasets.ProductDS productDS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBrand;
        private System.Windows.Forms.TextBox txtAddBrandWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewBrand;
        private System.Windows.Forms.TabPage tabProductType;
        private System.Windows.Forms.ListBox lstBrandProducts;
        private System.Windows.Forms.TextBox txtNewBrandProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddNewBrandProduct;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.ListBox lstOptions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnitSize;
        private System.Windows.Forms.BindingSource brandProductsBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.ListBox lstNewBrandSearch;
        private System.Windows.Forms.BindingSource BrandsSearchBindingSource;
        private System.Windows.Forms.BindingSource brandProductsBindingSource_combobox;
        private System.Windows.Forms.BindingSource productSizeUnitsBindingSource_RELATIVE;
        private System.Windows.Forms.BindingSource productSizeUnitsBindingSource_UNITS;
    }
}
