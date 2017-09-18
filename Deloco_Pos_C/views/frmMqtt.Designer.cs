namespace Deloco_Pos_C.views
{
    partial class frmMqtt
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMQTTReceive = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMQTTPush = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServer_mqtt_notification = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mqtt_ds = new Deloco_Pos_C.local_datasets.mqtt_ds();
            this.mqttmsgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msgpayloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgTopicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLastUpDated = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mqtt_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mqttmsgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 463);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MQTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(770, 437);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 411);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "MQTT Feed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblLastUpDated);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 359);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "MQTT message List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 46);
            this.panel3.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Go";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Langold",
            "Worksop",
            "Firth Park"});
            this.comboBox1.Location = new System.Drawing.Point(90, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Shop Topic:";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(762, 411);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(762, 411);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "dev";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtMQTTReceive);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtMQTTPush);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Calls";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtMQTTReceive
            // 
            this.txtMQTTReceive.Location = new System.Drawing.Point(114, 106);
            this.txtMQTTReceive.Name = "txtMQTTReceive";
            this.txtMQTTReceive.Size = new System.Drawing.Size(100, 20);
            this.txtMQTTReceive.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Push";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtMQTTPush
            // 
            this.txtMQTTPush.Location = new System.Drawing.Point(114, 70);
            this.txtMQTTPush.Name = "txtMQTTPush";
            this.txtMQTTPush.Size = new System.Drawing.Size(100, 20);
            this.txtMQTTPush.TabIndex = 2;
            this.txtMQTTPush.Text = "message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServer_mqtt_notification);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(310, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Calls";
            // 
            // txtServer_mqtt_notification
            // 
            this.txtServer_mqtt_notification.Location = new System.Drawing.Point(84, 72);
            this.txtServer_mqtt_notification.Name = "txtServer_mqtt_notification";
            this.txtServer_mqtt_notification.Size = new System.Drawing.Size(75, 20);
            this.txtServer_mqtt_notification.TabIndex = 2;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "Trigger Server Event";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msgpayloadDataGridViewTextBoxColumn,
            this.msgTopicDataGridViewTextBoxColumn,
            this.msgdatetimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mqttmsgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // mqtt_ds
            // 
            this.mqtt_ds.DataSetName = "mqtt_ds";
            this.mqtt_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mqttmsgBindingSource
            // 
            this.mqttmsgBindingSource.DataMember = "mqtt_msg";
            this.mqttmsgBindingSource.DataSource = this.mqtt_ds;
            this.mqttmsgBindingSource.CurrentChanged += new System.EventHandler(this.mqttmsgBindingSource_CurrentChanged);
            // 
            // msgpayloadDataGridViewTextBoxColumn
            // 
            this.msgpayloadDataGridViewTextBoxColumn.DataPropertyName = "msgpayload";
            this.msgpayloadDataGridViewTextBoxColumn.HeaderText = "msgpayload";
            this.msgpayloadDataGridViewTextBoxColumn.Name = "msgpayloadDataGridViewTextBoxColumn";
            // 
            // msgTopicDataGridViewTextBoxColumn
            // 
            this.msgTopicDataGridViewTextBoxColumn.DataPropertyName = "msgTopic";
            this.msgTopicDataGridViewTextBoxColumn.HeaderText = "msgTopic";
            this.msgTopicDataGridViewTextBoxColumn.Name = "msgTopicDataGridViewTextBoxColumn";
            // 
            // msgdatetimeDataGridViewTextBoxColumn
            // 
            this.msgdatetimeDataGridViewTextBoxColumn.DataPropertyName = "msgdatetime";
            this.msgdatetimeDataGridViewTextBoxColumn.HeaderText = "msgdatetime";
            this.msgdatetimeDataGridViewTextBoxColumn.Name = "msgdatetimeDataGridViewTextBoxColumn";
            // 
            // lblLastUpDated
            // 
            this.lblLastUpDated.AutoSize = true;
            this.lblLastUpDated.Location = new System.Drawing.Point(19, 316);
            this.lblLastUpDated.Name = "lblLastUpDated";
            this.lblLastUpDated.Size = new System.Drawing.Size(86, 13);
            this.lblLastUpDated.TabIndex = 3;
            this.lblLastUpDated.Text = "Last Updated at:";
            // 
            // frmMqtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMqtt";
            this.Text = "frmMqtt";
            this.Load += new System.EventHandler(this.frmMqtt_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mqtt_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mqttmsgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMQTTReceive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMQTTPush;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServer_mqtt_notification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgpayloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgTopicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mqttmsgBindingSource;
        private local_datasets.mqtt_ds mqtt_ds;
        private System.Windows.Forms.Label lblLastUpDated;
    }
}