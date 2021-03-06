﻿namespace Deloco_Pos_C.views
{
    partial class frmGlobalStockView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DG_ProductView = new System.Windows.Forms.DataGridView();
            this.FreeStockQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNPStockQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedStockQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSeeMoreLess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delocoProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delocoProductBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(874, 585);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DG_ProductView);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 512);
            this.panel2.TabIndex = 1;
            // 
            // DG_ProductView
            // 
            this.DG_ProductView.AllowUserToAddRows = false;
            this.DG_ProductView.AllowUserToDeleteRows = false;
            this.DG_ProductView.AllowUserToOrderColumns = true;
            this.DG_ProductView.AutoGenerateColumns = false;
            this.DG_ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productFullNameDataGridViewTextBoxColumn,
            this.FreeStockQTY,
            this.SNPStockQTY,
            this.ReservedStockQTY});
            this.DG_ProductView.DataSource = this.delocoProductBindingSource;
            this.DG_ProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_ProductView.Location = new System.Drawing.Point(0, 36);
            this.DG_ProductView.Name = "DG_ProductView";
            this.DG_ProductView.ReadOnly = true;
            this.DG_ProductView.Size = new System.Drawing.Size(546, 476);
            this.DG_ProductView.TabIndex = 0;
            // 
            // FreeStockQTY
            // 
            this.FreeStockQTY.DataPropertyName = "FreeStockQTY";
            this.FreeStockQTY.HeaderText = "FreeStockQTY";
            this.FreeStockQTY.Name = "FreeStockQTY";
            this.FreeStockQTY.ReadOnly = true;
            // 
            // SNPStockQTY
            // 
            this.SNPStockQTY.DataPropertyName = "SNPStockQTY";
            this.SNPStockQTY.HeaderText = "SNPStockQTY";
            this.SNPStockQTY.Name = "SNPStockQTY";
            this.SNPStockQTY.ReadOnly = true;
            // 
            // ReservedStockQTY
            // 
            this.ReservedStockQTY.DataPropertyName = "ReservedStockQTY";
            this.ReservedStockQTY.HeaderText = "ReservedStockQTY";
            this.ReservedStockQTY.Name = "ReservedStockQTY";
            this.ReservedStockQTY.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 36);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(549, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 512);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 36);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(314, 476);
            this.dataGridView3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSeeMoreLess);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 36);
            this.panel4.TabIndex = 1;
            // 
            // btnSeeMoreLess
            // 
            this.btnSeeMoreLess.Location = new System.Drawing.Point(338, 6);
            this.btnSeeMoreLess.Name = "btnSeeMoreLess";
            this.btnSeeMoreLess.Size = new System.Drawing.Size(40, 23);
            this.btnSeeMoreLess.TabIndex = 0;
            this.btnSeeMoreLess.Text = ">";
            this.btnSeeMoreLess.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 41);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get All Stock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Stock";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "old";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Create VAT Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Create Mars Brand";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(218, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "Create product Type";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(218, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "Create product categories";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(218, 253);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 52);
            this.button7.TabIndex = 8;
            this.button7.Text = "Create product sizes";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productFullNameDataGridViewTextBoxColumn
            // 
            this.productFullNameDataGridViewTextBoxColumn.DataPropertyName = "ProductFullName";
            this.productFullNameDataGridViewTextBoxColumn.HeaderText = "ProductFullName";
            this.productFullNameDataGridViewTextBoxColumn.Name = "productFullNameDataGridViewTextBoxColumn";
            this.productFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delocoProductBindingSource
            // 
            this.delocoProductBindingSource.DataSource = typeof(Deloco_Pos_C.base_classes.DelocoProduct);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(218, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 45);
            this.button8.TabIndex = 9;
            this.button8.Text = "Select";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // frmGlobalStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGlobalStockView";
            this.Text = "frmGlobalStockView";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delocoProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DG_ProductView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSeeMoreLess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource delocoProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeStockQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNPStockQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedStockQTY;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}