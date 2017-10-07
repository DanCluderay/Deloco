namespace Deloco_Pos_C
{
    partial class frmStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartup));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mQTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.marketingToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.areaManagmentToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // marketingToolStripMenuItem
            // 
            this.marketingToolStripMenuItem.Enabled = false;
            this.marketingToolStripMenuItem.Name = "marketingToolStripMenuItem";
            this.marketingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.marketingToolStripMenuItem.Text = "Marketing";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // viewAllCustomerToolStripMenuItem
            // 
            this.viewAllCustomerToolStripMenuItem.Name = "viewAllCustomerToolStripMenuItem";
            this.viewAllCustomerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewAllCustomerToolStripMenuItem.Text = "View All customer";
            this.viewAllCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewAllCustomerToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockManagerToolStripMenuItem});
            this.productsToolStripMenuItem.Enabled = false;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outstandingOrdersToolStripMenuItem,
            this.salesAnalysisToolStripMenuItem,
            this.pOSToolStripMenuItem,
            this.shopLocationsToolStripMenuItem});
            this.ordersToolStripMenuItem.Enabled = false;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ordersToolStripMenuItem.Text = "Shops";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // outstandingOrdersToolStripMenuItem
            // 
            this.outstandingOrdersToolStripMenuItem.Name = "outstandingOrdersToolStripMenuItem";
            this.outstandingOrdersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.outstandingOrdersToolStripMenuItem.Text = "Alexa Live Demo";
            this.outstandingOrdersToolStripMenuItem.Click += new System.EventHandler(this.outstandingOrdersToolStripMenuItem_Click);
            // 
            // salesAnalysisToolStripMenuItem
            // 
            this.salesAnalysisToolStripMenuItem.Name = "salesAnalysisToolStripMenuItem";
            this.salesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salesAnalysisToolStripMenuItem.Text = "Sales Analysis";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // shopLocationsToolStripMenuItem
            // 
            this.shopLocationsToolStripMenuItem.Name = "shopLocationsToolStripMenuItem";
            this.shopLocationsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.shopLocationsToolStripMenuItem.Text = "Shop Locations";
            this.shopLocationsToolStripMenuItem.Click += new System.EventHandler(this.shopLocationsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Enabled = false;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Enabled = false;
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.managementToolStripMenuItem.Text = "Shop Management";
            // 
            // areaManagmentToolStripMenuItem
            // 
            this.areaManagmentToolStripMenuItem.Enabled = false;
            this.areaManagmentToolStripMenuItem.Name = "areaManagmentToolStripMenuItem";
            this.areaManagmentToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.areaManagmentToolStripMenuItem.Text = "Area Managment";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developmentToolStripMenuItem,
            this.mQTTToolStripMenuItem});
            this.configToolStripMenuItem.Enabled = false;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // developmentToolStripMenuItem
            // 
            this.developmentToolStripMenuItem.Name = "developmentToolStripMenuItem";
            this.developmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.developmentToolStripMenuItem.Text = "Development";
            this.developmentToolStripMenuItem.Click += new System.EventHandler(this.developmentToolStripMenuItem_Click);
            // 
            // mQTTToolStripMenuItem
            // 
            this.mQTTToolStripMenuItem.Name = "mQTTToolStripMenuItem";
            this.mQTTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mQTTToolStripMenuItem.Text = "MQTT";
            this.mQTTToolStripMenuItem.Click += new System.EventHandler(this.mQTTToolStripMenuItem_Click);
            // 
            // stockManagerToolStripMenuItem
            // 
            this.stockManagerToolStripMenuItem.Name = "stockManagerToolStripMenuItem";
            this.stockManagerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.stockManagerToolStripMenuItem.Text = "Stock Manager";
            this.stockManagerToolStripMenuItem.Click += new System.EventHandler(this.stockManagerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStartup";
            this.Text = "Ask the Milkman";
            this.Load += new System.EventHandler(this.frmStartup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mQTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}