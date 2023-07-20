using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace InvoiceTotal_N01530146
{
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
        {
            InitializeComponent();
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
                MessageBox.Show("Sale Tax should be a decimal number", "Error");
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
                MessageBox.Show("Sale Tax should have a value", "Error");
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
                MessageBox.Show("Sale Tax should be within range", "Error");
                textBox.Focus();
                return false;
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtSalesTaxPct) && IsDecimal(txtSalesTaxPct) && IsWithinRange(txtSalesTaxPct, 0, 13))
            {
                btnOK.DialogResult = DialogResult.OK;
                Tag = txtSalesTaxPct.Text;
                this.Close();
            }
        }
    }
}
