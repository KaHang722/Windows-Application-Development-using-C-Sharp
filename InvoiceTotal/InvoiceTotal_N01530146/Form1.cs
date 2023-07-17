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
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent;

            if (subtotal >= 500)
            {
                discountPercent = 0.2m;
            }else if (subtotal >=250 && subtotal <500)
            {
                discountPercent = 0.15m;
            }else if (subtotal >=100 && subtotal <250)
            {
                discountPercent = 0.1m;
            }else
            {
                discountPercent = 0;
            }


            decimal discountAmount = discountPercent * subtotal;
            decimal total = subtotal - discountAmount;

            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p");
        }
    }
}