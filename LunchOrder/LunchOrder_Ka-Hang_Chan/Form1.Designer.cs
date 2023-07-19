namespace LunchOrder_Ka_Hang_Chan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.grbMainCourse = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.grbAddOn = new System.Windows.Forms.GroupBox();
            this.chkFrenchFries = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.grbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMainCourse.SuspendLayout();
            this.grbAddOn.SuspendLayout();
            this.grbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(21, 34);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(124, 19);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // grbMainCourse
            // 
            this.grbMainCourse.Controls.Add(this.radSalad);
            this.grbMainCourse.Controls.Add(this.radPizza);
            this.grbMainCourse.Controls.Add(this.radHamburger);
            this.grbMainCourse.Location = new System.Drawing.Point(116, 69);
            this.grbMainCourse.Name = "grbMainCourse";
            this.grbMainCourse.Size = new System.Drawing.Size(200, 130);
            this.grbMainCourse.TabIndex = 1;
            this.grbMainCourse.TabStop = false;
            this.grbMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(21, 102);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(91, 19);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(21, 68);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(89, 19);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // grbAddOn
            // 
            this.grbAddOn.Controls.Add(this.chkFrenchFries);
            this.grbAddOn.Controls.Add(this.chkKetchup);
            this.grbAddOn.Controls.Add(this.chkLettuce);
            this.grbAddOn.Location = new System.Drawing.Point(432, 69);
            this.grbAddOn.Name = "grbAddOn";
            this.grbAddOn.Size = new System.Drawing.Size(200, 130);
            this.grbAddOn.TabIndex = 2;
            this.grbAddOn.TabStop = false;
            this.grbAddOn.Text = "Add-on items ($.75/each)";
            // 
            // chkFrenchFries
            // 
            this.chkFrenchFries.AutoSize = true;
            this.chkFrenchFries.Location = new System.Drawing.Point(6, 93);
            this.chkFrenchFries.Name = "chkFrenchFries";
            this.chkFrenchFries.Size = new System.Drawing.Size(89, 19);
            this.chkFrenchFries.TabIndex = 2;
            this.chkFrenchFries.Text = "French Fries";
            this.chkFrenchFries.UseVisualStyleBackColor = true;
            this.chkFrenchFries.CheckedChanged += new System.EventHandler(this.chkLettuce_CheckedChanged);
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(6, 58);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(179, 19);
            this.chkKetchup.TabIndex = 1;
            this.chkKetchup.Text = "Ketchup, mustard, and mayo";
            this.chkKetchup.UseVisualStyleBackColor = true;
            this.chkKetchup.CheckedChanged += new System.EventHandler(this.chkLettuce_CheckedChanged);
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Location = new System.Drawing.Point(6, 25);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(179, 19);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Text = "Lettuce, tomator, and onions";
            this.chkLettuce.UseVisualStyleBackColor = true;
            this.chkLettuce.CheckedChanged += new System.EventHandler(this.chkLettuce_CheckedChanged);
            // 
            // grbOrderTotal
            // 
            this.grbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grbOrderTotal.Controls.Add(this.txtTax);
            this.grbOrderTotal.Controls.Add(this.txtSubtotal);
            this.grbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grbOrderTotal.Controls.Add(this.lblTax);
            this.grbOrderTotal.Controls.Add(this.lblSubtotal);
            this.grbOrderTotal.Location = new System.Drawing.Point(116, 263);
            this.grbOrderTotal.Name = "grbOrderTotal";
            this.grbOrderTotal.Size = new System.Drawing.Size(300, 118);
            this.grbOrderTotal.TabIndex = 3;
            this.grbOrderTotal.TabStop = false;
            this.grbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(118, 88);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 23);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(118, 58);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(118, 29);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 3;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(17, 91);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(65, 15);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(17, 61);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 15);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(17, 32);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 15);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(532, 263);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(100, 23);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grbOrderTotal);
            this.Controls.Add(this.grbAddOn);
            this.Controls.Add(this.grbMainCourse);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.grbMainCourse.ResumeLayout(false);
            this.grbMainCourse.PerformLayout();
            this.grbAddOn.ResumeLayout(false);
            this.grbAddOn.PerformLayout();
            this.grbOrderTotal.ResumeLayout(false);
            this.grbOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton radHamburger;
        private GroupBox grbMainCourse;
        private RadioButton radSalad;
        private RadioButton radPizza;
        private GroupBox grbAddOn;
        private CheckBox chkFrenchFries;
        private CheckBox chkKetchup;
        private CheckBox chkLettuce;
        private GroupBox grbOrderTotal;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label lblOrderTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private Button btnPlaceOrder;
        private Button btnExit;
    }
}