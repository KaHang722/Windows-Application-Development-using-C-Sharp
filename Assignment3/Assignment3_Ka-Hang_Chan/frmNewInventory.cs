using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Ka_Hang_Chan
{
    public partial class frmNewInventory : Form
    {
        public frmNewInventory()
        {
            InitializeComponent();
        }

        private InvItem inventory = null;

        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return inventory;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                inventory = new InvItem(Int32.Parse(txtItemNo.Text), txtDescription.Text, Decimal.Parse(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtItemNo.Text, txtItemNo.Tag.ToString());
            errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            errorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());
            errorMessage += Validator.IsInt32(txtItemNo.Text, txtItemNo.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
