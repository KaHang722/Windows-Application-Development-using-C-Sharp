using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_KaHang_Chan
{
    public partial class frmDataInput : Form
    {
        public frmDataInput()
        {
            InitializeComponent();
        }

        public string ProductCode;
        public string Description;
        public decimal UnitPrice;
        public int OnHandQuantity;

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            errorMessage += Validator.IsPresent(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());
            errorMessage += Validator.IsPresent(txtOnHand.Text, txtOnHand.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());
            errorMessage += Validator.IsInt32(txtOnHand.Text, txtOnHand.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                ProductCode = txtProductCode.Text;
                Description = txtDescription.Text;
                UnitPrice = Decimal.Parse(txtUnitPrice.Text);
                OnHandQuantity = Int32.Parse(txtOnHand.Text);

                btnAccept.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
