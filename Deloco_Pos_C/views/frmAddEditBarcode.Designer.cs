namespace Deloco_Pos_C.views
{
    partial class frmAddEditBarcode
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtCaseQTY = new System.Windows.Forms.TextBox();
            this.lblCaseQTY = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(93, 28);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtBarcode.TabIndex = 3;
            // 
            // txtCaseQTY
            // 
            this.txtCaseQTY.Location = new System.Drawing.Point(93, 54);
            this.txtCaseQTY.Name = "txtCaseQTY";
            this.txtCaseQTY.Size = new System.Drawing.Size(47, 20);
            this.txtCaseQTY.TabIndex = 5;
            // 
            // lblCaseQTY
            // 
            this.lblCaseQTY.AutoSize = true;
            this.lblCaseQTY.Location = new System.Drawing.Point(31, 57);
            this.lblCaseQTY.Name = "lblCaseQTY";
            this.lblCaseQTY.Size = new System.Drawing.Size(56, 13);
            this.lblCaseQTY.TabIndex = 4;
            this.lblCaseQTY.Text = "Case QTY";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(91, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 13);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "ProductName";
            // 
            // frmAddEditBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 116);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtCaseQTY);
            this.Controls.Add(this.lblCaseQTY);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmAddEditBarcode";
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.frmAddEditBarcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtCaseQTY;
        private System.Windows.Forms.Label lblCaseQTY;
        private System.Windows.Forms.Label lblProductName;
    }
}