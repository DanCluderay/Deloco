namespace Deloco_Pos_C
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customersdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersds = new Deloco_Pos_C.customersds();
            this.customersautoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amazon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBillingDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMQTTPush = new System.Windows.Forms.TextBox();
            this.txtMQTTReceive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer_mqtt_notification = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersds)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function";
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(99, 22);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(161, 20);
            this.txtFunction.TabIndex = 2;
            this.txtFunction.Text = "get_customers";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(99, 48);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(161, 20);
            this.txtValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(304, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(391, 84);
            this.txtResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customersautoidDataGridViewTextBoxColumn,
            this.title,
            this.fname,
            this.sname,
            this.postcode,
            this.localshop,
            this.amazon_id,
            this.shippingAddressLine1,
            this.shippingAddressLine2,
            this.shippingTown,
            this.shippingCity,
            this.shippingCounty,
            this.CustomerBillingDayOfWeek});
            this.dataGridView1.DataMember = "Customers";
            this.dataGridView1.DataSource = this.customersdsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(672, 186);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 38);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 388);
            this.panel2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 388);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtFunction);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtValue);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersdsBindingSource
            // 
            this.customersdsBindingSource.DataSource = this.customersds;
            this.customersdsBindingSource.Position = 0;
            // 
            // customersds
            // 
            this.customersds.DataSetName = "customersds";
            this.customersds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersautoidDataGridViewTextBoxColumn
            // 
            this.customersautoidDataGridViewTextBoxColumn.DataPropertyName = "customers_autoid";
            this.customersautoidDataGridViewTextBoxColumn.HeaderText = "customers_autoid";
            this.customersautoidDataGridViewTextBoxColumn.Name = "customersautoidDataGridViewTextBoxColumn";
            this.customersautoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "fname";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "sname";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            // 
            // postcode
            // 
            this.postcode.DataPropertyName = "postcode";
            this.postcode.HeaderText = "postcode";
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            // 
            // localshop
            // 
            this.localshop.DataPropertyName = "localshop";
            this.localshop.HeaderText = "localshop";
            this.localshop.Name = "localshop";
            this.localshop.ReadOnly = true;
            // 
            // amazon_id
            // 
            this.amazon_id.DataPropertyName = "amazon_id";
            this.amazon_id.HeaderText = "amazon_id";
            this.amazon_id.Name = "amazon_id";
            this.amazon_id.ReadOnly = true;
            // 
            // shippingAddressLine1
            // 
            this.shippingAddressLine1.DataPropertyName = "shippingAddressLine1";
            this.shippingAddressLine1.HeaderText = "shippingAddressLine1";
            this.shippingAddressLine1.Name = "shippingAddressLine1";
            this.shippingAddressLine1.ReadOnly = true;
            // 
            // shippingAddressLine2
            // 
            this.shippingAddressLine2.DataPropertyName = "shippingAddressLine2";
            this.shippingAddressLine2.HeaderText = "shippingAddressLine2";
            this.shippingAddressLine2.Name = "shippingAddressLine2";
            this.shippingAddressLine2.ReadOnly = true;
            // 
            // shippingTown
            // 
            this.shippingTown.DataPropertyName = "shippingTown";
            this.shippingTown.HeaderText = "shippingTown";
            this.shippingTown.Name = "shippingTown";
            this.shippingTown.ReadOnly = true;
            // 
            // shippingCity
            // 
            this.shippingCity.DataPropertyName = "shippingCity";
            this.shippingCity.HeaderText = "shippingCity";
            this.shippingCity.Name = "shippingCity";
            this.shippingCity.ReadOnly = true;
            // 
            // shippingCounty
            // 
            this.shippingCounty.DataPropertyName = "shippingCounty";
            this.shippingCounty.HeaderText = "shippingCounty";
            this.shippingCounty.Name = "shippingCounty";
            this.shippingCounty.ReadOnly = true;
            // 
            // CustomerBillingDayOfWeek
            // 
            this.CustomerBillingDayOfWeek.DataPropertyName = "CustomerBillingDayOfWeek";
            this.CustomerBillingDayOfWeek.HeaderText = "CustomerBillingDayOfWeek";
            this.CustomerBillingDayOfWeek.Name = "CustomerBillingDayOfWeek";
            this.CustomerBillingDayOfWeek.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(731, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MQTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Push";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMQTTPush
            // 
            this.txtMQTTPush.Location = new System.Drawing.Point(114, 70);
            this.txtMQTTPush.Name = "txtMQTTPush";
            this.txtMQTTPush.Size = new System.Drawing.Size(100, 20);
            this.txtMQTTPush.TabIndex = 2;
            this.txtMQTTPush.Text = "message";
            // 
            // txtMQTTReceive
            // 
            this.txtMQTTReceive.Location = new System.Drawing.Point(114, 106);
            this.txtMQTTReceive.Name = "txtMQTTReceive";
            this.txtMQTTReceive.Size = new System.Drawing.Size(100, 20);
            this.txtMQTTReceive.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtMQTTReceive);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtMQTTPush);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Calls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServer_mqtt_notification);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(369, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Calls";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "Trigger Server Event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Message";
            // 
            // txtServer_mqtt_notification
            // 
            this.txtServer_mqtt_notification.Location = new System.Drawing.Point(84, 72);
            this.txtServer_mqtt_notification.Name = "txtServer_mqtt_notification";
            this.txtServer_mqtt_notification.Size = new System.Drawing.Size(75, 20);
            this.txtServer_mqtt_notification.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersds)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customersdsBindingSource;
        private customersds customersds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersautoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn localshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn amazon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingCounty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBillingDayOfWeek;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMQTTReceive;
        private System.Windows.Forms.TextBox txtMQTTPush;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServer_mqtt_notification;
        private System.Windows.Forms.Label label4;
    }
}

