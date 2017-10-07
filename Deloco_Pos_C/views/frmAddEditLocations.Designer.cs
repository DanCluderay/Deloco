namespace Deloco_Pos_C.views
{
    partial class frmAddEditLocations
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtShopCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtShopID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Name";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(119, 37);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 1;
            // 
            // txtShopCode
            // 
            this.txtShopCode.Location = new System.Drawing.Point(119, 63);
            this.txtShopCode.Name = "txtShopCode";
            this.txtShopCode.Size = new System.Drawing.Size(100, 20);
            this.txtShopCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shop Code";
            // 
            // btnaction
            // 
            this.btnaction.Location = new System.Drawing.Point(283, 138);
            this.btnaction.Name = "btnaction";
            this.btnaction.Size = new System.Drawing.Size(152, 39);
            this.btnaction.TabIndex = 4;
            this.btnaction.Text = "Some Action";
            this.btnaction.UseVisualStyleBackColor = true;
            this.btnaction.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(119, 89);
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.ReadOnly = true;
            this.txtShopID.Size = new System.Drawing.Size(45, 20);
            this.txtShopID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shop ID";
            // 
            // frmAddEditLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 189);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaction);
            this.Controls.Add(this.txtShopCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditLocations";
            this.Text = "frmAddEditLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtShopCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtShopID;
        private System.Windows.Forms.Label label3;
    }
}