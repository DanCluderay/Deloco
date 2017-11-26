namespace Deloco_Pos_C.ctrl
{
    partial class ctrl_MoveStock
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
            this.txtFromSearchBox = new System.Windows.Forms.TextBox();
            this.lstFromSearchBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFromLocation = new System.Windows.Forms.ComboBox();
            this.locationGridFROMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationGrid = new Deloco_Pos_C.local_datasets.LocationGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DG_FromLocations = new System.Windows.Forms.DataGridView();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockVarientLocationsView_FROM_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlDS = new Deloco_Pos_C.local_datasets.StockControlDS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbToLocation = new System.Windows.Forms.ComboBox();
            this.locationGridTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DG_ToLocations = new System.Windows.Forms.DataGridView();
            this.locationNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockVarientLocationsView_TO_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtToSearchBox = new System.Windows.Forms.TextBox();
            this.lstToSearchBox = new System.Windows.Forms.ListBox();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.locationGrid_FROM_LIST_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.locationGridFROMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_FromLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockVarientLocationsView_FROM_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGridTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ToLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockVarientLocationsView_TO_BindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid_FROM_LIST_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromSearchBox
            // 
            this.txtFromSearchBox.Location = new System.Drawing.Point(86, 46);
            this.txtFromSearchBox.Name = "txtFromSearchBox";
            this.txtFromSearchBox.Size = new System.Drawing.Size(197, 20);
            this.txtFromSearchBox.TabIndex = 0;
            this.txtFromSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFromSearchBox_KeyUp);
            // 
            // lstFromSearchBox
            // 
            this.lstFromSearchBox.DataSource = this.locationGrid_FROM_LIST_BindingSource;
            this.lstFromSearchBox.DisplayMember = "FullName";
            this.lstFromSearchBox.FormattingEnabled = true;
            this.lstFromSearchBox.Location = new System.Drawing.Point(17, 77);
            this.lstFromSearchBox.Name = "lstFromSearchBox";
            this.lstFromSearchBox.Size = new System.Drawing.Size(266, 82);
            this.lstFromSearchBox.TabIndex = 1;
            this.lstFromSearchBox.ValueMember = "LocGridID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // cmbFromLocation
            // 
            this.cmbFromLocation.DataSource = this.locationGridFROMBindingSource;
            this.cmbFromLocation.DisplayMember = "LocName";
            this.cmbFromLocation.FormattingEnabled = true;
            this.cmbFromLocation.Location = new System.Drawing.Point(86, 19);
            this.cmbFromLocation.Name = "cmbFromLocation";
            this.cmbFromLocation.Size = new System.Drawing.Size(197, 21);
            this.cmbFromLocation.TabIndex = 3;
            this.cmbFromLocation.ValueMember = "LocGridID";
            this.cmbFromLocation.SelectedIndexChanged += new System.EventHandler(this.cmbFromLocation_SelectedIndexChanged);
            // 
            // locationGridFROMBindingSource
            // 
            this.locationGridFROMBindingSource.DataMember = "Location_Grid";
            this.locationGridFROMBindingSource.DataSource = this.locationGrid;
            // 
            // locationGrid
            // 
            this.locationGrid.DataSetName = "LocationGrid";
            this.locationGrid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // DG_FromLocations
            // 
            this.DG_FromLocations.AllowUserToAddRows = false;
            this.DG_FromLocations.AllowUserToDeleteRows = false;
            this.DG_FromLocations.AutoGenerateColumns = false;
            this.DG_FromLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_FromLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationNameDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.bBEDataGridViewTextBoxColumn});
            this.DG_FromLocations.DataSource = this.stockVarientLocationsView_FROM_BindingSource;
            this.DG_FromLocations.Location = new System.Drawing.Point(17, 195);
            this.DG_FromLocations.Name = "DG_FromLocations";
            this.DG_FromLocations.ReadOnly = true;
            this.DG_FromLocations.Size = new System.Drawing.Size(266, 124);
            this.DG_FromLocations.TabIndex = 10;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTYDataGridViewTextBoxColumn.Width = 50;
            // 
            // bBEDataGridViewTextBoxColumn
            // 
            this.bBEDataGridViewTextBoxColumn.DataPropertyName = "BBE";
            this.bBEDataGridViewTextBoxColumn.HeaderText = "BBE";
            this.bBEDataGridViewTextBoxColumn.Name = "bBEDataGridViewTextBoxColumn";
            this.bBEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bBEDataGridViewTextBoxColumn.Width = 70;
            // 
            // stockVarientLocationsView_FROM_BindingSource
            // 
            this.stockVarientLocationsView_FROM_BindingSource.DataMember = "StockVarientLocations_View";
            this.stockVarientLocationsView_FROM_BindingSource.DataSource = this.stockControlDS;
            // 
            // stockControlDS
            // 
            this.stockControlDS.DataSetName = "StockControlDS";
            this.stockControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFromLocation);
            this.groupBox1.Controls.Add(this.DG_FromLocations);
            this.groupBox1.Controls.Add(this.txtFromSearchBox);
            this.groupBox1.Controls.Add(this.lstFromSearchBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 338);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock Quantities";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbToLocation);
            this.groupBox2.Controls.Add(this.DG_ToLocations);
            this.groupBox2.Controls.Add(this.txtToSearchBox);
            this.groupBox2.Controls.Add(this.lstToSearchBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(480, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 338);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock Quantities";
            // 
            // cmbToLocation
            // 
            this.cmbToLocation.DataSource = this.locationGridTOBindingSource;
            this.cmbToLocation.DisplayMember = "LocName";
            this.cmbToLocation.FormattingEnabled = true;
            this.cmbToLocation.Location = new System.Drawing.Point(88, 19);
            this.cmbToLocation.Name = "cmbToLocation";
            this.cmbToLocation.Size = new System.Drawing.Size(198, 21);
            this.cmbToLocation.TabIndex = 13;
            this.cmbToLocation.ValueMember = "LocGridID";
            // 
            // locationGridTOBindingSource
            // 
            this.locationGridTOBindingSource.DataMember = "Location_Grid";
            this.locationGridTOBindingSource.DataSource = this.locationGrid;
            // 
            // DG_ToLocations
            // 
            this.DG_ToLocations.AllowUserToAddRows = false;
            this.DG_ToLocations.AllowUserToDeleteRows = false;
            this.DG_ToLocations.AutoGenerateColumns = false;
            this.DG_ToLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ToLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationNameDataGridViewTextBoxColumn1,
            this.qTYDataGridViewTextBoxColumn1,
            this.bBEDataGridViewTextBoxColumn1});
            this.DG_ToLocations.DataSource = this.stockVarientLocationsView_TO_BindingSource;
            this.DG_ToLocations.Location = new System.Drawing.Point(19, 195);
            this.DG_ToLocations.Name = "DG_ToLocations";
            this.DG_ToLocations.ReadOnly = true;
            this.DG_ToLocations.Size = new System.Drawing.Size(267, 124);
            this.DG_ToLocations.TabIndex = 14;
            // 
            // locationNameDataGridViewTextBoxColumn1
            // 
            this.locationNameDataGridViewTextBoxColumn1.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn1.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn1.Name = "locationNameDataGridViewTextBoxColumn1";
            this.locationNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qTYDataGridViewTextBoxColumn1
            // 
            this.qTYDataGridViewTextBoxColumn1.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn1.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn1.Name = "qTYDataGridViewTextBoxColumn1";
            this.qTYDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qTYDataGridViewTextBoxColumn1.Width = 50;
            // 
            // bBEDataGridViewTextBoxColumn1
            // 
            this.bBEDataGridViewTextBoxColumn1.DataPropertyName = "BBE";
            this.bBEDataGridViewTextBoxColumn1.HeaderText = "BBE";
            this.bBEDataGridViewTextBoxColumn1.Name = "bBEDataGridViewTextBoxColumn1";
            this.bBEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bBEDataGridViewTextBoxColumn1.Width = 70;
            // 
            // stockVarientLocationsView_TO_BindingSource
            // 
            this.stockVarientLocationsView_TO_BindingSource.DataMember = "StockVarientLocations_View";
            this.stockVarientLocationsView_TO_BindingSource.DataSource = this.stockControlDS;
            // 
            // txtToSearchBox
            // 
            this.txtToSearchBox.Location = new System.Drawing.Point(88, 46);
            this.txtToSearchBox.Name = "txtToSearchBox";
            this.txtToSearchBox.Size = new System.Drawing.Size(198, 20);
            this.txtToSearchBox.TabIndex = 11;
            // 
            // lstToSearchBox
            // 
            this.lstToSearchBox.FormattingEnabled = true;
            this.lstToSearchBox.Location = new System.Drawing.Point(19, 77);
            this.lstToSearchBox.Name = "lstToSearchBox";
            this.lstToSearchBox.Size = new System.Drawing.Size(267, 82);
            this.lstToSearchBox.TabIndex = 12;
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(341, 185);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(117, 53);
            this.btnMoveTo.TabIndex = 13;
            this.btnMoveTo.Text = ">>> Move >>>";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Location = new System.Drawing.Point(341, 259);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(117, 53);
            this.btnMoveBack.TabIndex = 14;
            this.btnMoveBack.Text = "<<< Move <<<";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 435);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnMoveBack);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnMoveTo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Move Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock Moves";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationGrid_FROM_LIST_BindingSource
            // 
            this.locationGrid_FROM_LIST_BindingSource.DataMember = "Location_Grid";
            this.locationGrid_FROM_LIST_BindingSource.DataSource = this.locationGrid;
            // 
            // ctrl_MoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrl_MoveStock";
            this.Size = new System.Drawing.Size(842, 435);
            ((System.ComponentModel.ISupportInitialize)(this.locationGridFROMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_FromLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockVarientLocationsView_FROM_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGridTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ToLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockVarientLocationsView_TO_BindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid_FROM_LIST_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromSearchBox;
        private System.Windows.Forms.ListBox lstFromSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFromLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DG_FromLocations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbToLocation;
        private System.Windows.Forms.DataGridView DG_ToLocations;
        private System.Windows.Forms.TextBox txtToSearchBox;
        private System.Windows.Forms.ListBox lstToSearchBox;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.Button btnMoveBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource locationGridFROMBindingSource;
        private local_datasets.LocationGrid locationGrid;
        private System.Windows.Forms.BindingSource locationGridTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockVarientLocationsView_FROM_BindingSource;
        private local_datasets.StockControlDS stockControlDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource stockVarientLocationsView_TO_BindingSource;
        private System.Windows.Forms.BindingSource locationGrid_FROM_LIST_BindingSource;
    }
}
