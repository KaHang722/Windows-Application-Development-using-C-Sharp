using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private List<Customer> customers = null;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: Add a statement that gets the customers here
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            var c = from Customer customer in customers
                    select customer.GetDisplayText();

            foreach (var customer in c)
            {
                lstCustomers.Items.Add(customer);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer customer = addCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                // TODO: Add a statement that saves the customers here
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i != -1)
            {
                var selectedCustomer = customers[i];
                var c = from Customer customerDelete in customers.ToList()
                        where customerDelete == selectedCustomer
                        select customerDelete;


                foreach (var customer in c)
                {
                    string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";

                    DialogResult button = MessageBox.Show(message, "Confirm Delete",
                        MessageBoxButtons.YesNo);

                    if (button == DialogResult.Yes)
                    {
                        customers.Remove(customer);
                        // TODO: Add a statement that saves the customers here
                        CustomerDB.SaveCustomers(customers);
                        FillCustomerListBox();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
