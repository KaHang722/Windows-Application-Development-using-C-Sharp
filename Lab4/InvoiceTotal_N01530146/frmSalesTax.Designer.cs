namespace InvoiceTotal_N01530146
{
    partial class frmSalesTax
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
            this.lblSalesTaxPct = new System.Windows.Forms.Label();
            this.txtSalesTaxPct = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalesTaxPct
            // 
            this.lblSalesTaxPct.AutoSize = true;
            this.lblSalesTaxPct.Location = new System.Drawing.Point(121, 176);
            this.lblSalesTaxPct.Name = "lblSalesTaxPct";
            this.lblSalesTaxPct.Size = new System.Drawing.Size(75, 15);
            this.lblSalesTaxPct.TabIndex = 0;
            this.lblSalesTaxPct.Text = "Sales tax pct:";
            // 
            // txtSalesTaxPct
            // 
            this.txtSalesTaxPct.Location = new System.Drawing.Point(203, 172);
            this.txtSalesTaxPct.Name = "txtSalesTaxPct";
            this.txtSalesTaxPct.Size = new System.Drawing.Size(100, 23);
            this.txtSalesTaxPct.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSalesTax
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSalesTaxPct);
            this.Controls.Add(this.lblSalesTaxPct);
            this.Name = "frmSalesTax";
            this.Text = "Sales Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSalesTaxPct;
        private TextBox txtSalesTaxPct;
        private Button btnCancel;
        public Button btnOK;
    }
}