namespace InvoiceTotal_N01530146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal st = Convert.ToDecimal(txtSubtotal.Text);
                decimal discountPercent = 0m;
                discountPercent = getDiscountPercent(subtotal: st);

                decimal discountAmount = discountPercent * st;
                decimal invoicetotal = st - discountAmount;

                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtDiscountPercent.Text = discountPercent.ToString("p");
                txtTotal.Text = invoicetotal.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private decimal getDiscountPercent(decimal subtotal = 100.0M)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }
            return discountPercent;
        }
    }
}