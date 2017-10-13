namespace Deloco_Pos_C.views
{
    partial class frmAddLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocationType = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtLocationPickOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTypes = new Deloco_Pos_C.local_datasets.LocationTypes();
            this.locationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Name";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(91, 36);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(100, 20);
            this.txtLocationName.TabIndex = 1;
            this.txtLocationName.TextChanged += new System.EventHandler(this.txtLocationName_TextChanged);
            this.txtLocationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocationName_KeyPress);
            this.txtLocationName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLocationName_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location Type";
            // 
            // cmbLocationType
            // 
            this.cmbLocationType.DataSource = this.locationTypesBindingSource;
            this.cmbLocationType.DisplayMember = "LocationName";
            this.cmbLocationType.FormattingEnabled = true;
            this.cmbLocationType.Location = new System.Drawing.Point(92, 114);
            this.cmbLocationType.Name = "cmbLocationType";
            this.cmbLocationType.Size = new System.Drawing.Size(99, 21);
            this.cmbLocationType.TabIndex = 4;
            this.cmbLocationType.ValueMember = "LocationTypeID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "AutoName";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtLocationPickOrder
            // 
            this.txtLocationPickOrder.Location = new System.Drawing.Point(92, 141);
            this.txtLocationPickOrder.Name = "txtLocationPickOrder";
            this.txtLocationPickOrder.Size = new System.Drawing.Size(100, 20);
            this.txtLocationPickOrder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pick Order";
            // 
            // locationTypes
            // 
            this.locationTypes.DataSetName = "LocationTypes";
            this.locationTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTypesBindingSource
            // 
            this.locationTypesBindingSource.DataMember = "LocationTypes";
            this.locationTypesBindingSource.DataSource = this.locationTypes;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(91, 10);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.ReadOnly = true;
            this.txtParentName.Size = new System.Drawing.Size(100, 20);
            this.txtParentName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parent Name";
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(281, 10);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.ReadOnly = true;
            this.txtParentID.Size = new System.Drawing.Size(49, 20);
            this.txtParentID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parent ID";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(91, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(239, 20);
            this.txtFullName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Full Name";
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(92, 88);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.ReadOnly = true;
            this.txtShortName.Size = new System.Drawing.Size(100, 20);
            this.txtShortName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Short Name";
            // 
            // frmAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 232);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocationPickOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbLocationType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddLocation";
            this.Text = "Add Location";
            this.Load += new System.EventHandler(this.frmAddLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocationType;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtLocationPickOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource locationTypesBindingSource;
        private local_datasets.LocationTypes locationTypes;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label7;
    }
}