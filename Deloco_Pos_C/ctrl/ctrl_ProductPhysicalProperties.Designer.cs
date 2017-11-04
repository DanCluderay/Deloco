namespace Deloco_Pos_C.ctrl
{
    partial class ctrl_ProductPhysicalProperties
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDS = new Deloco_Pos_C.local_datasets.ProductDS();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnRemoveItemBarcode = new System.Windows.Forms.Button();
            this.btnEditItemBarcode = new System.Windows.Forms.Button();
            this.btnAddNewItemBarcode = new System.Windows.Forms.Button();
            this.txtItemWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemLenght = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVolumetricWeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCase = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBarcodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(3, 195);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(348, 175);
            this.tabControl2.TabIndex = 26;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(340, 149);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Barcodes";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBarcodesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(219, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 170;
            // 
            // productBarcodesBindingSource
            // 
            this.productBarcodesBindingSource.DataMember = "Product_Barcodes";
            this.productBarcodesBindingSource.DataSource = this.productDS;
            // 
            // productDS
            // 
            this.productDS.DataSetName = "ProductDS";
            this.productDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnRemoveItemBarcode);
            this.tabPage8.Controls.Add(this.btnEditItemBarcode);
            this.tabPage8.Controls.Add(this.btnAddNewItemBarcode);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(340, 149);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Add / Edit / Delete";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItemBarcode
            // 
            this.btnRemoveItemBarcode.Location = new System.Drawing.Point(21, 108);
            this.btnRemoveItemBarcode.Name = "btnRemoveItemBarcode";
            this.btnRemoveItemBarcode.Size = new System.Drawing.Size(106, 31);
            this.btnRemoveItemBarcode.TabIndex = 6;
            this.btnRemoveItemBarcode.Text = "Remove";
            this.btnRemoveItemBarcode.UseVisualStyleBackColor = true;
            // 
            // btnEditItemBarcode
            // 
            this.btnEditItemBarcode.Location = new System.Drawing.Point(21, 62);
            this.btnEditItemBarcode.Name = "btnEditItemBarcode";
            this.btnEditItemBarcode.Size = new System.Drawing.Size(106, 31);
            this.btnEditItemBarcode.TabIndex = 5;
            this.btnEditItemBarcode.Text = "Edit";
            this.btnEditItemBarcode.UseVisualStyleBackColor = true;
            // 
            // btnAddNewItemBarcode
            // 
            this.btnAddNewItemBarcode.Location = new System.Drawing.Point(21, 16);
            this.btnAddNewItemBarcode.Name = "btnAddNewItemBarcode";
            this.btnAddNewItemBarcode.Size = new System.Drawing.Size(106, 31);
            this.btnAddNewItemBarcode.TabIndex = 4;
            this.btnAddNewItemBarcode.Text = "Add New";
            this.btnAddNewItemBarcode.UseVisualStyleBackColor = true;
            this.btnAddNewItemBarcode.Click += new System.EventHandler(this.btnAddNewItemBarcode_Click);
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.Location = new System.Drawing.Point(256, 38);
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(44, 20);
            this.txtItemWeight.TabIndex = 23;
            this.txtItemWeight.Text = "0.0";
            this.txtItemWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemWeight_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Weight";
            // 
            // txtItemVolume
            // 
            this.txtItemVolume.Location = new System.Drawing.Point(256, 9);
            this.txtItemVolume.Name = "txtItemVolume";
            this.txtItemVolume.ReadOnly = true;
            this.txtItemVolume.Size = new System.Drawing.Size(44, 20);
            this.txtItemVolume.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Volume";
            // 
            // txtItemLenght
            // 
            this.txtItemLenght.Location = new System.Drawing.Point(76, 57);
            this.txtItemLenght.Name = "txtItemLenght";
            this.txtItemLenght.Size = new System.Drawing.Size(31, 20);
            this.txtItemLenght.TabIndex = 19;
            this.txtItemLenght.Text = "1";
            this.txtItemLenght.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemLenght_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Lenght";
            // 
            // txtItemHeight
            // 
            this.txtItemHeight.Location = new System.Drawing.Point(76, 31);
            this.txtItemHeight.Name = "txtItemHeight";
            this.txtItemHeight.Size = new System.Drawing.Size(31, 20);
            this.txtItemHeight.TabIndex = 17;
            this.txtItemHeight.Text = "1";
            this.txtItemHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemHeight_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item Height";
            // 
            // txtItemidth
            // 
            this.txtItemidth.Location = new System.Drawing.Point(76, 5);
            this.txtItemidth.Name = "txtItemidth";
            this.txtItemidth.Size = new System.Drawing.Size(31, 20);
            this.txtItemidth.TabIndex = 15;
            this.txtItemidth.Text = "1";
            this.txtItemidth.TextChanged += new System.EventHandler(this.txtItemidth_TextChanged);
            this.txtItemidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemidth_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Item Width";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabItem);
            this.tabControl1.Controls.Add(this.tabCase);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 399);
            this.tabControl1.TabIndex = 27;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.label13);
            this.tabItem.Controls.Add(this.comboBox1);
            this.tabItem.Controls.Add(this.label11);
            this.tabItem.Controls.Add(this.txtVolumetricWeight);
            this.tabItem.Controls.Add(this.label12);
            this.tabItem.Controls.Add(this.label10);
            this.tabItem.Controls.Add(this.label9);
            this.tabItem.Controls.Add(this.label8);
            this.tabItem.Controls.Add(this.label7);
            this.tabItem.Controls.Add(this.label6);
            this.tabItem.Controls.Add(this.txtItemVolume);
            this.tabItem.Controls.Add(this.tabControl2);
            this.tabItem.Controls.Add(this.txtItemWeight);
            this.tabItem.Controls.Add(this.label1);
            this.tabItem.Controls.Add(this.label5);
            this.tabItem.Controls.Add(this.txtItemidth);
            this.tabItem.Controls.Add(this.label2);
            this.tabItem.Controls.Add(this.txtItemHeight);
            this.tabItem.Controls.Add(this.label4);
            this.tabItem.Controls.Add(this.label3);
            this.tabItem.Controls.Add(this.txtItemLenght);
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(354, 373);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "Item";
            this.tabItem.UseVisualStyleBackColor = true;
            this.tabItem.Click += new System.EventHandler(this.tabItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Expiry Date Type";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Pink;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No Date",
            "Best Before Date",
            "Used By Date",
            "Expiry Date"});
            this.comboBox1.Location = new System.Drawing.Point(256, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "KG";
            // 
            // txtVolumetricWeight
            // 
            this.txtVolumetricWeight.Location = new System.Drawing.Point(256, 64);
            this.txtVolumetricWeight.Name = "txtVolumetricWeight";
            this.txtVolumetricWeight.ReadOnly = true;
            this.txtVolumetricWeight.Size = new System.Drawing.Size(44, 20);
            this.txtVolumetricWeight.TabIndex = 33;
            this.txtVolumetricWeight.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Volumetric Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "KG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "cm3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "cm";
            // 
            // tabCase
            // 
            this.tabCase.Location = new System.Drawing.Point(4, 22);
            this.tabCase.Name = "tabCase";
            this.tabCase.Padding = new System.Windows.Forms.Padding(3);
            this.tabCase.Size = new System.Drawing.Size(354, 295);
            this.tabCase.TabIndex = 1;
            this.tabCase.Text = "Case";
            this.tabCase.UseVisualStyleBackColor = true;
            // 
            // ctrl_ProductPhysicalProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrl_ProductPhysicalProperties";
            this.Size = new System.Drawing.Size(362, 399);
            this.Load += new System.EventHandler(this.ctrl_ProductPhysicalProperties_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBarcodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtItemWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemLenght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVolumetricWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabCase;
        private System.Windows.Forms.BindingSource productBarcodesBindingSource;
        private local_datasets.ProductDS productDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemoveItemBarcode;
        private System.Windows.Forms.Button btnEditItemBarcode;
        private System.Windows.Forms.Button btnAddNewItemBarcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
