using System.Reflection.Metadata;

namespace InvoiceTotal_N01530146
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsDecimal(TextBox textBox)
        {
            decimal num = 0m;
            if (Decimal.TryParse(textBox.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Product total should be a decimal number", "Error");
                textBox.Focus();
                return false;
            }
        }

        private bool IsPresent(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Product total should have a value", "Error");
                textBox.Focus();
                return false;
            }
        }

        private bool IsWithinRange(TextBox textBox, int min, int max)
        {
            decimal num = Convert.ToDecimal(textBox.Text);
            if (num >= min && num <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Product total should be within range", "Error");
                textBox.Focus();
                return false;
            }
        }

        private decimal saleTaxPct = 0.0775m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtProductTotal) && IsDecimal(txtProductTotal) && IsWithinRange(txtProductTotal, 0, 1000000000))
            {

            decimal productTotal = Convert.ToDecimal(txtProductTotal.Text);
            decimal discountPercent;

            if (productTotal >= 500)
            {
                discountPercent = 0.2m;
            }else if (productTotal >= 250 && productTotal < 500)
            {
                discountPercent = 0.15m;
            }else if (productTotal >= 100 && productTotal < 250)
            {
                discountPercent = 0.1m;
            }else
            {
                discountPercent = 0;
            }
                decimal discountAmount = discountPercent * productTotal;
                decimal subtotal= productTotal - discountAmount;
                decimal tax = subtotal * saleTaxPct;
                decimal total = subtotal + tax;
                
                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtSubtotal.Text = subtotal.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");
            }
        }

        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            frmSalesTax form2 = new frmSalesTax();
            form2.ShowDialog();
            if (form2.btnOK.DialogResult == DialogResult.OK)
            {
                saleTaxPct = Convert.ToDecimal(form2.Tag) / 100;
                lblTax.Text = "Tax (" + form2.Tag + "%)";
            }
        }
    }
}