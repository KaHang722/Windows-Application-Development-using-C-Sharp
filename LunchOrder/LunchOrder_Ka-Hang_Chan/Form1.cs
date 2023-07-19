using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunchOrder_Ka_Hang_Chan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtOrderTotal.Text = "";
            txtTax.Text = "";
        }

        private void ClearAddOns()
        {
            chkLettuce.Checked = false;
            chkFrenchFries.Checked = false;
            chkKetchup.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            int addons = 0;
            decimal subtotal = 0.0m;
            decimal Tax = 0.0m;
            decimal OrderTotal = 0.0m;

            if (chkLettuce.Checked)
            {
                addons += 1;
            }

            if (chkKetchup.Checked)
            {
                addons += 1;
            }

            if (chkFrenchFries.Checked)
            {
                addons += 1;
            }

            if (radHamburger.Checked)
            {
                decimal Hamburger = 6.95m;

                subtotal = Hamburger + addons * 0.75m;
                Tax = subtotal * 0.0775m;
                OrderTotal = subtotal + Tax;
            }
            else if (radPizza.Checked)
            {
                decimal Pizza = 5.95m;

                subtotal = Pizza + addons * 0.5m;
                Tax = subtotal * 0.0775m;
                OrderTotal = subtotal + Tax;
            }
            else if (radSalad.Checked)
            {
                decimal Salad = 4.95m;

                subtotal = Salad + addons * 0.25m;
                Tax = subtotal * 0.0775m;
                OrderTotal = subtotal + Tax;
            }

            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = Tax.ToString("c");
            txtOrderTotal.Text = OrderTotal.ToString("c");
        }

        private void chkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            if (radHamburger.Checked)
            {
                grbAddOn.Text = "Add-on items ($.75/each)";
                chkLettuce.Text = "Lettuce, tomato, and onions";
                chkKetchup.Text = "Ketchup, mustard, and mayo";
                chkFrenchFries.Text = "French fries";
            }
            else if (radPizza.Checked)
            {
                grbAddOn.Text = "Add-on items ($.5/each)";
                chkLettuce.Text = "Pepperoni";
                chkKetchup.Text = "Sausage";
                chkFrenchFries.Text = "Olives";
            }
            else if (radSalad.Checked)
            {
                grbAddOn.Text = "Add-on items ($.25/each)";
                chkLettuce.Text = "Croutons";
                chkKetchup.Text = "Bacon bits";
                chkFrenchFries.Text = "Bread sticks";
            }
        }
    }
}