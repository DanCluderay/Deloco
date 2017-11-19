namespace Deloco_Pos_C.views
{
    partial class frmAddProductInstance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DG_Data = new System.Windows.Forms.DataGridView();
            this.productInstanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDS = new Deloco_Pos_C.local_datasets.ProductDS();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtCasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCostPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCaseConfig = new System.Windows.Forms.ComboBox();
            this.productCaseConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkAddNewCaseConfig = new System.Windows.Forms.LinkLabel();
            this.linkEditCaseConfig = new System.Windows.Forms.LinkLabel();
            this.tabCase = new System.Windows.Forms.TabControl();
            this.tabAddCase = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewCaseBC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewCaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewCaseQTY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.txtEditCaseID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.txtEditCaseBC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditCaseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditCaseQTY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnasignedStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCaseCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cases_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInstanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCaseConfigBindingSource)).BeginInit();
            this.tabCase.SuspendLayout();
            this.tabAddCase.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(12, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(187, 31);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.Enabled = false;
            this.btnAddInstance.Location = new System.Drawing.Point(174, 417);
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(147, 34);
            this.btnAddInstance.TabIndex = 7;
            this.btnAddInstance.Text = "Add Product";
            this.btnAddInstance.UseVisualStyleBackColor = true;
            this.btnAddInstance.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Main Goods In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fixed Good In Location";
            // 
            // DG_Data
            // 
            this.DG_Data.AutoGenerateColumns = false;
            this.DG_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QTY,
            this.Cases_QTY,
            this.ItemDate});
            this.DG_Data.DataSource = this.productInstanceBindingSource;
            this.DG_Data.Location = new System.Drawing.Point(19, 245);
            this.DG_Data.Name = "DG_Data";
            this.DG_Data.Size = new System.Drawing.Size(302, 132);
            this.DG_Data.TabIndex = 13;
            this.DG_Data.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // productInstanceBindingSource
            // 
            this.productInstanceBindingSource.DataMember = "Product_Instance";
            this.productInstanceBindingSource.DataSource = this.productDS;
            // 
            // productDS
            // 
            this.productDS.DataSetName = "ProductDS";
            this.productDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCasePrice
            // 
            this.txtCasePrice.Location = new System.Drawing.Point(116, 109);
            this.txtCasePrice.Name = "txtCasePrice";
            this.txtCasePrice.Size = new System.Drawing.Size(82, 20);
            this.txtCasePrice.TabIndex = 15;
            this.txtCasePrice.Text = "0";
            this.txtCasePrice.TextChanged += new System.EventHandler(this.txtCasePrice_TextChanged);
            this.txtCasePrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCasePrice_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Case Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Case configeration";
            // 
            // txtItemCostPrice
            // 
            this.txtItemCostPrice.Location = new System.Drawing.Point(116, 186);
            this.txtItemCostPrice.Name = "txtItemCostPrice";
            this.txtItemCostPrice.ReadOnly = true;
            this.txtItemCostPrice.Size = new System.Drawing.Size(82, 20);
            this.txtItemCostPrice.TabIndex = 19;
            this.txtItemCostPrice.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Cost";
            // 
            // cmbCaseConfig
            // 
            this.cmbCaseConfig.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCaseConfig.DataSource = this.productCaseConfigBindingSource;
            this.cmbCaseConfig.DisplayMember = "CaseDescription";
            this.cmbCaseConfig.FormattingEnabled = true;
            this.cmbCaseConfig.Location = new System.Drawing.Point(116, 135);
            this.cmbCaseConfig.Name = "cmbCaseConfig";
            this.cmbCaseConfig.Size = new System.Drawing.Size(121, 21);
            this.cmbCaseConfig.TabIndex = 20;
            this.cmbCaseConfig.ValueMember = "CaseConfigID";
            this.cmbCaseConfig.SelectedIndexChanged += new System.EventHandler(this.cmbCaseConfig_SelectedIndexChanged);
            // 
            // productCaseConfigBindingSource
            // 
            this.productCaseConfigBindingSource.DataMember = "ProductCaseConfig";
            this.productCaseConfigBindingSource.DataSource = this.productDS;
            this.productCaseConfigBindingSource.Filter = "Deleted=0";
            // 
            // linkAddNewCaseConfig
            // 
            this.linkAddNewCaseConfig.AutoSize = true;
            this.linkAddNewCaseConfig.Location = new System.Drawing.Point(243, 138);
            this.linkAddNewCaseConfig.Name = "linkAddNewCaseConfig";
            this.linkAddNewCaseConfig.Size = new System.Drawing.Size(49, 13);
            this.linkAddNewCaseConfig.TabIndex = 21;
            this.linkAddNewCaseConfig.TabStop = true;
            this.linkAddNewCaseConfig.Text = "Create / ";
            this.linkAddNewCaseConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddNewCaseConfig_LinkClicked);
            // 
            // linkEditCaseConfig
            // 
            this.linkEditCaseConfig.AutoSize = true;
            this.linkEditCaseConfig.Location = new System.Drawing.Point(287, 139);
            this.linkEditCaseConfig.Name = "linkEditCaseConfig";
            this.linkEditCaseConfig.Size = new System.Drawing.Size(25, 13);
            this.linkEditCaseConfig.TabIndex = 22;
            this.linkEditCaseConfig.TabStop = true;
            this.linkEditCaseConfig.Text = "Edit";
            this.linkEditCaseConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditCaseConfig_LinkClicked);
            // 
            // tabCase
            // 
            this.tabCase.Controls.Add(this.tabAddCase);
            this.tabCase.Controls.Add(this.tabEdit);
            this.tabCase.Location = new System.Drawing.Point(359, 62);
            this.tabCase.Name = "tabCase";
            this.tabCase.SelectedIndex = 0;
            this.tabCase.Size = new System.Drawing.Size(273, 318);
            this.tabCase.TabIndex = 23;
            // 
            // tabAddCase
            // 
            this.tabAddCase.Controls.Add(this.button2);
            this.tabAddCase.Controls.Add(this.txtNewCaseBC);
            this.tabAddCase.Controls.Add(this.label8);
            this.tabAddCase.Controls.Add(this.txtNewCaseName);
            this.tabAddCase.Controls.Add(this.label7);
            this.tabAddCase.Controls.Add(this.txtNewCaseQTY);
            this.tabAddCase.Controls.Add(this.label6);
            this.tabAddCase.Location = new System.Drawing.Point(4, 22);
            this.tabAddCase.Name = "tabAddCase";
            this.tabAddCase.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCase.Size = new System.Drawing.Size(265, 292);
            this.tabAddCase.TabIndex = 0;
            this.tabAddCase.Text = "Add New Case Configeration";
            this.tabAddCase.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 31);
            this.button2.TabIndex = 34;
            this.button2.Text = "Add Case Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNewCaseBC
            // 
            this.txtNewCaseBC.Location = new System.Drawing.Point(121, 84);
            this.txtNewCaseBC.Name = "txtNewCaseBC";
            this.txtNewCaseBC.Size = new System.Drawing.Size(130, 20);
            this.txtNewCaseBC.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Barcode";
            // 
            // txtNewCaseName
            // 
            this.txtNewCaseName.Location = new System.Drawing.Point(121, 26);
            this.txtNewCaseName.Name = "txtNewCaseName";
            this.txtNewCaseName.Size = new System.Drawing.Size(130, 20);
            this.txtNewCaseName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Case Description";
            // 
            // txtNewCaseQTY
            // 
            this.txtNewCaseQTY.Location = new System.Drawing.Point(121, 52);
            this.txtNewCaseQTY.Name = "txtNewCaseQTY";
            this.txtNewCaseQTY.Size = new System.Drawing.Size(82, 20);
            this.txtNewCaseQTY.TabIndex = 29;
            this.txtNewCaseQTY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Case QTY";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.chkDelete);
            this.tabEdit.Controls.Add(this.txtEditCaseID);
            this.tabEdit.Controls.Add(this.label12);
            this.tabEdit.Controls.Add(this.btnEditSave);
            this.tabEdit.Controls.Add(this.txtEditCaseBC);
            this.tabEdit.Controls.Add(this.label9);
            this.tabEdit.Controls.Add(this.txtEditCaseName);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.txtEditCaseQTY);
            this.tabEdit.Controls.Add(this.label11);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(265, 292);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit Case Configeration";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(75, 155);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 44;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // txtEditCaseID
            // 
            this.txtEditCaseID.Location = new System.Drawing.Point(115, 26);
            this.txtEditCaseID.Name = "txtEditCaseID";
            this.txtEditCaseID.ReadOnly = true;
            this.txtEditCaseID.Size = new System.Drawing.Size(82, 20);
            this.txtEditCaseID.TabIndex = 43;
            this.txtEditCaseID.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Case ID";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(116, 178);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(129, 31);
            this.btnEditSave.TabIndex = 41;
            this.btnEditSave.Text = "Save Case Config";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // txtEditCaseBC
            // 
            this.txtEditCaseBC.Location = new System.Drawing.Point(115, 111);
            this.txtEditCaseBC.Name = "txtEditCaseBC";
            this.txtEditCaseBC.Size = new System.Drawing.Size(130, 20);
            this.txtEditCaseBC.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Barcode";
            // 
            // txtEditCaseName
            // 
            this.txtEditCaseName.Location = new System.Drawing.Point(115, 53);
            this.txtEditCaseName.Name = "txtEditCaseName";
            this.txtEditCaseName.Size = new System.Drawing.Size(130, 20);
            this.txtEditCaseName.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Case Description";
            // 
            // txtEditCaseQTY
            // 
            this.txtEditCaseQTY.Location = new System.Drawing.Point(115, 79);
            this.txtEditCaseQTY.Name = "txtEditCaseQTY";
            this.txtEditCaseQTY.Size = new System.Drawing.Size(82, 20);
            this.txtEditCaseQTY.TabIndex = 36;
            this.txtEditCaseQTY.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Case QTY";
            // 
            // txtUnasignedStock
            // 
            this.txtUnasignedStock.Location = new System.Drawing.Point(115, 383);
            this.txtUnasignedStock.Name = "txtUnasignedStock";
            this.txtUnasignedStock.Size = new System.Drawing.Size(54, 20);
            this.txtUnasignedStock.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Unasigned Stock";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(115, 212);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(82, 20);
            this.txtTotalItems.TabIndex = 42;
            this.txtTotalItems.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Total Items";
            // 
            // txtCaseCount
            // 
            this.txtCaseCount.Location = new System.Drawing.Point(116, 161);
            this.txtCaseCount.Name = "txtCaseCount";
            this.txtCaseCount.Size = new System.Drawing.Size(82, 20);
            this.txtCaseCount.TabIndex = 44;
            this.txtCaseCount.Text = "0";
            this.txtCaseCount.TextChanged += new System.EventHandler(this.txtCaseCount_TextChanged);
            this.txtCaseCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCaseCount_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Case Count";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Pink;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Invoice";
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.QTY.DefaultCellStyle = dataGridViewCellStyle2;
            this.QTY.HeaderText = "Item QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 50;
            // 
            // Cases_QTY
            // 
            this.Cases_QTY.HeaderText = "Case QTY";
            this.Cases_QTY.Name = "Cases_QTY";
            this.Cases_QTY.Width = 50;
            // 
            // ItemDate
            // 
            this.ItemDate.HeaderText = "Date";
            this.ItemDate.Name = "ItemDate";
            // 
            // frmAddProductInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCaseCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUnasignedStock);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabCase);
            this.Controls.Add(this.linkEditCaseConfig);
            this.Controls.Add(this.linkAddNewCaseConfig);
            this.Controls.Add(this.cmbCaseConfig);
            this.Controls.Add(this.txtItemCostPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCasePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddInstance);
            this.Controls.Add(this.lblProductName);
            this.Name = "frmAddProductInstance";
            this.Text = "Add Product Instance";
            this.Load += new System.EventHandler(this.frmAddProductInstance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInstanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCaseConfigBindingSource)).EndInit();
            this.tabCase.ResumeLayout(false);
            this.tabAddCase.ResumeLayout(false);
            this.tabAddCase.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DG_Data;
        private System.Windows.Forms.BindingSource productInstanceBindingSource;
        private local_datasets.ProductDS productDS;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtCasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCaseConfig;
        private System.Windows.Forms.LinkLabel linkAddNewCaseConfig;
        private System.Windows.Forms.LinkLabel linkEditCaseConfig;
        private System.Windows.Forms.TabControl tabCase;
        private System.Windows.Forms.TabPage tabAddCase;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.BindingSource productCaseConfigBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNewCaseBC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewCaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewCaseQTY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.TextBox txtEditCaseBC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditCaseName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditCaseQTY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEditCaseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.TextBox txtUnasignedStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemexpirydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCaseCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cases_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDate;
    }
}