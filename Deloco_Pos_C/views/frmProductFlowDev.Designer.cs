namespace Deloco_Pos_C.views
{
    partial class frmProductFlowDev
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
            this.ctrl_edit_prodcut1 = new Deloco_Pos_C.ctrl.ctrl_edit_prodcut();
            this.SuspendLayout();
            // 
            // ctrl_edit_prodcut1
            // 
            this.ctrl_edit_prodcut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_edit_prodcut1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_edit_prodcut1.Name = "ctrl_edit_prodcut1";
            this.ctrl_edit_prodcut1.Size = new System.Drawing.Size(1324, 568);
            this.ctrl_edit_prodcut1.TabIndex = 1;
            this.ctrl_edit_prodcut1.Load += new System.EventHandler(this.ctrl_edit_prodcut1_Load);
            // 
            // frmProductFlowDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 568);
            this.Controls.Add(this.ctrl_edit_prodcut1);
            this.Name = "frmProductFlowDev";
            this.Text = "Product Flow Dev";
            this.Load += new System.EventHandler(this.frmProductFlowDev_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl.ctrl_edit_prodcut ctrl_edit_prodcut1;
    }
}